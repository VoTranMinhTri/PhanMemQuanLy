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
    public partial class FormSuaKhoHang : Form
    {
        int masp;
        int mamau;
        int masize;
        public FormSuaKhoHang()
        {
            InitializeComponent();
        }
        public FormSuaKhoHang(int masp,int mamau,int masize,int soluong):this()
        {
            this.masp = masp;
            this.mamau = mamau;
            this.masize = masize;
            txtMaSP.Text = masp.ToString();
            txtSoLuong.Text = soluong.ToString();
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_KhoHang balkho = new BAL_KhoHang();
            try
            {
                KhoHang kho = new KhoHang(this.masp, this.mamau, this.masize, int.Parse(txtSoLuong.Text));
                bool kq = balkho.SuaKhoHang(kho);
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
