namespace WindowsFormsApp1
{
    partial class HocSinhForm
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
            this.btnGv = new System.Windows.Forms.Button();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.ucHocSinh = new WindowsFormsApp1.UCThongTin();
            this.SuspendLayout();
            // 
            // btnGv
            // 
            this.btnGv.BackColor = System.Drawing.Color.Cyan;
            this.btnGv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGv.Location = new System.Drawing.Point(970, 537);
            this.btnGv.Name = "btnGv";
            this.btnGv.Size = new System.Drawing.Size(108, 61);
            this.btnGv.TabIndex = 12;
            this.btnGv.Text = "Giáo Viên";
            this.btnGv.UseVisualStyleBackColor = false;
            this.btnGv.Click += new System.EventHandler(this.btnGv_Click);
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.Location = new System.Drawing.Point(54, 31);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(366, 72);
            this.lblNameForm.TabIndex = 27;
            this.lblNameForm.Text = "Quản Lý Học Sinh";
            // 
            // ucHocSinh
            // 
            this.ucHocSinh.Location = new System.Drawing.Point(-2, 90);
            this.ucHocSinh.Name = "ucHocSinh";
            this.ucHocSinh.Size = new System.Drawing.Size(1445, 557);
            this.ucHocSinh.TabIndex = 42;
            // 
            // HocSinhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 736);
            this.Controls.Add(this.lblNameForm);
            this.Controls.Add(this.btnGv);
            this.Controls.Add(this.ucHocSinh);
            this.Name = "HocSinhForm";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.HocSinhForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGv;
        private System.Windows.Forms.Label lblNameForm;
        private UCThongTin ucHocSinh;
    }
}

