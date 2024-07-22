using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class ImportHR : Form
    {
        public ImportHR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();

            openFileDialog1.Filter = "表格文件 (*.xls)|*.xls";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Import(openFileDialog1.FileName);
            }

        }

        /// <summary>
        /// 导入excel数据
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool Import(string filePath)
        {
            try
            {
                //Excel就好比一个数据源一般使用
                //这里可以根据判断excel文件是03的还是07的，然后写相应的连接字符串
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection con = new OleDbConnection(strConn);
                con.Open();
                string[] names = GetExcelSheetNames(con);
                if (names.Length > 0)
                {
                    foreach (string name in names)
                    {
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandText = string.Format(" select * from [{0}]", name);//[sheetName]要如此格式
                        OleDbDataReader odr = cmd.ExecuteReader();
                        while (odr.Read())
                        {
                            if (odr[0].ToString() == "序号")//过滤列头  按你的实际Excel文件
                                continue;
                            //数据库添加操作
                            /*进行非法值的判断
                             * 添加数据到数据表中
                             * 添加数据时引用事物机制，避免部分数据提交
                             * Add(odr[1].ToString(), odr[2].ToString(), odr[3].ToString());//数据库添加操作，Add方法自己写的
                             * */

                        }
                        odr.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
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

      
    }
}
