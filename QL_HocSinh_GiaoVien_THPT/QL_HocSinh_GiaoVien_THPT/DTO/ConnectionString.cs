using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QL_HocSinh_GiaoVien_THPT.DTO
{
    public static class ConnectionString
    {
        public static string ServerName;
        public static string DatabaseName;
        public static string UserName;
        public static string Password;
        public static bool WinAuthentication;
        public static SqlConnection myconect;
        public static string stringConnect="";

        public static void TaoChuoiKetNoi()
        {
            string Temp = "";
            Temp = "Data Source=" + ServerName + ";";
            Temp += "Initial Catalog=" + DatabaseName + ";";

            if (WinAuthentication)
            {
                Temp += "Integrated security=true";
            }
            else
            {
                Temp += "Integrated security = false; User ID= " + UserName + ";" + "Password =" + Password;

            }
            stringConnect = Temp;
        }
        public static void MoKetNoi()
        {
            SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            conn.Open();
        }

        public static void DongKetNoi()
        {

        }

    }
}
