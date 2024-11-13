using QuanLySinhVien_Nhom2.Model;
using QuanLySinhVien_Nhom2.QuanLyDiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien.QuanLyDiem
{
	public partial class frm_QuanLyDiemMonHoc_Huyen : Form
	{
		Diem diem;
		public frm_QuanLyDiemMonHoc_Huyen()
		{
			InitializeComponent();
			diem = Diem.DIEM;
			diem.HienThiLenDataGridView(dgv_ThongTinDiem_Huyen);
		}

		private void frm_QuanLyDiemMonHoc_Huyen_Load(object sender, EventArgs e)
		{
            
        }

        private void btn_DiemThi_Huyen_Click(object sender, EventArgs e)
        {
            frm_DiemThi_Khanh d = new frm_DiemThi_Khanh();
            d.ShowDialog();
        }

        private void btn_DiemQuaTrinh_Huyen_Click(object sender, EventArgs e)
        {
            if (dgv_ThongTinDiem_Huyen.SelectedRows.Count > 0)
            {
                string maSV = dgv_ThongTinDiem_Huyen.SelectedRows[0].Cells["MaSV"].Value.ToString();
                string maMH = dgv_ThongTinDiem_Huyen.SelectedRows[0].Cells["MaMH"].Value.ToString();

                int soTinChi = diem.LaySoTinChi(maMH);

                frm_DiemQuaTrinh_Huyen diemquatrinh = new frm_DiemQuaTrinh_Huyen(maSV, maMH, soTinChi);

                if (diemquatrinh.ShowDialog() == DialogResult.OK)
                {
                    diem.HienThiLenDataGridView(dgv_ThongTinDiem_Huyen);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để nhập điểm quá trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DiemTBHK_Click(object sender, EventArgs e)
        {
			frm_TinhDiemTBHK_Bac tbhk = new frm_TinhDiemTBHK_Bac();
			tbhk.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ThongTinDiem_Huyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
