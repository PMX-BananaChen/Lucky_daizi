﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Data;
    using System.Windows.Forms;
    using System.Collections.Generic;


        /* 【原功能为文字左右滚动控件】
         * 此控件修改滚动方式为由下至上
         * 修改人：王志超
         * 时间：2014-02-10
         * 修改内容：public void DrawScrollingText(Graphics canvas)
         */

        /// <summary>
        /// Summary description for ScrollingTextControl.
        /// </summary>
        [
        ToolboxBitmapAttribute(typeof(Lucky.ScrollingText), "ScrollingText.bmp"),
        DefaultEvent("TextClicked")
        ]
        public class ScrollingText : System.Windows.Forms.Control
        {
            private Timer timer;                            // Timer for text animation.
            private string text = "Text";                    // Scrolling text
            private float staticTextPos = 0;                // The running x pos of the text
            private float yPos = 0;                            // The running y pos of the text
            private ScrollDirection scrollDirection = ScrollDirection.RightToLeft;                // The direction the text will scroll
            private ScrollDirection currentDirection = ScrollDirection.LeftToRight;                // Used for text bouncing 
            private VerticleTextPosition verticleTextPosition = VerticleTextPosition.Center;    // Where will the text be vertically placed
            private int scrollPixelDistance = 1;            // How far the text scrolls per timer event
            private bool showBorder = true;                    // Show a border or not
            private bool stopScrollOnMouseOver = false;        // Flag to stop the scroll if the user mouses over the text
            private bool scrollOn = true;                    // Internal flag to stop / start the scrolling of the text
            private Brush foregroundBrush = null;            // Allow the user to set a custom Brush to the text Font
            private Brush backgroundBrush = null;            // Allow the user to set a custom Brush to the background
            private Color borderColor = Color.Black;        // Allow the user to set the color of the control border
        
            public ScrollingText()
            {
                // Setup default properties for ScrollingText control
                InitializeComponent();

                //This turns off internal double buffering of all custom GDI+ drawing

                Version v = System.Environment.Version;

                if (v.Major < 2)
                {
                    this.SetStyle(ControlStyles.DoubleBuffer, true);
                }
                else
                {
                    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                }

                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.ResizeRedraw, true);

                //setup the timer object
                timer = new Timer();
                timer.Interval = 100;    //default timer interval
                timer.Enabled = true;
                timer.Tick += new EventHandler(Tick);
            }

            /**/
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    //Make sure our brushes are cleaned up
                    if (foregroundBrush != null)
                        foregroundBrush.Dispose();

                    //Make sure our brushes are cleaned up
                    if (backgroundBrush != null)
                        backgroundBrush.Dispose();

                    //Make sure our timer is cleaned up
                    if (timer != null)
                        timer.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Component Designer generated code
            /**/
            /// <summary>
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                //ScrollingText            
                this.Name = "ScrollingText";
                this.Size = new System.Drawing.Size(216, 40);
                this.Click += new System.EventHandler(this.ScrollingText_Click);
            }
            #endregion

            //Controls the animation of the text.
            private void Tick(object sender, EventArgs e)
            {
                //2014-05-10 王志超修改
                RectangleF refreshRect = new RectangleF(0, 0, this.Size.Width, this.Size.Height);
                Region updateRegion = new Region(refreshRect);

                Invalidate(updateRegion);
                Update();

                //原代码如下：

                ////update rectangle to include where to paint for new position            
                ////lastKnownRect.X -= 10;
                ////lastKnownRect.Width += 20;            
                //lastKnownRect.Inflate(10, 5);
                ////get the display rectangle
                //RectangleF refreshRect = lastKnownRect;
                //refreshRect.X = Math.Max(0, lastKnownRect.X);
                //refreshRect.Width = Math.Min(lastKnownRect.Width + lastKnownRect.X, this.Width);
                //refreshRect.Width = Math.Min(this.Width - lastKnownRect.X, refreshRect.Width);
                ////create region based on updated rectangle
                ////Region updateRegion = new Region(lastKnownRect);            
                //Region updateRegion = new Region(refreshRect);
                ////repaint the control            
                //Invalidate(updateRegion);
                //Update();
            }

            //Paint the ScrollingTextCtrl.
            protected override void OnPaint(PaintEventArgs pe)
            {
                //Console.WriteLine(pe.ClipRectangle.X + ",  " + pe.ClipRectangle.Y + ",  " + pe.ClipRectangle.Width + ",  " + pe.ClipRectangle.Height);
                //Paint the text to its new position
                DrawScrollingText(pe.Graphics);
                //pass on the graphics obj to the base Control class
                base.OnPaint(pe);
            }

            protected override void OnSizeChanged(EventArgs e)
            {
                p = new PointF(0, this.ClientSize.Height);
                base.OnSizeChanged(e);
            }

            PointF p;
            //Draw the scrolling text on the control        
            public void DrawScrollingText(Graphics canvas)
            {
                canvas.SmoothingMode = SmoothingMode.HighQuality;
                canvas.PixelOffsetMode = PixelOffsetMode.HighQuality;
                //measure the size of the string for placement calculation
                SizeF stringSize = canvas.MeasureString(this.text, this.Font);
                //Calculate the begining x position of where to paint the text
                if (scrollOn)
                {
                    //CalcTextPosition(stringSize);
                }
                //Clear the control with user set BackColor
                if (backgroundBrush != null)
                {
                    canvas.FillRectangle(backgroundBrush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                }
                else
                {
                    canvas.Clear(this.BackColor);
                }

                // Draw the border
                if (showBorder)
                {
                    using (Pen borderPen = new Pen(borderColor))
                        canvas.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                }


                //新增：绘制背景图片
                if (this.BackgroundImage != null)
                {
                    canvas.DrawImage(this.BackgroundImage, this.ClientRectangle);
                }

                //修改滚动方式为由下至上。
                //修改人：王志超
                //时间：2014-05-10
                p = new PointF(0, p.Y - scrollPixelDistance);//设置偏移

                List<string> textRows = GetStringRows(canvas, this.Font, this.text, this.Size.Width);
                string strDraw = "";
                //自动折行处理
                foreach (string str in textRows)
                {
                    strDraw += str + "\n";
                }
                stringSize = canvas.MeasureString(strDraw, this.Font);

                if (p.Y <= -1 * stringSize.Height)
                    p = new PointF(0, this.ClientSize.Height);//重新开始

                if (foregroundBrush == null)
                {
                    using (Brush tempForeBrush = new System.Drawing.SolidBrush(this.ForeColor))
                    {
                        canvas.DrawString(strDraw, this.Font, tempForeBrush, p);
                    }
                }
                else
                {
                    canvas.DrawString(strDraw, this.Font, foregroundBrush, p);
                }

                /*以下内容为原绘制方式*/

                //// Draw the text string in the bitmap in memory
                //if (foregroundBrush == null)
                //{
                //    using (Brush tempForeBrush = new System.Drawing.SolidBrush(this.ForeColor))
                //        canvas.DrawString(this.text, new Font("宋体", 20), tempForeBrush, 0, staticTextPos);
                //}
                //else
                //{
                //    canvas.DrawString(this.text, new Font("宋体", 20), foregroundBrush, 0, staticTextPos);
                //}

                //lastKnownRect = new RectangleF(staticTextPos, yPos, stringSize.Width, stringSize.Height);
                //EnableTextLink(lastKnownRect);
            }

            /// <summary>
            /// 绘制文本自动换行（超出截断）
            /// </summary>
            /// <param name="graphic">绘图图面</param>
            /// <param name="font">字体</param>
            /// <param name="text">文本</param>
            /// <param name="recangle">绘制范围</param>
            private void DrawStringWrap(Graphics graphic, Font font, string text, Rectangle recangle)
            {
                List<string> textRows = GetStringRows(graphic, font, text, recangle.Width);
                int rowHeight = (int)(Math.Ceiling(graphic.MeasureString("测试", font).Height));
                int maxRowCount = recangle.Height / rowHeight;
                int drawRowCount = (maxRowCount < textRows.Count) ? maxRowCount : textRows.Count;
                int top = (recangle.Height - rowHeight * drawRowCount) / 2;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                for (int i = 0; i < drawRowCount; i++)
                {
                    Rectangle fontRectanle = new Rectangle(recangle.Left, top + rowHeight * i, recangle.Width, rowHeight);
                    graphic.DrawString(textRows[i], font, new SolidBrush(Color.Black), fontRectanle, sf);
                }
            }

            /// <summary>
            /// 将文本分行
            /// </summary>
            /// <param name="graphic">绘图图面</param>
            /// <param name="font">字体</param>
            /// <param name="text">文本</param>
            /// <param name="width">行宽</param>
            /// <returns></returns>
            private List<string> GetStringRows(Graphics graphic, Font font, string text, int width)
            {
                int RowBeginIndex = 0;
                int rowEndIndex = 0;
                int textLength = text.Length;
                List<string> textRows = new List<string>();

                for (int index = 0; index < textLength; index++)
                {
                    rowEndIndex = index;
                    if (index == textLength - 1)
                    {
                        textRows.Add(text.Substring(RowBeginIndex));
                    }
                    else if (rowEndIndex + 1 < text.Length && text.Substring(rowEndIndex, 2) == "\r\n")
                    {
                        textRows.Add(text.Substring(RowBeginIndex, rowEndIndex - RowBeginIndex));
                        rowEndIndex = index += 2;
                        RowBeginIndex = rowEndIndex;
                    }
                    else if (graphic.MeasureString(text.Substring(RowBeginIndex, rowEndIndex - RowBeginIndex + 1), font).Width > width)
                    {
                        textRows.Add(text.Substring(RowBeginIndex, rowEndIndex - RowBeginIndex));
                        RowBeginIndex = rowEndIndex;
                    }
                }

                return textRows;
            }

            private void CalcTextPosition(SizeF stringSize)
            {
                switch (scrollDirection)
                {
                    case ScrollDirection.RightToLeft:
                        if (staticTextPos < (-1 * (stringSize.Width)))
                            staticTextPos = this.ClientSize.Width - 1;
                        else
                            staticTextPos -= scrollPixelDistance;
                        break;
                    case ScrollDirection.LeftToRight:
                        if (staticTextPos > this.ClientSize.Width)
                            staticTextPos = -1 * stringSize.Width;
                        else
                            staticTextPos += scrollPixelDistance;
                        break;
                    case ScrollDirection.Bouncing:
                        if (currentDirection == ScrollDirection.RightToLeft)
                        {
                            if (staticTextPos < 0)
                                currentDirection = ScrollDirection.LeftToRight;
                            else
                                staticTextPos -= scrollPixelDistance;
                        }
                        else if (currentDirection == ScrollDirection.LeftToRight)
                        {
                            if (staticTextPos > this.ClientSize.Width - stringSize.Width)
                                currentDirection = ScrollDirection.RightToLeft;
                            else
                                staticTextPos += scrollPixelDistance;
                        }
                        break;
                }

                //Calculate the vertical position for the scrolling text                
                switch (verticleTextPosition)
                {
                    case VerticleTextPosition.Top:
                        yPos = 2;
                        break;
                    case VerticleTextPosition.Center:
                        yPos = (this.ClientSize.Height / 2) - (stringSize.Height / 2);
                        break;
                    case VerticleTextPosition.Botom:
                        yPos = this.ClientSize.Height - stringSize.Height;
                        break;
                }
            }

            #region Mouse over, text link logic
            private void EnableTextLink(RectangleF textRect)
            {
                Point curPt = this.PointToClient(Cursor.Position);

                //if (curPt.X > textRect.Left && curPt.X < textRect.Right
                //    && curPt.Y > textRect.Top && curPt.Y < textRect.Bottom)            
                if (textRect.Contains(curPt))
                {
                    //Stop the text of the user mouse's over the text
                    if (stopScrollOnMouseOver)
                        scrollOn = false;

                    this.Cursor = Cursors.Hand;
                }
                else
                {
                    //Make sure the text is scrolling if user's mouse is not over the text
                    scrollOn = true;

                    this.Cursor = Cursors.Default;
                }
            }

            private void ScrollingText_Click(object sender, System.EventArgs e)
            {
                //Trigger the text clicked event if the user clicks while the mouse 
                //is over the text.  This allows the text to act like a hyperlink
                if (this.Cursor == Cursors.Hand)
                    OnTextClicked(this, new EventArgs());
            }

            public delegate void TextClickEventHandler(object sender, EventArgs args);
            public event TextClickEventHandler TextClicked;

            private void OnTextClicked(object sender, EventArgs args)
            {
                //Call the delegate
                if (TextClicked != null)
                    TextClicked(sender, args);
            }
            #endregion


            #region Properties
            [
            Browsable(true),
            CategoryAttribute("Scrolling Text"),
            Description("The timer interval that determines how often the control is repainted")
            ]
            public int TextScrollSpeed
            {
                set
                {
                    timer.Interval = value;
                }
                get
                {
                    return timer.Interval;
                }
            }

            [
            Browsable(true),
            CategoryAttribute("Scrolling Text"),
            Description("How many pixels will the text be moved per Paint")
            ]
            public int TextScrollDistance
            {
                set
                {
                    scrollPixelDistance = value;
                }
                get
                {
                    return scrollPixelDistance;
                }
            }

            [
            Browsable(true),
            CategoryAttribute("Scrolling Text"),
            Description("The text that will scroll accros the control")
            ]
            public string ScrollText
            {
                set
                {
                    text = value;
                    this.Invalidate();
                    this.Update();
                }
                get
                {
                    return text;
                }
            }

            //[
            //Browsable(true),
            //CategoryAttribute("Scrolling Text"),
            //Description("What direction the text will scroll: Left to Right, Right to Left, or Bouncing")
            //]
            //public ScrollDirection ScrollDirection
            //{
            //    set
            //    {
            //        scrollDirection = value;
            //    }
            //    get
            //    {
            //        return scrollDirection;
            //    }
            //}

            //[
            //Browsable(true),
            //CategoryAttribute("Scrolling Text"),
            //Description("The verticle alignment of the text")
            //]
            //public VerticleTextPosition VerticleTextPosition
            //{
            //    set
            //    {
            //        verticleTextPosition = value;
            //    }
            //    get
            //    {
            //        return verticleTextPosition;
            //    }
            //}

            [
            Browsable(true),
            CategoryAttribute("Scrolling Text"),
            Description("Turns the border on or off")
            ]
            public bool ShowBorder
            {
                set
                {
                    showBorder = value;
                }
                get
                {
                    return showBorder;
                }
            }

            [
            Browsable(true),
            CategoryAttribute("Scrolling Text"),
            Description("The color of the border")
            ]
            public Color BorderColor
            {
                set
                {
                    borderColor = value;
                }
                get
                {
                    return borderColor;
                }
            }

            //[
            //Browsable(true),
            //CategoryAttribute("Scrolling Text"),
            //Description("Determines if the text will stop scrolling if the user's mouse moves over the text")
            //]
            //public bool StopScrollOnMouseOver
            //{
            //    set
            //    {
            //        stopScrollOnMouseOver = value;
            //    }
            //    get
            //    {
            //        return stopScrollOnMouseOver;
            //    }
            //}

            [
            Browsable(true),
            CategoryAttribute("Behavior"),
            Description("Indicates whether the control is enabled")
            ]
            new public bool Enabled
            {
                set
                {
                    timer.Enabled = value;
                    base.Enabled = value;
                }

                get
                {
                    return base.Enabled;
                }
            }

            [
            Browsable(false)
            ]
            public Brush ForegroundBrush
            {
                set
                {
                    foregroundBrush = value;
                }
                get
                {
                    return foregroundBrush;
                }
            }

            [
            ReadOnly(true)
            ]
            public Brush BackgroundBrush
            {
                set
                {
                    backgroundBrush = value;
                }
                get
                {
                    return backgroundBrush;
                }
            }
            #endregion
        }

        public enum ScrollDirection
        {
            RightToLeft,
            LeftToRight,
            TopToBottom,
            BottomToTop,
            Bouncing
        }

        public enum VerticleTextPosition
        {
            Top,
            Center,
            Botom
        }
    }
