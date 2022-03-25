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
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();
            BAL_SanPham balsp = new BAL_SanPham();
            cbLoaiSP.DataSource = balsp.LayDanhSachLoaiSP();
            cbMau.DataSource = balsp.LayDanhSachMau();
            cbSize.DataSource = balsp.LayDanhSachSize();
            cbLoaiSP.ValueMember = "TenLoai";
            cbMau.ValueMember = "TenMau";
            cbSize.ValueMember = "TenSize";
            //txtMaSP.Text=balsp.LayMaSPNew().ToString();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            try
            {
                SanPham sp = new SanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, cbLoaiSP.Text, cbMau.Text, cbSize.Text, float.Parse(txtGia.Text), 1);
                bool kq = balsp.ThemSanPham(sp);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
