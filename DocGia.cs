using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyTacGia
{
    public partial class DocGia : Form
    {
        private SqlConnection sq = new SqlConnection();
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;

        public DocGia()
        {
            InitializeComponent();
        }

        private DataTable GetData(string query)
        {
            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                var dataTable = new DataTable();
                var dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                data2.DataSource = dataTable;
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
        public string ChuanHoa(string input)
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
        public string QUERY = "SELECT * FROM DocGia";
        private void DocGia_Load(object sender, EventArgs e)
        {
            GetData(QUERY);
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = ChuanHoa(tbTen.Text);
                if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(tbSDT.Text) || string.IsNullOrEmpty(tbCCCD.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (hoten.Any(char.IsDigit) || hoten.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                {
                    MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tbSDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ\r\nVui lòng nhập nhập đủ 10 số\r\nSố điện thoại của bạn đang có: " + tbSDT.Text.Length + " số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tbCCCD.Text.Length != 12)
                {
                    MessageBox.Show("Căn cước công dân không hợp lệ\r\nVui lòng nhập nhập đủ 12 số\r\nCăn cước công dân của bạn đang có: " + tbCCCD.Text.Length + " số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlParameter[] param = {
                new SqlParameter("@TenDG",hoten),
                new SqlParameter("@SDT",tbSDT.Text),
                new SqlParameter("@CCCD",tbCCCD.Text)
                };
                if (Execute("INSERT INTO DocGia VALUES(@TenDG,@SDT,@CCCD)", param))
                {
                    MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData(QUERY);
                    tbTen.Clear();
                    tbMa.Clear();
                    tbSDT.Clear();
                    tbCCCD.Clear();
                    tbMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể thêm thông tin độc giả");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có căn cước công dân này tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = ChuanHoa(tbTen.Text);
                if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(tbSDT.Text) || string.IsNullOrEmpty(tbCCCD.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tbSDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ\r\nVui lòng nhập nhập đủ 10 số\r\nSố điện thoại của bạn đang có: "+ tbSDT.Text.Length+" số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;    
                }
                
                if (tbCCCD.Text.Length != 12)
                {
                    MessageBox.Show("Căn cước công dân không hợp lệ\r\nVui lòng nhập nhập đủ 12 số\r\nCăn cước công dân của bạn đang có: " + tbCCCD.Text.Length + " số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlParameter[] param = {
                new SqlParameter("@TenDG",hoten),
                new SqlParameter("@SDT",tbSDT.Text),
                new SqlParameter("@CCCD",tbCCCD.Text),
                new SqlParameter("@ID_DG",tbMa.Text)
                };
                if (Execute("UPDATE DocGia SET TenDG = @TenDG,SDT = @SDT,CCCD = @CCCD WHERE ID_DG = @ID_DG", param))
                {
                    MessageBox.Show("Sửa thông tin độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData(QUERY);
                    tbTen.Clear();
                    tbMa.Clear();
                    tbSDT.Clear();
                    tbCCCD.Clear();
                    tbMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả có mã: " + tbMa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có căn cước công dân này tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] param =
            {
                new SqlParameter("@ID_DG",tbMa.Text)
            };
                if (Execute("DELETE FROM DocGia WHERE ID_DG = @ID_DG", param))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData(QUERY);
                    tbTen.Clear();
                    tbMa.Clear();
                    tbSDT.Clear();
                    tbCCCD.Clear();
                    tbMa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả có mã: " + tbMa.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi: Không thể xóa do còn liên kết với các bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void data2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data2.SelectedRows.Count > 0)
            {
                tbMa.Text = data2.SelectedRows[0].Cells[0].Value.ToString();
                tbTen.Text = data2.SelectedRows[0].Cells[1].Value.ToString();
                tbSDT.Text = data2.SelectedRows[0].Cells[2].Value.ToString();
                tbCCCD.Text = data2.SelectedRows[0].Cells[3].Value.ToString();

            }
        }
        private void Search()
        {
            if (data2.DataSource is DataTable dataTable)
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
                        filter = $"[ID_DG] = {id}";
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
                    if (tbTim.Text.Any(char.IsDigit) || tbTim.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                    {
                        MessageBox.Show("Họ tên không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    filter = $"TenDG LIKE '%{tbTim.Text}%'";
                }

                else if (searchValue == "CCCD")
                {
                    if (tbTim.Text.Any(ch => !char.IsDigit(ch)))
                    {
                        MessageBox.Show("Căn cước công dân không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    if (tbTim.Text.Trim().All(char.IsDigit))
                    {
                        filter = $"[CCCD] LIKE '%{tbTim.Text.Trim()}%'";
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
                dataTable.DefaultView.RowFilter = filter;
                if (data2.CurrentRow == null || data2.CurrentRow.Cells.Count == 0)
                {
                    if (cbFilter.Text == "Mã")
                    {
                        MessageBox.Show("Không tìm thấy độc giả có mã: " + tbTim.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    if (cbFilter.Text == "Họ tên" && tbTim.Text.Length == 22)
                    {

                        MessageBox.Show("Không tìm thấy độc giả có họ tên: " + tbTim.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                    if (cbFilter.Text == "CCCD" && tbTim.Text.Length == 12)
                    {
                        MessageBox.Show("Không tìm thấy độc giả có căn cước công dân: " + tbTim.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTim.Clear();
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Dữ liệu nguồn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                foreach (DataGridViewRow row in data2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maValue)
                    {
                        tbTen.Text = row.Cells[1].Value.ToString();
                        tbSDT.Text = row.Cells[2].Value.ToString();
                        tbCCCD.Text = row.Cells[3].Value.ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    if (!string.IsNullOrEmpty(maValue))
                    {
                        MessageBox.Show("Không tìm thấy độc giả có mã: " + maValue, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTen.Clear();
                        tbMa.Clear();
                        tbSDT.Clear();
                        tbCCCD.Clear();
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

        private void tbCCCD_TextChanged(object sender, EventArgs e)
        {
            if (tbCCCD.Text.Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("Căn cước công dân không hợp lệ\r\nVui lòng chỉ nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCCCD.Clear();
                return;
            }
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSDT.Text) && tbSDT.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSDT.Clear();
                return;
            }
            if (tbSDT.Text.Any(ch => !char.IsDigit(ch)))
            {
                MessageBox.Show("Số điện thoại không hợp lệ\r\nVui lòng chỉ nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSDT.Clear();
                return;
            }
        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            if (tbTen.Text.Any(char.IsDigit) || tbTen.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
            {
                MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTen.Clear();
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
            tbMa.Enabled = true;
        }
    }
}
