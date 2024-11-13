using Nhom2_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.Management.Instrumentation;
using System.Xml.Linq;
using System.Drawing;
namespace Nhom2_QuanLySinhVien.Model
{
	public class MonHoc
	{

		private string maMH, tenMH;
		private int soTC;
		private static MonHoc instance;
		KetnoiModel kn = new KetnoiModel();
		SqlCommand command;
		SqlDataReader reader;
		SqlDataAdapter adapter;
		DataTable dt = new DataTable();

		public string MaMH { get => maMH; set => maMH = value; }
		public string TenMH { get => tenMH; set => tenMH = value; }
		public int SoTC { get => soTC; set => soTC = value; }
		private MonHoc() { }

		public static MonHoc Subject
		{
			get
			{
				if (instance == null)
					instance = new MonHoc();
				return instance;
			}
		}
		
		#region Hiển thi lên DataGridView
		public DataTable SelectAllSubject()
		{
			try
			{
				string queryAll = "SELECT * FROM MonHoc";
				adapter = new SqlDataAdapter(queryAll, kn.openConnection());
				dt.Rows.Clear();
				adapter.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hệ thống báo lỗi( Không thể hiển thị danh sách môn học ): " + ex.Message, "Hiển thị danh sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return dt;
		}
		public void ShowDataOnTable(DataGridView dgv)
		{
			dgv.DataSource = SelectAllSubject();
		}
		#endregion
		private bool checkExistingByID(string NameOrID)
		{
			try
			{
				string queryID = "SELECT * FROM MonHoc WHERE MaMH LIKE @nameOrId OR TenMH LIKE @nameOrId";
				command = new SqlCommand(queryID, kn.openConnection());
				command.Parameters.AddWithValue("@nameOrId",NameOrID);
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
		public void GetAllByNameOrID(ComboBox nameOrId, ComboBox cbo, TextBox tb, int i, int j)
		{
			string queryOnce = "SELECT * FROM MonHoc WHERE MaMH LIKE @search OR TenMH LIKE @search";
			try
			{
				command = new SqlCommand(queryOnce, kn.openConnection());
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
			string queryOnce = "SELECT * FROM MonHoc WHERE MaMH LIKE @id";
			try
			{
				command = new SqlCommand(queryOnce, kn.openConnection());
				command.Parameters.AddWithValue("@id","%" + ID.Text + "%");
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
			foreach (DataRow item in SelectAllSubject().Rows)
			{
				cbo.Items.Add(item[i]);
			}
		}


		public void InsertData(TextBox ma, TextBox ten, ComboBox sotc)
		{

			if (checkExistingByID(ma.Text))
			{
				MessageBox.Show("Đã tồn tại mã môn học", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (checkExistingByID(ten.Text))
			{
				MessageBox.Show("Đã tồn tại tên môn học", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					string queryInsert = "INSERT INTO MonHoc VALUES (@mamonhoc,@tenmonhoc,@sotinchi)";
					command = new SqlCommand(queryInsert, kn.openConnection());
					command.Parameters.AddWithValue("@mamonhoc", ma.Text);
					command.Parameters.AddWithValue("@tenmonhoc", ten.Text);
					command.Parameters.AddWithValue("@sotinchi", sotc.Text);
					command.ExecuteNonQuery();
					kn.closeConnection();
					MessageBox.Show($"Thêm mới môn học {ten.Text} thành công", "Thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hệ thống báo lỗi (Không thể thêm mới môn học): " + ex.Message, "Thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		public void DeleleSubjectByID(ComboBox ma, ComboBox ten)
		{

			if (!checkExistingByID(ma.Text))
			{
				MessageBox.Show("Không tồn tại mã môn học này", "Xóa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					string queryInsert = "DELETE FROM MonHoc WHERE MaMH = @mamonhoc";
					command = new SqlCommand(queryInsert, kn.openConnection());
					command.Parameters.AddWithValue("@mamonhoc", ma.Text);
					command.ExecuteNonQuery();
					kn.closeConnection();
					MessageBox.Show($"Đã xóa môn học {ten.Text}", "Xóa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hệ thống báo lỗi (Không thể xóa môn học này): " + ex.Message, "Xóa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


			}

		}

		public void UpdateSubjectById(string ma, string ten, string sotc)
		{
			try
			{
				string queryUpdate = "UPDATE MonHoc SET TenMH = @tenmonhoc, SoTC = @sotinchi WHERE MaMH = @mamonhoc";
				command = new SqlCommand(queryUpdate, kn.openConnection());
				command.Parameters.AddWithValue("@mamonhoc", ma);
				command.Parameters.AddWithValue("@tenmonhoc", ten);
				command.Parameters.AddWithValue("@sotinchi", sotc);
				command.ExecuteNonQuery();
				kn.closeConnection();
				MessageBox.Show($"Đã sửa môn học : {ten}", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception e)
			{
				MessageBox.Show($"Hệ thống báo lỗi : {e.Message}", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}
		public DataTable SeachingAllByAll(string SearchingInfo)
		{
			try
			{
				string querySeaching = "SELECT * FROM MonHoc WHERE MaMH LIKE @info OR TenMH LIKE @info OR SoTC LIKE @info";
				command = new SqlCommand(querySeaching, kn.openConnection());
				command.Parameters.AddWithValue("@info", "%" + SearchingInfo + "%");
				reader = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(reader);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show($"Hệ thống báo lỗi : {e.Message}", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return null;
		}
		public DataTable SortingByIndexOfCombobox(ComboBox info)
		{
			if(info.Equals("---Chọn thông tin---"))
			{
				MessageBox.Show("Vui lòng chọn thông tin sắp xếp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);	
			}
			try
			{
				string option = "";
				if (info.SelectedIndex == 0)
					option = "MaMH";
				else if (info.SelectedIndex == 1)
					option = "TenMH";
				else if (info.SelectedIndex == 2)
					option = "SoTC ";
				string querySeaching = $"SELECT * FROM MonHoc Order By {option}";
				command = new SqlCommand(querySeaching, kn.openConnection());
				
				reader = command.ExecuteReader();
				dt = new DataTable();
				dt.Load(reader);
				kn.closeConnection();
				return dt;
			}
			catch (Exception e)
			{
				MessageBox.Show($"Hệ thống báo lỗi : {e.Message}", "Sửa thông tin môn học", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return null;
		}
	}

}
