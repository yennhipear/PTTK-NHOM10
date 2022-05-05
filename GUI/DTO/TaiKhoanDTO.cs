using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    class TaiKhoanDTO
    {
        string username;
        string password;
        string confirmPass;
        string name;
        string gender;
        string cmnd;
        string sdt;
        string email;
        string diachi;
        DateTime ngaysinh;

        public TaiKhoanDTO() { }
        public TaiKhoanDTO(string username, string password, string confirmPass, string name, string gender, string cmnd, string sdt, string email, string diachi, DateTime ngaysinh)
        {
            this.username = username;
            this.password = password;
            this.confirmPass = confirmPass;
            this.name = name;
            this.gender = gender;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.email = email;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmPass { get => confirmPass; set => confirmPass = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }

}
