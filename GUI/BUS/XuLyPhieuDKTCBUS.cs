using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GUI.DAO;
using GUI.DTO;

namespace GUI.BUS
{
    class XuLyPhieuDKTCBUS
    {
        public DataTable LayDSPhieuDKTC()
        {
            DataTable dataTable = PhieuDangKyTiemChungDAO.getInstance().LayDSPhieuDKTC();
            return dataTable;
        }

        public PhieuDangKyTiemChungDTO LayThongTinPhieuDKTC(String maPDK)
        {
            return PhieuDangKyTiemChungDAO.getInstance().LayThongTinPhieuDKTC(maPDK);
        }

        public DataTable LayCTPhieuDKTC(String maPDK)
        {
            return PhieuDangKyTiemChungDAO.getInstance().LayCTPhieuDKTC(maPDK);
        }
        public int CapNhatTinhTrangPhieu(String maPDK, String tinhTrang)
        {
            return PhieuDangKyTiemChungDAO.getInstance().CapNhatTinhTrangPhieu(maPDK, tinhTrang);
        }

    }
}
    