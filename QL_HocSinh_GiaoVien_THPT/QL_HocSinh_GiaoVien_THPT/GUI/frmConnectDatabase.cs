using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class frmConnectDatabase : Form
    {
        public frmConnectDatabase()
        {
            InitializeComponent();
        }

        private void frmConnectDatabase_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMK.Enabled = false;
        }

        private void cbxChonTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChonTaiKhoan.SelectedIndex == 0)
            {
                DTO.ConnectionString.WinAuthentication = true;
                txtTenDangNhap.Enabled = false;
                txtMK.Enabled = false;
            }
            if (cbxChonTaiKhoan.SelectedIndex == 1)
            {
                DTO.ConnectionString.WinAuthentication = false;
                txtTenDangNhap.Enabled = true;
                txtMK.Enabled = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenMayChu.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên máy chủ!");
                    ActiveControl = txtTenMayChu;
                    return;
                }
                else if (txtTenCSDL.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên CSDL!");
                    ActiveControl = txtTenCSDL;
                    return;
                }

                DTO.ConnectionString.ServerName = txtTenMayChu.Text.Trim();
                DTO.ConnectionString.DatabaseName = txtTenCSDL.Text.Trim();

                if (cbxChonTaiKhoan.SelectedIndex == 0)
                {
                    DTO.ConnectionString.WinAuthentication = true;
                    DTO.ConnectionString.TaoChuoiKetNoi();
                }
                else
                {
                    DTO.ConnectionString.WinAuthentication = false;
                    DTO.ConnectionString.TaoChuoiKetNoi();
                }


                DTO.Connect.myconnect = new SqlConnection(DTO.ConnectionString.stringConnect);
                DTO.Connect.openConnect();

                if (DTO.Connect.myconnect.State == ConnectionState.Open)
                {
                    MessageBox.Show("Bạn đã kết nối thành công đến cơ sở dữ liệu " + txtTenCSDL.Text);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Không kết nối được đến cơ sở dữ liệu!");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTenMayChu_TextChanged(object sender, EventArgs e)
        {

        }

        

       

    }
}
