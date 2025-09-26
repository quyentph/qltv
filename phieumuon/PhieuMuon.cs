using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

using PhieuTraMuon;

namespace QuanLiThuVien_PhieuMuon
{
    public partial class PhieuMuon : Form
    {
        private DataTable readerTable = new DataTable();
        private DataTable librarianTable = new DataTable();
        private DataTable bookTable = new DataTable();
        private DataTable currentBooksTable = new DataTable();
        private bool needUpdateCurrentBooks = false;

        private bool update_cbSach_fromEvent = true;

        public PhieuMuon()
        {
            InitializeComponent();

            Common.setDoubleBuffered(gridView);
        }

        private void loadMainData()
        {
            string query = "SELECT * FROM TomLuocPhieuMuon";
            if (checkLocDaTra.Checked)
            {
                query = "SELECT * FROM TomLuocPhieuMuon WHERE [Đã trả] = 0";
            }

            DataTable table = Common.GetTable(query);
            gridView.DataSource = table;
            gridView.Columns["ID_PM"].Visible = false;
            gridView.Columns["Ngày mượn"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.Columns["Hạn trả"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            triggerSearch();

            if (gridView.SelectedRows.Count == 0)
            {
                btnClear_Click(btnClear, EventArgs.Empty);
            }
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            readerTable = Common.GetTable("SELECT ID_DG, TenDG FROM DocGia");
            cbDocGia.DataSource = readerTable;
            cbDocGia.DisplayMember = "TenDG";
            cbDocGia.ValueMember = "ID_DG";

            librarianTable = Common.GetTable("SELECT ID_TT, TenThuThu FROM ThuThu");
            cbThuThu.DataSource = librarianTable;
            cbThuThu.DisplayMember = "TenThuThu";
            cbThuThu.ValueMember = "ID_TT";

            bookTable = Common.GetBooks();
            cbSach.DataSource = bookTable;
            cbSach.DisplayMember = "Tên sách";
            cbSach.ValueMember = "Mã sách";

            currentBooksTable = bookTable.Clone();

            loadMainData();
            gridView.Columns["ID_DG"].Visible = false;
            gridView.Columns["ID_TT"].Visible = false;
            cbLocNgay.SelectedIndex = 0;
        }

        private void LoadRowToEditors(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                var selectedRow = gridView.Rows[rowIndex];
                cbDocGia.SelectedValue = (int)selectedRow.Cells["ID_DG"].Value;
                cbThuThu.SelectedValue = (int)selectedRow.Cells["ID_TT"].Value;
                int bookCount = (int)selectedRow.Cells["Số sách mượn"].Value;
                int Id = (int)selectedRow.Cells["ID_PM"].Value;
                DataTable table = Common.GetTable("SELECT Sach.ID_Sach AS ID_Sach FROM SACH INNER JOIN ChiTietPhieuMuon AS CTPM ON CTPM.ID_Sach = Sach.ID_Sach WHERE CTPM.ID_PM = @Id", "@Id", Id);

                cbSach.SelectedIndex = -1;
                currentBooksTable.Clear();
                foreach (DataRow row in table.Rows)
                {
                    currentBooksTable.ImportRow(bookTable.Rows.Find(row.Field<int>(0)));
                }

                cbSach.Enabled = true;
                if (bookCount > 1)
                {
                    cbSach.DropDownStyle = ComboBoxStyle.DropDown;
                    cbSach.Text = $"{bookCount} quyển sách";
                    cbSach.Enabled = false;
                }
                else
                {
                    cbSach.DropDownStyle = ComboBoxStyle.DropDownList;
                    update_cbSach_fromEvent = false;
                    cbSach.SelectedValue = currentBooksTable.Rows[0].Field<int>("Mã sách");
                    update_cbSach_fromEvent = true;
                }

                dtNgayMuon.Value = (DateTime)selectedRow.Cells["Ngày mượn"].Value;
                dtHanTra.Value = (DateTime)selectedRow.Cells["Hạn trả"].Value;
                checkDaTra.Checked = (bool)selectedRow.Cells["Đã trả"].Value;

                needUpdateCurrentBooks = false;
            }
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            bool returned = false;
            if (currentBooksTable.Rows.Count == 0 || gridView.Rows.Count == 0)
            {
                returned = true;
            }
            else if (gridView.SelectedRows.Count > 0)
            {
                var selectedRow = gridView.SelectedRows[0];
                returned = (bool)selectedRow.Cells["Đã trả"].Value;
            }

            using SachTrongPhieuMuon dialog = new SachTrongPhieuMuon();
            dialog.selectedBooks = currentBooksTable.Copy();
            //dialog.returned = returned;
            dialog.returned = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cbSach.SelectedIndex = -1;
                currentBooksTable = dialog.selectedBooks;
                if (!needUpdateCurrentBooks)
                {
                    needUpdateCurrentBooks = dialog.selectedBooksAreChanged;
                }

                int bookCount = currentBooksTable.Rows.Count;
                cbSach.Enabled = true;
                if (currentBooksTable.Rows.Count > 0)
                {
                    if (bookCount > 1)
                    {
                        cbSach.DropDownStyle = ComboBoxStyle.DropDown;
                        cbSach.Text = $"{bookCount} quyển sách";
                        cbSach.Enabled = false;
                    }
                    else
                    {
                        cbSach.DropDownStyle = ComboBoxStyle.DropDownList;
                        update_cbSach_fromEvent = false;
                        cbSach.SelectedValue = currentBooksTable.Rows[0].Field<int>("Mã sách");
                        update_cbSach_fromEvent = true;
                    }
                }
            }
        }

