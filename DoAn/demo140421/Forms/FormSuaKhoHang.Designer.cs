namespace demo140421.Forms
{
    partial class FormSuaKhoHang
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.iconButtonSua = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(19, 125);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(330, 22);
            this.txtSoLuong.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(19, 61);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(330, 22);
            this.txtMaSP.TabIndex = 72;
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
            this.iconButtonSua.Location = new System.Drawing.Point(19, 161);
            this.iconButtonSua.Name = "iconButtonSua";
            this.iconButtonSua.Size = new System.Drawing.Size(330, 50);
            this.iconButtonSua.TabIndex = 70;
            this.iconButtonSua.Text = "Sửa";
            this.iconButtonSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSua.UseVisualStyleBackColor = false;
            this.iconButtonSua.Click += new System.EventHandler(this.iconButtonSua_Click);
            // 
            // FormSuaKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(361, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.iconButtonSua);
            this.Name = "FormSuaKhoHang";
            this.Text = "Form sửa kho hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private FontAwesome.Sharp.IconButton iconButtonSua;
    }
}