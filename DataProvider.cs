using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhieuTraMuon
{
    public class DataProvider
    {
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        public DataTable GetData(string query)
        {
            
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var dt = new DataTable();
                    var cmd = new SqlCommand(query, conn);
                    var dataAdapter = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    dataAdapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            
        }
        public DataTable GetDataWithParam(string query, params SqlParameter[] args)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var dt = new DataTable();
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(args);
                var dataAdapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                dataAdapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public bool Execute(string query, params SqlParameter[] args)
        {
            int result = 0;
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddRange(args);
                    result = cmd.ExecuteNonQuery(); 
                    conn.Close();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        
    }
}
