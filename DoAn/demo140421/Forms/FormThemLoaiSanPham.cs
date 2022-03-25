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
    public partial class FormThemLoaiSanPham : Form
    {
        public FormThemLoaiSanPham()
        {
            InitializeComponent();
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {

            BAL_LoaiSanPham ballsp = new BAL_LoaiSanPham();
            try
            {
                LoaiSanPham lsp = new LoaiSanPham(int.Parse(txtMaLoai.Text), txtTenLoai.Text, 1);
                bool kq = ballsp.ThemLoaiSP(lsp);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
