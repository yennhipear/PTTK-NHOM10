using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    class ChiNhanhDTO
    {
        String MaCN,TenCN, DiaChiCN;

        public ChiNhanhDTO()
        {
        }

        public ChiNhanhDTO(String maCN, string tenCN, string diaChiCN)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChiCN = diaChiCN;
        }

        public static List<ChiNhanhDTO> ConvertToListFromDataTable(DataTable dt)
        {
            List<ChiNhanhDTO> result = new List<ChiNhanhDTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiNhanhDTO cn = new ChiNhanhDTO();
                cn.MaCN = row.Table.Columns[0].ToString();
                cn.TenCN = row.Table.Columns[1].ToString();
                cn.DiaChiCN = row.Table.Columns[2].ToString();
            }
            return result;
        }
    }
}
