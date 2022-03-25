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
    public partial class FormLuong : Form
    {
        int dongthu = 0;
        public FormLuong()
        {
            InitializeComponent();
            BAL_Luong balluong=new BAL_Luong();
            cboTimKiem.SelectedIndex = 0;
            HienThiDanhSach(dgvListLuong);
            for(int i=0;i<dgvListLuong.RowCount-1;i++)
            {
                //Truong hop tinh luong cho thang 1 va cap nhat lai thang 11
                if (System.DateTime.Now.Month == 1 && int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()) == 11 && int.Parse(dgvListLuong.Rows[i].Cells["nam"].Value.ToString()) == System.DateTime.Now.Year -1)
                    balluong.CapNhatLaiTrangThaiLuong(int.Parse(dgvListLuong.Rows[i].Cells["manv"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["nam"].Value.ToString()));
                //Truong hop tinh luong cho thang 2 va cap nhat lai thang 12
                else if (System.DateTime.Now.Month == 2 && int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()) == 12 && int.Parse(dgvListLuong.Rows[i].Cells["nam"].Value.ToString()) == System.DateTime.Now.Year - 1)
                    balluong.CapNhatLaiTrangThaiLuong(int.Parse(dgvListLuong.Rows[i].Cells["manv"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["nam"].Value.ToString()));
                //Truong hop con lai
                else if (System.DateTime.Now.Month-2 == int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()))
                    balluong.CapNhatLaiTrangThaiLuong(int.Parse(dgvListLuong.Rows[i].Cells["manv"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["thang"].Value.ToString()), int.Parse(dgvListLuong.Rows[i].Cells["nam"].Value.ToString()));
            }
            HienThiDanhSach(dgvListLuong);
        }

        public static void HienThiDanhSach(DataGridView dgv)
        {
            BAL_Luong luong = new BAL_Luong();
            dgv.DataSource = luong.LayDanhSachLuong();
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

        private void dgvListLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dgvListLuong.Rows[dongthu];
            }
            catch (Exception err)
            {
            }
        }

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            FormThemLuong frm = new FormThemLuong();
            frm.ShowDialog();
            HienThiDanhSach(dgvListLuong);
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListLuong.Rows[dongthu];
            int manv = int.Parse(row.Cells["manv"].Value.ToString());
            int thang = int.Parse(row.Cells["thang"].Value.ToString());
            int nam = int.Parse(row.Cells["nam"].Value.ToString());
            float luong = float.Parse(row.Cells["luong"].Value.ToString());
            int trangthai = 0;
            if (row.Cells["trangthai"].Value.ToString().Equals("Còn sử dụng"))
                trangthai = 1;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa dòng dữ liệu này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                FormSuaLuong frm = new FormSuaLuong(manv, thang, nam, luong, trangthai);
                frm.ShowDialog();
                HienThiDanhSach(dgvListLuong);
            }
        }

        private void iconPictureBoxSearch_Click(object sender, EventArgs e)
        {
            BAL_Luong balluong = new BAL_Luong();
            if(cboTimKiem.Text.Equals("Mã NV"))
                dgvListLuong.DataSource = balluong.TimKiemLuongCuaNV(txtTimKiem.Text);
            else if(cboTimKiem.Text.Equals("Tháng"))
                dgvListLuong.DataSource = balluong.TimKiemLuongCuaNVTheoThang(txtTimKiem.Text);
            else
                dgvListLuong.DataSource = balluong.TimKiemLuongCuaNVTheoNam(txtTimKiem.Text);
            for (int i = 0; i < dgvListLuong.RowCount - 1; i++)
            {
                if (dgvListLuong.Rows[i].Cells["trangthai"].Value.ToString().Equals("1"))
                {
                    dgvListLuong.Rows[i].Cells["trangthai"].Value = "Còn sử dụng";
                }
                else
                    dgvListLuong.Rows[i].Cells["trangthai"].Value = "Không còn sử dụng";
            }
        }

    }
}
