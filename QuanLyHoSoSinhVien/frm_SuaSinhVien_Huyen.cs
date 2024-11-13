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
    public partial class frm_SuaSinhVien_Huyen : Form
    {
        private string initialGioiTinh;
        private readonly SinhVien svSua;
        private string HoDem, Ten, NgaySinh, GioiTinh, QueQuan, MaLop;

        private int SoDT;

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public frm_SuaSinhVien_Huyen()
        {
            InitializeComponent();

            svSua = SinhVien.SV;
            initialGioiTinh = svSua.GioiTinh1;
            svSua.ShowOnComboBox(cb_MaLop, 0);
            svSua.ShowOnComboBox1(cb_TenDN, 0);

            txt_MaSV.Text = svSua.MaSV1;
            txt_HoDem.Text = svSua.HoDem1;
            txt_Ten.Text = svSua.Ten1;
            dateNgaySinh.Text = svSua.NgaySinh1;
            txt_QueQuan.Text = svSua.QueQuan1;
            txt_SoDT.Text = svSua.SoDT1.ToString();
            cb_MaLop.SelectedItem = svSua.MaLop1;
            cb_TenDN.SelectedItem = svSua.TenDN1;


            HoDem = svSua.HoDem1;
            Ten = svSua.Ten1;
            NgaySinh = svSua.NgaySinh1;
            QueQuan = svSua.QueQuan1;
            SoDT = svSua.SoDT1;
            MaLop = svSua.MaLop1;

            if (svSua.GioiTinh1 == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else if (svSua.GioiTinh1 == "Nữ")
            {
                rb_Nu.Checked = true;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSV.Text) || string.IsNullOrEmpty(txt_HoDem.Text) ||
                string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(dateNgaySinh.Text) ||
                string.IsNullOrEmpty(txt_QueQuan.Text) || string.IsNullOrEmpty(txt_SoDT.Text) ||
                string.IsNullOrEmpty(cb_MaLop.Text) || string.IsNullOrEmpty(cb_TenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string gioiTinhMoi = gioitinh();
                if (
                HoDem == txt_HoDem.Text &&
                Ten == txt_Ten.Text.Trim() &&
                NgaySinh == dateNgaySinh.Value.ToString() &&
                gioiTinhMoi == initialGioiTinh &&
                QueQuan == txt_QueQuan.Text &&
                SoDT == int.Parse(txt_SoDT.Text) &&
                MaLop == cb_MaLop.Text)
                {
                    MessageBox.Show("Bạn chưa sửa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                svSua.Sua(txt_MaSV.Text, txt_HoDem.Text, txt_Ten.Text, dateNgaySinh, gioiTinhMoi, txt_QueQuan.Text, txt_SoDT.Text, cb_MaLop.Text, cb_TenDN.Text);
                this.Close();
            }
        }
        public string gioitinh()
        {
            if (rb_Nam.Checked)
            {
                return "Nam";
            }
            else if (rb_Nu.Checked)
            {
                return "Nữ";
            }
            return string.Empty;
        }
    }
}
