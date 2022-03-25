namespace demo140421.Forms
{
    partial class FormDanhSachChamCong
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
            this.dgvListCC = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.macc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manvcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennvcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCC
            // 
            this.dgvListCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListCC.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macc,
            this.ngaycham,
            this.manv,
            this.tennv,
            this.manvcc,
            this.tennvcc,
            this.tenlc,
            this.sotien,
            this.trangthai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCC.EnableHeadersVisualStyles = false;
            this.dgvListCC.GridColor = System.Drawing.Color.White;
            this.dgvListCC.Location = new System.Drawing.Point(12, 123);
            this.dgvListCC.Name = "dgvListCC";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListCC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCC.RowTemplate.Height = 24;
            this.dgvListCC.Size = new System.Drawing.Size(920, 593);
            this.dgvListCC.TabIndex = 48;
            this.dgvListCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCC_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(321, 22);
            this.txtTimKiem.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.iconButtonSua);
            this.panel2.Controls.Add(this.iconButtonXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(938, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 728);
            this.panel2.TabIndex = 63;
            // 
            // iconButtonSua
            // 
            this.iconButtonSua.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSua.FlatAppearance.BorderSize = 0;
            this.iconButtonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSua.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSua.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSua.IconSize = 32;
            this.iconButtonSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.Location = new System.Drawing.Point(3, 179);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(310, 50);
            this.iconButtonSua.TabIndex = 20;
            this.iconButtonSua.Text = "Sửa";
            this.iconButtonSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // iconButtonXoa
            // 
            this.iconButtonXoa.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonXoa.FlatAppearance.BorderSize = 0;
            this.iconButtonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoa.IconSize = 32;
            this.iconButtonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.Location = new System.Drawing.Point(3, 123);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(310, 50);
            this.iconButtonXoa.TabIndex = 19;
            this.iconButtonXoa.Text = "Xóa";
            this.iconButtonXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonXoa.UseVisualStyleBackColor = false;
            this.iconButtonXoa.Click += new System.EventHandler(this.iconButtonXoa_Click);
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
            this.iconPictureBoxSearch.TabIndex = 53;
            this.iconPictureBoxSearch.TabStop = false;
            this.iconPictureBoxSearch.Click += new System.EventHandler(this.iconPictureBoxSearch_Click);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã CC",
            "Mã NV",
            "Ngày"});
            this.cboTimKiem.Location = new System.Drawing.Point(481, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 202;
            // 
            // macc
            // 
            this.macc.DataPropertyName = "MaCC";
            this.macc.HeaderText = "Mã CC";
            this.macc.Name = "macc";
            // 
            // ngaycham
            // 
            this.ngaycham.DataPropertyName = "NgayCham";
            this.ngaycham.HeaderText = "Ngày chấm";
            this.ngaycham.Name = "ngaycham";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNV";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "HoTenNV";
            this.tennv.HeaderText = "Tên NV";
            this.tennv.Name = "tennv";
            // 
            // manvcc
            // 
            this.manvcc.DataPropertyName = "MaNV_CC";
            this.manvcc.HeaderText = "Mã NV_CC";
            this.manvcc.Name = "manvcc";
            // 
            // tennvcc
            // 
            this.tennvcc.DataPropertyName = "HoTenNVCC";
            this.tennvcc.HeaderText = "Tên NVCC";
            this.tennvcc.Name = "tennvcc";
            // 
            // tenlc
            // 
            this.tenlc.DataPropertyName = "TenLC";
            this.tenlc.HeaderText = "Tên LC";
            this.tenlc.Name = "tenlc";
            // 
            // sotien
            // 
            this.sotien.DataPropertyName = "SoTien";
            this.sotien.HeaderText = "Số tiền";
            this.sotien.Name = "sotien";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "TrangThai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            // 
            // FormDanhSachChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListCC);
            this.Name = "FormDanhSachChamCong";
            this.Text = "Danh sách chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCC)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCC;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn macc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycham;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennvcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}