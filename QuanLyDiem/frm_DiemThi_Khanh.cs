using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    public partial class frm_DiemThi_Khanh : Form
    {
        public frm_DiemThi_Khanh()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Đổ dữ liệu vào ComboBox Môn học
            cb_Mon_Khanh.DataSource = TruyVan.LayDuLieuMonHoc();  // Giả sử đây là phương thức lấy danh sách môn học
            cb_Mon_Khanh.DisplayMember = "TenMH";  // Hiển thị tên môn học
            cb_Mon_Khanh.ValueMember = "MaMH";    // Giá trị là mã môn học

            cb_Mon_Khanh.SelectedIndexChanged += cb_Mon_Khanh_SelectedIndexChanged;

        }

        private void cb_Mon_Khanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Kiểm tra xem có môn học nào được chọn không
            if (cb_Mon_Khanh.SelectedIndex != -1)
            {
                string maMH = cb_Mon_Khanh.SelectedValue.ToString();
                DataTable dtSinhVien = TruyVan.LayThongTinSinhVienTheoMonHoc(maMH);
                if (dtSinhVien.Rows.Count > 0)
                {
                    
                    // Nếu có dữ liệu, gán DataSource cho DataGridView
                    dgv_DiemThi_Khanh.DataSource = dtSinhVien;

                    if (dgv_DiemThi_Khanh.Columns["Xoa"] != null)
                    {
                        dgv_DiemThi_Khanh.Columns.Remove("Xoa");
                    }

                    // Thêm cột "Xóa" mới
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "Xoa";
                    btnDelete.HeaderText = "Xóa";
                    btnDelete.Text = "Xóa";
                    btnDelete.UseColumnTextForButtonValue = true;
                    dgv_DiemThi_Khanh.Columns.Add(btnDelete);

                    // Đảm bảo cột "Xóa" luôn ở cuối
                    btnDelete.DisplayIndex = dgv_DiemThi_Khanh.Columns.Count - 1;
                }
                else
                {
                    // Nếu không có dữ liệu, thông báo cho người dùng
                    MessageBox.Show("Không có dữ liệu sinh viên cho môn học này.");
                    dgv_DiemThi_Khanh.DataSource = null; // Đặt DataSource thành null để xóa dữ liệu cũ
                }
            }
            else
            {
                // Nếu không có môn học nào được chọn, xóa dữ liệu trong DataGridView
                dgv_DiemThi_Khanh.DataSource = null;
            }
        }

        private void dgv_DiemThi_Khanh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin sinh viên, môn học và điểm thi từ ô vừa được chỉnh sửa
            string maSV = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();
            string maMonHoc = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["MaMH"].Value?.ToString(); // Thêm cột MaMonHoc
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMonHoc))
                return; // Bỏ qua nếu không có mã sinh viên hoặc mã môn học

            string diemQuaTrinhStr = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["DiemQuaTrinh"].Value?.ToString();
            string diemThiStr = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["DiemThi"].Value?.ToString();

            // Không cần kiểm tra nếu một trong hai ô là null
            if (string.IsNullOrEmpty(diemQuaTrinhStr) || string.IsNullOrEmpty(diemThiStr))
                return; // Bỏ qua nếu chưa nhập đủ

            if (float.TryParse(diemQuaTrinhStr, out float diemQuaTrinh) && float.TryParse(diemThiStr, out float diemThi))
            {
                // Kiểm tra nếu điểm quá trình hoặc điểm thi nằm ngoài khoảng 0-10
                if (diemQuaTrinh >= 0 && diemQuaTrinh <= 10 && diemThi >= 0 && diemThi <= 10)
                {
                    // Tính toán điểm học phần
                    float diemHocPhan = (diemQuaTrinh * 0.4f) + (diemThi * 0.6f);
                    // Cập nhật lại giá trị điểm học phần vào DataGridView
                    dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["DiemHocPhan"].Value = diemHocPhan.ToString("0.00");

                    // Cập nhật lại dữ liệu lên cơ sở dữ liệu ngay lập tức
                    TruyVan.CapNhatDiem(maSV, maMonHoc, diemQuaTrinh, diemThi, diemHocPhan); // Thêm tham số maMonHoc
                }
            }
        }

        private void btn_LuuTatCa_Khanh_Click(object sender, EventArgs e)
        {
            // Lặp qua từng hàng trong DataGridView
            bool hasInvalidData = false;

            for (int i = 0; i < dgv_DiemThi_Khanh.Rows.Count; i++)
            {
                // Lấy thông tin sinh viên, môn học và điểm thi từ từng hàng
                string maSV = dgv_DiemThi_Khanh.Rows[i].Cells["MaSV"].Value?.ToString();
                string maMonHoc = dgv_DiemThi_Khanh.Rows[i].Cells["MaMH"].Value?.ToString(); // Thêm cột MaMonHoc
                if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMonHoc))
                    continue; // Bỏ qua hàng nếu không có mã sinh viên hoặc mã môn học

                string diemQuaTrinhStr = dgv_DiemThi_Khanh.Rows[i].Cells["DiemQuaTrinh"].Value?.ToString();
                string diemThiStr = dgv_DiemThi_Khanh.Rows[i].Cells["DiemThi"].Value?.ToString();

                if (float.TryParse(diemQuaTrinhStr, out float diemQuaTrinh) && float.TryParse(diemThiStr, out float diemThi))
                {
                    // Kiểm tra nếu điểm quá trình hoặc điểm thi nằm ngoài khoảng 0-10
                    if (diemQuaTrinh >= 0 && diemQuaTrinh <= 10 && diemThi >= 0 && diemThi <= 10)
                    {
                        float diemHocPhan = (diemQuaTrinh * 0.4f) + (diemThi * 0.6f);
                        // Cập nhật lại dữ liệu lên cơ sở dữ liệu
                        TruyVan.CapNhatDiem(maSV, maMonHoc, diemQuaTrinh, diemThi, diemHocPhan); // Thêm tham số maMonHoc
                    }
                    else
                    {
                        hasInvalidData = true; // Đánh dấu nếu có dữ liệu không hợp lệ
                    }
                }
            }

            if (hasInvalidData)
            {
                MessageBox.Show("Một số điểm không hợp lệ đã bị bỏ qua. Vui lòng kiểm tra lại.");
            }
            else
            {
                MessageBox.Show("Cập nhật điểm thành công!");
            }
        }

        private void dgv_DiemThi_Khanh_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /// Kiểm tra xem ô có phải là ô điểm không
            if (dgv_DiemThi_Khanh.Columns[e.ColumnIndex].Name == "DiemQuaTrinh" || dgv_DiemThi_Khanh.Columns[e.ColumnIndex].Name == "DiemThi")
            {
                if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    if (!float.TryParse(e.FormattedValue.ToString(), out float diem) || diem < 0 || diem > 10)
                    {
                        // Không xóa giá trị tại đây, để cho phép người dùng sửa lại
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.");
                        e.Cancel = true; // Hủy bỏ việc nhập dữ liệu không hợp lệ
                    }
                }
            }
        }

        private void dgv_DiemThi_Khanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DiemThi_Khanh.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                // Xác nhận xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa điểm thi này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lấy thông tin sinh viên và môn học
                    string maSV = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["MaSV"].Value?.ToString();
                    string maMonHoc = dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["MaMH"].Value?.ToString();

                    try
                    {
                        // Gọi hàm xóa điểm
                        if (TruyVan.XoaDiem(maSV, maMonHoc))
                        {
                            // Cập nhật lại các ô trong DataGridView
                            dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["DiemThi"].Value = DBNull.Value;
                            dgv_DiemThi_Khanh.Rows[e.RowIndex].Cells["DiemHocPhan"].Value = DBNull.Value;
                            MessageBox.Show("Điểm thi đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa điểm thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
