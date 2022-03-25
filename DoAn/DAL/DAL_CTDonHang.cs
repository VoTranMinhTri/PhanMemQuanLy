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
    public class DAL_CTDonHang : General
    {
        public DataTable DocCTDonHang(int madh)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MADH,CT_DonHang.MASP,TenMau,TenSize,CT_DonHang.Gia,(CT_DonHang.Gia*SoLuong)AS ThanhTien,SoLuong FROM CT_DonHang,Mau,Size,SanPham WHERE CT_DonHang.MaSP=SanPham.MaSP AND CT_DonHang.MaMau=SanPham.MaMau AND CT_DonHang.MaSize=SanPham.MaSize AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND MADH='" + madh + "'";
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
        public bool ThemCTDonHang(CTDonHang ctdh)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "insert into CT_DonHang values('" + ctdh.maDH + "','" + ctdh.maSP + "','" + ctdh.maMau + "','" + ctdh.maSize + "','" + ctdh.Gia + "','" + ctdh.soLuong + "',1)";
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
        public bool XoaCTDonHang(int madh, int mactsp, int mactmau, int mactsize)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_Donhang SET TRANGTHAI=0 WHERE MADH='" + madh + "'AND MASP='" + mactsp + "'AND MAMAU='" + mactmau + "'AND MASIZE='" + mactsize + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaCTDonHang(CTDonHang ctdh, int mactdhcu, int mactspcu, int mactmaucu, int mactsizecu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CT_DonHang SET MADH='" + ctdh.maDH + "',MASP='" + ctdh.maSP + "',MAMAU='" + ctdh.maMau + "',MASIZE='" + ctdh.maSize + "',GIA='" + ctdh.Gia + "',SOLUONG='" + ctdh.soLuong + "',TRANGTHAI=" + ctdh.trangThai + " WHERE MADH='" + mactdhcu + "'AND MASP='" + mactspcu + "'AND MASIZE='" + mactsizecu + "'AND MAMAU='" + mactmaucu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
    }
}
