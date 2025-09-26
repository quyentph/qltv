using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Giao_dien_dang_nhap
{
    internal class Data
    {
        private SqlConnection sqlcon;
        private SqlDataReader sqladapter;
        private DataTable datatable;
        string ConnectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        public DataTable GetData(string query)
        {
            using (var sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                var cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                var datatable = new DataTable();
                var dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(datatable);
                return datatable;
            }
        }
        public bool Excute(string query, params SqlParameter[] args)
        {
            bool result = false;
            using (var sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddRange(args);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    result = true;
                }
                sqlCon.Close();
                return result;

            }
        }
        public string GetStringConnection()
        {
            return ConnectionString;
        }
        public string Scalar(string query, params SqlParameter[] args)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddRange(args);
                        //String s = cmd.ExecuteScalar().ToString();
                        return (cmd.ExecuteScalar() == null) ? null : cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
