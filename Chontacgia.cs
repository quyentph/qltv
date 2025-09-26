using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgiaodien
{
    public partial class Chontacgia : Form
    {
        private SqlConnection conn;
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        public List<TacGia> cacTacGia = new List<TacGia>(); 
        public Chontacgia()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            GetData("SELECT * FROM TacGia ORDER BY ID_TG ASC");
        }
        private void Chontacgiac_Load(object sender, EventArgs e)
        {
            datatacgia.ClearSelection();
            foreach (DataGridViewRow row in datatacgia.Rows)
            {
                var value = row.Cells[0].Value;
                //Console.WriteLine($"{value} {row.Cells[1].Value}");
                if (value != null)
                {
                    foreach (var tg in cacTacGia)
                    {
                        if ((int)value == tg.ma)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private DataTable GetData(string query)
        {
            var dataTable = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var dataAdapter = new SqlDataAdapter(query, conn);
                    dataAdapter.Fill(dataTable);
                }

                datatacgia.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public bool Execute(string query, params SqlParameter[] args)
        {
            int result = 0;
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(query, conn);
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
        private void btchon_Click(object sender, EventArgs e)
        {
            cacTacGia.Clear();
            foreach (DataGridViewRow row in datatacgia.SelectedRows)
            {
                TacGia tg = new TacGia {
                    ma = (int)row.Cells[0].Value,
                    ten = (string)row.Cells[1].Value
                };
                cacTacGia.Add(tg);
            }
            Close();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datatacgia.Rows)
            {
                row.Selected = false; 
            }
            this.Close();
        }
    }

    public class TacGia
    {
        public int ma = 0;
        public string ten = "";
    }
}