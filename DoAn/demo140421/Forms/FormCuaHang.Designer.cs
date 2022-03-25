namespace demo140421.Forms
{
    partial class FormCuaHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonXoaSPPB = new FontAwesome.Sharp.IconButton();
            this.cboTimKiemSPPB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemSPPB = new System.Windows.Forms.TextBox();
            this.iconPictureBoxSearchSPPB = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonSuaPB = new FontAwesome.Sharp.IconButton();
            this.dgvListSPPB = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaisppb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonThemPB = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListCuaHang = new System.Windows.Forms.DataGridView();
            this.mach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tench = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTimKiemCH = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchSPPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSPPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.iconButtonXoaSPPB);
            this.panel2.Controls.Add(this.cboTimKiemSPPB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTimKiemSPPB);
            this.panel2.Controls.Add(this.iconPictureBoxSearchSPPB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconButtonSuaPB);
            this.panel2.Controls.Add(this.dgvListSPPB);
            this.panel2.Controls.Add(this.iconButtonThemPB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 728);
            this.panel2.TabIndex = 51;
            // 
            // iconButtonXoaSPPB
            // 
            this.iconButtonXoaSPPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonXoaSPPB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoaSPPB.FlatAppearance.BorderSize = 0;
            this.iconButtonXoaSPPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoaSPPB.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaSPPB.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoaSPPB.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaSPPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaSPPB.IconSize = 32;
            this.iconButtonXoaSPPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaSPPB.Location = new System.Drawing.Point(190, 649);
            this.iconButtonXoaSPPB.Name = "iconButtonXoaSPPB";
            this.iconButtonXoaSPPB.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoaSPPB.TabIndex = 70;
            this.iconButtonXoaSPPB.Text = "Xóa";
            this.iconButtonXoaSPPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaSPPB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaSPPB.UseVisualStyleBackColor = false;
            this.iconButtonXoaSPPB.Click += new System.EventHandler(this.iconButtonXoaSPPB_Click);
            // 
            // cboTimKiemSPPB
            // 
            this.cboTimKiemSPPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemSPPB.FormattingEnabled = true;
            this.cboTimKiemSPPB.Items.AddRange(new object[] {
            "Mã SP",
            "Tên SP"});
            this.cboTimKiemSPPB.Location = new System.Drawing.Point(358, 38);
            this.cboTimKiemSPPB.Name = "cboTimKiemSPPB";
            this.cboTimKiemSPPB.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiemSPPB.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tìm kiếm";
            // 
            // txtTimKiemSPPB
            // 
            this.txtTimKiemSPPB.Location = new System.Drawing.Point(152, 38);
            this.txtTimKiemSPPB.Name = "txtTimKiemSPPB";
            this.txtTimKiemSPPB.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemSPPB.TabIndex = 67;
            // 
            // iconPictureBoxSearchSPPB
            // 
            this.iconPictureBoxSearchSPPB.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxSearchSPPB.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchSPPB.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearchSPPB.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchSPPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearchSPPB.Location = new System.Drawing.Point(456, 38);
            this.iconPictureBoxSearchSPPB.Name = "iconPictureBoxSearchSPPB";
            this.iconPictureBoxSearchSPPB.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearchSPPB.TabIndex = 68;
            this.iconPictureBoxSearchSPPB.TabStop = false;
            this.iconPictureBoxSearchSPPB.Click += new System.EventHandler(this.iconPictureBoxSearchSPPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Danh sản phẩm phân bố";
            // 
            // iconButtonSuaPB
            // 
            this.iconButtonSuaPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSuaPB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaPB.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaPB.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaPB.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaPB.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaPB.IconSize = 32;
            this.iconButtonSuaPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaPB.Location = new System.Drawing.Point(364, 649);
            this.iconButtonSuaPB.Name = "iconButtonSuaPB";
            this.iconButtonSuaPB.Size = new System.Drawing.Size(169, 50);
            this.iconButtonSuaPB.TabIndex = 56;
            this.iconButtonSuaPB.Text = "Sửa";
            this.iconButtonSuaPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaPB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaPB.UseVisualStyleBackColor = false;
            this.iconButtonSuaPB.Click += new System.EventHandler(this.iconButtonSuaPB_Click);
            // 
            // dgvListSPPB
            // 
            this.dgvListSPPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSPPB.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListSPPB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSPPB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSPPB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListSPPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSPPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.tenmau,
            this.tensize,
            this.machpb,
            this.soluong,
            this.trangthaisppb});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSPPB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListSPPB.EnableHeadersVisualStyles = false;
            this.dgvListSPPB.GridColor = System.Drawing.Color.White;
            this.dgvListSPPB.Location = new System.Drawing.Point(16, 126);
            this.dgvListSPPB.Name = "dgvListSPPB";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListSPPB.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListSPPB.RowTemplate.Height = 24;
            this.dgvListSPPB.Size = new System.Drawing.Size(654, 517);
            this.dgvListSPPB.TabIndex = 55;
            this.dgvListSPPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSPPB_CellClick);
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
            // 
            // tenmau
            // 
            this.tenmau.DataPropertyName = "TenMau";
            this.tenmau.HeaderText = "Tên màu";
            this.tenmau.Name = "tenmau";
            // 
            // tensize
            // 
            this.tensize.DataPropertyName = "TenSize";
            this.tensize.HeaderText = "Size";
            this.tensize.Name = "tensize";
            // 
            // machpb
            // 
            this.machpb.DataPropertyName = "MaCH";
            this.machpb.HeaderText = "Mã CH";
            this.machpb.Name = "machpb";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // trangthaisppb
            // 
            this.trangthaisppb.DataPropertyName = "TrangThai";
            this.trangthaisppb.HeaderText = "Trạng thái";
            this.trangthaisppb.Name = "trangthaisppb";
            // 
            // iconButtonThemPB
            // 
            this.iconButtonThemPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThemPB.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemPB.FlatAppearance.BorderSize = 0;
            this.iconButtonThemPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemPB.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemPB.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemPB.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemPB.IconSize = 32;
            this.iconButtonThemPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemPB.Location = new System.Drawing.Point(16, 649);
            this.iconButtonThemPB.Name = "iconButtonThemPB";
            this.iconButtonThemPB.Size = new System.Drawing.Size(168, 50);
            this.iconButtonThemPB.TabIndex = 55;
            this.iconButtonThemPB.Text = "Thêm";
            this.iconButtonThemPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemPB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemPB.UseVisualStyleBackColor = false;
            this.iconButtonThemPB.Click += new System.EventHandler(this.iconButtonThemPB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Tìm kiếm";
            // 
            // dgvListCuaHang
            // 
            this.dgvListCuaHang.AllowUserToAddRows = false;
            this.dgvListCuaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCuaHang.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListCuaHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListCuaHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mach,
            this.tench,
            this.diachi,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCuaHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListCuaHang.EnableHeadersVisualStyles = false;
            this.dgvListCuaHang.GridColor = System.Drawing.Color.White;
            this.dgvListCuaHang.Location = new System.Drawing.Point(12, 126);
            this.dgvListCuaHang.Name = "dgvListCuaHang";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListCuaHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListCuaHang.RowTemplate.Height = 24;
            this.dgvListCuaHang.Size = new System.Drawing.Size(563, 517);
            this.dgvListCuaHang.TabIndex = 50;
            this.dgvListCuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mach
            // 
            this.mach.DataPropertyName = "MaCH";
            this.mach.HeaderText = "Mã CH";
            this.mach.Name = "mach";
            // 
            // tench
            // 
            this.tench.DataPropertyName = "TenCH";
            this.tench.HeaderText = "Tên CH";
            this.tench.Name = "tench";
            this.tench.Width = 250;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 250;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiem.TabIndex = 53;
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
            this.iconButtonSua.Location = new System.Drawing.Point(360, 649);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(168, 50);
            this.iconButtonSua.TabIndex = 18;
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
            this.iconButtonXoa.Location = new System.Drawing.Point(186, 649);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoa.TabIndex = 17;
            this.iconButtonXoa.Text = "Xóa";
            this.iconButtonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
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
            this.iconButtonThem.Location = new System.Drawing.Point(12, 649);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Size = new System.Drawing.Size(168, 50);
            this.iconButtonThem.TabIndex = 16;
            this.iconButtonThem.Text = "Thêm";
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
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(458, 38);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearch.TabIndex = 54;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Danh sách cửa hàng";
            // 
            // cboTimKiemCH
            // 
            this.cboTimKiemCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemCH.FormattingEnabled = true;
            this.cboTimKiemCH.Items.AddRange(new object[] {
            "Mã CH",
            "Tên CH"});
            this.cboTimKiemCH.Location = new System.Drawing.Point(360, 38);
            this.cboTimKiemCH.Name = "cboTimKiemCH";
            this.cboTimKiemCH.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiemCH.TabIndex = 70;
            // 
            // FormCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiemCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButtonSua);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonXoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.dgvListCuaHang);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Name = "FormCuaHang";
            this.Text = "Cửa hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchSPPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSPPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListCuaHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.DataGridView dgvListSPPB;
        private FontAwesome.Sharp.IconButton iconButtonSuaPB;
        private FontAwesome.Sharp.IconButton iconButtonThemPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTimKiemSPPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemSPPB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearchSPPB;
        private System.Windows.Forms.ComboBox cboTimKiemCH;
        private FontAwesome.Sharp.IconButton iconButtonXoaSPPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensize;
        private System.Windows.Forms.DataGridViewTextBoxColumn machpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaisppb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tench;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}