        private bool CheckComboBox(ComboBox comboBox, string msg)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show(msg, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckValid()
        {
            if (!CheckComboBox(cbDocGia, "Vui lòng chọn độc giả"))
            {
                return false;
            }
            if (currentBooksTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sách", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSach.Focus();
                return false;
            }
            if (!CheckComboBox(cbThuThu, "Vui lòng chọn thủ thư"))
            {
                return false;
            }
            return true;
        }

        private void addCurrentBooksToId(int id, bool checkExists)
        {
            int unavailableBooks = 0;
            foreach (DataRow row in currentBooksTable.Rows)
            {
                int bookId = row.Field<int>("Mã sách");
                bool available = true;
                if (checkExists)
                {
                    available = (bool)(Common.ExecuteReturnAValule("IF ((SELECT SoLuongSach FROM Sach WHERE ID_Sach = @Sach) > 0) SELECT CAST(1 AS BIT) ELSE SELECT CAST(0 AS BIT)", "@Sach", bookId) ?? false);
                }
                if (available)
                {
                    Common.Execute("INSERT INTO ChiTietPhieuMuon VALUES (@Id, @Sach)", "@Id", id, "@Sach", bookId);
                }
                else
                {
                    unavailableBooks++;
                }
            }

            if (unavailableBooks > 0)
            {
                if (currentBooksTable.Rows.Count == unavailableBooks)
                {
                    MessageBox.Show($"Tất cả các sách được chọn đều đã bị mượn hết rồi.", "Lỗi thêm phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Không thể mượn {unavailableBooks} trên tổng số {currentBooksTable.Rows.Count} sách do các sách đó đã cho mượn hết số lượng. Các sách khác vẫn được thêm vào phiếu mượn như thường.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                return;
            }

            int readerId = (int)cbDocGia.SelectedValue!;
            int librarianId = (int)cbThuThu.SelectedValue!;
            DateTime borrowDate = dtNgayMuon.Value;
            DateTime returnDate = dtHanTra.Value;
            bool returned = checkDaTra.Checked;

            if (returnDate <= borrowDate)
            {
                MessageBox.Show("Hạn trả phải xảy ra sau ngày mượn", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtNgayMuon.Focus();
                return;
            }

            int id = Common.ExecuteReturnInsertedId("INSERT INTO PhieuMuon VALUES (@DocGia, @ThuThu, @NgayMuon, @HanTra, @DaTra)", "@DocGia", readerId, "@ThuThu", librarianId, "@NgayMuon", borrowDate, "@HanTra", returnDate, "@DaTra", returned);
            addCurrentBooksToId(id, true);
            if (!returned)
            {
                Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, -1", "@Id", id);
            }

            loadMainData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var selectedRow = gridView.SelectedRows[0];
                int id = (int)selectedRow.Cells["ID_PM"].Value;
                bool returned = (bool)selectedRow.Cells["Đã trả"].Value;

                bool canDelete = (bool)(Common.ExecuteReturnAValule("IF EXISTS (SELECT * FROM PhieuTraMuon WHERE ID_PM = @Id) SELECT CAST(0 AS BIT) ELSE SELECT CAST(1 AS bit)", "@Id", id) ?? false);
                if (canDelete)
                {
                    if (!returned)
                    {
                        Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, 1", "@Id", id);
                    }
                    Common.Execute("DELETE FROM ChiTietPhieuMuon WHERE ID_PM = @Id", "@Id", id);
                    Common.Execute("DELETE FROM PhieuMuon WHERE ID_PM = @Id", "@Id", id);

                    loadMainData();
                }
                else
                {
                    MessageBox.Show("Không thể xoá phiếu mượn do có phiếu trả muộn liên kết với phiếu này.", "Lỗi xoá phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadMainData();
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn một phiếu mượn.", "Khoan đã", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDocGia.SelectedIndex = -1;
            cbSach.SelectedIndex = -1;
            cbSach.Text = "";
            cbSach.Enabled = true;
            dtNgayMuon.Value = DateTime.Now;
            dtHanTra.Value = DateTime.Now.AddDays(30);
            checkDaTra.Checked = false;
            currentBooksTable.Clear();
        }

        private void cbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update_cbSach_fromEvent)
            {
                currentBooksTable.Clear();
                if (cbSach.SelectedItem != null)
                {
                    currentBooksTable.ImportRow((cbSach.SelectedItem as DataRowView)!.Row);
                }
            }
        }

        private void gridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            LoadRowToEditors(e.RowIndex);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                if (!CheckValid())
                {
                    return;
                }

                var selectedRow = gridView.SelectedRows[0]!;
                int id = (int)selectedRow.Cells["ID_PM"].Value;
                int readerId = (int)cbDocGia.SelectedValue!;
                int librarianId = (int)cbThuThu.SelectedValue!;
                DateTime borrowDate = dtNgayMuon.Value;
                DateTime returnDate = dtHanTra.Value;
                bool returned = checkDaTra.Checked;

                bool oldReturned = (bool)selectedRow.Cells["Đã trả"].Value;
                bool returnedChanged = oldReturned != returned;
                if (returnedChanged)
                {
                    if (returned) // Chuyển từ chưa trả -> đã trả
                    {
                        // Trả sách bằng cách tăng số lượng trong kho của các sách
                        // đang mượn lên 1, rồi mới thay đổi sách mượn (bên dưới)
                        Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, 1", "@Id", id);
                    }
                    else // Chuyển từ đã trả -> chưa trả
                    {
                        foreach (DataRow row in currentBooksTable.Rows)
                        {
                            int bookId = row.Field<int>(0);
                            bool available = (bool)(Common.ExecuteReturnAValule("IF ((SELECT SoLuongSach FROM Sach WHERE ID_Sach = @IdSach) > 0) SELECT CAST(1 AS BIT) ELSE SELECT CAST(0 AS bit)", "@IdSach", bookId) ?? false);
                            if (!available)
                            {
                                MessageBox.Show(@"Không thể chuyển phiếu mượn từ đã trả sang chưa trả.
Nguyên nhân là do có ít nhất 1 sách mượn của phiếu đã bị mượn hết.", "Lỗi cập nhật phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else
                {
                    if (!returned) // Trạng thái vẫn là chưa trả
                    {
                        // Để sửa sách khi phiếu chưa trả, ta sẽ tạm thời trả hết sách
                        // rồi thay đổi các sách được mượn, sau đó mượn lại các sách
                        // đã thay đổi đó

                        // Tạm thời trả hết sách đang mượn
                        Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, 1", "@Id", id);
                    }
                }

                if (needUpdateCurrentBooks)
                {
                    // Thay đổi các sách mượn của phiếu bằng cách xoá hết sách mượn đang có
                    // trong CSDL rồi thêm các sách mượn từ selectedBooks vào CSDL
                    // Để đơn giản hoá quá trình, ta sẽ chỉ thay đổi sách mượn sau khi
                    // đảm bảo rằng các sách đã được (tạm) trả hết. Khi đó, việc xoá và thêm
                    // sách của phiếu đã trả sẽ không làm số lượng sách trong kho thay đổi.
                    Common.Execute("DELETE FROM ChiTietPhieuMuon WHERE ID_PM = @Id", "@Id", id);
                    addCurrentBooksToId(id, false);
                }

                if (returnedChanged)
                {
                    if (!returned) // Chuyển từ đã trả -> chưa trả
                    {
                        // Mượn lại sách bằng cách thay đổi sách mượn (bên trên),
                        // rồi mới giảm số lượng trong kho của các sách đang mượn xuống 1
                        Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, -1", "@Id", id);
                    }
                }
                else
                {
                    if (!returned) // Trạng thái vẫn là chưa trả
                    {
                        // Mượn lại các sách đã thay đổi
                        Common.Execute("EXEC SP_ChiTietPhieuMuon_ThayDoiSLSach @Id, -1", "@Id", id);
                    }
                }

                Common.Execute(@"
UPDATE PhieuMuon
SET ID_DG=@DocGia, ID_TT=@ThuThu, NgayMuon=@NgayMuon, HanTra=@HanTra, TrangThai=@DaTra
WHERE ID_PM = @Id
", "@DocGia", readerId, "@ThuThu", librarianId, "@NgayMuon", borrowDate, "@HanTra", returnDate, "@DaTra", returned, "@Id", id);

                if (returnedChanged && returned) // Chuyển từ chưa trả -> đã trả
                {
                    if (returnDate.Date < DateTime.Now.Date)
                    {
                        DialogResult result = MessageBox.Show(@"Phiếu mượn này bị trả muộn hơn hạn trả.
Quý thủ thư có muốn mở phần quản lí phiếu trả muộn không?", "Phiếu trả muộn", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes)
                        {
                            QLTRAMUON dialog = new QLTRAMUON(id);
                            dialog.ShowDialog();
                        }
                    }
                }

                loadMainData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn một phiếu mượn.", "Khoan đã", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string getDateFilter(string type)
        {
            List<string> conditions = new List<string>();
            if (checkTuNgay.Checked)
            {
                string dateString = "#" + dtTuNgay.Value.ToString("yyyy-MM-dd") + "#";
                string condition = $"([{type}] >= '{dateString}')";
                conditions.Add(condition);
            }
            if (checkDenNgay.Checked)
            {
                string dateString = "#" + dtDenNgay.Value.ToString("yyyy-MM-dd") + "#";
                string condition = $"([{type}] <= '{dateString}')";
                conditions.Add(condition);
            }
            if (conditions.Count > 0)
            {
                return "(" + string.Join(" AND ", conditions) + ")";
            }
            else
            {
                return "True";
            }
        }

        private void triggerSearch()
        {
            if (dtDenNgay.Value < dtTuNgay.Value)
            {
                MessageBox.Show("Ngày tìm đến không được nhỏ hơn ngày tìm từ.", "Lỗi tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtDenNgay.Value = dtTuNgay.Value;
                return;
            }

            List<string> conditions = new List<string>();
            if (checkLocNgay.Checked)
            {
                List<string> dateFilterConditions = new List<string>();
                string dateFilterOperator = "";

                if (cbLocNgay.SelectedIndex is (0 or 2 or 3))
                {
                    dateFilterConditions.Add(getDateFilter("Ngày mượn"));
                }
                if (cbLocNgay.SelectedIndex is (1 or 2 or 3))
                {
                    dateFilterConditions.Add(getDateFilter("Hạn trả"));
                }
                if (cbLocNgay.SelectedIndex == 2)
                {
                    dateFilterOperator = " OR ";
                }
                else if (cbLocNgay.SelectedIndex == 3)
                {
                    dateFilterOperator = " AND ";
                }

                string condition = "True";
                if (dateFilterConditions.Count > 0)
                {
                    condition = "(" + string.Join(dateFilterOperator, dateFilterConditions) + ")";
                }
                conditions.Add(condition);
            }
            if (checkTimDocGia.Checked)
            {
                string searchTerm = txtTimDocGia.Text.Trim();
                string condition = $"([Độc giả] LIKE '%{searchTerm}%')";
                conditions.Add(condition);
            }

            var defaultView = ((DataTable)gridView.DataSource).DefaultView;
            string filter = string.Join(" AND ", conditions);
            defaultView.RowFilter = filter;

            gbDanhSach.Text = $"Danh sách ({gridView.Rows.Count})";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            triggerSearch();
        }

        private void checkLocDaTra_CheckedChanged(object sender, EventArgs e)
        {
            loadMainData();
        }

        private void checkTimDocGia_CheckedChanged(object sender, EventArgs e)
        {
            txtTimDocGia.Enabled = checkTimDocGia.Checked;
            triggerSearch();
        }

        private void checkLocNgay_CheckedChanged(object sender, EventArgs e)
        {
            panelLocNgay.Enabled = checkLocNgay.Checked;
            triggerSearch();
        }

        private void checkTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtTuNgay.Enabled = checkTuNgay.Checked;
            triggerSearch();
        }

        private void cbDenNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtDenNgay.Enabled = checkDenNgay.Checked;
            triggerSearch();
        }

        private void txtTimDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
    }
}
