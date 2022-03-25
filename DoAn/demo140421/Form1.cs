using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BAL;
using BEL;
using FontAwesome.Sharp;
using demo140421.Forms;
namespace demo140421
{
    public partial class Form1 : Form
    {   //Bien
        
        private int manv;
        private int mach;
        private int macd;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string username):this()
        {
            BAL_NhanVien balnv = new BAL_NhanVien();
            BAL_CuaHang balch = new BAL_CuaHang();
            BAL_TaiKhoan baltk=new BAL_TaiKhoan();
            this.manv = baltk.LayMaNV(username);
            this.mach = baltk.LayMaCH(this.manv);
            this.macd = baltk.LayMaCD(this.manv);
            lblTenCH.Text = balch.LayTenTuMaCH(this.mach);
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            customizeDesing();
            //GioiHan
            if(this.macd == 1)
            {
                iconButtonCuaHang.Enabled = false;
                iconButtonDanhSachChamCong.Enabled = false;
                iconButtonHoaDonBan.Enabled = false;
                iconButtonHoaDonNhap.Enabled = false;
                iconButtonLuong.Enabled = false;
                iconButtonNhanVien.Enabled = false;
                iconButtonSanPham.Enabled = false;
                iconButtonTaiKhoan.Enabled = false;
                iconButtonChamCong.Enabled = false;
                iconButtonKhoHang.Enabled = false;
                iconButtonNhaCungCap.Enabled = false;
                iconButtonCuaHang.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonDanhSachChamCong.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonHoaDonBan.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonHoaDonNhap.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonLuong.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonNhanVien.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonSanPham.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonTaiKhoan.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonKhoHang.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonNhaCungCap.BackColor = Color.FromArgb(37, 36, 81);
            }
            if(this.macd == 2)
            {
                iconButtonCuaHang.Enabled = false;
                iconButtonLuong.Enabled = false;
                iconButtonSanPham.Enabled = false;
                iconButtonThanhToan.Enabled = false;
                iconButtonDatHang.Enabled = false;
                iconButtonLuong.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonSanPham.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonCuaHang.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonThanhToan.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonDatHang.BackColor = Color.FromArgb(37, 36, 81);
            }
            if(this.macd == 3)
            {
                iconButtonThanhToan.Enabled = false;
                iconButtonDatHang.Enabled = false;
                iconButtonThanhToan.BackColor = Color.FromArgb(37, 36, 81);
                iconButtonDatHang.BackColor = Color.FromArgb(37, 36, 81);
            }
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Bang mau
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Phuong thuc
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;
                //Child Form Text
                lblTitleChildForm.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Home;
            iconCurrentForm.IconColor = System.Drawing.SystemColors.MenuHighlight;
            lblTitleChildForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            lblTitleChildForm.Text = "Home";
            hideSubMenu();
        }
        //Events
        //Tro ve man hinh home
        private void lblHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks
        private void iconButtonQuanLy_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = iconButtonQuanLy.Text;
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(panelQuanLySubMenu);
        }
        private void iconPictureBoxMenuUser_Click(object sender, EventArgs e)
        {
            Reset();
            showSubMenu(panelUserSubMenu);
        }
        private void iconButtonSanPham_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonSanPham.IconChar;
            OpenChildForm(new FormSanPham());
        }
        private void iconButtonNhaCungCap_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonNhaCungCap.IconChar;
            OpenChildForm(new FormNhaCungCap());
        }
        private void iconButtonDonDatHang_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonDonDatHang.IconChar;
            OpenChildForm(new FormDonDatHang(this.mach,this.macd,this.manv));
        }
        private void iconButtonKhachHang_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonKhachHang.IconChar;
            OpenChildForm(new FormKhachHang(this.macd));
        }
        private void iconButtonNhanVien_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonNhanVien.IconChar;
            OpenChildForm(new FormNhanVien(this.macd,this.mach,this.manv));
        }
        private void iconButtonHoaDonBan_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonHoaDonBan.IconChar;
            OpenChildForm(new FormHoaDonBan(this.macd,this.mach));
        }

        private void iconButtonHoaDonNhap_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonHoaDonNhap.IconChar;
            OpenChildForm(new FormHoaDonNhap(this.macd,this.mach));
        }
        private void iconButtonDanhSachChamCong_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonDanhSachChamCong.IconChar;
            OpenChildForm(new FormDanhSachChamCong(this.manv,this.macd));
        }
        private void iconButtonLuong_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonLuong.IconChar;
            OpenChildForm(new FormLuong());
        }
        private void iconButtonCuaHang_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonCuaHang.IconChar;
            OpenChildForm(new FormCuaHang());
        }
        private void iconButtonKhoHang_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonKhoHang.IconChar;
            OpenChildForm(new FormKhoHang(this.macd));
        }
        private void iconButtonTaiKhoan_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonTaiKhoan.IconChar;
            OpenChildForm(new FormTaiKhoan(this.manv,this.mach,this.macd));
        }
        private void iconButtonThanhToan_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = iconButtonThanhToan.Text;
            hideSubMenu();
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormThanhToan(this.mach,this.manv));
        }
        private void iconButtonThongKe_Click(object sender, EventArgs e)
        {
            
            lblTitleChildForm.Text = iconButtonThongKe.Text;
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(panelThongKeSubMenu);
        }
        private void iconButtonThongKe1_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonThongKe1.IconChar;
            OpenChildForm(new FormThongKe1());
        }

        private void iconButtonThongKe2_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonThongKe2.IconChar;
            OpenChildForm(new FormThongKe2());
        }

        private void iconButtonThongKe3_Click(object sender, EventArgs e)
        {
            iconCurrentForm.IconChar = iconButtonThongKe3.IconChar;
            OpenChildForm(new FormThongKe3());
        }
        private void iconButtonDatHang_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = iconButtonDatHang.Text;
            hideSubMenu();
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormThemDonDatHang(this.mach,this.manv));
        }
        private void iconButtonChamCong_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = iconButtonChamCong.Text;
            hideSubMenu();
            ActivateButton(sender, Color.Lime);
            OpenChildForm(new FormChamCong(this.manv,this.macd));

        }
        //Di chuyen man hinh
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Thu nho - phong to - thoat
        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void iconMaximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Xoa duong vien trong suot o trang thai toi da
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        //Time-Date
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        //Submenu quan ly, user, thong ke
        private void customizeDesing()
        {
            panelUserSubMenu.Visible = false;
            panelQuanLySubMenu.Visible = false;
            panelThongKeSubMenu.Visible = false;
        }
        private void hideSubMenuUser()
        {
            if (panelUserSubMenu.Visible == true)
                panelUserSubMenu.Visible = false;
        }
        private void showSubMenuUser(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelQuanLySubMenu.Visible == true || panelThongKeSubMenu.Visible == true)
            {
                panelQuanLySubMenu.Visible = false;
                panelThongKeSubMenu.Visible = false;
            }
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Menu User
        private void iconButtonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap frm = new DangNhap();
            frm.ShowDialog();
        }

        private void iconButtonDMK_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau();
            frm.ShowDialog();
        }


    }
}
