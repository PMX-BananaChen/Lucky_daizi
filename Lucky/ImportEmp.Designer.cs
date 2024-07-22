namespace Lucky
{
    partial class ImportEmp
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.PictureBox();
            this.EmpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlantNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "导入(&I)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "浏览(&Q)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 29);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpNo,
            this.EmpName,
            this.DeptName,
            this.CardNo,
            this.PlantNo,
            this.EmpInDate,
            this.Prize});
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 465);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 148);
            this.panel1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1180, 62);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "导出中獎";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(938, 62);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "全部导出";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1059, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "清空人員";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "名單導入:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(412, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 149);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 76);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 34);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "正在導入中,請稍後...";
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseForm.Image = global::Lucky.Properties.Resources.close2;
            this.CloseForm.Location = new System.Drawing.Point(1208, 2);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(99, 63);
            this.CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseForm.TabIndex = 27;
            this.CloseForm.TabStop = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // EmpNo
            // 
            this.EmpNo.DataPropertyName = "EmpNo";
            this.EmpNo.HeaderText = "工號";
            this.EmpNo.Name = "EmpNo";
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "姓名";
            this.EmpName.Name = "EmpName";
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "部門";
            this.DeptName.Name = "DeptName";
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "卡號";
            this.CardNo.Name = "CardNo";
            // 
            // PlantNo
            // 
            this.PlantNo.DataPropertyName = "PlantNo";
            this.PlantNo.HeaderText = "廠別";
            this.PlantNo.Name = "PlantNo";
            // 
            // EmpInDate
            // 
            this.EmpInDate.HeaderText = "入职日期";
            this.EmpInDate.Name = "EmpInDate";
            this.EmpInDate.Width = 140;
            // 
            // Prize
            // 
            this.Prize.DataPropertyName = "Prize";
            this.Prize.HeaderText = "中獎獎項";
            this.Prize.Name = "Prize";
            this.Prize.Width = 140;
            // 
            // ImportEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 784);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportEmp";
            this.Load += new System.EventHandler(this.ImportEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox CloseForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlantNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prize;
    }
}