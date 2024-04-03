using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PersonDAO
    {
        string sqlStr;
        DbConnection dbcon = new DbConnection();
        string role;

        public PersonDAO()
        {
            role= this is GiaoVienDao ? "GiaoVien" : "HocSinh";
        }

        public void Delete(string id)
        {
            sqlStr = string.Format("DELETE FROM {1} WHERE ID = {0}", id , role);
            dbcon.Process(sqlStr);
        }
        
        public DataTable LoadForm()
        {
            sqlStr = string.Format("SELECT *FROM {0}", role) ;
            return dbcon.LoadForm(sqlStr);
        }
        public void Add(Person ps)
        {
            sqlStr = string.Format("INSERT INTO "+role+"(Ten , Diachi, Cmnd, DoB, ID, Email, Phone, Gender) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ps.Ten, ps.Diachi, ps.Cmnd, ps.Dob, ps.Id, ps.Email, ps.Phone, ps.Gender);
            dbcon.Process(sqlStr);
        }
        public void Edit(Person ps)
        {
            sqlStr = string.Format("UPDATE "+role+" SET Ten = '{0}', DiaChi = '{1}', DoB='{3}',Cmnd='{4}',Email='{5}', Phone='{6}',Gender='{7}' WHERE ID = {2}", ps.Ten, ps.Diachi, ps.Id, ps.Dob, ps.Cmnd, ps.Email, ps.Phone, ps.Gender); ;
            dbcon.Process(sqlStr);
        }
    }
}
