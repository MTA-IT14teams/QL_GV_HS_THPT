namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    partial class ucGiangDay
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
            this.cboXemLop = new System.Windows.Forms.ComboBox();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboXemTheoThu = new System.Windows.Forms.ComboBox();
            this.cboXemGiaoVien = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet = new System.Data.DataSet();
            this.pnTittle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnInput = new System.Windows.Forms.Panel();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboGiaoVien = new System.Windows.Forms.ComboBox();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnTittle.SuspendLayout();
            this.pnInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboXemLop
            // 
            this.cboXemLop.FormattingEnabled = true;
            this.cboXemLop.Location = new System.Drawing.Point(208, 46);
            this.cboXemLop.Name = "cboXemLop";
            this.cboXemLop.Size = new System.Drawing.Size(103, 21);
            this.cboXemLop.TabIndex = 1;
            this.cboXemLop.SelectedIndexChanged += new System.EventHandler(this.cboXemLop_SelectedIndexChanged);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // idthu
            // 
            this.idthu.DataPropertyName = "idthu";
            this.idthu.HeaderText = "ID Thứ";
            this.idthu.Name = "idthu";
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            this.Thu.Width = 60;
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tiet";
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            this.Tiet.Width = 60;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 70;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Môn Học";
            this.TenMon.Name = "TenMon";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 60;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.label4);
            this.pnDisplay.Controls.Add(this.label3);
            this.pnDisplay.Controls.Add(this.label2);
            this.pnDisplay.Controls.Add(this.label1);
            this.pnDisplay.Controls.Add(this.btnFilter);
            this.pnDisplay.Controls.Add(this.cboXemTheoThu);
            this.pnDisplay.Controls.Add(this.cboXemGiaoVien);
            this.pnDisplay.Controls.Add(this.cboXemLop);
            this.pnDisplay.Controls.Add(this.dgvData);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplay.Location = new System.Drawing.Point(283, 64);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(742, 449);
            this.pnDisplay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xem Theo Thứ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xem Theo Giáo Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xem Theo Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xem Thông Tin:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(659, 44);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Tất Cả";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboXemTheoThu
            // 
            this.cboXemTheoThu.FormattingEnabled = true;
            this.cboXemTheoThu.Location = new System.Drawing.Point(534, 46);
            this.cboXemTheoThu.Name = "cboXemTheoThu";
            this.cboXemTheoThu.Size = new System.Drawing.Size(101, 21);
            this.cboXemTheoThu.TabIndex = 3;
            this.cboXemTheoThu.SelectedIndexChanged += new System.EventHandler(this.cboXemTheoThu_SelectedIndexChanged);
            // 
            // cboXemGiaoVien
            // 
            this.cboXemGiaoVien.FormattingEnabled = true;
            this.cboXemGiaoVien.Location = new System.Drawing.Point(364, 46);
            this.cboXemGiaoVien.Name = "cboXemGiaoVien";
            this.cboXemGiaoVien.Size = new System.Drawing.Size(110, 21);
            this.cboXemGiaoVien.TabIndex = 2;
            this.cboXemGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cboXemGiaoVien_SelectedIndexChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.TenLop,
            this.MaLop,
            this.idthu,
            this.Thu,
            this.Tiet,
            this.MaMon,
            this.TenMon});
            this.dgvData.Location = new System.Drawing.Point(3, 86);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(734, 402);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã";
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 60;
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DatasetQL";
            // 
            // pnTittle
            // 
            this.pnTittle.Controls.Add(this.label5);
            this.pnTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTittle.Location = new System.Drawing.Point(277, 0);
            this.pnTittle.Name = "pnTittle";
            this.pnTittle.Size = new System.Drawing.Size(748, 64);
            this.pnTittle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(285, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quản Lý Lịch Giảng Dạy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.cboThu);
            this.pnInput.Controls.Add(this.btnDelete);
            this.pnInput.Controls.Add(this.btnUpdate);
            this.pnInput.Controls.Add(this.btnAdd);
            this.pnInput.Controls.Add(this.label10);
            this.pnInput.Controls.Add(this.label9);
            this.pnInput.Controls.Add(this.label8);
            this.pnInput.Controls.Add(this.label7);
            this.pnInput.Controls.Add(this.label6);
            this.pnInput.Controls.Add(this.txtTiet);
            this.pnInput.Controls.Add(this.cboLop);
            this.pnInput.Controls.Add(this.cboGiaoVien);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInput.Location = new System.Drawing.Point(0, 0);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(277, 513);
            this.pnInput.TabIndex = 5;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Location = new System.Drawing.Point(103, 252);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(138, 21);
            this.cboThu.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 407);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 407);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(75, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Chi Tiết";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thứ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giáo Viên:";
            // 
            // txtTiet
            // 
            this.txtTiet.Location = new System.Drawing.Point(103, 328);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(138, 20);
            this.txtTiet.TabIndex = 2;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(103, 169);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(138, 21);
            this.cboLop.TabIndex = 1;
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.Location = new System.Drawing.Point(103, 89);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(138, 21);
            this.cboGiaoVien.TabIndex = 0;
            // 
            // ucGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnTittle);
            this.Controls.Add(this.pnInput);
            this.Name = "ucGiangDay";
            this.Size = new System.Drawing.Size(1025, 513);
            this.Load += new System.EventHandler(this.ucGiangDay_Load);
            this.pnDisplay.ResumeLayout(false);
            this.pnDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnTittle.ResumeLayout(false);
            this.pnTittle.PerformLayout();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboXemLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboXemTheoThu;
        private System.Windows.Forms.ComboBox cboXemGiaoVien;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.Panel pnTittle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboGiaoVien;

    }
}
