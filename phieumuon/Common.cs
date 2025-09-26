using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace QuanLiThuVien_PhieuMuon
{
    public static class Common
    {
        public static readonly string connString = getConnString();

        public static string getConnString()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=quanlithuvien_nhom2;Integrated Security=True;Connection Timeout=3";
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                conn.Close();
            }
            catch (Exception)
            {
               MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu SQL. Vui lòng kiểm tra lại kết nối.", "Lỗi kết nối SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            System.Diagnostics.Debug.WriteLine(connStr);
            return connStr;
        }

        public static bool Execute(string cmd, params object[] parameters)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand command = new SqlCommand(cmd, conn);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    command.Parameters.AddWithValue(parameters[i] as string, parameters[i + 1]);
                }
                command.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static object? ExecuteReturnAValule(string cmd, params object[] parameters)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand command = new SqlCommand(cmd, conn);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    command.Parameters.AddWithValue(parameters[i] as string, parameters[i + 1]);
                }
                var value = command.ExecuteScalar();

                conn.Close();

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int ExecuteReturnInsertedId(string cmd, params object[] parameters)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand command = new SqlCommand(cmd + ";SELECT SCOPE_IDENTITY()", conn);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    command.Parameters.AddWithValue(parameters[i] as string, parameters[i + 1]);
                }
                var insertedId = Convert.ToInt32(command.ExecuteScalar());

                conn.Close();

                return insertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static DataTable GetTable(string cmd, params object[] parameters)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                SqlCommand command = new SqlCommand(cmd, conn);
                for (int i = 0; i < parameters.Length; i += 2)
                {
                    command.Parameters.AddWithValue(parameters[i] as string, parameters[i + 1]);
                }

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                conn.Close();

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi kết nối SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public static DataTable GetBooks(bool allBooks = true)
        {
            string query = allBooks ? "SELECT * FROM TomLuocSach" : "SELECT * FROM TomLuocSach WHERE [Số lượng] > 0";
            DataTable table = GetTable(query);
            table.PrimaryKey = [table.Columns[0]];
            return table;
        }
        //Hàm này dùng reflection để bật chế độ DoubleBuffered cho DataGridView, giúp hiển thị mượt mà hơn, thay vì bị nhấp nháy khi redraw.
        public static void setDoubleBuffered(DataGridView view)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, view, [true]);
        }
        
    }
}
