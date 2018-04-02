namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    partial class ucThoiKhoaBieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(434, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời Khóa Biểu";
            // 
            // dgvTKB
            // 
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thu,
            this.Tiet,
            this.TenGV,
            this.TenMon});
            this.dgvTKB.Location = new System.Drawing.Point(66, 139);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.Size = new System.Drawing.Size(889, 360);
            this.dgvTKB.TabIndex = 9;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(102, 72);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(121, 21);
            this.cbbLop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QL_HocSinh_GiaoVien_THPT.Properties.Resources.find__1_;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(262, 72);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(70, 33);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.Name = "Thu";
            // 
            // Tiet
            // 
            this.Tiet.DataPropertyName = "Tiet";
            this.Tiet.HeaderText = "Tiết";
            this.Tiet.Name = "Tiet";
            // 
            // TenGV
            // 
            this.TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Môn Học";
            this.TenMon.Name = "TenMon";
            // 
            // ucThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucThoiKhoaBieu";
            this.Size = new System.Drawing.Size(1025, 513);
            this.Load += new System.EventHandler(this.ucThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
    }
}
