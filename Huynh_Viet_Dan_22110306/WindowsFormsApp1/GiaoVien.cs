using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GiaoVien : Person
    {
       
        public GiaoVien(string ten, string diachi, string cmnd, DateTime dob,string id, string phone, string email, string gender) : base( ten,  diachi,  cmnd, dob, id, phone, email, gender)
        {    
        }
       
      
    }
}
