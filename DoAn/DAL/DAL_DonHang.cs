using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BEL;
namespace DAL
{
    public class DAL_DonHang : General
    {
        public bool ThemDonHang(DonHang dh, DataTable table)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into DonHang values('" + dh.maDH + "','" + dh.maNV + "','" + dh.maKH + "','" + dh.ngayLap + "','" + dh.ngayNhan + "','" + dh.chietKhau + "','" + dh.ghiChu + "',1)";
                SqlCommand command = new SqlCommand(sql, con);
                if (command.ExecuteNonQuery() > 0)
                    ketqua = true;
                using (SqlBulkCopy sbc = new SqlBulkCopy(con))
                {
                    sbc.DestinationTableName = "CT_DonHang";
                    sbc.WriteToServer(table);
                }
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool XoaDonHang(int madh)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DonHang SET TRANGTHAI=0 WHERE MADH='" + madh + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaDonHang(DonHang dh, int macu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DonHang SET MADH='" + dh.maDH + "',MaNV=" + dh.maNV + ",MAKH='" + dh.maKH + "',NGAYLAP='" + dh.ngayLap + "',NGAYNHAN='" + dh.ngayNhan + "',CHIETKHAU='" + dh.chietKhau + "',GHICHU='" + dh.ghiChu + "',TRANGTHAI='" + dh.trangThai + "' WHERE MADH='" + macu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public int LayMaDHNew()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MADH)+1 FROM DonHang ", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            if (dt.Rows[0][0].ToString().Equals(""))
                return 1;
            else
                return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable DocDonHangDanhChoAdmin()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            { }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable DocDonHangDanhChoNhanVien(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                    string sql = "SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH AND NHANVIEN.MACH=" + mach + " AND DONHANG.TRANGTHAI=1 GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ";
                    SqlCommand command = new SqlCommand(sql, con);
                    SqlDataReader rd = command.ExecuteReader();
                    dt.Load(rd);
            }
            catch (Exception err)
            { }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable TimKiemDonHang(string madh,int mach, DateTime ngaylap,DateTime ngaynhan)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                if (madh.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH AND NHANVIEN.MACH=" + mach + " AND   CT_DonHang.MADH LIKE'%' GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH AND NHANVIEN.MACH=" + mach + " AND   CT_DonHang.MADH='" + madh + "' AND NGAYLAP='" + ngaylap + "' AND NGAYNHAN='" + ngaynhan + "' GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemDonHangDanhChoAdmin(string madh, DateTime ngaylap, DateTime ngaynhan)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                if (madh.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH  AND   CT_DonHang.MADH LIKE'%' GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_DonHang.MaDH,DonHang.MaNV,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,GhiChu,SUM(CT_DonHang.Gia*SoLuong)-SUM(CT_DonHang.Gia*SoLuong*ChietKhau)as TONGTIEN,DonHang.TrangThai FROM CT_DonHang,NhanVien,DonHang WHERE DonHang.MaNV=NhanVien.MaNV and DonHang.MaDH=CT_DonHang.MaDH  AND   CT_DonHang.MADH='" + madh + "' AND NGAYLAP='" + ngaylap + "' AND NGAYNHAN='" + ngaynhan + "' GROUP BY CT_DonHang.MaDH,DonHang.MaKH,NgayLap,NgayNhan,ChietKhau,DonHang.TrangThai,GhiChu,DonHang.MaNV ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
    }
}
