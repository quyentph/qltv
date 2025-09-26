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

using QuanLyThuVien;

namespace Giao_dien_dang_nhap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Data data = new Data();
        private void linkdki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txttendangnhap.Text.Length > 0 && txtmk.Text.Length > 0)
            {
                string query = "SELECT Pass FROM TaiKhoan WHERE Username = @Value1";
                SqlParameter p = new SqlParameter("Value1", txttendangnhap.Text);
                string cellValue = data.Scalar(query, p);
                if (!string.IsNullOrEmpty(cellValue))
                {
                    if (cellValue.Equals(txtmk.Text))
                    {
                        txtmk.Clear();
                        txttendangnhap.Clear();
                        txtmk.Focus();
                        this.Hide();
                        QuanLyThuVien.QuanLyThuVien newForm = new QuanLyThuVien.QuanLyThuVien(txttendangnhap.Text);
                        newForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmk.Clear();
                        txtmk.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttendangnhap.Text = "";
                    txtmk.Clear();
                    txttendangnhap.Focus();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txttendangnhap.Text))
                {
                    MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttendangnhap.Focus();
                }
                else if (string.IsNullOrEmpty(txtmk.Text))
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmk.Focus();
                }
            }

        }



        private void DangNhap_Load(object sender, EventArgs e)
        {
            pShow.BringToFront();
            txtmk.KeyDown += new KeyEventHandler(txtmk_KeyDown);
        }

        private void pShow_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '*')
            {
                txtmk.PasswordChar = '\0';
            }
            pHide.BringToFront();
        }

        private void pHide_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0')
            {
                txtmk.PasswordChar = '*';
            }
            pShow.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap.PerformClick();
                e.SuppressKeyPress = true;
                this.Hide();
            }
        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


