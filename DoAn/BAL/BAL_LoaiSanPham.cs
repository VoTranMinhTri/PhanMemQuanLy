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
    public class BAL_LoaiSanPham
    {
        public DataTable TimKiemLoaiSPTheoTen(string tensp)
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                return objdal.TimKiemLoaiSanPhamTheoTen(tensp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemLoaiSP(string masp)
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                return objdal.TimKiemLoaiSanPham(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachLoaiSP()
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                return objdal.DocLoaiSP();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemLoaiSP(LoaiSanPham lsp)
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                bool kq = objdal.ThemLoaiSP(lsp);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaLoaiSP(int malspcu)
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                bool kq = objdal.XoaLoaiSP(malspcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaLoaiSP(LoaiSanPham lsp,int malspcu)
        {
            try
            {
                DAL_LoaiSanPham objdal = new DAL_LoaiSanPham();
                bool kq = objdal.SuaLoaiSP(lsp,malspcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
