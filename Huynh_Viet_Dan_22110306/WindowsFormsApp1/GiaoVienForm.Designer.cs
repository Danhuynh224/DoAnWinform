namespace WindowsFormsApp1
{
    partial class GiaoVienForm
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
            this.lblNameForm = new System.Windows.Forms.Label();
            this.ucGiaoVien = new WindowsFormsApp1.UCThongTin();
            this.btnHs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameForm
            // 
            this.lblNameForm.AutoSize = true;
            this.lblNameForm.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraBo", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.Location = new System.Drawing.Point(57, 8);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(378, 72);
            this.lblNameForm.TabIndex = 26;
            this.lblNameForm.Text = "Quản Lý Giáo Viên";
            // 
            // ucGiaoVien
            // 
            this.ucGiaoVien.Location = new System.Drawing.Point(-6, 70);
            this.ucGiaoVien.Name = "ucGiaoVien";
            this.ucGiaoVien.Size = new System.Drawing.Size(1445, 562);
            this.ucGiaoVien.TabIndex = 27;
      
            // 
            // btnHs
            // 
            this.btnHs.BackColor = System.Drawing.Color.Cyan;
            this.btnHs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHs.Location = new System.Drawing.Point(956, 516);
            this.btnHs.Name = "btnHs";
            this.btnHs.Size = new System.Drawing.Size(108, 61);
            this.btnHs.TabIndex = 28;
            this.btnHs.Text = "Học Sinh";
            this.btnHs.UseVisualStyleBackColor = false;
            this.btnHs.Click += new System.EventHandler(this.btnHs_Click);
            // 
            // GiaoVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 706);
            this.Controls.Add(this.btnHs);
            this.Controls.Add(this.lblNameForm);
            this.Controls.Add(this.ucGiaoVien);
            this.Name = "GiaoVienForm";
            this.Text = "FGiangVien";
            this.Load += new System.EventHandler(this.GiaoVienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameForm;
        private UCThongTin ucGiaoVien;
        private System.Windows.Forms.Button btnHs;
    }
}