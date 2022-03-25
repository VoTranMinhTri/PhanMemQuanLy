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
    public partial class FormNhanVien : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int macdht;
        int machht;
        int manvht;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public FormNhanVien(int macd,int mach,int manv):this()
        {
            this.macdht = macd;
            this.machht = mach;
            this.manvht = manv;
            cboTimKiem.SelectedIndex = 0;
            cboTimKiemCD.SelectedIndex = 0;
            if(macd!=3)
            {
                iconButtonSuaChucDanh.Enabled = false;
                iconButtonThemChucDanh.Enabled = false;
                iconButtonXoaChucDanh.Enabled = false;
                iconButtonXoaChucDanh.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonSuaChucDanh.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonThemChucDanh.BackColor = Color.FromArgb(37, 36, 81);
                HienThiDanhSachDanhChoQuanLy(dgvListNV, mach);
                HienThiDanhSachChucDanhDanhChoQuanLy(dataGridView2);    
            }
            else
            { 
                HienThiDanhSach(dgvListNV);
                HienThiDanhSachChucDanh(dataGridView2);
            }

        }
        public static void HienThiDanhSachDanhChoQuanLy(DataGridView dgv,int mach)
        {
            BAL_NhanVien nv = new BAL_NhanVien();
            dgv.DataSource = nv.LayDanhSachNVDanhChoQuanLy(mach);
           
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_NhanVien nv = new BAL_NhanVien();
            dgv.DataSource = nv.LayDanhSachNV();
            for(int i=0;i<dgv.RowCount-1;i++)
            {
                if(dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }
        public static void HienThiDanhSachChucDanhDanhChoQuanLy(DataGridView dgv)
        {
            BAL_ChucDanh sp = new BAL_ChucDanh();
            dgv.DataSource = sp.LayDanhSachCDDanhChoQuanLy();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }
        public static void HienThiDanhSachChucDanh(DataGridView dgv)
        {
            BAL_ChucDanh sp = new BAL_ChucDanh();
            dgv.DataSource = sp.LayDanhSachCD();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthaicd"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthaicd"].Value = "Còn sử dụng";
                }
                else
                    dgv.Rows[i].Cells["trangthaicd"].Value = "Không còn sử dụng";
            }
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien frm = new FormThemNhanVien(this.macdht,this.machht);
            frm.ShowDialog();
            if (this.macdht != 3)
            {
                HienThiDanhSachDanhChoQuanLy(dgvListNV, this.machht);
            }
            else
                HienThiDanhSach(dgvListNV);
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_NhanVien sp = new BAL_NhanVien();
            DataGridViewRow row = dgvListNV.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (this.manvht != int.Parse(row.Cells["manv"].Value.ToString()))
                {
                    if (sp.XoaNhanVien(int.Parse(row.Cells["manv"].Value.ToString())))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.macdht != 3)
                        {
                            HienThiDanhSachDanhChoQuanLy(dgvListNV, this.machht);
                        }
                        else
                            HienThiDanhSach(dgvListNV);
                    }
                    else
                        MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListNV.Rows[dongthu];
            int maNV = int.Parse(row.Cells["manv"].Value.ToString());
            string ho = row.Cells["ho"].Value.ToString();
            string tenlot = row.Cells["tenlot"].Value.ToString();
            string ten = row.Cells["ten"].Value.ToString();
            string gioiTinh = row.Cells["gioitinh"].Value.ToString();
            DateTime ngaySinh = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
            string cccd = row.Cells["cccd"].Value.ToString();
            string sDT = row.Cells["sdt"].Value.ToString();
            string diaChi = row.Cells["diachi"].Value.ToString();
            DateTime ngayVaoLam = DateTime.Parse(row.Cells["ngaybdlam"].Value.ToString());
            DateTime ngayKetThuc;
            if (row.Cells["ngayketthuc"].Value.ToString().Equals(""))
                ngayKetThuc = DateTime.Parse("1/1/2030");
            else
                ngayKetThuc = DateTime.Parse(row.Cells["ngayketthuc"].Value.ToString());
            int macd = int.Parse(row.Cells["macd"].Value.ToString());
            int mach = int.Parse(row.Cells["mach"].Value.ToString());
            int manvql = int.Parse(row.Cells["manvql"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn làm"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaNhanVien frm = new FormSuaNhanVien(maNV, ho, tenlot, ten, ngaySinh, gioiTinh, cccd, sDT, diaChi, ngayVaoLam, ngayKetThuc, macd, mach, manvql, trangthai, this.macdht, this.machht);
                frm.ShowDialog();
                if(this.macdht!=3)
                {
                    HienThiDanhSachDanhChoQuanLy(dgvListNV, this.machht);
                }
                else
                HienThiDanhSach(dgvListNV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListNV.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_NhanVien balnv = new BAL_NhanVien();
            if (this.macdht != 3)
            {
                if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListNV.DataSource = balnv.TimKiemNhanVienDanhChoQuanLy(txtTimKiem.Text,this.machht);
                else
                    dgvListNV.DataSource = balnv.TimKiemNhanVienTheoTenDanhChoQuanLy(txtTimKiem.Text, this.machht);
            }
            else
            {
                if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListNV.DataSource = balnv.TimKiemNhanVien(txtTimKiem.Text);
                else
                    dgvListNV.DataSource = balnv.TimKiemNhanVienTheoTen(txtTimKiem.Text);
            }
            for (int i = 0; i < dgvListNV.RowCount - 1; i++)
            {
                if (dgvListNV.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListNV.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgvListNV.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }

        private void iconButtonThemChucDanh_Click(object sender, EventArgs e)
        {
            FormThemChucDanh frm = new FormThemChucDanh();
            frm.ShowDialog();
            HienThiDanhSachChucDanh(dataGridView2);
        }

        private void iconButtonXoaChucDanh_Click(object sender, EventArgs e)
        {
            BAL_ChucDanh cd = new BAL_ChucDanh();
            DataGridViewRow row = dataGridView2.Rows[dongthu1];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (cd.XoaChucDanh(int.Parse(row.Cells["macdnv"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachChucDanh(dataGridView2);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSuaChucDanh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[dongthu1];
            int macd = int.Parse(row.Cells["macdnv"].Value.ToString());
            float luong = float.Parse(row.Cells["luongcb"].Value.ToString());
            string tencd = row.Cells["tencd"].Value.ToString();
            int trangthai=0;
            if (row.Cells["trangthaicd"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaChucDanh frm = new FormSuaChucDanh(macd,tencd,luong,trangthai);
                frm.ShowDialog();
                HienThiDanhSachChucDanh(dataGridView2);
            }
        }

        private void iconPictureBoxSearchChucDanh_Click(object sender, EventArgs e)
        {
            BAL_ChucDanh balcd = new BAL_ChucDanh();
            if (this.macdht != 3)
            {
                if (cboTimKiemCD.Text.Equals("Mã CD"))
                    dataGridView2.DataSource = balcd.TimKiemChucDanhChoQuanLy(txtTimKiemChucDanh.Text);
                else
                    dataGridView2.DataSource = balcd.TimKiemChucDanhTheoTenDanhChoQuanLy(txtTimKiemChucDanh.Text);
            }
            else
            {
                if (cboTimKiemCD.Text.Equals("Mã CD"))
                    dataGridView2.DataSource = balcd.TimKiemChucDanh(txtTimKiemChucDanh.Text);
                else
                    dataGridView2.DataSource = balcd.TimKiemChucDanhTheoTen(txtTimKiemChucDanh.Text);
            }
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells["trangthaicd"].Value.ToString().Equals("1"))
                {
                    dataGridView2.Rows[i].Cells["trangthaicd"].Value = "Còn sử dụng";
                }
                else
                    dataGridView2.Rows[i].Cells["trangthaicd"].Value = "Không còn sử dụng";
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }
    }
}
