namespace Giao_dien_dang_nhap
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            txttendangnhap = new TextBox();
            txtmk = new TextBox();
            linkdki = new LinkLabel();
            btndangnhap = new Button();
            pictureBox2 = new PictureBox();
            pShow = new PictureBox();
            pHide = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txttendangnhap
            // 
            txttendangnhap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txttendangnhap.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttendangnhap.Location = new Point(204, 133);
            txttendangnhap.Margin = new Padding(2, 3, 2, 3);
            txttendangnhap.Multiline = true;
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(307, 34);
            txttendangnhap.TabIndex = 2;
            txttendangnhap.TextAlign = HorizontalAlignment.Center;
            txttendangnhap.TextChanged += txttendangnhap_TextChanged;
            // 
            // txtmk
            // 
            txtmk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtmk.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtmk.Location = new Point(204, 195);
            txtmk.Margin = new Padding(2, 3, 2, 3);
            txtmk.Multiline = true;
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(307, 34);
            txtmk.TabIndex = 4;
            txtmk.TextAlign = HorizontalAlignment.Center;
            txtmk.KeyDown += txtmk_KeyDown;
            // 
            // linkdki
            // 
            linkdki.ActiveLinkColor = Color.LawnGreen;
            linkdki.Anchor = AnchorStyles.Top;
            linkdki.AutoSize = true;
            linkdki.BackColor = Color.Transparent;
            linkdki.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkdki.ForeColor = Color.LemonChiffon;
            linkdki.LinkColor = Color.LightYellow;
            linkdki.Location = new Point(444, 332);
            linkdki.Margin = new Padding(2, 0, 2, 0);
            linkdki.Name = "linkdki";
            linkdki.Size = new Size(121, 25);
            linkdki.TabIndex = 6;
            linkdki.TabStop = true;
            linkdki.Text = "ĐĂNG KÝ";
            linkdki.LinkClicked += linkdki_LinkClicked;
            // 
            // btndangnhap
            // 
            btndangnhap.Anchor = AnchorStyles.Top;
            btndangnhap.BackColor = Color.Cornsilk;
            btndangnhap.FlatStyle = FlatStyle.Flat;
            btndangnhap.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndangnhap.ForeColor = Color.Black;
            btndangnhap.Location = new Point(229, 256);
            btndangnhap.Margin = new Padding(2, 3, 2, 3);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(257, 37);
            btndangnhap.TabIndex = 7;
            btndangnhap.Text = "ĐĂNG NHẬP";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = BTL_QuanLyThuVien_Nhom2.Properties.Resources.OIP__2__removebg_preview;
            pictureBox2.Location = new Point(108, 123);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pShow
            // 
            pShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pShow.BackColor = Color.Transparent;
            pShow.Image = (Image)resources.GetObject("pShow.Image");
            pShow.Location = new Point(529, 195);
            pShow.Margin = new Padding(2, 1, 2, 1);
            pShow.Name = "pShow";
            pShow.Size = new Size(44, 33);
            pShow.SizeMode = PictureBoxSizeMode.Zoom;
            pShow.TabIndex = 9;
            pShow.TabStop = false;
            pShow.Click += pShow_Click;
            // 
            // pHide
            // 
            pHide.BackColor = Color.Transparent;
            pHide.Image = (Image)resources.GetObject("pHide.Image");
            pHide.Location = new Point(529, 195);
            pHide.Margin = new Padding(2, 1, 2, 1);
            pHide.Name = "pHide";
            pHide.Size = new Size(44, 33);
            pHide.SizeMode = PictureBoxSizeMode.Zoom;
            pHide.TabIndex = 10;
            pHide.TabStop = false;
            pHide.Click += pHide_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.LemonChiffon;
            label2.Location = new Point(105, 332);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(345, 25);
            label2.TabIndex = 11;
            label2.Text = "BẠN CHƯA CÓ TÀI KHOẢN →";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(105, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 53);
            label1.TabIndex = 14;
            label1.Text = "QUẢN LÝ THƯ VIỆN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 188);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = BTL_QuanLyThuVien_Nhom2.Properties.Resources.product_presentation_wooden_table_with_background_empty_bookshelf_library_172251_444;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 447);
            Controls.Add(pHide);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pShow);
            Controls.Add(btndangnhap);
            Controls.Add(linkdki);
            Controls.Add(txtmk);
            Controls.Add(txttendangnhap);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.LinkLabel linkdki;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.PictureBox pShow;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

