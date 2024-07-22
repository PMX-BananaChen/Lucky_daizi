using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Lucky
{
    public partial class ImportEmp : Form
    {

        DataAccess DA = new DataAccess();

        public object isInsert=true; 

        public bool YN_Ok = false;      

        delegate void myDel2();

        public ImportEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel文件(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                this.textBox1.Text = filePath;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("请选择导入数据的Execl文件");
            }
            else
            {
                try
                {
                    this.panel2.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                    string filePath = this.textBox1.Text;

                    //用子线程工作
                    Thread Threadnew = new Thread(new ThreadStart(StartDownload));
                    Threadnew.Start();

                    Thread ThreadImport = new Thread(new ParameterizedThreadStart(Import));
                    ThreadImport.Start(filePath);

                    Thread ThreadUpdategrid = new Thread(new ThreadStart(ShowGridview));
                    ThreadUpdategrid.Start();        

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }


        /// <summary>
        /// 查询表名
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static string[] GetExcelSheetNames(OleDbConnection con)
        {
            try
            {
                System.Data.DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new[] { null, null, null, "Table" });//检索Excel的架构信息
                var sheet = new string[dt.Rows.Count];
                for (int i = 0, j = dt.Rows.Count; i < j; i++)
                {
                    //获取的SheetName是带了$的
                    sheet[i] = dt.Rows[i]["TABLE_NAME"].ToString();
                }
                return sheet;
            }
            catch
            {
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportEmp_Load(object sender, EventArgs e)
        {
            //bool UpS = false;
            //UpS = DA.ExecuteSQL(" update EmployeInfo a,LuckyType b set a.Prize=b.LuckyName Where a.Prize=CStr(b.LuckyID);");
            //if (UpS)
            //{
                System.Data.DataTable DT_Emp = DA.GetDataTable("select EmpNo,EmpName,DeptName,CardNo,PlantNo,Prize from EmployeInfo order by Prize desc;");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = DT_Emp;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除所有人員嗎?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DA.ExecuteSQL("delete from EmployeInfo ");
                MessageBox.Show("成功刪除所有人員");
                System.Data.DataTable DT_Emp = DA.GetDataTable(" select EmpNo,EmpName,DeptName,CardNo,PlantNo,EmpInDate from EmployeInfo ");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = DT_Emp;
            }

        }    
     

        //开始下载
        public void StartDownload()
        {
            Downloader downloader = new Downloader();
            downloader.onDownLoadProgress += new Downloader.dDownloadProgress(downloader_onDownLoadProgress);
            downloader.Start();
        }

        //同步更新UI
        void downloader_onDownLoadProgress(long total, long current)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Downloader.dDownloadProgress(downloader_onDownLoadProgress), new object[] { total, current });
            }
            else
            {
                this.progressBar1.Maximum = (int)total;
                this.progressBar1.Value = (int)current;
            }
        }

        //导入文件
        private void Import(object filePath)
        {
            lock (isInsert)
            {

                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath.ToString() + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection con = new OleDbConnection(strConn);
                con.Open();
                string[] names = GetExcelSheetNames(con);
                if (names.Length > 0)
                {

                    //讀取第一個表格

                    string name = names[0].ToString();

                    DataSet ds = new DataSet();
                    OleDbDataAdapter da = new OleDbDataAdapter(string.Format(" select * from [{0}]", name), strConn);
                    OleDbCommandBuilder sqlBulider = new OleDbCommandBuilder(da);
                    da.Fill(ds, "tb");
                    System.Data.DataTable result = ds.Tables["tb"];
                    bool Insert_YN= DA.InsertMore(result, " select EmpNo,EmpName,DeptName,CardNo,PlantNo from EmployeInfo ");
                    if(!Insert_YN)
                    {
                        MessageBox.Show("导入失败,烦请检查一下文件格式!");                      

                    }

                }

                YN_Ok = true;


            }


        }


        //导入文件
        private void ShowGridview()
        {
            lock (isInsert)
            {

                if (YN_Ok)
                {
                    this.Invoke(new myDel2(myShow));   

                }
            }

        }

        //导入文件
        private void myShow()
        {
            System.Data.DataTable DT_Emp = DA.GetDataTable(" select EmpNo,EmpName,DeptName,CardNo,PlantNo,EmpInDate,Prize from EmployeInfo ");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DT_Emp;
            this.panel2.Visible = false;
            this.textBox1.Text = "";
            this.Cursor = Cursors.Default;
            MessageBox.Show("导入成功!");

        }

        /// <summary>
        /// 导出excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
           if(this.dataGridView1.Rows.Count==0)
           {
              MessageBox.Show("没有发现参与抽奖名单!");
              return;
           }
           else
           {
              //导出名单

               this.Cursor = Cursors.WaitCursor;

               //先读取Excel模块,后向模板中填充数据
               string FilePath = System.Windows.Forms.Application.StartupPath + "\\Temp\\export.xls";
               System.Data.DataTable DT_Emp = DA.GetDataTable(" select EmpNo,EmpName,DeptName,CardNo,PlantNo,EmpInDate,'' as Prize from EmployeInfo;");
               ExportExcel(FilePath, DT_Emp);

               this.Cursor = Cursors.Default;

           }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        public void ExportExcel(string strFileName, System.Data.DataTable dt)
        {

            Microsoft.Office.Interop.Excel.Application ThisApplication = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ThisWorkBook;
            object missing = System.Reflection.Missing.Value;
            try
            {
                //加载Excel模板文件
                ThisWorkBook = ThisApplication.Workbooks.Open(strFileName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                Microsoft.Office.Interop.Excel.Worksheet ThisSheet = (Microsoft.Office.Interop.Excel.Worksheet)ThisWorkBook.Sheets[2];
                ThisApplication.Visible = false;

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    DataRow dr = dt.Rows[j];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ThisSheet.Cells[j + 2, i + 1] = dr[i].ToString();

                    }

                }


                //弹出另存对话框

                string FileName = "Employee" + DateTime.Now.ToString("yyyyMMddhhmmss");

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "xls";
                saveDialog.Filter = "Excel文件|*.xls";
                saveDialog.FileName = FileName;
                saveDialog.ShowDialog();

                //更新数据后另存为新文件
                ThisSheet.SaveAs(saveDialog.FileName, missing, missing, missing, missing, missing, missing, missing, missing);

                MessageBox.Show("成功导出!");

            }
            catch
            {



            }
            finally
            {
                ThisApplication.Quit();
                ThisWorkBook = null;
                ThisApplication = null;
               
            }

            //try
            //{
            //    //打开刚才生成的Excel文件
            //    Microsoft.Office.Interop.Excel.Workbook NewWorkBook;
            //    NewWorkBook = NewApplication.Workbooks.Open(strFileName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
            //    Microsoft.Office.Interop.Excel.Worksheet NewSheet = (Microsoft.Office.Interop.Excel.Worksheet)NewWorkBook.Sheets[1];
            //    NewApplication.Visible = true;
            //    //也可以使用System.Diagnostics.Process.Start(strSaveFileName);来打开新文件
            //}


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("没有发现参与抽奖名单!");
                return;
            }
            else
            {
                //导出中獎人員名单

                this.Cursor = Cursors.WaitCursor;

                //先读取Excel模块,后向模板中填充数据
                string FilePath = System.Windows.Forms.Application.StartupPath + "\\Temp\\export.xls";
                System.Data.DataTable DT_Emp = DA.GetDataTable(" select EmpNo,EmpName,DeptName,CardNo,PlantNo,EmpInDate,LuckyName as Prize from EmployeInfo,LuckyType where Prize is not null and Prize<>'' order by LuckyID;");
                ExportExcel(FilePath, DT_Emp);

                this.Cursor = Cursors.Default;

            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// 下载类（您的复杂处理类）
    /// </summary>
    public class Downloader
    {
        //委托
        public delegate void dDownloadProgress(long total, long current);
        //事件
        public event dDownloadProgress onDownLoadProgress;
        //开始模拟工作
        public void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                if (onDownLoadProgress != null)
                    onDownLoadProgress(100, i);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
    

}
