using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Person
    {
        private string ten;
        private string diachi;
        private string cmnd;
        private DateTime dob;
        private string id;
        private string phone;
        private string email;
        private string gender;

        public Person(string ten, string diachi, string cmnd, DateTime dob, string id, string phone, string email, string gender)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.dob = dob;
            this.Id = id;
            this.Phone = phone;
            this.Email = email;
            this.Gender = gender;
        }
        public  bool check()
        {
            // Kiểm tra dữ liệu thêm có rỗng hay không?
            if (ten == "" || diachi == "" || cmnd == "" || id == "" || phone == "" || email == "" || gender == "")
            {
                MessageBox.Show("Da nhạp vào dữ liệu rỗng");
                return false;
            }
            // Biểu thức  kiểm tra email
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(this.email) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            // Biểu thức kiểm tra số điện thoại (dạng xxx-xxxx-xxx)
            pattern = @"^\d{3}-\d{4}-\d{3}$";
            regex = new Regex(pattern);
            if (regex.IsMatch(this.phone) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }
            // Kiểm tra tuổi
            int tuoi = (int)(((DateTime.Now- dob ).Days)/365.25);
            if (tuoi < 17)
            {
                MessageBox.Show("Chưa đủ 18 tuổi!!");
                return false;
            }
            return true;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
