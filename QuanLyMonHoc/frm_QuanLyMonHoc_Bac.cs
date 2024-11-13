using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.QuanLyMonHoc;
using Nhom2_QuanLySinhVien.Model;

namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	public partial class frm_QuanLyMonHoc_Bac : Form
	{
		private readonly MonHoc monhoc;
		public frm_QuanLyMonHoc_Bac()
		{
			InitializeComponent();
			monhoc = MonHoc.Subject;
			PhanQuyen();

		}
		public void PhanQuyen()
		{
			// 1 là admin, 2 là pdt, 3 là giáo viên, 4 là sinh viên
			if (Program.loaiND == 3 || Program.loaiND == 4)// Giang Vien
			{
				btn_addNew_Bac.Visible = false;
				btn_SuaMH_Bac.Visible = false;
				btn_XoaMH_Bac.Visible = false;
			}
			
		}
		
		private void frm_XemThongTinMonHoc_Bac_Load(object sender, EventArgs e)
		{
			cbo_SapxepMonHoc_Bac.Text = "---Chọn thông tin---";
			dgv_DSMonHoc_Bac.DataSource = monhoc.SelectAllSubject();
			lb_somonhoc.Text = "Số môn học : " + monhoc.SelectAllSubject().Rows.Count;
		}

		private void btn_addNew_Bac_Click(object sender, EventArgs e)
		{
			frm_ThemMoiMonHoc_Bac f = new frm_ThemMoiMonHoc_Bac();
			f.ShowDialog();
			dgv_DSMonHoc_Bac.DataSource = monhoc.SelectAllSubject();
			lb_somonhoc.Text = "Số môn học : " + monhoc.SelectAllSubject().Rows.Count;

		}


		private void btn_XoaMH_Bac_Click(object sender, EventArgs e)
		{
			frm_XoaMonHoc_Bac f = new frm_XoaMonHoc_Bac();
			f.ShowDialog();
			dgv_DSMonHoc_Bac.DataSource = monhoc.SelectAllSubject();
			lb_somonhoc.Text = "Số môn học : " + monhoc.SelectAllSubject().Rows.Count;

		}


		private void btn_SuaMH_Bac_Click(object sender, EventArgs e)
		{
			frm_SuaMonHoc_Bac f = new frm_SuaMonHoc_Bac();
			f.ShowDialog();
			dgv_DSMonHoc_Bac.DataSource = monhoc.SelectAllSubject();
			lb_somonhoc.Text = "Số môn học : " + monhoc.SelectAllSubject().Rows.Count;
		}


		private void cbo_SapxepMonHoc_Bac_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgv_DSMonHoc_Bac.DataSource = monhoc.SortingByIndexOfCombobox(cbo_SapxepMonHoc_Bac);
			
		}

		private void dgv_DSMonHoc_Bac_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				monhoc.MaMH = dgv_DSMonHoc_Bac.Rows[e.RowIndex].Cells[0].Value.ToString();
				monhoc.TenMH = dgv_DSMonHoc_Bac.Rows[e.RowIndex].Cells[1].Value.ToString();
				monhoc.SoTC = int.Parse(dgv_DSMonHoc_Bac.Rows[e.RowIndex].Cells[2].Value.ToString());
			}
		
	}

		private void txt_TimKiem_Bac_TextChanged_1(object sender, EventArgs e)
		{
			dgv_DSMonHoc_Bac.DataSource = monhoc.SeachingAllByAll(txt_TimKiem_Bac.Text);
			lb_somonhoc.Text = "Số môn học : " + monhoc.SeachingAllByAll(txt_TimKiem_Bac.Text).Rows.Count;
		}
	}
}
