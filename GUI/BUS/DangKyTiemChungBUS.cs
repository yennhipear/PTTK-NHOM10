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

        public String[] LayCTVacxin(String maVacxin)
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayCTVacxin(maVacxin);
            if (dao == null)
            {
                MessageBox.Show("Đã xảy ra lỗi! Không thể lấy chi tiết vắc xin");
                return null;
            }

            String[] result = new String[2];
            result[0] = $"Hãng sản xuất: {dataTable.Rows[0]["HANGVACXIN"].ToString()}";
            result[1] = $"Mô tả: {dataTable.Rows[0]["MOTA"].ToString()}";

            return result;
        }
    }
}
