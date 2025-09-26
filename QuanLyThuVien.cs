using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PhieuTraMuon;
using QuanLiThuVien_PhieuMuon;
using QuanLyTacGia;
using testgiaodien;
using Giao_dien_dang_nhap;
using BTL_QuanLyThuVien_Nhom2;

namespace QuanLyThuVien
{
    public partial class QuanLyThuVien : Form
    {
        private string username;
        public QuanLyThuVien()
        {
            InitializeComponent();
        }

        public QuanLyThuVien(string username) 
        {
            InitializeComponent();
            this.username = username;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DocGia form = new DocGia();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoaiSach form = new LoaiSach();
            form.ShowDialog();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            btnQLTT.BackColor = Color.Navy;
        }

        private void btQLTK_MouseLeave(object sender, EventArgs e)
        {
            btnQLTT.BackColor = Color.Transparent;
        }

        private void btnQLTG_Click(object sender, EventArgs e)
        {
            QuanLyTacGia.TacGia form = new QuanLyTacGia.TacGia();
            form.ShowDialog();
        }

        private void btnQLS_Click(object sender, EventArgs e)
        {
            Sach form = new Sach();
            form.ShowDialog();
        }

        private void btnQLPM_Click(object sender, EventArgs e)
        {
            PhieuMuon form = new PhieuMuon();
            form.ShowDialog();
        }

        private void btnQLPTM_Click(object sender, EventArgs e)
        {
            QLTRAMUON form = new QLTRAMUON();
            form.ShowDialog();
        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            GiaoDien form = new GiaoDien();
            form.ShowDialog();
        }

        private void QuanLyThuVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog =
            MessageBox.Show("Bạn có muốn thoát khỏi giao diện này không? Bạn cũng sẽ đăng xuất.", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
                this.FormClosed += new FormClosedEventHandler((s, args) =>
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.Show();
                });
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnQLTG_MouseEnter(object sender, EventArgs e)
        {
            btnQLTG.BackColor = Color.Navy;
        }

        private void btnQLDG_MouseEnter(object sender, EventArgs e)
        {
            btnQLDG.BackColor = Color.Navy;
        }

        private void btnQLLS_MouseEnter(object sender, EventArgs e)
        {
            btnQLLS.BackColor = Color.Navy;
        }

        private void btnQLS_MouseEnter(object sender, EventArgs e)
        {
            btnQLS.BackColor = Color.Navy;
        }

        private void btnQLPM_MouseEnter(object sender, EventArgs e)
        {
            btnQLPM.BackColor = Color.Navy;
        }

        private void btnQLPTM_MouseEnter(object sender, EventArgs e)
        {
            btnQLPTM.BackColor = Color.Navy;
        }

        private void btnQLTG_MouseLeave(object sender, EventArgs e)
        {
            btnQLTG.BackColor = Color.Transparent;
        }

        private void btnQLDG_MouseLeave(object sender, EventArgs e)
        {
            btnQLDG.BackColor = Color.Transparent;
        }

        private void btnQLLS_MouseLeave(object sender, EventArgs e)
        {
            btnQLLS.BackColor = Color.Transparent;
        }

        private void btnQLS_MouseLeave(object sender, EventArgs e)
        {
            btnQLS.BackColor = Color.Transparent;
        }

        private void btnQLPM_MouseLeave(object sender, EventArgs e)
        {
            btnQLPM.BackColor = Color.Transparent;
        }

        private void btnQLPTM_MouseLeave(object sender, EventArgs e)
        {
            btnQLPTM.BackColor = Color.Transparent;
        }

        private void QuanLyThuVien_Load(object sender, EventArgs e)
        {

        }
    }
}
