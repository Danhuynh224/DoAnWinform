using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
   
    public partial class HocSinhForm : Form
    {
        HocSinhDAO hocSinhDAO = new HocSinhDAO();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public HocSinhForm()
        {  
            InitializeComponent();         
            ucHocSinh.BtnAdd.Click += btnAdd_Click;
            ucHocSinh.BtnDelete.Click += btnDelete_Click;
            ucHocSinh.BtnEdit.Click += btnEdit_Click;
        }

        private void HocSinhForm_Load(object sender, EventArgs e)
        {
            ucHocSinh.GVStudent.DataSource = hocSinhDAO.LoadForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           HocSinh hs = new HocSinh(ucHocSinh.TxtName.Text, ucHocSinh.TxtAddress.Text, ucHocSinh.TxtCMND.Text, ucHocSinh.DTPBirthday.Value.Date, ucHocSinh.TxtID.Text, ucHocSinh.Mtxtphone.Text, ucHocSinh.Txtmail.Text, ucHocSinh.CboGender.Text);
           if (hs.check())
           {
               hocSinhDAO.Add(hs);
               HocSinhForm_Load(sender, e);
           }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            hocSinhDAO.Delete(ucHocSinh.TxtID.Text);
            HocSinhForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

           HocSinh hs = new HocSinh(ucHocSinh.TxtName.Text, ucHocSinh.TxtAddress.Text, ucHocSinh.TxtCMND.Text, ucHocSinh.DTPBirthday.Value.Date, ucHocSinh.TxtID.Text, ucHocSinh.Mtxtphone.Text, ucHocSinh.Txtmail.Text, ucHocSinh.CboGender.Text);
           if (hs.check())
           {
                hocSinhDAO.Edit(hs);
                HocSinhForm_Load(sender, e);
            }
          
        }

        private void btnGv_Click(object sender, EventArgs e)
        {
            Hide();
            GiaoVienForm giaoVienForm = new GiaoVienForm();
            giaoVienForm.ShowDialog();
        }   
    }
}
