using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UCThongTin : UserControl
    {
        public UCThongTin()
        {
            InitializeComponent();
        }

        private void gVStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = GVStudent.Rows[e.RowIndex];
                    TxtName.Text = row.Cells[0].Value.ToString();
                    TxtID.Text = row.Cells[1].Value.ToString();
                    TxtAddress.Text = row.Cells[2].Value.ToString();
                    TxtCMND.Text = row.Cells[3].Value.ToString();
                    DTPBirthday.Value = (DateTime)row.Cells[4].Value;
                    Txtmail.Text = row.Cells[5].Value.ToString();
                    Mtxtphone.Text = row.Cells[6].Value.ToString();
                    CboGender.Text = row.Cells[7].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Chon lai");
            }
        }
    }
}
