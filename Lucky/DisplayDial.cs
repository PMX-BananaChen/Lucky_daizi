using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class DisplayDial : Form
    {
        public DisplayDial()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        public string firstPerson;
        private void DisplayDial_Load(object sender, EventArgs e)
        {
            //  global::Lucky.Properties.Resources.Background;
            //this.BackgroundImage = global::Lucky.Properties.Resources.Background;
            //this.BackgroundImage.s = this.Site;
            //label1.Text = "恭喜";
            label2.Text = firstPerson.Replace("一等奖","");

            this.Location=  new Point(850/2, 840/2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //private void DisplayDial_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.drawimage(this.backgoundimage, this.clientrectangle);
        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BackgroundImage, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
