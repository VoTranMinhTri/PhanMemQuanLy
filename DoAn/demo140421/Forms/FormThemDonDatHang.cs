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
    public partial class FormThemDonDatHang : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int mach;
        public FormThemDonDatHang()
        {
            InitializeComponent();
        }
        public FormThemDonDatHang(int mach,int manv):this()
        {
            this.mach = mach;
            BAL_DonHang baldh = new BAL_DonHang();
            txtMaDH.Text = baldh.LayMaDHNew().ToString();
            HienThiDanhSach(dgvListSP,this.mach);
            txtMaDH.Text = baldh.LayMaDHNew().ToString();
            cboTimKiem.SelectedIndex = 0;
            BAL_NhanVien balnv = new BAL_NhanVien();
            txtMaNV.Text = manv.ToString();
        }
        public static void HienThiDanhSach(DataGridView dgv,int mach)
        {
            BAL_SanPham sp = new BAL_SanPham();
            dgv.DataSource = sp.LayDanhSachSPThanhToan(mach);
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
        public DataTable GetDataTable()
        {
            BAL_SanPham balsp = new BAL_SanPham();
            DataTable table = new DataTable();
            table.Columns.Add(new System.Data.DataColumn("MaDH", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSP", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaMau", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSize", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("Gia", typeof(float)));
            table.Columns.Add(new System.Data.DataColumn("SoLuong", typeof(int)));
            DataRow dtrow = null;
            foreach (DataGridViewRow row in dgvCTDDH.Rows)
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

        private void dgvCTDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvCTDDH.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThemSP_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            DataGridViewRow rowsp = dgvListSP.Rows[dongthu];
            int soluongkq = 0;
            int ktsp=0;
            try
            {
                if (int.Parse(txtSoLuong.Text) > 0)
                {
                    soluongkq = int.Parse(rowsp.Cells["soluongpb"].Value.ToString()) - int.Parse(txtSoLuong.Text);
                    if (soluongkq >= 0)
                    {
                        if (dgvCTDDH.RowCount - 1 != 0)
                        {
                            for (int i = 0; i < dgvCTDDH.RowCount - 1; i++)
                            {
                                if (txtMaSP.Text.Equals(dgvCTDDH.Rows[i].Cells["maspct"].Value.ToString()) && rowsp.Cells["tenmau"].Value.ToString().Equals(dgvCTDDH.Rows[i].Cells["tenmauct"].Value.ToString()) && rowsp.Cells["size"].Value.ToString().Equals(dgvCTDDH.Rows[i].Cells["sizect"].Value.ToString()))
                                {
                                    dgvCTDDH.Rows[i].Cells["soluong"].Value = int.Parse(dgvCTDDH.Rows[i].Cells["soluong"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                                    dgvCTDDH.Rows[i].Cells["thanhtien"].Value = int.Parse(dgvCTDDH.Rows[i].Cells["soluong"].Value.ToString()) * float.Parse(dgvCTDDH.Rows[i].Cells["giasp"].Value.ToString());
                                    ktsp = 1;
                                    rowsp.Cells["soluongpb"].Value = soluongkq;
                                    txtTongSL.Text = (dgvCTDDH.Rows.Count - 1).ToString();
                                    txtMaSP.Clear();
                                    txtSoLuong.Clear();
                                }
                            }
                        }
                        if (ktsp == 0)
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvCTDDH.Rows[0].Clone();
                            row.Cells[0].Value = int.Parse(txtMaDH.Text);
                            row.Cells[1].Value = int.Parse(txtMaSP.Text);
                            row.Cells[2].Value = rowsp.Cells["tenmau"].Value.ToString();
                            row.Cells[3].Value = rowsp.Cells["size"].Value.ToString();
                            row.Cells[4].Value = float.Parse(rowsp.Cells["gia"].Value.ToString());
                            row.Cells[5].Value = int.Parse(txtSoLuong.Text);
                            row.Cells[6].Value = float.Parse(rowsp.Cells["gia"].Value.ToString()) * int.Parse(row.Cells[5].Value.ToString());
                            rowsp.Cells["soluongpb"].Value = soluongkq;
                            dgvCTDDH.Rows.Add(row);
                            txtTongSL.Text = (dgvCTDDH.Rows.Count - 1).ToString();
                            txtMaSP.Clear();
                            txtSoLuong.Clear();
                        }
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công! Vui lòng nhập số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Clear();
                    txtSoLuong.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void iconButtonTongTien_Click(object sender, EventArgs e)
        {
            int sc = dgvCTDDH.Rows.Count;
            float thanhtien = 0;
            float chietkhau;
            if (txtChietKhau.Text.Equals(""))
                chietkhau = 0;
            else
                chietkhau = float.Parse(txtChietKhau.Text);
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvCTDDH.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTDDH.Rows[i].Cells[5].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
            float tongtien = thanhtien - (thanhtien * chietkhau);
            txtTongTien.Text = tongtien.ToString();
        }
        private void resetForm()
        {
            BAL_DonHang balhdn = new BAL_DonHang();
            txtMaDH.Text = balhdn.LayMaDHNew().ToString();
            dgvCTDDH.Rows.Clear();
            txtChietKhau.Text = null;
            txtMaKH.Text = null;
            txtTongSL.Text = null;
            txtTongTien.Text = null;
            txtMaSP.Text = null;
            txtTimKiem.Text = null;
            rtbGhiChu.Text = null;
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sp này khỏi đơn hàng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                DataGridViewRow row = dgvCTDDH.Rows[dongthu1];
                for (int i = 0; i < dgvListSP.RowCount - 1; i++)
                {
                    if (dgvListSP.Rows[i].Cells[0].Value.ToString().Equals(dgvCTDDH.Rows[dongthu1].Cells[1].Value.ToString()) && dgvListSP.Rows[i].Cells["tenmau"].Value.ToString().Equals(dgvCTDDH.Rows[dongthu1].Cells["tenmauct"].Value.ToString()) && dgvListSP.Rows[i].Cells["size"].Value.ToString().Equals(dgvCTDDH.Rows[dongthu1].Cells["sizect"].Value.ToString()))
                        dgvListSP.Rows[i].Cells["soluongpb"].Value = int.Parse(dgvListSP.Rows[i].Cells["soluongpb"].Value.ToString()) + int.Parse(dgvCTDDH.Rows[dongthu1].Cells["soluong"].Value.ToString());
                }
                dgvCTDDH.Rows.RemoveAt(dongthu1);
                txtTongSL.Text = (dgvCTDDH.Rows.Count - 1).ToString();
                int sc = dgvCTDDH.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dgvCTDDH.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTDDH.Rows[i].Cells[5].Value.ToString());
                txtTongTien.Text = thanhtien.ToString();
            }
        }

        private void iconButtonThemDonHang_Click(object sender, EventArgs e)
        {
            BAL_DonHang baldh = new BAL_DonHang();
            DataTable table = GetDataTable();
            float chietkhau = 0;
            try
            {

                if (txtChietKhau.Text.ToString() != "")
                    chietkhau = float.Parse(txtChietKhau.Text);
                if (chietkhau >= 0)
                {
                    DonHang dh = new DonHang(int.Parse(txtMaDH.Text), int.Parse(txtMaNV.Text), int.Parse(txtMaKH.Text), dtpNgayDatHang.Value, dtpNgayNhanHang.Value, chietkhau, rtbGhiChu.Text, 1);
                    bool kq = baldh.ThemDonHang(dh, table);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công! Chiết khấu không được nhỏ hơn 0 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          catch(Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
