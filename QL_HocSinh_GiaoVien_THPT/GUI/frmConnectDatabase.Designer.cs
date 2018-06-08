namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    partial class frmConnectDatabase
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbxChonTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTenCSDL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMayChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Authentication";
            // 
            // cbxChonTaiKhoan
            // 
            this.cbxChonTaiKhoan.FormattingEnabled = true;
            this.cbxChonTaiKhoan.Items.AddRange(new object[] {
            "Window Authentication",
            "SQL Server Authentication"});
            this.cbxChonTaiKhoan.Location = new System.Drawing.Point(176, 77);
            this.cbxChonTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.cbxChonTaiKhoan.Name = "cbxChonTaiKhoan";
            this.cbxChonTaiKhoan.Size = new System.Drawing.Size(361, 23);
            this.cbxChonTaiKhoan.TabIndex = 24;
            this.cbxChonTaiKhoan.Text = "Window Authentication";
            this.cbxChonTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbxChonTaiKhoan_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(457, 320);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 34);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(343, 320);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 35);
            this.btnDangNhap.TabIndex = 22;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTenCSDL
            // 
            this.txtTenCSDL.Location = new System.Drawing.Point(176, 267);
            this.txtTenCSDL.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenCSDL.Name = "txtTenCSDL";
            this.txtTenCSDL.Size = new System.Drawing.Size(361, 22);
            this.txtTenCSDL.TabIndex = 21;
            this.txtTenCSDL.Text = "QL_GV_HS_THPT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(77, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên CSDL";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(303, 194);
            this.txtMK.Margin = new System.Windows.Forms.Padding(5);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(234, 22);
            this.txtMK.TabIndex = 19;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(303, 139);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(234, 22);
            this.txtTenDangNhap.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Location = new System.Drawing.Point(176, 14);
            this.txtTenMayChu.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(361, 22);
            this.txtTenMayChu.TabIndex = 15;
            this.txtTenMayChu.TextChanged += new System.EventHandler(this.txtTenMayChu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(94, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server";
            // 
            // frmConnectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxChonTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTenCSDL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenMayChu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConnectDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectDatabase";
            this.Load += new System.EventHandler(this.frmConnectDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxChonTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTenCSDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMayChu;
        private System.Windows.Forms.Label label1;
    }
}