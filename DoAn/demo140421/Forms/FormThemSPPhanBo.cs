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
    public partial class FormThemSPPhanBo : Form
    {
        int dongthu=0;
        public FormThemSPPhanBo()
        {
            InitializeComponent();
            BAL_CuaHang balch=new BAL_CuaHang();
            HienThiDanhSach(dgvListKho);
            cboCuaHang.DataSource = balch.LayDanhSachTenCuaHang();
            cboCuaHang.ValueMember = "TenCH";
        }

        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_KhoHang kho = new BAL_KhoHang();
            dgv.DataSource = kho.LayDanhSachKhoHang();
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_SanPham balhdn = new BAL_SanPham();
            dgvListKho.DataSource = balhdn.TimSanPham(txtTimKiem.Text);
        }
        private void dgvListKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListKho.Rows[dongthu];
                txtMaSP.Text = row.Cells["masp"].Value.ToString();
                txtTenMau.Text = row.Cells["tenmau"].Value.ToString();
                txtSize.Text = row.Cells["tensize"].Value.ToString();
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThem_Click_1(object sender, EventArgs e)
        {
            BAL_SPPhanBo balsppb = new BAL_SPPhanBo();
            BAL_CuaHang balch = new BAL_CuaHang();
            BAL_SanPham sp = new BAL_SanPham();
            DataGridViewRow row = dgvListKho.Rows[dongthu];
            int mamau = sp.LayMaMau(row.Cells[2].Value.ToString());
            int masize = sp.LayMaSize(row.Cells[3].Value.ToString());
            int mach = balch.LayMaCHTuTenCH(cboCuaHang.Text);
            try
            {
                SP_PhanBo sppb = new SP_PhanBo(int.Parse(txtMaSP.Text), mamau, masize, mach, int.Parse(txtSoLuong.Text), 1);
                bool kq = balsppb.ThemSPPhanBo(sppb);
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
