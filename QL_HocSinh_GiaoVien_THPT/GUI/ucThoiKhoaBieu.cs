using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class ucThoiKhoaBieu : UserControl
    {
        public ucThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                conn.Open();
                //SqlCommand cmd = new SqlCommand("ThoiKhoaBieu", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                string sql = "SELECT gd.Thu, gd.Tiet, gv.TenGV, mh.TenMon FROM dbo.tblLop l, dbo.tblGiangday gd, dbo.tblGiaovien gv, dbo.tblMonhoc mh WHERE gd.MaLop = '" + cbbLop.SelectedValue + "' AND l.MaLop = gd.MaLop AND gd.MaGV = gv.MaGV AND gv.MaMon = mh.MaMon";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@Malop", cbbLop.ValueMember);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dgvTKB.DataSource = tb;
                //MessageBox.Show("xxx");
                //for (int i = 0; i < tb.Rows.Count; i++)
                //{
                //    string thu = tb.Rows[i]["Thu"].ToString();
                //    int tiet = int.Parse(tb.Rows[i]["Tietday"].ToString());
                //    dgvTKB.Rows[tiet - 1].Cells["Thu" + thu].Value = tb.Rows[i]["TenMon"].ToString();
                //    dgvTKB.Rows[tiet - 1].Cells["TenGV" + thu].Value = tb.Rows[i]["Hoten"].ToString();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DTO.ConnectString.StringConnect);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaLop, TenLop from tblLop", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbLop.DataSource = dt;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
