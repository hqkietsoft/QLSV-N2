using Nhom2_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	public partial class frm_SuaMonHoc_Bac : Form
	{
		private readonly MonHoc monhoc;
		private string id, name;
		private int sotc;
		private int no0Column = 0, no1Column = 1, no2Column = 2;
		 
		public frm_SuaMonHoc_Bac()
		{
			InitializeComponent();
			monhoc = MonHoc.Subject;
			id = monhoc.MaMH;
			name = monhoc.TenMH;
			sotc = monhoc.SoTC;
			monhoc.ShowOnComboBox(cbo_MaMH_Bac, no0Column);
			showOnControls();
			cbo_MaMH_Bac.DropDownHeight = 400;
			cbo_MaMH_Bac.DropDownWidth = 30;

		}

		private void frm_SuaMonHoc_Bac_Load(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbo_MaMH_Bac_SelectedIndexChanged(object sender, EventArgs e)
		{
			monhoc.GetAllByID_SuaThongTin(cbo_MaMH_Bac,txt_TenMH_Bac, txt_SoTC_Bac, no1Column,no2Column);

		}

		private void showOnControls()
		{
			cbo_MaMH_Bac.SelectedItem = monhoc.MaMH;
			txt_TenMH_Bac.Text = monhoc.TenMH;
			txt_SoTC_Bac.Text = monhoc.SoTC.ToString();
		}
		

		private void btn_SuaMonHoc_Bac_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(cbo_MaMH_Bac.Text) || string.IsNullOrEmpty(txt_TenMH_Bac.Text) || string.IsNullOrEmpty(txt_SoTC_Bac.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if(name == txt_TenMH_Bac.Text.Trim() && sotc == int.Parse(txt_SoTC_Bac.Text.Trim()))
				{
					MessageBox.Show("Bạn chưa sửa thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				monhoc.UpdateSubjectById(cbo_MaMH_Bac.Text, txt_TenMH_Bac.Text, txt_SoTC_Bac.Text);
				this.Close();
			}
		}
	}
}
