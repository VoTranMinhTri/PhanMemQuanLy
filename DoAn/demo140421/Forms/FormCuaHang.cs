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
    public partial class FormCuaHang : Form
    {
        int dongthu = 0;
        int dongthu1 = 0;
        public FormCuaHang()
        {
            InitializeComponent();
            HienThiDanhSach(dgvListCuaHang);
            cboTimKiemCH.SelectedIndex = 0;
            cboTimKiemSPPB.SelectedIndex = 0;
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_CuaHang nv = new BAL_CuaHang();
            dgv.DataSource = nv.LayDanhSachCH();
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
        public static void HienThiDanhSachSPPhanBo(DataGridView dgv,int mach)
        {
            BAL_SPPhanBo sppb = new BAL_SPPhanBo();
            dgv.DataSource = sppb.LayDanhSachSPPhanBo(mach);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthaisppb"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthaisppb"].Value = "Còn hoạt động";
                }
                else
                    dgv.Rows[i].Cells["trangthaisppb"].Value = "Không còn hoạt động";
            }
        }
        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemCuaHang frm = new FormThemCuaHang();
            frm.ShowDialog();
            HienThiDanhSach(dgvListCuaHang);
        }

        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            BAL_CuaHang nv = new BAL_CuaHang();
            DataGridViewRow row = dgvListCuaHang.Rows[dongthu];
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (nv.XoaCuaHang(int.Parse(row.Cells["mach"].Value.ToString())))
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSach(dgvListCuaHang);
                }
                else
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListCuaHang.Rows[dongthu];
            int mach = int.Parse(row.Cells["mach"].Value.ToString());
            string tench = row.Cells["tench"].Value.ToString();
            string diaChi = row.Cells["diachi"].Value.ToString();
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn hoạt động"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaCuaHang frm = new FormSuaCuaHang(mach, tench, diaChi, trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dgvListCuaHang);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_CuaHang balch = new BAL_CuaHang();
            if(cboTimKiemCH.Text.Equals("Mã CH"))
                dgvListCuaHang.DataSource = balch.TimCuaHang(txtTimKiem.Text);
            else
                dgvListCuaHang.DataSource = balch.TimKiemCuaHangTheoTen(txtTimKiem.Text);
            for (int i = 0; i < dgvListCuaHang.RowCount - 1; i++)
            {
                if (dgvListCuaHang.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListCuaHang.Rows[i].Cells["trangthai"].Value = "Còn hoạt động";
                }
                else
                    dgvListCuaHang.Rows[i].Cells["trangthai"].Value = "Không còn hoạt động";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListCuaHang.Rows[dongthu];
                HienThiDanhSachSPPhanBo(dgvListSPPB, int.Parse(row.Cells["mach"].Value.ToString()));
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThemPB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListCuaHang.Rows[dongthu];
            FormThemSPPhanBo frm = new FormThemSPPhanBo();
            frm.ShowDialog();
            HienThiDanhSachSPPhanBo(dgvListSPPB, int.Parse(row.Cells["mach"].Value.ToString()));
        }

        private void iconButtonSuaPB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = dgvListCuaHang.Rows[dongthu];
            DataGridViewRow row = dgvListSPPB.Rows[dongthu];
            BAL_SanPham balsp = new BAL_SanPham();
            BAL_CuaHang balch=new BAL_CuaHang();
            int trangthai = 0;
            if (row.Cells["trangthaisppb"].Value.ToString().Equals("Còn hoạt động"))
                trangthai = 1;
            string tench=balch.LayTenTuMaCH(int.Parse(row.Cells["machpb"].Value.ToString()));
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaSPPhanBo frm = new FormSuaSPPhanBo(int.Parse(row.Cells["masp"].Value.ToString()), row.Cells["tenmau"].Value.ToString(), row.Cells["tensize"].Value.ToString(), tench, int.Parse(row.Cells["soluong"].Value.ToString()), trangthai);
                frm.ShowDialog();
                HienThiDanhSachSPPhanBo(dgvListSPPB, int.Parse(row1.Cells["mach"].Value.ToString()));
            }
        }

        private void iconPictureBoxSearchSPPB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = dgvListCuaHang.Rows[dongthu];
            BAL_SPPhanBo balsppb = new BAL_SPPhanBo();
            if (cboTimKiemSPPB.Text.Equals("Mã SP"))
                dgvListSPPB.DataSource = balsppb.TimKiemSPPB(txtTimKiemSPPB.Text, int.Parse(row1.Cells["mach"].Value.ToString()));
            else
                dgvListSPPB.DataSource = balsppb.TimKiemSPPBTheoTen(txtTimKiemSPPB.Text, int.Parse(row1.Cells["mach"].Value.ToString()));
            for (int i = 0; i < dgvListSPPB.RowCount - 1; i++)
            {
                if (dgvListSPPB.Rows[i].Cells["trangthaisppb"].Value.ToString().Equals("1"))
                {
                    dgvListSPPB.Rows[i].Cells["trangthaisppb"].Value = "Còn hoạt động";
                }
                else
                    dgvListSPPB.Rows[i].Cells["trangthaisppb"].Value = "Không còn hoạt động";
            }
        }

        private void iconButtonXoaSPPB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row1 = dgvListCuaHang.Rows[dongthu];
            BAL_SPPhanBo sppb = new BAL_SPPhanBo();
            DataGridViewRow row = dgvListSPPB.Rows[dongthu1];
            BAL_SanPham sp = new BAL_SanPham();
            try
            {
                int mamau = sp.LayMaMau(row.Cells["tenmau"].Value.ToString());
                int masize = sp.LayMaSize(row.Cells["tensize"].Value.ToString());
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (kq == DialogResult.Yes)
                {
                    if (sppb.XoaSanPhamPhanBo(int.Parse(row.Cells["masp"].Value.ToString()), mamau, masize, int.Parse(row.Cells["machpb"].Value.ToString())))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiDanhSachSPPhanBo(dgvListSPPB, int.Parse(row1.Cells["mach"].Value.ToString()));
                    }
                    else
                        MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListSPPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu1 = e.RowIndex;
                DataGridViewRow row = dgvListSPPB.Rows[dongthu1];
            }
            catch (Exception err)
            {
            }
        }
    }
}
