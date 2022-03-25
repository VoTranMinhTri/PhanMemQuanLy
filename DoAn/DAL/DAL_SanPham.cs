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
    public class DAL_SanPham : General
    {
        public bool ThemSanPham(SanPham sp)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                int maloai = LayMaLoai(sp.Loai);
                int mamau = LayMaMau(sp.Mau);
                int masize = LayMaSize(sp.Size);
                con.Open();
                string sql1 = "INSERT INTO SANPHAM VALUES(" + sp.maSP + ",'" + sp.tenSP + "'," + mamau + "," + masize + "," + maloai + ","+sp.Gia+",'1') ";
                SqlCommand command1 = new SqlCommand(sql1, con);
                if (command1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool XoaSanPham(int masp,int mamau,int masize)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE SP_PhanBo SET TrangThai=0 WHERE MaSP='" + masp + "' AND MaMau=" + mamau + " AND MaSize=" + masize + "", con);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("UPDATE SanPham SET TrangThai=0 WHERE MaSP='" + masp + "' AND MaMau="+mamau+" AND MaSize="+masize+"", con);
                if (cmd2.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                return false;
            }
            return false;
        }
        public bool SuaSanPham(SanPham sp, int maspcu,int mamaucu,int masizecu)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                int maloai = LayMaLoai(sp.Loai);
                int mamau = LayMaMau(sp.Mau);
                int masize = LayMaSize(sp.Size);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE SANPHAM SET MASP='" + sp.maSP + "',TENSP='" + sp.tenSP + "',MAMAU=" + mamaucu + ",MASIZE=" + masizecu + ",GIA=" + sp.Gia + ",MALOAI=" + maloai + ",TRANGTHAI=" + sp.tinhTrang + " WHERE MASP='" + maspcu + "' AND MAMAU='" + mamaucu + "' AND MASIZE='" + masizecu + "'", con);
                if (cmd1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                return false;
            }
            return false;
        }
        public DataTable TimKiemSanPhamChoThanhToanTheoTen(string tensp, int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tensp.Equals(""))
                    cmd = new SqlCommand("SELECT SanPham.MaSP,TenSP,TenMau,TenSize,TenLoai,SoLuong,Gia,SanPham.TrangThai FROM SP_PhanBo,SanPham,Mau,Size,LoaiSP WHERE SanPham.MaSP=SP_PhanBo.MaSP AND SP_PhanBo.MaMau=SanPham.MaMau AND SP_PhanBo.MaSize=SanPham.MaSize AND SanPham.MaLoai=LoaiSP.MaLoai AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.TrangThai=1 AND MaCH=" + mach + " AND SanPham.MaSP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT SanPham.MaSP,TenSP,TenMau,TenSize,TenLoai,SoLuong,Gia,SanPham.TrangThai FROM SP_PhanBo,SanPham,Mau,Size,LoaiSP WHERE SanPham.MaSP=SP_PhanBo.MaSP AND SP_PhanBo.MaMau=SanPham.MaMau AND SP_PhanBo.MaSize=SanPham.MaSize AND SanPham.MaLoai=LoaiSP.MaLoai AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.TrangThai=1 AND MaCH=" + mach + " AND SanPham.TenSP LIKE'%" + tensp + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemSanPhamChoThanhToan(string masp,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (masp.Equals(""))
                    cmd = new SqlCommand("SELECT SanPham.MaSP,TenSP,TenMau,TenSize,TenLoai,SoLuong,Gia,SanPham.TrangThai FROM SP_PhanBo,SanPham,Mau,Size,LoaiSP WHERE SanPham.MaSP=SP_PhanBo.MaSP AND SP_PhanBo.MaMau=SanPham.MaMau AND SP_PhanBo.MaSize=SanPham.MaSize AND SanPham.MaLoai=LoaiSP.MaLoai AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.TrangThai=1 AND MaCH="+mach+" AND SanPham.MaSP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT SanPham.MaSP,TenSP,TenMau,TenSize,TenLoai,SoLuong,Gia,SanPham.TrangThai FROM SP_PhanBo,SanPham,Mau,Size,LoaiSP WHERE SanPham.MaSP=SP_PhanBo.MaSP AND SP_PhanBo.MaMau=SanPham.MaMau AND SP_PhanBo.MaSize=SanPham.MaSize AND SanPham.MaLoai=LoaiSP.MaLoai AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.TrangThai=1 AND MaCH=" + mach + " AND SanPham.MaSP LIKE'"+masp+"'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public  DataTable TimKiemSanPham(string masp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (masp.Equals(""))
                    cmd = new SqlCommand("SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai AND MASP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai AND MASP LIKE'" + masp + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemSanPhamTheoTen(string tensp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tensp.Equals(""))
                    cmd = new SqlCommand("SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai AND TENSP LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai AND TENSP LIKE'%" + tensp + "%'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable DocSanPhamThanhToan(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT SanPham.MaSP,TenSP,TenMau,TenSize,TenLoai,SoLuong,Gia,SanPham.TrangThai FROM SP_PhanBo,SanPham,Mau,Size,LoaiSP WHERE SanPham.MaSP=SP_PhanBo.MaSP AND SP_PhanBo.MaMau=SanPham.MaMau AND SP_PhanBo.MaSize=SanPham.MaSize AND SanPham.MaLoai=LoaiSP.MaLoai AND SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize  AND SP_PhanBo.TrangThai=1 AND MaCH=" + mach + "";
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
        public DataTable DocSanPhamChoHoaDonNhap()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai AND SanPham.TrangThai=1";
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
        public DataTable DocSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaSP,TenSP,TenMau,TenSize,TenLoai,Gia,SanPham.TrangThai FROM SanPham,Mau,Size,LoaiSP WHERE SanPham.MaMau=Mau.MaMau AND SanPham.MaSize=Size.MaSize AND SanPham.MaLoai= LoaiSP.MaLoai";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader rd= command.ExecuteReader();
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
        public DataTable layDanhSachMau()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENMAU FROM MAU WHERE TrangThai=1";
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
        public DataTable layDanhSachLoaiSP()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENLOAI FROM LoaiSP WHERE TrangThai=1";
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
        public DataTable layDanhSachSize()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENSIZE FROM Size WHERE TrangThai=1";
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
        public int LayMaLoai(string tenloai)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MALOAI FROM LOAISP WHERE TENLOAI='"+tenloai+"'";
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
        public int LayMaMau(string tenmau)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MAMAU FROM MAU WHERE TENMAU='" + tenmau + "'";
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
        public int LayMaSize(string tensize)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MASIZE FROM SIZE WHERE TENSIZE='" + tensize + "'";
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
        public int LayMaSPNew()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MAX(MASP)+1 FROM SanPham";
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
        public bool KiemTraMaSP(int masp)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MASP FROM SANPHAM WHERE MaSP='" + masp + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if(dt.Rows.Count >0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public string LayTenMau(int mamau)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENMAU FROM MAU WHERE MAMAU="+mamau+"";
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
        public string LayTenSize(int masize)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENSIZE FROM SIZE WHERE MAMAU=" + masize + "";
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
        public bool KiemTraSPTrongDonHang(int masp,int mamau,int masize)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CT_DonHang,DonHang WHERE DonHang.MaDH=CT_DonHang.MaDH AND  CT_DonHang.MaSP=" + masp + " AND CT_DonHang.MaMau=" + mamau + " AND CT_DonHang.MaSize=" + masize + " AND DonHang.TrangThai=1", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
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
