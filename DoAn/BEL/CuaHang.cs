using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CuaHang
    {
        private int mach;
        private string tench;
        private string diachi;
        private int trangthai;
        public CuaHang()
        {
            this.mach = 0;
            this.tench = null;
            this.diachi = null;
            this.trangthai = 0;
        }
        public CuaHang(int mach, string tench, string diachi,  int trangthai)
        {
            this.mach = mach;
            this.tench = tench;
            this.diachi = diachi;
            this.trangthai = trangthai;
        }
        public int maCH
        {
            set { this.mach = value; }
            get { return this.mach; }
        }
        public string diaChi
        {
            set { this.diachi = value; }
            get { return this.diachi; }
        }
        public string tenCH
        {
            set { this.tench = value; }
            get { return this.tench; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
    }
}
