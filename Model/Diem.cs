using Nhom2_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Nhom2.Model
{
	public class Diem
	{
		KetnoiModel kn = new KetnoiModel();
		SqlCommand command;
		SqlDataReader dr;
		SqlDataAdapter da;
		DataTable dt;
		private static Diem diem;
		private string masv, mamh;
		private float diemcc, diemhs1, diemhs2l1, diemhs2l2, diemthi, diemquatrinh, diemhocphan, diemtbhk;
		public static Diem DIEM
		{
			get
			{
				if (diem == null)
					diem = new Diem();
				return diem;
			}
		}

		public string Masv { get => masv; set => masv = value; }
		public string Mamh { get => mamh; set => mamh = value; }
		public float Diemcc { get => diemcc; set => diemcc = value; }
		public float Diemhs1 { get => diemhs1; set => diemhs1 = value; }
		public float Diemhs2l1 { get => diemhs2l1; set => diemhs2l1 = value; }
		public float Diemhs2l2 { get => diemhs2l2; set => diemhs2l2 = value; }
		public float Diemthi { get => diemthi; set => diemthi = value; }
		public float Diemquatrinh { get => diemquatrinh; set => diemquatrinh = value; }
		public float Diemhocphan { get => diemhocphan; set => diemhocphan = value; }
		public float Diemtbhk { get => diemtbhk; set => diemtbhk = value; }

		public DataTable LayDuLieuDiem_Monhoc_SinhVien()
		{
			try
			{
				string sql = "SELECT DIEM.MaSV, SINHVIEN.HoDem, SinhVien.Ten, DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, Diem.DiemHocPhan, DIEM.DiemTBHK FROM DIEM JOIN SinhVien ON DIEM.MaSV = SinhVien.MaSV JOIN MonHoc ON DIEM.MaMH = MonHoc.MaMH";
				command = new SqlCommand(sql, kn.openConnection());
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;

		}

        public DataTable LayDuLieuDiem_Monhoc_SinhVien1()
        {
            try
            {
                string sql = "SELECT DIEM.MaSV, SinhVien.HoDem, SinhVien.Ten, DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, DIEM.DiemCC, DIEM.DiemHS1, DIEM.DiemHS2L1, Diem.DiemHS2L2, DIEM.DiemQuaTrinh, DIEM.DiemThi, Diem.DiemHocPhan, DIEM.DiemTBHK FROM DIEM JOIN SinhVien ON DIEM.MaSV = SinhVien.MaSV JOIN MonHoc ON DIEM.MaMH = MonHoc.MaMH";
                command = new SqlCommand(sql, kn.openConnection());
                dr = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                kn.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            return null;

        }

        public DataTable LayDuLieuDiem_Monhoc_SinhVien_Cbo(string hocky)
		{
			try
			{
				string sql = "SELECT DIEM.MaSV, SinhVien.HoDem, SinhVien.Ten, DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, DIEM.DiemCC, DIEM.DiemHS1, DIEM.DiemHS2L1, Diem.DiemHS2L2, DIEM.DiemQuaTrinh, DIEM.DiemThi, Diem.DiemHocPhan, DIEM.DiemTBHK FROM DIEM JOIN SinhVien ON DIEM.MaSV = SinhVien.MaSV JOIN MonHoc ON DIEM.MaMH = MonHoc.MaMH WHERE Diem.MaMH LIKE @hocky";
				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@hocky", $"%MH{hocky}%");
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;

		}
		public void HienThiLenDataGridView(DataGridView dgv)
		{
			dgv.DataSource = LayDuLieuDiem_Monhoc_SinhVien1();
		}
		public DataTable LayDuLieuSV()
		{
			try
			{
				string sql = "SELECT * FROM SINHVIEN";
				command = new SqlCommand(sql, kn.openConnection());
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;
		}
		
		public void HienThiLenComboboxSV(ComboBox cbo)
		{
			foreach (DataRow dr in LayDuLieuSV().Rows)
			{
				cbo.Items.Add($"{dr["MaSV"]} -{dr["HoDem"]} {dr["Ten"]}");
			}
		}
		public DataTable HienThiDiemLenCBO(string hocky)
		{
			try
			{
				string sql = "SELECT distinct dbo.Diem.MaSV FROM dbo.Diem INNER JOIN dbo.LopHocPhan ON dbo.Diem.MaMH = dbo.LopHocPhan.MaMH INNER JOIN  dbo.MonHoc ON dbo.Diem.MaMH = dbo.MonHoc.MaMH AND dbo.LopHocPhan.MaMH = dbo.MonHoc.MaMH WHERE HocKy = @hocky";
				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@hocky", hocky);
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();

				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;
		}

		public DataTable TinhDiemTBHK(string masv, string hocky)
		{
			try
			{
				string sql = "SELECT distinct dbo.Diem.MaSV,DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, Diem.DiemHocPhan, Diem.DiemTBHK FROM dbo.Diem INNER JOIN dbo.LopHocPhan ON dbo.Diem.MaMH = dbo.LopHocPhan.MaMH INNER JOIN  dbo.MonHoc ON dbo.Diem.MaMH = dbo.MonHoc.MaMH AND dbo.LopHocPhan.MaMH = dbo.MonHoc.MaMH WHERE HocKy = @hocky AND MaSV = @masv";

				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@masv", masv);
				command.Parameters.AddWithValue("@hocky", hocky);

				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();

				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;
		}
		
		public void UpdateDiemTBHK(double diem, string masv)
		{
			try
			{
				string sql = "UPDATE Diem SET DiemTBHK = @diem WHERE MaSV = @masv";
				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@diem", diem);
				command.Parameters.AddWithValue("@masv", masv);
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
		}

		public DataTable XetHocBong(string hocky)
		{
			try
			{
				string sql = "SELECT TOP 10 PERCENT Diem.MaSV, SinhVien.HoDem, SinhVien.Ten, DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, Diem.DiemHocPhan, Diem.DiemTBHK FROM DIEM JOIN SinhVien ON DIEM.MaSV = SinhVien.MaSV JOIN MonHoc ON DIEM.MaMH = MonHoc.MaMH WHERE DIEM.DiemTBHK >= 7 AND Diem.MaMH LIKE @hocky ORDER BY DIEM.DiemTBHK DESC";
				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@hocky",$"%MH{hocky}%");
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;
		}
		
		//tim kiem dua theo ten mon hoc va diem sv
		public DataTable TimKiemDiemMonHoc(string diem)
		{
			try
			{
				string sql = "SELECT Diem.MaSV, SinhVien.HoDem, SinhVien.Ten, DIEM.MaMH, MonHoc.TenMH, MonHoc.SoTC, Diem.DiemHocPhan, Diem.DiemTBHK FROM DIEM JOIN SinhVien ON DIEM.MaSV = SinhVien.MaSV JOIN MonHoc ON DIEM.MaMH = MonHoc.MaMH WHERE DIEM.DiemTBHK like @d";
				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@d", $"%{diem}%");
				dr = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(dr);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show("Không có dữ liệu");
			}
			return null;
		}


		public void UpdateDiemQuaTrinh(string maSV, string maMH, float diemCC, float diemHS1, float diemHS2L1, float diemHS2L2, float diemQuaTrinh)
		{
			try
			{
				string sql = @"
								UPDATE DIEM 
								SET DiemCC = @diemCC, 
									DiemHS1 = @diemHS1, 
									DiemHS2L1 = @diemHS2L1, 
									DiemHS2L2 = @diemHS2L2, 
									DiemQuaTrinh = @diemQuaTrinh
								WHERE MaSV = @maSV AND MaMH = @maMH";

				command = new SqlCommand(sql, kn.openConnection());
				command.Parameters.AddWithValue("@diemCC", diemCC);
				command.Parameters.AddWithValue("@diemHS1", diemHS1);
				command.Parameters.AddWithValue("@diemHS2L1", diemHS2L1);
				command.Parameters.AddWithValue("@diemHS2L2", diemHS2L2);
				command.Parameters.AddWithValue("@diemQuaTrinh", diemQuaTrinh);
				command.Parameters.AddWithValue("@maSV", maSV);
				command.Parameters.AddWithValue("@maMH", maMH);

				// Thực thi câu lệnh update và kiểm tra số dòng bị ảnh hưởng
				int rowsAffected = command.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Cập nhật điểm thành công.");
				}
				else
				{
					MessageBox.Show("Không tìm thấy sinh viên hoặc môn học để cập nhật.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi khi lưu điểm: " + ex.Message);
			}
			finally
			{
				kn.closeConnection(); // Đảm bảo đóng kết nối
			}
		}

        public int LaySoTinChi(string maMH)
        {
            int soTC = 0;
            try
            {
                string sql = "SELECT SoTC FROM MonHoc WHERE MaMH = @maMH";
                command = new SqlCommand(sql, kn.openConnection());
                command.Parameters.AddWithValue("@maMH", maMH);
                soTC = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy số tín chỉ: " + ex.Message);
            }
            finally
            {
                kn.closeConnection();
            }
            return soTC;
        }
    }
}
