using Microsoft.Data.SqlClient;
using System.Buffers;
using System.Data;
using System.Net;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhieuTraMuon
{
    public partial class QLTRAMUON : Form
    {
        DataProvider dataProvider = new DataProvider();
        int maPhieuMuon = -1;


        public QLTRAMUON()
        {
            InitializeComponent();

        }

        public QLTRAMUON(int ma)
        {
            InitializeComponent();
            maPhieuMuon = ma;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateNgayTra.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            string query = @"select * from view_LatePaid order by TenDG asc";
            dataLatePaid.DataSource = dataProvider.GetData(query);
            groupBox2.Text = "Danh sách (" + dataLatePaid.RowCount.ToString() + ")";
            cbTim.SelectedIndex = 0;
            //Phieu muon co phieu tra muon
            string query1 = @"SELECT ID_PM, TrangThai 
                FROM PhieuMuon
                WHERE TrangThai = 1";

            DataTable dataTable1 = dataProvider.GetData(query1);

            // Thêm cột mới để định dạng ID_PM
            dataTable1.Columns.Add("FormattedID_PM", typeof(string));

            foreach (DataRow row in dataTable1.Rows)
            {
                row["FormattedID_PM"] = $"PM{int.Parse(row["ID_PM"].ToString()):D2}";
            }
            cbMaPM.ValueMember = "ID_PM";
            cbMaPM.DisplayMember = "FormattedID_PM";
            cbMaPM.DataSource = dataTable1;
            //combo_box_push(@"Select TenDG from DocGia", cbTenDG);
            SqlParameter pa = new SqlParameter("@ID_PM", cbMaPM.SelectedValue);
            string query2 = @"Select DocGia.ID_DG,TenDG from DocGia
                inner join PhieuMuon on DocGia.ID_DG = PhieuMuon.ID_DG
                where PhieuMuon.ID_PM = @ID_PM";
            DataTable dataTable2 = dataProvider.GetDataWithParam(query2, pa);
            cbTenDG.ValueMember = "ID_DG";
            cbTenDG.DisplayMember = "TenDG";
            cbTenDG.DataSource = dataTable2;
            //combo_box_push(@"Select TenThuThu from ThuThu", cbTenTT);
            string query3 = @"Select ID_TT, TenThuThu from ThuThu";
            DataTable dataTable3 = dataProvider.GetData(query3);
            cbTenTT.ValueMember = "ID_TT";
            cbTenTT.DisplayMember = "TenThuThu";
            cbTenTT.DataSource = dataTable3;

            if (maPhieuMuon != -1)
            {
                loadFromConstructor();
            }
        }

        private void loadFromConstructor()
        {
            SqlParameter pa = new SqlParameter("@ID_PM", maPhieuMuon);
            string query2 = @"Select DocGia.ID_DG,TenDG from DocGia
                inner join PhieuMuon on DocGia.ID_DG = PhieuMuon.ID_DG
                where PhieuMuon.ID_PM = @ID_PM";
            DataTable dataTable2 = dataProvider.GetDataWithParam(query2, pa);
            string query = @"select * from make_a_latepaid(@ID_PM, @NgayTra)";
            SqlParameter[] par = {
                 new SqlParameter("@ID_PM", maPhieuMuon),
                 new SqlParameter("@NgayTra",dateNgayTra.Value),
            };
            DataTable dt = dataProvider.GetDataWithParam(query, par);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                DateTime han = Convert.ToDateTime(row["HanTra"]);
                if (dateNgayTra.Value < han)
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateNgayTra.Value = DateTime.Now;
                    return;
                }
                else
                {
                    //cbTenDG.Text = row["TenDG"].ToString();
                    cbMaPM.SelectedValue = maPhieuMuon;
                    txtSoSachMuon.Text = row["SoSachDaMuon"].ToString();
                    txtSoNgayMuon.Text = row["SoNgayTraMuon"].ToString();
                    txtTienPhat.Text = row["TienPhat"].ToString();
                }

            }
            string query3 = @"select TenThuThu from ThuThu inner Join PhieuMuon on ThuThu.ID_TT = PhieuMuon.ID_TT where ID_PM =@ID_PM";
            SqlParameter[] par2 = {
                 new SqlParameter("@ID_PM", maPhieuMuon)
            };
            DataTable dt2 = dataProvider.GetDataWithParam(query3, par2);
            DataRow ro2w = dt2.Rows[0];
            cbTenTT.Text = ro2w["TenThuThu"].ToString();
            combo_box_push(@"exec cbBox_Book @ID_PM ", cbSachDaMuon, new SqlParameter("@ID_PM", maPhieuMuon));
            if (cbSachDaMuon.Items.Count > 0)
            {
                cbSachDaMuon.SelectedIndex = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        Close();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dataProvider.Execute("exec Fine_Update");
                string query = @"select * from view_LatePaid order by TenDG asc";
                dataLatePaid.DataSource = dataProvider.GetData(query);
                MessageBox.Show("Làm mới thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                dataProvider.Execute("exec Fine_Update");
                int lateday = Convert.ToInt32(txtSoNgayMuon.Text);
                int latebook = Convert.ToInt32(txtSoSachMuon.Text);
                int fine = 0;
                if (lateday < 30)
                {
                    fine = lateday * 5000;
                }
                else
                {
                    fine = 30 * 5000 + (lateday - 30) * 10000;
                }
                txtTienPhat.Text = fine.ToString();
                string query = @"select * from view_LatePaid order by TenDG asc";
                dataLatePaid.DataSource = dataProvider.GetData(query);
                MessageBox.Show("Cập nhật tiền phạt hành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dataLatePaid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void combo_box_push(string query, System.Windows.Forms.ComboBox cb, params SqlParameter[] args)
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
                    cb.Items.Clear();
                    while (reader.Read())
                    {
                        cb.Items.Add(reader[0].ToString());

                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataLatePaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataLatePaid.SelectedRows.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                cbMaPM.Text = "PM0" + dataLatePaid.SelectedRows[0].Cells["ColumnID_PM"].Value.ToString();
                cbTenTT.Text = dataLatePaid.SelectedRows[0].Cells["ColumnTenThuThu"].Value.ToString();
                cbTenDG.Text = dataLatePaid.SelectedRows[0].Cells["ColumnTenDG"].Value.ToString();
                cbTenDG.Enabled = false;
                txtSoSachMuon.Text = dataLatePaid.SelectedRows[0].Cells["ColumnSoSachDaMuon"].Value.ToString();
                dateNgayTra.Value = Convert.ToDateTime(dataLatePaid.SelectedRows[0].Cells["ColumnNgayTra"].Value);
                txtSoNgayMuon.Text = dataLatePaid.SelectedRows[0].Cells["ColumnSoNgayTraMuon"].Value.ToString();
                txtTienPhat.Text = Convert.ToInt32(dataLatePaid.SelectedRows[0].Cells["ColumnTienPhat"].Value).ToString();

                combo_box_push(@"exec cbBox_Book @ID_PM ", cbSachDaMuon, new SqlParameter("@ID_PM", Convert.ToInt32(cbMaPM.SelectedValue)));

                if (cbSachDaMuon.Items.Count > 0)
                {
                    cbSachDaMuon.SelectedIndex = 0;
                }
            }
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            if (cbMaPM.Items.Count > 0 || cbSachDaMuon.Items.Count > 0)
            {
                if (cbMaPM.SelectedValue is int ma)
                {
                    QLSACHDAMUON f2 = new QLSACHDAMUON(ma);
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mã phiếu mượn hợp lệ!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không có sách nào để hiển thị", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataLatePaid.Rows)
            {
                if (row.Cells["ColumnID_PM"].Value != null && !row.IsNewRow)
                {
                    if (row.Cells["ColumnID_PM"].Value.ToString() == (cbMaPM.SelectedValue).ToString())
                    {
                        MessageBox.Show("Đã tồn tại mã phiếu mượn này!!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            if (cbMaPM.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn mã phiếu mượn", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTenTT.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn tên thủ thư","Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTenDG.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn tên độc giả", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlParameter[] parameter =
            {
                new SqlParameter("@ID_TT",cbTenTT.SelectedValue),
                new SqlParameter("@ID_DG",cbTenDG.SelectedValue),
                new SqlParameter("ID_PM",cbMaPM.SelectedValue),
                new SqlParameter("@NgayTra",dateNgayTra.Value),
                new SqlParameter("@SoNgayTraMuon",Convert.ToInt32(txtSoNgayMuon.Text)),
                new SqlParameter("@TienPhat",decimal.Parse(txtTienPhat.Text)),
            };
            string query2 = @"select * from make_a_latepaid(@ID_PM, @NgayTra)";
            SqlParameter[] par = {
                 new SqlParameter("@ID_PM", Convert.ToInt32(cbMaPM.SelectedValue)),
                 new SqlParameter("@NgayTra",dateNgayTra.Value),
            };
            DataTable dt = dataProvider.GetDataWithParam(query2, par);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                DateTime han = Convert.ToDateTime(row["HanTra"]);
                if (dateNgayTra.Value <= han)
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateNgayTra.Value = DateTime.Now;
                    return;
                }
                else
                {

                    string query = @"insert into PhieuTraMuon values( @ID_TT, @ID_DG,@ID_PM, @NgayTra, @SoNgayTraMuon, @TienPhat )";
                    bool result = dataProvider.Execute(query, parameter);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        string query1 = @"select * from view_LatePaid order by TenDG asc";
                        dataLatePaid.DataSource = dataProvider.GetData(query1);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm phiếu trả muộn", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
        private void Search()
        {
            if (dataLatePaid.DataSource is DataTable dataTable)
            {
                string searchField = cbTim.SelectedItem?.ToString();
                string filter = "";
                if (string.IsNullOrEmpty(searchField))
                {
                    if (!string.IsNullOrEmpty(txtFind.Text))
                    {
                        MessageBox.Show("Vui lòng chọn giá trị tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFind.Clear();
                        return;
                    }
                }


                if (searchField == "Tên thủ thư")
                {
                    if (txtFind.Text.Any(char.IsDigit) || txtFind.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                    {
                        MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFind.Clear();
                        return;
                    }
                    filter = $"[TenThuThu] LIKE '%{txtFind.Text.Trim()}%'";
                }
                else if (searchField == "Tên độc giả")
                {
                    if (txtFind.Text.Any(char.IsDigit) || txtFind.Text.Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                    {
                        MessageBox.Show("Tên không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFind.Clear();
                        return;
                    }
                    filter = $"[TenDG] LIKE '%{txtFind.Text.Trim()}%'";
                }
                else if (searchField == "Số điện thoại")
                {
                    if (txtFind.Text.Any(ch => !char.IsDigit(ch)))
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFind.Clear();
                        return;
                    }
                    if (txtFind.Text.Length > 10)
                    {
                        MessageBox.Show("Số điện thoại không được vượt quá 10 ký tự\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFind.Clear();
                        return;
                    }
                    filter = $"[SDT] LIKE '%{txtFind.Text.Trim()}%'";
                }

                dataTable.DefaultView.RowFilter = filter;
            }
            else
            {
                MessageBox.Show("Dữ liệu nguồn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Search();
            groupBox2.Text = "Danh sách (" + dataLatePaid.RowCount.ToString() + ")";
        }

        private void dataLatePaid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataLatePaid.Columns[e.ColumnIndex].Name == "ColumnTienPhat" && e.Value != null)
            {
                e.Value = ((int)Convert.ToDouble(e.Value)).ToString();
                e.FormattingApplied = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataLatePaid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn muốn xóa!!", "Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                var selectedRow = dataLatePaid.SelectedRows[0];
                int id = (int)selectedRow.Cells["ColumnID_PTM"].Value;
                SqlParameter pa = new SqlParameter("@ID_PTM", id);
                string query = @"Delete from PhieuTraMuon where ID_PTM = @ID_PTM";
                if (dataProvider.Execute(query, pa) == true)
                {
                    MessageBox.Show("Xóa phiếu trả muộn thành công!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string query1 = @"select * from view_LatePaid order by TenDG asc";
                    dataLatePaid.DataSource = dataProvider.GetData(query1);
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể xóa phiếu trả muộn!!", "Thong bao" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }

        }

        private void dataLatePaid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }


        private void cbTenTT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clear_info()
        {
            dateNgayTra.Value = DateTime.Now;
            txtFind.Clear();
            txtSoNgayMuon.Clear();
            txtSoSachMuon.Clear();
            txtTienPhat.Clear();
            cbMaPM.SelectedIndex = -1;
            cbSachDaMuon.SelectedIndex = -1;
            cbTenDG.SelectedIndex = -1;
            cbTenTT.SelectedIndex = -1;
            dateNgayTra.Value = DateTime.Now;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataLatePaid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu muốn sửa!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (cbTenTT.SelectedValue != null)
                {
                    //ColumnHanTra
                    int ma_TT = Convert.ToInt32(cbTenTT.SelectedValue);
                    DateTime hantra = Convert.ToDateTime(dataLatePaid.SelectedRows[0].Cells["ColumnHanTra"].Value);
                    int maptm = Convert.ToInt32(dataLatePaid.SelectedRows[0].Cells["ColumnID_PTM"].Value);
                    if (dateNgayTra.Value <= hantra)
                    {
                        MessageBox.Show("Thời gian không hợp lệ", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        return;
                    }
                    else
                    {
                        string query = @"Update PhieuTraMuon set ID_TT = @ID_TT , NgayTra = @NgayTra where ID_PTM = @ID_PTM";
                        SqlParameter[] sp = new SqlParameter[] {
                            new SqlParameter("@ID_TT",ma_TT),
                            new SqlParameter("@NgayTra",dateNgayTra.Value),
                            new SqlParameter("@ID_PTM", maptm)
                        };
                        bool kq = dataProvider.Execute(query, sp);
                        if (kq)
                        {
                            int fine = 0;
                            int lateday = (dateNgayTra.Value - hantra).Days;
                            if (lateday < 30)
                            {
                                fine = lateday * 5000;
                            }
                            else
                            {
                                fine = 30 * 5000 + (lateday - 30) * 10000;
                            }
                            txtSoNgayMuon.Text = lateday.ToString();
                            txtTienPhat.Text = fine.ToString();
                            dataProvider.Execute("exec Fine_Update");
                            MessageBox.Show("Cập nhật thông tin thành công","Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataLatePaid.DataSource = dataProvider.GetData("select * from view_LatePaid order by TenDG asc");
                            //clear_info();
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                        }
                    }
                }

            }
        }

        private void cbSachDaMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter pa = new SqlParameter("@ID_PM", cbMaPM.SelectedValue);
            string query2 = @"Select DocGia.ID_DG,TenDG from DocGia
                inner join PhieuMuon on DocGia.ID_DG = PhieuMuon.ID_DG
                where PhieuMuon.ID_PM = @ID_PM";
            DataTable dataTable2 = dataProvider.GetDataWithParam(query2, pa);
            string query = @"select * from make_a_latepaid(@ID_PM, @NgayTra)";
            SqlParameter[] par = {
                 new SqlParameter("@ID_PM", Convert.ToInt32(cbMaPM.SelectedValue)),
                 new SqlParameter("@NgayTra",dateNgayTra.Value),
            };
            DataTable dt = dataProvider.GetDataWithParam(query, par);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                DateTime han = Convert.ToDateTime(row["HanTra"]);
                if (dateNgayTra.Value < han)
                {
                    MessageBox.Show("Thời gian không hợp lệ","Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateNgayTra.Value = DateTime.Now;
                    return;
                }
                else
                {
                    cbTenDG.Text = row["TenDG"].ToString();
                    txtSoSachMuon.Text = row["SoSachDaMuon"].ToString();
                    txtSoNgayMuon.Text = row["SoNgayTraMuon"].ToString();
                    txtTienPhat.Text = row["TienPhat"].ToString();
                }

            }
            combo_box_push(@"exec cbBox_Book @ID_PM ", cbSachDaMuon, new SqlParameter("@ID_PM", Convert.ToInt32(cbMaPM.SelectedValue)));
            if (cbSachDaMuon.Items.Count > 0)
            {
                cbSachDaMuon.SelectedIndex = 0;
            }
        }

        private void cbMaPM_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbTenTT_TextChanged(object sender, EventArgs e)
        {
            if (cbTenTT.DataSource != null)
            {
                var validItems = cbTenTT.Items.Cast<DataRowView>().Select(row => row[cbTenTT.DisplayMember].ToString()).ToList();
                if (!validItems.Contains(cbTenTT.Text))
                {
                    MessageBox.Show("Giá trị không hợp lệ. Vui lòng chọn từ danh sách.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cbTenTT.Items.Count > 0)
                    {
                        cbTenTT.SelectedIndex = 0;
                    }

                    if (cbTenTT.SelectedItem is DataRowView selectedRow)
                    {
                        cbTenTT.Text = selectedRow[cbTenTT.DisplayMember].ToString();
                    }
                    else
                    {
                        cbTenTT.Text = "";
                    }
                }
            }
        }

        private void cbTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Clear();
        }

        private void cbTim_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}