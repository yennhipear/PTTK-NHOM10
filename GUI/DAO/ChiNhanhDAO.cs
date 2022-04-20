using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAO
{
    class ChiNhanhDAO
    {
        private static ChiNhanhDAO Instance = null;

        private ChiNhanhDAO() { }

        public static ChiNhanhDAO getInstance()
        {
            if (Instance == null)
                Instance = new ChiNhanhDAO();
            return Instance;
        }
        public List<String> LayDSTenCN()
        {
            DataTable dt = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select TENCN from CHINHANH"));
            List<String> result = new List<String>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[0].ToString());
            }
            return result;
        }
    }
}
