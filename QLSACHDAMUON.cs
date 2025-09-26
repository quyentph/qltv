using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhieuTraMuon
{
    public partial class QLSACHDAMUON : Form
    {
        DataProvider dataProvider = new DataProvider();
        int num = -1;
        public QLSACHDAMUON(int maPM)
        {
            InitializeComponent();
            txtMaPM.Text = "PM0"+maPM.ToString();
            cbTimSach.SelectedIndex = 0;
            num = maPM;
        }
        
        private void Search()
        {
            //Mã sách
            //Tên sách
            //Thể loại sách
            //Tác giả
            if (dataBook.DataSource is DataTable dataTable)
            {
                string searchField = cbTimSach.SelectedItem?.ToString();
                string filter = "";
                if (string.IsNullOrEmpty(searchField))
                {
                    if (!string.IsNullOrEmpty(txtTimSach.Text))
                    {
                        MessageBox.Show("Vui lòng chọn giá trị tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTimSach.Clear();
                        return;
                    }
                }

                if(searchField == "Mã sách")
{
                    if (txtTimSach.Text.Any(ch => !char.IsDigit(ch)))
                    {
                        MessageBox.Show("Mã không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTimSach.Clear();
                        return;
                    }
                    if (int.TryParse(txtTimSach.Text.Trim(), out int id))
                    {
                        filter = $"[ID_Sach] = {id}";
                    }
                    else if (string.IsNullOrEmpty(txtTimSach.Text.Trim()))
                    {
                        filter = "";
                    }
                    else
                    {
                        return;
                    }
                }

                else if (searchField == "Tên sách")
                {
                    
                    filter = $"[TenSach] LIKE '%{txtTimSach.Text.Trim()}%'";
                }
                else if (searchField == "Thể loại sách")
                {
                    if (txtTimSach.Text.Any(char.IsDigit) || txtTimSach.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
                    {
                        MessageBox.Show("Thể loại không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTimSach.Clear();
                        return;
                    }
                    filter = $"[TheLoai] LIKE '%{txtTimSach.Text.Trim()}%'";
                }
                else if (searchField == "Tác giả")
                {
                    if (txtTimSach.Text.Any(char.IsDigit) || txtTimSach.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch) && ch != '.' && ch != '-'))
                    {
                        MessageBox.Show("Họ tên tác giả không hợp lệ\r\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTimSach.Clear();
                        return;
                    }
                    filter = $"[TacGia] LIKE '%{txtTimSach.Text.Trim()}%'";
                }
                dataTable.DefaultView.RowFilter = filter;
            }
            else
            {
                MessageBox.Show("Dữ liệu nguồn không hợp lệ!");
                txtTimSach.Clear();
                return;
            }

        }

        public void textbox_load(string query, TextBox tb, params SqlParameter[] args)
        {
            string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(args);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb.Text = reader.GetString(0);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            string query_name = @" select DocGia.TenDG
                                from PhieuMuon
                                inner join DocGia on PhieuMuon.ID_DG = DocGia.ID_DG
                                where PhieuMuon.ID_PM = @ID_PM";
            string query_phone = @" select DocGia.SDT
                                from PhieuMuon
                                inner join DocGia on PhieuMuon.ID_DG = DocGia.ID_DG
                                where PhieuMuon.ID_PM = @ID_PM";
            textbox_load(query_name, txtTenDG, new SqlParameter("@ID_PM", num));
            textbox_load(query_phone, txtSDT, new SqlParameter("@ID_PM", num));
            var pa = new SqlParameter("@ID_PM", num);
            string query = @"select * from Borrow_book(@ID_PM)";
            dataBook.DataSource = dataProvider.GetDataWithParam(query, pa);
            groupBox1.Text = "Danh sách (" + dataBook.Rows.Count.ToString() + ")";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            Search();
            groupBox1.Text = "Danh sách (" + dataBook.RowCount.ToString() + ")";
        }

        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTimSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimSach.Clear();
        }

        private void cbTimSach_TextChanged(object sender, EventArgs e)
        {
            if (cbTimSach.DataSource != null)
            {
                var validItems = cbTimSach.Items.Cast<DataRowView>().Select(row => row[cbTimSach.DisplayMember].ToString()).ToList();
                if (!validItems.Contains(cbTimSach.Text))
                {
                    MessageBox.Show("Giá trị không hợp lệ. Vui lòng chọn từ danh sách.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cbTimSach.Items.Count > 0)
                    {
                        cbTimSach.SelectedIndex = 0;
                    }
                   
                    if (cbTimSach.SelectedItem is DataRowView selectedRow)
                    {
                        cbTimSach.Text = selectedRow[cbTimSach.DisplayMember].ToString();
                    }
                    else
                    {
                        cbTimSach.Text = "";
                    }
                }
            }
        }
    }
}
