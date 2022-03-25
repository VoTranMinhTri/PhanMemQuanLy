using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
namespace demo140421.Forms
{
    public partial class FormSuaNhaCungCap : Form
    {
        private int mancccu;
        public FormSuaNhaCungCap()
        {
            InitializeComponent();
        }
        public FormSuaNhaCungCap(int mancc, string tenncc, string diachi, string email, string sdt, int trangthai) :this()
        {
            this.mancccu = mancc;
            txtMaNhaCungCap.Text = mancc.ToString();
            txtDiaChi.Text = diachi;
            txtEmail.Text = email;
            txtSDT.Text = sdt;
            txtTen.Text = tenncc;
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }

        private void iconButtonSuaNCC_Click(object sender, EventArgs e)
        {
            BAL_NhaCungCap balkh = new BAL_NhaCungCap();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                NhaCungCap kh = new NhaCungCap(int.Parse(txtMaNhaCungCap.Text), txtTen.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text, trangthai);
                bool kq = balkh.SuaNhaCungCap(kh, this.mancccu);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
