using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class UCThongTin
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
            this.lblgender = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gVStudent = new System.Windows.Forms.DataGridView();
            this.dTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtxtphone = new System.Windows.Forms.MaskedTextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(75, 234);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 16);
            this.lblgender.TabIndex = 51;
            this.lblgender.Text = "Giới Tính";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(167, 193);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(196, 22);
            this.txtmail.TabIndex = 50;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(75, 196);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 16);
            this.lblemail.TabIndex = 49;
            this.lblemail.Text = "Email";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.Location = new System.Drawing.Point(50, 153);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(98, 16);
            this.lblsdt.TabIndex = 47;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(167, 102);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 22);
            this.txtID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(10, 371);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(151, 16);
            this.lblBirthday.TabIndex = 44;
            this.lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(167, 320);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(196, 22);
            this.txtCMND.TabIndex = 43;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(76, 323);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(51, 16);
            this.lblCMND.TabIndex = 42;
            this.lblCMND.Text = "CMND";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 271);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 22);
            this.txtAddress.TabIndex = 41;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(75, 274);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 16);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // gVStudent
            // 
            this.gVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVStudent.Location = new System.Drawing.Point(570, 17);
            this.gVStudent.Name = "gVStudent";
            this.gVStudent.RowHeadersWidth = 51;
            this.gVStudent.RowTemplate.Height = 24;
            this.gVStudent.Size = new System.Drawing.Size(871, 324);
            this.gVStudent.TabIndex = 39;
            this.gVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVStudent_CellClick);
            // 
            // dTPBirthday
            // 
            this.dTPBirthday.Location = new System.Drawing.Point(181, 368);
            this.dTPBirthday.Name = "dTPBirthday";
            this.dTPBirthday.Size = new System.Drawing.Size(277, 22);
            this.dTPBirthday.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 22);
            this.txtName.TabIndex = 37;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 16);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Họ và Tên";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Pink;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(768, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 61);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(567, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 61);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(376, 447);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 61);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // mtxtphone
            // 
            this.mtxtphone.Location = new System.Drawing.Point(167, 151);
            this.mtxtphone.Mask = "000-0000-000";
            this.mtxtphone.Name = "mtxtphone";
            this.mtxtphone.Size = new System.Drawing.Size(196, 22);
            this.mtxtphone.TabIndex = 60;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cboGender.Location = new System.Drawing.Point(167, 231);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(196, 24);
            this.cboGender.TabIndex = 61;
            // 
            // UCThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.mtxtphone);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.gVStudent);
            this.Controls.Add(this.dTPBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "UCThongTin";
            this.Size = new System.Drawing.Size(1445, 576);
            ((System.ComponentModel.ISupportInitialize)(this.gVStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblgender;
        private TextBox txtmail;
        private Label lblemail;
        private Label lblsdt;
        private TextBox txtID;
        private Label label1;
        private Label lblBirthday;
        private TextBox txtCMND;
        private Label lblCMND;
        private TextBox txtAddress;
        private Label lblAddress;
        private DataGridView gVStudent;
        private DateTimePicker dTPBirthday;
        private TextBox txtName;
        private Label lblName;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private MaskedTextBox mtxtphone;
        private ComboBox cboGender;

        public Label Label4 { get => lblgender; set => lblgender = value; }
        public TextBox Txtmail { get => txtmail; set => txtmail = value; }
        public Label Label3 { get => lblemail; set => lblemail = value; }
        
        public Label Label2 { get => lblsdt; set => lblsdt = value; }
        public TextBox TxtID { get => txtID; set => txtID = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblBirthday { get => lblBirthday; set => lblBirthday = value; }
        public TextBox TxtCMND { get => txtCMND; set => txtCMND = value; }
        public Label LblCMND { get => lblCMND; set => lblCMND = value; }
        public TextBox TxtAddress { get => txtAddress; set => txtAddress = value; }
        public Label LblAddress { get => lblAddress; set => lblAddress = value; }
        public DataGridView GVStudent { get => gVStudent; set => gVStudent = value; }
        public DateTimePicker DTPBirthday { get => dTPBirthday; set => dTPBirthday = value; }
        public TextBox TxtName { get => txtName; set => txtName = value; }
        public Label LblName { get => lblName; set => lblName = value; }
   
        public Button BtnEdit { get => btnEdit; set => btnEdit = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public MaskedTextBox Mtxtphone { get => mtxtphone; set => mtxtphone = value; }
        public ComboBox CboGender { get => cboGender; set => cboGender = value; }
    }
}
