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
    public class DAL_ThongKe : General
    {
        public DataTable LayDoanhThuTungThang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MONTH(HoaDon.NgayLap)AS THANG,SUM(CT_HoaDon.Gia*CT_HoaDon.SoLuong -(HoaDon.ChietKhau*CT_HoaDon.Gia*CT_HoaDon.SoLuong))AS DOANHTHU FROM HoaDon,CT_HoaDon WHERE HoaDon.MaHD=CT_HoaDon.MaHD GROUP BY month(HoaDon.NgayLap)";
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
        public DataTable LayTop3KhachHangCoDoanhSoCaoNhat()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT top 3 TenKH,DoanhSo FROM KHACHHANG order by DOANHSO desc";
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
        public DataTable LayTop5SanPhamCoSoLuongBanCaoNhat()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT top 5 TENSP ,SUM(CT_HoaDon.SoLuong) AS SOLUONG FROM CT_HoaDon,SanPham WHERE CT_HoaDon.MaSP=SanPham.MaSP AND CT_HoaDon.MaMau=SanPham.MaMau AND CT_HoaDon.MaSize=SanPham.MaSize GROUP BY CT_HoaDon.MASP,TenSP order by SUM(CT_HoaDon.SoLuong) desc";
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
