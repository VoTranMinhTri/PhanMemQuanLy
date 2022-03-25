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
namespace demo140421.Forms
{
    public partial class FormSanPham : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        public FormSanPham()
        {
            InitializeComponent();
            cboTimKiem.SelectedIndex = 0;
            cboTimKiemLoaiSP.SelectedIndex = 0;
            HienThiDanhSach(dgvListSP);
            HienThiDanhSachLoaiSP(dgvListLoaiSP);
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_SanPham sp = new BAL_SanPham();
            dgv.DataSource = sp.LayDanhSachSP();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn hoạt động";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Không còn hoạt động";
            }
        }
        public static void HienThiDanhSachLoaiSP(DataGridView dgv)
        {
            BAL_LoaiSanPham lsp = new BAL_LoaiSanPham();
            dgv.DataSource = lsp.LayDanhSachLoaiSP();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthailoai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthailoai"].Value = "Còn sử dụng";
                }
                else
                    dgv.Rows[i].Cells["trangthailoai"].Value = "Không còn sử dụng";
            }
        }
        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_SanPham sp = new BAL_SanPham();
            DataGridViewRow row = dgvListSP.Rows[dongthu];
            int mamau = sp.LayMaMau(row.Cells["tenmau"].Value.ToString());
            int masize = sp.LayMaSize(row.Cells["size"].Value.ToString());
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (sp.KiemTraSPTrongDonHang(int.Parse(row.Cells["masp"].Value.ToString()), mamau, masize) == false)
                {
                    if (sp.XoaSanPham(int.Parse(row.Cells["masp"].Value.ToString()), mamau, masize) == true)
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDanhSach(dgvListSP);
                    }
                    else
                        MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xoá không thành công! Sản phẩm này đang trong đơn đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListSP.Rows[dongthu];
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn hoạt động"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaSanPham frm = new FormSuaSanPham(int.Parse(row.Cells["masp"].Value.ToString()), row.Cells["tensp"].Value.ToString(), row.Cells["loaisanpham"].Value.ToString(), row.Cells["tenmau"].Value.ToString(), row.Cells["size"].Value.ToString(), float.Parse(row.Cells["gia"].Value.ToString()),trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dgvListSP);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            if(cboTimKiem.Text.Equals("Mã SP"))
                dgvListSP.DataSource = balsp.TimSanPham(txtTimKiem.Text);
            else
                dgvListSP.DataSource = balsp.TimSanPhamTheoTen(txtTimKiem.Text);
            for (int i = 0; i < dgvListSP.RowCount - 1; i++)
            {
                if (dgvListSP.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListSP.Rows[i].Cells["trangthai"].Value = "Còn hoạt động";
                }
                else
                    dgvListSP.Rows[i].Cells["trangthai"].Value = "Không còn hoạt động";
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemSanPham frm = new FormThemSanPham();
            frm.ShowDialog();
            HienThiDanhSach(dgvListSP);
        }
        private void dgvListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListSP.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void dgvListLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvListLoaiSP.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThemLoaiSP_Click(object sender, EventArgs e)
        {
            FormThemLoaiSanPham frm = new FormThemLoaiSanPham();
            frm.ShowDialog();
            HienThiDanhSachLoaiSP(dgvListLoaiSP);
        }

        private void iconButtonXoaLoaiSP_Click(object sender, EventArgs e)
        {
            BAL_LoaiSanPham cd = new BAL_LoaiSanPham();
            DataGridViewRow row = dgvListLoaiSP.Rows[dongthu1];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (cd.XoaLoaiSP(int.Parse(row.Cells["maloai"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachLoaiSP(dgvListLoaiSP);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSuaLoaiSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListLoaiSP.Rows[dongthu1];
            int maloai = int.Parse(row.Cells["maloai"].Value.ToString());
            string tenloai = row.Cells["tenloai"].Value.ToString();
            int trangthai = 0;
            if (row.Cells["trangthailoai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaLoaiSanPham frm = new FormSuaLoaiSanPham(maloai, tenloai, trangthai);
                frm.ShowDialog();
                HienThiDanhSachLoaiSP(dgvListLoaiSP);
            }
        }

        private void iconPictureBoxSearchLoaiSP_Click(object sender, EventArgs e)
        {
            BAL_LoaiSanPham balsp = new BAL_LoaiSanPham();
            if (cboTimKiemLoaiSP.Text.Equals("Mã loại"))
                dgvListLoaiSP.DataSource = balsp.TimKiemLoaiSP(txtTimKiemLoai.Text);
            else
                dgvListLoaiSP.DataSource = balsp.TimKiemLoaiSPTheoTen(txtTimKiemLoai.Text);
            for (int i = 0; i < dgvListLoaiSP.RowCount - 1; i++)
            {
                if (dgvListLoaiSP.Rows[i].Cells["trangthailoai"].Value.ToString().Equals("1"))
                {
                    dgvListLoaiSP.Rows[i].Cells["trangthailoai"].Value = "Còn sử dụng";
                }
                else
                    dgvListLoaiSP.Rows[i].Cells["trangthailoai"].Value = "Không còn sử dụng";
            }
        }
    }
}
