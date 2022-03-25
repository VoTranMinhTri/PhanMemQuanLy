namespace demo140421.Forms
{
    partial class FormSanPham
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
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListSP = new System.Windows.Forms.DataGridView();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTimKiemLoaiSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListLoaiSP = new System.Windows.Forms.DataGridView();
            this.iconButtonXoaLoaiSP = new FontAwesome.Sharp.IconButton();
            this.txtTimKiemLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBoxSearchLoaiSP = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonSuaLoaiSP = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemLoaiSP = new FontAwesome.Sharp.IconButton();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthailoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchLoaiSP)).BeginInit();
            this.SuspendLayout();
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
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiem.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tìm kiếm";
            // 
            // dgvListSP
            // 
            this.dgvListSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSP.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loaisanpham,
            this.tenmau,
            this.size,
            this.gia,
            this.trangthai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListSP.EnableHeadersVisualStyles = false;
            this.dgvListSP.GridColor = System.Drawing.Color.White;
            this.dgvListSP.Location = new System.Drawing.Point(12, 126);
            this.dgvListSP.Name = "dgvListSP";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListSP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListSP.RowTemplate.Height = 24;
            this.dgvListSP.Size = new System.Drawing.Size(562, 517);
            this.dgvListSP.TabIndex = 50;
            this.dgvListSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSP_CellClick);
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
            this.iconPictureBoxSearch.TabIndex = 34;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã SP",
            "Tên SP"});
            this.cboTimKiem.Location = new System.Drawing.Point(360, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.cboTimKiemLoaiSP);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvListLoaiSP);
            this.panel2.Controls.Add(this.iconButtonXoaLoaiSP);
            this.panel2.Controls.Add(this.txtTimKiemLoai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconPictureBoxSearchLoaiSP);
            this.panel2.Controls.Add(this.iconButtonSuaLoaiSP);
            this.panel2.Controls.Add(this.iconButtonThemLoaiSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 728);
            this.panel2.TabIndex = 53;
            // 
            // cboTimKiemLoaiSP
            // 
            this.cboTimKiemLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemLoaiSP.FormattingEnabled = true;
            this.cboTimKiemLoaiSP.Items.AddRange(new object[] {
            "Mã loại",
            "Tên loại"});
            this.cboTimKiemLoaiSP.Location = new System.Drawing.Point(358, 38);
            this.cboTimKiemLoaiSP.Name = "cboTimKiemLoaiSP";
            this.cboTimKiemLoaiSP.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiemLoaiSP.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tìm kiếm";
            // 
            // dgvListLoaiSP
            // 
            this.dgvListLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListLoaiSP.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListLoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListLoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.tenloai,
            this.trangthailoai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListLoaiSP.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListLoaiSP.EnableHeadersVisualStyles = false;
            this.dgvListLoaiSP.GridColor = System.Drawing.Color.White;
            this.dgvListLoaiSP.Location = new System.Drawing.Point(16, 126);
            this.dgvListLoaiSP.Name = "dgvListLoaiSP";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListLoaiSP.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListLoaiSP.RowTemplate.Height = 24;
            this.dgvListLoaiSP.Size = new System.Drawing.Size(654, 517);
            this.dgvListLoaiSP.TabIndex = 53;
            this.dgvListLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListLoaiSP_CellClick);
            // 
            // iconButtonXoaLoaiSP
            // 
            this.iconButtonXoaLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonXoaLoaiSP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoaLoaiSP.FlatAppearance.BorderSize = 0;
            this.iconButtonXoaLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoaLoaiSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaLoaiSP.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoaLoaiSP.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaLoaiSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaLoaiSP.IconSize = 32;
            this.iconButtonXoaLoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaLoaiSP.Location = new System.Drawing.Point(190, 649);
            this.iconButtonXoaLoaiSP.Name = "iconButtonXoaLoaiSP";
            this.iconButtonXoaLoaiSP.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoaLoaiSP.TabIndex = 52;
            this.iconButtonXoaLoaiSP.Text = "Xóa";
            this.iconButtonXoaLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaLoaiSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaLoaiSP.UseVisualStyleBackColor = false;
            this.iconButtonXoaLoaiSP.Click += new System.EventHandler(this.iconButtonXoaLoaiSP_Click);
            // 
            // txtTimKiemLoai
            // 
            this.txtTimKiemLoai.Location = new System.Drawing.Point(152, 38);
            this.txtTimKiemLoai.Name = "txtTimKiemLoai";
            this.txtTimKiemLoai.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemLoai.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Danh sách loại sản phẩm";
            // 
            // iconPictureBoxSearchLoaiSP
            // 
            this.iconPictureBoxSearchLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxSearchLoaiSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchLoaiSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearchLoaiSP.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchLoaiSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearchLoaiSP.Location = new System.Drawing.Point(456, 38);
            this.iconPictureBoxSearchLoaiSP.Name = "iconPictureBoxSearchLoaiSP";
            this.iconPictureBoxSearchLoaiSP.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearchLoaiSP.TabIndex = 57;
            this.iconPictureBoxSearchLoaiSP.TabStop = false;
            this.iconPictureBoxSearchLoaiSP.Click += new System.EventHandler(this.iconPictureBoxSearchLoaiSP_Click);
            // 
            // iconButtonSuaLoaiSP
            // 
            this.iconButtonSuaLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSuaLoaiSP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaLoaiSP.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaLoaiSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaLoaiSP.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaLoaiSP.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaLoaiSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaLoaiSP.IconSize = 32;
            this.iconButtonSuaLoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaLoaiSP.Location = new System.Drawing.Point(364, 649);
            this.iconButtonSuaLoaiSP.Name = "iconButtonSuaLoaiSP";
            this.iconButtonSuaLoaiSP.Size = new System.Drawing.Size(168, 50);
            this.iconButtonSuaLoaiSP.TabIndex = 55;
            this.iconButtonSuaLoaiSP.Text = "Sửa";
            this.iconButtonSuaLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaLoaiSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaLoaiSP.UseVisualStyleBackColor = false;
            this.iconButtonSuaLoaiSP.Click += new System.EventHandler(this.iconButtonSuaLoaiSP_Click);
            // 
            // iconButtonThemLoaiSP
            // 
            this.iconButtonThemLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThemLoaiSP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemLoaiSP.FlatAppearance.BorderSize = 0;
            this.iconButtonThemLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemLoaiSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemLoaiSP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemLoaiSP.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemLoaiSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemLoaiSP.IconSize = 32;
            this.iconButtonThemLoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemLoaiSP.Location = new System.Drawing.Point(16, 649);
            this.iconButtonThemLoaiSP.Name = "iconButtonThemLoaiSP";
            this.iconButtonThemLoaiSP.Size = new System.Drawing.Size(168, 50);
            this.iconButtonThemLoaiSP.TabIndex = 50;
            this.iconButtonThemLoaiSP.Text = "Thêm";
            this.iconButtonThemLoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemLoaiSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemLoaiSP.UseVisualStyleBackColor = false;
            this.iconButtonThemLoaiSP.Click += new System.EventHandler(this.iconButtonThemLoaiSP_Click);
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "MaLoai";
            this.maloai.HeaderText = "Mã loại";
            this.maloai.Name = "maloai";
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "TenLoai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.Name = "tenloai";
            this.tenloai.Width = 150;
            // 
            // trangthailoai
            // 
            this.trangthailoai.DataPropertyName = "TrangThai";
            this.trangthailoai.HeaderText = "Trạng thái";
            this.trangthailoai.Name = "trangthailoai";
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
            this.loaisanpham.Width = 150;
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
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonSua);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.iconButtonXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.dgvListSP);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Name = "FormSanPham";
            this.Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListSP;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListLoaiSP;
        private FontAwesome.Sharp.IconButton iconButtonXoaLoaiSP;
        private System.Windows.Forms.TextBox txtTimKiemLoai;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearchLoaiSP;
        private FontAwesome.Sharp.IconButton iconButtonSuaLoaiSP;
        private FontAwesome.Sharp.IconButton iconButtonThemLoaiSP;
        private System.Windows.Forms.ComboBox cboTimKiemLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthailoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;

    }
}