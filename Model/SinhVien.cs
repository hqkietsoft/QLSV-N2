using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;

namespace Nhom2_QuanLySinhVien.Model
{
    internal class SinhVien
    {
        
        private string MaSV, HoDem, Ten, NgaySinh, GioiTinh, QueQuan, MaLop, TenDN;
        private int SoDT;
        private static SinhVien instance;
        KetnoiModel kn = new KetnoiModel();
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        private SinhVien() { }

        public static SinhVien SV
        {
            get
            {
                if (instance == null)
                    instance = new SinhVien();
                return instance;
            }
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string HoDem1 { get => HoDem; set => HoDem = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string TenDN1 { get => TenDN; set => TenDN = value; }
        public int SoDT1 { get => SoDT; set => SoDT = value; }

        #region Hiển thi lên DataGridView
        

        private DataTable HienThiDuLieu_sinhvien()
        {
            try
            {
                string sqlHienThi = "SELECT * FROM SinhVien";
                adapter = new SqlDataAdapter(sqlHienThi, kn.openConnection());
                dt = new DataTable();
                adapter.Fill(dt);
                kn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống báo lỗi( Không thể hiển thị danh sách sinh viên): " + ex.Message, "Hiển thị danh sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
            
        }
        private DataTable HienThiDuLieu_lophoc()
        {
            try
            {
                string sqlHienThi = "SELECT * FROM LopHoc";
                adapter = new SqlDataAdapter(sqlHienThi, kn.openConnection());
                dt = new DataTable();
                adapter.Fill(dt);
                kn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống báo lỗi( Không thể hiển thị danh sách lớp học ): " + ex.Message, "Hiển thị danh sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        private DataTable HienThiDuLieu_nguoidung()
        {
            try
            {
                string sqlHienThi = "SELECT * FROM NguoiDung";
                adapter = new SqlDataAdapter(sqlHienThi, kn.openConnection());
                dt = new DataTable();
                adapter.Fill(dt);
                kn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống báo lỗi( Không thể hiển thị danh sách người dùng): " + ex.Message, "Hiển thị danh sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public void Show_All(DataGridView dgv)
        {
            dgv.DataSource = HienThiDuLieu_sinhvien();
            
        }
        #endregion
        private bool Check_Ma_TenDN(string NameOrID)
        {
            try
            {
                string sqlcheck = "SELECT * FROM SinhVien WHERE MaSV LIKE @nameOrId OR TenDN LIKE @nameOrId";
                command = new SqlCommand(sqlcheck, kn.openConnection());
                command.Parameters.AddWithValue("@nameOrId", "%" + NameOrID + "%");
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    kn.closeConnection();
                    return true;
                }
                kn.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không truy xuất được cơ sở dữ liệu : " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public void Laydulieu_ma_ten(ComboBox nameOrId, ComboBox cbo, TextBox tb, int i, int j)
        {
            string sql1 = "SELECT * FROM SinhVien WHERE MaSV LIKE @search OR TenDN LIKE @search";
            try
            {
                command = new SqlCommand(sql1, kn.openConnection());
                command.Parameters.AddWithValue("@search", "%" + nameOrId.Text + "%");
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cbo.SelectedItem = dt.Rows[0][i].ToString();
                    tb.Text = dt.Rows[0][j].ToString();
                }
                kn.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Thông tin lỗi: " + e.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllByID_SuaThongTin(ComboBox ID, TextBox tb, TextBox tb1, int i, int j)
        {
            string queryOnce = "SELECT * FROM SinhVien WHERE MaSV LIKE @id";
            try
            {
                command = new SqlCommand(queryOnce, kn.openConnection());
                command.Parameters.AddWithValue("@id", "%" + ID.Text + "%");
                adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    tb.Text = dt.Rows[0][i].ToString();
                    tb1.Text = dt.Rows[0][j].ToString();
                }
                kn.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Thông tin lỗi: " + e.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowOnComboBox(ComboBox cbo, int i)
        {
            foreach (DataRow item in HienThiDuLieu_lophoc().Rows)
            {
                cbo.Items.Add(item[i]);
            }
        }
        public void ShowOnComboBox1(ComboBox cbo, int i)
        {
            foreach (DataRow item in HienThiDuLieu_nguoidung().Rows)
            {
                cbo.Items.Add(item[i]);
            }
        }

        public void Them(string masv, string hodem, string ten, DateTimePicker ngaysinh, string gioitinh , string quequan, string sdt, string malop, ComboBox cbbTenDN)
        {

            string tendn = cbbTenDN.SelectedItem.ToString();

            if (Check_Ma_TenDN(masv))
            {
                MessageBox.Show("Đã tồn tại mã sinh viên!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Check_Ma_TenDN(tendn))
            {
                MessageBox.Show("Đã tồn tại tên đăng nhập!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string sqlThem = "INSERT INTO SinhVien (MaSV, HoDem, Ten, NgaySinh, GioiTinh, QueQuan, SoDT, MaLop, TenDN) " +
                                     "VALUES (@MaSV, @HoDem, @Ten, @NgaySinh, @GioiTinh, @QueQuan, @SoDT, @MaLop, @TenDN)";
                    command = new SqlCommand(sqlThem, kn.openConnection());
                    command.Parameters.AddWithValue("@MaSV", masv);
                    command.Parameters.AddWithValue("@HoDem", hodem);
                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@NgaySinh", ngaysinh.Value.ToString());
                    command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                    command.Parameters.AddWithValue("@QueQuan", quequan);
                    command.Parameters.AddWithValue("@SoDT", sdt);
                    command.Parameters.AddWithValue("@MaLop", malop);
                    command.Parameters.AddWithValue("@TenDN", tendn);  // Use the selected TenDN
                    command.ExecuteNonQuery();
                    kn.closeConnection();
                    MessageBox.Show($"Thêm mới sinh viên {ten} thành công", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hệ thống báo lỗi( Không thể thêm mới sinh viên): " + ex.Message, "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Xoa(string masv, string tendn)
        {
                try
                {
                    string sqlXoa = "DELETE FROM SinhVien WHERE MaSV = @masv";

                    command = new SqlCommand(sqlXoa, kn.openConnection());
                    command.Parameters.AddWithValue("@masv", masv);
                    command.ExecuteNonQuery();
                    kn.closeConnection();
                    MessageBox.Show($"Đã xóa sinh viên {tendn}", "Xóa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hệ thống báo lỗi (Không thể xóa sinh viên này): " + ex.Message, "Xóa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void Sua(string masv, string hodem, string ten, DateTimePicker ngaysinh, string gioitinh, string quequan, string sodt, string malop, string tendn)
        {
            try
            {
                string sqlSua = "UPDATE SinhVien SET HoDem=@HoDem, Ten=@Ten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, QueQuan=@QueQuan, SoDT=@SoDT, MaLop=@MaLop WHERE MaSV=@MaSV";
                command = new SqlCommand(sqlSua, kn.openConnection());
                command.Parameters.AddWithValue("@MaSV", masv);
                command.Parameters.AddWithValue("@HoDem", hodem);
                command.Parameters.AddWithValue("@Ten", ten);
                command.Parameters.AddWithValue("@NgaySinh", ngaysinh.Value.ToString());
                command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                command.Parameters.AddWithValue("@QueQuan", quequan);
                command.Parameters.AddWithValue("@SoDT", sodt);
                command.Parameters.AddWithValue("@MaLop", malop);
                command.Parameters.AddWithValue("@TenDN", tendn);
                command.ExecuteNonQuery();
                kn.closeConnection();
                MessageBox.Show($"Đã sửa thông tin sinh viên : {ten}", "Sửa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hệ thống báo lỗi : {e.Message}", "Sửa thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public DataTable TimKiem(string timkiem)
        {
            try
            {
                string sqlTK = "SELECT * FROM SinhVien WHERE MaSV LIKE @info OR Ten LIKE @info OR MaLop LIKE @info";
                command = new SqlCommand(sqlTK, kn.openConnection());
                command.Parameters.AddWithValue("@info", "%" + timkiem + "%");
                reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                kn.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Không tìm thấy sinh viên : {e.Message}", "Tìm kiếm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return null;
        }
        public DataTable SapXep()
        {
            try
            {
                string sqlSX = "SELECT * FROM SinhVien ORDER BY Ten";
                command = new SqlCommand(sqlSX, kn.openConnection());
                reader = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                kn.closeConnection();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách sinh viên: " + ex.Message);
            }
            return null;
        }
    }
}
