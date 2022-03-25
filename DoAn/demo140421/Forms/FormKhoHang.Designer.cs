namespace demo140421.Forms
{
    partial class FormKhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListKho = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBoxSearch = new FontAwesome.Sharp.IconPictureBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButtonSuaCT = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListKho
            // 
            this.dgvListKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListKho.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvListKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.tenmau,
            this.tensize,
            this.soluong});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListKho.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListKho.EnableHeadersVisualStyles = false;
            this.dgvListKho.GridColor = System.Drawing.Color.White;
            this.dgvListKho.Location = new System.Drawing.Point(12, 123);
            this.dgvListKho.Name = "dgvListKho";
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListKho.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListKho.RowTemplate.Height = 24;
            this.dgvListKho.Size = new System.Drawing.Size(920, 593);
            this.dgvListKho.TabIndex = 30;
            this.dgvListKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListKho_CellClick);
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
            this.tensize.HeaderText = "Tên size";
            this.tensize.Name = "tensize";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(154, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(321, 22);
            this.txtTimKiem.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tìm kiếm";
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
            this.iconPictureBoxSearch.TabIndex = 42;
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
            this.cboTimKiem.Location = new System.Drawing.Point(481, 38);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(92, 24);
            this.cboTimKiem.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.iconButtonSuaCT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(938, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 728);
            this.panel3.TabIndex = 54;
            // 
            // iconButtonSuaCT
            // 
            this.iconButtonSuaCT.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaCT.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaCT.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaCT.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaCT.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaCT.IconSize = 32;
            this.iconButtonSuaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaCT.Location = new System.Drawing.Point(3, 123);
            this.iconButtonSuaCT.Name = "iconButtonSuaCT";
            this.iconButtonSuaCT.Size = new System.Drawing.Size(310, 50);
            this.iconButtonSuaCT.TabIndex = 61;
            this.iconButtonSuaCT.Text = "Sửa";
            this.iconButtonSuaCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaCT.UseVisualStyleBackColor = false;
            this.iconButtonSuaCT.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // FormKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconPictureBoxSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvListKho);
            this.Name = "FormKhoHang";
            this.Text = "Kho hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListKho;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensize;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonSuaCT;
    }
}