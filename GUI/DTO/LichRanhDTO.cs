using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DTO
{
    class LichRanhDTO
    {
        public int userID;
        public int week;
        public List<List<int>> regArr;
        public LichRanhDTO(int userID, int week, List<List<int>> dklrArr)
        {
            this.userID = userID;
            this.week = week;
            regArr = new List<List<int>>();
            for(int i = 0; i < dklrArr.Count; ++i)
            {
                regArr.Add(new List<int>(dklrArr[i]));
            }
        }
    }
}
