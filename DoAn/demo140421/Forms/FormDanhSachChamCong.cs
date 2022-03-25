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
    public partial class FormDanhSachChamCong : Form
    {
        int macdht;
        int manvht;
        int dongthu = 0;
        public FormDanhSachChamCong()
        {
            InitializeComponent();
            HienThiDanhSach(dgvListCC);
        }
        public FormDanhSachChamCong(int manv, int macd)
            : this()
        {
            this.manvht = manv;
            this.macdht = macd;
            if (macd == 3)
                HienThiDanhSach(dgvListCC);
            else
            {
                HienThiDanhSachChoQuanLy(dgvListCC, manv);
                iconButtonSua.Enabled = false;
                iconButtonSua.BackColor = Color.FromArgb(37, 36, 81);
            }
            cboTimKiem.SelectedIndex = 0;
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_ChamCong cc = new BAL_ChamCong();
            dgv.DataSource = cc.layDanhSachChamCong();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
            }
        }
        public static void HienThiDanhSachChoQuanLy(DataGridView dgv, int manvql)
        {
            BAL_ChamCong cc = new BAL_ChamCong();
            dgv.DataSource = cc.layDanhSachChamCongChoQuanLy(manvql);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
            }
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_ChamCong cc = new BAL_ChamCong();
            DataGridViewRow row = dgvListCC.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (cc.XoaChamCong(int.Parse(row.Cells["macc"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.macdht == 3)
                        HienThiDanhSach(dgvListCC);
                    else
                        HienThiDanhSachChoQuanLy(dgvListCC, this.manvht);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListCC.Rows[dongthu];
            int macc = int.Parse(row.Cells["macc"].Value.ToString());
            int manv = int.Parse(row.Cells["manv"].Value.ToString());
            int manvcc = int.Parse(row.Cells["manvcc"].Value.ToString());
            DateTime ngaycham = DateTime.Parse(row.Cells["ngaycham"].Value.ToString());
            string tenloai = row.Cells["tenlc"].Value.ToString();
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaChamCong frm = new FormSuaChamCong(macc, ngaycham, manv, manvcc, tenloai, trangthai);
                frm.ShowDialog();
                if (this.macdht == 3)
                    HienThiDanhSach(dgvListCC);
                else
                    HienThiDanhSachChoQuanLy(dgvListCC, this.manvht);
            }
        }

        private void dgvListCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListCC.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_ChamCong balcc = new BAL_ChamCong();
            if (macdht != 3)
            {
                if (cboTimKiem.Text.Equals("Mã CC"))
                    dgvListCC.DataSource = balcc.TimKiemChamCongDanhChoQuanLy(txtTimKiem.Text, this.manvht);
                else if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListCC.DataSource = balcc.TimKiemChamCongTheoMaNVDanhChoQuanLy(txtTimKiem.Text, this.manvht);
                else
                    dgvListCC.DataSource = balcc.TimKiemChamCongTheoNgayDanhChoQuanLy(txtTimKiem.Text, this.manvht);
                for (int i = 0; i < dgvListCC.RowCount - 1; i++)
                {
                    if (dgvListCC.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                    {
                        dgvListCC.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                    }
                    else
                        dgvListCC.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
                }
            }
            else
            {
                if (cboTimKiem.Text.Equals("Mã CC"))
                    dgvListCC.DataSource = balcc.TimKiemChamCong(txtTimKiem.Text);
                else if (cboTimKiem.Text.Equals("Mã NV"))
                    dgvListCC.DataSource = balcc.TimKiemChamCongTheoMaNV(txtTimKiem.Text);
                else
                    dgvListCC.DataSource = balcc.TimKiemChamCongTheoNgay(txtTimKiem.Text);
                for (int i = 0; i < dgvListCC.RowCount - 1; i++)
                {
                    if (dgvListCC.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                    {
                        dgvListCC.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                    }
                    else
                        dgvListCC.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
                }
            }
        }
    }
}
