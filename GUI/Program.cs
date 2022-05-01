using GUI.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu());
            Application.Run(new KHDangNhapGUI());
            //Application.Run(new DangKyTaiKhoanGUI());
            //Application.Run(new DatMuaVacxinGUI());
            // xac nhan xong matkhau, dem ham hash, luu kq hash vao cot password, dang nhap tuong tu, so sanh 2 cot
        }
    }
}
