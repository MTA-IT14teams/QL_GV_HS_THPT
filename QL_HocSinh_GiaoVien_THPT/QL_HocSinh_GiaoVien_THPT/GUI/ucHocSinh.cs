using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class ucHocSinh : UserControl
    {
        bool themmoi = false;
        public ucHocSinh()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public void Ketnoi()
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();
            string sql = "Select *from tblHocSinh";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHS.DataSource = dt;
            conn.Close();
        }
       
        public void LockControl()
        {
            txtMaHS.Enabled = false;
            txtTenHS.Enabled = false;
            txtMaLp.Enabled = false;
            txtDT.Enabled = false;
            txtDC.Enabled = false;
            cboTG.Enabled = false;

        }
        public void UnLockControl()
        {
            txtMaHS.Enabled = true;
            txtMaLp.Enabled = true;
            txtDT.Enabled = true;
            txtTenHS.Enabled = true;
            txtDC.Enabled = true;
            cboTG.Enabled = true;
        }
        public void Setnull()
        {
            txtMaHS.Text = "";
          
            txtTenHS.Text = "";
            txtDC.Text = "";
            dtpNgaySinh.Value = new DateTime(1900, 1, 1);
        }
       private void Show_CboTG( string mahs)
        {
           
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select MaHS, TonGiao from tblHocSinh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboTG.DataSource = dt;
            cboTG.DisplayMember = "TonGiao";
            cboTG.ValueMember = "TonGiao";

        }
        private void ucHocSinh_Load(object sender, EventArgs e)
        {
            Ketnoi();
            LockControl();
            Show_CboTG("");
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            txtMaHS.Enabled = true;
            btnLuu.Enabled = true;
            btnThayDoi.Enabled = false;
            btnXoa.Enabled = false;
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();

            txtMaHS.Focus();
            UnLockControl();
            Setnull();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnThayDoi.Enabled = true;
                Setnull();
                LockControl();/*không cho thao tác*/
              //  Ketnoi();

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Ketnoi();
            LockControl();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnThayDoi.Enabled = true;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            themmoi = false;
            txtMaHS.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();

           // txtMaHS.Focus();
            UnLockControl();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if(txtMaHS.Text == ""|| txtTenHS.Text == "")
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin");
                LockControl();
                return;
            }
            else
            {
            if(themmoi==true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ThemHS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ma", txtMaHS.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenHS.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@Malop", txtMaLp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Dantoc", txtDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tongiao", cboTG.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diachi", txtDC.Text.Trim());

                    cmd.ExecuteNonQuery();

                    Ketnoi();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (themmoi == false)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_ThayDoi", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ma", txtMaHS.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenHS.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ngaysinh", dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@Malop", txtMaLp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Dantoc", txtDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@Tongiao", cboTG.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diachi", txtDC.Text.Trim());

                    cmd.ExecuteNonQuery();

                    Ketnoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }
               

        }

        
         
        

        private void dgvHS_CellClick(object sendesr, DataGridViewCellEventArgs e)
        {
            //dong = e.RowIndex;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHS.Text = dgvHS.CurrentRow.Cells["MaHS"].Value.ToString();
                txtTenHS.Text = dgvHS.CurrentRow.Cells["TenHS"].Value.ToString();
                txtTenHS.Text = Convert.ToString(dgvHS.CurrentRow.Cells["TenHS"].Value); 
                if (dgvHS.Rows[e.RowIndex].Cells["GT"].Value.ToString() == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                dtpNgaySinh.Text = dgvHS.CurrentRow.Cells["NgaySinh"].Value.ToString();
               txtMaLp.Text= dgvHS.CurrentRow.Cells["MaLop"].Value.ToString();
               txtDT.Text = dgvHS.CurrentRow.Cells["DanToc"].Value.ToString();
                Show_CboTG(dgvHS.CurrentRow.Cells["TonGiao"].Value.ToString());
                txtDC.Text = dgvHS.CurrentRow.Cells["DiaChi"].Value.ToString();

               
 
            }
            
        }

        

       

      
       /* private void cboTG_Click(object sender, EventArgs e)
        {
            Show_CboTG("");
        }*/
        string sql = "";
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
                
            {
                SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
                conn.Open();
                if(cboTimkiem.Text=="Mã Học Sinh")
                    sql = "select *from tblHocSinh where MaHS = '" + txtTimKiem.Text.Trim() + "'";
                else if(cboTimkiem.Text=="Tên Học Sinh")
                    sql = "select *from tblHocSinh where TenHS like N'%" + txtTimKiem.Text.Trim() + "%'";
                else if(cboTimkiem.Text=="Mã Lớp")
                    sql = "select *from tblHocSinh where MaLop = '" + txtTimKiem.Text.Trim() + "'";
                else if(cboTimkiem.Text=="Dân Tộc")
                    sql = "select *from tblHocSinh where DanToc = '" + txtTimKiem.Text.Trim() + "'";
                else if(cboTimkiem.Text=="Tôn Giáo")
                    sql = "select *from tblHocSinh where TonGiao = '" + txtTimKiem.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHS.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void cboTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(null, null);
        }

        private void cboTG_Click_1(object sender, EventArgs e)
        {
            Show_CboTG("");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_XoaHS", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Ma", txtMaHS.Text.Trim());

                    cmd.ExecuteNonQuery();

                    Ketnoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
      

       
    }
}
