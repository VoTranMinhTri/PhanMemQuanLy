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
    public partial class FormSuaChucDanh : Form
    {
        private int macdcu;
        public FormSuaChucDanh()
        {
            InitializeComponent();
        }
        public FormSuaChucDanh(int macd,string tencd,float luong,int trangthai):this()
        {
            this.macdcu = macd;
            txtMaCD.Text = macd.ToString();
            txtTenCD.Text = tencd;
            txtLuongCB.Text = luong.ToString();
            if (trangthai == 1)
                cbTrangThai.Checked = true;
        }
        private void iconButtonSua_Click(object sender, EventArgs e)
        {
            BAL_ChucDanh balcd = new BAL_ChucDanh();
            int trangthai = 0;
            if (cbTrangThai.Checked == true)
                trangthai = 1;
            try
            {
                ChucDanh cd = new ChucDanh(int.Parse(txtMaCD.Text), txtTenCD.Text, float.Parse(txtLuongCB.Text), trangthai);
                bool kq = balcd.SuaChucDanh(cd, this.macdcu);
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
