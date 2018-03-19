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
    public partial class ucTaiKhoan : UserControl
    {
        public ucTaiKhoan()
        {
            InitializeComponent();
        }
        //kết nối
        private void KetNoi()
        {
            try
            {
                DTO.Connect.myconnect.Open();
                string sql = "select *from tblUser";
                SqlCommand cmd = new SqlCommand(sql, DTO.Connect.myconnect);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //load data
        private void LoadData()
        {
            txtuser.DataBindings.Clear();  // xóa dữ liệu có sẵn trong textbox
            txtuser.DataBindings.Add("Text",dataGridView.DataSource, "Username");

            txtpassword.DataBindings.Clear();
            txtpassword.DataBindings.Add("Text", dataGridView.DataSource, "Password");
        }
        //load
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            KetNoi();
            LoadData();
        }

        private void dtgUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dtgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.CurrentRow.Selected = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        //Them
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DTO.ConnectString.stringConnect);
                conn.Open();
                string them = "insert into USER values ('" + txtuser.Text + "', N'" + txtpassword.Text + "')";
                SqlCommand cmd = new SqlCommand(them, conn);
                cmd.ExecuteReader();
                KetNoi();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
