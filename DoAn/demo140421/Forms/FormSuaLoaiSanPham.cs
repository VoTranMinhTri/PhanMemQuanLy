using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
namespace demo140421.Forms
{
    public partial class FormSuaLoaiSanPham : Form
    {
        int maloaispcu;
        public FormSuaLoaiSanPham()
        {
            InitializeComponent();
        }
        public FormSuaLoaiSanPham(int maloai,string tenloai,int trangthai):this()
        {
            this.maloaispcu = maloai;
            txtMaLoai.Text = maloai.ToString();
            txtTenLoai.Text = tenloai;
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_LoaiSanPham ballsp = new BAL_LoaiSanPham();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                LoaiSanPham lsp = new LoaiSanPham(int.Parse(txtMaLoai.Text), txtTenLoai.Text, trangthai);
                bool kq = ballsp.SuaLoaiSP(lsp, this.maloaispcu);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
