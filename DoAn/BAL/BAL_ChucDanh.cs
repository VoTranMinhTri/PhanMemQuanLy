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
    public class BAL_ChucDanh
    {
        public DataTable TimKiemChucDanhChoQuanLy(string macd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.TimKiemChucDanhChoQuanLy(macd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChucDanhTheoTenDanhChoQuanLy(string tencd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.TimKiemChucDanhTheoTenDanhChoQuanLy(tencd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChucDanh(string macd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.TimKiemChucDanh(macd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChucDanhTheoTen(string tencd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.TimKiemChucDanhTheoTen(tencd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTenCDDanhChoQuanLy()
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.LayDanhSachTenCDDanhChoQuanLy();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTenCDTuMaCD(int macd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.LayTenCDTuMaCD(macd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaCD(string tencd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.LayMaCD(tencd);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTenCD()
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.LayDanhSachTenCD();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachCDDanhChoQuanLy()
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.DocChucDanhDanhChoQuanLy();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachCD()
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.DocChucDanh();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemChucDanh(ChucDanh cd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                bool kq = objdal.ThemChucDanh(cd);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaChucDanh(int macd)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                bool kq = objdal.XoaChucDanh(macd);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaChucDanh(ChucDanh cd, int macdcu)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                bool kq = objdal.SuaChucDanh(cd, macdcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public float LayLuongCB(int manv)
        {
            try
            {
                DAL_ChucDanh objdal = new DAL_ChucDanh();
                return objdal.LayLuongCB(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
