using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NhaCungCap
    {
        private int mancc;
        private string tenncc;
        private string diachi;
        private string email;
        private string sdt;
        private int trangthai;
        public NhaCungCap()
        {
            this.mancc = 0;
            this.tenncc = null;
            this.diachi = null;
            this.email = null;
            this.sdt = null;
            this.trangthai = 0;
        }
        public NhaCungCap(int mancc, string tenncc, string diachi, string email, string sdt, int trangthai)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
            this.trangthai = trangthai;
        }
        public string SDT
        {
            set { this.sdt = value; }
            get { return this.sdt; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public int maNCC
        {
            set { this.mancc = value; }
            get { return this.mancc; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
        public string tenNCC
        {
            set { this.tenncc = value; }
            get { return this.tenncc; }
        }
        public string diaChi
        {
            set { this.diachi = value; }
            get { return this.diachi; }
        }
    }
}
