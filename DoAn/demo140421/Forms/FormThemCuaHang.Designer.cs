namespace demo140421.Forms
{
    partial class FormThemCuaHang
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
            this.iconButtonThem = new FontAwesome.Sharp.IconButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iconButtonThem
            // 
            this.iconButtonThem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonThem.FlatAppearance.BorderSize = 0;
            this.iconButtonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonThem.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThem.IconSize = 32;
            this.iconButtonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.Location = new System.Drawing.Point(19, 228);
            this.iconButtonThem.Name = "iconButtonThem";
            this.iconButtonThem.Size = new System.Drawing.Size(330, 50);
            this.iconButtonThem.TabIndex = 128;
            this.iconButtonThem.Text = "Thêm";
            this.iconButtonThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThem.UseVisualStyleBackColor = false;
            this.iconButtonThem.Click += new System.EventHandler(this.iconButtonThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(19, 193);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(330, 22);
            this.txtDiaChi.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 123;
            this.label5.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Tên CH";
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(19, 125);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(330, 22);
            this.txtTenCH.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Mã CH";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(19, 57);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(330, 22);
            this.txtMaCH.TabIndex = 118;
            // 
            // FormThemCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(361, 312);
            this.Controls.Add(this.iconButtonThem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaCH);
            this.Name = "FormThemCuaHang";
            this.Text = "Form thêm cửa hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCH;
    }
}