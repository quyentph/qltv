using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Giao_dien_dang_nhap
{
    public partial class GiaoDien : Form
    {
        Data data = new Data();
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            DoiMK newForm = new DoiMK();
            newForm.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Close();
            }

        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.GetData("SELECT * FROM ThuThu ORDER BY ID_TT ASC");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && !row.IsNewRow)
                {
                    if (row.Cells[0].Value.ToString() == txtID_TT.Text && row.Cells[1].Value.ToString() == txtten.Text)
                    {
                        MessageBox.Show("Đã tồn tại mã thủ thư này!!!");
                        txtten.Clear();
                        txtID_TT.Clear();
                        return;
                    }
                }
            }
            if (txtten.Text.Contains("  "))
            {
                MessageBox.Show("Tên thủ thư không được chứa quá nhiều khoảng trắng liên tiếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Clear();
                txtten.Focus();
                return;
            }
            string hoten = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtten.Text.ToLower());
            if (txtten.Text.Length == 0)
            {
                if (txtten.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtten.Focus();
                }
            }
            else
            {
                string query = "INSERT INTO ThuThu VALUES(@Value1)";
                SqlParameter[] args =
                {
                            new SqlParameter("@Value1", hoten)
                };

                if (data.Excute(query, args))
                {
                    MessageBox.Show("Thêm thủ thư thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = data.GetData("SELECT * FROM ThuThu ORDER BY ID_TT ASC");

                }
                else
                {
                    MessageBox.Show("Không thêm được thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            dataGridView1.DataSource = data.GetData("SELECT * FROM ThuThu ORDER BY ID_TT ASC");
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID_TT.Text))
            {
                MessageBox.Show("Vui lòng chọn thủ thư cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "DELETE FROM ThuThu WHERE ID_TT=@ID_TT";
                SqlParameter[] pa =
                {
                    new SqlParameter("@ID_TT", txtID_TT.Text)
                };

                if (data.Excute(query, pa))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = data.GetData("SELECT * FROM ThuThu ORDER BY ID_TT ASC");
                    txtten.Clear();
                    txtID_TT.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa do còn liên kết với các bảng khác" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtID_TT.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtten.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string hoten = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
               string.Join(" ", txtten.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToLower()
           );


            if (txtten.Text.Contains("  "))
            {
                MessageBox.Show("Tên thủ thư không được chứa quá nhiều khoảng trắng liên tiếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Clear();
                txtten.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Tên thủ thư không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Focus();
                return;
            }


            string query = "UPDATE ThuThu SET TenThuThu = @Value1 WHERE ID_TT = @Value3";
            SqlParameter[] p =
            {
                new SqlParameter("@Value1", hoten),
                new SqlParameter("@Value3", Convert.ToInt32(txtID_TT.Text))
            };

            if (data.Excute(query, p))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = data.GetData("SELECT * FROM ThuThu ORDER BY ID_TT ASC");
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            if (txtten.Text.Any(char.IsDigit) || txtten.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
            {
                MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Clear();
                return;
            }
        }

        private void txtten_TextChanged_1(object sender, EventArgs e)
        {
            if (txtten.Text.Any(char.IsDigit) || txtten.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
            {
                MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Clear();
                return;
            }
        }
    }
}
