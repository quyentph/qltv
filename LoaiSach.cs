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
    public partial class LoaiSach : Form
    {
        private SqlConnection conn;
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        public LoaiSach()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
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

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(args);
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            return false;
        }   

        private void btthem_Click(object sender, EventArgs e)
        {
            string query = "insert into LoaiSach values (@TenLS)";

            foreach (DataGridViewRow row in dataloaisach.Rows)
            {
                if (row.Cells["Column2"].Value != null && !row.IsNewRow)
                {
                    if (row.Cells["Column2"].Value.ToString() == txtten.Text)
                    {
                        txtma.Clear();
                        txtten.Clear();
                        MessageBox.Show("Đã tồn tại loại sách này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            string ten = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtten.Text.ToLower());
            if (ten.Any(char.IsDigit) || ten.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
            {
                txtma.Clear();
                txtten.Clear();
                MessageBox.Show("Tên không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtten.Text) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlParameter[] pa =
            {
            new SqlParameter("@TenLS",ten),
            };
            if (Execute(query, pa))
            {
                txtma.Clear();
                MessageBox.Show("Thêm loại sách thành công");
                GetData("Select * from LoaiSach order by ID_LS ASC");
                txtma.Clear();
                txtten.Clear();
            }
            else
            {
                MessageBox.Show("Lỗi thêm loại sách.");
            }

        }

        private void Thể_loại_sách_Load(object sender, EventArgs e)
        {
            GetData("SELECT * FROM LoaiSach ORDER BY ID_LS ASC");
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mã loại sách"); 
            comboBox1.Items.Add("Loại sách");
            comboBox1.SelectedIndex = 0; 
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE LoaiSach SET TenLS=@TenLS WHERE ID_LS=@ID_LS";
            foreach (DataGridViewRow row in dataloaisach.Rows)
            {
                if (row.Cells["Column2"].Value != null && !row.IsNewRow)
                {
                    if (row.Cells["Column2"].Value.ToString() == txtten.Text)
                    {
                        txtten.Clear();
                        MessageBox.Show("Đã tồn tại loại sách này!!!");
                        return;
                    }
                }
            }
            string hoten = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtten.Text.ToLower());

            if (hoten.Any(char.IsDigit) || hoten.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
            {
                txtma.Clear();
                txtten.Clear();
                MessageBox.Show("Tên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtten.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlParameter[] pa =
            {
            new SqlParameter("@TenLS", hoten),
            new SqlParameter("@ID_LS", txtma.Text)
            };

            if (Execute(query, pa))
            {
                txtten.Clear();
                txtma.Clear();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData("SELECT * FROM LoaiSach ORDER BY ID_LS ASC");
                txtma.Clear();
                txtten.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy loại sách có mã: " + txtma.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataloaisach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataloaisach.Rows[e.RowIndex].Cells[0] != null)
            {
                txtma.Text = dataloaisach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtten.Text = dataloaisach.Rows[e.RowIndex ].Cells[1].Value.ToString();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtma.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "DELETE FROM LoaiSach WHERE ID_LS=@ID_LS";
                SqlParameter[] pa =
                {
                new SqlParameter("@ID_LS", txtma.Text)
                };

                if (Execute(query, pa))
                {
                    GetData("SELECT * FROM LoaiSach ORDER BY ID_LS ASC");
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtma.Clear();
                    txtten.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do còn liên kết với các bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search()
        {
            if (dataloaisach.DataSource is DataTable dataTable)
            {
                string searchField = comboBox1.SelectedItem?.ToString();
                string filter = "";


                if (string.IsNullOrEmpty(searchField))
                {
                    MessageBox.Show("Vui lòng chọn trường để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (searchField == "Mã loại sách")
                {
                    if (string.IsNullOrEmpty(txttim.Text.Trim()))
                    {
                        filter = "";
                    }
                    else if (int.TryParse(txttim.Text.Trim(), out int id))
                    {
                        filter = $"[ID_LS] = {id}";
                    }
                    else
                    {
                        txttim.Clear();
                        MessageBox.Show("Mã loại sách phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (searchField == "Loại sách")
                {
                    if (txttim.Text.Any(char.IsDigit))
                    {
                        txttim.Clear();
                        MessageBox.Show("Loại sách không có số!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    filter = $"[TenLS] LIKE '%{txttim.Text.Trim()}%'";
                }
                dataTable.DefaultView.RowFilter = filter;
            }
            else
            {
                MessageBox.Show("Dữ liệu nguồn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            Search(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(); 
            txttim.Clear();

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
