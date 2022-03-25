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
    public partial class FormTaiKhoan : Form
    {
        int dongthu = 0;
        int manvht;
        int macdht;
        int machht;
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        public FormTaiKhoan(int manv,int mach,int macd):this()
        {
            this.manvht = manv;
            this.macdht = macd;
            this.machht = mach;
            if (this.macdht != 3)
            {
                HienThiDanhSachDanhChoQuanLy(dgvListTK, this.machht);
            }
            else
                HienThiDanhSach(dgvListTK);
            cboTimKiem.SelectedIndex = 0;
        }
        public static void HienThiDanhSachDanhChoQuanLy(DataGridView dgv,int mach)
        {
            BAL_TaiKhoan tk = new BAL_TaiKhoan();
            DataTable dt = tk.LayDanhSachTKDanhChoQuanLy(mach);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][2] = Encryption.Decrypt(dt.Rows[i][2].ToString());
                }
            }
            dgv.DataSource = dt;
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
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_TaiKhoan tk = new BAL_TaiKhoan();
            DataTable dt=tk.LayDanhSachTK();
            if(dt.Rows.Count>0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    dt.Rows[i][2]=Encryption.Decrypt(dt.Rows[i][2].ToString());
                }
            }
            dgv.DataSource = dt;
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
        private void dgvListTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListTK.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan frm = new FormThemTaiKhoan(this.machht,this.macdht);
            frm.ShowDialog();
            if (this.macdht != 3)
            {
                HienThiDanhSachDanhChoQuanLy(dgvListTK, this.machht);
            }
            else
                HienThiDanhSach(dgvListTK);
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_TaiKhoan tk = new BAL_TaiKhoan();
            DataGridViewRow row = dgvListTK.Rows[dongthu];
            string username =Encryption.Encrypt(row.Cells["username"].Value.ToString());
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (this.manvht != tk.LayMaNV(username))
                {
                    if (tk.XoaTaiKhoan(username) == true)
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.macdht != 3)
                        {
                            HienThiDanhSachDanhChoQuanLy(dgvListTK, this.machht);
                        }
                        else
                            HienThiDanhSach(dgvListTK);
                    }
                    else
                        MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xoá không thành công! Tài khoản hiện đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListTK.Rows[dongthu];
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn hoạt động"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaTaiKhoan frm = new FormSuaTaiKhoan(row.Cells["username"].Value.ToString(),int.Parse(row.Cells["manv"].Value.ToString()),trangthai,this.manvht,this.macdht,this.machht);
                frm.ShowDialog();
                if (this.macdht != 3)
                {
                    HienThiDanhSachDanhChoQuanLy(dgvListTK, this.machht);
                }
                else
                    HienThiDanhSach(dgvListTK);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
             BAL_TaiKhoan tk = new BAL_TaiKhoan();
            if (this.macdht != 3)
            {
                if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListTK.DataSource = tk.TimKiemTaiKhoanDanhChoQuanLy(txtTimKiem.Text,this.machht);
                else if (cboTimKiem.Text.Equals("Họ tên"))
                    dgvListTK.DataSource = tk.TimKiemTaiKhoanTheoHoTenDanhChoQuanLy(txtTimKiem.Text, this.machht);
                else
                    dgvListTK.DataSource = tk.TimKiemTaiKhoanTheoUsernameDanhChoQuanLy(txtTimKiem.Text, this.machht);
            }
            else
            {
                if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListTK.DataSource = tk.TimKiemTaiKhoan(txtTimKiem.Text);
                else if (cboTimKiem.Text.Equals("Họ tên"))
                    dgvListTK.DataSource = tk.TimKiemTaiKhoanTheoHoTen(txtTimKiem.Text);
                else
                    dgvListTK.DataSource = tk.TimKiemTaiKhoanTheoUsername(txtTimKiem.Text);
            }
            for (int i = 0; i < dgvListTK.RowCount - 1; i++)
            {
                if (dgvListTK.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListTK.Rows[i].Cells["trangthai"].Value = "Còn hoạt động";
                }
                else
                    dgvListTK.Rows[i].Cells["trangthai"].Value = "Không còn hoạt động";
                dgvListTK.Rows[i].Cells["username"].Value = Encryption.Decrypt(dgvListTK.Rows[i].Cells["username"].Value.ToString());
            }
        }
    }
}
