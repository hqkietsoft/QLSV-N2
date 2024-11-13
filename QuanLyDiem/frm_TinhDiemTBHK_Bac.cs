using QuanLySinhVien_Nhom2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Nhom2.QuanLyDiem
{
	public partial class frm_TinhDiemTBHK_Bac : Form
	{
		private readonly Diem diem;
		string ma;
		public frm_TinhDiemTBHK_Bac()
		{
			InitializeComponent();
			diem = Diem.DIEM;
			dgv_DiemTBHK.DataSource = diem.LayDuLieuDiem_Monhoc_SinhVien();
			cbo_ThongTinSV.DropDownHeight = 300;
			cbo_ThongTinSV.DropDownWidth = 30;


		}

		private void cbo_ThongTinSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			//dgv_DiemTBHK.DataSource = diem.TinhDiemTBHK(cbo_ThongTinSV.Text.Substring(0,5));
			dgv_DiemTBHK.DataSource = diem.TinhDiemTBHK(cbo_ThongTinSV.Text.Trim(),cbo_hocky_diem.Text.Trim());

		}

		private void btnTinhDiem_Click(object sender, EventArgs e)
		{
			double result =0;
			foreach (DataRow dr in diem.TinhDiemTBHK(cbo_ThongTinSV.Text.Trim(), cbo_hocky_diem.Text.Trim()).Rows)
			{
				double diemhpxtinchi = double.Parse(dr["DiemHocPhan"].ToString()) * double.Parse(dr["SoTC"].ToString());
				double TongsoTinchi = double.Parse(dr["SoTC"].ToString());
				result = diemhpxtinchi / TongsoTinchi;
			}
			diem.UpdateDiemTBHK(result, cbo_ThongTinSV.Text.Substring(0, 5));
			dgv_DiemTBHK.DataSource = diem.TinhDiemTBHK(cbo_ThongTinSV.Text.Trim(), cbo_hocky_diem.Text.Trim());

		}

		private void btnXetHocBong_Click(object sender, EventArgs e)
		{
			dgv_DiemTBHK.DataSource = diem.XetHocBong(cbo_hocky.Text);
		}

		private void txt_TTTimKiem_TextChanged(object sender, EventArgs e)
		{
			dgv_DiemTBHK.DataSource = diem.TimKiemDiemMonHoc(txt_TTTimKiem.Text);
		}

		private void cbo_hocky_diem_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = diem.HienThiDiemLenCBO(cbo_hocky_diem.Text.Trim());
			foreach(DataRow dr in dt.Rows)
			{
				cbo_ThongTinSV.Items.Add(dr["MaSV"]);
			}
			

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
