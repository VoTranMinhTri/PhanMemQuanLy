using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace BAL
{
    public class BAL_TaiKhoan
    {
        public DataTable TimKiemTaiKhoanTheoUsernameDanhChoQuanLy(string username,int mach)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoanTheoUsernameDanhChoQuanLy(username,mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemTaiKhoanTheoHoTenDanhChoQuanLy(string hoten,int mach)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoanTheoHoTenDanhChoQuanLy(hoten, mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemTaiKhoanDanhChoQuanLy(string manv, int mach)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoanDanhChoQuanLy(manv, mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemTaiKhoanTheoUsername(string username)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoanTheoUsername(username);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemTaiKhoanTheoHoTen(string hoten)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoanTheoHoTen(hoten);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemTaiKhoan(string manv)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.TimKiemTaiKhoan(manv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTKDanhChoQuanLy(int mach)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.DocTaiKhoanDanhChoQuanLy(mach);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDanhSachTK()
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                DataTable kq = objdal.DocTaiKhoan();
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool DoiMatKhau(string us,string pass)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.DoiMatKhau(us, pass);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.SuaTaiKhoan(tk);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.ThemTaiKhoan(tk);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaTaiKhoan(string us)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.XoaTaiKhoan(us);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraTenTaiKhoan(string us)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.KiemTraTenTaiKhoan(us);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraDangNhap(string us, string pw)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                bool kq = objdal.KiemTraTaiKhoan(us, pw);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaNV(string us)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                int kq = objdal.LayMaNV(us);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaCD(int manv)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                int kq = objdal.LayMaCD(manv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaCH(int manv)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                int kq = objdal.LayMaCH(manv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public string LayPassword(string us)
        {
            try
            {
                DAL_TaiKhoan objdal = new DAL_TaiKhoan();
                string kq = objdal.LayPassword(us);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
