using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Nhom2
{
    public partial class BCTK : Form
    {
        private string maSinhVien;
        private string connectionString;
        public BCTK(string maSinhVien)
        {
            InitializeComponent();
            this.maSinhVien = maSinhVien;
            this.StartPosition = FormStartPosition.CenterScreen;

            connectionString = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False";

            // Thiết lập Dock để ReportViewer chiếm toàn bộ diện tích form
            reportViewer1.Dock = DockStyle.Fill;

            // Thiết lập chế độ Zoom để căn chỉnh theo chiều rộng trang
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void BCTK_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            try
            {
                LoadReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private DataTable GetDiemSinhVien()
        {
            string query = @"SELECT dbo.Diem.MaSV AS MaSV1, dbo.Diem.MaMH AS MaMH1, dbo.SinhVien.HoDem, 
                             dbo.SinhVien.Ten, dbo.MonHoc.TenMH, dbo.MonHoc.SoTC, dbo.Diem.DiemCC, 
                             dbo.Diem.DiemHS1, dbo.Diem.DiemHS2L1, dbo.Diem.DiemHS2L2, 
                             dbo.Diem.DiemQuaTrinh, dbo.Diem.DiemThi, dbo.Diem.DiemHocPhan, dbo.Diem.DiemTBHK
                             FROM dbo.Diem
                             INNER JOIN dbo.MonHoc ON dbo.Diem.MaMH = dbo.MonHoc.MaMH
                             INNER JOIN dbo.SinhVien ON dbo.Diem.MaSV = dbo.SinhVien.MaSV
                             INNER JOIN dbo.LopHocPhan ON dbo.MonHoc.MaMH = dbo.LopHocPhan.MaMH
                             WHERE dbo.SinhVien.MaSV = @MaSV";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private void LoadReport()
        {
            try
            {
                string reportPath = FindReportPath("Report.rdlc");

                if (string.IsNullOrEmpty(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file Report.rdlc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer1.LocalReport.ReportPath = reportPath;
                DataTable dtDiem = GetDiemSinhVien();

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtDiem));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FindReportPath(string reportFileName)
        {
            string[] possiblePaths = new string[]
            {
                Path.Combine(Application.StartupPath, reportFileName),
                Path.Combine(Directory.GetCurrentDirectory(), reportFileName),
                Path.GetFullPath(reportFileName),
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, reportFileName)
            };

            foreach (var path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }
            return null;
        }

        // Thêm chức năng xuất PDF nếu cần
        private void ExportReport(string format = "PDF")
        {
            try
            {
                byte[] bytes = reportViewer1.LocalReport.Render(format: format, deviceInfo: null);

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
