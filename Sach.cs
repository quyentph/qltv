using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testgiaodien
{
    public partial class Sach : Form
    {
        private SqlConnection conn;
        string connectionString = QuanLiThuVien_PhieuMuon.Common.connString;
        List<TacGia> cacTacGia = new List<TacGia>();
        List<LoaiSachMoi> cacLoaiSach = new List<LoaiSachMoi>();
        public Sach()
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

                datasach.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData("SELECT * FROM SachChuan");
            comboBox1.Items.Add("Mã sách");
            comboBox1.Items.Add("Tên sách");
            comboBox1.Items.Add("Mã tác giả");
            comboBox1.Items.Add("Tên tác giả");
            comboBox1.Items.Add("Mã loại sách");
            comboBox1.Items.Add("Loại sách");
            comboBox1.Items.Add("Số lượng sách");
            comboBox1.SelectedIndex = 0;
        }
        
        private void btchontacgia_Click(object sender, EventArgs e)
        {
            Chontacgia f1 = new Chontacgia();
            f1.cacTacGia = new List<TacGia>(cacTacGia);
            f1.Owner = this;  
            f1.ShowDialog();
            cacTacGia = new List<TacGia>(f1.cacTacGia);
            
            List<int> cacMa = new List<int>();
            List<string> cacTen = new List<string>();
            foreach (TacGia tg in cacTacGia)
            {
                cacMa.Add(tg.ma);
                cacTen.Add(tg.ten);
            }

            txttentacgia.Text = string.Join(", ", cacTen);
            txtmatacgia.Text = string.Join (", ", cacMa);
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
            private void datasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = datasach.Rows[e.RowIndex];
                txtmasach.Text = row.Cells["MaSach"].Value?.ToString() ?? "";
                txttensach.Text = row.Cells["TenSach"].Value?.ToString() ?? "";
                txtmatacgia.Text = row.Cells["MaTacGia"].Value?.ToString() ?? "";
                txttentacgia.Text = row.Cells["TenTacGia"].Value?.ToString() ?? "";
                txtmaloaisach.Text = row.Cells["MaLoaiSach"].Value?.ToString() ?? "";
                txtloaisach.Text = row.Cells["LoaiSach"].Value?.ToString() ?? "";

                cacTacGia.Clear();
                string[] phay = new string[] { ", " };
                string[] cacMa = txtmatacgia.Text.Split(phay, StringSplitOptions.RemoveEmptyEntries);
                string[] cacTen = txttentacgia.Text.Split(phay, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < cacMa.Length; i++)
                {
                    TacGia tacGia = new TacGia
                    {
                        ma = int.Parse(cacMa[i]),
                        ten = cacTen[i]
                    };
                    cacTacGia.Add(tacGia);
                }

                cacLoaiSach.Clear();
                string[] cacMa1 = txtmaloaisach.Text.Split(phay, StringSplitOptions.RemoveEmptyEntries);
                string[] cacTen1 = txtloaisach.Text.Split(phay, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < cacMa1.Length; i++)
                {
                    LoaiSachMoi loaiSach = new LoaiSachMoi
                    {
                        ma1 = int.Parse(cacMa1[i]),
                        ten1 = cacTen1[i]
                    };
                    cacLoaiSach.Add(loaiSach);
                }
                if (row.Cells["SoLuongSach"].Value != null && decimal.TryParse(row.Cells["SoLuongSach"].Value.ToString(), out decimal value))
                {
                    num.Value = value;
                }   
                else
                {
                    num.Value = num.Minimum;
                }
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSach = txttensach.Text.Trim();
                string tenLoaiSach = txtloaisach.Text;
                string tenTacGia = txttentacgia.Text;
                int soLuongSach = (int)num.Value;
                foreach (DataGridViewRow row in datasach.Rows)
                {
                    if (row.Cells["Tensach"].Value != null && !row.IsNewRow && row.Cells["Tentacgia"].Value != null && row.Cells["Loaisach"].Value != null)
                    {
                        if (row.Cells["Tensach"].Value.ToString() == txttensach.Text && row.Cells["Tentacgia"].Value.ToString() == txttentacgia.Text && row.Cells["Loaisach"].Value.ToString() == txtloaisach.Text)
                        {
                            txtmasach.Clear();
                            txtmatacgia.Clear();
                            txtmaloaisach.Clear();
                            txttensach.Clear();
                            txtloaisach.Clear();
                            txttentacgia.Clear();
                            num.Value = 0;
                            MessageBox.Show("Đã tồn tại sách này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(tenLoaiSach) || string.IsNullOrWhiteSpace(tenTacGia))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(num.Text, out int value))
                {
                    if (value > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Giá trị phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Sach VALUES(@TenSach, @SoLuongSach);SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@SoLuongSach", soLuongSach);

                        int maSach = Convert.ToInt32(cmd.ExecuteScalar());

                        string query2 = "INSERT INTO DongTacGia VALUES(@MaSach, @MaTacGia);";
                        foreach (var tg in cacTacGia)
                        {
                            using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                            {
                                cmd2.Parameters.AddWithValue("@MaSach", maSach);
                                cmd2.Parameters.AddWithValue("@MaTacGia", tg.ma);

                                cmd2.ExecuteNonQuery();
                            }
                        }
                        string query3 = "INSERT INTO TheLoaiSach VALUES(@MaSach, @MaLoaiSach);";
                        foreach (var ls in cacLoaiSach)
                        {
                            using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                            {
                                cmd3.Parameters.AddWithValue("@MaSach", maSach);
                                cmd3.Parameters.AddWithValue("@MaLoaiSach", ls.ma1);

                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Thêm sách thành công!");
                GetData("SELECT * FROM SachChuan ORDER BY [Mã sách] ASC");
                txttensach.Clear();
                txtloaisach.Clear();
                txtmasach.Clear();
                txtmaloaisach.Clear();
                txtmatacgia.Clear();
                txttentacgia.Clear();
                num.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            string idSach = txtmasach.Text.Trim();
            string tenSach = txttensach.Text.Trim();
            string tenTG = txttentacgia.Text.Trim();
            string tenLS = txtloaisach.Text.Trim();
            int soLuongSach = (int)num.Value;
            if (string.IsNullOrWhiteSpace(tenSach) || string.IsNullOrWhiteSpace(tenLS) || string.IsNullOrWhiteSpace(tenTG))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(idSach, out int idSachInt))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(num.Text, out int value))
            {
                if (value >= 0)
                {

                }
                else
                {
                    MessageBox.Show("Giá trị phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Sach SET TenSach = @TenSach, SoLuongSach = @SoLuongSach WHERE ID_Sach = @MaSach;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenSach", tenSach);
                        cmd.Parameters.AddWithValue("@SoLuongSach", soLuongSach);
                        cmd.Parameters.AddWithValue("@MaSach", idSach);

                        cmd.ExecuteNonQuery();
                    }

                    string query2 = "DELETE FROM DongTacGia WHERE ID_Sach = @MaSach;";
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@MaSach", idSach);

                        cmd2.ExecuteNonQuery();
                    }

                    string query3 = "INSERT INTO DongTacGia VALUES(@MaSach, @MaTacGia);";
                    foreach (var tg in cacTacGia)
                    {
                        using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                        {
                            cmd3.Parameters.AddWithValue("@MaSach", idSach);
                            cmd3.Parameters.AddWithValue("@MaTacGia", tg.ma);

                            cmd3.ExecuteNonQuery();
                        }
                    }
                    string query4 = "DELETE FROM TheLoaiSach WHERE ID_Sach = @MaSach;";
                    using (SqlCommand cmd4 = new SqlCommand(query4, conn))
                    {
                        cmd4.Parameters.AddWithValue("@MaSach", idSach);

                        cmd4.ExecuteNonQuery();
                    }

                    string query5 = "INSERT INTO TheLoaiSach VALUES(@MaSach, @MaLoaiSach);";
                    foreach (var ls in cacLoaiSach)
                    {
                        using (SqlCommand cmd5 = new SqlCommand(query5, conn))
                        {
                            cmd5.Parameters.AddWithValue("@MaSach", idSach);
                            cmd5.Parameters.AddWithValue("@MaLoaiSach", ls.ma1);

                            cmd5.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData("SELECT * FROM SachChuan ORDER BY [Mã sách] ASC");
                txttensach.Clear();
                txtloaisach.Clear();
                txtmasach.Clear();
                txtmaloaisach.Clear();
                txtmatacgia.Clear();
                txttentacgia.Clear();
                num.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            string tenSach = txttensach.Text;

            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query = "EXEC DeleteBook @TenSach";
                SqlParameter[] parameters =
                {
                new SqlParameter("@TenSach", tenSach)
                };

                if (Execute(query, parameters))
                {
                    MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData("SELECT * FROM SachChuan ORDER BY [Mã sách] ASC");
                    txttensach.Clear();
                    txtloaisach.Clear();
                    txtmasach.Clear();
                    txtmaloaisach.Clear();
                    txtmatacgia.Clear();
                    txttentacgia.Clear();
                    num.Value = 0;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Không thể xóa do còn liên kết với các bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search()
        {
            if (datasach.DataSource is DataTable dataTable)
            {
                string searchField = comboBox1.SelectedItem?.ToString();
                string filter = "";

                if (string.IsNullOrEmpty(searchField))
                {
                    MessageBox.Show("Vui lòng chọn trường để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.SelectedIndex = 0;
                    txttim.Clear();
                    return;
                }


                string searchText = txttim.Text.Trim();

                try
                {
                    switch (searchField)
                    {
                        case "Mã sách":
                            if (int.TryParse(searchText, out int maSach))
                            {
                                filter = $"[Mã sách] = {maSach}";
                            }
                            else if (!string.IsNullOrEmpty(searchText))
                            {
                                txttim.Clear();
                                MessageBox.Show("Mã sách phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                return;
                            }
                            break;

                        case "Tên sách":
                            filter = $"[Tên sách] LIKE '%{searchText}%'";
                            break;

                        case "Mã tác giả":
                            if (int.TryParse(searchText, out int maTacGia))
                            {
                                filter = $"[Mã tác giả] LIKE '%{searchText}%'";

                            }
                            else if (!string.IsNullOrEmpty(searchText))
                            {
                                txttim.Clear();
                                MessageBox.Show("Mã tác giả phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            break;

                        case "Tên tác giả":
                            filter = $"[Tên tác giả] LIKE '%{searchText}%'";
                            break;

                        case "Mã loại sách":
                            if (int.TryParse(searchText, out int maLoaiSach))
                            {
                                filter = $"[Mã loại sách] LIKE '%{searchText}%'";
                            }
                            else if (!string.IsNullOrEmpty(searchText))
                            {
                                txttim.Clear();
                                MessageBox.Show("Mã loại sách phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            break;

                        case "Loại sách":
                            filter = $"[Loại sách] LIKE '%{searchText}%'";
                            break;

                        case "Số lượng sách":
                            if (string.IsNullOrEmpty(searchText))
                            {
                                filter = "";
                            }
                            else if (int.TryParse(searchText, out int soLuongSach))
                            {
                                filter = $"[Số lượng sách] = {soLuongSach}";
                            }
                            else
                            {
                                txttim.Clear();
                                MessageBox.Show("Số lượng phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            break;

                        default:
                            MessageBox.Show("Trường tìm kiếm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    dataTable.DefaultView.RowFilter = filter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi áp dụng bộ lọc: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            txttim.Clear();
            Search();
        }

        private void btchonloaisach_Click(object sender, EventArgs e)
        {
            Chontheloai f2 = new Chontheloai();
            f2.cacLoaiSach = new List<LoaiSachMoi>(cacLoaiSach);
            f2.Owner = this;
            f2.ShowDialog();
            cacLoaiSach = new List<LoaiSachMoi>(f2.cacLoaiSach);

            List<int> cacMa1 = new List<int>();
            List<string> cacTen1 = new List<string>();
            foreach (LoaiSachMoi ls in cacLoaiSach)
            {
                cacMa1.Add(ls.ma1);
                cacTen1.Add(ls.ten1);
            }

            txtloaisach.Text = string.Join(", ", cacTen1);
            txtmaloaisach.Text = string.Join(", ", cacMa1);
        }
    }
}
