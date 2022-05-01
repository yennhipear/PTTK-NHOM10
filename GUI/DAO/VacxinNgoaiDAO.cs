﻿using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GUI.DAO
{
    class VacxinNgoaiDAO
    {
        private static VacxinNgoaiDAO Instance = null;
        private VacxinNgoaiDAO() { }

        public static VacxinNgoaiDAO getInstance()
        {
            if (Instance == null)
                Instance = new VacxinNgoaiDAO();
            return Instance;
        }

        public DataTable LayDSPhieuDKTC()
        {
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(new SqlCommand("Select MAPDK, MAKH, THOIGIANDK, TINHTRANG from PHIEUDANGKYTIEMCHUNG"));
            return result;
        }

        public PhieuDangKyTiemChungDTO LayThongTinPhieuDKTC(String maPDK)
        {
            SqlCommand command = new SqlCommand(
                @"Select pdk.MAPDK, pdk.MAKH, kh.HOTENKH, kh.DIACHIKH, kh.GIOITINHKH, kh.SDTKH, kh.NGAYSINHKH,
                    pdk.HoTenNT, pdk.CMNDNT, pdk.DIACHINT, pdk.GioiTinhNT, pdk.SDTNT, pdk.NGSINHNT, pdk.QUANHE, pdk.TINHTRANG, pdk.THOIGIANDK
                    From PHIEUDANGKYTIEMCHUNG pdk left join KHACHHANG kh on(pdk.MAKH = kh.MAKH)
                    Where pdk.MAPDK = @maPDK");
            command.Parameters.Add(new SqlParameter("@maPDK", maPDK));
            DataTable result = DataProviderDAO.getInstance().ExecuteQuery(command);

            String MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT, SDTNT, QUANHE, TinhTrang;
            String HoTenKH, DiaChiKH, GioiTinhKH, SDTKH;
            DateTime NgayDK, NgSinhNT, NgSinhKH;

            MaPDKTC = result.Rows[0]["MAPDK"].ToString();
            MaKH = result.Rows[0]["MaKH"].ToString();
            HoTenNT = result.Rows[0]["HoTenNT"].ToString();
            CMNDNT = result.Rows[0]["CMNDNT"].ToString();
            DiaChiNT = result.Rows[0]["DiaChiNT"].ToString();
            GioiTinhNT = result.Rows[0]["GioiTinhNT"].ToString();
            SDTNT = result.Rows[0]["SDTNT"].ToString();
            QUANHE = result.Rows[0]["QUANHE"].ToString();
            TinhTrang = result.Rows[0]["TinhTrang"].ToString();
            HoTenKH = result.Rows[0]["HoTenKH"].ToString();
            DiaChiKH = result.Rows[0]["DiaChiKH"].ToString();
            GioiTinhKH = result.Rows[0]["GioiTinhKH"].ToString();
            SDTKH = result.Rows[0]["SDTKH"].ToString();

            if (DateTime.TryParse(result.Rows[0]["THOIGIANDK"].ToString(), out NgayDK) == false)
                NgayDK = new DateTime();

            if (DateTime.TryParse(result.Rows[0]["NGSINHNT"].ToString(), out NgSinhNT) == false)
                NgSinhNT = new DateTime();

            if (DateTime.TryParse(result.Rows[0]["NGAYSINHKH"].ToString(), out NgSinhKH) == false)
                NgSinhKH = new DateTime();


            PhieuDangKyTiemChungDTO phieuDangKy = new PhieuDangKyTiemChungDTO(MaPDKTC, MaKH, HoTenNT, CMNDNT, DiaChiNT, GioiTinhNT,
                SDTNT, QUANHE, TinhTrang, HoTenKH, DiaChiKH, GioiTinhKH, SDTKH, NgayDK, NgSinhNT, NgSinhKH);
            return phieuDangKy;
        }
    }
}
