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
using System.IO;


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
                DTO.ConnectString.WinAuthentication = true;
                txtTenDangNhap.Enabled = false;
                txtMK.Enabled = false;
            }
            if (cbxChonTaiKhoan.SelectedIndex == 1)
            {
                DTO.ConnectString.WinAuthentication = false;
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

                DTO.ConnectString.ServerName = txtTenMayChu.Text.Trim();
                DTO.ConnectString.DatabaseName = txtTenCSDL.Text.Trim();

                if (cbxChonTaiKhoan.SelectedIndex == 0)
                {
                    DTO.ConnectString.WinAuthentication = true;
                    DTO.ConnectString.TaoChuoiKetNoi();
                }
                else
                {
                    DTO.ConnectString.WinAuthentication = false;
                    DTO.ConnectString.TaoChuoiKetNoi();
                }


                DTO.Connect.myconnect = new SqlConnection(DTO.ConnectString.StringConnect);
                DTO.Connect.openConnect();

                if (DTO.Connect.myconnect.State == ConnectionState.Open)
                {
                    using (StreamWriter write = new StreamWriter("config"))
                    {
                        write.WriteLine(DTO.ConnectString.ServerName);
                        write.WriteLine(DTO.ConnectString.DatabaseName);
                        write.WriteLine(DTO.ConnectString.UserName);
                        write.WriteLine(DTO.ConnectString.Password);
                    }

                    GUI.frmLogin lg = new GUI.frmLogin();
                    this.Hide();
                    lg.ShowDialog();
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
