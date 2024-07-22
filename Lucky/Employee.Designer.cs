namespace Lucky
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_CardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_CardNo
            // 
            this.txt_CardNo.Font = new System.Drawing.Font("PMingLiU", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CardNo.Location = new System.Drawing.Point(91, 295);
            this.txt_CardNo.Name = "txt_CardNo";
            this.txt_CardNo.Size = new System.Drawing.Size(633, 47);
            this.txt_CardNo.TabIndex = 2;
            this.txt_CardNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "参与抽奖人员刷卡窗口";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(566, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "魏莎保存成功!";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lucky.Properties.Resources.bgreg2;
            this.ClientSize = new System.Drawing.Size(801, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CardNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参与抽奖人员信息采集窗口";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Employee_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}