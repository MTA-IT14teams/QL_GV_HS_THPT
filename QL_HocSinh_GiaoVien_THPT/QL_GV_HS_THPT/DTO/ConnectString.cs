using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_GiaoVien_THPT.DTO
{
    public static class ConnectString
    {
        public static string ServerName;
        public static string DatabaseName;
        public static string UserName;
        public static string Password;
        public static bool WinAuthentication;

        public static string StringConnect="";

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
            StringConnect = Temp;
        }

    }
}
