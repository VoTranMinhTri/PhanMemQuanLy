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
    public class DAL_NhanVien:General
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into NhanVien values('" + nv.maNV + "','" + nv.Ho + "','" + nv.tenLot + "','" + nv.Ten + "','" + nv.ngaySinh + "','" + nv.gioiTinh + "','" + nv.CCCD + "','" + nv.SDT + "','" + nv.diaChi + "','" + nv.ngayVaoLam + "','" + nv.ngayKetThuc + "','" + nv.maCD + "','" + nv.maCH + "',"+nv.maNVQL+",'1')";
                SqlCommand command = new SqlCommand(sql, con);
                if (command.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            { }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool XoaNhanVien(int manv)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET TRANGTHAI=0,NGAYKETTHUC='"+System.DateTime.Now+"' WHERE MANV='" + manv + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaNhanVien(NhanVien nv,int manvcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET MaNV='" + nv.maNV + "',HO='" + nv.Ho + "',TENLOT='" + nv.tenLot + "',TEN='" + nv.Ten + "',NGAYSINH='" + nv.ngaySinh + "',PHAI='" + nv.gioiTinh + "',CCCD='" + nv.CCCD + "',SDT='" + nv.SDT + "',DIACHI='" + nv.diaChi + "',NgayBDLam='" + nv.ngayVaoLam + "',NGAYKETTHUC='" + nv.ngayKetThuc + "',MACD='" + nv.maCD + "',MACH='" + nv.maCH + "',TRANGTHAI='" + nv.trangThai + "',MANV_QL="+nv.maNVQL+" WHERE MANV='" + manvcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemNhanVienDanhChoQuanLy(string manv,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (manv.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE  MACH ="+mach+" AND MANV LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MACH =" + mach + " AND MANV LIKE'" + manv + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemNhanVienTheoTenDanhChoQuanLy(string hoten,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (hoten.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE  MACH =" + mach + " AND Ho+' '+TenLot+' '+Ten LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE  MACH =" + mach + " AND Ho+' '+TenLot+' '+Ten like'%" + hoten + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemNhanVien(string manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (manv.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE  MANV LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV LIKE'" + manv + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemNhanVienTheoTen(string hoten)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (hoten.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE  Ho+' '+TenLot+' '+Ten LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE Ho+' '+TenLot+' '+Ten like'%"+ hoten+"%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocNhanVienChamCong(int manvql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from NHANVIEN where macd=1 and MaNV_QL="+manvql+"";
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
        public DataTable DocNhanVienDanhChoQuanLy(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from NHANVIEN WHERE MaCD!=3 AND MaCH="+mach+"";
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
        public DataTable DocNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from NHANVIEN";
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
        public DataTable LayDanhSachMaNVDanhChoQuanLy(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select MANV from NHANVIEN where macd!=3 and MaCH="+mach+" and trangthai=1";
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
        public DataTable LayDanhSachMaNV()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select MANV from NHANVIEN";
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
        public string LayTenNV(int manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT (Ho+' '+TenLot+' '+Ten) as HoTen  FROM NhanVien WHERE MaNV='" + manv + "'";
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
            return dt.Rows[0][0].ToString();
        }
    }
}
