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
    public class DAL_HoaDonNhap:General
    {
        public bool ThemHoaDonNhap(HoaDonNhap hdn,DataTable cthdn)
        {
            bool ketqua1 = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "insert into HoaDonNhap values('" + hdn.maHD + "','" + hdn.ngayLap + "','" + hdn.maNCC + "','1')";
                SqlCommand command1 = new SqlCommand(sql1, con);
                if (command1.ExecuteNonQuery() > 0)
                    ketqua1 = true;
                using (SqlBulkCopy sbc = new SqlBulkCopy(con))
                {
                    sbc.DestinationTableName = "CT_HoaDonNhap";
                    sbc.WriteToServer(cthdn);
                }
                for (int i = 0; i < cthdn.Rows.Count; i++)
                {
                    DataTable dt = new DataTable();
                    int soluong = int.Parse(cthdn.Rows[i][5].ToString());
                    int masp = int.Parse(cthdn.Rows[i][1].ToString());
                    int mamau = int.Parse(cthdn.Rows[i][2].ToString());
                    int masize = int.Parse(cthdn.Rows[i][3].ToString());
                    string sql2 = "select * from KhoHang where MaSP=" + masp + " and MaMau=" + mamau + "and MaSize=" + masize + "";
                    SqlCommand command2 = new SqlCommand(sql2, con);
                    SqlDataReader rd = command2.ExecuteReader();
                    dt.Load(rd);
                    if(dt.Rows.Count == 0)
                    {
                        string sql3 = "insert into KhoHang Values("+masp+","+mamau+","+masize+","+soluong+")";
                        SqlCommand command3 = new SqlCommand(sql3, con);
                        command3.ExecuteNonQuery();
                    }
                    else
                    {
                        string sql4 = "update KhoHang set SoLuong=Soluong+" + soluong + " WHERE MASP=" + masp + " AND MAMAU=" + mamau + " AND MASIZE=" + masize + "";
                        SqlCommand command4 = new SqlCommand(sql4, con);
                        command4.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return ketqua1;
        }
        public bool XoaHoaDonNhap(int mahdn)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HoaDonNhap SET TRANGTHAI=0 WHERE MAHD='" + mahdn + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaHoaDonNhap(HoaDonNhap hdn, int mahdncu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HoaDonNhap SET MAHD='" + hdn.maHD + "',NGAYLAP='" + hdn.ngayLap + "',MANCC='" + hdn.maNCC+ "',TRANGTHAI='" + hdn.trangThai + "' WHERE MAHD='" + mahdncu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemHoaDonNhap(string mahdn, DateTime ngaylap)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                if(mahdn.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonNhap WHERE MAHD like'%' AND NGAYLAP like'%'", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonNhap WHERE MAHD='" + mahdn + "'AND NGAYLAP='" + ngaylap + "'", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public int LayMaHDNNew()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MAHD)+1 FROM HoaDonNhap ", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable DocHoaDonNhap()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT CT_HoaDonNhap.MaHD,TenNCC,NgayLap,SUM(Gia*SoLuong)AS TongTien,HoaDonNhap.TrangThai FROM HoaDonNhap,CT_HoaDonNhap,NhaCungCap WHERE HoaDonNhap.MaNCC=NhaCungCap.MaNCC AND HoaDonNhap.MaHD=CT_HoaDonNhap.MaHD GROUP BY CT_HoaDonNhap.MaHD,NhaCungCap.TenNCC,HoaDonNhap.NgayLap,HoaDonNhap.TrangThai";
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
