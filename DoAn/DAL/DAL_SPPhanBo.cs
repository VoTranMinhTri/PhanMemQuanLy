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
    public class DAL_SPPhanBo : General
    {
        public bool XoaSanPhamPhanBo(int masp, int mamau, int masize,int mach)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SP_PHANBO SET TrangThai=0 WHERE MaSP='" + masp + "' AND MaMau=" + mamau + " AND MaSize=" + masize + " AND MaCH="+mach+"", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable DocSPPhanBo(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT SP_PHANBO.MaSP,TenSP,TenMau,TenSize,MaCH,SoLuong,SP_PHANBO.TRANGTHAI FROM SP_PHANBO,SANPHAM,Mau,Size WHERE SP_PHANBO.MaSP=SanPham.MaSP AND SP_PHANBO.MaMau=SanPham.MaMau AND SP_PHANBO.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau AND MACH="+mach+"";
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
        public bool ThemSPPhanBo(SP_PhanBo sppb)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "SELECT SoLuong-" + sppb.soLuong + " FROM KhoHang WHERE MaSP=" + sppb.maSP + " AND MaMau=" + sppb.maMau + " AND MaSize=" + sppb.maSize + "";
                SqlCommand command1 = new SqlCommand(sql1, con);
                SqlDataReader rd = command1.ExecuteReader();
                dt.Load(rd);
                if (int.Parse(dt.Rows[0][0].ToString()) < 0)
                    return false;
                else
                {
                    string sql2 = "UPDATE KhoHang SET SOLUONG=SOLUONG-" + sppb.soLuong + " WHERE MaSP=" + sppb.maSP + " AND MaMau=" + sppb.maMau + " AND MaSize=" + sppb.maSize + "";
                    SqlCommand command2 = new SqlCommand(sql2, con);
                    command2.ExecuteNonQuery();
                    string sql3 = "INSERT INTO SP_PhanBo VALUES(" + sppb.maSP + ",'" + sppb.maMau + "'," + sppb.maSize + "," + sppb.maCH + "," + sppb.soLuong + ",1)";
                    SqlCommand command3 = new SqlCommand(sql3, con);
                    if (command3.ExecuteNonQuery() > 0)
                        return true;
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
            return false;
        }
        public bool SuaSPPhanBo(SP_PhanBo sppb, int maspcu, int mamaucu, int masizecu,int machcu,int soluongcu)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                int kqsoluong;
                if (soluongcu > sppb.soLuong)
                    kqsoluong = sppb.soLuong - soluongcu;
                else if (soluongcu < sppb.soLuong)
                    kqsoluong = sppb.soLuong - soluongcu;
                else
                    kqsoluong = 0;
                string sql1 = "SELECT SoLuong-'" + kqsoluong + "' FROM KhoHang WHERE MaSP=" + sppb.maSP + " AND MaMau=" + sppb.maMau + " AND MaSize=" + sppb.maSize + "";
                SqlCommand command1 = new SqlCommand(sql1, con);
                SqlDataReader rd = command1.ExecuteReader();
                dt.Load(rd);
                if (int.Parse(dt.Rows[0][0].ToString()) < 0)
                    return false;
                else
                {
                    string sql2 = "UPDATE KhoHang SET SOLUONG=SOLUONG-'" + kqsoluong + "' WHERE MaSP=" + sppb.maSP + " AND MaMau=" + sppb.maMau + " AND MaSize=" + sppb.maSize + "";
                    SqlCommand command2 = new SqlCommand(sql2, con);
                    command2.ExecuteNonQuery();
                    string sql3 = "UPDATE SP_PhanBo SET SoLuong="+sppb.soLuong+",TRANGTHAI="+sppb.trangThai+" WHERE MASP='" + maspcu + "' AND MAMAU='" + mamaucu + "' AND MASIZE='" + masizecu + "' AND MACH=" + machcu + "";
                    SqlCommand command3 = new SqlCommand(sql3, con);
                    if (command3.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable TimKiemSPPBTheoTen(string tensp,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (tensp.Equals(""))
                    cmd = new SqlCommand("SELECT SP_PHANBO.MaSP,TenSP,TenMau,TenSize,MaCH,SoLuong,SP_PHANBO.TRANGTHAI FROM SP_PHANBO,SANPHAM,Mau,Size WHERE SP_PHANBO.MaSP=SanPham.MaSP AND SP_PHANBO.MaMau=SanPham.MaMau AND SP_PHANBO.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and  tensp LIKE'%' AND MACH="+mach+"" , con);
                else
                    cmd = new SqlCommand("SELECT SP_PHANBO.MaSP,TenSP,TenMau,TenSize,MaCH,SoLuong,SP_PHANBO.TRANGTHAI FROM SP_PHANBO,SANPHAM,Mau,Size WHERE SP_PHANBO.MaSP=SanPham.MaSP AND SP_PHANBO.MaMau=SanPham.MaMau AND SP_PHANBO.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and tensp LIKE'%" + tensp + "%' AND MACH=" + mach + "", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemSPPB(string masp,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (masp.Equals(""))
                    cmd = new SqlCommand("SELECT SP_PHANBO.MaSP,TenSP,TenMau,TenSize,MaCH,SoLuong,SP_PHANBO.TRANGTHAI FROM SP_PHANBO,SANPHAM,Mau,Size WHERE SP_PHANBO.MaSP=SanPham.MaSP AND SP_PHANBO.MaMau=SanPham.MaMau AND SP_PHANBO.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and  SP_PHANBO.MASP LIKE'%' AND MACH=" + mach + "", con);
                else
                    cmd = new SqlCommand("SELECT SP_PHANBO.MaSP,TenSP,TenMau,TenSize,MaCH,SoLuong,SP_PHANBO.TRANGTHAI FROM SP_PHANBO,SANPHAM,Mau,Size WHERE SP_PHANBO.MaSP=SanPham.MaSP AND SP_PHANBO.MaMau=SanPham.MaMau AND SP_PHANBO.MaSize=SanPham.MaSize AND SanPham.MaSize=Size.MaSize AND SanPham.MaMau=Mau.MaMau and SP_PHANBO.MASP LIKE'" + masp + "' AND MACH=" + mach + "", con);
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
