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
    public class DAL_LoaiSanPham : General
    {
        public DataTable DocLoaiSP()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT * FROM LoaiSP";
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
        public bool ThemLoaiSP(LoaiSanPham lsp)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into LoaiSP values('" + lsp.maLoai + "','" + lsp.tenLoai + "','1')";
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
        public bool XoaLoaiSP(int maloai)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LoaiSP SET TRANGTHAI=0 WHERE MALOAI='" + maloai + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaLoaiSP(LoaiSanPham lsp, int maloaicu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LoaiSP SET MALOAI='" + lsp.maLoai + "' ,TENloai='" + lsp.tenLoai + "',TRANGTHAI='" + lsp.trangThai + "' WHERE MALOAI='" + maloaicu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemLoaiSanPham(string maloai)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (maloai.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM LoaiSP WHERE  MALOAI LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM LoaiSP WHERE MALOAI LIKE'" + maloai + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemLoaiSanPhamTheoTen(string tenloai)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tenloai.Equals(""))
                    cmd = new SqlCommand("SELECT * FROM LoaiSP WHERE  TENLOAI LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT * FROM LoaiSP WHERE TENLOAI LIKE'%" + tenloai + "%'", con);
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
