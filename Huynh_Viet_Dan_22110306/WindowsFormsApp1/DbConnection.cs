using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DbConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Process(string sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format(sql);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                MessageBox.Show(cmd.ToString());
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
                else
                    MessageBox.Show("Nhap sai" );
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadForm(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
