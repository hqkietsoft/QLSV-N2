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

namespace Nhom2_QuanLySinhVien.QuanLyDiem
{
    public partial class frm_DiemQuaTrinh_Huyen : Form
    {
        private string maSV;
        private string maMH;
        private int soTinChi;
        public frm_DiemQuaTrinh_Huyen(string maSV, string maMH, int soTinChi)
        {
            InitializeComponent();
            this.maSV = maSV;
            this.maMH = maMH;
            this.soTinChi = soTinChi;

            // Hiển thị số tín chỉ lên ô txt_soTC
            txt_soTC.Text = soTinChi.ToString();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các ô nhập
                float diemChuyenCan = float.Parse(txt_DiemCC.Text);
                float diemHS1 = float.Parse(txt_DiemHS1.Text);
                float diemHS2ThuNhat = float.Parse(txt_DiemHS2thu1.Text);
                float diemHS2ThuHai = float.Parse(txt_DiemHS2thu2.Text);
                int soTinChi = int.Parse(txt_soTC.Text);

                // Tính điểm quá trình
                float diemQuaTrinh = (diemChuyenCan * soTinChi + diemHS1 + (diemHS2ThuNhat * 2) + (diemHS2ThuHai * 2)) / (soTinChi + 5);

                // Gọi phương thức lưu điểm vào cơ sở dữ liệu
                Diem.DIEM.UpdateDiemQuaTrinh(maSV, maMH, diemChuyenCan, diemHS1, diemHS2ThuNhat, diemHS2ThuHai, diemQuaTrinh);

                // Hiển thị kết quả tính toán
                MessageBox.Show("Điểm quá trình: " + diemQuaTrinh.ToString("0.00"));

                // Đóng form với kết quả OK để cập nhật lại DataGridView ở form chính
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng số cho tất cả các ô điểm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
