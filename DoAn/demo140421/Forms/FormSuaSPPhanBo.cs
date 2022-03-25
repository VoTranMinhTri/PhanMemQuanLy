using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
namespace demo140421.Forms
{
    public partial class FormSuaSPPhanBo : Form
    {
        int masp;
        int mamau;
        int masize;
        int machcu;
        int soluongcu;
        public FormSuaSPPhanBo()
        {
            InitializeComponent();
        }
        public FormSuaSPPhanBo(int masp,string tenmau,string tensize,string tench,int soluong,int trangthai):this()
        {
            BAL_SanPham balsp=new BAL_SanPham();
            BAL_CuaHang balch=new BAL_CuaHang();
            this.masp = masp;
            this.mamau = balsp.LayMaMau(tenmau);
            this.masize = balsp.LayMaSize(tensize);
            this.machcu = balch.LayMaCHTuTenCH(tench);
            this.soluongcu = soluong;
            txtMaSP.Text = masp.ToString();
            txtTenMau.Text = tenmau;
            txtSize.Text = tensize;
            txtCuaHang.Text = tench;
            txtSoLuong.Text = soluong.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
            
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_SPPhanBo balsppb = new BAL_SPPhanBo();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                SP_PhanBo sppb = new SP_PhanBo(this.masp, this.mamau, this.masize, this.machcu, int.Parse(txtSoLuong.Text), trangthai);
                bool kq = balsppb.SuaSPPhanBo(sppb, this.masp, this.mamau, this.masize, this.machcu, this.soluongcu);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           catch(Exception err)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
