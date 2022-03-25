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
    public class BAL_HoaDonBan
    {
        public DataTable LayDanhSachHDBDanhChoQuanLy(int mach)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                return objdal.DocHoaDonBanDanhChoQuanLy(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachHDB()
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                return objdal.DocHoaDonBan();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemHoaDonBan(HoaDonBan hdb,DataTable table,int mach)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                bool kq = objdal.ThemHoaDonBan(hdb, table, mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaHoaDonBan(int mahdb)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                bool kq = objdal.XoaHoaDonBan(mahdb);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaHoaDonBan(HoaDonBan hdb, int mahdbcu)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                bool kq = objdal.SuaHoaDonBan(hdb, mahdbcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemHoaDonBanDanhChoQuanLy(string mahdb,int mach, DateTime ngaylap)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                return objdal.TimKiemHoaDonBanDanhChoQuanLy(mahdb,mach, ngaylap);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimHoaDonBan(string mahdb, DateTime ngaylap)
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                return objdal.TimKiemHoaDonBan(mahdb,ngaylap);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaHDBNew()
        {
            try
            {
                DAL_HoaDonBan objdal = new DAL_HoaDonBan();
                return objdal.LayMaHDBNew();
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
