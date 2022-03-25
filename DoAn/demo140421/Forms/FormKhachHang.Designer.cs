namespace demo140421.Forms
{
    partial class FormKhachHang
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
            this.cboTimKiemLoaiKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemLoai = new System.Windows.Forms.TextBox();
            this.iconPictureBoxSearchLoai = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonThemLoai = new FontAwesome.Sharp.IconButton();
            this.iconButtonSuaLoai = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonXoaLoai = new FontAwesome.Sharp.IconButton();
            this.dgvListLoaiKH = new System.Windows.Forms.DataGridView();
            this.maloaikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthailoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListKhachHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLoaiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.cboTimKiemLoaiKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTimKiemLoai);
            this.panel2.Controls.Add(this.iconPictureBoxSearchLoai);
            this.panel2.Controls.Add(this.iconButtonThemLoai);
            this.panel2.Controls.Add(this.iconButtonSuaLoai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconButtonXoaLoai);
            this.panel2.Controls.Add(this.dgvListLoaiKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 728);
            this.panel2.TabIndex = 41;
            // 
            // cboTimKiemLoaiKH
            // 
            this.cboTimKiemLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemLoaiKH.FormattingEnabled = true;
            this.cboTimKiemLoaiKH.Items.AddRange(new object[] {
            "Mã loại",
            "Tên loại"});
            this.cboTimKiemLoaiKH.Location = new System.Drawing.Point(358, 38);
            this.cboTimKiemLoaiKH.Name = "cboTimKiemLoaiKH";
            this.cboTimKiemLoaiKH.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiemLoaiKH.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tìm kiếm";
            // 
            // txtTimKiemLoai
            // 
            this.txtTimKiemLoai.Location = new System.Drawing.Point(152, 38);
            this.txtTimKiemLoai.Name = "txtTimKiemLoai";
            this.txtTimKiemLoai.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemLoai.TabIndex = 47;
            // 
            // iconPictureBoxSearchLoai
            // 
            this.iconPictureBoxSearchLoai.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxSearchLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchLoai.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearchLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearchLoai.Location = new System.Drawing.Point(456, 38);
            this.iconPictureBoxSearchLoai.Name = "iconPictureBoxSearchLoai";
            this.iconPictureBoxSearchLoai.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearchLoai.TabIndex = 48;
            this.iconPictureBoxSearchLoai.TabStop = false;
            this.iconPictureBoxSearchLoai.Click += new System.EventHandler(this.iconPictureBoxSearchLoai_Click);
            // 
            // iconButtonThemLoai
            // 
            this.iconButtonThemLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThemLoai.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemLoai.FlatAppearance.BorderSize = 0;
            this.iconButtonThemLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemLoai.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemLoai.IconSize = 32;
            this.iconButtonThemLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemLoai.Location = new System.Drawing.Point(16, 649);
            this.iconButtonThemLoai.Name = "iconButtonThemLoai";
            this.iconButtonThemLoai.Size = new System.Drawing.Size(168, 50);
            this.iconButtonThemLoai.TabIndex = 46;
            this.iconButtonThemLoai.Text = "Thêm";
            this.iconButtonThemLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemLoai.UseVisualStyleBackColor = false;
            this.iconButtonThemLoai.Click += new System.EventHandler(this.iconButtonThemLoai_Click);
            // 
            // iconButtonSuaLoai
            // 
            this.iconButtonSuaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSuaLoai.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaLoai.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaLoai.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaLoai.IconSize = 32;
            this.iconButtonSuaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaLoai.Location = new System.Drawing.Point(364, 649);
            this.iconButtonSuaLoai.Name = "iconButtonSuaLoai";
            this.iconButtonSuaLoai.Size = new System.Drawing.Size(168, 50);
            this.iconButtonSuaLoai.TabIndex = 47;
            this.iconButtonSuaLoai.Text = "Sửa";
            this.iconButtonSuaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaLoai.UseVisualStyleBackColor = false;
            this.iconButtonSuaLoai.Click += new System.EventHandler(this.iconButtonSuaLoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Danh sách loại khách hàng";
            // 
            // iconButtonXoaLoai
            // 
            this.iconButtonXoaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonXoaLoai.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoaLoai.FlatAppearance.BorderSize = 0;
            this.iconButtonXoaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoaLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaLoai.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoaLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaLoai.IconSize = 32;
            this.iconButtonXoaLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaLoai.Location = new System.Drawing.Point(190, 649);
            this.iconButtonXoaLoai.Name = "iconButtonXoaLoai";
            this.iconButtonXoaLoai.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoaLoai.TabIndex = 46;
            this.iconButtonXoaLoai.Text = "Xóa";
            this.iconButtonXoaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaLoai.UseVisualStyleBackColor = false;
            this.iconButtonXoaLoai.Click += new System.EventHandler(this.iconButtonXoaLoai_Click);
            // 
            // dgvListLoaiKH
            // 
            this.dgvListLoaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListLoaiKH.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListLoaiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListLoaiKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListLoaiKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaikh,
            this.tenloai,
            this.hanmuc,
            this.trangthailoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListLoaiKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListLoaiKH.EnableHeadersVisualStyles = false;
            this.dgvListLoaiKH.GridColor = System.Drawing.Color.White;
            this.dgvListLoaiKH.Location = new System.Drawing.Point(16, 126);
            this.dgvListLoaiKH.Name = "dgvListLoaiKH";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListLoaiKH.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListLoaiKH.RowTemplate.Height = 24;
            this.dgvListLoaiKH.Size = new System.Drawing.Size(654, 517);
            this.dgvListLoaiKH.TabIndex = 46;
            this.dgvListLoaiKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // maloaikh
            // 
            this.maloaikh.DataPropertyName = "MaLoai";
            this.maloaikh.HeaderText = "Mã loại";
            this.maloaikh.Name = "maloaikh";
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "TenLoai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.Name = "tenloai";
            // 
            // hanmuc
            // 
            this.hanmuc.DataPropertyName = "HanMuc";
            this.hanmuc.HeaderText = "Hạn mức";
            this.hanmuc.Name = "hanmuc";
            this.hanmuc.Width = 200;
            // 
            // trangthailoai
            // 
            this.trangthailoai.DataPropertyName = "TrangThai";
            this.trangthailoai.HeaderText = "Trạng thái";
            this.trangthailoai.Name = "trangthailoai";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tìm kiếm";
            // 
            // dgvListKhachHang
            // 
            this.dgvListKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListKhachHang.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.diachi,
            this.doanhso,
            this.maloai,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListKhachHang.EnableHeadersVisualStyles = false;
            this.dgvListKhachHang.GridColor = System.Drawing.Color.White;
            this.dgvListKhachHang.Location = new System.Drawing.Point(12, 126);
            this.dgvListKhachHang.Name = "dgvListKhachHang";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListKhachHang.RowTemplate.Height = 24;
            this.dgvListKhachHang.Size = new System.Drawing.Size(563, 517);
            this.dgvListKhachHang.TabIndex = 40;
            this.dgvListKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiem.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Danh sách khách hàng";
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
            this.iconPictureBoxSearch.TabIndex = 44;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã KH",
            "Họ tên"});
            this.cboTimKiem.Location = new System.Drawing.Point(360, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 65;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "MaKH";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "TenKH";
            this.tenkh.HeaderText = "Tên KH";
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Phai";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 170;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 200;
            // 
            // doanhso
            // 
            this.doanhso.DataPropertyName = "DoanhSo";
            this.doanhso.HeaderText = "Doanh số";
            this.doanhso.Name = "doanhso";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "MaLoai";
            this.maloai.HeaderText = "Mã loại";
            this.maloai.Name = "maloai";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonSua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconButtonXoa);
            this.Controls.Add(this.dgvListKhachHang);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Name = "FormKhachHang";
            this.Text = "Khách hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLoaiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListKhachHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListLoaiKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemLoai;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearchLoai;
        private FontAwesome.Sharp.IconButton iconButtonThemLoai;
        private FontAwesome.Sharp.IconButton iconButtonSuaLoai;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonXoaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthailoai;
        private System.Windows.Forms.ComboBox cboTimKiemLoaiKH;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhso;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;



    }
}