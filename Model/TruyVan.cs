using System;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien
{
    internal class TruyVan
    {
        #region Kết nối csdl
        private static SqlConnection conn;

        public static readonly string KetNoi = "Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False";
        //public static readonly string KetNoi = "Data Source=DESKTOP-EC4KK8E\\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
        public static SqlConnection moKeNoi()
        {
            if (conn == null)
            {
                conn = new SqlConnection(KetNoi);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public static void dongKetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        #endregion

        #region Lệnh thực thi truy vấn 

        public static DataSet ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, moKeNoi()))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }
            finally
            {
                dongKetNoi();
            }
            return ds;
        }
        #endregion

        #region Lệnh thực thi Thêm, Sửa, Xoá

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int kq;
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, moKeNoi()))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    kq = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }
            finally
            {
                dongKetNoi();
            }
            return kq;
        }
        #endregion

        #region Hàm kiểm tra tồn tại Mã Lớp
        public static bool KiemTra(string maLop)
        {
            string query = "SELECT COUNT(*) FROM LOPHOC WHERE MaLop = @MaLop";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@MaLop", maLop) };

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, moKeNoi()))
                {
                    cmd.Parameters.AddRange(parameters);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra mã lớp: " + ex.Message);
            }
            finally
            {
                dongKetNoi();
            }
        }
        #endregion

        #region Hàm lấy dữ liệu Khoa
        public static DataTable LayDuLieuKhoa()
        {
            string query = "SELECT MaKhoa, TenKhoa FROM Khoa"; // Câu lệnh SQL lấy mã và tên khoa
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, moKeNoi()))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu khoa: " + ex.Message);
            }
            finally
            {
                dongKetNoi();
            }
            return dt;
        }
        #endregion

        #region Lấy danh sách Mã lớp
        public static DataTable LayDanhSachMaLop()
        {
            string query = "SELECT MaLop FROM LOPHOC";
            return ExecuteQuery(query).Tables[0];
        }
        #endregion

        #region Lấy thông tin dựa vào Mã lớp
        public static DataTable LayThongTinLop(string maLop)
        {
            string query = "SELECT TenLop, KhoaHoc, HeDaoTao, NamNhapHoc FROM LOPHOC WHERE MaLop = @MaLop";
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, moKeNoi()))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin lớp học: " + ex.Message);
            }
            finally
            {
                dongKetNoi();
            }
            return dt;
        }
        #endregion

        #region Xoá lớp học
        public static int XoaLop(string maLop)
        {
            string query = "DELETE FROM LOPHOC WHERE MaLop = @MaLop";
            SqlParameter[] parameters = { new SqlParameter("@MaLop", maLop) };
            return ExecuteNonQuery(query, parameters);
        }
        #endregion

        #region Tìm Kiếm
        public static DataTable TimKiemLop(string tuKhoa, string maKhoa)
        {
            // Câu truy vấn tìm kiếm theo mã lớp, tên lớp, khóa học, hệ đào tạo và năm nhập học
            string query = @"SELECT * FROM LOPHOC 
                     WHERE (MaLop LIKE @TuKhoa 
                            OR TenLop LIKE @TuKhoa 
                            OR KhoaHoc LIKE @TuKhoa 
                            OR HeDaoTao LIKE @TuKhoa 
                            OR NamNhapHoc LIKE @TuKhoa)";

            if (!string.IsNullOrEmpty(maKhoa))
            {
                query += " AND MaKhoa = @MaKhoa";
            }

            SqlParameter[] parameters =
            {
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%"),
                new SqlParameter("@MaKhoa", maKhoa ?? (object)DBNull.Value)
            };

            return ExecuteQuery(query, parameters).Tables[0];
        }
        #endregion


        //Các câu lệnh triuy vấn xử lý form điểm thi
        public static DataTable LayThongTinSinhVienTheoMonHoc(string maMH)
        {
            string sql = "SELECT Diem.MaSV, SinhVien.HoDem, SinhVien.Ten, Diem.DiemQuaTrinh, Diem.DiemThi, Diem.DiemHocPhan, Diem.MaMH " +
                         "FROM Diem " +
                         "JOIN SinhVien ON Diem.MaSV = SinhVien.MaSV " +
                         "JOIN MonHoc ON Diem.MaMH = MonHoc.MaMH " +
                         "WHERE MonHoc.MaMH = @mh";

            SqlParameter[] parameters = { new SqlParameter("@mh", maMH) };

            return ExecuteQuery(sql, parameters).Tables[0];
        }
        public static DataTable LayDuLieuMonHoc()
        {
            string query = "SELECT MaMH, TenMH FROM MonHoc"; // Truy vấn lấy danh sách môn học từ bảng MonHoc
            return ExecuteQuery(query).Tables[0]; // Trả về bảng dữ liệu
        }
        public static int CapNhatDiem(string maSV, string maMonHoc, float? diemQuaTrinh, float? diemThi, float? diemHocPhan)
        {
            string query = "UPDATE Diem SET DiemQuaTrinh = @DiemQuaTrinh, DiemThi = @DiemThi, DiemHocPhan = @DiemHocPhan WHERE MaSV = @MaSV AND MaMH = @MaMH";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSV", maSV),
                new SqlParameter("@MaMH", maMonHoc),
                new SqlParameter("@DiemQuaTrinh", diemQuaTrinh.HasValue ? (object)diemQuaTrinh.Value : DBNull.Value),
                new SqlParameter("@DiemThi", diemThi.HasValue ? (object)diemThi.Value : DBNull.Value),
                new SqlParameter("@DiemHocPhan", diemHocPhan.HasValue ? (object)diemHocPhan.Value : DBNull.Value)
            };

            return ExecuteNonQuery(query, parameters);
        }
        public static bool XoaDiem(string maSV, string maMonHoc)
        {
            try
            {
                string query = "UPDATE Diem SET DiemThi = NULL, DiemHocPhan = NULL WHERE MaSV = @MaSV AND MaMH = @MaMonHoc";

                SqlParameter[] parameters = {
            new SqlParameter("@MaSV", maSV),
            new SqlParameter("@MaMonHoc", maMonHoc)
        };

                int rowsAffected = ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; // Kiểm tra số dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, có thể ghi log hoặc hiển thị thông báo
                MessageBox.Show("Lỗi: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }
    }
}