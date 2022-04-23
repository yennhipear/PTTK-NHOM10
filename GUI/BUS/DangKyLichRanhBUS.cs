using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BUS
{
    class DangKyLichRanhBUS
    {
        static private string getOnlyDay(string dayStr)
        {
            string onlyDateStr = dayStr.Substring(0, dayStr.IndexOf(' '));
            DateTime onlyDate = DateTime.Parse(onlyDateStr, CultureInfo.CreateSpecificCulture("vi-VN"));
            return onlyDate.ToString("yyyy-MM-dd");
        }

        static private int getShiftInt(string shiftStr)
        {
            switch (shiftStr)
            {
                case "Sáng":
                    return 0;
                case "Chiều":
                    return 1;
                case "Tối":
                    return 2;
                default:
                    return -1;
            }
        }
        static public bool dangKyLichRanh(int userID, DataGridView dklrDGV)
        {
            // check null
            for(int i = 0; i < dklrDGV.Rows.Count - 1; ++i)
            {
                if(dklrDGV.Rows[i].Cells[0].Value == null || dklrDGV.Rows[i].Cells[1].Value == null)
                {
                    return false;
                }
            }
            List<List<dynamic>> dklrArr = new List<List<dynamic>>();
            string day;
            int shift;
            for (int i = 0; i < dklrDGV.Rows.Count - 1; ++i)
            {
                day = getOnlyDay(dklrDGV.Rows[i].Cells["dklrDay"].Value.ToString());
                shift = getShiftInt(dklrDGV.Rows[i].Cells["dklrShift"].Value.ToString());
                dklrArr.Add(new List<dynamic>{ day, shift });
            }
            LichRanhDTO lrInfo = new LichRanhDTO(userID, dklrArr);
            LichRanhDAO.themLichRanh(lrInfo);
            return true;
        }
    }
}
