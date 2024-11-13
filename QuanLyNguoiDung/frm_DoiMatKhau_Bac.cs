using Nhom2_QuanLySinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;
namespace Nhom2_QuanLySinhVien
{
	public partial class frm_DoiMatKhau_Bac : Form
	{
		private readonly Login login;
		public frm_DoiMatKhau_Bac()
		{
			InitializeComponent();
			login = Login.NguoiDung;
			login.ShowOnComboBox(cbo_TenDN_Bac);
			cbo_TenDN_Bac.Text = "--Choose Username---";
			txt_MatKhauCu_Bac.Enabled = false;
		}

		private void btn_Cancel_Bac_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Luu_Bac_Click(object sender, EventArgs e)
		{

			if (cbo_TenDN_Bac.Text == "--Choose Username---")
			{
				MessageBox.Show("Bạn chưa chọn tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (string.IsNullOrEmpty(txt_MatKhauCu_Bac.Text.Trim()))
			{
				MessageBox.Show("Bạn chưa nhập mật khẩu cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else if (string.IsNullOrEmpty(txt_MatKhauMoi_Bac.Text.Trim()))
			{
				MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else if (string.IsNullOrEmpty(txt_XacNhanMatKhauMoi_Bac.Text.Trim()))
			{
				MessageBox.Show("Bạn chưa xác nhận mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else if (txt_MatKhauMoi_Bac.Text != txt_XacNhanMatKhauMoi_Bac.Text)
			{
				MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txt_MatKhauCu_Bac.Text == txt_XacNhanMatKhauMoi_Bac.Text)
			{
				MessageBox.Show("Bạn chưa đổi mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				login.ChagePassword(cbo_TenDN_Bac.Text, txt_MatKhauMoi_Bac.Text.Trim());
				MessageBox.Show($"Bạn đã đổi mật khẩu thành công.\n Cho tên đăng nhập : {cbo_TenDN_Bac.Text}", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_MatKhauCu_Bac.Clear();
				txt_MatKhauMoi_Bac.Clear();
				txt_XacNhanMatKhauMoi_Bac.Clear();
				cbo_TenDN_Bac.Items.Clear();
				login.ShowOnComboBox(cbo_TenDN_Bac);
				cbo_TenDN_Bac.Text = "--Choose Username---";
			}
		}

		private void cbo_TenDN_Bac_SelectedIndexChanged(object sender, EventArgs e)
		{

			login.GetAllByUsername(cbo_TenDN_Bac, txt_MatKhauCu_Bac);

		}
	}
}
