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
	public partial class frm_XoaMonHoc_Bac : Form
	{
		private readonly MonHoc monhoc; 
		int no0Column = 0;
		int no1Column = 1;
		int no2Column = 2;
		public frm_XoaMonHoc_Bac()
		{
			InitializeComponent();
			monhoc = MonHoc.Subject;
			monhoc.ShowOnComboBox(cbo_MaMH_Bac, no0Column);
			monhoc.ShowOnComboBox(cbo_TenMH_Bac, no1Column);
			showOnControls();
		}

		
		private void showOnControls()
		{
			cbo_MaMH_Bac.SelectedItem = monhoc.MaMH;
			cbo_TenMH_Bac.SelectedItem = monhoc.TenMH;
			txt_SoTC_Bac.Text = monhoc.SoTC.ToString();
		}
		private void btn_Thoat_Bac_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Xoa_Bac_Click(object sender, EventArgs e)
		{
			DialogResult ans = MessageBox.Show($"Bạn có muốn xóa môn học {cbo_TenMH_Bac.Text}", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(ans == DialogResult.Yes)
			{
				if (string.IsNullOrEmpty(cbo_MaMH_Bac.Text) || string.IsNullOrEmpty(cbo_TenMH_Bac.Text) || string.IsNullOrEmpty(txt_SoTC_Bac.Text))
				{
					MessageBox.Show("Vui lòng điền đầy đủ thông tin để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					monhoc.DeleleSubjectByID(cbo_MaMH_Bac, cbo_TenMH_Bac);
					this.Close();
				}
			}
		}
		private void frm_XoaMonHoc_Bac_Load(object sender, EventArgs e)
		{
			
		}

		private void cbo_MaMH_Bac_SelectedIndexChanged(object sender, EventArgs e)
		{
			monhoc.GetAllByNameOrID(cbo_MaMH_Bac, cbo_TenMH_Bac, txt_SoTC_Bac, no1Column, no2Column);
		}

		private void cbo_TenMH_Bac_SelectedIndexChanged(object sender, EventArgs e)
		{
			monhoc.GetAllByNameOrID(cbo_TenMH_Bac, cbo_MaMH_Bac, txt_SoTC_Bac, no0Column, no2Column);
		}

		private void guna2GroupBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
