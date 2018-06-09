using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HocSinh_GiaoVien_THPT.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucView uv = new ucView();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(uv);
            uv.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            ucGiaoVien gv = new ucGiaoVien();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ucHocSinh gv = new ucHocSinh();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            ucGiangDay gv = new ucGiangDay();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucThoiKhoaBieu gv = new ucThoiKhoaBieu();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucTaiKhoan gv = new ucTaiKhoan();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình không?", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
