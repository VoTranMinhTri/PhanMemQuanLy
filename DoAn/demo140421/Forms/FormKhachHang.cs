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
    public partial class FormKhachHang : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public FormKhachHang(int macd):this()
        {
            if(macd == 1)
            {
                iconButtonSuaLoai.Enabled = false;
                iconButtonThemLoai.Enabled = false;
                iconButtonXoaLoai.Enabled = false;
                iconButtonSuaLoai.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonThemLoai.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonXoaLoai.BackColor = Color.FromArgb(37, 36, 81);
            }
            HienThiDanhSach(dgvListKhachHang);
            HienThiDanhSachLoai(dgvListLoaiKH);
            cboTimKiem.SelectedIndex = 0;
            cboTimKiemLoaiKH.SelectedIndex = 0;
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_KhachHang nv = new BAL_KhachHang();
            dgv.DataSource = nv.LayDanhSachKH();
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
        public static void HienThiDanhSachLoai(DataGridView dgv)
        {
            BAL_LoaiKhachHang nv = new BAL_LoaiKhachHang();
            dgv.DataSource = nv.LayDanhSachLKH();
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
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemKhachHang frm = new FormThemKhachHang();
            frm.ShowDialog();
            HienThiDanhSach(dgvListKhachHang);
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_KhachHang nv = new BAL_KhachHang();
            DataGridViewRow row = dgvListKhachHang.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (nv.XoaKhachHang(int.Parse(row.Cells["makh"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dgvListKhachHang);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListKhachHang.Rows[dongthu];
            int maKH = int.Parse(row.Cells["makh"].Value.ToString());
            string hoTen = row.Cells["tenkh"].Value.ToString();
            string gioiTinh = row.Cells["gioitinh"].Value.ToString();
            DateTime ngaySinh = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
            string sDT = row.Cells["sdt"].Value.ToString();
            string diaChi = row.Cells["diachi"].Value.ToString();
            int maLoai = int.Parse(row.Cells["maloai"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            float doanhso=float.Parse(row.Cells["doanhso"].Value.ToString());
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaKhachHang frm = new FormSuaKhachHang(maKH, hoTen, gioiTinh, ngaySinh, sDT, diaChi,doanhso, maLoai,trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dgvListKhachHang);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListKhachHang.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_KhachHang balkh = new BAL_KhachHang();
            if(cboTimKiem.Text.Equals("Mã KH"))
                dgvListKhachHang.DataSource = balkh.TimKhachHang(txtTimKiem.Text);
            else
                dgvListKhachHang.DataSource = balkh.TimKhachHangTheoTen(txtTimKiem.Text);
            for (int i = 0; i < dgvListKhachHang.RowCount - 1; i++)
            {
                if (dgvListKhachHang.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListKhachHang.Rows[i].Cells["trangthai"].Value = "Còn hoạt động";
                }
                else
                    dgvListKhachHang.Rows[i].Cells["trangthai"].Value = "Không còn hoạt động";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvListLoaiKH.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThemLoai_Click(object sender, EventArgs e)
        {
            FormThemLoaiKhachHang frm = new FormThemLoaiKhachHang();
            frm.ShowDialog();
            HienThiDanhSachLoai(dgvListLoaiKH);
        }

        private void iconButtonXoaLoai_Click(object sender, EventArgs e)
        {
            BAL_LoaiKhachHang nv = new BAL_LoaiKhachHang();
            DataGridViewRow row = dgvListLoaiKH.Rows[dongthu1];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (nv.XoaLoaiKhachHang(int.Parse(row.Cells["maloaikh"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachLoai(dgvListLoaiKH);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSuaLoai_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListLoaiKH.Rows[dongthu1];
            int maLKH = int.Parse(row.Cells["maloaikh"].Value.ToString());
            string ten = row.Cells["tenloai"].Value.ToString();
            float hanmuc = float.Parse(row.Cells["hanmuc"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthailoai"].Value.ToString().Equals("Còn hoạt động"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaLoaiKhachHang frm = new FormSuaLoaiKhachHang(maLKH,ten,hanmuc, trangthai);
                frm.ShowDialog();
                HienThiDanhSachLoai(dgvListLoaiKH);
            }
        }

        private void iconPictureBoxSearchLoai_Click(object sender, EventArgs e)
        {
            BAL_LoaiKhachHang ballkh = new BAL_LoaiKhachHang();
            if(cboTimKiemLoaiKH.Text.Equals("Mã loại"))
                dgvListLoaiKH.DataSource = ballkh.TimLoaiKhachHang(txtTimKiemLoai.Text);
            else
                dgvListLoaiKH.DataSource = ballkh.TimKiemLoaiKhachHangTheoTen(txtTimKiemLoai.Text);
            for (int i = 0; i < dgvListLoaiKH.RowCount - 1; i++)
            {
                if (dgvListLoaiKH.Rows[i].Cells["trangthailoai"].Value.ToString().Equals("1"))
                {
                    dgvListLoaiKH.Rows[i].Cells["trangthailoai"].Value = "Còn sử dụng";
                }
                else
                    dgvListLoaiKH.Rows[i].Cells["trangthailoai"].Value = "Không còn sử dụng";
            }
        }

  
    }
}
