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
    public partial class FormHoaDonBan : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int macd;
        int mach;
        public FormHoaDonBan()
        {
            InitializeComponent();
        }
        public FormHoaDonBan(int macd,int mach):this()
        {
            this.macd = macd;
            this.mach = mach;
            if (macd != 3)
            {
                iconButtonXoa.Enabled = false;
                iconButtonSua.Enabled = false;
                iconButtonSua.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonXoa.BackColor = Color.FromArgb(37, 36, 81);
                HienThiDanhSachDanhChoQuanLy(dgvHoaDon, mach);
            }
            else
                HienThiDanhSach(dgvHoaDon);
        }
        public static void HienThiDanhSachDanhChoQuanLy(DataGridView dgv,int mach)
        {
            BAL_HoaDonBan hdb = new BAL_HoaDonBan();
            dgv.DataSource = hdb.LayDanhSachHDBDanhChoQuanLy(mach);
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
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_HoaDonBan hdb = new BAL_HoaDonBan();
            dgv.DataSource = hdb.LayDanhSachHDB();
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
        public static void HienThiDanhSachCT(DataGridView dgv,int mahd)
        {
            BAL_CTHoaDonBan cthdb = new BAL_CTHoaDonBan();
            dgv.DataSource = cthdb.LayDanhSachCTHDB(mahd);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvHoaDon.Rows[dongthu];
                HienThiDanhSachCT(dgvCTHoaDon, int.Parse(row.Cells["mahdb"].Value.ToString()));
                int tongsl=dgvCTHoaDon.RowCount-1;
                txtTongSL.Text = tongsl.ToString();
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_HoaDonBan hdb = new BAL_HoaDonBan();
            DataGridViewRow row = dgvHoaDon.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (hdb.XoaHoaDonBan(int.Parse(row.Cells["mahdb"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (macd != 3)
                    {
                        HienThiDanhSachDanhChoQuanLy(dgvCTHoaDon, mach);
                    }
                    else
                        HienThiDanhSach(dgvHoaDon);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHoaDon.Rows[dongthu];
            int maHDB = int.Parse(row.Cells["mahdb"].Value.ToString());
            int maNV = int.Parse(row.Cells["manv"].Value.ToString());
            int maKH = int.Parse(row.Cells["makh"].Value.ToString());
            DateTime ngayLap = DateTime.Parse(row.Cells["ngaylap"].Value.ToString());
            float chietKhau = float.Parse(row.Cells["chietkhau"].Value.ToString());
            float tongTien = float.Parse(row.Cells["tongtien"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaHoaDonBan frm = new FormSuaHoaDonBan(maHDB, maNV, maKH, ngayLap, chietKhau, trangthai);
                frm.ShowDialog();
                if (macd != 3)
                {
                    HienThiDanhSachDanhChoQuanLy(dgvCTHoaDon, mach);
                }
                else
                    HienThiDanhSach(dgvHoaDon);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
            if(this.macd!=3)
                dgvHoaDon.DataSource = balhdb.TimKiemHoaDonBanDanhChoQuanLy(txtTimKiem.Text, this.mach, DateTime.Parse(dtpNgayLap.Value.ToString()));
            else
                dgvHoaDon.DataSource = balhdb.TimHoaDonBan(txtTimKiem.Text,DateTime.Parse(dtpNgayLap.Value.ToString()));
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
            {
                if (dgvHoaDon.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvHoaDon.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                }
                else
                    dgvHoaDon.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
            }
        }
    }
}
