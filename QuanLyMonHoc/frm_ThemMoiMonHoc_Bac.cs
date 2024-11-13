
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;
namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	public partial class frm_ThemMoiMonHoc_Bac : Form
	{
		private readonly MonHoc monhoc;
		public frm_ThemMoiMonHoc_Bac()
		{
			InitializeComponent();
			monhoc = MonHoc.Subject;
		}

		
		private void btn_Thoat_Bac_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		#region Thêm mới
		private void AddNewSubject()
		{
			if(string.IsNullOrEmpty(txt_MaMH_Bac.Text) || string.IsNullOrEmpty(txt_TenMH_Bac.Text) || string.IsNullOrEmpty(cbo_SoTC_Bac.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				monhoc.InsertData(txt_MaMH_Bac, txt_TenMH_Bac, cbo_SoTC_Bac);
				this.Close();
			}
		}
		private void btn_Them_Bac_Click(object sender, EventArgs e)
		{
			AddNewSubject();
			txt_MaMH_Bac.Clear();
			txt_TenMH_Bac.Clear();
			cbo_SoTC_Bac.Items.Clear();
			for(int i = 1; i < 5; i++)
			{
				cbo_SoTC_Bac.Items.Add(i);
			}
		}
		#endregion
	}
}
