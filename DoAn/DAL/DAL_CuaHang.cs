using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_CuaHang:General
    {
        
        public bool ThemCuaHang(CuaHang ch)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into CuaHang values('" + ch.maCH + "','" + ch.tenCH + "','" + ch.diaChi + "','1')";
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
        public bool XoaCuaHang(int mach)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CuaHang SET TRANGTHAI=0 WHERE MAch='" + mach + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaCuaHang(CuaHang ch, int machcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CuaHang SET Mach='" + ch.maCH + "',TENCH='" + ch.tenCH + "',DIACHI='" + ch.diaChi + "',TRANGTHAI='" + ch.trangThai + "' WHERE MAch='" + machcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemCuaHangTheoTen(string tench)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tench.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CUAHANG WHERE  tench LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CUAHANG WHERE tench LIKE'%" + tench + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemCuaHang(string mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (mach.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CUAHANG WHERE  MACH LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CUAHANG WHERE MACH LIKE'" + mach + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocCuaHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from CuaHang";
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
        public DataTable LayDanhSachTenCuaHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select TenCH from CuaHang";
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
        public int LayMaCHTuTenCH(string tench)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select MaCH from CuaHang where tench='"+tench+"'";
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
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public string LayTenTuMaCH(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select TenCH from CuaHang where MACH='" + mach + "'";
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
