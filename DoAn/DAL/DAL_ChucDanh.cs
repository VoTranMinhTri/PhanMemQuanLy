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
    public class DAL_ChucDanh:General
    {
        public bool ThemChucDanh(ChucDanh cd)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into ChucDanh values('" + cd.maCD + "','" + cd.tenCD + "',"+cd.luongCB+",'1')";
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
        public bool XoaChucDanh(int macd)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChucDanh SET TRANGTHAI=0 WHERE MACD='" + macd + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaChucDanh(ChucDanh cd, int macdcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChucDanh SET Macd='" + cd.maCD + "' ,TENCD='" + cd.tenCD + "',luongcb="+cd.luongCB+",TRANGTHAI='" + cd.trangThai + "' WHERE MAcd='" + macdcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemChucDanh(int macd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChucDanh WHERE Macd='" + macd + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocChucDanhDanhChoQuanLy()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT * FROM ChucDanh WHERE MaCD !=3";
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
        public DataTable DocChucDanh()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select * from ChucDanh";
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
        public string LayTenCDTuMaCD(int macd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TenCD FROM ChucDanh WHERE MaCD="+macd+"";
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
        public DataTable LayDanhSachTenCDDanhChoQuanLy()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TenCD FROM ChucDanh where MaCD=1 or MaCD=2";
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
        public DataTable LayDanhSachTenCD()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TenCD FROM ChucDanh";
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
        public int LayMaCD(string tencd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaCD FROM ChucDanh WHERE TenCD ='" + tencd + "'";
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
        public float LayLuongCB(int manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT LuongCB FROM ChucDanh,NhanVien WHERE NhanVien.MaCD=ChucDanh.MaCD AND MaNV =" + manv + "";
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
            return float.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimKiemChucDanh(string macd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (macd.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE  MACD LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE MACD LIKE'" + macd + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChucDanhTheoTen(string tencd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tencd.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE  tencd LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE tencd LIKE'%" + tencd + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChucDanhChoQuanLy(string macd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (macd.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE  MACD LIKE'%' AND MACD!=3", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE MACD LIKE'" + macd + "' AND MACD!=3", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChucDanhTheoTenDanhChoQuanLy(string tencd)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tencd.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE  tencd LIKE'%' AND MACD!=3", con);
                else
                    cmd = new SqlCommand("SELECT * FROM CHUCDANH WHERE tencd LIKE'%" + tencd + "%' AND MACD!=3", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
    }
}
