using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class EmployeeGet : Form
    {

        DataAccess DA = new DataAccess();

        public EmployeeGet()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if(e.KeyCode== Keys.Enter)
            {

                if(this.txt_CardNo.Text=="")
                {
                    return;
                }

                string CardNo = this.txt_CardNo.Text;

                //判断此卡是否已在抽奖名单中

                DataTable DT_Employee = DA.GetDataTable("select EmpNo,EmpName,DeptName,CardNo,PlantNo from EmployeInfo where Cardno='" + CardNo + "'");

                if(DT_Employee.Rows.Count >0)
                {

                    MessageBox.Show("名单已存在抽奖箱,每个人仅一次抽奖机会!");
                    this.txt_CardNo.Text = "";
                    this.txt_CardNo.Focus();

                    return;

                }

                //判断此卡号是否有效

                DataTable DT_EmployeeHR = DA.GetDataTable("select EmpNo,EmpName,DeptPrintShotName,ICCardNo from EmployeInfo where ICCardNo='" + CardNo + "'");

                if (DT_EmployeeHR.Rows.Count > 0)
                {

                    string empNo = DT_EmployeeHR.Rows[0][0].ToString();
                    string EmpName = DT_EmployeeHR.Rows[0][1].ToString();
                    string DeptPrintShotName = DT_EmployeeHR.Rows[0][2].ToString();
                    string ICCardNo = DT_EmployeeHR.Rows[0][3].ToString();
                    string PlantNo = DT_EmployeeHR.Rows[0][4].ToString();

                    DA.ExecuteSQL("insert into EmployeInfo (EmpNo,EmpName,DeptName,CardNo,PlantNo) values('" + empNo + "','" + EmpName + "','" + DeptPrintShotName + "','" + ICCardNo + "','"+PlantNo+"') ");

                    //this.label2.Visible = true;
                    //this.label2.Text = "添加成功!";
                    this.txt_CardNo.Text = "";
                    this.txt_CardNo.Focus();

                }
                else
                {
                    MessageBox.Show("人事系统不存在此人或此卡为无效卡,请核查!");
                    this.txt_CardNo.Text = "";
                    this.txt_CardNo.Focus();
                    return;

                }  


            
            
            }


        }

        private void Employee_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();


            }

        }

    }
}
