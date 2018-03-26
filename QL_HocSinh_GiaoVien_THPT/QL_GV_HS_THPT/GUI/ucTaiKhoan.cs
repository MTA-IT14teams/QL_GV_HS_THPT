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
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Open();
                string sql = "select * from tblUser";
                SqlCommand commandsql = new SqlCommand(sql, kn);//thuc thi cac cau lenh trong sql
                SqlDataAdapter com = new SqlDataAdapter(commandsql);//van chuyen du lieu
                DataTable table = new DataTable();//tao 1 bang ao trong he thong 
                com.Fill(table);//do du lieu vao bang ao
                dataGridView1.DataSource = table;//bang ao nay duoc do vao datagrirdview
            }
            catch
            {
                MessageBox.Show("Loi Ket Noi Vui Long Kiem Tra Lai !");

            }
            finally
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Close();
            }
        }
  
        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtUsername.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtMaGV.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtQuyen.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }
        string them;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // kn.Open();
                them = "insert into tblUser values('"+txtUsername.Text+"','"+txtPassword.Text+"','"+txtMaGV.Text+"','"+txtQuyen.Text+"')";
                SqlCommand commandthem = new SqlCommand(them,kn);
                commandthem.ExecuteNonQuery();
               ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                //kn.Close();
            }

        }
        string xoa;
        private void ucXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Open();
               // SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // kn.Open();
                xoa = "delete  tblUser where Username='"+txtUsername.Text+"'";
                SqlCommand commandxoa = new SqlCommand(xoa, kn);
                commandxoa.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Close();
               // SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // kn.Close();
            }

        }
        string sua;
        private void ucSua_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Open();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // kn.Open();
                sua = "update  tblUser set Password='"+txtPassword.Text+"',MaGV='"+txtMaGV.Text+"',Quyen='"+txtQuyen.Text+"' where Username='"+txtUsername.Text+"'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // kn.Close();
            }

        }
        string sqlTimKiem;
        private void ucTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                conn.Open();
                //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
               // conn.Open();
                sqlTimKiem = "SELECT *FROM tblUser where Username = '" + txtTimKiem.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("Username", txtTimKiem.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" không tìm thấy!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(DTO.ConnectString.StringConnect);
                kn.Close();
                //SqlConnection kn = new SqlConnection(@"Data Source=ADMIN-PC\SQLSERVEREXPRESS;Initial Catalog=QL_GV_HS_THPT;Integrated Security=True");
                // kn.Close();
            }
        }
        private void ucRefresh_Click(object sender, EventArgs e)
        {
            ketnoi();
            dataGridView1_Click(sender, e);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
        

       

        

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        

        
    }
}
