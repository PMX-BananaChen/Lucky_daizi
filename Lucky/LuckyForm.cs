using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Configuration;

namespace Lucky
{
    public partial class LuckyForm : Form
    {

        //声明一个委托 
        public delegate void DisplayUpdate();
        //声明事件 
        public event DisplayUpdate ShowUpdate;

        PublicClass PCMusic=new PublicClass();
        PublicClassFinish PCFinish = new PublicClassFinish();

        public object isUpdated = true;

        public bool YN = true;

        delegate void myDel();
        
        DataAccess DA = new DataAccess();

        List<Winner> userName = new List<Winner>();
        List<Winner> tempUserName = new List<Winner>();

        int totalCountStaff = 0;//总的员工数
        int randomNum = 0;//随机数
        int setLotteryNum = 0;//欲抽取个数
        int currentLotteryNum = 0;//已抽取个数

        bool isRepeat = false;//判断随机抽取的用户是否跟已抽取用户重复
        List<Winner> userNameShow;

        public string choose { get; set; }
        public Int32 Ncount { get; set; }
        /// <summary>
        /// 東莞
        /// </summary>
        public string DG { get; set; }
        /// <summary>
        /// 重慶
        /// </summary>
        public string CQ { get; set; }
        /// <summary>
        /// 昆山
        /// </summary>
        public string KS { get; set; }
        /// <summary>
        /// LuckyID用ID查找速度比較快
        /// </summary>
        public string LuckyID { get; set; }
        /// <summary>
        /// 東莞,重慶,昆山DG,CQ,KS
        /// </summary>
        /// <param name="choose"></param>
        /// <param name="Ncount"></param>
        /// <param name="DG"></param>
        /// <param name="CQ"></param>
        /// <param name="KS"></param>
        public LuckyForm(string choose, Int32 Ncount, string DG,string CQ,string KS,string LuckyID)
        {
            this.choose = choose;
            this.Ncount = Ncount;
            this.DG = DG;
            this.CQ = CQ;
            this.KS = KS;
            this.LuckyID = LuckyID;
            InitializeComponent();
        }

        ///// <summary>
        ///// 抽奖
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>

        //private void btnonoff_Click(object sender, EventArgs e)
        //{
        //       timer1.Enabled = true;              
        //       this.pictureBox3.Focus();
        //       this.panel2.Visible = true;
        //       this.textBox1.Visible = true;
        //       this.pictureBox2.Visible = false;             

        //        //中奖用户
        //        currentLotteryNum = 0;
        //        setLotteryNum = this.Ncount;             
        //        while (currentLotteryNum < setLotteryNum)
        //        {
        //            isRepeat = false;
        //            Random kd = new Random(Guid.NewGuid().GetHashCode());
        //            randomNum = kd.Next(totalCountStaff);

        //            if (tempUserName.Count > 0)
        //            {
        //                for (int i = 0; i < currentLotteryNum; i++)
        //                {
        //                    if (tempUserName[i] == userName[randomNum])
        //                    {
        //                        isRepeat = true;
        //                        break;
        //                    }
        //                }

        //            }

        //            if (!isRepeat)
        //            {                        
        //                currentLotteryNum = currentLotteryNum + 1;                  
        //                tempUserName.Add(userName[randomNum]);

        //            }

        //        }    


        //}
        /// <summary>
        /// EmployeInfo 中獎的人員信息表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LuckyForm_Load(object sender, EventArgs e)
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
                if (DG == "" && CQ == "" && KS == "")//沒有條件全部可以抽獎
                {
                    needLoadPerson("", Ncount.ToString());//這個時候全部人可以參與抽獎,但是只要1個名額
                }
                else
                {
                    if (CQ == "" && KS == "")//重慶,昆山為空時候可以抽獎人數條件
                    {
                        needLoadPerson(" and PlantNo='DG';", DG);//東莞的先按照這個人數抽獎,在抽重慶,昆山人數
                        needLoadPerson(" and PlantNo<>'DG';", (Ncount - int.Parse(DG)).ToString());//可中獎總數減去東莞的,就是其它地方要抽獎的人數
                    }
                    else
                    {
                        needLoadPerson(" and PlantNo='DG';",DG);//這個時候全部人可以參與抽獎,但是只要1個名額
                        needLoadPerson(" and PlantNo='CQ';", CQ);//這個時候全部人可以參與抽獎,但是只要1個名額
                        needLoadPerson(" and PlantNo = 'KS';", KS);//這個時候全部人可以參與抽獎,但是只要1個名額
                    }
                }

                this.lblGrade.Text = this.choose;
                this.lbcount.Text = this.Ncount.ToString() + "    名";
                //pictureBox1.SetBounds(this.Width/2-55, this.Height/2+28, this.pictureBox1.Width, this.pictureBox1.Height);

                pictureBox3.KeyDown += new KeyEventHandler(pictureBox3_KeyDown);
                startChoose_Click(sender, e);//自動開始抽獎

