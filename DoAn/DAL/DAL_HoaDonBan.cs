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
    public class DAL_HoaDonBan:General
    {
        public bool ThemHoaDonBan(HoaDonBan hdb, DataTable cthdb,int mach)
        {
            bool ketqua = false;
            DataTable dt = new DataTable();
            float doanhso = 0;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                for (int i = 0; i < cthdb.Rows.Count; i++)
                {
                    int soluong = int.Parse(cthdb.Rows[i][5].ToString());
                    int masp = int.Parse(cthdb.Rows[i][1].ToString());
                    int mamau = int.Parse(cthdb.Rows[i][2].ToString());
                    int masize = int.Parse(cthdb.Rows[i][3].ToString());
                    string sql2 = "update SP_PhanBo set SoLuong=Soluong-" + soluong + " WHERE MASP=" + masp + " AND MAMAU=" + mamau + " AND MASIZE=" + masize + " AND MACH=" + mach + "";
                    SqlCommand command2 = new SqlCommand(sql2, con);
                    command2.ExecuteNonQuery();
                }
                for(int i = 0; i < cthdb.Rows.Count; i++)
                {
                    int soluong = int.Parse(cthdb.Rows[i][5].ToString());
                    float gia = float.Parse(cthdb.Rows[i][4].ToString());
                    doanhso = doanhso+(soluong*gia-(soluong*gia*hdb.chietKhau));
                    string sql3 = "update KhachHang set DoanhSo=DoanhSo+" + doanhso + " WHERE MAKH="+hdb.maKH+"";
                    SqlCommand command3 = new SqlCommand(sql3, con);
                    command3.ExecuteNonQuery();
                }
                SqlCommand command4 = new SqlCommand("SELECT DOANHSO FROM KHACHHANG WHERE MAKH="+hdb.maKH+" ", con);
                SqlDataReader rd = command4.ExecuteReader();
                dt.Load(rd);
                if (float.Parse(dt.Rows[0][0].ToString()) >= 1000000000)
                {
                    command4 = new SqlCommand("update KhachHang set MaLoai=5 WHERE MAKH=" + hdb.maKH + "", con);
                    command4.ExecuteNonQuery();
                }
                else if(float.Parse(dt.Rows[0][0].ToString())>=100000000)
                {
                    command4 = new SqlCommand("update KhachHang set MaLoai=4 WHERE MAKH=" + hdb.maKH + "", con);
                    command4.ExecuteNonQuery();
                }
                else if (float.Parse(dt.Rows[0][0].ToString()) >= 10000000)
                {
                    command4 = new SqlCommand("update KhachHang set MaLoai=3 WHERE MAKH=" + hdb.maKH + "", con);
                    command4.ExecuteNonQuery();
                }
                else if (float.Parse(dt.Rows[0][0].ToString()) >= 1000000)
                {
                    command4 = new SqlCommand("update KhachHang set MaLoai=2 WHERE MAKH=" + hdb.maKH + "", con);
                    command4.ExecuteNonQuery();
                }
                else
                {
                    command4 = new SqlCommand("update KhachHang set MaLoai=1 WHERE MAKH=" + hdb.maKH + "", con);
                    command4.ExecuteNonQuery();
                }
                string sql = "insert into HoaDon values('" + hdb.maHD + "','" + hdb.maNV + "','" + hdb.maKH + "','" + hdb.ngayLap + "','" + hdb.chietKhau + "','1')";
                SqlCommand command = new SqlCommand(sql, con);
                if (command.ExecuteNonQuery() > 0)
                    ketqua = true;
                using (SqlBulkCopy sbc = new SqlBulkCopy(con))
                {
                    sbc.DestinationTableName = "CT_HoaDon";
                    sbc.WriteToServer(cthdb);
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
            return ketqua;
        }
        public bool XoaHoaDonBan(int mahdb)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET TRANGTHAI=0 WHERE MAHD='" + mahdb + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public int LayMaHDBNew()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MAHD)+1 FROM HoaDon ", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
        public bool SuaHoaDonBan(HoaDonBan hdb, int mahdbcu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET MAHD='" + hdb.maHD + "',MANV='" + hdb.maNV + "',MAKH='" + hdb.maKH + "',NGAYLAP='" + hdb.ngayLap + "',CHIETKHAU='" + hdb.chietKhau + "',TRANGTHAI='" + hdb.trangThai + "' WHERE MAHD='" + mahdbcu + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemHoaDonBan(string mahdb,DateTime ngaylap)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                if(mahdb.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV AND HoaDon.MAHD like '%' AND NGAYLAP like '%' GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV AND HoaDon.MAHD like '"+mahdb+"' AND NGAYLAP='" + ngaylap + "' GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH ", con);
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
        public DataTable TimKiemHoaDonBanDanhChoQuanLy(string mahdb,int mach, DateTime ngaylap)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                if(mahdb.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE HoaDon.MAHD like '%' AND NGAYLAP like '%' AND NhanVien.MaCH=" + mach + " AND HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH  ", con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE HoaDon.MAHD like '"+mahdb+"' AND NGAYLAP='" + ngaylap + "' AND NhanVien.MaCH=" + mach + " AND HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH  ", con);
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
        public DataTable DocHoaDonBan()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH";
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
        public DataTable DocHoaDonBanDanhChoQuanLy(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.MaKH,NgayLap,ChietKhau,SUM(CT_HoaDon.Gia*SoLuong)-SUM(CT_HoaDon.Gia*SoLuong*ChietKhau)as TONGTIEN,HoaDon.TrangThai FROM HoaDon,NhanVien,CT_HoaDon WHERE NhanVien.MaCH="+mach+" AND HoaDon.MaHD=CT_HoaDon.MaHD AND HOADON.MaNV=NhanVien.MaNV GROUP BY CT_HoaDon.MaHD,HoaDon.MaNV,HoaDon.NgayLap,HoaDon.ChietKhau,HoaDon.TrangThai,HoaDon.MaKH";
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
