using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;
using System.Configuration;
using static Lucky.LuckyForm;
using System.Threading;

namespace Lucky
{
    public partial class LoginForm : Form
    {

        DataAccess DA = new DataAccess();
        string LuckyID = "";
        string DG = "";
        string CQ = "";
        string KS = "";
        Int32 Num = 0;

        //数据字典才能唯一
        //Dictionary<string, Winner> userName = new Dictionary<string, Winner>();
        List<Winner> tempEmpNoW = new List<Winner>();
        //Dictionary<string, Winner> tempUserName = new Dictionary<string, Winner>();

        public object isUpdated = true;

        //////声明一个委托 
        //public delegate void DisplayUpdate();
        //////声明事件 
        //public event DisplayUpdate ShowUpdate;
        //private delegate void de_OutputMessage(string str);


        //publicClass PCMusic = new PublicClass();
        PublicClassFinish PCFinish = new PublicClassFinish();
        int totalCountStaff = 0;//总的员工数

        int setLotteryNum = 0;//欲抽取个数
        //int currentLotteryNum = 0;//已抽取个数

        bool isRepeat = false;//判断随机抽取的用户是否跟已抽取用户重复
        List<Winner> empNoShow=new List<Winner>();
        //Dictionary<string, Winner> userNameShow = new Dictionary<string, Winner>();
        public LoginForm()
        {
            InitializeComponent();
        }

        //系统设置
        private void btnset_Click(object sender, EventArgs e)
        {
            SetForm set = new SetForm();
            set.ShowDialog();
        }

        //查看奖品
        private void btnsee_Click(object sender, EventArgs e)
        {
            ShowForm re = new ShowForm();
            re.ShowDialog();
        }

        //加载
        public void LoginForm_Load(object sender, EventArgs e)
        {

            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
            this.CloseForm.Tag = "exit";

            ////restart = false;
            ////SoundPlayer sp = new SoundPlayer("zhufu.wav");
            ////sp.PlayLooping();
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲
            //DA.ExecuteSQL("insert into EmployeInfo (EmpNo,EmpName,DeptName,CardNo) select EmpNo,EmpName,DeptPrintShotName,ICCardNo from EmployeInfo  ");

            string Title = ConfigurationManager.AppSettings["Title"].ToString();

            #region by banana 2020-12-24 拿掉中獎人數 .. 
            lb_Count.Visible = false;
            label4.Visible = false;
            #endregion

            if (Title == "1")
            {
                //Primax              
                this.label6.Visible = false;
            }
            else if (Title == "2")
            {
                //TYM
                this.TitleLabel.Visible = false;
            }
            //加载菜单     

            //Button btn_AddEmp = Factory.CreateButton("人员刷卡", "Lucky." + "Employee", imageList1, 1, Button_Onclick);
            //this.panel3.Controls.Add(btn_AddEmp);

            //Button btn_Set = Factory.CreateButton("名單導入", "Lucky." + "ImportEmp", imageList1, 3, Button_Onclick);
            //this.panel3.Controls.Add(btn_Set);


            //Button btn_Winner = Factory.CreateButton("中奖名单", "Lucky." + "Report", imageList1, 2, Button_Onclick);
            //this.panel3.Controls.Add(btn_Winner);


            //Button btn_Repleat = Factory.CreateButton("重新抽獎", "Lucky." + "Report", imageList1, 4, Button_Onclick);
            //this.panel3.Controls.Add(btn_Repleat);
            // this.lb_Count.Focus();
            //重新加載數據
            RefreshDate();

        }


