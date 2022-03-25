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
    public partial class FormHoaDonNhap : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int mach;
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }
        public FormHoaDonNhap(int macd,int mach):this()
        {
            this.mach = mach;
            if(macd!=3)
            {
                iconButtonSua.Enabled = false;
                iconButtonThem.Enabled = false;
                iconButtonXoa.Enabled = false;
                iconButtonXoa.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonSua.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonThem.BackColor = Color.FromArgb(37, 36, 81);
            }
            HienThiDanhSach(dataGridView2);
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_HoaDonNhap hdb = new BAL_HoaDonNhap();
            dgv.DataSource = hdb.LayDanhSachHDN();
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
        public static void HienThiDanhSachCT(DataGridView dgv, int mahd)
        {
            BAL_CTHoaDonNhap cthdb = new BAL_CTHoaDonNhap();
            dgv.DataSource = cthdb.LayDanhSachCTHDN(mahd);
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemHoaDonNhap frm = new FormThemHoaDonNhap(this.mach);
            frm.ShowDialog();
            HienThiDanhSach(dataGridView2);
        }
        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_HoaDonNhap hdb = new BAL_HoaDonNhap();
            DataGridViewRow row = dataGridView2.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (hdb.XoaHoaDonNhap(int.Parse(row.Cells["mahdn"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dataGridView2);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[dongthu];
            int maHDN = int.Parse(row.Cells["mahdn"].Value.ToString());
            string tenncc =row.Cells["tenncc"].Value.ToString();
            DateTime ngayLap = DateTime.Parse(row.Cells["ngaylap"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaHoaDonNhap frm = new FormSuaHoaDonNhap(maHDN, ngayLap, tenncc, trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dataGridView2);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[dongthu];
                HienThiDanhSachCT(dataGridView3, int.Parse(row.Cells["mahdn"].Value.ToString()));
                int tongsl = dataGridView3.RowCount - 1;
                if (tongsl < 0)
                    tongsl = 0;
                txtTongSL.Text = tongsl.ToString();
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_HoaDonNhap balhdn = new BAL_HoaDonNhap();
            dataGridView2.DataSource = balhdn.TimHoaDonNhap(txtTimKiem.Text, DateTime.Parse(dtpNgayLap.Value.ToString()));
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dataGridView2.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                }
                else
                    dataGridView2.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
            }
        }
    }
}
