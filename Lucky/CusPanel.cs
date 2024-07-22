using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lucky
{
    internal class CusPanel : Panel
    {
        private Size _childControlSize;
        private int _childMargin;

        public CusPanel()
        {
            this._childControlSize = new Size(100, 100);
            _childMargin = 30;
        }

        public Size ChildControlSize
        {
            get
            {
                return _childControlSize;
            }
            set
            {
                this._childControlSize = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.SetControlPos();
            base.OnPaint(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            e.Control.Height = this._childControlSize.Height;
            e.Control.Width = this._childControlSize.Width;
            base.OnControlAdded(e);
        }

        private void SetControlPos()
        {

            if (this.Controls.Count == 0)

                return;

            int x = 0;
            int y = 0;
            int top = 100;
            int left = 80;
            int height = 60;

            foreach (Control control in Controls)
            {
                control.Left = x + left;
                control.Top = y + top;
                x = control.Right + _childMargin;

                if (x + left + this._childControlSize.Width > this.Width)
                {
                    x = 0;
                    y += this._childMargin + this._childControlSize.Height + height;
                }

            }
        }
    }
}
