using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_ThemLopHoc_Khanh : Form
    {
        public frm_ThemLopHoc_Khanh()
        {
            InitializeComponent();
        }

        private void LoadKhoa()
        {
            try
            {
                //Cách 1: DisplayMember

                //DataTable dt = TruyVan.LayDuLieuKhoa(); // Gọi phương thức lấy dữ liệu khoa
                //cb_MaKhoa_Khanh.DisplayMember = "TenKhoa"; // Hiển thị tên khoa
                //cb_MaKhoa_Khanh.ValueMember = "MaKhoa"; // Giá trị của combo box là mã khoa
                //cb_MaKhoa_Khanh.DataSource = dt; // Gán dữ liệu cho combo box

                //// Cách 2: Vòng lặp
                foreach (DataRow item in TruyVan.LayDuLieuKhoa().Rows)
                {
                    cb_MaKhoa_Khanh.Items.Add(item[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu khoa: " + ex.Message, "Lỗi");
            }
        }

        private void btn_Them_Khanh_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tb_MaLop_Khanh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp.", "Thông báo");
                tb_MaLop_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_TenLop_Khanh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp.", "Thông báo");
                tb_TenLop_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_KhoaHoc_Khanh.Text))
            {
                MessageBox.Show("Vui lòng nhập khóa học.", "Thông báo");
                tb_KhoaHoc_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_HeDaoTao_Khanh.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ đào tạo.", "Thông báo");
                tb_HeDaoTao_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_NamNhapHoc_Khanh.Text))
            {
                MessageBox.Show("Vui lòng nhập năm nhập học.", "Thông báo");
                tb_NamNhapHoc_Khanh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cb_MaKhoa_Khanh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã khoa.", "Thông báo");
                cb_MaKhoa_Khanh.Focus();
                return;
            }

            // Kiểm tra lớp học đã tồn tại chưa
            if (TruyVan.KiemTra(tb_MaLop_Khanh.Text))
            {
                MessageBox.Show("Lớp học đã tồn tại. Vui lòng nhập mã lớp khác.", "Thông báo");
                tb_MaLop_Khanh.Focus();
                return;
            }
            string maLop = tb_MaLop_Khanh.Text.Trim();
            string tenLop = tb_TenLop_Khanh.Text.Trim();
            string khoaHoc = tb_KhoaHoc_Khanh.Text.Trim();
            string heDaoTao = tb_HeDaoTao_Khanh.Text.Trim();
            string namNhapHoc = tb_NamNhapHoc_Khanh.Text.Trim();
            //string maKhoa = cb_MaKhoa_Khanh.SelectedValue?.ToString().Trim(); // Lấy mã khoa từ SelectedValue Cách 1
            string maKhoa = cb_MaKhoa_Khanh.SelectedItem.ToString().Trim(); // Lấy mã khoa từ SelectedItem Cách 2
            string query = "INSERT INTO LOPHOC (MaLop, TenLop, KhoaHoc, HeDaoTao, NamNhapHoc, MaKhoa) " +
                           "VALUES (@MaLop, @TenLop, @KhoaHoc, @HeDaoTao, @NamNhapHoc, @MaKhoa)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@KhoaHoc", khoaHoc),
                new SqlParameter("@HeDaoTao", heDaoTao),
                new SqlParameter("@NamNhapHoc", namNhapHoc),
                new SqlParameter("@MaKhoa", maKhoa)
            };
            try
            {
                int kq = TruyVan.ExecuteNonQuery(query, parameters);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm lớp học thành công!", "Thông báo");
                    frm_QuanLyLopHoc_Khanh quanLyLopHoc = new frm_QuanLyLopHoc_Khanh();
                    quanLyLopHoc.HienThi(); 
                    quanLyLopHoc.Show(); 

                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Không thêm được lớp học.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void frm_Them_Khanh_Load(object sender, EventArgs e)
        {
            LoadKhoa(); 
        }

        private void btn_Huy_Khanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
