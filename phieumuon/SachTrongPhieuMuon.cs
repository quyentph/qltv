using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace QuanLiThuVien_PhieuMuon
{
    public partial class SachTrongPhieuMuon : Form
    {
        public DataTable books = new DataTable();
        private DataTable _selectedBooks = new DataTable();
        // Đây là 1 thuộc tính của lớp SachTrongPhieuMuon, lưu các sách được chọn
        public DataTable selectedBooks
        {
            // từ khoá get quy định hàm getter của thuộc tính selectedBooks
            // Có cái này thì hai lệnh sau giống nhau:
            // DataTable a = dialog.selectedBooks;
            // DataTable a = dialog.getSelectedBooks();
            // Vì selectedBooks là thuộc tính nên ta cần có 1 biến để lưu giá trị thực sự của selectedBooks
            // Ta dùng biến _selectedBooks để lưu giá trị thực của selectedBooks
            get => _selectedBooks;
            // từ khoá set quy định hàm setter của thuộc tính selectedBooks
            // Có cái này thì hai lệnh sau giống nhau:
            // dialog.selectedBooks = new DataTable();
            // dialog.setSelectedBooks(new DataTable());
            // Như trên, ta dùng biến _selectedBooks để lưu giá trị thực của selectedBooks
            set
            {
                _selectedBooks = value;
                // Gán khoá chính cho selectedBooks
                // Việc gán khoá chính này để phục vụ tìm hàng dữ liệu sách theo mã sách
                // Hàm selectedBooks.Rows.Find(<mã sách>) sẽ tìm theo cột khoá chính
                _selectedBooks.PrimaryKey = [_selectedBooks.Columns[0]];
                gridView.DataSource = _selectedBooks;
                gridView.Columns["Mã sách"].Visible = false;
                gridView.Columns["Số lượng"].Visible = false;

                gridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }
        public bool returned = false;
        public bool selectedBooksAreChanged = false;
        private string[] searchFields = ["Tên sách", "Thể loại", "Tác giả", "Số lượng"];
        private string searchField = "";

        public SachTrongPhieuMuon()
        {
            InitializeComponent();

            Common.setDoubleBuffered(gridViewTim);
            Common.setDoubleBuffered(gridView);
        }

        private void triggerSearch()
        {
            if (searchField == "Số lượng")
            {
                try
                {
                    int amount = int.Parse(txtTim.Text.Trim());
                    if (amount >= 0)
                    {
                        books.DefaultView.RowFilter = "[Số lượng] = " + amount;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sách phải lớn hơn hoặc bằng 0.", "Lỗi tìm sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    books.DefaultView.RowFilter = "";
                    txtTim.Clear();
                }
            }
            else
            {
                books.DefaultView.RowFilter = $"[{searchField}] LIKE '%{txtTim.Text.Trim()}%'";
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            triggerSearch();
        }

        private void showMessageNotEditable()
        {
            MessageBox.Show("Không thể thay đổi sách mượn khi phiếu mượn ở trạng thái chưa trả.", "Lỗi sửa sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!returned)
            {
                showMessageNotEditable();
                return;
            }

            selectedBooks.Clear();
            selectedBooksAreChanged = true;
            gbChon.Text = $"Sách được chọn ({selectedBooks.Rows.Count})";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!returned)
            {
                showMessageNotEditable();
                return;
            }

            foreach (DataGridViewRow row in gridViewTim.SelectedRows)
            {
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                if (selectedBooks.Rows.Find(dataRow.Field<int>(0)) == null)
                {
                    if (dataRow.Field<int>("Số lượng") > 0)
                    {
                        selectedBooks.ImportRow(dataRow);
                        selectedBooksAreChanged = true;
                    }
                }
            }
            selectedBooks.AcceptChanges();
            gridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!returned)
            {
                showMessageNotEditable();
                return;
            }

            foreach (DataGridViewRow row in gridView.SelectedRows)
            {
                ((DataRowView)row.DataBoundItem).Row.Delete();
                selectedBooksAreChanged = true;
            }
            selectedBooks.AcceptChanges();
            gridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            btnChon.Enabled = selectedBooks.Rows.Count > 0;
        }

        private void SachTrongPhieuMuon_Load(object sender, EventArgs e)
        {
            books = Common.GetBooks(false);
            gridViewTim.DataSource = books;
            gridViewTim.Columns["Mã sách"].Visible = false;
            gridViewTim.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            var textUpdateFunc = () =>
            {
                gbChon.Text = $"Sách được chọn ({selectedBooks.Rows.Count})";
            };

            selectedBooks.RowDeleted += (sender, e) => textUpdateFunc();
            selectedBooks.TableNewRow += (sender, e) => textUpdateFunc();
            selectedBooks.RowChanged += (sender, e) => textUpdateFunc();

            cbTimTheo.SelectedIndex = 0;

            textUpdateFunc();
            btnChon.Enabled = selectedBooks.Rows.Count > 0;
            gridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchField = searchFields[cbTimTheo.SelectedIndex];
            triggerSearch();
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchField == "Số lượng")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
