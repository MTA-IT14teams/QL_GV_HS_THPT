using QL_HocSinh_GiaoVien_THPT.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocSinh_GiaoVien_THPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sname = "";
            string dbname = "";
            string uname = "";
            string pass = "";

            if (!File.Exists("config"))
            {
                Application.Run(new GUI.frmConnectDatabase());
            }
            else
            {
                using (StreamReader read = new StreamReader("config"))
                {
                    sname = read.ReadLine();
                    dbname = read.ReadLine();
                    uname = read.ReadLine();
                    pass = read.ReadLine();
                }

                DTO.ConnectString.ServerName = sname;
                DTO.ConnectString.DatabaseName = dbname;

                if (uname == "")
                {
                    DTO.ConnectString.WinAuthentication = true;
                }
                else
                {
                    DTO.ConnectString.WinAuthentication = false;
                    DTO.ConnectString.UserName = uname;
                    DTO.ConnectString.Password = pass;
                }
                DTO.ConnectString.TaoChuoiKetNoi();

                try
                {
                    SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        GUI.frmLogin lg = new GUI.frmLogin();
                        lg.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại kết nối đến CSDL");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kiểm tra lại thông tin kết nối và ấn OK để thiết lập lại!\n Eror: " + ex.Message);
                }
            }

            Application.Run(new GUI.frmConnectDatabase());
        }
    }
}
