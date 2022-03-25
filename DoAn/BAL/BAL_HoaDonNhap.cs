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
    public class BAL_HoaDonNhap
    {
        public DataTable LayDanhSachHDN()
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                return objdal.DocHoaDonNhap();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemHoaDonNhap(HoaDonNhap hdn,DataTable cthdn)
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                bool kq = objdal.ThemHoaDonNhap(hdn, cthdn);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaHoaDonNhap(int mahdn)
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                bool kq = objdal.XoaHoaDonNhap(mahdn);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaHoaDonNhap(HoaDonNhap hdn, int mahdncu)
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                bool kq = objdal.SuaHoaDonNhap(hdn, mahdncu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimHoaDonNhap(string mahdn, DateTime ngaylap)
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                return objdal.TimKiemHoaDonNhap(mahdn, ngaylap);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaHDNNew()
        {
            try
            {
                DAL_HoaDonNhap objdal = new DAL_HoaDonNhap();
                return objdal.LayMaHDNNew();
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
