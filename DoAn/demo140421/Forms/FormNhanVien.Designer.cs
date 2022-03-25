namespace demo140421.Forms
{
    partial class FormNhanVien
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTimKiemCD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.macdnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaicd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonXoaChucDanh = new FontAwesome.Sharp.IconButton();
            this.txtTimKiemChucDanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBoxSearchChucDanh = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonSuaChucDanh = new FontAwesome.Sharp.IconButton();
            this.iconButtonThemChucDanh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListNV = new System.Windows.Forms.DataGridView();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybdlam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manvql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiem.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.cboTimKiemCD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.iconButtonXoaChucDanh);
            this.panel2.Controls.Add(this.txtTimKiemChucDanh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.iconPictureBoxSearchChucDanh);
            this.panel2.Controls.Add(this.iconButtonSuaChucDanh);
            this.panel2.Controls.Add(this.iconButtonThemChucDanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 728);
            this.panel2.TabIndex = 36;
            // 
            // cboTimKiemCD
            // 
            this.cboTimKiemCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemCD.FormattingEnabled = true;
            this.cboTimKiemCD.Items.AddRange(new object[] {
            "Mã CD",
            "Tên CD"});
            this.cboTimKiemCD.Location = new System.Drawing.Point(358, 38);
            this.cboTimKiemCD.Name = "cboTimKiemCD";
            this.cboTimKiemCD.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiemCD.TabIndex = 65;
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
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macdnv,
            this.tencd,
            this.luongcb,
            this.trangthaicd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(16, 126);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(654, 517);
            this.dataGridView2.TabIndex = 53;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // macdnv
            // 
            this.macdnv.DataPropertyName = "MaCD";
            this.macdnv.HeaderText = "Mã CD";
            this.macdnv.Name = "macdnv";
            // 
            // tencd
            // 
            this.tencd.DataPropertyName = "TenCD";
            this.tencd.HeaderText = "Tên CD";
            this.tencd.Name = "tencd";
            this.tencd.Width = 150;
            // 
            // luongcb
            // 
            this.luongcb.DataPropertyName = "LuongCB";
            this.luongcb.HeaderText = "Lương CB";
            this.luongcb.Name = "luongcb";
            // 
            // trangthaicd
            // 
            this.trangthaicd.DataPropertyName = "TrangThai";
            this.trangthaicd.HeaderText = "Trạng thái";
            this.trangthaicd.Name = "trangthaicd";
            // 
            // iconButtonXoaChucDanh
            // 
            this.iconButtonXoaChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonXoaChucDanh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoaChucDanh.FlatAppearance.BorderSize = 0;
            this.iconButtonXoaChucDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoaChucDanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaChucDanh.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoaChucDanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoaChucDanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoaChucDanh.IconSize = 32;
            this.iconButtonXoaChucDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaChucDanh.Location = new System.Drawing.Point(190, 649);
            this.iconButtonXoaChucDanh.Name = "iconButtonXoaChucDanh";
            this.iconButtonXoaChucDanh.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoaChucDanh.TabIndex = 52;
            this.iconButtonXoaChucDanh.Text = "Xóa";
            this.iconButtonXoaChucDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoaChucDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoaChucDanh.UseVisualStyleBackColor = false;
            this.iconButtonXoaChucDanh.Click += new System.EventHandler(this.iconButtonXoaChucDanh_Click);
            // 
            // txtTimKiemChucDanh
            // 
            this.txtTimKiemChucDanh.Location = new System.Drawing.Point(152, 38);
            this.txtTimKiemChucDanh.Name = "txtTimKiemChucDanh";
            this.txtTimKiemChucDanh.Size = new System.Drawing.Size(200, 22);
            this.txtTimKiemChucDanh.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Danh sách chức danh";
            // 
            // iconPictureBoxSearchChucDanh
            // 
            this.iconPictureBoxSearchChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxSearchChucDanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchChucDanh.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearchChucDanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearchChucDanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearchChucDanh.Location = new System.Drawing.Point(456, 38);
            this.iconPictureBoxSearchChucDanh.Name = "iconPictureBoxSearchChucDanh";
            this.iconPictureBoxSearchChucDanh.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearchChucDanh.TabIndex = 57;
            this.iconPictureBoxSearchChucDanh.TabStop = false;
            this.iconPictureBoxSearchChucDanh.Click += new System.EventHandler(this.iconPictureBoxSearchChucDanh_Click);
            // 
            // iconButtonSuaChucDanh
            // 
            this.iconButtonSuaChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSuaChucDanh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaChucDanh.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaChucDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaChucDanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaChucDanh.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaChucDanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaChucDanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaChucDanh.IconSize = 32;
            this.iconButtonSuaChucDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaChucDanh.Location = new System.Drawing.Point(364, 649);
            this.iconButtonSuaChucDanh.Name = "iconButtonSuaChucDanh";
            this.iconButtonSuaChucDanh.Size = new System.Drawing.Size(168, 50);
            this.iconButtonSuaChucDanh.TabIndex = 55;
            this.iconButtonSuaChucDanh.Text = "Sửa";
            this.iconButtonSuaChucDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaChucDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaChucDanh.UseVisualStyleBackColor = false;
            this.iconButtonSuaChucDanh.Click += new System.EventHandler(this.iconButtonSuaChucDanh_Click);
            // 
            // iconButtonThemChucDanh
            // 
            this.iconButtonThemChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonThemChucDanh.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThemChucDanh.FlatAppearance.BorderSize = 0;
            this.iconButtonThemChucDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThemChucDanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemChucDanh.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThemChucDanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThemChucDanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemChucDanh.IconSize = 32;
            this.iconButtonThemChucDanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemChucDanh.Location = new System.Drawing.Point(16, 649);
            this.iconButtonThemChucDanh.Name = "iconButtonThemChucDanh";
            this.iconButtonThemChucDanh.Size = new System.Drawing.Size(168, 50);
            this.iconButtonThemChucDanh.TabIndex = 50;
            this.iconButtonThemChucDanh.Text = "Thêm";
            this.iconButtonThemChucDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThemChucDanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThemChucDanh.UseVisualStyleBackColor = false;
            this.iconButtonThemChucDanh.Click += new System.EventHandler(this.iconButtonThemChucDanh_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tìm kiếm";
            // 
            // dgvListNV
            // 
            this.dgvListNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListNV.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.ho,
            this.tenlot,
            this.ten,
            this.ngaysinh,
            this.gioitinh,
            this.cccd,
            this.sdt,
            this.diachi,
            this.ngaybdlam,
            this.ngayketthuc,
            this.macd,
            this.mach,
            this.manvql,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListNV.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListNV.EnableHeadersVisualStyles = false;
            this.dgvListNV.GridColor = System.Drawing.Color.White;
            this.dgvListNV.Location = new System.Drawing.Point(12, 126);
            this.dgvListNV.Name = "dgvListNV";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListNV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListNV.RowTemplate.Height = 24;
            this.dgvListNV.Size = new System.Drawing.Size(562, 517);
            this.dgvListNV.TabIndex = 35;
            this.dgvListNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.iconPictureBoxSearch.TabIndex = 39;
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
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã NV",
            "Họ tên"});
            this.cboTimKiem.Location = new System.Drawing.Point(360, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 64;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNV";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // ho
            // 
            this.ho.DataPropertyName = "Ho";
            this.ho.HeaderText = "Họ";
            this.ho.Name = "ho";
            // 
            // tenlot
            // 
            this.tenlot.DataPropertyName = "TenLot";
            this.tenlot.HeaderText = "Tên lót";
            this.tenlot.Name = "tenlot";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
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
            // cccd
            // 
            this.cccd.DataPropertyName = "CCCD";
            this.cccd.HeaderText = "CCCD";
            this.cccd.Name = "cccd";
            this.cccd.Width = 180;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 180;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // ngaybdlam
            // 
            this.ngaybdlam.DataPropertyName = "NgayBDLam";
            this.ngaybdlam.HeaderText = "Ngày BĐ Làm";
            this.ngaybdlam.Name = "ngaybdlam";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "NgayKetThuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.Name = "ngayketthuc";
            // 
            // macd
            // 
            this.macd.DataPropertyName = "MaCD";
            this.macd.HeaderText = "Mã CD";
            this.macd.Name = "macd";
            // 
            // mach
            // 
            this.mach.DataPropertyName = "MaCH";
            this.mach.HeaderText = "Mã CH";
            this.mach.Name = "mach";
            // 
            // manvql
            // 
            this.manvql.DataPropertyName = "MaNV_QL";
            this.manvql.HeaderText = "Mã NV_QL";
            this.manvql.Name = "manvql";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.iconButtonSua);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.iconButtonXoa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListNV);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearchChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FontAwesome.Sharp.IconButton iconButtonXoaChucDanh;
        private System.Windows.Forms.TextBox txtTimKiemChucDanh;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearchChucDanh;
        private FontAwesome.Sharp.IconButton iconButtonSuaChucDanh;
        private FontAwesome.Sharp.IconButton iconButtonThemChucDanh;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiemCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn macdnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencd;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaicd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybdlam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn macd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mach;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvql;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}