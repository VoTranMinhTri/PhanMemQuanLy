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
    public partial class FormNhaCungCap : Form
    {
        int dongthu = 0;
        public FormNhaCungCap()
        {
            InitializeComponent();
            HienThiDanhSach(dataGridView1);
            cboTimKiem.SelectedIndex = 0;
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_NhaCungCap nv = new BAL_NhaCungCap();
            dgv.DataSource = nv.LayDanhSachNCC();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn cung cấp";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Không còn cung cấp";
            }
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemNhaCungCap frm = new FormThemNhaCungCap();
            frm.ShowDialog();
            HienThiDanhSach(dataGridView1);
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_NhaCungCap nv = new BAL_NhaCungCap();
            DataGridViewRow row = dataGridView1.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (nv.XoaNhaCungCap(int.Parse(row.Cells["mancc"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dataGridView1);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dongthu];
            int maNCC = int.Parse(row.Cells["mancc"].Value.ToString());
            string ten = row.Cells["tenncc"].Value.ToString();
            string Email = row.Cells["email"].Value.ToString();
            string sDT = row.Cells["sdt"].Value.ToString();
            string diaChi = row.Cells["diachi"].Value.ToString();
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn cung cấp"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaNhaCungCap frm = new FormSuaNhaCungCap(maNCC, ten, diaChi, Email, sDT, trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            if(cboTimKiem.Text.Equals("Mã NCC"))
                dataGridView1.DataSource = balncc.TimNhaCungCap(txtTimKiem.Text);
            else
                dataGridView1.DataSource = balncc.TimNhaCungCapTheoTen(txtTimKiem.Text);
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dataGridView1.Rows[i].Cells["trangthai"].Value = "Còn cung cấp";
                }
                else
                    dataGridView1.Rows[i].Cells["trangthai"].Value = "Không còn cung cấp";
            }
        }

    
    }
}
