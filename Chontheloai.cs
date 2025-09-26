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
    public partial class Chontheloai : Form
    {
        private SqlConnection conn;
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        public List<LoaiSachMoi> cacLoaiSach = new List<LoaiSachMoi>();
        public Chontheloai()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            GetData("SELECT * FROM LoaiSach ORDER BY ID_LS ASC");
        }

        private void Chontheloai_Load(object sender, EventArgs e)
        {
            dataloaisach.ClearSelection();
            foreach (DataGridViewRow row in dataloaisach.Rows)
            {
                var value = row.Cells[0].Value;
                if (value != null)
                {
                    foreach (var ls in cacLoaiSach)
                    {
                        if ((int)value == ls.ma1)
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

                dataloaisach.DataSource = dataTable;
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
        private void bthuy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataloaisach.Rows)
            {
                row.Selected = false;
            }
            this.Close();
        }

        private void btchon_Click(object sender, EventArgs e)
        {
            cacLoaiSach.Clear();
            foreach (DataGridViewRow row in dataloaisach.SelectedRows)
            {
                LoaiSachMoi ls = new LoaiSachMoi
                {
                    ma1 = (int)row.Cells[0].Value,
                    ten1 = (string)row.Cells[1].Value
                };
                cacLoaiSach.Add(ls);
            }
            Close();
        }
    }
    public class LoaiSachMoi
    {
        public int ma1 = 0;
        public string ten1 = "";
    }
}
