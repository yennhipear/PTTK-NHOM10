using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GUI.DAO;
using System.Windows.Forms;

namespace GUI.BUS
{
    class DangKyTiemChungBUS
    {
        public DangKyTiemChungBUS() { }
        public DataTable LayDSVacxinHT()
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayDSVacxinHT();
            if (dao == null)
                MessageBox.Show("Đã xảy ra lỗi! Không thể lấy danh sách vắc xin");

            return dao.LayDSVacxinHT();
        }
    }
}
