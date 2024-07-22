using System;

namespace Lucky
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_LuckyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Count = new System.Windows.Forms.TextBox();
            this.WinningName = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labFinish = new System.Windows.Forms.Label();
            this.labSum = new System.Windows.Forms.Label();
            this.RepeatChoose = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.MeneV = new System.Windows.Forms.PictureBox();
            this.labDisplayNum = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lbcount = new System.Windows.Forms.Label();
            this.stoprun = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeneV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoprun)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "award.png");
            this.imageList1.Images.SetKeyName(1, "award.png");
            this.imageList1.Images.SetKeyName(2, "award.png");
            this.imageList1.Images.SetKeyName(3, "award.png");
            // 
            // btnstart
            // 
            this.btnstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnstart.BackColor = System.Drawing.Color.Yellow;
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstart.ForeColor = System.Drawing.Color.Red;
            this.btnstart.Location = new System.Drawing.Point(702, 22);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(100, 72);
            this.btnstart.TabIndex = 8;
            this.btnstart.Text = "抽奖";
            this.btnstart.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.combox_LuckyType);
            this.panel2.Controls.Add(this.btnstart);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_Count);
            this.panel2.Location = new System.Drawing.Point(0, 1294);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1508, 113);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(296, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "中奖人数:";
            // 
            // combox_LuckyType
            // 
            this.combox_LuckyType.Location = new System.Drawing.Point(0, 0);
            this.combox_LuckyType.Margin = new System.Windows.Forms.Padding(4);
            this.combox_LuckyType.Name = "combox_LuckyType";
            this.combox_LuckyType.Size = new System.Drawing.Size(180, 26);
            this.combox_LuckyType.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择奖项:";
            // 
            // lb_Count
            // 
            this.lb_Count.Location = new System.Drawing.Point(0, 0);
            this.lb_Count.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(148, 29);
            this.lb_Count.TabIndex = 13;
            // 
            // WinningName
            // 
            this.WinningName.AutoSize = true;
            this.WinningName.BackColor = System.Drawing.Color.Transparent;
            this.WinningName.Font = new System.Drawing.Font("SimSun", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningName.ForeColor = System.Drawing.Color.Yellow;
            this.WinningName.Location = new System.Drawing.Point(500, 334);
            this.WinningName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinningName.Name = "WinningName";
            this.WinningName.Size = new System.Drawing.Size(0, 131);
            this.WinningName.TabIndex = 18;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.Location = new System.Drawing.Point(-30, 76);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 120);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(250, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 113);
            this.label6.TabIndex = 22;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labFinish
            // 
            this.labFinish.AutoSize = true;
            this.labFinish.BackColor = System.Drawing.Color.Transparent;
            this.labFinish.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFinish.ForeColor = System.Drawing.Color.Yellow;
            this.labFinish.Location = new System.Drawing.Point(668, 506);
            this.labFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFinish.Name = "labFinish";
            this.labFinish.Size = new System.Drawing.Size(0, 97);
            this.labFinish.TabIndex = 33;
            // 
            // labSum
            // 
            this.labSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSum.AutoSize = true;
            this.labSum.BackColor = System.Drawing.Color.Transparent;
            this.labSum.Font = new System.Drawing.Font("SimSun", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSum.ForeColor = System.Drawing.Color.Yellow;
            this.labSum.Location = new System.Drawing.Point(664, 621);
            this.labSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(0, 131);
            this.labSum.TabIndex = 35;
            // 
            // RepeatChoose
            // 
            this.RepeatChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatChoose.BackColor = System.Drawing.Color.Transparent;
            this.RepeatChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RepeatChoose.Image = global::Lucky.Properties.Resources.again3;
            this.RepeatChoose.Location = new System.Drawing.Point(890, 850);
            this.RepeatChoose.Margin = new System.Windows.Forms.Padding(4);
            this.RepeatChoose.Name = "RepeatChoose";
            this.RepeatChoose.Size = new System.Drawing.Size(180, 66);
            this.RepeatChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RepeatChoose.TabIndex = 30;
            this.RepeatChoose.TabStop = false;
            this.RepeatChoose.Tag = "菜單";
            this.RepeatChoose.Visible = false;
            this.RepeatChoose.Click += new System.EventHandler(this.RepeatChoose_Click);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Image = global::Lucky.Properties.Resources.start3;
            this.start.Location = new System.Drawing.Point(400, 850);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(180, 66);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start.TabIndex = 28;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseForm.Image = global::Lucky.Properties.Resources.close2;
            this.CloseForm.Location = new System.Drawing.Point(1406, 3);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(99, 60);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 25;
            this.CloseForm.TabStop = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // MeneV
            // 
            this.MeneV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeneV.BackColor = System.Drawing.Color.Transparent;
            this.MeneV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MeneV.Image = global::Lucky.Properties.Resources.menu3;
            this.MeneV.Location = new System.Drawing.Point(644, 850);
            this.MeneV.Margin = new System.Windows.Forms.Padding(4);
            this.MeneV.Name = "MeneV";
            this.MeneV.Size = new System.Drawing.Size(180, 66);
            this.MeneV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MeneV.TabIndex = 31;
            this.MeneV.TabStop = false;
            this.MeneV.Tag = "重新抽獎";
            this.MeneV.Visible = false;
            this.MeneV.Click += new System.EventHandler(this.MenuV_Click);
            // 
            // labDisplayNum
            // 
            this.labDisplayNum.BackColor = System.Drawing.Color.Transparent;
            this.labDisplayNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labDisplayNum.Font = new System.Drawing.Font("SimSun", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDisplayNum.ForeColor = System.Drawing.Color.Yellow;
            this.labDisplayNum.Location = new System.Drawing.Point(602, 594);
            this.labDisplayNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDisplayNum.Name = "labDisplayNum";
            this.labDisplayNum.Size = new System.Drawing.Size(718, 183);
            this.labDisplayNum.TabIndex = 78;
            this.labDisplayNum.Text = "97**45*";
            this.labDisplayNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labDisplayNum.Visible = false;
            // 
            // lblGrade
            // 
            this.lblGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.Transparent;
            this.lblGrade.Font = new System.Drawing.Font("SimSun", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.Yellow;
            this.lblGrade.Location = new System.Drawing.Point(440, 405);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 90);
            this.lblGrade.TabIndex = 75;
            this.lblGrade.Visible = false;
            // 
            // lbcount
            // 
            this.lbcount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbcount.AutoSize = true;
            this.lbcount.BackColor = System.Drawing.Color.Transparent;
            this.lbcount.Font = new System.Drawing.Font("SimSun", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcount.ForeColor = System.Drawing.Color.Yellow;
            this.lbcount.Location = new System.Drawing.Point(570, 261);
            this.lbcount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(0, 90);
            this.lbcount.TabIndex = 76;
            this.lbcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbcount.Visible = false;
            // 
            // stoprun
            // 
            this.stoprun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stoprun.BackColor = System.Drawing.Color.Transparent;
            this.stoprun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stoprun.Image = global::Lucky.Properties.Resources.stop31;
            this.stoprun.Location = new System.Drawing.Point(640, 850);
            this.stoprun.Margin = new System.Windows.Forms.Padding(4);
            this.stoprun.Name = "stoprun";
            this.stoprun.Size = new System.Drawing.Size(180, 66);
            this.stoprun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stoprun.TabIndex = 77;
            this.stoprun.TabStop = false;
            this.stoprun.Visible = false;
            this.stoprun.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnstart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lucky.Properties.Resources.B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1509, 1106);
            this.Controls.Add(this.labDisplayNum);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.labFinish);
            this.Controls.Add(this.RepeatChoose);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WinningName);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MeneV);
            this.Controls.Add(this.stoprun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeneV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoprun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox lb_Count;
        private System.Windows.Forms.Label WinningName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_LuckyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CloseForm;
        private System.Windows.Forms.PictureBox RepeatChoose;
        private System.Windows.Forms.PictureBox MeneV;
        private System.Windows.Forms.Label labFinish;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label labDisplayNum;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.PictureBox stoprun;
        private System.Windows.Forms.Timer timer1;
    }
}

