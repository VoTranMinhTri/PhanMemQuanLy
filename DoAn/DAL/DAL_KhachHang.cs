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
    public class DAL_KhachHang:General
    {
        public bool ThemKhachHang(KhachHang kh)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into KhachHang values('" + kh.maKH + "','" + kh.tenKH + "','" + kh.ngaySinh + "','" + kh.gioiTinh + "','" + kh.SDT + "','" + kh.diaChi + "'," + kh.doanhSo + ",'" + kh.maLoai + "','1')";
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
        public bool XoaKhachHang(int makh)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET TRANGTHAI=0 WHERE Makh='" + makh + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaKhachHang(KhachHang kh, int makhcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KHACHHANG SET MAKH='" + kh.maKH + "',TENKH='" + kh.tenKH + "',PHAI='" + kh.gioiTinh + "',NGAYSINH='" + kh.ngaySinh + "',SDT='" + kh.SDT + "',MALOAI='" + kh.maLoai + "',DIACHI='" + kh.diaChi + "',DOANHSO="+kh.doanhSo+",TRANGTHAI='" + kh.trangThai + "' WHERE MAKH='" + makhcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemKhachHangTheoTen(string tenkh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tenkh.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE  tenkh LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE tenkh LIKE'%" + tenkh + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemKhachHang(string makh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (makh.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE  MAKH LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE MAKH LIKE'" + makh + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from KhachHang";
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
    }
}
