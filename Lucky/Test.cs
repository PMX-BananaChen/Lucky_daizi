using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    public partial class Test : Form
    {
        DataAccess DA = new DataAccess();

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DA.UpdateMoreTest("select * from EmployeInfo ");

            MessageBox.Show("修改成功!");           


        }
    }
}
