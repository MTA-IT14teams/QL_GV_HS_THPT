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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ucThem = new System.Windows.Forms.Button();
            this.ucSua = new System.Windows.Forms.Button();
            this.ucXoa = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.ucTimKiem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(453, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ucThem
            // 
            this.ucThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucThem.Image = ((System.Drawing.Image)(resources.GetObject("ucThem.Image")));
            this.ucThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucThem.Location = new System.Drawing.Point(387, 101);
            this.ucThem.Name = "ucThem";
            this.ucThem.Size = new System.Drawing.Size(75, 36);
            this.ucThem.TabIndex = 3;
            this.ucThem.Text = "Thêm";
            this.ucThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucThem.UseVisualStyleBackColor = false;
            this.ucThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucSua
            // 
            this.ucSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucSua.ForeColor = System.Drawing.Color.Black;
            this.ucSua.Image = ((System.Drawing.Image)(resources.GetObject("ucSua.Image")));
            this.ucSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucSua.Location = new System.Drawing.Point(468, 101);
            this.ucSua.Name = "ucSua";
            this.ucSua.Size = new System.Drawing.Size(75, 36);
            this.ucSua.TabIndex = 3;
            this.ucSua.Text = "Sửa";
            this.ucSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucSua.UseVisualStyleBackColor = false;
            this.ucSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucXoa
            // 
            this.ucXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucXoa.Image = ((System.Drawing.Image)(resources.GetObject("ucXoa.Image")));
            this.ucXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucXoa.Location = new System.Drawing.Point(549, 101);
            this.ucXoa.Name = "ucXoa";
            this.ucXoa.Size = new System.Drawing.Size(75, 36);
            this.ucXoa.TabIndex = 3;
            this.ucXoa.Text = "Xóa";
            this.ucXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucXoa.UseVisualStyleBackColor = false;
            this.ucXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uc.Image = ((System.Drawing.Image)(resources.GetObject("uc.Image")));
            this.uc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uc.Location = new System.Drawing.Point(630, 101);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(75, 36);
            this.uc.TabIndex = 3;
            this.uc.Text = "Refresh";
            this.uc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uc.UseVisualStyleBackColor = false;
            this.uc.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(711, 110);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(100, 20);
            this.TimKiem.TabIndex = 5;
            this.TimKiem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ucTimKiem
            // 
            this.ucTimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("ucTimKiem.Image")));
            this.ucTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucTimKiem.Location = new System.Drawing.Point(817, 101);
            this.ucTimKiem.Name = "ucTimKiem";
            this.ucTimKiem.Size = new System.Drawing.Size(75, 36);
            this.ucTimKiem.TabIndex = 3;
            this.ucTimKiem.Text = "Tìm Kiếm";
            this.ucTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucTimKiem.UseVisualStyleBackColor = false;
            this.ucTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Username,
            this.Password});
            this.dataGridView.Location = new System.Drawing.Point(387, 153);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(505, 300);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.ucSua);
            this.Controls.Add(this.ucXoa);
            this.Controls.Add(this.ucTimKiem);
            this.Controls.Add(this.ucThem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(946, 485);
            this.Load += new System.EventHandler(this.ucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ucThem;
        private System.Windows.Forms.Button ucSua;
        private System.Windows.Forms.Button ucXoa;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.Button ucTimKiem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Diagnostics.EventLog eventLog1;
    }
}
