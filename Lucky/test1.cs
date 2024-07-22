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
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 10% 2;

            int t = 10 / 2;

            if (i > 0)
            {
                int x = i+t;
            }
            else
            {
                int x =t;
            }
        }
    }
}
