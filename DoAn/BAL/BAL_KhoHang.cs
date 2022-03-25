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
    public class BAL_KhoHang
    {
        public DataTable LayDanhSachKhoHang()
        {
            try
            {
                DAL_KhoHang objdal = new DAL_KhoHang();
                return objdal.DocKhoHang();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemKhoTheoTenSP(string tensp)
        {
            try
            {
                DAL_KhoHang objdal = new DAL_KhoHang();
                return objdal.TimKiemKhoTheoTenSP(tensp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemKho(string masp)
        {
            try
            {
                DAL_KhoHang objdal = new DAL_KhoHang();
                return objdal.TimKiemKho(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaKhoHang(KhoHang kho)
        {
            try
            {
                DAL_KhoHang objdal = new DAL_KhoHang();
                bool kq = objdal.SuaKhoHang(kho);
                return kq;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
