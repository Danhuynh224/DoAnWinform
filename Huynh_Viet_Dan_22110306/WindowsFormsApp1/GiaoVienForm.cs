using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GiaoVienForm : Form
    {
        
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDao Giaoviendao = new GiaoVienDao();
        
        public GiaoVienForm()
        {
            InitializeComponent();
            ucGiaoVien.BtnAdd.Click += btnAdd_Click;
            ucGiaoVien.BtnDelete.Click += btnDelete_Click;
            ucGiaoVien.BtnEdit.Click += btnEdit_Click;
        }

        private void GiaoVienForm_Load(object sender, EventArgs e)
        {
            ucGiaoVien.GVStudent.DataSource = Giaoviendao.LoadForm();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            GiaoVien gv = new GiaoVien(ucGiaoVien.TxtName.Text, ucGiaoVien.TxtAddress.Text, ucGiaoVien.TxtCMND.Text, ucGiaoVien.DTPBirthday.Value.Date, ucGiaoVien.TxtID.Text, ucGiaoVien.Mtxtphone.Text, ucGiaoVien.Txtmail.Text, ucGiaoVien.CboGender.Text);
            if (gv.check())
            {
                Giaoviendao.Add(gv);
                GiaoVienForm_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Giaoviendao.Delete(ucGiaoVien.TxtID.Text);
            GiaoVienForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(ucGiaoVien.TxtName.Text, ucGiaoVien.TxtAddress.Text, ucGiaoVien.TxtCMND.Text, ucGiaoVien.DTPBirthday.Value.Date, ucGiaoVien.TxtID.Text, ucGiaoVien.Mtxtphone.Text, ucGiaoVien.Txtmail.Text, ucGiaoVien.CboGender.Text);

            if (gv.check())
            {
                Giaoviendao.Edit(gv);
                GiaoVienForm_Load(sender, e);
            }
        }


        private void btnHs_Click(object sender, EventArgs e)
        {
            Hide();
            HocSinhForm hocSinhForm = new HocSinhForm();
            hocSinhForm.ShowDialog();
        }
    }
}
