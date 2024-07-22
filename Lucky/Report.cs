using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class Report : Form
    {

        DataAccess DA = new DataAccess();

        public Report()
        {

            InitializeComponent();


        }
        /// <summary>
        /// 加载奖项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Report_Load(object sender, EventArgs e)
        {
            //綁定所有設定的獎項
            DataTable DT_LuckyType = DA.GetDataTable("select LuckyID,LuckyName from LuckyType where LuckyID<>8 union all select distinct 0,'全部' from LuckyType where 1=1;");//where Active<>'0'


            this.combox_LuckyType.DataSource = DT_LuckyType;
            this.combox_LuckyType.DisplayMember = "LuckyName";
            this.combox_LuckyType.ValueMember = "LuckyID";
            this.combox_LuckyType.SelectedIndex = 0;
          

            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost =true;

        }


        /// <summary>
        ///  导出名单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Export_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //设置文件类型  

            //设置文件名称：
            saveFileDialog1.FileName = this.combox_LuckyType.Text.Replace(" ", "") + ".pdf";

            //设置默认文件类型显示顺序  
            //saveFileDialog1.FilterIndex = 2;

            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;

            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径  
                string localFilePath = saveFileDialog1.FileName.ToString();
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] reportBytes = this.reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                //FileStream fs = new FileStream(System.Environment.CurrentDirectory + "\\PDF\\" + this.combox_LuckyType.Text.Replace(" ", "") + ".pdf", FileMode.Create);
                FileStream fs = new FileStream(localFilePath, FileMode.Create);
                fs.Write(reportBytes, 0, reportBytes.Length);
                fs.Close();
                MessageBox.Show(this.combox_LuckyType.Text.Replace(" ", "") + "人员名单成功导出!", "Info");

            }




        }


        private void button2_Click(object sender, EventArgs e)
        {

            //未中奖人员名单
            string SQLStr = "";
         
                if (this.combox_LuckyType.SelectedText== "全部" || this.combox_LuckyType.SelectedText=="")
                {
                            if (this.combox_LuckyType.SelectedIndex >=0)
                            {
                              SQLStr = "select PlantNo,EmpNo,EmpName,DeptName,Prize as Winner from [EmployeInfo] where Prize='" + this.combox_LuckyType.SelectedValue + "'";
                            }
                            else
                            { 
                             SQLStr = "select PlantNo,EmpNo,EmpName,DeptName,Prize as Winner from [EmployeInfo] where Prize is not null and Prize<>'';";
                            }
                }
                else
                {

                    SQLStr = "select PlantNo,EmpNo,EmpName,DeptName,Prize as Winner from [EmployeInfo] where Prize='" + this.combox_LuckyType.SelectedValue + "'";

                }

            
            //if(this.combox_LuckyType.Text =="未中奖人员")
            //{
            //    SQLStr = "select EmpNo,EmpName,DeptName,'未中奖人员' as Winner from EmployeInfo where A is null and B is null ";

            //}

            DataTable DT_Winner = DA.GetDataTable(SQLStr);
            if (DT_Winner.Rows.Count > 0)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", DT_Winner));
                this.reportViewer1.RefreshReport();
                this.Export.Visible = true;
            }
            else
            {
                this.Export.Visible = false;
                MessageBox.Show("无人中此奖!");
                return;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
