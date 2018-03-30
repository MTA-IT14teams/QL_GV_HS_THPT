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
using System.Data;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class ucGiangDay : UserControl
    {
        public ucGiangDay()
        {
            InitializeComponent();
        }

        private DataTable dtGiaoVien = new DataTable();
        private DataTable dtLop = new DataTable();
        private DataTable dtDuLieu = new DataTable();
        private DataTable dtThu = new DataTable();
        //
        DataView dvDuLieu = new DataView();
        DataView dvGiaoVien = new DataView();
        DataView dvLop = new DataView();
        DataView dvThu = new DataView();
        DataView dvXGiaoVien = new DataView();
        DataView dvXLop = new DataView();
        DataView dvXThu = new DataView();

        private void loadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblGiaoVien", DTO.Connect.myconnect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                this.dtGiaoVien.Clear();
                da.Fill(dtGiaoVien);
                //fill data into Lop
                cmd = new SqlCommand("select * from tblLop", DTO.Connect.myconnect);
                da = new SqlDataAdapter(cmd);
                this.dtLop.Clear();
                da.Fill(dtLop);
                //fill data into giaovien
                cmd = new SqlCommand("SELECT gv.MaGV,gv.TenGV,l.MaLop,l.TenLop,th.Ten as Thu ,gd.Thu as idthu,gd.Tiet, mh.MaMon,mh.TenMon  FROM dbo.tblGiangDay gd, dbo.tblGiaovien gv, dbo.tblLop l, dbo.tblMonhoc mh, dbo.tblThu th WHERE l.MaLop = gd.MaLop AND gd.MaGV = gv.MaGV AND gv.MaMon = mh.MaMon AND gd.Thu = th.ID", DTO.Connect.myconnect);
                da = new SqlDataAdapter(cmd);
                this.dtDuLieu.Clear();
                da.Fill(dtDuLieu);
                //fill data into Thu
                cmd = new SqlCommand("Select * from tblThu", DTO.Connect.myconnect);
                da = new SqlDataAdapter(cmd);
                this.dtThu.Clear();
                da.Fill(dtThu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy dữ liệu từ Server.\nVui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                dvThu = new DataView(dtThu);
                dvXThu = new DataView(dtThu);
                // blind datasource
                //dgvData.DataSource = new DataView(); ;
                //this.dgvData.ClearSelection();
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

                cboThu.DataSource = dvThu;
                cboThu.DisplayMember = "Ten";
                cboThu.ValueMember = "ID";

                cboXemTheoThu.DataSource = dvXThu;
                cboXemTheoThu.DisplayMember = "Ten";
                cboXemTheoThu.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Don't display data.\nERROR:" + ex.Message);
            }



        }
        private void bindingData()
        {
            this.cboGiaoVien.DataBindings.Clear();
            this.cboGiaoVien.DataBindings.Add("SelectedValue", dgvData.DataSource, "MaGV", true, DataSourceUpdateMode.Never);
            this.cboGiaoVien.DataBindings.Add("Text", dgvData.DataSource, "TenGV", true, DataSourceUpdateMode.Never);
            this.cboLop.DataBindings.Add("SelectedValue", dgvData.DataSource, "MaLop", true, DataSourceUpdateMode.Never);
            this.cboLop.DataBindings.Add("Text", dgvData.DataSource, "TenLop", true, DataSourceUpdateMode.Never);

            this.cboThu.DataBindings.Add("SelectedValue", dgvData.DataSource, "idthu", true, DataSourceUpdateMode.Never);
            this.cboThu.DataBindings.Add("Text", dgvData.DataSource, "Thu", true, DataSourceUpdateMode.Never);

            this.txtTiet.DataBindings.Add("Text", dgvData.DataSource, "Tiet", true, DataSourceUpdateMode.Never);

        }

        private void ucGiangDay_Load(object sender, EventArgs e)
        {
            loadData();
            displayData();
            bindingData();
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

        private void cboXemTheoThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dvDuLieu.RowFilter = string.Empty;
                dvDuLieu.RowFilter = "idthu=" + cboXemTheoThu.SelectedValue;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dvDuLieu.RowFilter = string.Empty;
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvData.CurrentRow.Index;
                int count = dgvData.Rows.Count;

                //MessageBox.Show(index.ToString() + " " + count.ToString());
                if (index == count - 1)
                {
                    this.btnAdd.Enabled = true;
                    this.btnUpdate.Enabled = false;
                    this.btnDelete.Enabled = false;
                }
                else
                {
                    this.btnAdd.Enabled = false;
                    this.btnUpdate.Enabled = true;
                    this.btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO dbo.tblGiangDay (MaGV, MaLop, Thu, Tiet) VALUES('" + cboGiaoVien.SelectedValue.ToString().Trim() + "','" + cboLop.SelectedValue.ToString() + "'," + cboThu.SelectedValue.ToString() + "," + txtTiet.Text.Trim() + ")";
            try
            {
                SqlCommand cmd = new SqlCommand(str, DTO.Connect.myconnect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Dữ Liệu Thành Công..!");
                //this.dgvData.Rows.
                //this.dgvData
                //ucGiangDay_Load(null, null);
                loadData();
                displayData();
                this.btnFilter_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "update tblGiangDay set MaGV=@magv,MaLop=@malop,Thu=@thu,Tiet=@tiet Where MaGV=@mgv and MaLop=@ml and Thu=@t and Tiet=@tt";
                SqlCommand cmd = new SqlCommand(str, DTO.Connect.myconnect);

                //add value 
                cmd.Parameters.Add("@magv", cboGiaoVien.SelectedValue);
                cmd.Parameters.Add("@malop", cboLop.SelectedValue);
                cmd.Parameters.Add("@thu", cboThu.SelectedValue);
                cmd.Parameters.Add("@tiet", txtTiet.Text.Trim());

                //value
                cmd.Parameters.Add("@mgv", this.dgvData.SelectedRows[0].Cells["MaGV"].Value);
                cmd.Parameters.Add("@ml", this.dgvData.SelectedRows[0].Cells["MaLop"].Value);
                cmd.Parameters.Add("@t", this.dgvData.SelectedRows[0].Cells["idthu"].Value);
                cmd.Parameters.Add("@tt", this.dgvData.SelectedRows[0].Cells["Tiet"].Value);
                // MessageBox.Show(" " + this.dgvData.SelectedCells[0].Value + " " + this.dgvData.SelectedCells[1].Value + " " + this.dgvData.SelectedCells[2].Value + " " + this.dgvData.SelectedCells[3].Value + " " + this.dgvData.SelectedCells[4].Value + " " + this.dgvData.SelectedCells[5].Value + " " + this.dgvData.SelectedCells[6].Value);


                //
                var num = cmd.ExecuteNonQuery();
                if (num == 0)
                {
                    MessageBox.Show("Không Thể Update. Kiểm Tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Updated!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    displayData();
                    this.btnFilter_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete tblGiangDay  Where MaGV=@mgv and MaLop=@ml and Thu=@t and Tiet=@tt";
                SqlCommand cmd = new SqlCommand(str, DTO.Connect.myconnect);

                //add value 
                //cmd.Parameters.Add("@magv", cboGiaoVien.SelectedValue);
                //cmd.Parameters.Add("@malop", cboLop.SelectedValue);
                //cmd.Parameters.Add("@thu", cboThu.SelectedValue);
                //cmd.Parameters.Add("@tiet", txtTiet.Text.Trim());

                //value
                cmd.Parameters.Add("@mgv", this.dgvData.SelectedRows[0].Cells["MaGV"].Value);
                cmd.Parameters.Add("@ml", this.dgvData.SelectedRows[0].Cells["MaLop"].Value);
                cmd.Parameters.Add("@t", this.dgvData.SelectedRows[0].Cells["idthu"].Value);
                cmd.Parameters.Add("@tt", this.dgvData.SelectedRows[0].Cells["Tiet"].Value);
                // MessageBox.Show(" " + this.dgvData.SelectedCells[0].Value + " " + this.dgvData.SelectedCells[1].Value + " " + this.dgvData.SelectedCells[2].Value + " " + this.dgvData.SelectedCells[3].Value + " " + this.dgvData.SelectedCells[4].Value + " " + this.dgvData.SelectedCells[5].Value + " " + this.dgvData.SelectedCells[6].Value);


                //
                var num = cmd.ExecuteNonQuery();
                if (num == 0)
                {
                    MessageBox.Show("Không Thể Delete. Kiểm Tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Deleted!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    displayData();
                    this.btnFilter_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }












    }
}
