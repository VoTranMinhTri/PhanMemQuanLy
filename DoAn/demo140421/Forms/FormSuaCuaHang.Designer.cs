namespace demo140421.Forms
{
    partial class FormSuaCuaHang
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonSuaNCC = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(16, 193);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(333, 22);
            this.txtDiaChi.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 133;
            this.label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 132;
            this.label2.Text = "Tên CH";
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(16, 129);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(333, 22);
            this.txtTenCH.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Mã CH";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(16, 65);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(333, 22);
            this.txtMaCH.TabIndex = 129;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbTrangThai.Location = new System.Drawing.Point(49, 257);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(55, 21);
            this.cbTrangThai.TabIndex = 139;
            this.cbTrangThai.Text = "Còn";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 138;
            this.label7.Text = "Trạng thái";
            // 
            // iconButtonSuaNCC
            // 
            this.iconButtonSuaNCC.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonSuaNCC.FlatAppearance.BorderSize = 0;
            this.iconButtonSuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSuaNCC.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaNCC.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonSuaNCC.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSuaNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSuaNCC.IconSize = 32;
            this.iconButtonSuaNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaNCC.Location = new System.Drawing.Point(16, 292);
            this.iconButtonSuaNCC.Name = "iconButtonSuaNCC";
            this.iconButtonSuaNCC.Size = new System.Drawing.Size(333, 50);
            this.iconButtonSuaNCC.TabIndex = 137;
            this.iconButtonSuaNCC.Text = "Sửa";
            this.iconButtonSuaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSuaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSuaNCC.UseVisualStyleBackColor = false;
            this.iconButtonSuaNCC.Click += new System.EventHandler(this.iconButtonSuaNCC_Click);
            // 
            // FormSuaCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(361, 374);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButtonSuaNCC);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaCH);
            this.Name = "FormSuaCuaHang";
            this.Text = "Form sửa cửa hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButtonSuaNCC;
    }
}