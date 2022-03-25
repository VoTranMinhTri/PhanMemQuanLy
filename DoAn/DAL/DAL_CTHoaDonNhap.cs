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
    public class DAL_CTHoaDonNhap:General
    {
        public bool ThemCTHoaDonNhap(CTHoaDonNhap cthdn)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into CT_HoaDonNhap values('" + cthdn.maHD + "','" + cthdn.maSP + "','" + cthdn.maMau + "','" + cthdn.maSize + "','" + cthdn.Gia + "','" + cthdn.soLuong + "',1)";
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
        public bool XoaCTHoaDonNhap(int macthdn, int mactsp, int mactmau, int mactsize)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_HoaDonNhap SET TRANGTHAI=0 WHERE MAHD='" + macthdn + "'AND MASP='" + mactsp + "'AND MAMAU='" + mactmau + "'AND MASIZE='" + mactsize + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaCTHoaDonNhap(CTHoaDonNhap cthdn, int macthdncu, int mactspcu, int mactmaucu, int mactsizecu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_HoaDonNhap SET MAHD='" + cthdn.maHD + "',MASP='" + cthdn.maSP + "',MAMAU='" + cthdn.maMau + "',MASIZE='" + cthdn.maSize + "',GIA=" + cthdn.Gia + ",SOLUONG='" + cthdn.soLuong + "',TRANGTHAI="+cthdn.trangThai+" WHERE MAHD='" + macthdncu + "'AND MASP='" + mactspcu + "'AND MASIZE='" + mactsizecu + "'AND MAMAU='" + mactmaucu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemCTHoaDonNhap(int mactsp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CT_HoaDonNhap WHERE MASP='" + mactsp + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocCTHoaDonNhap(int mahdn)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaHD,CT_HoaDonNhap.MaSP,TenMau,TenSize,SoLuong,CT_HoaDonNhap.Gia,(CT_HoaDonNhap.Gia*SoLuong) as ThanhTien from CT_HoaDonNhap,Mau,Size,SanPham WHERE  CT_HoaDonNhap.MaSP=SanPham.MaSP AND CT_HoaDonNhap.MaMau=SanPham.MaMau AND CT_HoaDonNhap.MaSize=SanPham.MaSize  AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND MaHD='" + mahdn + "'";
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
