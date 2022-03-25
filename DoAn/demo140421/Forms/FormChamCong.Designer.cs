namespace demo140421.Forms
{
    partial class FormChamCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvListNV = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCC = new System.Windows.Forms.TextBox();
            this.txtMaNVCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLoaiCham = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonChamCong = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(321, 22);
            this.txtTimKiem.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 48;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListNV.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListNV.EnableHeadersVisualStyles = false;
            this.dgvListNV.GridColor = System.Drawing.Color.White;
            this.dgvListNV.Location = new System.Drawing.Point(12, 123);
            this.dgvListNV.Name = "dgvListNV";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListNV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListNV.RowTemplate.Height = 24;
            this.dgvListNV.Size = new System.Drawing.Size(920, 593);
            this.dgvListNV.TabIndex = 47;
            this.dgvListNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListNV_CellClick);
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
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã chấm công";
            // 
            // txtMaCC
            // 
            this.txtMaCC.Enabled = false;
            this.txtMaCC.Location = new System.Drawing.Point(6, 151);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.Size = new System.Drawing.Size(307, 22);
            this.txtMaCC.TabIndex = 53;
            // 
            // txtMaNVCC
            // 
            this.txtMaNVCC.Enabled = false;
            this.txtMaNVCC.Location = new System.Drawing.Point(6, 212);
            this.txtMaNVCC.Name = "txtMaNVCC";
            this.txtMaNVCC.Size = new System.Drawing.Size(307, 22);
            this.txtMaNVCC.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Mã NV chấm công";
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Enabled = false;
            this.dtpNgayCham.Location = new System.Drawing.Point(6, 334);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.Size = new System.Drawing.Size(307, 22);
            this.dtpNgayCham.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ngày chấm";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(6, 273);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(307, 22);
            this.txtMaNV.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(3, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Loại chấm công";
            // 
            // cboLoaiCham
            // 
            this.cboLoaiCham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiCham.FormattingEnabled = true;
            this.cboLoaiCham.Location = new System.Drawing.Point(5, 395);
            this.cboLoaiCham.Name = "cboLoaiCham";
            this.cboLoaiCham.Size = new System.Drawing.Size(308, 24);
            this.cboLoaiCham.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.iconButtonChamCong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboLoaiCham);
            this.panel2.Controls.Add(this.txtMaCC);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.txtMaNVCC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpNgayCham);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(938, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 728);
            this.panel2.TabIndex = 62;
            // 
            // iconButtonChamCong
            // 
            this.iconButtonChamCong.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonChamCong.FlatAppearance.BorderSize = 0;
            this.iconButtonChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChamCong.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonChamCong.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconButtonChamCong.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonChamCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChamCong.IconSize = 32;
            this.iconButtonChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChamCong.Location = new System.Drawing.Point(3, 433);
            this.iconButtonChamCong.Name = "iconButtonChamCong";
            this.iconButtonChamCong.Size = new System.Drawing.Size(313, 50);
            this.iconButtonChamCong.TabIndex = 62;
            this.iconButtonChamCong.Text = "Chấm công";
            this.iconButtonChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChamCong.UseVisualStyleBackColor = false;
            this.iconButtonChamCong.Click += new System.EventHandler(this.iconButtonChamCong_Click);
            // 
            // iconPictureBoxSearch
            // 
            this.iconPictureBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBoxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBoxSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSearch.Location = new System.Drawing.Point(579, 38);
            this.iconPictureBoxSearch.Name = "iconPictureBoxSearch";
            this.iconPictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBoxSearch.TabIndex = 50;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã NV",
            "Họ tên"});
            this.cboTimKiem.Location = new System.Drawing.Point(481, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 63;
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListNV);
            this.Name = "FormChamCong";
            this.Text = "Chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvListNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCC;
        private System.Windows.Forms.TextBox txtMaNVCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiCham;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonChamCong;
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
        private System.Windows.Forms.ComboBox cboTimKiem;
    }
}