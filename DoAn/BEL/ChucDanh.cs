using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ChucDanh
    {
        private int macd;
        private string tencd;
        private int trangthai;
        private float luongcb;
        public ChucDanh()
        {
            this.macd = 0;
            this.tencd = null;
            this.luongcb=0;
            this.trangthai = 0;
        }
        public ChucDanh(int macd, string tencd,float luongcb, int trangthai)
        {
            this.macd = macd;
            this.tencd = tencd;
            this.luongcb = luongcb;
            this.trangthai = trangthai;
        }
        public string tenCD
        {
            set { this.tencd = value; }
            get { return this.tencd; }
        }
        public float luongCB
        {
            set { this.luongcb = value; }
            get { return this.luongcb; }
        }
        public int maCD
        {
            set { this.macd = value; }
            get { return this.macd; }
        }
        public int trangThai
        {
            set { this.trangthai = value; }
            get { return this.trangthai; }
        }
    }
}
