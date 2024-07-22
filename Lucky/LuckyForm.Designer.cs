namespace Lucky
{
    partial class LuckyForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ilface = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbcount = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labDisplayNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ilface
            // 
            this.ilface.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ilface.ImageSize = new System.Drawing.Size(200, 220);
            this.ilface.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbcount
            // 
            this.lbcount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcount.AutoSize = true;
            this.lbcount.BackColor = System.Drawing.Color.Transparent;
            this.lbcount.Font = new System.Drawing.Font("SimSun", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcount.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbcount.Location = new System.Drawing.Point(534, 279);
            this.lbcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(0, 90);
            this.lbcount.TabIndex = 69;
            this.lbcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbcount.Click += new System.EventHandler(this.lbcount_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("SimSun", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblGrade.Location = new System.Drawing.Point(430, 434);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 90);
            this.lblGrade.TabIndex = 68;
            this.lblGrade.Click += new System.EventHandler(this.lblGrade_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::Lucky.Properties.Resources.stop3;
            this.pictureBox3.Location = new System.Drawing.Point(644, 834);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labDisplayNum
            // 
            this.labDisplayNum.AutoSize = true;
            this.labDisplayNum.BackColor = System.Drawing.Color.Transparent;
            this.labDisplayNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labDisplayNum.Font = new System.Drawing.Font("SimSun", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDisplayNum.ForeColor = System.Drawing.Color.LimeGreen;
            this.labDisplayNum.Location = new System.Drawing.Point(674, 626);
            this.labDisplayNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDisplayNum.Name = "labDisplayNum";
            this.labDisplayNum.Size = new System.Drawing.Size(714, 182);
            this.labDisplayNum.TabIndex = 74;
            this.labDisplayNum.Text = "97**45*";
            this.labDisplayNum.Click += new System.EventHandler(this.labDisplayNum_Click);
            // 
            // LuckyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lucky.Properties.Resources.Bk5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 1106);
            this.Controls.Add(this.labDisplayNum);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LuckyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "抽奖系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LuckyForm_FormClosing);
            this.Load += new System.EventHandler(this.LuckyForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LuckyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilface;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labDisplayNum;
    }
}