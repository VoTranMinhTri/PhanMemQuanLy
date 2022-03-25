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
    public class BAL_DonHang
    {
        public DataTable LayDanhSachDHChoAdmin()
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                return objdal.DocDonHangDanhChoAdmin();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachDHChoNhanVien(int mach)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                return objdal.DocDonHangDanhChoNhanVien(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemDonHang(DonHang dh, DataTable table)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                bool kq = objdal.ThemDonHang(dh, table);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaDonHang(int madh)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                bool kq = objdal.XoaDonHang(madh);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaDonHang(DonHang dh, int macu)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                bool kq = objdal.SuaDonHang(dh, macu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaDHNew()
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                return objdal.LayMaDHNew();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimDonHangDanhChoAdmin(string madh, DateTime ngaylap, DateTime ngaynhan)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                return objdal.TimKiemDonHangDanhChoAdmin(madh, ngaylap, ngaynhan);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimDonHang(string madh,int mach, DateTime ngaylap,DateTime ngaynhan)
        {
            try
            {
                DAL_DonHang objdal = new DAL_DonHang();
                return objdal.TimKiemDonHang(madh,mach, ngaylap, ngaynhan);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
