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
    public class DAL_LoaiKhachHang:General
    {
        public bool ThemLoaiKhachHang(LoaiKhachHang lkh)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into LoaiKH values('" + lkh.maLoai + "','" + lkh.tenLoai + "'," + lkh.hanMuc + ",'1')";
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
        public bool XoaLoaiKhachHang(int malkh)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LoaiKH SET TRANGTHAI=0 WHERE MaLoai='" + malkh + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaLoaiKhachHang(LoaiKhachHang lkh, int malkhcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LoaiKH SET MALOAI='" + lkh.maLoai + "',TENLOAI='" + lkh.tenLoai + "',HANMUC='" + lkh.hanMuc + "',TRANGTHAI='" + lkh.trangThai + "' WHERE MALOAI='" + malkhcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemLoaiKhachHangTheoTen(string tenlkh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tenlkh.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM LOAIKH WHERE  TENLOAI LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM LOAIKH WHERE TENLOAI LIKE'%" + tenlkh + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemLoaiKhachHang(string malkh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (malkh.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM LOAIKH WHERE  MALOAI LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM LOAIKH WHERE MALOAI LIKE'" + malkh + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocLoaiKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from LoaiKH";
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
