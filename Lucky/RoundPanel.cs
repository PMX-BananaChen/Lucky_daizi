using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; 
using System.Drawing; 
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace Lucky
{

    public class RoundPanel : Panel
    {

        private Color _borderColor = Color.FromArgb(23, 169, 254);
        private int _radius = 10;
       

        private const int WM_ERASEBKGND = 0x0014;
        private const int WM_PAINT = 0xF;

        public RoundPanel()
            : base()
        {

        }

        [DefaultValue(typeof(Color), "23, 169, 254"), Description("控件边框颜色")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(int), "10"), Description("圆角弧度大小")]
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                base.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
                if (m.Msg == WM_PAINT)
                {
                    if (this.Radius > 0)
                    {
                        using (Graphics g = Graphics.FromHwnd(this.Handle))
                        {
                            Rectangle r = new Rectangle();
                            r.Width = this.Width;
                            r.Height = this.Height;
                            DrawBorder(g, r, this.Radius);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawBorder(Graphics g, Rectangle rect, int radius)
        {
            rect.Width -= 1;
            rect.Height -= 1;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            using (Pen pen = new Pen(this.BorderColor))
            {
                g.DrawPath(pen, path);
            }

        }

    }
}


