using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_HoSoSinhVien : Form
    {
        SinhVien sinhvien;

        public frm_HoSoSinhVien()
        {
            InitializeComponent();
            sinhvien = SinhVien.SV;
            sinhvien.Show_All(dgv_HoSoSinhVien);
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_TimKiem.Text))
                
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               dgv_HoSoSinhVien.DataSource = sinhvien.TimKiem(txt_TimKiem.Text.Trim());
            }  
        }
        
        public void PhanQuyenSinhVien()
        {
            if (Program.loaiND == 1)// admin
            {

            }
            else if (Program.loaiND == 2) // phongdaotao
            {

            }
            if (Program.loaiND == 3 || Program.loaiND == 4)// Giáo viên và sinh viên
            {
                btn_Them.Visible = false;
                btn_Sua.Visible = false;
                btn_Xoa.Visible = false;
            }
            
        }
        private void dgv_HoSoSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                sinhvien.MaSV1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                sinhvien.HoDem1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                sinhvien.Ten1= dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                sinhvien.NgaySinh1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                sinhvien.GioiTinh1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                sinhvien.QueQuan1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                sinhvien.SoDT1 = int.Parse(dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString());
                sinhvien.MaLop1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                sinhvien.TenDN1 = dgv_HoSoSinhVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemSinhVien_Huyen Them = new frm_ThemSinhVien_Huyen();
            Them.ShowDialog();
            sinhvien.Show_All(dgv_HoSoSinhVien);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            frm_SuaSinhVien_Huyen Sua = new frm_SuaSinhVien_Huyen();
            Sua.ShowDialog();
            sinhvien.Show_All(dgv_HoSoSinhVien);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            frm_XoaSinhVien_Huyen Xoa = new frm_XoaSinhVien_Huyen();
            Xoa.ShowDialog();
            sinhvien.Show_All(dgv_HoSoSinhVien);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {  
             dgv_HoSoSinhVien.DataSource = sinhvien.TimKiem(txt_TimKiem.Text.Trim());   
        }

        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            dgv_HoSoSinhVien.DataSource = sinhvien.SapXep();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
