using QL_HocSinh_GiaoVien_THPT.GUI;
using System;
using System.Collections.Generic;
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
            frmConnectDatabase db = new frmConnectDatabase();
            db.ShowDialog();

            if (DTO.ConnectString.StringConnect != "")
            {
                Application.Run(new GUI.frmLogin());
            }
        }
    }
}
