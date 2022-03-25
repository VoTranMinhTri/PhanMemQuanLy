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
    public partial class FormChamCong : Form
    {
        int dongthu = 0;
        public FormChamCong()
        {
            InitializeComponent();
          
        }
        public FormChamCong(int manvql,int macd):this()
        {
            if (macd == 3)
                HienThiDanhSachChamChoAdmin(dgvListNV);
            else
                HienThiDanhSachChamChoQuanLy(dgvListNV,manvql);
            BAL_ChamCong balcc = new BAL_ChamCong();
            cboLoaiCham.DataSource = balcc.layDanhSachLoaiChamCong();
            cboLoaiCham.ValueMember = "TenLC";
            txtMaCC.Text = balcc.LayMaCCNew().ToString();
            cboTimKiem.SelectedIndex = 0;
            dtpNgayCham.Value = System.DateTime.Now;
            txtMaNVCC.Text = manvql.ToString();
        }
        public static void HienThiDanhSachChamChoAdmin(DataGridView dgv)
        {
            BAL_NhanVien nv = new BAL_NhanVien();
            dgv.DataSource = nv.LayDanhSachNV();
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }
        public static void HienThiDanhSachChamChoQuanLy(DataGridView dgv,int manvql)
        {
            BAL_NhanVien nv = new BAL_NhanVien();
            dgv.DataSource = nv.LayDanhSachNVChamCong(manvql);
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgv.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgv.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }

        private void iconButtonChamCong_Click(object sender, EventArgs e)
        {
            BAL_ChamCong balcc = new BAL_ChamCong();
            try
            {
                if (balcc.KiemTraNgayNghiCoPhep(int.Parse(txtMaNV.Text))==true)
                {
                    int maloai = balcc.LayMaLoaiChamCong(cboLoaiCham.Text);
                    ChamCong cc = new ChamCong(int.Parse(txtMaCC.Text), dtpNgayCham.Value, int.Parse(txtMaNV.Text), int.Parse(txtMaNVCC.Text), maloai, 1);
                    bool kq = balcc.ThemChamCong(cc);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetForm();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công! Ngày nghỉ có phép của nhân viên đã vượt quá quy định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void resetForm()
        {
            BAL_ChamCong balcc = new BAL_ChamCong();
            txtMaCC.Text = balcc.LayMaCCNew().ToString();
            txtMaNV.Text = null;
            txtMaNVCC.Text = null;
        }
        private void dgvListNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListNV.Rows[dongthu];
                txtMaNV.Text = row.Cells["manv"].Value.ToString();
            }
            catch (Exception err)
            {
            }

        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_NhanVien balnv = new BAL_NhanVien();
            if(cboTimKiem.Text.Equals("Mã NV"))
                dgvListNV.DataSource = balnv.TimKiemNhanVien(txtTimKiem.Text);
            else
                dgvListNV.DataSource = balnv.TimKiemNhanVienTheoTen(txtTimKiem.Text);
            for (int i = 0; i < dgvListNV.RowCount - 1; i++)
            {
                if (dgvListNV.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListNV.Rows[i].Cells["trangthai"].Value = "Còn làm";
                }
                else
                    dgvListNV.Rows[i].Cells["trangthai"].Value = "Đã nghỉ";
            }
        }
    }
}