                timer2.Start();
                timer2.Enabled = true;

            }
            catch(Exception ex)
            {
                throw (ex);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random(Guid.NewGuid().GetHashCode());

                int j = rd.Next(totalCountStaff);

                Int32 EmpNOLength = Convert.ToInt32(ConfigurationManager.AppSettings["EmpNOLength"].ToString());

                this.labDisplayNum.Text = userName[j].empNo.Replace("4", "*").Replace("5", "*").Replace("3", "#").Replace("6", "#").PadLeft(EmpNOLength, '*');

            }
            catch (Exception ex)
            {
                throw (ex);
            }
           
        }

        /// <summary>
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        { 
              

        }

        private void Update(object list)
        {
            lock (isUpdated)
            {
                //YN = false;
                bool ExRsult = false;
                //DataTable DT_Employee = null;
                string sqlstr = "";
                var Winners = list as List<Winner>;
              
                DA.UpdateMore(Winners, "select * from EmployeInfo", LuckyID, "Prize");//拿掉

                //更新抽獎項,不可再抽獎
               // sqlstr  = "UPDATE [LuckyType] SET Active='0' where rtrim(left(LuckyName,instr(LuckyName, ' '))) = '" + this.choose.ToString() + "' ";
                sqlstr = "UPDATE [LuckyType] SET Active='0' where LuckyName = '" + this.choose.ToString() + "' ";

                ExRsult = DA.ExecuteSQL(sqlstr);

                isUpdated = false;
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

        private void CloseThis(object obj)
        {
            try
            {
                lock (isUpdated)
                {
                    this.Invoke(new myDel(CloseThis2));

                }
            }
            catch(Exception ex)
            {
                throw (ex);

            }
          
        }

        private void LuckyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!YN)
            {             

                MessageBox.Show("由于此次中奖人数过多,系统正在保存中奖人员名单到数据库,将再耐心等待几分钟,系统会自动关闭此窗口!");

                e.Cancel = true;

            } 

        }     

        private void CloseThis2 ()
        {
            this.Close();
            ShowUpdate();
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startChoose_Click(object sender, EventArgs e)
        {

            PCMusic.MusicPlayer(0);
            timer1.Start();
            timer1.Enabled = true;
            //this.pictureBox3.Focus();
            //this.panel2.Visible = true;
           // this.textBox1.Visible = true;
        }

        private void needLoadPerson(string WhereStr,string ChooseSum)
        {
            //List<Winner> userName = new List<Winner>();
            string sqlstr = "select EmpNo,EmpName,DeptName,CardNo,PlantNo,Prize from [EmployeInfo] where (Prize='' or Prize is null)";

            DataTable DT_Employee = DA.GetDataTable(sqlstr+ WhereStr);

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
                userName.Add(Wn);
            }
            userNameShow = userName;
            choosePrize(userName, ChooseSum);
        }


        private void choosePrize(List<Winner> userName,string ChooseSum)
        {
            try
            {
                //中奖用户
                currentLotteryNum = 0;
                setLotteryNum =int.Parse(ChooseSum);
                while (currentLotteryNum < setLotteryNum)
                {
                    isRepeat = false;
                    Random kd = new Random(Guid.NewGuid().GetHashCode());
                    randomNum = kd.Next(totalCountStaff);

                    if (tempUserName.Count > 0)
                    {
                        for (int i = 0; i < currentLotteryNum; i++)
                        {
                            if (tempUserName[i] == userName[randomNum])
                            {
                                isRepeat = true;
                                break;
                            }
                        }
                    }

                    if (!isRepeat)
                    {
                        currentLotteryNum = currentLotteryNum + 1;
                        if (userName.Count > 0)
                        {
                            tempUserName.Add(userName[randomNum]);
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
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            PCMusic.MusicPlayer(1);
            PCFinish.MusicPlayer(0);
            Thread th = new Thread(new ParameterizedThreadStart(Update));
            Thread th2 = new Thread(new ParameterizedThreadStart(CloseThis));
            th.Start(tempUserName);
            th2.Start();
            //WinnerForm WF = new WinnerForm(this.choose, tempUserName);
            //WF.Show();
        }

        private void LuckyForm_KeyUp(object sender, KeyEventArgs e)
        {

           //空格

        }


        void pictureBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.startChoose_Click(sender,e);//東莞
                this.startChoose_Click(sender, e);//重慶
                this.startChoose_Click(sender, e);//昆山
                this.ActiveControl = this.pictureBox3;

            }
            else
            {                
                return ;
            
            }



        }

        void pictureBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.pictureBox3_Click(sender, e);
               

            }
            else
            {

                return;

            }



        }


        /// <summary>
        /// 聚交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.panel2_Leave(sender, e);

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.panel2_Leave(sender, e); 
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Click(object sender, EventArgs e)
        {

            this.panel2_Leave(sender, e);     
        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = this.pictureBox3;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.panel2_Leave(sender, e);
        }

        /// <summary>
        /// 為了防止時間超時,自動關閉窗體,繼續下個抽獎
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //string sqlstr = "select count(*) from [LuckyType] where LuckyName = '" + this.choose.ToString() + "' and  Active='1'";

            //DataTable DT_Count = DA.GetDataTable(sqlstr);

            //if (DT_Count.Rows.Count > 0)//自動關閉界面
            //{
            //    //Thread.Sleep(3000);
            //    //pictureBox3_Click(sender, e);
            //}
        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void lbcount_Click(object sender, EventArgs e)
        {

        }

        private void labDisplayNum_Click(object sender, EventArgs e)
        {

        }
    }
}