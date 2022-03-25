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
    public class DAL_Luong:General
    {
        public bool ThemLuong(Luong luong)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "insert into Luong values('" + luong.maNV + "','" + luong.Thang + "','" + luong.Nam + "','" + luong.LuongTK + "','1')";
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
        public bool CapNhatLaiTrangThaiLuong(int manv,int thang,int nam)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "update luong set trangthai=0 where manv="+manv+" and thang="+thang+" and nam="+nam+"";
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
        public bool XoaLuong(int manv,int thang,int nam)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Luong SET TRANGTHAI=0 WHERE MaNV='" + manv + "' AND THANG="+thang+" AND NAM="+nam+"", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaLuong(Luong luong, int manv, int thang, int nam)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE Luong SET MaNV="+luong.maNV+",Thang="+luong.Thang+",Nam="+luong.Nam+",Luong="+luong.LuongTK+",TrangThai="+luong.trangThai+"  WHERE MaNV='" + manv + "' AND THANG=" + thang + " AND NAM=" + nam + "", con);
                if (cmd1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable DocLuong()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE LUONG.TrangThai=1 AND NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE())";
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
        public DataTable TimKiemLuongCuaNVTheoNam(string nam)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (nam.Equals(""))
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND  NAM LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND  NAM LIKE'" + nam + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
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
        public DataTable TimKiemLuongCuaNVTheoThang(string thang)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (thang.Equals(""))
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND   THANG LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND  THANG LIKE'" + thang + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
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
        public DataTable TimKiemLuongCuaNV(string manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (manv.Equals(""))
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND   LUONG.MANV LIKE'%'", con);
                else
                    cmd = new SqlCommand("SELECT NhanVien.MaNV,Ho+' '+TenLot+' '+Ten as HoTen,TenCD,TenCH,Thang,Nam,Luong,Luong.TrangThai FROM Luong,NhanVien,CuaHang,ChucDanh WHERE NhanVien.MaCD=ChucDanh.MaCD AND NhanVien.MaCH=CuaHang.MaCH AND NhanVien.MaNV=LUONG.MaNV AND THANG=MONTH(GETDATE()) AND NAM=YEAR(GETDATE()) AND  LUONG.MANV LIKE'" + manv + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
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
