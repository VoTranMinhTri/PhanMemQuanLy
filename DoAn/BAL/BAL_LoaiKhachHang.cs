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
    public class BAL_LoaiKhachHang
    {
        public DataTable LayDanhSachLKH()
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                return objdal.DocLoaiKhachHang();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemLoaiKhachHang(LoaiKhachHang lkh)
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                bool kq = objdal.ThemLoaiKhachHang(lkh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaLoaiKhachHang(int malkh)
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                bool kq = objdal.XoaLoaiKhachHang(malkh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaLoaiKhachHang(LoaiKhachHang lkh, int malkhcu)
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                bool kq = objdal.SuaLoaiKhachHang(lkh, malkhcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemLoaiKhachHangTheoTen(string tenlkh)
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                return objdal.TimKiemLoaiKhachHangTheoTen(tenlkh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimLoaiKhachHang(string malkh)
        {
            try
            {
                DAL_LoaiKhachHang objdal = new DAL_LoaiKhachHang();
                return objdal.TimKiemLoaiKhachHang(malkh);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
