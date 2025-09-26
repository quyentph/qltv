using Giao_dien_dang_nhap;
using QuanLiThuVien_PhieuMuon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThuVien_Nhom2
{
    public partial class ThuThu : Form
    {
        private string loggedInUsername;

        // Constructor that accepts the logged-in username
        public ThuThu(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
        }

        // Default constructor for when you don't need to pass a username
        public ThuThu()
        {
            InitializeComponent();
        }

        private void ThuThu_Load(object sender, EventArgs e)
        {
            LoadLibrarianInfo();
        }

        private void LoadLibrarianInfo()
        {
            string query = "SELECT ID_TT, TenThuThu, GioiTinh, ChucVu FROM ThuThu WHERE Username = @username";
            DataTable dt = Common.GetTable(query, "@username", loggedInUsername);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtid.Text = row["ID_TT"].ToString();
                txtten.Text = row["TenThuThu"].ToString();
                txtgt.Text = row["GioiTinh"].ToString();
                txtchucvu.Text = row["ChucVu"].ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtgt.Clear();
            txtchucvu.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var loginForm = new DangNhap();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            //Doimk doiMatKhauForm = new Doimk(loggedInUsername);
            //doiMatKhauForm.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Add a check to ensure all textboxes are not empty
            if (string.IsNullOrEmpty(txtten.Text) || string.IsNullOrEmpty(txtgt.Text) || string.IsNullOrEmpty(txtchucvu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các trường!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop the execution if any field is empty
            }

            // Update librarian info in the database
            string query = "UPDATE ThuThu SET TenThuThu = @ten, GioiTinh = @gt, ChucVu = @cv WHERE Username = @username";
            bool success = Common.Execute(query,
                "@ten", txtten.Text,
                "@gt", txtgt.Text,
                "@cv", txtchucvu.Text,
                "@username", loggedInUsername);

            if (success)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
