using Guna.UI2.WinForms;
using Nhom2_QuanLySinhVien.QuanLyDiem;
using Nhom2_QuanLySinhVien.QuanLyMonHoc;
using QuanLySinhVien_Nhom2.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            btn_show.Visible = false;
            guna2PictureBox2.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            Home h = new Home();
            addUserControl(h);
        }

        private void PhanQuyen()
        {
            if (Program.loaiND == 3) //Giáo Viên
            {
                btnHSSV.Enabled = false;
                btnBCTK.Enabled = false;
            }
            if (Program.loaiND == 4)//Sinh Viên
            {
                btnBCTK.Enabled = false;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
            guna2PictureBox2.Visible = true;
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Separator1.Visible = false;
            guna2Panel1.Width = 74;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2PictureBox2.Visible = false;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Separator1.Visible = true;
            guna2Panel1.Width = 254;
            guna2Transition1.ShowSync(guna2Panel1);
        }
        public void LoadLopHocPhanUserControl()
        {
            LopHocPhan lopHocPhanUC = new LopHocPhan();
            addUserControl(lopHocPhanUC);

            panelMain.Controls.Clear();
            panelMain.Controls.Add(lopHocPhanUC);
            lopHocPhanUC.BringToFront();
            if (btnLHP != null)
            {
                btnLHP.Checked = true;
            }
        }

        //private void guna2Button3_Click(object sender, EventArgs e)
        //{
        //    LoadLopHocPhanUserControl();
        //}

        private void addUserControl(UserControl function)
        {
            function.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(function);
            function.BringToFront();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLND_Click(object sender, EventArgs e)
        {

        }

        private void btnLHP_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = new LopHocPhan();
            addUserControl(lhp);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
            guna2PictureBox2.Visible = true;
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Separator1.Visible = false;
            guna2Panel1.Width = 74;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_show_Click_1(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = true;
            guna2PictureBox2.Visible = false;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Separator1.Visible = true;
            guna2Panel1.Width = 254;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe bctk = new BaoCaoThongKe();
            addUserControl(bctk);
        }

        private void btnHSSV_Click(object sender, EventArgs e)
        {
            frm_HoSoSinhVien d = new frm_HoSoSinhVien();
            d.TopLevel = false; // Đảm bảo form không ở mức cửa sổ chính
            d.Dock = DockStyle.Fill; // Làm cho form chiếm toàn bộ diện tích của panel
            panelMain.Controls.Add(d); // Thêm form vào panel
            d.BringToFront();
            d.Show(); // Hiển thị form con
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            frm_QuanLyLopHoc_Khanh d = new frm_QuanLyLopHoc_Khanh();
            d.TopLevel = false;
            d.Dock = DockStyle.Fill;
            panelMain.Controls.Add(d);
            d.BringToFront();
            d.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frm_QuanLyDiemMonHoc_Huyen d = new frm_QuanLyDiemMonHoc_Huyen();
            d.TopLevel = false;
            d.Dock = DockStyle.Fill;
            panelMain.Controls.Add(d);
            d.BringToFront();
            d.Show();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            frm_QuanLyMonHoc_Bac d = new frm_QuanLyMonHoc_Bac();
            d.TopLevel = false;
            d.Dock = DockStyle.Fill;
            panelMain.Controls.Add(d);
            d.BringToFront();
            d.Show();
        }
    }
}
