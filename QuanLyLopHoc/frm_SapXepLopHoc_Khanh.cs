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
    public partial class frm_SapXepLopHoc_Khanh : Form
    {
        public frm_SapXepLopHoc_Khanh()
        {
            InitializeComponent();
            LoadDanhSachLop(); // Tải dữ liệu danh sách lớp khi mở form
        }
        // Phương thức để tải dữ liệu danh sách lớp vào DataGridView
        private void LoadDanhSachLop()
        {
            dgv_SapXep_Khanh.DataSource = TruyVan.ExecuteQuery("SELECT * FROM LOPHOC").Tables[0];
        }
        public DataTable LayDanhSachLop()
        {
            string query = "SELECT * FROM LopHoc ORDER BY TenLop ASC";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(TruyVan.KetNoi))
                {
                    conn.Open(); 
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lớp: " + ex.Message);
            }

            return dt;
        }

        //private void SapXepTheoCot(string tenCot, string thuTu = "ASC")
        //{
        //    if (tenCot == "MaLop")
        //    {
        //        MessageBox.Show("Không thể sắp xếp theo cột Mã Lớp.");
        //        return;
        //    }

        //    DataTable dt = dgv_SapXep_Khanh.DataSource as DataTable;
        //    if (dt != null)
        //    {
        //        DataView dv = new DataView(dt);
        //        dv.Sort = $"{tenCot} {thuTu}";
        //        dgv_SapXep_Khanh.DataSource = dv;
        //    }
        //}


        private void btn_SapXep_Khanh_Click(object sender, EventArgs e)
        {
            //SapXepTheoCot("NamNhapHoc", "ASC");
            // Lấy danh sách lớp đã sắp xếp từ phương thức LayDanhSachLop
            DataTable dt = LayDanhSachLop();

            // Gán dữ liệu đã sắp xếp cho DataGridView
            dgv_SapXep_Khanh.DataSource = dt;
        }

        private void btn_Huy_Khanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
