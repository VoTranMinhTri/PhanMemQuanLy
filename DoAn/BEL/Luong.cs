using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Luong
    {
        private int manv;
        private int thang;
        private int nam;
        private float luong;
        private int trangthai;
        public Luong()
        {
            this.manv = 0;
            this.thang = 0;
            this.nam = 0;
            this.luong = 0;
            this.trangthai = 0;
        }
        public Luong(int manv, int thang, int nam, float luong, int trangthai)
        {
            this.manv = manv;
            this.thang = thang;
            this.nam = nam;
            this.luong = luong;
            this.trangthai = trangthai;
        }
        public int maNV
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public int Thang
        {
            set { this.thang = value; }
            get { return this.thang; }
        }
        public int Nam
        {
            set { this.nam = value; }
            get { return this.nam; }
        }
        public float LuongTK
        {
            set { this.luong = value; }
            get { return this.luong; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
    }
}
