using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace QuanLyTacGia
{
    public partial class TacGia : Form
    {
        private SqlConnection sqlCon;
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;

        public TacGia()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(connectionString);

        }
        public string QUERY = "EXEC GetBooks2;";
        private DataTable GetData(string query)
        {
            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(query, sqlCon);
                var dataAdapter = new SqlDataAdapter(cmd);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                data1.DataSource = dataTable;
                return dataTable;
            }
        }


        private bool Execute(string query, params SqlParameter[] args)
        {
            bool result = false;
            using (var sqlCon = new SqlConnection(connectionString))
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
        public string ChuanHoaTenRieng(string input)
        {
            input = input.Trim();
            input = input.ToLower();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = ChuanHoaTenRieng(tbTG.Text);
                if (string.IsNullOrEmpty(hoten))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlParameter[] param = {
                new SqlParameter("@TenTG", hoten),
                new SqlParameter("@ID_TG", tbMa.Text)
                };
                if (string.IsNullOrEmpty(tbTG.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Execute("INSERT INTO TacGia VALUES (@TenTG)", param))
                {
                    MessageBox.Show("Thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMa.Clear();
                    tbS.Clear();
                    tbTG.Clear();
                    tbTL.Clear();
                    tbTim.Clear();
                    cbFilter.SelectedIndex = -1;
                    tbMa.Enabled = false;
                    GetData(QUERY);
                }
                else
                {
                    MessageBox.Show("Không thêm được thông tin tác giả");
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetData(QUERY);
            cbFilter.SelectedIndexChanged += CbFilter_SelectedIndexChanged;
            
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTim.Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = ChuanHoaTenRieng(tbTG.Text);
                if (string.IsNullOrEmpty(hoten))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlParameter[] param = {
                new SqlParameter("@TenTG",hoten),
                new SqlParameter("@ID_TG",tbMa.Text)
            };
                if (Execute("UPDATE TacGia SET TenTG =@TenTG WHERE ID_TG = @ID_TG", param))
                {
                    GetData(QUERY);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMa.Clear();
                    tbS.Clear();
                    tbTG.Clear();
                    tbTL.Clear();
                    tbTim.Clear();
                    cbFilter.SelectedIndex = -1;
                    tbMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tác giả có mã: " + tbMa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] param = {
                new SqlParameter ("@ID_TG",tbMa.Text),
                new SqlParameter("@TenTG","Không xác định...")
            };
                if (Execute("DELETE FROM TacGia WHERE ID_TG = @ID_TG", param))
                {
                    GetData(QUERY);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMa.Clear();
                    tbS.Clear();
                    tbTG.Clear();
                    tbTL.Clear();
                    tbTim.Clear();
                    cbFilter.SelectedIndex = -1;
                    tbMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tác giả có mã: " + tbMa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do còn liên kết với các bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data1.SelectedRows.Count > 0)
            {
                tbMa.Text = data1.SelectedRows[0].Cells[0].Value.ToString();
                tbTG.Text = data1.SelectedRows[0].Cells[1].Value.ToString();
                tbS.Text = data1.SelectedRows[0].Cells[2].Value.ToString();
                tbTL.Text = data1.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search()
        {
            if (data1.DataSource is DataTable dataTable)
            {
                string searchValue = cbFilter.SelectedItem?.ToString();
                string filter = "";
                if (string.IsNullOrEmpty(searchValue))
                {
                    if (!string.IsNullOrEmpty(tbTim.Text))
                    {
                        MessageBox.Show("Vui lòng chọn giá trị tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }

                }
                if (searchValue == "Mã")
                {
                    if (tbTim.Text.Any(ch => !char.IsDigit(ch)))
                    {
                        MessageBox.Show("Mã không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    if (int.TryParse(tbTim.Text.Trim(), out int id))
                    {
                        filter = $"[ID] = {id}";
                    }
                    else if (string.IsNullOrEmpty(tbTim.Text.Trim()))
                    {
                        filter = "";
                    }
                    else
                    {
                        return;
                    }
                }
                else if (searchValue == "Họ tên")
                {
                    if (tbTim.Text.Any(char.IsDigit) || tbTim.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
                    {
                        MessageBox.Show("Họ tên không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    filter = $"[TENTG] LIKE '%{tbTim.Text}%'";
                }
                dataTable.DefaultView.RowFilter = filter;
            }
            else
            {
                MessageBox.Show("Dữ liệu nguồn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PushByID()
        {
            if (string.IsNullOrEmpty(tbTim.Text.Trim()))
            {
                string maValue = tbMa.Text;

                if (maValue.Any(ch => !char.IsDigit(ch)))
                {
                    MessageBox.Show("Mã không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMa.Clear();
                    return;
                }

                bool found = false;

                foreach (DataGridViewRow row in data1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maValue)
                    {
                        tbTG.Text = row.Cells[1].Value.ToString();
                        tbTL.Text = row.Cells[3].Value.ToString();
                        tbS.Text = row.Cells[2].Value.ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    if (!string.IsNullOrEmpty(maValue))
                    {
                        MessageBox.Show("Không tìm thấy tác giả có mã: " + maValue, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMa.Clear();
                        tbTG.Clear();
                        tbS.Clear();
                        tbTL.Clear();
                    }
                }
            }
        }


        private void tbMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PushByID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTG_TextChanged(object sender, EventArgs e)
        {
            if (tbTG.Text.Any(char.IsDigit) || tbTG.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
            {
                MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTG.Clear();
                return;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTim.Clear();
            tbMa.Enabled = false;
        }
        private void btnEnabled_Click(object sender, EventArgs e)
        {
            tbMa.Enabled=true;
        }
    }
}
