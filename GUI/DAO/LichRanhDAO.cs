using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI.DAO
{
    class LichRanhDAO
    {
        static public bool themLichRanh(LichRanhDTO lrInfo)
        {
            string dklrQuery = "INSERT INTO LICHRANH VALUES ";
            for(int i = 0; i < lrInfo.regArr.Count - 1; ++i)
            {
                dklrQuery += $"({lrInfo.userID}, '{lrInfo.regArr[i][0]}', {lrInfo.regArr[i][1]}),";
            }
            List<dynamic> last = new List<dynamic>(lrInfo.regArr[lrInfo.regArr.Count - 1]);
            dklrQuery += $"({lrInfo.userID}, '{last[0]}', {last[1]})";
            DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand(dklrQuery));
            //MessageBox.Show(dklrQuery);
            return true;
        }
    }
}
