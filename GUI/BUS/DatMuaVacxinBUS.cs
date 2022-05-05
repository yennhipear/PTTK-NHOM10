using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GUI.DAO;
using GUI.DTO;
using System.Windows.Forms;

namespace GUI.BUS
{
    class DatMuaVacxinBUS
    {

        public DatMuaVacxinBUS() { }
        public DataTable LayDSVacxinHT()
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayDSVacxinHT();
            if (dao == null)
                MessageBox.Show("Đã xảy ra lỗi! Không thể lấy danh sách vắc xin");

            return dao.LayDSVacxinHT();
        }

        
 

        public void LoadTableVacxinNgoai(DataTable table, string maVX, string tenVX, string nguabenh, string gia, string SL)
        {
            table.Rows.Add(maVX, tenVX, nguabenh, gia, SL);
        }

        public DataTable LayDSGoiVacxinHT()
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayDSGoiVacxinHT();

            return dataTable;
        }

        public DataTable LayCTGoiVacxinHT(String maGoiVacxin)
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayCTGoiVacxinHT(maGoiVacxin);

            return dataTable;
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
            result[0] = $"{dataTable.Rows[0]["HANGVACXIN"].ToString()}";
            result[1] = $"{dataTable.Rows[0]["MOTA"].ToString()}";

            return result;
        }

        public int LuuThongTinVacxinNgoai(VacxinNgoaiDTO vacxinNgoai)
        {
            return VacxinNgoaiDAO.getInstance().LuuThongTinVacxinNgoai(vacxinNgoai);

        }

        public int LuuThongTinDatMua(PhieuDatMuaVacxinDTO phieuDatMua)
        {
            return PhieuDatMuaVacxinDAO.getInstance().LuuThongTinDatMua(phieuDatMua);
        }
    }
}
