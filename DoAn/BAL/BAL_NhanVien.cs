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
    public class BAL_NhanVien
    {
        public DataTable TimKiemNhanVienTheoTenDanhChoQuanLy(string hoten,int mach)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.TimKiemNhanVienTheoTenDanhChoQuanLy(hoten, mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemNhanVienDanhChoQuanLy(string manv,int mach)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.TimKiemNhanVienDanhChoQuanLy(manv, mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemNhanVienTheoTen(string hoten)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.TimKiemNhanVienTheoTen(hoten);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemNhanVien(string manv)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.TimKiemNhanVien(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachMaNVDanhChoQuanLy(int mach)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.LayDanhSachMaNVDanhChoQuanLy(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachMaNV()
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.LayDanhSachMaNV();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachNVChamCong(int manvql)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.DocNhanVienChamCong(manvql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachNVDanhChoQuanLy(int mach)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.DocNhanVienDanhChoQuanLy(mach);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachNV()
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.DocNhanVien();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                bool kq = objdal.ThemNhanVien(nv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaNhanVien(int manv)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                bool kq = objdal.XoaNhanVien(manv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaNhanVien(NhanVien nv, int manvcu)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                bool kq = objdal.SuaNhanVien(nv, manvcu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayTenNV(int manv)
        {
            try
            {
                DAL_NhanVien objdal = new DAL_NhanVien();
                return objdal.LayTenNV(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
