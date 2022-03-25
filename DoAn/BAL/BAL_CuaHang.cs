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
    public class BAL_CuaHang
    {
        public DataTable LayDanhSachCH()
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.DocCuaHang();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemCuaHang(CuaHang ch)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                bool kq = objdal.ThemCuaHang(ch);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaCuaHang(int mach)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                bool kq = objdal.XoaCuaHang(mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaCuaHang(CuaHang ch, int machcu)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                bool kq = objdal.SuaCuaHang(ch, machcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemCuaHangTheoTen(string tench)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.TimKiemCuaHangTheoTen(tench);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimCuaHang(string mach)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.TimKiemCuaHang(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTenCuaHang()
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.LayDanhSachTenCuaHang();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaCHTuTenCH(string tench)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.LayMaCHTuTenCH(tench);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTenTuMaCH(int mach)
        {
            try
            {
                DAL_CuaHang objdal = new DAL_CuaHang();
                return objdal.LayTenTuMaCH(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
