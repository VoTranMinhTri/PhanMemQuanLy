namespace demo140421.Forms
{
    partial class FormThemHoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.mahdnct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maspct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmauct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemHDN = new FontAwesome.Sharp.IconButton();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTenNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvListSP = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHDN.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCTHDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHDN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdnct,
            this.maspct,
            this.tenmauct,
            this.sizect,
            this.giasp,
            this.soluong,
            this.thanhtien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHDN.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHDN.EnableHeadersVisualStyles = false;
            this.dgvCTHDN.GridColor = System.Drawing.Color.White;
            this.dgvCTHDN.Location = new System.Drawing.Point(7, 70);
            this.dgvCTHDN.Name = "dgvCTHDN";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTHDN.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCTHDN.RowTemplate.Height = 24;
            this.dgvCTHDN.Size = new System.Drawing.Size(738, 594);
            this.dgvCTHDN.TabIndex = 64;
            this.dgvCTHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDN_CellClick);
            // 
            // mahdnct
            // 
            this.mahdnct.DataPropertyName = "MaHD";
            this.mahdnct.HeaderText = "Mã HĐ";
            this.mahdnct.Name = "mahdnct";
            // 
            // maspct
            // 
            this.maspct.DataPropertyName = "MaSP";
            this.maspct.HeaderText = "Mã SP";
            this.maspct.Name = "maspct";
            // 
            // tenmauct
            // 
            this.tenmauct.DataPropertyName = "TenMau";
            this.tenmauct.HeaderText = "Tên màu";
            this.tenmauct.Name = "tenmauct";
            // 
            // sizect
            // 
            this.sizect.DataPropertyName = "TenSize";
            this.sizect.HeaderText = " Size";
            this.sizect.Name = "sizect";
            // 
            // giasp
            // 
            this.giasp.DataPropertyName = "Gia";
            this.giasp.HeaderText = "Giá nhập";
            this.giasp.Name = "giasp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "ThanhTien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mã SP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.dgvCTHDN);
            this.panel1.Controls.Add(this.iconButtonXoa);
            this.panel1.Controls.Add(this.iconButtonThemHDN);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTongSL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1016, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 825);
            this.panel1.TabIndex = 41;
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButtonXoa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoa.FlatAppearance.BorderSize = 0;
            this.iconButtonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.IconSize = 32;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(274, 763);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(259, 50);
            this.iconButtonXoa.TabIndex = 61;
            this.iconButtonXoa.Text = "Xóa sản phẩm";
            this.iconButtonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // iconButtonThemHDN
            // 
            this.iconButtonThemHDN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButtonThemHDN.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemHDN.FlatAppearance.BorderSize = 0;
            this.iconButtonThemHDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemHDN.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemHDN.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemHDN.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemHDN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemHDN.IconSize = 32;
            this.iconButtonThemHDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemHDN.Location = new System.Drawing.Point(9, 763);
            this.iconButtonThemHDN.Name = "iconButtonThemHDN";
            this.iconButtonThemHDN.Size = new System.Drawing.Size(259, 50);
            this.iconButtonThemHDN.TabIndex = 49;
            this.iconButtonThemHDN.Text = "Thêm hóa đơn nhập";
            this.iconButtonThemHDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemHDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemHDN.UseVisualStyleBackColor = false;
            this.iconButtonThemHDN.Click += new System.EventHandler(this.iconButtonThemHDN_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(274, 698);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(259, 22);
            this.txtTongTien.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(6, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tổng tiền";
            // 
            // txtTongSL
            // 
            this.txtTongSL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongSL.Enabled = false;
            this.txtTongSL.Location = new System.Drawing.Point(274, 670);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(259, 22);
            this.txtTongSL.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(6, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tổng sl sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(183, 168);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(321, 22);
            this.txtTimKiem.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tìm kiếm SP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTimKiem);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbTenNCC);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.dgvListSP);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.iconButtonThem);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.iconPictureBoxSearch);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1773, 825);
            this.panel2.TabIndex = 32;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiaNhap.Location = new System.Drawing.Point(183, 735);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(321, 22);
            this.txtGiaNhap.TabIndex = 197;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(13, 738);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 196;
            this.label11.Text = "Giá nhập";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuong.Location = new System.Drawing.Point(183, 702);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(321, 22);
            this.txtSoLuong.TabIndex = 195;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(13, 705);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 194;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(11, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Hóa đơn nhập";
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.FormattingEnabled = true;
            this.cbTenNCC.Location = new System.Drawing.Point(183, 98);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(321, 24);
            this.cbTenNCC.TabIndex = 193;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(183, 128);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(321, 22);
            this.dtpNgayLap.TabIndex = 192;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 191;
            this.label2.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 190;
            this.label4.Text = "Tên NCC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 189;
            this.label7.Text = "Mã HĐ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(183, 70);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(321, 22);
            this.txtMaHD.TabIndex = 188;
            // 
            // dgvListSP
            // 
            this.dgvListSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSP.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loaisanpham,
            this.tenmau,
            this.size,
            this.gia,
            this.trangthai});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSP.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListSP.EnableHeadersVisualStyles = false;
            this.dgvListSP.GridColor = System.Drawing.Color.White;
            this.dgvListSP.Location = new System.Drawing.Point(15, 215);
            this.dgvListSP.Name = "dgvListSP";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListSP.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListSP.RowTemplate.Height = 24;
            this.dgvListSP.Size = new System.Drawing.Size(994, 449);
            this.dgvListSP.TabIndex = 51;
            this.dgvListSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSP_CellClick);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MaSP";
            this.masp.HeaderText = "Mã SP";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TenSP";
            this.tensp.HeaderText = "Tên SP";
            this.tensp.Name = "tensp";
            this.tensp.Width = 200;
            // 
            // loaisanpham
            // 
            this.loaisanpham.DataPropertyName = "TenLoai";
            this.loaisanpham.HeaderText = "Loại sản phẩm";
            this.loaisanpham.Name = "loaisanpham";
            // 
            // tenmau
            // 
            this.tenmau.DataPropertyName = "TenMau";
            this.tenmau.HeaderText = "Tên màu";
            this.tenmau.Name = "tenmau";
            this.tenmau.Width = 150;
            // 
            // size
            // 
            this.size.DataPropertyName = "TenSize";
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "Gia";
            this.gia.HeaderText = "Giá bán";
            this.gia.Name = "gia";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(183, 670);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(321, 22);
            this.txtMaSP.TabIndex = 46;
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThem.FlatAppearance.BorderSize = 0;
            this.iconButtonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThem.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.IconSize = 32;
            this.iconButtonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.Location = new System.Drawing.Point(183, 763);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Size = new System.Drawing.Size(321, 50);
            this.iconButtonThem.TabIndex = 42;
            this.iconButtonThem.Text = "Thêm sp vào ct hóa đơn";
            this.iconButtonThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(608, 168);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearch.TabIndex = 40;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã SP",
            "Tên SP"});
            this.cboTimKiem.Location = new System.Drawing.Point(510, 168);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 202;
            // 
            // FormThemHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1773, 825);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1791, 872);
            this.Name = "FormThemHoaDonNhap";
            this.Text = "Form thêm hóa đơn nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private FontAwesome.Sharp.IconButton iconButtonThemHDN;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTenNCC;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvListSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdnct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmauct;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizect;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.ComboBox cboTimKiem;


    }
}