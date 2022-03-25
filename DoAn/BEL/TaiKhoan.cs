using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class TaiKhoan
    {
        private string username;
        private string password;
        private int manv;
        private int trangthai;
        public TaiKhoan()
        {
            this.username = null;
            this.password = null;
            this.manv = 0;
            this.trangthai = 0;
        }
        public TaiKhoan(string username, string password, int manv, int trangthai)
        {
            this.username = username;
            this.password = password;
            this.manv = manv;
            this.trangthai = trangthai;
        }
        public string passWord
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public string userName
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
    }
}
