using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Lucky
{
    class Factory
    {
        public static System.Windows.Forms.Button CreateButton(string text, string form, System.Windows.Forms.ImageList imgList, int index)
        {
            return CreateButton(text, form, imgList, index, null);
        }

        public static System.Windows.Forms.Button CreateButton(string text, string form, System.Windows.Forms.ImageList imgList, int index, EventHandler e)
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.Text = text;            
            button.BackColor = System.Drawing.Color.Transparent;
            button.ImageList = imgList;
            button.ImageIndex = index;
            button.TextAlign = ContentAlignment.BottomCenter;
            button.ImageAlign = ContentAlignment.TopCenter;
            button.FlatStyle = FlatStyle.Flat;            
           // button.FlatAppearance.BorderColor = Color.FromArgb(233, 233, 233);
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.FromArgb(0, 0, 0);
            button.Font = new Font("宋体", 12 , FontStyle.Bold);

            button.Tag = form;
            if (e != null)
                button.Click += e;
            return button;
        }
    }
}
