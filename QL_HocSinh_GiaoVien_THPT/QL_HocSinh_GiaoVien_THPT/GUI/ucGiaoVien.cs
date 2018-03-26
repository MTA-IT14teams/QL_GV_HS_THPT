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
using System.Configuration;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{   
     
    public partial class ucGiaoVien : UserControl
    {
        bool themmoi = false;
        int dong = -1;
        DataTable dtMon = new DataTable();

        public ucGiaoVien()
        {
            InitializeComponent();
        }

        public void Mo_btn()
        {
            //các txt mở lại để nhập
            txtMaGV.ReadOnly = false;
            txtTen.ReadOnly = false ;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtLuong.ReadOnly = false;
        }
        public void Khoa_btn()
        {
            //các txt khóa, ko cho nhập 
            txtMaGV.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtLuong.ReadOnly = true;
        }

        public void LoadGV()
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
            conn.Open();
            string sql = "Select *from tblGiaovien";
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGiaoVien.DataSource = dt;
            conn.Close();
        }

        private void ucGiaoVien_Load(object sender, EventArgs e)
        {
            Khoa_btn();
            LoadGV();
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

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dong = e.RowIndex;
                txtMaGV.Text = dgvGiaoVien.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
                if (dgvGiaoVien.Rows[e.RowIndex].Cells["GT"].Value.ToString() == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                dtpNgaySinh.Text = dgvGiaoVien.Rows[dong].Cells[3].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[dong].Cells[5].Value.ToString();
                txtLuong.Text = dgvGiaoVien.Rows[dong].Cells[6].Value.ToString();
                
                SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                conn.Open();
                string strSQL = "select * from tblMonhoc where MaMon = '" + dgvGiaoVien.Rows[dong].Cells[7].Value.ToString() + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, conn);
                sqlDa.Fill(dt);
                cboMamon.DataSource = dt;
                cboMamon.ValueMember = "MaMon";
                cboMamon.DisplayMember = "TenMon";
                Khoa_btn();
            }
            catch { }
        }
        private void show_cboMonhoc()
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
            conn.Open();
            string strSQL = "select * from tblMonhoc where MaMon = '" + dgvGiaoVien.Rows[dong].Cells[7].Value.ToString() + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, conn);
            sqlDa.Fill(dt);
            cboMamon.DataSource = dt;
            cboMamon.DisplayMember = "TenMon";
            cboMamon.ValueMember = "MaMon";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;            

            //Mở nút lưu 
            txtMaGV.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            
            txtMaGV.Focus();
            Mo_btn();
            SetNull();
            txtLuong.Text = "1000000";    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaGV.Text == ""|| txtTen.Text == "")
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin");
                Khoa_btn();
                return;
            }
            else
            {
                //Them GV
                #region 
                if (themmoi==true)
                {
                    try
                      {

                          SqlConnection connT = new SqlConnection(DTO.ConnectString.StringConnect);
                        connT.Open();
                        SqlCommand cmd = new SqlCommand("themGV1", connT);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaGV",txtMaGV.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@TenGV", txtTen.Text);
                        cmd.Parameters.Add(p);
                        if (rdbNam.Checked)                 
                            p = new SqlParameter("@GT", "Nam");
                        else 
                            p = new SqlParameter("@GT", "Nữ");
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@NgaySinh",dtpNgaySinh.Value.Year.ToString() + "-" +
                        dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString());
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@SDT", txtSDT.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@Luong", txtLuong.Text);
                        cmd.Parameters.Add(p);         
                        p = new SqlParameter("@MaMon", cboMamon.SelectedValue.ToString());
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();
                        //Hiển thị lại thông tin sau khi thêm và thông báo
                        LoadGV();                        
                        MessageBox.Show("Thêm mới thành công");

                        //
                        txtMaGV.Enabled = false;
                        btnLuu.Enabled = false;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        SetNull();
                        connT.Close();
                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //Sua GV
                #region
                else
                {
                    try
                    {
                        SqlConnection connX = new SqlConnection(DTO.ConnectString.StringConnect);
                        connX.Open();
                        //MessageBox.Show("ok");
                        
                        SqlCommand cmd2 = new SqlCommand("suaGV1", connX);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaGV", txtMaGV.Text);
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("@TenGV", txtTen.Text);
                        cmd2.Parameters.Add(p);
                        if (rdbNam.Checked)
                            p = new SqlParameter("@GT", "Nam");
                        else
                            p = new SqlParameter("@GT", "Nữ");
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("NgaySinh", dtpNgaySinh.Value.Year.ToString() + "-" +
                        dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString());
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("@SDT", txtSDT.Text);
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("@DiaChi", txtDiaChi.Text);
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("@Luong", txtLuong.Text);
                        cmd2.Parameters.Add(p);
                        p = new SqlParameter("@MaMon", cboMamon.SelectedValue.ToString());
                        cmd2.Parameters.Add(p);
                        
                        cmd2.ExecuteNonQuery();
                         
                        //Hiển thị lại thông tin sau khi thêm và thông báo
                        //Ketnoi();
                        
                        MessageBox.Show("Thay đổi thông tin giáo viên thành công");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                SetNull();
                Khoa_btn();/*không cho thao tác*/
                LoadGV();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                SetNull();
                Khoa_btn();/*không cho thao tác*/
                LoadGV();
            }
        }
        private DataTable Show_GV(string dieukien)
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
            conn.Open();
            string strSQL = "select * from tblGiaovien where MaGV = '" + dieukien + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, conn);
            sqlDa.Fill(dt);
            conn.Close();
            return dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn giáo viên để sửa!");
                return;
            }
            Mo_btn();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            //hienthi ds Ma Mon
            SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
            conn.Open();
            string strSQL = "select * from tblMonhoc";
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, conn);
            sqlDa.Fill(dt);
            cboMamon.DataSource = dt;
            cboMamon.DisplayMember = "TenMon";
            cboMamon.ValueMember = "MaMon";
            conn.Close();
        }

        // Tìm Kiếm
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rdTKMa.Checked == true)
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                    conn.Open();
                    string strSQL = "SELECT MaGV, TenGV, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien WHERE MaGV like N'%" + txtTimKiem.Text + "%'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL,conn);
                    sqlDa.Fill(dt);
                    dgvGiaoVien.DataSource = dt;
                    conn.Close();
                }
                else if (rdTKTen.Checked == true)
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                    conn.Open();
                    string strSQL = "SELECT MaGV, GT, NgaySinh, SDT, DiaChi, Luong, MaMon FROM tblGiaovien WHERE TenGV like N'%" + txtTimKiem.Text + "%'";
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, conn);
                    sqlDa.Fill(dt);
                    dgvGiaoVien.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show(" Mời bạn chọn lại!!!!");
                    return;
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

           
                
        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            Khoa_btn();
            LoadGV();
        }

    }
}
