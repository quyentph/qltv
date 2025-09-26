using System;
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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        Data data = new Data();
        private void btndangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttentk.Text) || string.IsNullOrWhiteSpace(txtmktk.Text) || string.IsNullOrWhiteSpace(txtxacthuc.Text))
            {
                if (string.IsNullOrWhiteSpace(txttentk.Text))
                {
                    MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttentk.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtmktk.Text))
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmktk.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtxacthuc.Text))
                {
                    MessageBox.Show("Chưa nhập xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtxacthuc.Focus();
                    return;
                }
            }

            if (txttentk.Text.Any(ch => !char.IsDigit(ch) && !char.IsLetter(ch)))
            {
                MessageBox.Show("Tên tài khoản không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentk.Clear();
                txttentk.Focus();
                return;
            }
            if (txtmktk.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmktk.Clear();
                txtmktk.Focus();
                return;
            }
            if (txtxacthuc.Text.Contains(" "))
            {
                MessageBox.Show("Xác nhận mật khẩu không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtxacthuc.Clear();
                txtxacthuc.Focus();
                return;
            }

            if (!txtmktk.Text.Equals(txtxacthuc.Text))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtxacthuc.Clear();
                txtxacthuc.Focus();
                return;
            }

            string query = "SELECT Username FROM TaiKhoan WHERE Username = @Value1";
            SqlParameter p = new SqlParameter("@Value1", txttentk.Text);
            string valueCell = data.Scalar(query, p);
            if (!string.IsNullOrEmpty(valueCell))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttentk.Clear();
                txtmktk.Clear();
                txtxacthuc.Clear();
                txttentk.Focus();
                return;
            }

            string query2 = "INSERT INTO TaiKhoan VALUES(@Value1, @Value2)";
            SqlParameter[] args =
            {
                new SqlParameter("@Value1", txttentk.Text),
                new SqlParameter("@Value2", txtmktk.Text),
            };

            if (data.Excute(query2, args))
            {
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể tạo tài khoản, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtxacthuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
