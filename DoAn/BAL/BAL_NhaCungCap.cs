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
    public class BAL_NhaCungCap
    {
        public DataTable LayDanhSachNCC()
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                return objdal.DocNhaCungCap();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                bool kq = objdal.ThemNhaCungCap(ncc);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaNhaCungCap(int mancc)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                bool kq = objdal.XoaNhaCungCap(mancc);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaNhaCungCap(NhaCungCap ncc, int mancccu)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                bool kq = objdal.SuaNhaCungCap(ncc, mancccu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTenNCC()
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                return objdal.LayDanhSachTenNCC();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimNhaCungCapTheoTen(string tenncc)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                return objdal.TimKiemNhaCungCapTheoTen(tenncc);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimNhaCungCap(string mancc)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                return objdal.TimKiemNhaCungCap(mancc);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaNCC(string tenncc)
        {
            try
            {
                DAL_NhaCungCap objdal = new DAL_NhaCungCap();
                return objdal.LayMaNCC(tenncc);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
