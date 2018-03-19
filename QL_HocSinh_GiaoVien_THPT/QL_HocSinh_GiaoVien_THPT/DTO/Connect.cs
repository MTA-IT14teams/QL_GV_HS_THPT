using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.DTO
{
    public static class Connect
    {
        //public static bool isConnect = false;
        public static SqlConnection myconnect = new SqlConnection(DTO.ConnectString.stringConnect);
    }
}
