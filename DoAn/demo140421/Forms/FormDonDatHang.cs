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
    public partial class FormDonDatHang : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int mach;
        int macd;
        int manvht;
        public FormDonDatHang()
        {
            InitializeComponent();
        }
        public FormDonDatHang(int mach,int macd,int manv):this()
        {
            this.macd=macd;
            this.mach = mach;
            this.manvht = manv;
            txtMaNV.Text=manv.ToString();
            if (macd == 1)
                HienThiDanhSachChoNhanVien(dgvListDonHang, mach);
            else
            {
                iconButtonSua.Enabled = false;
                iconButtonThemHoaDon.Enabled = false;
                iconButtonSua.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonThemHoaDon.BackColor = Color.FromArgb(37, 36, 81);
                HienThiDanhSachChoAdmin(dgvListDonHang);
                dtpNgayLapHoaDon.Enabled = false;
                txtMaNV.Enabled = false;
            }
        }
        public static void HienThiDanhSachChoAdmin(DataGridView dgv)
        {
            BAL_DonHang hdb = new BAL_DonHang();
            dgv.DataSource = hdb.LayDanhSachDHChoAdmin();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Chưa giao";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã giao";
            }
        }

        public static void HienThiDanhSachChoNhanVien(DataGridView dgv,int mach)
        {
            BAL_DonHang hdb = new BAL_DonHang();
            dgv.DataSource = hdb.LayDanhSachDHChoNhanVien(mach);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Chưa giao";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã giao";
            }
        }

        public static void HienThiDanhSachCT(DataGridView dgv, int madh)
        {
            BAL_CTDonHang cthdb = new BAL_CTDonHang();
            dgv.DataSource = cthdb.LayDanhSachCTDH(madh);
        }

        public DataTable GetDataTable()
        {
            BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
            BAL_SanPham balsp = new BAL_SanPham();
            DataTable table = new DataTable();
            table.Columns.Add(new System.Data.DataColumn("MaDH", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSP", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaMau", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSize", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("Gia", typeof(float)));
            table.Columns.Add(new System.Data.DataColumn("SoLuong", typeof(int)));
            DataRow dtrow = null;
            foreach (DataGridViewRow row in dgvCTDH.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                dtrow = table.NewRow();
                dtrow[0] = balhdb.LayMaHDBNew();
                dtrow[1] = row.Cells[1].Value;
                dtrow[2] = balsp.LayMaMau(row.Cells[2].Value.ToString());
                dtrow[3] = balsp.LayMaSize(row.Cells[3].Value.ToString());
                dtrow[4] = row.Cells[4].Value;
                dtrow[5] = row.Cells["soluongct"].Value;
                table.Rows.Add(dtrow);
            }
            return table;
        }

        private void dgvListDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListDonHang.Rows[dongthu];
                HienThiDanhSachCT(dgvCTDH, int.Parse(row.Cells["madh"].Value.ToString()));
                int tongsl = dgvCTDH.RowCount - 1;
                txtTongSL.Text = tongsl.ToString();
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_DonHang dh = new BAL_DonHang();
            DataGridViewRow row = dgvListDonHang.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (dh.XoaDonHang(int.Parse(row.Cells["madh"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(this.macd!=3)
                        HienThiDanhSachChoNhanVien(dgvListDonHang, this.mach);
                    else
                        HienThiDanhSachChoAdmin(dgvListDonHang);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListDonHang.Rows[dongthu];
            int madh = int.Parse(row.Cells["madh"].Value.ToString());
            int makh = int.Parse(row.Cells["makh"].Value.ToString());
            DateTime ngaylap = DateTime.Parse(row.Cells["ngaylap"].Value.ToString());
            DateTime ngaynhan = DateTime.Parse(row.Cells["ngaynhan"].Value.ToString());
            float chietKhau = float.Parse(row.Cells["chietkhau"].Value.ToString());
            string ghichu = row.Cells["ghichu"].Value.ToString();
            float tongTien = float.Parse(row.Cells["tongtien"].Value.ToString());
            int manv = int.Parse(row.Cells["manv"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Chưa giao"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaDonHang frm = new FormSuaDonHang(madh, manv, makh, ngaylap, ngaynhan, chietKhau, ghichu, trangthai);
                frm.ShowDialog();
                if (this.macd != 3)
                    HienThiDanhSachChoNhanVien(dgvListDonHang, this.mach);
                else
                    HienThiDanhSachChoAdmin(dgvListDonHang);
            }
        }

        private void iconButtonThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                BAL_DonHang dh = new BAL_DonHang();
                DataGridViewRow row = dgvListDonHang.Rows[dongthu];
                BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
                DataTable table = GetDataTable();
                float chietkhau = 0;
                if (row.Cells["chietkhau"].Value.ToString() != "")
                    chietkhau = float.Parse(row.Cells["chietkhau"].Value.ToString());
                HoaDonBan hdb = new HoaDonBan(balhdb.LayMaHDBNew(), int.Parse(txtMaNV.Text), int.Parse(row.Cells["makh"].Value.ToString()), dtpNgayLapHoaDon.Value, chietkhau, 1);
                bool kq = balhdb.ThemHoaDonBan(hdb, table,1);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dh.XoaDonHang(int.Parse(row.Cells["madh"].Value.ToString()));
                    if (this.macd != 3)
                        HienThiDanhSachChoNhanVien(dgvListDonHang, this.mach);
                    else
                        HienThiDanhSachChoAdmin(dgvListDonHang);
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_DonHang baldh = new BAL_DonHang();
            if(this.macd!=3)
                dgvListDonHang.DataSource = baldh.TimDonHang(txtTimKiem.Text,this.mach, DateTime.Parse(dtpNgayLap.Value.ToString()), DateTime.Parse(dtpNgayNhan.Value.ToString()));
            else
                dgvListDonHang.DataSource = baldh.TimDonHangDanhChoAdmin(txtTimKiem.Text, DateTime.Parse(dtpNgayLap.Value.ToString()), DateTime.Parse(dtpNgayNhan.Value.ToString()));
            for (int i = 0; i < dgvListDonHang.RowCount - 1; i++)
            {
                if (dgvListDonHang.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListDonHang.Rows[i].Cells["trangthai"].Value = "Chưa giao";
                }
                else
                    dgvListDonHang.Rows[i].Cells["trangthai"].Value = "Đã giao";
            }
        }
    }
}
