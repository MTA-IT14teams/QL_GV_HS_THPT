using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void KiemTra()
        {
            //MessageBox.Show("test");
            try
            {
                if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên đăng nhập!");
                    ActiveControl = txtUsername;
                    return;
                }
                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu!");
                    ActiveControl = txtPassword;
                    return;
                }

                SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
                conn.Open();
                string sql = "select *from tblUser where Username = '" + txtUsername.Text.Trim() + "' and  Password = '" + txtPassword.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    frmMain m = new frmMain();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();
                    //MessageBox.Show("Hoàn thành công việc của mình trước 26/3/2018", "Deadline");
                }
                else
                {
                    MessageBox.Show("Không đăng nhập được! Kiểm tra lại thông tin tài khoản!");
                }
<<<<<<< HEAD
                
=======
>>>>>>> 8011a03f74cd22a5669236fe6f06f1fd193c26ba
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không đăng nhập được! Kiểm tra lại thông tin tài khoản!" +ex.Message);
            }
        }

        

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Save") == "true")
            {
                cbLuuTK.Checked = true;
                txtUsername.Text = ConfigurationManager.AppSettings["Username"].ToString();
                //txtUsername.Text = ConfigurationManager.AppSettings.Get("Username");
                //txtPassword.Text = ConfigurationManager.AppSettings.Get("Password");
            }
        }

        private void ckcHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            KiemTra();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
