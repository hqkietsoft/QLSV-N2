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
    public partial class SuaLopHocPhan : UserControl
    {
        private ConnectionData connectDB;
        private string originalMaLop;
        public SuaLopHocPhan()
        {
            InitializeComponent();
        }
        public SuaLopHocPhan(string maLop, string maMH, string maGV, string hocKy, string nam)
        {
            InitializeComponent();
            string conString = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            connectDB = new ConnectionData(conString);

            originalMaLop = maLop;
            LoadComboBoxData();

            // Hiển thị dữ liệu lên form
            txtMaLHP.Text = maLop;
            cbbHocKy.Text = hocKy;
            nbrNam.Value = decimal.Parse(nam);

            // Set selected value cho các ComboBox
            SetComboBoxSelectedValue(cbbMaMon, maMH);
            SetComboBoxSelectedValue(cbbMaGV, maGV);
        }

        private void SetComboBoxSelectedValue(ComboBox comboBox, string value)
        {
            if (comboBox.DataSource != null)
            {
                foreach (DataRowView item in (comboBox.DataSource as DataTable).DefaultView)
                {
                    if (item.Row[comboBox.ValueMember].ToString() == value)
                    {
                        comboBox.SelectedValue = value;
                        break;
                    }
                }
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Load dữ liệu cho ComboBox Môn học
                string queryMonHoc = "SELECT MaMH, TenMH, CONCAT(MaMH, ' - ', TenMH) as Display FROM MonHoc";
                DataTable dtMonHoc = connectDB.ExecuteQuery(queryMonHoc);
                cbbMaMon.DataSource = dtMonHoc;
                cbbMaMon.DisplayMember = "Display";
                cbbMaMon.ValueMember = "MaMH";

                // Load dữ liệu cho ComboBox Giáo viên
                string queryGiaoVien = "SELECT MaGV, HoTen, CONCAT(MaGV, ' - ', HoTen) as Display FROM GiaoVien";
                DataTable dtGiaoVien = connectDB.ExecuteQuery(queryGiaoVien);
                cbbMaGV.DataSource = dtGiaoVien;
                cbbMaGV.DisplayMember = "Display";
                cbbMaGV.ValueMember = "MaGV";

                // Load data cho ComboBox Học kỳ
                cbbHocKy.Items.AddRange(new object[] { "1", "2", "3" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();
            trangChu.LoadLopHocPhanUserControl();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
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

                // Kiểm tra nếu mã lớp mới đã tồn tại (chỉ khi mã lớp bị thay đổi)
                if (txtMaLHP.Text != originalMaLop)
                {
                    string checkQuery = "SELECT COUNT(*) FROM LopHocPhan WHERE MaLop = @MaLop";
                    var checkParam = new SqlParameter("@MaLop", txtMaLHP.Text.Trim());
                    DataTable dt = connectDB.ExecuteQuery(checkQuery, new[] { checkParam });
                    if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                    {
                        MessageBox.Show("Mã lớp học phần đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Tạo câu lệnh SQL và parameters
                string query = @"UPDATE LopHocPhan 
                           SET MaLop = @MaLopMoi,
                               MaMH = @MaMH,
                               MaGV = @MaGV,
                               HocKy = @HocKy,
                               Nam = @Nam
                           WHERE MaLop = @MaLopCu";

                List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaLopMoi", txtMaLHP.Text.Trim()),
                new SqlParameter("@MaMH", cbbMaMon.SelectedValue),
                new SqlParameter("@MaGV", cbbMaGV.SelectedValue),
                new SqlParameter("@HocKy", cbbHocKy.Text.Trim()),
                new SqlParameter("@Nam", nbrNam.Value),
                new SqlParameter("@MaLopCu", originalMaLop)
            };

                // Thực thi câu lệnh
                connectDB.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Cập nhật lớp học phần thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load lại form LopHocPhan
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

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {

        }
    }
}
