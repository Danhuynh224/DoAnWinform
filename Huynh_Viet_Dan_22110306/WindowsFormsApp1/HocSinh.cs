using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class HocSinh: Person
    {
  
        public HocSinh(string ten, string diachi, string cmnd, DateTime dob, string id, string phone, string email, string gender) : base(ten,diachi,cmnd,dob,id,phone,email,gender)
        {
           
        }
    }

}
