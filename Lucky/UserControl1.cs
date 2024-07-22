using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky
{
    public partial class UserControl1 : UserControl
    {
        public static string name; public string photo; 

        //public event EventHandler<ControlClickEventArgs> ControlClick;

        public UserControl1(string name, string photo)
        {
            InitializeComponent();
            lb_name.Text =photo+'\n'+ name;
            name = lb_name.Text;
            //lb_photo.ImageLocation = @"E:\F20180717\工作\Code\Lucky\Lucky_IT\Lucky\bin\Debug\photo\" + photo + ".bmp"; 
            lb_photo.ImageLocation = @"C:\Users\monica.huang\Desktop\Debug\photo\" + photo + ".jpg";
            //lb_photo.ImageLocation = @"F:\Monica.Huang\2019-04-09  交接（小康）系统\Lucky-抽奖系统\Lucky_东聚30周年庆抽奖2\Lucky\bin\Debug\photo\" + photo + ".jpg"; 

            this.photo = lb_photo.ImageLocation;
         

        }



        private void label2_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lab_ondutyHour_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lab_extraHour_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lab_offdutyHour_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lab_day_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            //var handle = this.ControlClick;

            //if (handle == null)
            //    return;

            //var args = new ControlClickEventArgs();
            //args.Date = lbdate.Text;
            //handle(this, args);
        }

        private void lb_photo_Click(object sender, EventArgs e)
        {

        }


    }
}
