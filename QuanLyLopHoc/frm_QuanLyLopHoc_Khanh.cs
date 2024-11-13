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
    
    public partial class frm_QuanLyLopHoc_Khanh : Form
    {
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sqlda;
        public frm_QuanLyLopHoc_Khanh()
        {
            InitializeComponent();
        }
        public void PhanQuyen()
        {
            if (Program.loaiND == 3 || Program.loaiND == 4) // sinh vien
            {
                btn_Them.Visible = false;
                btn_Sua.Visible = false;
                btn_Xoa.Visible = false;
            }
        }
        #region NÚT THÊM
        private void btn_Them_Click(object sender, EventArgs e)
        {
                frm_ThemLopHoc_Khanh them = new frm_ThemLopHoc_Khanh();
                this.Hide();
                them.ShowDialog();
                HienThi();
                this.Show();
        }
        #endregion

        #region NÚT SỬA
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_QuanLyLopHoc_Khanh.CurrentRow != null)
            {
                string MaLop = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[0].Value.ToString();
                string TenLop = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[1].Value.ToString();
                string KhoaHoc = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[2].Value.ToString();
                string HeDaoTao = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[3].Value.ToString();
                string NamNhapHoc = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[4].Value.ToString();
                string MaKhoa = dgv_QuanLyLopHoc_Khanh.CurrentRow.Cells[5].Value.ToString();

                // Khởi tạo form sửa và gán các thuộc tính
                frm_Sua_Khanh sua = new frm_Sua_Khanh
                {
                    MaLop = MaLop,
                    TenLop = TenLop,
                    KhoaHoc = KhoaHoc,
                    HeDaoTao = HeDaoTao,
                    NamNhapHoc = NamNhapHoc,
                    MaKhoa = MaKhoa
                };

                this.Hide();
                sua.ShowDialog();
                HienThi();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi sửa.", "Thông báo");
            }
        }
        #endregion

        #region NÚT XOÁ
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            frm_XoaLopHoc_Khanh xoa = new frm_XoaLopHoc_Khanh();
            this.Hide();
            xoa.ShowDialog();
            HienThi();
            this.Show();
        }
        #endregion

        #region NÚT TÌM KIẾM
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = TruyVan.ExecuteQuery("SELECT * FROM LOPHOC").Tables[0]; // Lấy danh sách tất cả lớp học
            frm_TimKiemLopHoc_Khanh timkiem = new frm_TimKiemLopHoc_Khanh(dt); // Truyền dữ liệu vào form tìm kiếm
            this.Hide();
            timkiem.ShowDialog();
            this.Show();
        }
        #endregion

        #region NÚT THOÁT
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region FORM LOAD
        private void frm_QuanLyLopHoc_Khanh_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        //public void connect()
        //{
        //    //Tạo kết nối
        //    string ketnoi;
        //    ketnoi = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
        //    conn = new SqlConnection(ketnoi);
        //    conn.Open();
        //}
        //public void dongketnoi()
        //{
        //    if (conn != null && conn.State == ConnectionState.Open)
        //        conn.Close();
        //}
        public void HienThi()
        {
            try
            {
                //Cách 1: 
                //connect();
                //string sql = "SELECT * FROM LOPHOC";
                //sqlda = new SqlDataAdapter(sql, conn);
                //ds = new DataSet();
                //sqlda.Fill(ds);
                //dgv_QuanLyLopHoc_Khanh.DataSource = ds.Tables[0];

                //Cách 2: Sử dụng class Truy Vấn riêng
                string sql = "SELECT * FROM LOPHOC";
                DataSet ds = TruyVan.ExecuteQuery(sql);
                dgv_QuanLyLopHoc_Khanh.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi");
            }
        }
        #endregion

        #region NÚT SẮP XẾP
        private void btn_SapXep_Khanh_Click(object sender, EventArgs e)
        {
            //frm_SapXep_Khanh sapxep = new frm_SapXep_Khanh();
            //this.Hide();
            //sapxep.ShowDialog();
            //HienThi();
            //this.Show();
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
                dgv_QuanLyLopHoc_Khanh.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lớp: " + ex.Message);
            }
        }
        #endregion
    }
}
