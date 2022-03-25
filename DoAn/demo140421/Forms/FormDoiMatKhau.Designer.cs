namespace demo140421.Forms
{
    partial class FormDoiMatKhau
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
            this.ckMK = new System.Windows.Forms.CheckBox();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.iconButtonDoiMatKhau = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckMK
            // 
            this.ckMK.AutoSize = true;
            this.ckMK.ForeColor = System.Drawing.Color.Gainsboro;
            this.ckMK.Location = new System.Drawing.Point(18, 317);
            this.ckMK.Name = "ckMK";
            this.ckMK.Size = new System.Drawing.Size(83, 21);
            this.ckMK.TabIndex = 148;
            this.ckMK.Text = "Hiện MK";
            this.ckMK.UseVisualStyleBackColor = true;
            this.ckMK.CheckedChanged += new System.EventHandler(this.ckMK_CheckedChanged);
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(17, 279);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(330, 22);
            this.txtXacNhan.TabIndex = 147;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(14, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "Xác nhận password mới";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(330, 22);
            this.txtPassword.TabIndex = 145;
            // 
            // iconButtonDoiMatKhau
            // 
            this.iconButtonDoiMatKhau.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.iconButtonDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDoiMatKhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDoiMatKhau.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButtonDoiMatKhau.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDoiMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDoiMatKhau.IconSize = 32;
            this.iconButtonDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDoiMatKhau.Location = new System.Drawing.Point(17, 354);
            this.iconButtonDoiMatKhau.Name = "iconButtonDoiMatKhau";
            this.iconButtonDoiMatKhau.Size = new System.Drawing.Size(330, 50);
            this.iconButtonDoiMatKhau.TabIndex = 144;
            this.iconButtonDoiMatKhau.Text = "Đổi mật khẩu";
            this.iconButtonDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDoiMatKhau.UseVisualStyleBackColor = false;
            this.iconButtonDoiMatKhau.Click += new System.EventHandler(this.iconButtonDoiMatKhau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 143;
            this.label3.Text = "Password mới";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(330, 22);
            this.txtUsername.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "Username";
            // 
            // txtPasswordCu
            // 
            this.txtPasswordCu.Location = new System.Drawing.Point(17, 131);
            this.txtPasswordCu.Name = "txtPasswordCu";
            this.txtPasswordCu.PasswordChar = '*';
            this.txtPasswordCu.Size = new System.Drawing.Size(330, 22);
            this.txtPasswordCu.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Password cũ";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(361, 442);
            this.Controls.Add(this.txtPasswordCu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckMK);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.iconButtonDoiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Name = "FormDoiMatKhau";
            this.Text = "Form đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckMK;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton iconButtonDoiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordCu;
        private System.Windows.Forms.Label label1;
    }
}