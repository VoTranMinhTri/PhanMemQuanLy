namespace demo140421.Forms
{
    partial class FormSuaHoaDonNhap
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
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cbTenNCC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(19, 196);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(330, 22);
            this.dtpNgayLap.TabIndex = 163;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbTrangThai.Location = new System.Drawing.Point(50, 260);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(55, 21);
            this.cbTrangThai.TabIndex = 160;
            this.cbTrangThai.Text = "Còn";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(15, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 159;
            this.label7.Text = "Trạng thái";
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
            this.iconButtonSua.Location = new System.Drawing.Point(19, 295);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(330, 50);
            this.iconButtonSua.TabIndex = 158;
            this.iconButtonSua.Text = "Sửa";
            this.iconButtonSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(15, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 152;
            this.label2.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 150;
            this.label1.Text = "Mã HĐ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(19, 68);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(330, 22);
            this.txtMaHD.TabIndex = 149;
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.FormattingEnabled = true;
            this.cbTenNCC.Location = new System.Drawing.Point(19, 130);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(330, 24);
            this.cbTenNCC.TabIndex = 164;
            // 
            // FormSuaHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(361, 376);
            this.Controls.Add(this.cbTenNCC);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButtonSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Name = "FormSuaHoaDonNhap";
            this.Text = "Form sửa hóa đơn nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButtonSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cbTenNCC;
    }
}