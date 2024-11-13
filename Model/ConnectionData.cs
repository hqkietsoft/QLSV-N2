using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom2_QuanLySinhVien.Model
{
    public class ConnectionData
    {
        private string connectionString;
        private SqlConnection connection;

        public ConnectionData(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Hàm thực thi câu lệnh SQL (INSERT, UPDATE, DELETE)
        public void ExecuteNonQuery(string query, List<SqlParameter> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Hàm thực thi câu lệnh SQL lấy dữ liệu (SELECT)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
