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
    public partial class ucGiangDay : UserControl
    {
        public ucGiangDay()
        {
            InitializeComponent();
        }
        //
        private DataTable dtGiaoVien= new DataTable();
        private DataTable dtLop = new DataTable();
        private DataTable dtDuLieu= new DataTable();
        //
        DataView dvDuLieu = new DataView();
        DataView dvGiaoVien = new DataView();
        DataView dvLop = new DataView();
        DataView dvXGiaoVien = new DataView();
        DataView dvXLop = new DataView();
        private void loadData()
        {
            try
            {
               // DTO.Connect.openConnect();
                //fill data into giaovien
                SqlCommand cmd = new SqlCommand("select * from tblGiaoVien", DTO.Connect.myconnect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtGiaoVien);
                //fill data into Lop
                 cmd = new SqlCommand("select * from tblLop", DTO.Connect.myconnect);
                 da = new SqlDataAdapter(cmd);
                da.Fill(dtLop);
                //fill data into giaovien
                 cmd = new SqlCommand("SELECT gv.MaGV,gv.TenGV,l.MaLop,l.TenLop,gd.Thu,gd.Tiet, mh.MaMon,mh.TenMon  FROM dbo.tblGiangDay gd, dbo.tblGiaovien gv, dbo.tblLop l, dbo.tblMonhoc mh WHERE l.MaLop = gd.MaLop AND gd.MaGV = gv.MaGV AND gv.MaMon = mh.MaMon", DTO.Connect.myconnect);
                 da = new SqlDataAdapter(cmd);
                da.Fill(dtDuLieu);
            }
          catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy dữ liệu từ Server.\nVui lòng kiểm tra lại!\n"+ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void displayData()
        {
            try
            {
                  dvDuLieu = new DataView(dtDuLieu);
                  dvGiaoVien = new DataView(dtGiaoVien);
                  dvLop = new DataView(dtLop);
                  dvXGiaoVien = new DataView(dtGiaoVien);
                  dvXLop = new DataView(dtLop);
                // blind datasource
                dgvData.DataSource = dvDuLieu;
                

                cboGiaoVien.DataSource = dvGiaoVien;
                cboGiaoVien.DisplayMember = "TenGV";
                cboGiaoVien.ValueMember = "MaGV";

                cboLop.DataSource = dvLop;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";

                cboXemGiaoVien.DataSource = dvXGiaoVien;
                cboXemGiaoVien.DisplayMember = "TenGV";
                cboXemGiaoVien.ValueMember = "MaGV";

                cboXemLop.DataSource = dvXLop;
                cboXemLop.DisplayMember = "TenLop";
                cboXemLop.ValueMember = "MaLop";

            }catch (Exception ex)
            {
                MessageBox.Show("Don't display data");
            }



        }
        private void pnInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ucGiangDay_Load(object sender, EventArgs e)
        {
            loadData();
            displayData();


        }

        private void cboXemLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dvDuLieu.RowFilter = string.Empty;
                dvDuLieu.RowFilter = "MaLop=" + cboXemLop.SelectedValue;
                
            }
            catch (Exception ex)
            {

            }
           
        }

        private void cboXemGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dvDuLieu.RowFilter = string.Empty;
                dvDuLieu.RowFilter = "MaGV=" + cboXemGiaoVien.SelectedValue;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dvDuLieu.RowFilter = string.Empty;
        }
    }
}
