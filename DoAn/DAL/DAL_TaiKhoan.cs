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
    public class DAL_TaiKhoan:General
    {
        public DataTable TimKiemTaiKhoanTheoUsernameDanhChoQuanLy(string username,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (username.Equals(""))
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND USERNAME  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND USERNAME  LIKE'%" + username + "%'", con);

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
        public DataTable TimKiemTaiKhoanTheoHoTenDanhChoQuanLy(string hoten,int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (hoten.Equals(""))
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND Ho+' '+TenLot+' '+Ten  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND Ho+' '+TenLot+' '+Ten  LIKE'%" + hoten + "%'", con);
     
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
        public DataTable TimKiemTaiKhoanDanhChoQuanLy(string manv,int mach)
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
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND TaiKhoan.MaNV  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH =" + mach + " AND TaiKhoan.MaNV  LIKE'" + manv + "'", con);

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
        public DataTable TimKiemTaiKhoanTheoUsername(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (username.Equals(""))
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND USERNAME  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND USERNAME  LIKE'%" + username + "%'", con);
 
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
        public DataTable TimKiemTaiKhoanTheoHoTen(string hoten)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                SqlCommand cmd;
                if (hoten.Equals(""))
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND Ho+' '+TenLot+' '+Ten  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND Ho+' '+TenLot+' '+Ten  LIKE'%" + hoten + "%'", con);
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
        public DataTable TimKiemTaiKhoan(string manv)
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
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND TaiKhoan.MaNV  LIKE'%'", con);
                else
                    cmd = new SqlCommand("select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND TaiKhoan.MaNV  LIKE'" + manv + "'", con);

                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable DocTaiKhoanDanhChoQuanLy(int mach)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND MaCD!=3 AND MaCH ="+mach+"";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception err)
            {
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable DocTaiKhoan()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select TaiKhoan.MaNV,(Ho+' '+TenLot+' '+Ten) as HoTen,USERNAME,TaiKhoan.TrangThai from TAIKHOAN,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV";
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
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql1 = "INSERT INTO TAIKHOAN VALUES('" + tk.userName + "','" + tk.passWord + "'," + tk.maNV + ",'1') ";
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
        public bool XoaTaiKhoan(string username)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET TrangThai=0 WHERE username='" + username + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                return false;
            }
            return false;
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE taikhoan SET manv="+tk.maNV+",TRANGTHAI=" + tk.trangThai + " WHERE username='" + tk.userName + "'", con);
                if (cmd1.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception err)
            {
                return false;
            }
            return false;
        }
        public bool KiemTraTaiKhoan(string us, string pw)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select USERNAME,PASSWORD from TAIKHOAN where USERNAME = '" + us + "' AND TRANGTHAI=1" ;
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows[0][1].Equals(pw))
                {
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
        public bool DoiMatKhau(string us,string pass)
        {
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "update taikhoan set password='"+pass+"' where USERNAME = '" + us + "'";
                SqlCommand command = new SqlCommand(sql, con);
                if(command.ExecuteNonQuery()>0)
                {
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
        public bool KiemTraTenTaiKhoan(string us)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "select USERNAME from TAIKHOAN where USERNAME = '" + us + "'";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader rd = command.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count>0)
                {
                    return true;
                }
            }
            catch (Exception err)
            { }
            finally
            {
                con.Close();
            }
            return false;
        }
        public int LayMaNV(string tk)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT TaiKhoan.MaNV  FROM TaiKhoan,NhanVien WHERE TaiKhoan.MaNV=NhanVien.MaNV AND TaiKhoan.username='" + tk + "'";
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
        public int LayMaCD(int manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaCD FROM NhanVien WHERE MaNV='" + manv + "'";
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
        public string LayPassword(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT password  FROM TaiKhoan WHERE username='" + username + "'";
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
        public int LayMaCH(int manv)
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConnectionState.Closed == con.State)
                {
                    con.Open();
                }
                string sql = "SELECT MaCH FROM NhanVien WHERE MaNV='" + manv + "'";
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
    }
}
