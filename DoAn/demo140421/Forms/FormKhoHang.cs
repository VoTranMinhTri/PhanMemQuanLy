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
    public partial class FormKhoHang : Form
    {
        int dongthu = 0;
        public FormKhoHang()
        {
            InitializeComponent();
        }
        public FormKhoHang(int macd):this()
        {
            HienThiDanhSach(dgvListKho);
            cboTimKiem.SelectedIndex = 0;
            if (macd != 3)
                iconButtonSuaCT.Enabled = false;
        }
        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_KhoHang kho = new BAL_KhoHang();
            dgv.DataSource = kho.LayDanhSachKhoHang();
        }

        private void dgvListKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListKho.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_KhoHang balkho = new BAL_KhoHang();
            if(cboTimKiem.Text.Equals("Mã SP"))
                dgvListKho.DataSource = balkho.TimKiemKho(txtTimKiem.Text);
            else
                dgvListKho.DataSource = balkho.TimKiemKhoTheoTenSP(txtTimKiem.Text);
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListKho.Rows[dongthu];
            BAL_SanPham balsp=new BAL_SanPham();
            int mamau=balsp.LayMaMau(row.Cells["tenmau"].Value.ToString());
            int masize = balsp.LayMaSize(row.Cells["tensize"].Value.ToString());
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaKhoHang frm = new FormSuaKhoHang(int.Parse(row.Cells["masp"].Value.ToString()),mamau , masize, int.Parse(row.Cells["soluong"].Value.ToString()));
                frm.ShowDialog();
                HienThiDanhSach(dgvListKho);
            }
        }
    }
}
