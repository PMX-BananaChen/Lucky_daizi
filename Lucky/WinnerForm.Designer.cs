namespace Lucky
{
    partial class WinnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.lbldj = new System.Windows.Forms.Label();
            this.FactoryOK = new System.Windows.Forms.Label();
            this.labfirt = new System.Windows.Forms.Label();
            this.labPage = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "10.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 6500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseForm.Image = global::Lucky.Properties.Resources.close2;
            this.CloseForm.Location = new System.Drawing.Point(1257, 3);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(99, 60);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 26;
            this.CloseForm.TabStop = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // lbldj
            // 
            this.lbldj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldj.AutoSize = true;
            this.lbldj.BackColor = System.Drawing.Color.Transparent;
            this.lbldj.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldj.ForeColor = System.Drawing.Color.Yellow;
            this.lbldj.Location = new System.Drawing.Point(424, 273);
            this.lbldj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldj.Name = "lbldj";
            this.lbldj.Size = new System.Drawing.Size(0, 72);
            this.lbldj.TabIndex = 35;
            // 
            // FactoryOK
            // 
            this.FactoryOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FactoryOK.BackColor = System.Drawing.Color.Transparent;
            this.FactoryOK.Font = new System.Drawing.Font("SimSun", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryOK.ForeColor = System.Drawing.Color.Yellow;
            this.FactoryOK.Location = new System.Drawing.Point(168, 394);
            this.FactoryOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FactoryOK.Name = "FactoryOK";
            this.FactoryOK.Size = new System.Drawing.Size(0, 36);
            this.FactoryOK.TabIndex = 36;
            // 
            // labfirt
            // 
            this.labfirt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labfirt.AutoSize = true;
            this.labfirt.BackColor = System.Drawing.Color.Transparent;
            this.labfirt.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labfirt.ForeColor = System.Drawing.Color.Orange;
            this.labfirt.Location = new System.Drawing.Point(354, 610);
            this.labfirt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labfirt.Name = "labfirt";
            this.labfirt.Size = new System.Drawing.Size(0, 36);
            this.labfirt.TabIndex = 39;
            this.labfirt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPage
            // 
            this.labPage.AutoSize = true;
            this.labPage.BackColor = System.Drawing.Color.Transparent;
            this.labPage.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labPage.Location = new System.Drawing.Point(1456, 315);
            this.labPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(0, 29);
            this.labPage.TabIndex = 40;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("KaiTi", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labName.Location = new System.Drawing.Point(820, 670);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 120);
            this.labName.TabIndex = 41;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lucky.Properties.Resources.B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 1035);
            this.ControlBox = false;
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labPage);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.labfirt);
            this.Controls.Add(this.lbldj);
            this.Controls.Add(this.FactoryOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WinnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "中奖记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CloseForm;
        private System.Windows.Forms.Label lbldj;
        private System.Windows.Forms.Label FactoryOK;
        private System.Windows.Forms.Label labfirt;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.Label labName;
    }
}