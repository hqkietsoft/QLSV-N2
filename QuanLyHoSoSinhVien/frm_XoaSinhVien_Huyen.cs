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
    public partial class frm_XoaSinhVien_Huyen : Form
    {
        private readonly SinhVien svXoa;
        private string HoDem, Ten, NgaySinh, GioiTinh, QueQuan, MaLop;
        private int SoDT;
        int no0Column = 0;
        
        public frm_XoaSinhVien_Huyen()
        {
            InitializeComponent();
            svXoa = SinhVien.SV;
            
            svXoa.ShowOnComboBox(cb_MaLop, no0Column);
            svXoa.ShowOnComboBox1(cb_TenDN, no0Column);

            txt_MaSV.Text = svXoa.MaSV1;
            txt_HoDem.Text = svXoa.HoDem1;
            txt_Ten.Text = svXoa.Ten1;
            dateNgaySinh.Text = svXoa.NgaySinh1;
            txt_QueQuan.Text = svXoa.QueQuan1;
            txt_SoDT.Text = svXoa.SoDT1.ToString();
            cb_MaLop.SelectedItem = svXoa.MaLop1;
            cb_TenDN.SelectedItem = svXoa.TenDN1;

            HoDem = svXoa.HoDem1;
            Ten = svXoa.Ten1;
            NgaySinh = svXoa.NgaySinh1;
            QueQuan = svXoa.QueQuan1;
            SoDT = svXoa.SoDT1;
            MaLop = svXoa.MaLop1;

            if (svXoa.GioiTinh1 == "Nam")
            {
                rb_Nam.Checked = true;
            }
            else
            {
                rb_Nu.Checked = true;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show($"Bạn có muốn xóa sinh viên {cb_TenDN.Text}", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txt_MaSV.Text) || string.IsNullOrEmpty(txt_HoDem.Text) ||
                    string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(dateNgaySinh.Value.ToString()) ||
                    string.IsNullOrEmpty(txt_QueQuan.Text) || string.IsNullOrEmpty(txt_SoDT.Text) ||
                    string.IsNullOrEmpty(cb_MaLop.Text) || string.IsNullOrEmpty(cb_TenDN.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    svXoa.Xoa(txt_MaSV.Text, cb_TenDN.Text);
                    this.Close();
                }
            }
        }
        
    }
}
