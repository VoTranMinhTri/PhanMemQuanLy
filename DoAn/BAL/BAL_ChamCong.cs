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
    public class BAL_ChamCong
    {
        public DataTable layDanhSachChamCongChoQuanLy(int manvql)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.DocChamCongDanhChoQuanLy(manvql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable layDanhSachChamCong()
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.DocChamCong();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable layDanhSachLoaiChamCong()
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.layDanhSachLoaiChamCong();
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool KiemTraNgayNghiCoPhep(int manv)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                bool kq = objdal.KiemTraNgayNghiCoPhep(manv);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool ThemChamCong(ChamCong cc)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                bool kq = objdal.ThemChamCong(cc);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool SuaChamCong(ChamCong cc, int macccu, int malccu)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                bool kq = objdal.SuaChamCong(cc,macccu,malccu);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaChamCong(int macc)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                bool kq = objdal.XoaChamCong(macc);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaCCNew()
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                int kq = objdal.LayMaCCNew();
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public int LayMaLoaiChamCong(string ten)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                int kq = objdal.LayMaLoaiCC(ten);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public float LayTongTienChamCong(int manv,int thang ,int nam)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                float kq = objdal.LayTongTienChamCong(manv,thang,nam);
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCongTheoNgay(string ngay)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCongTheoNgay(ngay);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCongTheoMaNV(string manv)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCongTheoMaNV(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCong(string macc)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCong(macc);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCongTheoNgayDanhChoQuanLy(string ngay,int manvql)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCongTheoNgayDanhChoQuanLy(ngay, manvql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCongTheoMaNVDanhChoQuanLy(string manv, int manvql)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCongTheoMaNVDanhChoQuanLy(manv, manvql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable TimKiemChamCongDanhChoQuanLy(string macc, int manvql)
        {
            try
            {
                DAL_ChamCong objdal = new DAL_ChamCong();
                return objdal.TimKiemChamCongDanhChoQuanLy(macc, manvql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
