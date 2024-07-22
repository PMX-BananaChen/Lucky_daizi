using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Lucky
{
    public partial class WinnerForm : Form
    {

        DataAccess DA = new DataAccess();

        public string ccdj { get; set; } //等级
        public string LuckyID { get; set; } //等级

        public List<Winner> Winners {get; set;}

        int lblInfoY = 1;//頁數
        public WinnerForm(string ccdj , List<Winner> Winners,string LuckyID)
        {
            this.ccdj = ccdj;
            this.LuckyID = LuckyID;
            this.Winners = Winners;
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //窗体加载
        private void WinnerForm_Load(object sender, EventArgs e)
        {

           switch(this.ccdj)
            {
                case "三   等   奖":
                    this.lbldj.Top = 200;
                    this.lbldj.Font = new Font("宋体",40, FontStyle.Bold);
                    break;
                case "二   等   奖":
                    this.lbldj.Top = 200;
                    this.lbldj.Font = new Font("宋体", 40, FontStyle.Bold);
                    break;
                case "一   等   奖":
                    this.lbldj.Top = 230;
                    this.lbldj.Font = new Font("宋体", 45, FontStyle.Bold);
                    break;
            }
           this.lbldj.Text = this.ccdj;

        //this.lbldj.Text = this.ccdj;
        //要實現跑馬燈效果
        //   timer1.Start();
        // runDate();
        //if (Winners.Count > 50)//人多300多,所有字體變小些
        //{
        //    DGOK.Font=new Font("宋体", 12, FontStyle.Bold); //第一个是字体，第二个大小，第三个是样式，
        //}
        //t1 = new Thread((abc) =>
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            // LabelRun();
        //            Timer_Elapsed();
        //        }
        //        catch
        //        {

        //        }
        //        Thread.Sleep(30000);
        //    }
        //})
        //{
        //    IsBackground = true
        //};
        //t1.Start();
        // timer1.Start();
            lblInfoY = 1;
            if (Winners.Count>= 7)
            {
                FactoryOK.AutoSize = false;
                FactoryOK.Height = 540;
                FactoryOK.Width = 800;
                displayDL7();//10行以頁
            }
            else
            {
                FactoryOK.AutoSize = true;
                displayDL();//10行以頁
            }
            //if (this.ccdj.Replace(" ","") == "四等奖")
            //{
            //    timer1.Interval = 3000;
            //}
            //else
            //{
            //    timer1.Interval = 2000;

            //}
            if(Winners.Count>7)
            {
                labPage.Text = "(1/" + (Winners.Count / 7 + 1).ToString()+")";
            }
            
            timer1.Enabled = true;
            
        }

        private void labrun()
        {
            
            string FOk = "";
            string Dpart = "";
            string Names = "";
            int LenJ = 0;
            for (int i = 0; i < 7; i++)
            {
                if ((lblInfoY-1) * 7 + i >= Winners.Count)
                {
                    break;
                 }

                ////重複不加入
                //if (ContentOK.Text.Contains(Winners[lblInfoY * 7 + i].empNo))
                //    continue;

                switch (Winners[(lblInfoY - 1)* 7+i].PlantNo)
                    {
                        case "DG":
                        FOk += "东莞".PadRight(6);
                            break;
                        case "CQ":
                        FOk += "重庆".PadRight(6);
                        break;
                        case "KS":
                        FOk += "昆山".PadRight(6);
                        break;
                    }
                LenJ = ReturnChinaFont(Winners[(lblInfoY - 1) * 7 + i].DeptName);
                if (Winners[(lblInfoY - 1) * 7 + i].DeptName.Length <= 20)
                {
                    if (Winners[(lblInfoY - 1) * 7 + i].DeptName.Length == 20)
                    {
                        Dpart = Winners[(lblInfoY - 1) * 7 + i].DeptName.Substring(0, Winners[(lblInfoY - 1) * 7 + i].DeptName.Length - LenJ);
                    }
                    else
                    {
                        Dpart = Winners[(lblInfoY - 1) * 7 + i].DeptName;
                    }
                     
                }
                else
                {
                    Dpart = Winners[(lblInfoY - 1) * 7 + i].DeptName.Substring(0, 17-LenJ);
                }

                if (Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Length < 3)
                {
                    if(Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Length==2)
                    {
                        Names = Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Substring(0,1)+"  " + Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Substring(1,1);
                        Names = Names.PadRight(8);
                    }
                    else
                    {

                        Names = Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().PadRight(8);
                    }
                  
                }
                else
                {
                    if (Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Length > 8)
                    {
                        Names = Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().Substring(0,6).PadRight(7)+"   ";
                    }
                    else
                    {
                        Names = Winners[(lblInfoY - 1) * 7 + i].EmpName.Trim().PadRight(7);
                    }
                       
                }

                FOk +=  Winners[(lblInfoY - 1) * 7 + i].empNo.PadRight(10)  + Names + Dpart + "\r\n\r\n";
            }
            if(FOk!="")
            {
                FactoryOK.Text = FOk;
            }
        }

        private void displayDL()
        {
            string Dpart = "";
            string Names = "";
            int LenJ = 0;//要除去中文汉字的长度
            if (FactoryOK.Text == "")
            {
                if (Winners.Count == 1) //一等奖
                {
                    FactoryOK.Top = FactoryOK.Top + 100;
                    FactoryOK.Font = new Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    for (int i = 0; i < Winners.Count; i++)
                    {
                        switch (Winners[i].PlantNo)
                        {
                            case "DG":
                                FactoryOK.Text += "     " + "东莞".PadRight(6);
                                break;
                            case "CQ":
                                FactoryOK.Text += "     " + "重庆".PadRight(6);
                                break;
                            case "KS":
                                FactoryOK.Text += "     " + "昆山".PadRight(6);
                                break;
                        }
                        LenJ = ReturnChinaFont(Winners[i].DeptName);
                        if (Winners[i].DeptName.Length <= 20)
                        {
                            if (Winners[i].DeptName.Length == 20)
                            {
                                Dpart = Winners[i].DeptName.Substring(0, Winners[i].DeptName.Length - LenJ);
                            }
                            else
                            {
                                Dpart = Winners[i].DeptName;
                            }
                                
                        }
                        else
                        {
                            Dpart = Winners[i].DeptName.Substring(0, 17 - LenJ);
                        }

                        if (Winners[i].EmpName.Trim().Length < 3)
                        {
                            if (Winners[i].EmpName.Trim().Length == 2)
                            {
                                Names = Winners[i].EmpName.Trim().Substring(0,1)+"  "+ Winners[i].EmpName.Trim().Substring(1, 1);
                                Names = Names.PadRight(8);
                            }
                            else
                            {
                                Names = Winners[i].EmpName.Trim().PadRight(8);
                            }

                           
                        }
                        else
                        {
                            if (Winners[i].EmpName.Trim().Length > 8)
                            {
                                Names = Winners[i].EmpName.Trim().Substring(0, 6).PadRight(7) + "   ";
                            }
                            else
                            {
                                Names = Winners[i].EmpName.Trim().PadRight(7);
                            }
                        }

                        FactoryOK.Text +=  Winners[i].empNo.PadRight(10)+ Dpart + "\r\n\r\n";

                        this.Focus();
                        // MessageBox.Show("恭喜 " + Winners[i].EmpName + " 获得一等奖!");
                        //DisplayDial a = new DisplayDial();
                        //a.firstPerson = Names.Trim() + " 一等奖";
                        //a.ShowDialog();
                        //一等奖时候背景图改变
                        this.labName.Text = Names.Trim();
                        this.BackgroundImage = Image.FromFile("yidengbj.jpg");
                    }
                }
                else
                {
                    FactoryOK.Top = FactoryOK.Top + 50;
                    FactoryOK.Font = new Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    for (int i = 0; i < Winners.Count; i++)
                    {
                        switch (Winners[i].PlantNo)
                        {
                            case "DG":
                                FactoryOK.Text +=  "东莞".PadRight(6);
                                break;
                            case "CQ":
                                FactoryOK.Text +=  "重庆".PadRight(6);
                                break;
                            case "KS":
                                FactoryOK.Text += "昆山".PadRight(6);
                                break;
                        }
                        LenJ = ReturnChinaFont(Winners[i].DeptName);
                        if (Winners[i].DeptName.Length <= 20)
                        {
                            if (Winners[i].DeptName.Length == 20)
                            {
                                Dpart = Winners[i].DeptName.Substring(0, Winners[i].DeptName.Length - LenJ);
                            }
                            else
                            {
                                Dpart = Winners[i].DeptName;
                            }
                               
                        }
                        else
                        {
                            Dpart = Winners[i].DeptName.Substring(0, 17 - LenJ);
                        }
                        if (Winners[i].EmpName.Trim().Length < 3)
                        {
                            if (Winners[i].EmpName.Trim().Length == 2)
                            {
                                Names = Winners[i].EmpName.Trim().Substring(0, 1) + "  " + Winners[i].EmpName.Trim().Substring(1, 1);
                                Names = Names.PadRight(8);
                            }
                            else
                            {
                                Names = Winners[i].EmpName.Trim().PadRight(8);
                            }
                        }
                        else
                        {
                            if (Winners[i].EmpName.Trim().Length > 8)
                            {
                                Names = Winners[i].EmpName.Trim().Substring(0, 6).PadRight(7) + "   ";
                            }
                            else
                            {
                                Names = Winners[i].EmpName.Trim().PadRight(7);
                            }
                              
                        }
                        FactoryOK.Text += Winners[i].empNo.PadRight(10) + Names + Dpart + "\r\n\r\n";
                    }
                }
               
            }
        }

        private int ReturnChinaFont(string DepartV)
        {
            int j = 0;
            CharEnumerator CEnumerator = DepartV.GetEnumerator();
            Regex regex = new Regex("^[\u4E00-\u9FA5]{0,}$");
            while (CEnumerator.MoveNext())
            {
                if (regex.IsMatch(CEnumerator.Current.ToString(), 0))
                    j += 1;
            }
            return j;
        }
        private void displayDL7()
        {
            string Dpart = "";
            string Names = "";
            int LenJ = 0;
            if (FactoryOK.Text == "")
            {
               for (int i = 0; i < 7; i++)
                {
                    switch (Winners[i].PlantNo)
                    {
                        case "DG":
                            FactoryOK.Text +=  "东莞".PadRight(6);
                            break;
                        case "CQ":
                            FactoryOK.Text +=  "重庆".PadRight(6);
                            break;
                        case "KS":
                            FactoryOK.Text +=  "昆山".PadRight(6);
                            break;
                    }
                    LenJ = ReturnChinaFont(Winners[i].DeptName);
                    if (Winners[i].DeptName.Length <= 20)
                    {
                        if(Winners[i].DeptName.Length==20)
                        {
                            Dpart = Winners[i].DeptName.Substring(0, Winners[i].DeptName.Length - LenJ);
                        }
                        else
                        {
                            Dpart = Winners[i].DeptName;
                        }
                           
                    }
                    else
                    {
                        Dpart = Winners[i].DeptName.Substring(0, 17-LenJ);
                    }
                    if (Winners[i].EmpName.Trim().Length < 3)
                    {
                        if (Winners[i].EmpName.Trim().Length == 2)
                        {
                            Names = Winners[i].EmpName.Trim().Substring(0,1)+"  "+ Winners[i].EmpName.Trim().Substring(1,1);
                            Names = Names.PadRight(8);
                        }
                        else
                        {
                            Names = Winners[i].EmpName.Trim().PadRight(8);
                        }
                           
                    }
                    else
                    {
                        if (Winners[i].EmpName.Trim().Length > 8)
                        {
                            Names = Winners[i].EmpName.Trim().Substring(0,6).PadRight(7) + "   ";
                        }
                        else
                        {
                            Names = Winners[i].EmpName.Trim().PadRight(7);
                        }
                       
                    }

                    FactoryOK.Text +=  Winners[i].empNo.PadRight(10) + Names + Dpart + "\r\n\r\n";
                }
            }
        }
        private void CloseForm_Click(object sender, EventArgs e)
        {
            try
            {
                //WAA:  DataTable DT_WinNumber = DA.GetDataTable("select count(*) from [EmployeInfo] where Prize='"+ this.LuckyID + "'");
                //  if (DT_WinNumber.Rows.Count > 0)
                //  {
                //      if (DT_WinNumber.Rows[0][0].ToString() == this.Winners.Count.ToString())
                //      {
                this.Dispose();
                this.Close();
                //      }
                //      else
                //      {
                //          goto WAA;
                //      }
                //  }
                //  else
                //  {
                //      goto WAA;
                //  }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Winners.Count > 7)
            {
                if(lblInfoY*7>Winners.Count)
                {
                    lblInfoY = 1;
                    FactoryOK.Text = "";
                    labPage.Text =  "(1/" + (Winners.Count / 7 + 1).ToString()+")";
                    displayDL7();//10行以頁
                }
                else
                { 
                    lblInfoY += 1;
                    labPage.Text = "("+lblInfoY + "/" + (Winners.Count / 7+1).ToString()+")";
                    labrun();
                }
            }
        }
    }

}