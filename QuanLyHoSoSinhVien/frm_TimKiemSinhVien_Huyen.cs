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

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_TimKiemSinhVien_Huyen : Form
    {
        private readonly SinhVien svTK;
        public frm_TimKiemSinhVien_Huyen()
        {
            InitializeComponent();
            svTK = SinhVien.SV;
            svTK.Show_All(dgv_HoSoSinhVien);
        }

        private void frm_TimKiem_Huyen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn chắC chắn muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_HoSoSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                svTK.MaSV1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                svTK.HoDem1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                svTK.Ten1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                svTK.NgaySinh1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                svTK.GioiTinh1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                svTK.QueQuan1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                svTK.SoDT1 = int.Parse(dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString());
                svTK.MaLop1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                svTK.TenDN1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void cb_timkiemtheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