        //加载
        public void LoginForm_Refresh()
        {

            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
            this.CloseForm.Tag = "exit";
            this.start.Visible = true;
            //this.MeneV.Visible = true;
            this.RepeatChoose.Visible = true;
            this.labSum.Visible = true;
            this.WinningName.Visible = true;
            this.CloseForm.Visible = true;
            this.MeneV.Focus();

            this.lbcount.Visible = false;
            this.lblGrade.Visible = false;
            this.labDisplayNum.Visible = false;
            this.stoprun.Visible = false;

            timer1.Stop();
            timer1.Enabled = false;
            //将数据清空，重新计算
            
            ////restart = false;
            ////SoundPlayer sp = new SoundPlayer("zhufu.wav");
            ////sp.PlayLooping();
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲
            //DA.ExecuteSQL("insert into EmployeInfo (EmpNo,EmpName,DeptName,CardNo) select EmpNo,EmpName,DeptPrintShotName,ICCardNo from EmployeInfo  ");

            string Title = ConfigurationManager.AppSettings["Title"].ToString();

            #region by banana 2020-12-24 拿掉中獎人數 .. 
            lb_Count.Visible = false;
            label4.Visible = false;
            //panel3.Visible = false;
            labFinish.Text = "";
            start.Visible = true;
            #endregion

            if (Title == "1")
            {
                //Primax              
                this.label6.Visible = false;
            }
            else if (Title == "2")
            {
                //TYM
                this.TitleLabel.Visible = false;
            }

            //this.textBox1.Text = empnos;
            //加载菜单     

            //Button btn_AddEmp = Factory.CreateButton("人员刷卡", "Lucky." + "Employee", imageList1, 1, Button_Onclick);
            //this.panel3.Controls.Add(btn_AddEmp);

            //Button btn_Set = Factory.CreateButton("名單導入", "Lucky." + "ImportEmp", imageList1, 3, Button_Onclick);
            //this.panel3.Controls.Add(btn_Set);


            //Button btn_Winner = Factory.CreateButton("中奖名单", "Lucky." + "Report", imageList1, 2, Button_Onclick);
            //this.panel3.Controls.Add(btn_Winner);


            //Button btn_Repleat = Factory.CreateButton("重新抽獎", "Lucky." + "Report", imageList1, 4, Button_Onclick);
            //this.panel3.Controls.Add(btn_Repleat);
            // this.lb_Count.Focus();
            //重新加載數據
            RefreshDate();

        }
        /// <summary>
        /// 重新加載數據
        /// </summary>
        private void RefreshDate()
        {
            try
            {
                //綁定所有設定的獎項人數
                //  this.BackgroundImage = global::Lucky.Properties.Resources.Primax;
                DataTable DT_WinNumber = DA.GetDataTable("select LuckyID,LuckyName,WinNumber,DG,CQ,KS,WinAmount from LuckyType where Active='1' order by LuckyID desc;");
                if (DT_WinNumber.Rows.Count > 0)
                {
                    this.RepeatChoose.Visible = false;
                    this.MeneV.Visible = false;
                    LuckyID = DT_WinNumber.Rows[0]["LuckyID"].ToString();//抽獎順序 靈活實現現場可以更改抽獎順序
                    this.WinningName.Text = DT_WinNumber.Rows[0]["LuckyName"].ToString();//獎項名稱
                    if (DT_WinNumber.Rows[0]["WinAmount"].ToString() == "")
                    {
                        MessageBox.Show("麻烦设置奖金!");
                        return;
                    }
                    else
                    {
                        if (int.Parse(DT_WinNumber.Rows[0]["WinAmount"].ToString()) < 1000)
                        {
                            this.labSum.Text = "     " + DT_WinNumber.Rows[0]["WinAmount"].ToString() + "元";//獎項金額
                            this.labSum.SetBounds(this.WinningName.Location.X - 50, this.WinningName.Location.Y + 170, this.WinningName.Width, this.WinningName.Height);
                        }
                        else
                        {
                            this.labSum.Text = "     " + DT_WinNumber.Rows[0]["WinAmount"].ToString() + "元" + "  ";//獎項金額
                            this.labSum.SetBounds(this.WinningName.Location.X - 50, this.WinningName.Location.Y + 170, this.WinningName.Width, this.WinningName.Height);
                        }
                    }


                    //this.labPcs.Text = DT_WinNumber.Rows[0]["WinNumber"].ToString() + "个";//獎項金額
                    //this.labSum.SetBounds(this.Width/2-80, this.Height/2+40,50,30);
                    this.lb_Count.Text = DT_WinNumber.Rows[0]["WinNumber"].ToString();//獎項人數
                    DG = DT_WinNumber.Rows[0]["DG"].ToString();//當前獎項下面,東莞可以中獎的人數
                    CQ = DT_WinNumber.Rows[0]["CQ"].ToString();//當前獎項下面,重慶可以中獎的人數
                    KS = DT_WinNumber.Rows[0]["KS"].ToString();//當前獎項下面,昆山可以中獎的人數
                }
                else
                {
                    // this.BackgroundImage = global::Lucky.Properties.Resources.Primax2;
                    WinningName.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label6.Text = "";
                    //labPcs.Text = "";
                    labSum.Text = "";
                    lb_Count.Text = "";
                    start.Visible = false;
                    // MessageBox.Show("全部抽奖完毕!");
                    labFinish.Text = "全部抽奖完毕!";
                    this.RepeatChoose.Visible = true;
                    //this.MeneV.Visible = true;
                    //MeneV.Focus();
                    return;
                }

                if (this.lb_Count.Text == "")
                {
                    this.lb_Count.Text = "1";
                }

                Num = Convert.ToInt32(this.lb_Count.Text);


            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// 按鍵事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Onclick(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c.Tag == null)
                return;

            string assembly = c.Tag.ToString();

            Type type = Type.GetType(assembly);

            if (type == null)
            {
                MessageBox.Show(string.Format("类别{0}不存在", assembly));
                return;
            }

            //使用Activator创建实例(带参数构造函数) --- var user2 = Activator.CreateInstance(type, "1" );           
            //這裡需要傳入用戶與窗體信息------参数数组(按顺序)
            //string ModuleName = c.Text;
            //string UserId = this.UserId;
            //object[] constructParms = new object[] { ModuleName };

            var f = Activator.CreateInstance(type) as Form;

            if (f != null)
            {
                f.ShowDialog();
            }

            else
                MessageBox.Show("程序集不存在");
        }
        //查看结果
        private void btnresult_Click(object sender, EventArgs e)
        {
            ResultForm re = new ResultForm();
            // re.ShowDialog();

            re.Show();
        }

        /// <summary>
        /// 關閉抽獎系統
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        /// <summary>
        /// 開始抽獎按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// //进入抽奖（不含:入职未满一个月在职员工，G9及以上人员、派遣工、工作人员）
        //一等奖      3,000   1    所有人随机
        //二等奖      2,000   3    DG：2，CQ&KS：1
        //三等奖      1,500   5    DG：3,CQ：1,KS：1
        //四等奖      1,000   10   DG：7,CQ：2,KS：1
        //五等奖      800     20   DG：14,CQ：4,KS：2
        //六等奖      500     40   DG：28,CQ：8,KS：4
        //幸运奖      300     270  DG：189,CQ：54,KS：27
        //小游戏红包  5,000 不用管...

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                //進入抽獎展示界面
                //  string LuckyType=this.combox_LuckyType.SelectedValue.ToString();
                if (string.IsNullOrEmpty(WinningName.Text))
                {
                    MessageBox.Show("全部抽奖完毕!");
                    MeneV.Focus();
                    return;
                }
                // LuckyForm luck = new LuckyForm(WinningName.Text, Num, DG, CQ, KS, LuckyID);
                this.lb_Count.Text = "";

                ////重新加載
                //LuckyForm luck = new LuckyForm(WinningName.Text, Num, DG, CQ, KS, LuckyID);
                //luck.ShowUpdate += new DisplayUpdate(LoginForm_Refresh);
                //luck.Show();
                LuckyForm_Load();
               // tempUserName.Clear();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void LuckyForm_Load()
        {
            try
            {
                //一等奖      3,000   1    所有人随机
                //二等奖      2,000   3    DG：2，CQ&KS：1
                //三等奖      1,500   5    DG：3,CQ：1,KS：1
                //四等奖      1,000   10   DG：7,CQ：2,KS：1
                //五等奖      800     20   DG：14,CQ：4,KS：2
                //六等奖      500     40   DG：28,CQ：8,KS：4
                //幸运奖      300     270  DG：189,CQ：54,KS：27
                this.start.Visible = false;
                //this.MeneV.Visible = false;
                //this.RepeatChoose.Visible = false;
                this.labSum.Visible = false;
                this.WinningName.Visible = false;
                this.CloseForm.Visible = false;
                setLotteryNum = 0;

                if (DG == "" && CQ == "" && KS == "")//沒有條件全部可以抽獎
                {
                    needLoadPerson(" and EmpInDate<'2021-01-09'", Num.ToString());//這個時候全部人可以參與抽獎,但是只要1個名額
                }
                else
                {
                    if (CQ == "" && KS == "")//重慶,昆山為空時候可以抽獎人數條件
                    {
                        needLoadPerson(" and PlantNo='DG';", DG);//東莞的先按照這個人數抽獎,在抽重慶,昆山人數
                        needLoadPerson(" and PlantNo<>'DG';", (Num - int.Parse(DG)).ToString());//可中獎總數減去東莞的,就是其它地方要抽獎的人數
                    }
                    else
                    {
                        needLoadPerson(" and PlantNo='DG';", DG);//這個時候全部人可以參與抽獎,但是只要1個名額
                        needLoadPerson(" and PlantNo='CQ';", CQ);//這個時候全部人可以參與抽獎,但是只要1個名額
                        needLoadPerson(" and PlantNo = 'KS';", KS);//這個時候全部人可以參與抽獎,但是只要1個名額
                    }
                }

                this.lblGrade.Text = this.WinningName.Text;
                this.lbcount.Text = this.Num.ToString() + "    名";

                this.lbcount.Visible = true;
                this.lblGrade.Visible = true;
                this.labDisplayNum.Visible = true;
                this.stoprun.Visible = true;

                //pictureBox1.SetBounds(this.Width/2-55, this.Height/2+28, this.pictureBox1.Width, this.pictureBox1.Height);

                //pictureBox3.KeyDown += new KeyEventHandler(pictureBox3_KeyDown);
                startChoose_Click();//自動開始抽獎


            }
            catch (Exception ex)
            {
                throw (ex);
            }


        }

        private void needLoadPerson(string WhereStr, string ChooseSum)
        {
            List<Winner> empNoW = new List<Winner>();
            string sqlstr = "select EmpNo,EmpName,DeptName,CardNo,PlantNo,Prize from [EmployeInfo] where (Prize='' or Prize is null)";

            DataTable DT_Employee = DA.GetDataTable(sqlstr + WhereStr);

            totalCountStaff = DT_Employee.Rows.Count;

            foreach (DataRow DR in DT_Employee.Rows)
            {
                Winner Wn = new Winner();
                Wn.empNo = DR["EmpNo"].ToString();
                Wn.EmpName = DR["EmpName"].ToString();
                //Wn.DeptName = DR["DeptName"].ToString();
                Wn.DeptName = DR["DeptName"].ToString();
                Wn.CardNo = DR["CardNo"].ToString();
                Wn.PlantNo = DR["PlantNo"].ToString();
                empNoW.Add(Wn);
                empNoShow.Add(Wn);//全部数据都加入
            }
            choosePrize(empNoW, ChooseSum);
        }
        /// <summary>
        /// Dictionary<int, string> dic = new Dictionary<int, string>();
        /// </summary>
        /// <param name="empNoW"></param>
        /// <param name="ChooseSum"></param>
        private void choosePrize(List<Winner> empNoW, string ChooseSum)
        {
            try
            {
                //中奖用户
                //currentLotteryNum = 0;
                string tempEmpNoWb = "";
                int randomNum = 0;//随机数
                Winner empNoWbInsert=new Winner();

                setLotteryNum += int.Parse(ChooseSum);
                while (tempEmpNoW.Count < setLotteryNum)
                {
                    isRepeat = false;
                    Random kd = new Random(Guid.NewGuid().GetHashCode());
                    randomNum = kd.Next(totalCountStaff);

                    empNoWbInsert = empNoW[randomNum];

                    if (tempEmpNoW.Count > 0)
                    {
                        for (int i = 0; i < tempEmpNoW.Count; i++)
                        {
                            tempEmpNoWb = tempEmpNoW[i].empNo.ToString().Trim();
                            if (tempEmpNoWb == empNoWbInsert.empNo.ToString().Trim())
                            {
                                //empNoWbInsert = tempEmpNoW[i];
                                isRepeat = true;
                                break;
                            }
                        }
                    }
                    //else //第1次肯定没有重复
                    //{
                    //    empNoWbInsert = empNoW[randomNum];
                    //}

                    if (!isRepeat)
                    {
                        //currentLotteryNum = currentLotteryNum + 1;
                        if (empNoWbInsert != null && empNoWbInsert.empNo!=null)
                        {
                            tempEmpNoW.Add(empNoWbInsert);//empNoW[randomNum]
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        /// <summary>
        /// 重新抽獎
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuV_Click(object sender, EventArgs e)
        {
            try
            {
                ////加载菜单
                //this.panel3.Visible = true;
                //this.panel3.Controls.Clear();
                //Button btn_AddEmp = Factory.CreateButton("人员刷卡", "Lucky." + "Employee", imageList1, 1, Button_Onclick);
                //this.panel3.Controls.Add(btn_AddEmp);

                //Button btn_Set = Factory.CreateButton("名单导入", "Lucky." + "ImportEmp", imageList1, 3, Button_Onclick);
                //this.panel3.Controls.Add(btn_Set);


                //Button btn_Winner = Factory.CreateButton("中奖名单", "Lucky." + "Report", imageList1, 2, Button_Onclick);
                //this.panel3.Controls.Add(btn_Winner);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void RepeatChoose_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons messButton = MessageBoxButtons.YesNo;

                DialogResult dr = MessageBox.Show("确定要重新抽奖吗?", "重新抽奖", messButton);

                if (dr == DialogResult.Yes)
                {
                    //this.panel3.Visible = false;
                    //測試用的.要拿掉
                    string sqlstr = "UPDATE [EmployeInfo] SET Prize=''; ";
                    bool ExRsult = DA.ExecuteSQL(sqlstr);

                    //更新抽獎項,不可再抽獎
                    // sqlstr  = "UPDATE [LuckyType] SET Active='0' where rtrim(left(LuckyName,instr(LuckyName, ' '))) = '" + this.choose.ToString() + "' ";
                    sqlstr = "UPDATE [LuckyType] SET Active='1' ";

                    ExRsult = DA.ExecuteSQL(sqlstr);

                    if (ExRsult == true)
                    {
                        RefreshDate();
                        start.Visible = true;
                        this.labFinish.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Update Fail!");
                    }


                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //PCMusic.MusicPlayer(1);
            //PCFinish.MusicPlayer(0);
            Thread th = new Thread(new ParameterizedThreadStart(Update));
            th.Start(tempEmpNoW);
            // m_personList.Sort((x, y) =>
            //{
            //    return x.name.CompareTo(y.name);
            //});
            tempEmpNoW.Sort((x, y) => { return x.EmpName.CompareTo(y.EmpName); });

            WinnerForm WF = new WinnerForm(WinningName.Text, tempEmpNoW, this.LuckyID);
            WF.ShowDialog();
            LoginForm_Refresh();
            tempEmpNoW.Clear();//回来时候把数据清理掉

        }

        private void Update(object list)
        {
            lock (isUpdated)
            {
                //YN = false;
                bool ExRsult = false;
                //int Accounts = 0;
                //DataTable DT_Employee = null;
                string sqlstr = "";
                var Winners = list as List<Winner>;
                if (Winners.Count == 0)
                    return;


                DA.UpdateMore(Winners, "select * from EmployeInfo", LuckyID, "Prize");//拿掉

                //发现有没有被更新到的重新更新

                //if (Num == 270)//不要急着切换窗体，否则数据会没有统计到就结束人数
                //{
                //    foreach (Winner wn in Winners)
                //    {
                //        empnos += wn.empNo + ";";
                //        sqlstr = "update EmployeInfo set Prize='7' where EmpNo='" + wn.empNo + "';";
                //        ExRsult = DA.ExecuteSQL(sqlstr);
                //    }


                //    OutputMessage(empnos);
                //    Accounts = empnos.Split(';').Length;
                //}

                    

                //更新抽獎項,不可再抽獎
                // sqlstr  = "UPDATE [LuckyType] SET Active='0' where rtrim(left(LuckyName,instr(LuckyName, ' '))) = '" + this.choose.ToString() + "' ";
                sqlstr = "UPDATE [LuckyType] SET Active='0' where LuckyName = '" + this.WinningName.Text.ToString() + "';";

                ExRsult = DA.ExecuteSQL(sqlstr);

                isUpdated = false;

                //清除数据
                //userName.Clear();
               // tempEmpNoW.Clear();
                //YN = true;
                //if(!string.IsNullOrEmpty(DG))
                //{
                //    if (int.Parse(DG) > 100)
                //    {
                //        Thread.Sleep(2000);
                //    }
                //}
                //抽一万人时,要改一下此方法,批量修改!
            }
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startChoose_Click()
        {

            //PCMusic.MusicPlayer(0);
            timer1.Start();
            timer1.Enabled = true;
            //this.pictureBox3.Focus();
            //this.panel2.Visible = true;
            // this.textBox1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random(Guid.NewGuid().GetHashCode());
                int j = rd.Next(totalCountStaff);
                //for (int j=0;j<userName.Count;j++)
                //{ 
                Int32 EmpNOLength = Convert.ToInt32(ConfigurationManager.AppSettings["EmpNOLength"].ToString());
                //.Replace("4", "*").Replace("5", "*").Replace("3", "#").Replace("6", "#").
                //PadLeft(EmpNOLength, '*')
                this.labDisplayNum.Text = empNoShow[j].empNo.Replace("3", "#");
                //}
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //private delegate void de_OutputMessage(string str);
        //public void OutputMessage(string str)
        //{
        //    if (this.textBox1.InvokeRequired)
        //    {
        //        this.BeginInvoke(new de_OutputMessage(OutputMessage), str);
        //    }
        //    else
        //    {
        //        if (textBox1.TextLength > textBox1.MaxLength - 10)
        //        {
        //            textBox1.Clear();
        //        }

        //    }
        //}
    }
}