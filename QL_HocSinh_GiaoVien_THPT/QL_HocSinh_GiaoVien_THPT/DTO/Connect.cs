using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.DTO
{
    public class Connect
    {
        public static SqlConnection myconnect = new SqlConnection(DTO.ConnectionString.stringConnect);

        public static void openConnect()
        {
            Connect.myconnect.Open();
        }

        public static void closeConnect()
        {
            Connect.myconnect.Close();
        }
    }
}
