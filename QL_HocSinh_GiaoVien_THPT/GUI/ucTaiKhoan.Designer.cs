namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    partial class ucTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.ucThem = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ucSua = new System.Windows.Forms.Button();
            this.ucXoa = new System.Windows.Forms.Button();
            this.ucTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucRefresh = new System.Windows.Forms.Button();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(436, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(102, 180);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(191, 20);
            this.txtMaGV.TabIndex = 2;
            this.txtMaGV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(102, 257);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(191, 20);
            this.txtQuyen.TabIndex = 2;
            this.txtQuyen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ucThem
            // 
            this.ucThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucThem.Image = ((System.Drawing.Image)(resources.GetObject("ucThem.Image")));
            this.ucThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucThem.Location = new System.Drawing.Point(328, 101);
            this.ucThem.Name = "ucThem";
            this.ucThem.Size = new System.Drawing.Size(77, 46);
            this.ucThem.TabIndex = 3;
            this.ucThem.Text = "Thêm";
            this.ucThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucThem.UseVisualStyleBackColor = false;
            this.ucThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MaGV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 257);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quyen";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 20);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(191, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ucSua
            // 
            this.ucSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucSua.Image = ((System.Drawing.Image)(resources.GetObject("ucSua.Image")));
            this.ucSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucSua.Location = new System.Drawing.Point(421, 101);
            this.ucSua.Name = "ucSua";
            this.ucSua.Size = new System.Drawing.Size(71, 46);
            this.ucSua.TabIndex = 11;
            this.ucSua.Text = "Sửa";
            this.ucSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucSua.UseVisualStyleBackColor = false;
            this.ucSua.Click += new System.EventHandler(this.ucSua_Click);
            // 
            // ucXoa
            // 
            this.ucXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucXoa.Image = ((System.Drawing.Image)(resources.GetObject("ucXoa.Image")));
            this.ucXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucXoa.Location = new System.Drawing.Point(509, 101);
            this.ucXoa.Name = "ucXoa";
            this.ucXoa.Size = new System.Drawing.Size(74, 46);
            this.ucXoa.TabIndex = 12;
            this.ucXoa.Text = "Xóa";
            this.ucXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucXoa.UseVisualStyleBackColor = false;
            this.ucXoa.Click += new System.EventHandler(this.ucXoa_Click);
            // 
            // ucTimKiem
            // 
            this.ucTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("ucTimKiem.Image")));
            this.ucTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucTimKiem.Location = new System.Drawing.Point(850, 107);
            this.ucTimKiem.Name = "ucTimKiem";
            this.ucTimKiem.Size = new System.Drawing.Size(88, 34);
            this.ucTimKiem.TabIndex = 14;
            this.ucTimKiem.Text = "Tìm Kiếm";
            this.ucTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucTimKiem.UseVisualStyleBackColor = false;
            this.ucTimKiem.Click += new System.EventHandler(this.ucTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.txtQuyen);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 339);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ucRefresh
            // 
            this.ucRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ucRefresh.Image")));
            this.ucRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucRefresh.Location = new System.Drawing.Point(591, 101);
            this.ucRefresh.Name = "ucRefresh";
            this.ucRefresh.Size = new System.Drawing.Size(90, 46);
            this.ucRefresh.TabIndex = 13;
            this.ucRefresh.Text = "Refresh";
            this.ucRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucRefresh.UseVisualStyleBackColor = false;
            this.ucRefresh.Click += new System.EventHandler(this.ucRefresh_Click);
            // 
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyen";
            this.Quyen.Name = "Quyen";
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "MaGV";
            this.MaGV.Name = "MaGV";
            // 
            // Pasword
            // 
            this.Pasword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pasword.DataPropertyName = "Password";
            this.Pasword.HeaderText = "Password";
            this.Pasword.Name = "Pasword";
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Pasword,
            this.MaGV,
            this.Quyen});
            this.dataGridView1.Location = new System.Drawing.Point(328, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 287);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(944, 115);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 18;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucTimKiem);
            this.Controls.Add(this.ucRefresh);
            this.Controls.Add(this.ucXoa);
            this.Controls.Add(this.ucSua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucThem);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(1065, 500);
            this.Load += new System.EventHandler(this.ucTaiKhoan_Load);
            this.Click += new System.EventHandler(this.ucTaiKhoan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button ucThem;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button ucXoa;
        private System.Windows.Forms.Button ucSua;
        private System.Windows.Forms.Button ucTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ucRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasword;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
