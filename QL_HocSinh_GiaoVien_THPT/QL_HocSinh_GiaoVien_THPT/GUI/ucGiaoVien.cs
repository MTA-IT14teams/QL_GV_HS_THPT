using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class ucGiaoVien : UserControl
    {
        public ucGiaoVien()
        {
            InitializeComponent();
        }

        public void Khoa()
        {
            txtMaGV.Enabled = false;
            txtTen.Enabled = false ;
            txtDiaChi.Enabled = false;
            txtSDT.ReadOnly = false;
            txtLuong.ReadOnly = false;
        }
        public void Mo()
        {
            txtMaGV.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.ReadOnly = true;
            txtLuong.ReadOnly = true;
        }

        public void Ketnoi()
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();
            string sql = "Select *from tblGiaovien";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGiaoVien.DataSource = dt;
        }
        public void LoadData()
        {
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", dgvGiaoVien.DataSource, "MaGV");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvGiaoVien.DataSource, "TenGV");

            cboGT.DataBindings.Clear();
            cboGT.DataBindings.Add("Text", dgvGiaoVien.DataSource, "GT");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvGiaoVien.DataSource, "NgaySinh");

            cboMamon.DataBindings.Clear();
            cboMamon.DataBindings.Add("Text",dgvGiaoVien.DataSource,"MaMon");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text",dgvGiaoVien.DataSource,"SDT");

            txtLuong.DataBindings.Clear();
            txtLuong.DataBindings.Add("Text",dgvGiaoVien.DataSource,"Luong");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvGiaoVien.DataSource, "DiaChi");
        }
        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            Khoa();
            Ketnoi();
            LoadData();
        }


        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvGiaoVien.CurrentRow.Selected = true;
            }
            catch { }
        }
        public void SetNull()
        {
            txtMaGV.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            dtpNgaySinh.Value = new DateTime(1900, 1, 1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ////Lấy mã môn học
            //SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            //conn.Open();
            //string sql = "Select *from tblMonhoc";
            //cboMamon.DataSource = sql;
            //cboMamon.DisplayMember = "MaMon";
            //cboMamon.ValueMember = "MaMon";

            txtMaGV.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaGV.Focus();
            Mo();
            SetNull();
            txtLuong.Text = "1000000";
           // conn.Close();
            //Thêm GV
            try
            {
                SqlConnection connT = new SqlConnection(DTO.ConnectionString.stringConnect);
                connT.Open();
                string them = "insert into tblGiaovien values ('" + txtMaGV.Text.Trim() + "', N'" + txtTen.Text.Trim() 
                    + "', '" + cboGT.Text.Trim() + "', '" + dtpNgaySinh.Text.Trim() + "',N'" +
                    txtSDT.Text.Trim()+ ","+
                    txtDiaChi.Text.Trim() + "', '" + txtLuong.Text.Trim() + "', '" + 
                    cboMamon.Text.Trim() + "')";
                SqlCommand comm = new SqlCommand(them, connT);
                SqlDataAdapter daThem = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                daThem.Fill(dt);
                dgvGiaoVien.DataSource = dt;
                Ketnoi();
                LoadData();
                connT.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


    }
}
