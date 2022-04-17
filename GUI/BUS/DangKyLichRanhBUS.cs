using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BUS
{
    class DangKyLichRanhBUS
    {
        static private int getDayInt(string dayStr)
        {
            switch(dayStr)
            {
                case "Thứ hai":
                    return 0;
                case "Thứ ba":
                    return 1;
                case "Thứ tư":
                    return 2;
                case "Thứ năm":
                    return 3;
                case "Thứ sáu":
                    return 4;
                case "Thứ bảy":
                    return 5;
                default:
                    return -1;
            }
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
        static public bool dangKyLichRanh(int userID, int week, DataGridView dklrDGV)
        {
            // check null
            for(int i = 0; i < dklrDGV.Rows.Count - 1; ++i)
            {
                if(dklrDGV.Rows[i].Cells[0].Value == null || dklrDGV.Rows[i].Cells[1].Value == null)
                {
                    return false;
                }
            }
            List<List<int>> dklrArr = new List<List<int>>();
            int day, shift;
            for (int i = 0; i < dklrDGV.Rows.Count - 1; ++i)
            {
                day = getDayInt(dklrDGV.Rows[i].Cells["dklrDay"].Value.ToString());
                shift = getShiftInt(dklrDGV.Rows[i].Cells["dklrShift"].Value.ToString());
                dklrArr.Add(new List<int>{ day, shift });
            }
            LichRanhDTO lrInfo = new LichRanhDTO(userID, week, dklrArr);
            LichRanhDAO.themLichRanh(lrInfo);
            return true;
        }
    }
}
