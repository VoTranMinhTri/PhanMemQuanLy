using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BAL;
using BEL;
using Microsoft.Reporting.WinForms;
namespace demo140421.Forms
{
    public partial class FormThanhToan : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        int mach;
        public FormThanhToan()
        {
            InitializeComponent();
        }
        public FormThanhToan(int mach,int manv):this()
        {
            this.mach = mach;
            BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
            BAL_NhanVien balnv=new BAL_NhanVien();
            txtMaHD.Text = balhdb.LayMaHDBNew().ToString();
            HienThiDanhSach(dgvListSP,this.mach);
            cboTimKiem.SelectedIndex = 0;
            txtMaNV.Text = manv.ToString();
            dtpNgayLap.Value = System.DateTime.Now;
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
            table.Columns.Add(new System.Data.DataColumn("MAHD", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSP", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaMau", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("MaSize", typeof(int)));
            table.Columns.Add(new System.Data.DataColumn("Gia", typeof(float)));
            table.Columns.Add(new System.Data.DataColumn("SoLuong", typeof(int)));
            DataRow dtrow = null;
            foreach (DataGridViewRow row in dgvCTHDB.Rows)
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


        private void iconButtonThanhToan_Click(object sender, EventArgs e)
        {
            BAL_HoaDonBan balhdb = new BAL_HoaDonBan();
            DataTable table = GetDataTable();
            try
            {
                float chietkhau = 0;
                if (txtChietKhau.Text.ToString() != "")
                    chietkhau = float.Parse(txtChietKhau.Text);
                if (chietkhau >= 0)
                { 
                    HoaDonBan hdb = new HoaDonBan(int.Parse(txtMaHD.Text), int.Parse(txtMaNV.Text), int.Parse(txtMaKH.Text), dtpNgayLap.Value, chietkhau, 1);
                    bool kq = balhdb.ThemHoaDonBan(hdb, table, mach);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHoaDonThanhToan frm = new FormHoaDonThanhToan(int.Parse(txtMaHD.Text));
                        frm.ShowDialog();
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

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sp này khỏi chi tiết hóa đơn nhập ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                DataGridViewRow row = dgvCTHDB.Rows[dongthu1];
                for (int i = 0; i < dgvListSP.RowCount-1; i++)
                {
                    if (dgvListSP.Rows[i].Cells[0].Value.ToString().Equals(dgvCTHDB.Rows[dongthu1].Cells[1].Value.ToString()) && dgvListSP.Rows[i].Cells["tenmau"].Value.ToString().Equals(dgvCTHDB.Rows[dongthu1].Cells["tenmauct"].Value.ToString()) && dgvListSP.Rows[i].Cells["size"].Value.ToString().Equals(dgvCTHDB.Rows[dongthu1].Cells["sizect"].Value.ToString()))
                        dgvListSP.Rows[i].Cells["soluongpb"].Value = int.Parse(dgvListSP.Rows[i].Cells["soluongpb"].Value.ToString()) + int.Parse(dgvCTHDB.Rows[dongthu1].Cells["soluong"].Value.ToString());
                }
                dgvCTHDB.Rows.RemoveAt(dongthu1);
                txtTongSL.Text = (dgvCTHDB.Rows.Count - 1).ToString();
                int sc = dgvCTHDB.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dgvCTHDB.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTHDB.Rows[i].Cells[5].Value.ToString());
                txtTongTien.Text = thanhtien.ToString();
               
            }
        }

        private void dgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvCTHDB.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            if (cboTimKiem.Text.Equals("Mã SP"))
                dgvListSP.DataSource = balsp.TimKiemSanPhamChoThanhToan(txtTimKiem.Text,this.mach);
            else
                dgvListSP.DataSource = balsp.TimKiemSanPhamChoThanhToanTheoTen(txtTimKiem.Text,this.mach);
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

        private void iconButtonThemSP_Click(object sender, EventArgs e)
        {
            BAL_SanPham balsp = new BAL_SanPham();
            DataGridViewRow rowsp = dgvListSP.Rows[dongthu];
            int soluongkq=0;
            int ktsp=0;
            try
            {
                if (int.Parse(txtSoLuong.Text) > 0)
                {
                    soluongkq = int.Parse(rowsp.Cells["soluongpb"].Value.ToString()) - int.Parse(txtSoLuong.Text);
                    if (soluongkq >= 0)
                    {
                        if (dgvCTHDB.RowCount - 1 != 0)
                        {
                            for (int i = 0; i < dgvCTHDB.RowCount - 1; i++)
                            {
                                if (txtMaSP.Text.Equals(dgvCTHDB.Rows[i].Cells["maspct"].Value.ToString()) && rowsp.Cells["tenmau"].Value.ToString().Equals(dgvCTHDB.Rows[i].Cells["tenmauct"].Value.ToString()) && rowsp.Cells["size"].Value.ToString().Equals(dgvCTHDB.Rows[i].Cells["sizect"].Value.ToString()))
                                {
                                    dgvCTHDB.Rows[i].Cells["soluong"].Value = int.Parse(dgvCTHDB.Rows[i].Cells["soluong"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                                    dgvCTHDB.Rows[i].Cells["thanhtien"].Value = int.Parse(dgvCTHDB.Rows[i].Cells["soluong"].Value.ToString()) * float.Parse(dgvCTHDB.Rows[i].Cells["giasp"].Value.ToString());
                                    rowsp.Cells["soluongpb"].Value = soluongkq;
                                    txtTongSL.Text = (dgvCTHDB.Rows.Count - 1).ToString();
                                    txtMaSP.Clear();
                                    txtSoLuong.Clear();
                                    ktsp = 1;
                                }
                            }
                        }
                        if (ktsp == 0)
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvCTHDB.Rows[0].Clone();
                            row.Cells[0].Value = int.Parse(txtMaHD.Text);
                            row.Cells[1].Value = int.Parse(txtMaSP.Text);
                            row.Cells[2].Value = rowsp.Cells["tenmau"].Value.ToString();
                            row.Cells[3].Value = rowsp.Cells["size"].Value.ToString();
                            row.Cells[4].Value = rowsp.Cells["gia"].Value.ToString();
                            row.Cells[5].Value = int.Parse(txtSoLuong.Text);
                            row.Cells[6].Value = float.Parse(rowsp.Cells["gia"].Value.ToString()) * int.Parse(row.Cells[5].Value.ToString());
                            rowsp.Cells["soluongpb"].Value = soluongkq;
                            dgvCTHDB.Rows.Add(row);
                            txtTongSL.Text = (dgvCTHDB.Rows.Count - 1).ToString();
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
            catch(Exception err)
            {
                MessageBox.Show("Thêm sản phẩm vào chi tiết hóa đơn nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonTongTien_Click(object sender, EventArgs e)
        {
            int sc = dgvCTHDB.Rows.Count;
            float thanhtien = 0;
            float chietkhau;
            if (txtChietKhau.Text.Equals(""))
                chietkhau = 0;
            else
                chietkhau = float.Parse(txtChietKhau.Text);
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvCTHDB.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvCTHDB.Rows[i].Cells[5].Value.ToString());
            txtTongTien.Text = thanhtien.ToString();
            float tongtien = thanhtien - (thanhtien * chietkhau);
            txtTongTien.Text = tongtien.ToString();
        }
        private void resetForm()
        {
            BAL_HoaDonBan balhdn = new BAL_HoaDonBan();
            txtMaHD.Text = balhdn.LayMaHDBNew().ToString();
            dgvCTHDB.Rows.Clear();
            txtChietKhau.Text = null;
            txtMaKH.Text = null;
            txtTongSL.Text = null;
            txtTongTien.Text = null;
        }

    }
}
