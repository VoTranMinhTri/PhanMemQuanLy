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
    public class BAL_CTHoaDonNhap
    {
        public DataTable LayDanhSachCTHDN(int mahdn)
        {
            try
            {
                DAL_CTHoaDonNhap objdal = new DAL_CTHoaDonNhap();
                return objdal.DocCTHoaDonNhap(mahdn);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemCTHoaDonNhap(CTHoaDonNhap hdn)
        {
            try
            {
                DAL_CTHoaDonNhap objdal = new DAL_CTHoaDonNhap();
                bool kq = objdal.ThemCTHoaDonNhap(hdn);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaCTHoaDonNhap(int macthdn, int mactsp, int mactmau, int mactsize)
        {
            try
            {
                DAL_CTHoaDonNhap objdal = new DAL_CTHoaDonNhap();
                bool kq = objdal.XoaCTHoaDonNhap(macthdn, mactsp, mactmau, mactsize);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaCTHoaDonNhap(CTHoaDonNhap hdn, int macthdncu, int mactspcu, int mactmaucu, int mactsizecu)
        {
            try
            {
                DAL_CTHoaDonNhap objdal = new DAL_CTHoaDonNhap();
                bool kq = objdal.SuaCTHoaDonNhap(hdn, macthdncu, mactspcu, mactmaucu, mactsizecu);
                return kq;
            }
            catch (Exception err)
            {
                return false;
            }
        }
        public DataTable TimCTHoaDonNhap(int mahdn)
        {
            try
            {
                DAL_CTHoaDonNhap objdal = new DAL_CTHoaDonNhap();
                return objdal.TimKiemCTHoaDonNhap(mahdn);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
