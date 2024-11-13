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
    public partial class frm_ThemSinhVien_Huyen : Form
    {
        private readonly SinhVien svthem;
        public frm_ThemSinhVien_Huyen()
        {

            InitializeComponent();
            svthem = SinhVien.SV;
            svthem.ShowOnComboBox(cb_MaLop, 0);
            svthem.ShowOnComboBox1(cb_TenDN, 0);
            SinhVien.SV.ShowOnComboBox1(cb_TenDN, 1);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaSV.Text) || string.IsNullOrEmpty(txt_HoDem.Text) ||
                string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(dateNgaySinh.Text) ||
                string.IsNullOrEmpty(txt_QueQuan.Text) || string.IsNullOrEmpty(txt_SoDT.Text) ||
                string.IsNullOrEmpty(cb_MaLop.Text) || string.IsNullOrEmpty(cb_TenDN.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                svthem.Them(txt_MaSV.Text, txt_HoDem.Text, txt_Ten.Text, dateNgaySinh, gioitinh(), txt_QueQuan.Text, txt_SoDT.Text, cb_MaLop.Text, cb_TenDN);
                this.Close();
            }

        }
        
        public string gioitinh()
        {
            if (rb_Nam.Checked)
            {
                return "Nam";
            }
            return "Nữ";
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
