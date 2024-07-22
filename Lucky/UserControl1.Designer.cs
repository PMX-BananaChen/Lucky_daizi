using System.Windows.Forms;
namespace Lucky
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.lab_offdutyHour = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lab_offdutyHour
            // 
            this.lab_offdutyHour.AutoSize = true;
            this.lab_offdutyHour.ForeColor = System.Drawing.Color.Red;
            this.lab_offdutyHour.Location = new System.Drawing.Point(57, 62);
            this.lab_offdutyHour.Name = "lab_offdutyHour";
            this.lab_offdutyHour.Size = new System.Drawing.Size(0, 12);
            this.lab_offdutyHour.TabIndex = 6;
            this.lab_offdutyHour.Click += new System.EventHandler(this.lab_offdutyHour_Click);
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_name.Font = new System.Drawing.Font("NSimSun", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Black;
            this.lb_name.Location = new System.Drawing.Point(94, 167);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(132, 61);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "label1";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_name.Click += new System.EventHandler(this.lab_day_Click);
            // 
            // lb_photo
            // 
            this.lb_photo.ImageLocation = "E:\\F20180717\\工作\\Code\\Lucky\\Lucky_IT\\Lucky\\bin\\Debug\\photo\\82539.bmp";
            this.lb_photo.Location = new System.Drawing.Point(15, 0);
            this.lb_photo.Name = "lb_photo";
            this.lb_photo.Size = new System.Drawing.Size(285, 164);
            this.lb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_photo.TabIndex = 7;
            this.lb_photo.TabStop = false;
            this.lb_photo.Click += new System.EventHandler(this.lb_photo_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_photo);
            this.Controls.Add(this.lab_offdutyHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_name);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(319, 228);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.lb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
                return parms;
            }
        }
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_offdutyHour;
        private Label lb_name;
        private PictureBox lb_photo;
    }
}
