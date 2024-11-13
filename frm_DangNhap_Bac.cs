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
	public partial class frm_DangNhap_Bac : Form
	{
		Login login;
		public frm_DangNhap_Bac()
		{
			InitializeComponent();
			login = new Login();
		}
		

		private void frm_DangNhap_Bac_Load(object sender, EventArgs e)
		{
			lb_ThongBaoDangNhap_Bac.Text = "";	
		}

		

		private void btn_DangNhap_Bac_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txt_TenDangNhap_Bac.Text.Trim()))
			{
				lb_ThongBaoDangNhap_Bac.Text = "Bạn chưa nhập tên đăng nhập!";
				txt_TenDangNhap_Bac.Focus();
			}
			else if (string.IsNullOrEmpty(txt_MatKhau_Bac.Text.Trim()))
			{
				lb_ThongBaoDangNhap_Bac.Text = "Bạn chưa nhập mật khẩu!";
				txt_MatKhau_Bac.Focus();
			}
			else if (login.checkLogin(txt_TenDangNhap_Bac.Text, txt_MatKhau_Bac.Text) == 0)
			{
				lb_ThongBaoDangNhap_Bac.Text = "Tên đăng nhập và mật khẩu không đúng!";
			}	
			else
			{
				MessageBox.Show("Đăng nhập thành công.", "Đăng nhập hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
				TrangChu f = new TrangChu();
				this.Hide();
				f.ShowDialog();
			}
		}

		private void chb_ShowPassword_Bac_CheckedChanged(object sender, EventArgs e)
		{
			if (chb_ShowPassword_Bac.Checked)
				txt_MatKhau_Bac.UseSystemPasswordChar = false;
			else 
				txt_MatKhau_Bac.UseSystemPasswordChar = true;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Liên hệ Admin để cấp lại mật khẩu!", "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
