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
    class DSVacxinBUS
    {
        public DSVacxinBUS() { }
        public DataTable LayDSVacxinHT()
        {
            VacxinDAO dao = new VacxinDAO();
            DataTable dataTable = dao.LayDSVacxinHT();
            
            return dataTable;
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
          
            String[] result = new String[2];
            result[0] = $"{dataTable.Rows[0]["HANGVACXIN"].ToString()}";
            result[1] = $"{dataTable.Rows[0]["MOTA"].ToString()}";

            return result;
        }

    }
}
