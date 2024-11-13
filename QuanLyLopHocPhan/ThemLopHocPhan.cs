using Microsoft.Data.SqlClient;
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
    public partial class ThemLopHocPhan : UserControl
    {
        private ConnectionData connectDB;
        public ThemLopHocPhan()
        {
            InitializeComponent();
            string conString = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            connectDB = new ConnectionData(conString);
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            try
            {
                string queryMonHoc = "SELECT MaMH, TenMH, CONCAT(MaMH, ' - ', TenMH) as Display FROM MonHoc";
                DataTable dtMonHoc = connectDB.ExecuteQuery(queryMonHoc);
                cbbMaMon.DataSource = dtMonHoc;
                cbbMaMon.DisplayMember = "Display";
                cbbMaMon.ValueMember = "MaMH";    
                cbbMaMon.SelectedIndex = -1;

                string queryGiaoVien = "SELECT MaGV, HoTen, CONCAT(MaGV, ' - ', HoTen) as Display FROM GiaoVien";
                DataTable dtGiaoVien = connectDB.ExecuteQuery(queryGiaoVien);
                cbbMaGV.DataSource = dtGiaoVien;
                cbbMaGV.DisplayMember = "Display";
                cbbMaGV.ValueMember = "MaGV";
                cbbMaGV.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemLopHocPhan_Load(object sender, EventArgs e)
        {
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtMaLHP.Text) ||
                    cbbMaMon.SelectedValue == null ||
                    cbbMaGV.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(cbbHocKy.Text) ||
                    string.IsNullOrWhiteSpace(nbrNam.Value.ToString()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã lớp học phần đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM LopHocPhan WHERE MaLop = @MaLop";
                var checkParam = new SqlParameter("@MaLop", txtMaLHP.Text.Trim());
                DataTable dt = connectDB.ExecuteQuery(checkQuery, new[] { checkParam });
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Mã lớp học phần đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo câu lệnh SQL và parameters
                string query = @"INSERT INTO LopHocPhan (MaLop, MaMH, MaGV, HocKy, Nam) 
                    VALUES (@MaLop, @MaMH, @MaGV, @HocKy, @Nam)";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaLop", txtMaLHP.Text.Trim()),
                    new SqlParameter("@MaMH", cbbMaMon.SelectedValue),
                    new SqlParameter("@MaGV", cbbMaGV.SelectedValue),
                    new SqlParameter("@HocKy", cbbHocKy.Text.Trim()),
                    new SqlParameter("@Nam", nbrNam.Value)
                };

                // Thực thi câu lệnh
                connectDB.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Thêm lớp học phần thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear các control sau khi thêm thành công
                txtMaLHP.Clear();
                cbbMaMon.SelectedIndex = -1;
                cbbMaGV.SelectedIndex = -1;
                cbbHocKy.SelectedIndex = -1;
                nbrNam.Value = nbrNam.Minimum;

                // Load lại form LopHocPhan
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
                trangChu.LoadLopHocPhanUserControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            trangChu.LoadLopHocPhanUserControl();
        }
    }
}
