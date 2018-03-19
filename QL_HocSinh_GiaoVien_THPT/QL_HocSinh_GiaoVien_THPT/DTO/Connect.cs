using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.DTO
{
<<<<<<< HEAD
    class Connect
    {
        public static bool isConnect = false;
        public static SqlConnection myconnect = new SqlConnection(ConnectionString.stringConnect);

    }
=======
    
   
    public static class Connect
    {
        public static SqlConnection myconnect = new SqlConnection(DTO.ConnectionString.stringConnect);

        public static void openConnect()
        {
            myconnect.Open();
        }

        public static void closeConnect()
        {
            myconnect.Close();
        }

    }



>>>>>>> e544cfcb60de5d4c229b0955c3e32ffe1e404b18
}
