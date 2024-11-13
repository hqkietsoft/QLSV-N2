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

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_Sua_Khanh : Form
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string KhoaHoc { get; set; }
        public string HeDaoTao { get; set; }
        public string NamNhapHoc { get; set; }
        public string MaKhoa { get; set; }
        public frm_Sua_Khanh()
        {
            InitializeComponent();
        }
        private void LoadKhoa()
        {
            try
            {
                DataTable dt = TruyVan.LayDuLieuKhoa(); // Gọi phương thức lấy dữ liệu khoa
                cb_MaKhoa_Khanh.DisplayMember = "TenKhoa"; // Hiển thị tên khoa
                cb_MaKhoa_Khanh.ValueMember = "MaKhoa"; // Giá trị của combo box là mã khoa
                cb_MaKhoa_Khanh.DataSource = dt; // Gán dữ liệu cho combo box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khoa: " + ex.Message, "Lỗi");
            }
        }
        private void frm_Sua_Khanh_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            tb_MaLop_Khanh.Text = MaLop;
            tb_TenLop_Khanh.Text = TenLop;
            tb_KhoaHoc_Khanh.Text = KhoaHoc;
            tb_HeDaoTao_Khanh.Text = HeDaoTao;
            tb_NamNhapHoc_Khanh.Text = NamNhapHoc;
            cb_MaKhoa_Khanh.Text = MaKhoa;
        }

        private void btn_Sua_Khanh_Click(object sender, EventArgs e)
        {
            string tenLop = tb_TenLop_Khanh.Text.Trim();
            string khoaHoc = tb_KhoaHoc_Khanh.Text.Trim();
            string heDaoTao = tb_HeDaoTao_Khanh.Text.Trim();
            string namNhapHoc = tb_NamNhapHoc_Khanh.Text.Trim();
            string maKhoa = cb_MaKhoa_Khanh.SelectedValue.ToString().Trim();


            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("Vui lòng nhập tên lớp.", "Thông báo");
                tb_TenLop_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(khoaHoc))
            {
                MessageBox.Show("Vui lòng nhập khóa học.", "Thông báo");
                tb_KhoaHoc_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(heDaoTao))
            {
                MessageBox.Show("Vui lòng nhập hệ đào tạo.", "Thông báo");
                tb_HeDaoTao_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(namNhapHoc))
            {
                MessageBox.Show("Vui lòng nhập năm nhập học.", "Thông báo");
                tb_NamNhapHoc_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn mã khoa.", "Thông báo");
                cb_MaKhoa_Khanh.Focus();
                return;
            }

            // Kiểm tra nếu không có thay đổi nào so với thông tin ban đầu
            if (tenLop == TenLop && khoaHoc == KhoaHoc && heDaoTao == HeDaoTao && namNhapHoc == NamNhapHoc && maKhoa == MaKhoa)
            {
                MessageBox.Show("Bạn chưa sửa thông tin nào.", "Thông báo");
                return; // Dừng lại nếu không có thay đổi
            }

            string query = "UPDATE LOPHOC SET TenLop = @TenLop, KhoaHoc = @KhoaHoc, HeDaoTao = @HeDaoTao, NamNhapHoc = @NamNhapHoc, MaKhoa = @MaKhoa " +
                           "WHERE MaLop = @MaLop";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", MaLop),
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@KhoaHoc", khoaHoc),
                new SqlParameter("@HeDaoTao", heDaoTao),
                new SqlParameter("@NamNhapHoc", namNhapHoc),
                new SqlParameter("@MaKhoa", maKhoa)
            };

            // Thực thi câu lệnh cập nhật dữ liệu
            try
            {
                int kq = TruyVan.ExecuteNonQuery(query, parameters);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo");

                    frm_QuanLyLopHoc_Khanh quanLyLopHoc = new frm_QuanLyLopHoc_Khanh();
                    quanLyLopHoc.HienThi();
                    quanLyLopHoc.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không có lớp học nào được cập nhật. Vui lòng kiểm tra mã lớp.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btn_Huy_Khanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
