namespace demo140421.Forms
{
    partial class FormHoaDonBan
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
            this.mahdbct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maspct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmauct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensizect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienhdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoa = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.manv,
            this.makh,
            this.ngaylap,
            this.chietkhau,
            this.tongtien,
            this.trangthai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 159);
            this.dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(629, 484);
            this.dgvHoaDon.TabIndex = 49;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // mahdb
            // 
            this.mahdb.DataPropertyName = "MaHD";
            this.mahdb.HeaderText = "Mã HĐ";
            this.mahdb.Name = "mahdb";
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
            // chietkhau
            // 
            this.chietkhau.DataPropertyName = "ChietKhau";
            this.chietkhau.HeaderText = "Chiết khấu";
            this.chietkhau.Name = "chietkhau";
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
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(195, 81);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(321, 22);
            this.dtpNgayLap.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(8, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 60;
            this.label10.Text = "Ngày lập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.iconButtonSua);
            this.panel2.Controls.Add(this.iconButtonXoa);
            this.panel2.Controls.Add(this.dgvHoaDon);
            this.panel2.Controls.Add(this.iconPictureBoxSearch);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 728);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.txtTongSL);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dgvCTHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(647, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 728);
            this.panel3.TabIndex = 53;
            // 
            // txtTongSL
            // 
            this.txtTongSL.Enabled = false;
            this.txtTongSL.Location = new System.Drawing.Point(300, 79);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(108, 22);
            this.txtTongSL.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
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
            // dgvCTHoaDon
            // 
            this.dgvCTHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHoaDon.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCTHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdbct,
            this.maspct,
            this.tenmauct,
            this.tensizect,
            this.giact,
            this.soluongct,
            this.thanhtienhdb});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHoaDon.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCTHoaDon.EnableHeadersVisualStyles = false;
            this.dgvCTHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.Location = new System.Drawing.Point(17, 159);
            this.dgvCTHoaDon.Name = "dgvCTHoaDon";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCTHoaDon.RowTemplate.Height = 24;
            this.dgvCTHoaDon.Size = new System.Drawing.Size(587, 484);
            this.dgvCTHoaDon.TabIndex = 29;
            // 
            // mahdbct
            // 
            this.mahdbct.DataPropertyName = "MaHD";
            this.mahdbct.HeaderText = "Mã HĐ";
            this.mahdbct.Name = "mahdbct";
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
            this.iconButtonSua.Location = new System.Drawing.Point(186, 649);
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
            this.iconButtonXoa.Location = new System.Drawing.Point(12, 649);
            this.iconButtonXoa.Name = "iconButtonXoa";
            this.iconButtonXoa.Size = new System.Drawing.Size(168, 50);
            this.iconButtonXoa.TabIndex = 57;
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
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Mã Hóa Đơn";
            // 
            // FormHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.panel2);
            this.Name = "FormHoaDonBan";
            this.Text = "Hóa đơn bán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private FontAwesome.Sharp.IconButton iconButtonXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTongSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCTHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdbct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmauct;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensizect;
        private System.Windows.Forms.DataGridViewTextBoxColumn giact;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongct;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienhdb;
    }
}