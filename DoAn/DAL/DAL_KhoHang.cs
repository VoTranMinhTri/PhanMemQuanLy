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
    public class DAL_KhoHang : General
    {
        public DataTable DocKhoHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT KhoHang.MaSP,TenSP,TenMau,TenSize,SoLuong FROM KhoHang,SanPham,Mau,Size WHERE KhoHang.MaSP=SanPham.MaSP AND KhoHang.MaMau=SanPham.MaMau AND KhoHang.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau";
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
        public bool SuaKhoHang(KhoHang kho)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KhoHang SET SOLUONG='" + kho.soLuong + "' WHERE  MASP='" + kho.maSP + "'AND MASIZE='" + kho.maSize + "'AND MAMAU='" + kho.maMau + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemKhoTheoTenSP(string tensp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tensp.Equals(""))
                    cmd = new SqlCommand("SELECT KhoHang.MaSP,TenSP,TenMau,TenSize,SoLuong FROM KhoHang,SanPham,Mau,Size WHERE KhoHang.MaSP=SanPham.MaSP AND KhoHang.MaMau=SanPham.MaMau AND KhoHang.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and TENSP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT KhoHang.MaSP,TenSP,TenMau,TenSize,SoLuong FROM KhoHang,SanPham,Mau,Size WHERE KhoHang.MaSP=SanPham.MaSP AND KhoHang.MaMau=SanPham.MaMau AND KhoHang.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and TENSP LIKE'%" + tensp + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemKho(string masp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                 SqlCommand cmd ;
                if(masp.Equals(""))
                    cmd = new SqlCommand("SELECT KhoHang.MaSP,TenSP,TenMau,TenSize,SoLuong FROM KhoHang,SanPham,Mau,Size WHERE KhoHang.MaSP=SanPham.MaSP AND KhoHang.MaMau=SanPham.MaMau AND KhoHang.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and KhoHang.MASP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT KhoHang.MaSP,TenSP,TenMau,TenSize,SoLuong FROM KhoHang,SanPham,Mau,Size WHERE KhoHang.MaSP=SanPham.MaSP AND KhoHang.MaMau=SanPham.MaMau AND KhoHang.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and KhoHang.MASP LIKE'" + masp + "'", con);
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
