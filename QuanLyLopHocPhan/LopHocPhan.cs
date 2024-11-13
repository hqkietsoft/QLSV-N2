using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using Nhom2_QuanLySinhVien.Model;

namespace Nhom2_QuanLySinhVien
{
    public partial class LopHocPhan : UserControl
    {
        private ConnectionData connectDB;
        public LopHocPhan()
        {
            InitializeComponent();
            string conString = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            connectDB = new ConnectionData(conString);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM LopHocPhan";
            DataTable dataTable = connectDB.ExecuteQuery(query);

            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[rowIndex].Cells["MaLop"].Value = row["MaLop"];
                guna2DataGridView1.Rows[rowIndex].Cells["MaMH"].Value = row["MaMH"];
                guna2DataGridView1.Rows[rowIndex].Cells["MaGV"].Value = row["MaGV"];
                guna2DataGridView1.Rows[rowIndex].Cells["HocKy"].Value = row["HocKy"];
                guna2DataGridView1.Rows[rowIndex].Cells["Nam"].Value = row["Nam"];
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void LopHocPhan_Load(object sender, EventArgs e)
        {
            
        }


        private void MaLopCount()
        {
            int count = guna2DataGridView1.Rows.Cast<DataGridViewRow>()
                          .Count(row => !row.IsNewRow && row.Cells["MaLop"].Value != null && row.Cells["MaLop"].Value.ToString() != "");

            label3.Text = $"{count}";
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            int buttonCount = panel3.Controls.OfType<Button>().Count();
            if (buttonCount == 0) return;

            int buttonWidth = 120;
            int buttonHeight = 45;
            int space = 150;

            int totalWidth = buttonCount * buttonWidth + (buttonCount - 1) * space;
            int startX = (panel3.Width - totalWidth) / 2;
            int y = (panel3.Height - buttonHeight) / 2;

            int x = startX;

            foreach (Button btn in panel3.Controls.OfType<Button>())
            {
                btn.SetBounds(x, y, buttonWidth, buttonHeight);
                x += buttonWidth + space;

            }
        }

        private void addUserControl(UserControl function)
        {
            function.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(function);
            function.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemLopHocPhan them = new ThemLopHocPhan();
            addUserControl(them);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = guna2TextBox1.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                MaLopCount();
                return;
            }

            string query = "SELECT * FROM LopHocPhan WHERE MaLop LIKE @keyword OR MaMH LIKE @keyword OR MaGV LIKE @keyword OR HocKy LIKE @keyword OR Nam LIKE @keyword";

            SqlParameter param = new SqlParameter("@keyword", "%" + keyword + "%");

            DataTable dataTable = connectDB.ExecuteQuery(query, new SqlParameter[] { param });

            guna2DataGridView1.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[rowIndex].Cells["MaLop"].Value = row["MaLop"];
                guna2DataGridView1.Rows[rowIndex].Cells["MaMH"].Value = row["MaMH"];
                guna2DataGridView1.Rows[rowIndex].Cells["MaGV"].Value = row["MaGV"];
                guna2DataGridView1.Rows[rowIndex].Cells["HocKy"].Value = row["HocKy"];
                guna2DataGridView1.Rows[rowIndex].Cells["Nam"].Value = row["Nam"];
            }
            MaLopCount();
        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = guna2DataGridView1.SelectedRows[0];
                SuaLopHocPhan sua = new SuaLopHocPhan(
                    row.Cells["MaLop"].Value.ToString(),
                    row.Cells["MaMH"].Value.ToString(),
                    row.Cells["MaGV"].Value.ToString(),
                    row.Cells["HocKy"].Value.ToString(),
                    row.Cells["Nam"].Value.ToString()
                );
                addUserControl(sua);
            }
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (guna2Button4 != null)
                {
                    guna2Button4.Checked = true;
                    if (guna2Button4.Checked)
                    {
                        DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                        SuaLopHocPhan sua = new SuaLopHocPhan(
                            row.Cells["MaLop"].Value.ToString(),
                            row.Cells["MaMH"].Value.ToString(),
                            row.Cells["MaGV"].Value.ToString(),
                            row.Cells["HocKy"].Value.ToString(),
                            row.Cells["Nam"].Value.ToString()
                        );

                        addUserControl(sua);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn nút sửa trước khi chỉnh sửa.");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = guna2DataGridView1.SelectedRows[0];

            string maLop = row.Cells["MaLop"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp học phần với Mã Lớp: {maLop}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM LopHocPhan WHERE MaLop = @MaLop";

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaLop", maLop)
            };

                    connectDB.ExecuteNonQuery(query, parameters);

                    MessageBox.Show("Xóa lớp học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MaLopCount();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LopHocPhan_Load_1(object sender, EventArgs e)
        {
            LoadData();
            MaLopCount();
        }
    }
}
