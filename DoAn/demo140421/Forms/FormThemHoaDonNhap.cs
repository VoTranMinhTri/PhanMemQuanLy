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
    public partial class FormThemHoaDonNhap : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int mach;
        public FormThemHoaDonNhap()
        {
            InitializeComponent();
        }
        public FormThemHoaDonNhap(int mach):this()
        {
            this.mach = mach;
            BAL_HoaDonNhap balhdn = new BAL_HoaDonNhap();
            txtMaHD.Text = balhdn.LayMaHDNNew().ToString();
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            cbTenNCC.DataSource = balncc.LayDanhSachTenNCC();
            cbTenNCC.ValueMember = "TenNCC";
            cboTimKiem.SelectedIndex = 0;
            HienThiDanhSach(dgvListSP);
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_SanPham sp = new BAL_SanPham();
            dgv.DataSource = sp.LayDanhSachSPChoHoaDonNhap();
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
        private void dgvListSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListSP.Rows[dongthu];
                txtMaSP.Text = row.Cells["masp"].Value.ToString();
            }
            catch (Exception err)
            {
            }
        }
        public DataTable GetDataTable()
        {
            BAL_SanPham balsp = new BAL_SanPham();
            DataTable table = new DataTable();
            table.Columns.Add(new System.Data.DataColumn("MAHD", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSP", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaMau", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSize", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("Gia", typeof(float)));
            table.Columns.Add(new System.Data.DataColumn("SoLuong", typeof(int)));
            DataRow dtrow = null;
            foreach (DataGridViewRow row in dgvCTHDN.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                dtrow = table.NewRow();
                dtrow[0] = row.Cells[0].Value;
                dtrow[1] = row.Cells[1].Value;
                dtrow[2] = balsp.LayMaMau(row.Cells[2].Value.ToString());
                dtrow[3] = balsp.LayMaSize(row.Cells[3].Value.ToString());
                dtrow[4] = row.Cells[4].Value;
                dtrow[5] = row.Cells[5].Value;
                table.Rows.Add(dtrow);
            }
            return table;
        }
        private void iconButtonThemHDN_Click(object sender, EventArgs e)
        {
            BAL_HoaDonNhap balhdn = new BAL_HoaDonNhap();
            BAL_NhaCungCap balncc = new BAL_NhaCungCap();
            DataTable table = GetDataTable();
            int mancc = balncc.LayMaNCC(cbTenNCC.Text);
            HoaDonNhap hdn = new HoaDonNhap(int.Parse(txtMaHD.Text), dtpNgayLap.Value, mancc, 1);
            bool kq = balhdn.ThemHoaDonNhap(hdn, table);
            if (kq == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            DialogResult kq;
            DataGridViewRow rowsp = dgvListSP.Rows[dongthu];
            int ktsp = 0;
            try
            {
                if (balsp.KiemTraMaSP(int.Parse(txtMaSP.Text)) == true)
                {
                    if (dgvCTHDN.RowCount - 1 != 0)
                    {
                        for (int i = 0; i < dgvCTHDN.RowCount - 1; i++)
                        {
                            if (txtMaSP.Text.Equals(dgvCTHDN.Rows[i].Cells["maspct"].Value.ToString()) && rowsp.Cells["tenmau"].Value.ToString().Equals(dgvCTHDN.Rows[i].Cells["tenmauct"].Value.ToString()) && rowsp.Cells["size"].Value.ToString().Equals(dgvCTHDN.Rows[i].Cells["sizect"].Value.ToString()))
                            {
                                if (float.Parse(dgvCTHDN.Rows[i].Cells["giasp"].Value.ToString()) == float.Parse(txtGiaNhap.Text))
                                {
                                    dgvCTHDN.Rows[i].Cells["soluong"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                                    dgvCTHDN.Rows[i].Cells["thanhtien"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) * float.Parse(dgvCTHDN.Rows[i].Cells["giasp"].Value.ToString());
                                    ktsp = 1;
                                    txtMaSP.Clear();
                                    txtSoLuong.Clear();
                                    txtGiaNhap.Clear();
                                    int sc = dgvCTHDN.Rows.Count;
                                    float thanhtien = 0;
                                    for (int j = 0; j < sc - 1; j++)
                                        thanhtien += float.Parse(dgvCTHDN.Rows[j].Cells[4].Value.ToString()) * float.Parse(dgvCTHDN.Rows[j].Cells[5].Value.ToString());
                                    txtTongTien.Text = thanhtien.ToString();
                                    txtTongSL.Text = (dgvCTHDN.Rows.Count - 1).ToString();
                                }
                                else
                                {
                                    kq = MessageBox.Show("Giá bị thay đổi? Bạn có muốn thay đổi giá mới cho sản phẩm nhập vào?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (kq == DialogResult.Yes)
                                    {
                                        dgvCTHDN.Rows[i].Cells["soluong"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                                        dgvCTHDN.Rows[i].Cells["giasp"].Value = float.Parse(txtGiaNhap.Text);
                                        dgvCTHDN.Rows[i].Cells["thanhtien"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) * float.Parse(txtGiaNhap.Text);
                                        ktsp = 1;
                                        txtMaSP.Clear();
                                        txtSoLuong.Clear();
                                        txtGiaNhap.Clear();
                                        int sc = dgvCTHDN.Rows.Count;
                                        float thanhtien = 0;
                                        for (int j = 0; j < sc - 1; j++)
                                            thanhtien += float.Parse(dgvCTHDN.Rows[j].Cells[4].Value.ToString()) * float.Parse(dgvCTHDN.Rows[j].Cells[5].Value.ToString());
                                        txtTongTien.Text = thanhtien.ToString();
                                        txtTongSL.Text = (dgvCTHDN.Rows.Count - 1).ToString();
                                    }
                                    else
                                    {
                                        dgvCTHDN.Rows[i].Cells["soluong"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                                        dgvCTHDN.Rows[i].Cells["thanhtien"].Value = int.Parse(dgvCTHDN.Rows[i].Cells["soluong"].Value.ToString()) * float.Parse(dgvCTHDN.Rows[i].Cells["giasp"].Value.ToString());
                                        ktsp = 1;
                                        txtMaSP.Clear();
                                        txtSoLuong.Clear();
                                        txtGiaNhap.Clear();
                                        int sc = dgvCTHDN.Rows.Count;
                                        float thanhtien = 0;
                                        for (int j = 0; j < sc - 1; j++)
                                            thanhtien += float.Parse(dgvCTHDN.Rows[j].Cells[4].Value.ToString()) * float.Parse(dgvCTHDN.Rows[j].Cells[5].Value.ToString());
                                        txtTongTien.Text = thanhtien.ToString();
                                        txtTongSL.Text = (dgvCTHDN.Rows.Count - 1).ToString();
                                    }
                                }
                            }
                        }
                    }
                    if (ktsp == 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)dgvCTHDN.Rows[0].Clone();
                        row.Cells[0].Value = int.Parse(txtMaHD.Text);
                        row.Cells[1].Value = int.Parse(txtMaSP.Text);
                        row.Cells[2].Value = rowsp.Cells["tenmau"].Value.ToString();
                        row.Cells[3].Value = rowsp.Cells["size"].Value.ToString();
                        row.Cells[4].Value = float.Parse(txtGiaNhap.Text);
                        row.Cells[5].Value = int.Parse(txtSoLuong.Text);
                        row.Cells[6].Value = float.Parse(txtGiaNhap.Text) * int.Parse(row.Cells[5].Value.ToString());
                        dgvCTHDN.Rows.Add(row);
                        txtTongSL.Text = (dgvCTHDN.Rows.Count - 1).ToString();
                        int sc = dgvCTHDN.Rows.Count;
                        float thanhtien = 0;
                        for (int i = 0; i < sc - 1; i++)
                            thanhtien += float.Parse(dgvCTHDN.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTHDN.Rows[i].Cells[5].Value.ToString());
                        txtTongTien.Text = thanhtien.ToString();
                        txtMaSP.Clear();
                        txtSoLuong.Clear();
                        txtGiaNhap.Clear();
                    }
                }
                else
                    MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           catch(Exception err)
            {
                MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvCTHDN.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sp này khỏi chi tiết hóa đơn nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(kq==DialogResult.Yes)
            {
                DataGridViewRow row = dgvCTHDN.Rows[dongthu1];
                dgvCTHDN.Rows.RemoveAt(dongthu1);
                txtTongSL.Text = (dgvCTHDN.Rows.Count - 1).ToString();
                int sc = dgvCTHDN.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dgvCTHDN.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTHDN.Rows[i].Cells[5].Value.ToString());
                txtTongTien.Text = thanhtien.ToString();
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            if (cboTimKiem.Text.Equals("Mã SP"))
                dgvListSP.DataSource = balsp.TimKiemSanPhamChoThanhToan(txtTimKiem.Text, this.mach);
            else
                dgvListSP.DataSource = balsp.TimKiemSanPhamChoThanhToanTheoTen(txtTimKiem.Text, this.mach);
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
    }
}
