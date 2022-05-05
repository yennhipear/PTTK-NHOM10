using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    class CurrentUser
    {		       
        private static CurrentUser Instance = null;

        private CurrentUser() { }

        public static String Ma { get; set; }
        public static String HoTen { get; set; }
        public static String DiaChi { get; set; }
        public static String GioiTinh { get; set; }
        public static String Email { get; set; }
        public static String Cmnd { get; set; }
        public static String Sdt { get; set; }
        public static String Username { get; set; }
        public static DateTime NgaySinh { get; set; }
        public static bool isNhanVien { get; set; }

        public static CurrentUser getInstance()
        {
            if (Instance == null)
                Instance = new CurrentUser();
            return Instance;
        }

    }
}
