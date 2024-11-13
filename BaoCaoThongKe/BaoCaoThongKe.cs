using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;
using QuanLySinhVien_Nhom2;

namespace Nhom2_QuanLySinhVien
{
    public partial class BaoCaoThongKe : UserControl
    {
        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }
        private ConnectionData connectDB;
        public BaoCaoThongKe()
        {
            InitializeComponent();
            string conString = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            connectDB = new ConnectionData(conString);

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            string queryLop = "SELECT DISTINCT MaLop FROM LopHoc";
            DataTable dtLop = connectDB.ExecuteQuery(queryLop);
            cbbLopHoc.DataSource = dtLop;
            cbbLopHoc.DisplayMember = "MaLop";
            cbbLopHoc.ValueMember = "MaLop";

            string queryLop1 = "SELECT MaMH, TenMH FROM MonHoc";
            DataTable dtLop1 = connectDB.ExecuteQuery(queryLop);
            cbbLopHoc1.DataSource = dtLop1;
            cbbLopHoc1.DisplayMember = "MaLop";
            cbbLopHoc1.ValueMember = "MaLop";

            string queryMonHoc = "SELECT MaMH, TenMH FROM MonHoc";
            DataTable dtMonHoc = connectDB.ExecuteQuery(queryMonHoc);
            cbbMonHoc.DataSource = dtMonHoc;
            cbbMonHoc.DisplayMember = "MaMH";
            cbbMonHoc.ValueMember = "MaMH";

            string queryMaSV = "SELECT MaSV FROM SinhVien";
            DataTable dtMaSV = connectDB.ExecuteQuery(queryMaSV);
            cbbMaSV.DataSource = dtMaSV;
            cbbMaSV.DisplayMember = "MaSV";
            cbbMaSV.ValueMember = "MaSV";
        }

        // Xuất danh sách sinh viên của một lớp ra file Excel
        private void btnXuatDanhSachSV_Click(object sender, EventArgs e)
        {
            string maLop = cbbLopHoc1.SelectedValue.ToString();
            string query = "SELECT * FROM SinhVien WHERE MaLop = @MaLop";
            SqlParameter param = new SqlParameter("@MaLop", maLop);
            DataTable dataTable = connectDB.ExecuteQuery(query, new[] { param });

            ExportToExcel(dataTable);
        }

        // Xuất bảng điểm của lớp cho một môn học ra file Excel
        private void btnXuatBaiDiem_Click(object sender, EventArgs e)
        {
            string maLop = cbbLopHoc.SelectedValue.ToString();
            string maMonHoc = cbbMonHoc.SelectedValue.ToString();

            string query = "SELECT s.MaLop,d.MaMH, s.MaSV,s.HoDem, s.Ten, d.DiemCC, d.DiemHS1, d.DiemHS2L1, d.DiemHS2L2, d.DiemQuaTrinh, d.DiemThi, d.DiemHocPhan, d.DiemTBHK FROM SinhVien s " +
                           "JOIN Diem d ON s.MaSV = d.MaSV WHERE s.MaLop = @MaLop AND d.MaMH = @MaMH";
            SqlParameter[] parameters = {
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@MaMH", maMonHoc)
            };

            DataTable dataTable = connectDB.ExecuteQuery(query, parameters);
            ExportToExcel(dataTable);
        }

        // Xuất báo cáo thông tin bảng điểm của sinh viên theo mã sinh viên
        private void btnXuatBaoCaoSV_Click(object sender, EventArgs e)
        {
            //string maSinhVien = cbbMaSV.SelectedValue.ToString();

            //string query = "SELECT s.MaSV,s.HoDem, s.Ten,m.TenMH, d.DiemCC, d.DiemHS1, d.DiemHS2L1, d.DiemHS2L2, d.DiemQuaTrinh, d.DiemThi, d.DiemHocPhan, d.DiemTBHK " +
            //               "FROM SinhVien s " +
            //               "JOIN Diem d ON s.MaSV = d.MaSV " +
            //               "JOIN MonHoc m ON d.MaMH = m.MaMH WHERE s.MaSV = @MaSV";
            //SqlParameter param = new SqlParameter("@MaSV", maSinhVien);
            //DataTable dataTable = connectDB.ExecuteQuery(query, new[] { param });

            //ExportToExcel(dataTable);

            string maSinhVien = cbbMaSV.SelectedValue.ToString();

            //Mở form BCTK và truyền Mã sinh viên vào
            BCTK reportForm = new BCTK(maSinhVien);
            reportForm.ShowDialog();
        }

        private void ExportToExcel(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Khởi tạo một đối tượng ExcelPackage
                using (var package = new ExcelPackage())
                {
                    // Thêm một Worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Tải dữ liệu từ DataTable vào Worksheet
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true); // "true" cho phép sử dụng header

                    for (int col = 1; col <= dt.Columns.Count; col++)
                    {
                        // Nếu cột là Ngày Sinh (ví dụ cột có tên là "NgaySinh")
                        if (dt.Columns[col - 1].ColumnName.Equals("NgaySinh", StringComparison.OrdinalIgnoreCase))
                        {
                            // Đặt định dạng ngày cho cột Ngày Sinh
                            worksheet.Column(col).Style.Numberformat.Format = "dd/MM/yyyy";
                        }
                    }

                    // Căn chỉnh độ rộng cột cho phù hợp với nội dung
                    for (int col = 1; col <= dt.Columns.Count; col++)
                    {
                        // Căn chỉnh độ rộng cột
                        worksheet.Column(col).AutoFit();

                        // Nếu muốn căn độ rộng cụ thể là 14px
                        worksheet.Column(col).Width = 14;
                    }

                    // Mở SaveFileDialog để chọn đường dẫn và tên file lưu
                    using (var saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Lưu file Excel vào vị trí người dùng chọn
                            File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                            MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
