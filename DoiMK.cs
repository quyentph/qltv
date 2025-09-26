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
    public partial class DoiMK : Form
    {
        Data data = new Data();

        public DoiMK()
        {
            InitializeComponent();
        }

        private void btndoi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txttentk.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentk.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtmkc.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmkc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtmkm.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmkm.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtxacnhan.Text))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtxacnhan.Focus();
                return;
            }

            string laymk = "SELECT Username FROM TaiKhoan WHERE Username = @value1 AND Pass = @value2";
            SqlParameter[] p =
            {
                new SqlParameter("value1", txttentk.Text),
                new SqlParameter("value2", txtmkc.Text)
            };

            string result = data.Scalar(laymk, p);

            if (!string.IsNullOrEmpty(result))
            {

                if (txtmkm.Text.Equals(txtmkc.Text))
                {
                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmkm.Clear();
                    txtmkm.Focus();
                    return;
                }


                if (txtmkm.Text.Contains(" "))
                {
                    MessageBox.Show("Mật khẩu mới không được chứa khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmkm.Clear();
                    txtmkm.Focus();
                    return;
                }


                if (!txtmkm.Text.Equals(txtxacnhan.Text))
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp với mật khẩu nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtxacnhan.Clear();
                    txtxacnhan.Focus();
                    return;
                }


                string query = "UPDATE TaiKhoan SET Pass = @value2 WHERE Username = @value3";
                SqlParameter[] q =
                {
                    new SqlParameter("value2", txtmkm.Text),
                    new SqlParameter("value3", txttentk.Text)
                };

                if (data.Excute(query, q))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi đổi mật khẩu, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Close();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
