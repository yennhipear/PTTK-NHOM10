using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI.DAO
{
    class PhieuDangKyTiemChungDAO
    {
        private static PhieuDangKyTiemChungDAO Instance = null;

        private PhieuDangKyTiemChungDAO() { }

        public static PhieuDangKyTiemChungDAO getInstance()
        {
            if (Instance == null)
                Instance = new PhieuDangKyTiemChungDAO();
            return Instance;
        }

        public int LuuThongTinDangKy(PhieuDangKyTiemChungDTO phieuDangKy)
        {
            SqlCommand command = phieuDangKy.getInsertSqlCommand();

            int result = DataProviderDAO.getInstance().ExecuteNonQuery(command);
            return result;
           
        }
    }
}
