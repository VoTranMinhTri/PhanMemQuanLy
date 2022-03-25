namespace demo140421.Forms
{
    partial class FormDonDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonThemHoaDon = new FontAwesome.Sharp.IconButton();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCTDH = new System.Windows.Forms.DataGridView();
            this.madhct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maspct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmauct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensizect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienhdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.dgvListDonHang = new System.Windows.Forms.DataGridView();
            this.madh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongSL
            // 
            this.txtTongSL.Enabled = false;
            this.txtTongSL.Location = new System.Drawing.Point(257, 76);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(108, 22);
            this.txtTongSL.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tổng số lượng sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(15, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Chi tiết hóa đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(195, 76);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(321, 22);
            this.dtpNgayLap.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayLapHoaDon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.iconButtonThemHoaDon);
            this.panel2.Controls.Add(this.dtpNgayNhan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.iconButtonSua);
            this.panel2.Controls.Add(this.iconButtonXoa);
            this.panel2.Controls.Add(this.dgvListDonHang);
            this.panel2.Controls.Add(this.iconPictureBoxSearch);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 732);
            this.panel2.TabIndex = 34;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(214, 578);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(373, 22);
            this.txtMaNV.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mã NV lập";
            // 
            // dtpNgayLapHoaDon
            // 
            this.dtpNgayLapHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpNgayLapHoaDon.Location = new System.Drawing.Point(214, 613);
            this.dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            this.dtpNgayLapHoaDon.Size = new System.Drawing.Size(373, 22);
            this.dtpNgayLapHoaDon.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(15, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // iconButtonThemHoaDon
            // 
            this.iconButtonThemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThemHoaDon.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemHoaDon.FlatAppearance.BorderSize = 0;
            this.iconButtonThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemHoaDon.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemHoaDon.IconSize = 32;
            this.iconButtonThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemHoaDon.Location = new System.Drawing.Point(18, 653);
            this.iconButtonThemHoaDon.Name = "iconButtonThemHoaDon";
            this.iconButtonThemHoaDon.Size = new System.Drawing.Size(217, 50);
            this.iconButtonThemHoaDon.TabIndex = 65;
            this.iconButtonThemHoaDon.Text = "Thêm Hóa Đơn";
            this.iconButtonThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemHoaDon.UseVisualStyleBackColor = false;
            this.iconButtonThemHoaDon.Click += new System.EventHandler(this.iconButtonThemHoaDon_Click);
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Location = new System.Drawing.Point(195, 104);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(321, 22);
            this.dtpNgayNhan.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ngày nhận";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.txtTongSL);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dgvCTDH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(647, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 732);
            this.panel3.TabIndex = 53;
            // 
            // dgvCTDH
            // 
            this.dgvCTDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTDH.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCTDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madhct,
            this.maspct,
            this.tenmauct,
            this.tensizect,
            this.giact,
            this.soluongct,
            this.thanhtienhdb});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTDH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTDH.EnableHeadersVisualStyles = false;
            this.dgvCTDH.GridColor = System.Drawing.Color.White;
            this.dgvCTDH.Location = new System.Drawing.Point(17, 159);
            this.dgvCTDH.Name = "dgvCTDH";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTDH.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTDH.RowTemplate.Height = 24;
            this.dgvCTDH.Size = new System.Drawing.Size(587, 403);
            this.dgvCTDH.TabIndex = 29;
            // 
            // madhct
            // 
            this.madhct.DataPropertyName = "MaDH";
            this.madhct.HeaderText = "Mã ĐH";
            this.madhct.Name = "madhct";
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
            // tensizect
            // 
            this.tensizect.DataPropertyName = "TenSize";
            this.tensizect.HeaderText = "Size";
            this.tensizect.Name = "tensizect";
            // 
            // giact
            // 
            this.giact.DataPropertyName = "Gia";
            this.giact.HeaderText = "Giá";
            this.giact.Name = "giact";
            // 
            // soluongct
            // 
            this.soluongct.DataPropertyName = "SoLuong";
            this.soluongct.HeaderText = "Số lượng";
            this.soluongct.Name = "soluongct";
            // 
            // thanhtienhdb
            // 
            this.thanhtienhdb.DataPropertyName = "ThanhTien";
            this.thanhtienhdb.HeaderText = "Thành tiền";
            this.thanhtienhdb.Name = "thanhtienhdb";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(15, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Ngày lập";
            // 
            // iconButtonSua
            // 
            this.iconButtonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSua.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSua.FlatAppearance.BorderSize = 0;
            this.iconButtonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSua.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSua.IconSize = 32;
            this.iconButtonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.Location = new System.Drawing.Point(415, 653);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(168, 50);
            this.iconButtonSua.TabIndex = 58;
            this.iconButtonSua.Text = "Sửa";
            this.iconButtonSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonXoa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoa.FlatAppearance.BorderSize = 0;
            this.iconButtonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.IconSize = 32;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(241, 653);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoa.TabIndex = 57;
            this.iconButtonXoa.Text = "Xóa";
            this.iconButtonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
            // 
            // dgvListDonHang
            // 
            this.dgvListDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListDonHang.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madh,
            this.manv,
            this.makh,
            this.ngaylap,
            this.ngaynhan,
            this.chietkhau,
            this.ghichu,
            this.tongtien,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListDonHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListDonHang.EnableHeadersVisualStyles = false;
            this.dgvListDonHang.GridColor = System.Drawing.Color.White;
            this.dgvListDonHang.Location = new System.Drawing.Point(17, 159);
            this.dgvListDonHang.Name = "dgvListDonHang";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListDonHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListDonHang.RowTemplate.Height = 24;
            this.dgvListDonHang.Size = new System.Drawing.Size(624, 403);
            this.dgvListDonHang.TabIndex = 49;
            this.dgvListDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDonHang_CellClick);
            // 
            // madh
            // 
            this.madh.DataPropertyName = "MaDH";
            this.madh.HeaderText = "Mã ĐH";
            this.madh.Name = "madh";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNV";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MaKH";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "NgayLap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            // 
            // ngaynhan
            // 
            this.ngaynhan.DataPropertyName = "NgayNhan";
            this.ngaynhan.HeaderText = "Ngày nhận";
            this.ngaynhan.Name = "ngaynhan";
            // 
            // chietkhau
            // 
            this.chietkhau.DataPropertyName = "ChietKhau";
            this.chietkhau.HeaderText = "Chiết khấu";
            this.chietkhau.Name = "chietkhau";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "GhiChu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TONGTIEN";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(522, 38);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearch.TabIndex = 40;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(195, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(321, 22);
            this.txtTimKiem.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã Hóa Đơn";
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 732);
            this.Controls.Add(this.panel2);
            this.Name = "FormDonDatHang";
            this.Text = "Đơn đặt hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.DataGridView dgvListDonHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCTDH;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButtonThemHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn madhct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmauct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensizect;
        private System.Windows.Forms.DataGridViewTextBoxColumn giact;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongct;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienhdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn madh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;


    }
}