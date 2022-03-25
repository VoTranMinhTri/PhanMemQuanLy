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
    public partial class FormSuaChamCong : Form
    {
        int macccu;
        int malccu;
        public FormSuaChamCong()
        {
            InitializeComponent();
            BAL_ChamCong balcc = new BAL_ChamCong();
            cboLoaiCham.DataSource = balcc.layDanhSachLoaiChamCong();
            cboLoaiCham.ValueMember = "TenLC";
        }
        public FormSuaChamCong(int macc,DateTime ngaycham,int manv,int manvcc,string tenlc,int trangthai):this()
        {
            BAL_ChamCong balcc = new BAL_ChamCong();
            this.macccu = macc;
            this.malccu = balcc.LayMaLoaiChamCong(tenlc);
            txtMaCC.Text = macc.ToString();
            dtpNgayCham.Value = ngaycham;
            txtMaNV.Text = manv.ToString();
            txtMaNV_CC.Text = manvcc.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
            cboLoaiCham.Text = tenlc;
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_ChamCong balcc = new BAL_ChamCong();
            int maloai = balcc.LayMaLoaiChamCong(cboLoaiCham.Text);
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                ChamCong cc = new ChamCong(int.Parse(txtMaCC.Text), dtpNgayCham.Value, int.Parse(txtMaNV.Text), int.Parse(txtMaNV_CC.Text), maloai, trangthai);
                bool kq = balcc.SuaChamCong(cc, this.macccu, this.malccu);
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

        private void cbTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
