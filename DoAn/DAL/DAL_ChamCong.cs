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
    public class DAL_ChamCong : General
    {
        public bool ThemChamCong(ChamCong cc)
        {
            
            bool ketqua1 = false;
            bool ketqua2 = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "insert into ChamCong values('" + cc.maCC + "','" + cc.ngayCham + "','" + cc.maNV + "','" + cc.maNV_CC + "','1')";
                SqlCommand command1 = new SqlCommand(sql1, con);
                if (command1.ExecuteNonQuery() > 0)
                    ketqua1 = true;
                string sql2 = "insert into CT_ChamCong values('" + cc.maCC + "','" + cc.maLC + "')";
                SqlCommand command2 = new SqlCommand(sql2, con);
                if (command2.ExecuteNonQuery() > 0)
                    ketqua2 = true;
                if (ketqua1 == true && ketqua2 == true)
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
        public bool XoaChamCong(int macc)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChamCong SET TRANGTHAI=0 WHERE Macc='" + macc + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public bool SuaChamCong(ChamCong cc, int macccu,int malccu)
        {
            try
            {
                bool ketqua1 = false;
                bool ketqua2 = false;
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE ChamCong SET MAcc='" + cc.maCC + "',MANV='" + cc.maNV + "',MANV_CC='" + cc.maNV_CC + "',NGAYCHAM='" + cc.ngayCham + "',TRANGTHAI='" + cc.trangThai + "' WHERE MAcc='" + macccu + "'", con);
                if (cmd1.ExecuteNonQuery() > 0)
                    ketqua1= true;
                SqlCommand cmd2 = new SqlCommand("UPDATE CT_ChamCong SET MAcc='" + cc.maCC + "',MALC='" + cc.maLC + "' WHERE MAcc='" + macccu + "' AND MALC='" + malccu + "'", con);
                if (cmd2.ExecuteNonQuery() > 0)
                    ketqua2 = true;
                if (ketqua1 == true && ketqua2 == true)
                    return true;
            }
            catch (Exception err)
            {
                throw;
            }
            return false;
        }
        public DataTable layDanhSachLoaiChamCong()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TENLC FROM LOAICHAM";
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
        public DataTable DocChamCongDanhChoQuanLy(int manvql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC="+manvql+" AND nv2.MaNV="+manvql+"";
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
        public DataTable DocChamCong()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC";
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
        public int LayMaLoaiCC(string tenloai)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaLC FROM LoaiCham WHERE TenLC='" + tenloai + "'";
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
        public int LayMaCCNew()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MACC)+1 FROM ChamCong ", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            if (dt.Rows[0][0].ToString().Equals(""))
                return 1;
            else
                return int.Parse(dt.Rows[0][0].ToString());
        }
        public float LayTongTienChamCong(int manv,int thang,int nam)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(SoTien) FROM LoaiCham,ChamCong,CT_ChamCong WHERE ChamCong.MaCC=CT_ChamCong.MaCC AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=" + manv + " AND MONTH(NgayCham)=" + thang + " AND YEAR(NgayCham)="+nam+"", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            if (dt.Rows[0][0].ToString().Equals(""))
                return 0;
            return float.Parse(dt.Rows[0][0].ToString());
        }
        public DataTable TimKiemChamCongTheoNgay(string ngaycham)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (ngaycham.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND DAY(NgayCham) LIKE '"+ngaycham+"' AND nv2.MaNV=ChamCong.MaNV_CC", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChamCongTheoMaNV(string manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (manv.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC AND ChamCong.MaNV  LIKE'" + manv + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChamCong(string macc)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (macc.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND nv2.MaNV=ChamCong.MaNV_CC AND ChamCong.MaCC  LIKE'" + macc + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChamCongTheoNgayDanhChoQuanLy(string ngaycham,int manvql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (ngaycham.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + "", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + " AND DAY(NgayCham) LIKE'" + ngaycham + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChamCongTheoMaNVDanhChoQuanLy(string manv, int manvql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (manv.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + "", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + " AND ChamCong.MaNV  LIKE'" + manv + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public DataTable TimKiemChamCongDanhChoQuanLy(string macc, int manvql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                if (macc.Equals(""))
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + "", con);
                else
                    cmd = new SqlCommand("SELECT ChamCong.Macc,NgayCham,ChamCong.MaNV,(nv1.Ho+' '+nv1.TenLot+' '+nv1.Ten) as HoTenNV,(nv2.Ho+' '+nv2.TenLot+' '+nv2.Ten) as HoTenNVCC,MaNV_cc,TenLC,SoTien,ChamCong.TrangThai FROM ChamCong,CT_ChamCong,LoaiCham,NhanVien nv1,NhanVien nv2 WHERE ChamCong.Macc=CT_ChamCong.Macc AND CT_ChamCong.MaLC=LoaiCham.MaLC AND ChamCong.MaNV=nv1.MaNV AND nv1.MaCD=1 AND MONTH(NgayCham)=MONTH(GETDATE()) AND MaNV_CC=" + manvql + " AND nv2.MaNV=" + manvql + " AND ChamCong.MaCC  LIKE'" + macc + "'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
                throw;
            }
            return dt;
        }
        public bool KiemTraNgayNghiCoPhep(int manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT COUNT(CHAMCONG.MACC) FROM CHAMCONG,CT_ChamCong,NhanVien WHERE ChamCong.MaCC=CT_ChamCong.MaCC AND MaLC=3 AND NhanVien.MaNV=ChamCong.MaNV AND NHANVIEN.MaNV="+manv+" AND MONTH(NgayCham)=MONTH(GETDATE())", con);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (int.Parse(dt.Rows[0][0].ToString()) > 3)
                    return false;
               
            }
            catch (Exception err)
            {
                return false;
            }
            return true;
        }
    }
}
