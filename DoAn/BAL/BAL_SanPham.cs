using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;
using System.IO;
namespace BAL
{
    public class BAL_SanPham
    {
        public DataTable TimKiemSanPhamChoThanhToanTheoTen(string tensp, int mach)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.TimKiemSanPhamChoThanhToanTheoTen(tensp,mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemSanPhamChoThanhToan(string masp,int mach)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.TimKiemSanPhamChoThanhToan(masp,mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachSPChoHoaDonNhap()
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.DocSanPhamChoHoaDonNhap();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachSP()
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.DocSanPham();
            }
            catch(Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachSPThanhToan(int mach)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.DocSanPhamThanhToan(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemSanPham(SanPham sp)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                bool kq = objdal.ThemSanPham(sp);
                return kq;
            }
            catch(Exception err)
            {
                throw;
            }
        }
        public bool KiemTraMaSP(int masp)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                bool kq = objdal.KiemTraMaSP(masp);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaSanPham(int masp,int mamau,int masize)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                bool kq = objdal.XoaSanPham(masp,mamau,masize);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaSanPham(SanPham sp,int maspcu,int mamaucu,int masizecu)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                bool kq = objdal.SuaSanPham(sp,maspcu,mamaucu,masizecu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimSanPhamTheoTen(string tensp)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.TimKiemSanPhamTheoTen(tensp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimSanPham(string masp)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.TimKiemSanPham(masp);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachMau()
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.layDanhSachMau();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachSize()
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.layDanhSachSize();
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
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.layDanhSachLoaiSP();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaSPNew()
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.LayMaSPNew();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaSize(string tensize)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.LayMaSize(tensize);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaMau(string tenmau)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.LayMaMau(tenmau);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTenMau(int mamau)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.LayTenMau(mamau);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTenSize(int masize)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                return objdal.LayTenSize(masize);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraSPTrongDonHang(int masp, int mamau, int masize)
        {
            try
            {
                DAL_SanPham objdal = new DAL_SanPham();
                bool kq = objdal.KiemTraSPTrongDonHang(masp,mamau,masize);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
