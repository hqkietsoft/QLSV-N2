using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;
namespace Nhom2_QuanLySinhVien
{
	internal class Login
	{
		SqlCommand command;
		SqlDataReader reader;
		KetnoiModel kn = new KetnoiModel();
		private string username, password;
		private string loaiND;
		private static Login instance;
		public static Login NguoiDung
		{
			get
			{
				if (instance == null)
					instance = new Login();
				return instance;
			}
		}

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string LoaiND { get => loaiND; set => loaiND = value; }

		public DataTable SelectAllUser()
		{
			try
			{
				string getAll = "SELECT * FROM NGUOIDUNG ";
				command = new SqlCommand(getAll, kn.openConnection());
				reader = command.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				return dt;
			}
			catch (Exception ex) {
				MessageBox.Show("Không có tên đăng nhập nào từ cơ sở dữ liệu hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return null; 
		}
		public int checkLogin(string tendn, string matkhau)
		{
			try
			{
				string queryToNguoiDung = "select LoaiND from NguoiDung where TenDN = @user and MatKhau = @pass";
				command = new SqlCommand(queryToNguoiDung, kn.openConnection());
				command.Parameters.AddWithValue("@user", tendn);
				command.Parameters.AddWithValue("@pass", matkhau);
				reader = command.ExecuteReader();
				if (reader.Read())
					Program.loaiND = int.Parse(reader["LoaiND"].ToString());
				kn.closeConnection();
			}	
			catch (Exception ex) {
				MessageBox.Show("Lỗi : " + ex.Message, " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return Program.loaiND;
		}
		
		public void GetAllByUsername(ComboBox user, TextBox tb)
		{
			string queryOnce = "SELECT * FROM NguoiDung WHERE TenDN LIKE @search";
			try
			{
				command = new SqlCommand(queryOnce, kn.openConnection());
				command.Parameters.AddWithValue("@search", "%" + user.Text + "%");
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					tb.Text = dt.Rows[0][1].ToString();
				}
				kn.closeConnection();
			}
			catch (Exception e)
			{
				MessageBox.Show("Thông tin lỗi: " + e.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void ShowOnComboBox(ComboBox cbo)
		{
			foreach (DataRow item in SelectAllUser().Rows)
			{
				cbo.Items.Add(item[0]);
			}
		}
		public void ChagePassword(string user, string pass)
		{
			try
			{
				string query = "UPDATE NguoiDung SET MatKhau = @pass WHERE TenDN = @user";
				command = new SqlCommand(query, kn.openConnection());
				command.Parameters.AddWithValue("@user", user );
				command.Parameters.AddWithValue("@pass", pass );
				command.ExecuteNonQuery();
				kn.closeConnection();
			}
			catch(Exception e)
			{
				MessageBox.Show("Đổi mật khẩu không thành công", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void UserInfo(int loaind, TextBox username,TextBox password, TextBox TypeOfUser)
		{

			try
			{
				
				string query = "SELECT * FROM NguoiDung WHERE LoaiND=@loaiND";
				
				command = new SqlCommand(query, kn.openConnection());
				command.Parameters.AddWithValue("@loaiND", loaind);
				
				reader = command.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				foreach(DataRow dr in dt.Rows)
				{
					username.Text = dr["TenDN"].ToString();
					password.Text = dr["MatKhau"].ToString();
					TypeOfUser.Text = dr["LoaiND"].ToString();

				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Bạn chưa đăng nhập. Vui lòng đăng nhập để xem thông tin", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

	}
}
