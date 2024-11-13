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
namespace Nhom2_QuanLySinhVien.QuanLyNguoiDung
{
	public partial class frm_ThongTinNguoiDung_Bac : Form
	{
		private readonly Login nguoidung;
		public frm_ThongTinNguoiDung_Bac()
		{
			InitializeComponent();
			nguoidung = Login.NguoiDung;
			Disabled();
			nguoidung.UserInfo(Program.loaiND,txt_TenDN_Bac,txt_MatKhau_Bac, txt_LoaiND_Bac);
		}
		public void Disabled()
		{
			txt_TenDN_Bac.Enabled = false;
			txt_LoaiND_Bac.Enabled = false;
			txt_MatKhau_Bac.Enabled = false;
		}
	}
}
