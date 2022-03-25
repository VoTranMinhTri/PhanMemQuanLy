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
    public class DAL_NhaCungCap:General
    {
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into NhaCungCap values('" + ncc.maNCC + "','" + ncc.tenNCC + "','" + ncc.diaChi + "','" + ncc.Email + "','" + ncc.SDT + "','1')";
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
        public bool XoaNhaCungCap(int mancc)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NhaCungCap SET TRANGTHAI=0 WHERE Mancc='" + mancc + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaNhaCungCap(NhaCungCap ncc, int mancccu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NhaCungCap SET MAncc='" + ncc.maNCC + "',TENncc='" + ncc.tenNCC + "',SDT='" + ncc.SDT + "',DIACHI='" + ncc.diaChi + "',TRANGTHAI='" + ncc.trangThai + "' WHERE MAncc='" + mancccu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemNhaCungCapTheoTen(string tenncc)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tenncc.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHACUNGCAP WHERE  TENNCC LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE'%" + tenncc + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemNhaCungCap(string mancc)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (mancc.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM NHACUNGCAP WHERE  MANCC LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM NHACUNGCAP WHERE MANCC LIKE'" + mancc + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public int LayMaNCC(string tenncc)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaNCC FROM NhaCungCap WHERE TenNCC='" + tenncc + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable LayDanhSachTenNCC()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenNCC FROM NhaCungCap ", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocNhaCungCap()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from NhaCungCap";
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
