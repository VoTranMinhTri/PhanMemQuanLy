using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
namespace BAL
{
    public class BAL_Luong
    {
        public DataTable LayDanhSachLuong()
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                return objdal.DocLuong();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool CapNhatLaiTrangThaiLuong(int manv, int thang, int nam)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                bool kq = objdal.CapNhatLaiTrangThaiLuong(manv, thang, nam);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemLuong(Luong luong)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                bool kq = objdal.ThemLuong(luong);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaLuong(int manv, int thang, int nam)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                bool kq = objdal.XoaLuong(manv, thang, nam);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaLuong(Luong luong, int manv, int thang, int nam)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                bool kq = objdal.SuaLuong(luong,manv, thang, nam);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemLuongCuaNV(string manv)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                return objdal.TimKiemLuongCuaNV(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemLuongCuaNVTheoNam(string nam)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                return objdal.TimKiemLuongCuaNVTheoNam(nam);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemLuongCuaNVTheoThang(string thang)
        {
            try
            {
                DAL_Luong objdal = new DAL_Luong();
                return objdal.TimKiemLuongCuaNVTheoThang(thang);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
