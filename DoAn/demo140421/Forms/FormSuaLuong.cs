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
    public partial class FormSuaLuong : Form
    {
        int manvcu;
        int thangcu;
        int namcu;
        public FormSuaLuong()
        {
            InitializeComponent();
            khoiTaoThang();
        }

        public FormSuaLuong(int manv,int thang,int nam,float luong,int trangthai):this()
        {
            khoiTaoThang();
            this.manvcu = manv;
            this.thangcu = thang;
            this.namcu = nam;
            txtMaNV.Text = manv.ToString();
            cboThang.Text = thang.ToString();
            txtNam.Text = nam.ToString();
            txtLuong.Text=luong.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }

        private void khoiTaoThang()
        {
            for (int i = 1; i < 13; i++)
                cboThang.Items.Add(i);
        }

        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_Luong balluong = new BAL_Luong();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                Luong luong = new Luong(int.Parse(txtMaNV.Text), int.Parse(cboThang.Text), int.Parse(txtNam.Text), float.Parse(txtLuong.Text), trangthai);
                bool kq = balluong.SuaLuong(luong, this.manvcu, this.thangcu, this.namcu);
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
