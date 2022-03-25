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
    public class DAL_CTHoaDonBan:General
    {
        public bool ThemCTHoaDonBan(CTHoaDonBan cthdb)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into CT_HoaDon values('" + cthdb.maHD + "','" + cthdb.maSP + "','" + cthdb.maMau + "','" + cthdb.maSize + "','" + cthdb.Gia + "','" + cthdb.soLuong + "',1)";
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
        public bool XoaCTHoaDonBan(int macthdb, int mactsp,int mactmau,int mactsize)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_HoaDon SET TRANGTHAI=0 WHERE MAHD='" + macthdb + "'AND MASP='" + mactsp + "'AND MAMAU='" + mactmau + "'AND MASIZE='" + mactsize + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaCTHoaDonBan(CTHoaDonBan cthdb, int macthdbcu,int mactspcu,int mactmaucu,int mactsizecu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_HoaDon SET MAHD='" + cthdb.maHD + "',MASP='" + cthdb.maSP + "',MAMAU='" + cthdb.maMau + "',MASIZE='" + cthdb.maSize + "',GIA='" + cthdb.Gia + "',SOLUONG='" + cthdb.soLuong + "',TRANGTHAI="+cthdb.trangThai+" WHERE MAHD='" + macthdbcu + "'AND MASP='" + mactspcu + "'AND MASIZE='" + mactsizecu + "'AND MAMAU='" + mactmaucu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemCTHoaDonBan(int mactsp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CT_HoaDon WHERE MASP='" + mactsp + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocCTHoaDonBan(int mahdb)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MAHD,CT_HoaDon.MASP,TenMau,TenSize,CT_HoaDon.Gia,(CT_HoaDon.Gia*SoLuong)AS ThanhTien,SoLuong FROM CT_HoaDon,Mau,Size,SanPham WHERE CT_HoaDon.MaSP=SanPham.MaSP AND CT_HoaDon.MaMau=SanPham.MaMau AND CT_HoaDon.MaSize=SanPham.MaSize AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND MAHD='" + mahdb + "'";
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
