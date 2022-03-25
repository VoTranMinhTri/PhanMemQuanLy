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
    public class BAL_KhachHang
    {
        public DataTable LayDanhSachKH()
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                return objdal.DocKhachHang();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                bool kq = objdal.ThemKhachHang(kh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaKhachHang(int makh)
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                bool kq = objdal.XoaKhachHang(makh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaKhachHang(KhachHang kh, int makhcu)
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                bool kq = objdal.SuaKhachHang(kh, makhcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKhachHangTheoTen(string tenkh)
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                return objdal.TimKiemKhachHangTheoTen(tenkh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKhachHang(string makh)
        {
            try
            {
                DAL_KhachHang objdal = new DAL_KhachHang();
                return objdal.TimKiemKhachHang(makh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
