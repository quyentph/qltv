namespace QuanLiThuVien_PhieuMuon
{
    partial class PhieuMuon
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkDaTra = new CheckBox();
            label2 = new Label();
            dtHanTra = new DateTimePicker();
            cbSach = new ComboBox();
            label6 = new Label();
            cbDocGia = new ComboBox();
            btnChonSach = new Button();
            label5 = new Label();
            dtNgayMuon = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            cbThuThu = new ComboBox();
            gbDanhSach = new GroupBox();
            gridView = new DataGridView();
            btnLap = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            checkLocDaTra = new CheckBox();
            txtTimDocGia = new TextBox();
            btnClear = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelLocNgay = new FlowLayoutPanel();
            cbLocNgay = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            checkTuNgay = new CheckBox();
            dtTuNgay = new DateTimePicker();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkDenNgay = new CheckBox();
            dtDenNgay = new DateTimePicker();
            checkTimDocGia = new CheckBox();
            checkLocNgay = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelLocNgay.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 254);
            label1.Location = new Point(376, 38);
            label1.Name = "label1";
            label1.Size = new Size(264, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản lí phiếu mượn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(812, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết phiếu mượn";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(checkDaTra, 4, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dtHanTra, 4, 1);
            tableLayoutPanel1.Controls.Add(cbSach, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 3, 1);
            tableLayoutPanel1.Controls.Add(cbDocGia, 1, 0);
            tableLayoutPanel1.Controls.Add(btnChonSach, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(dtNgayMuon, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(cbThuThu, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(806, 108);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // checkDaTra
            // 
            checkDaTra.AutoSize = true;
            checkDaTra.Location = new Point(646, 77);
            checkDaTra.Margin = new Padding(3, 4, 3, 4);
            checkDaTra.Name = "checkDaTra";
            checkDaTra.Size = new Size(72, 24);
            checkDaTra.TabIndex = 12;
            checkDaTra.Text = "Đã trả";
            checkDaTra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 36);
            label2.TabIndex = 0;
            label2.Text = "Độc giả:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtHanTra
            // 
            dtHanTra.CustomFormat = "dd/MM/yyyy";
            dtHanTra.Format = DateTimePickerFormat.Custom;
            dtHanTra.Location = new Point(646, 40);
            dtHanTra.Margin = new Padding(3, 4, 3, 4);
            dtHanTra.Name = "dtHanTra";
            dtHanTra.Size = new Size(131, 27);
            dtHanTra.TabIndex = 9;
            // 
            // cbSach
            // 
            cbSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSach.FormattingEnabled = true;
            cbSach.Location = new Point(73, 40);
            cbSach.Margin = new Padding(3, 4, 3, 4);
            cbSach.Name = "cbSach";
            cbSach.Size = new Size(390, 28);
            cbSach.TabIndex = 11;
            cbSach.SelectedIndexChanged += cbSach_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(550, 36);
            label6.Name = "label6";
            label6.Size = new Size(90, 37);
            label6.TabIndex = 7;
            label6.Text = "Hạn trả";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbDocGia
            // 
            cbDocGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDocGia.FormattingEnabled = true;
            cbDocGia.Location = new Point(73, 4);
            cbDocGia.Margin = new Padding(3, 4, 3, 4);
            cbDocGia.Name = "cbDocGia";
            cbDocGia.Size = new Size(244, 28);
            cbDocGia.TabIndex = 10;
            // 
            // btnChonSach
            // 
            btnChonSach.Location = new Point(469, 40);
            btnChonSach.Margin = new Padding(3, 4, 3, 4);
            btnChonSach.Name = "btnChonSach";
            btnChonSach.Size = new Size(75, 29);
            btnChonSach.TabIndex = 6;
            btnChonSach.Text = "Chọn...";
            btnChonSach.UseVisualStyleBackColor = true;
            btnChonSach.Click += btnChonSach_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(550, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 36);
            label5.TabIndex = 2;
            label5.Text = "Ngày mượn:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtNgayMuon
            // 
            dtNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtNgayMuon.Format = DateTimePickerFormat.Custom;
            dtNgayMuon.Location = new Point(646, 4);
            dtNgayMuon.Margin = new Padding(3, 4, 3, 4);
            dtNgayMuon.Name = "dtNgayMuon";
            dtNgayMuon.Size = new Size(131, 27);
            dtNgayMuon.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 36);
            label4.Name = "label4";
            label4.Size = new Size(64, 37);
            label4.TabIndex = 1;
            label4.Text = "Sách:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(64, 35);
            label3.TabIndex = 13;
            label3.Text = "Thủ thư:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbThuThu
            // 
            cbThuThu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThuThu.FormattingEnabled = true;
            cbThuThu.Location = new Point(73, 76);
            cbThuThu.Name = "cbThuThu";
            cbThuThu.Size = new Size(244, 28);
            cbThuThu.TabIndex = 14;
            // 
            // gbDanhSach
            // 
            gbDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbDanhSach.Controls.Add(gridView);
            gbDanhSach.Location = new Point(12, 279);
            gbDanhSach.Margin = new Padding(3, 4, 3, 4);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Padding = new Padding(3, 4, 3, 4);
            gbDanhSach.Size = new Size(977, 355);
            gbDanhSach.TabIndex = 2;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh sách (0)";
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ColumnHeadersHeight = 29;
            gridView.Dock = DockStyle.Fill;
            gridView.Location = new Point(3, 24);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 24;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(971, 327);
            gridView.TabIndex = 0;
            gridView.RowEnter += gridView_RowEnter;
            // 
            // btnLap
            // 
            btnLap.Location = new Point(12, 236);
            btnLap.Margin = new Padding(3, 4, 3, 4);
            btnLap.Name = "btnLap";
            btnLap.Size = new Size(95, 39);
            btnLap.TabIndex = 3;
            btnLap.Text = "Lập phiếu";
            btnLap.UseVisualStyleBackColor = true;
            btnLap.Click += btnLap_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(113, 237);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 38);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(194, 237);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 38);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // checkLocDaTra
            // 
            checkLocDaTra.Anchor = AnchorStyles.Right;
            checkLocDaTra.AutoSize = true;
            checkLocDaTra.Checked = true;
            checkLocDaTra.CheckState = CheckState.Checked;
            checkLocDaTra.Location = new Point(788, 27);
            checkLocDaTra.Margin = new Padding(3, 4, 3, 4);
            checkLocDaTra.Name = "checkLocDaTra";
            tableLayoutPanel2.SetRowSpan(checkLocDaTra, 2);
            checkLocDaTra.Size = new Size(176, 24);
            checkLocDaTra.TabIndex = 8;
            checkLocDaTra.Text = "Ẩn phiếu mượn đã trả";
            checkLocDaTra.TextAlign = ContentAlignment.MiddleRight;
            checkLocDaTra.UseVisualStyleBackColor = true;
            checkLocDaTra.CheckedChanged += checkLocDaTra_CheckedChanged;
            // 
            // txtTimDocGia
            // 
            txtTimDocGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimDocGia.Enabled = false;
            txtTimDocGia.Location = new Point(130, 47);
            txtTimDocGia.Margin = new Padding(3, 4, 3, 4);
            txtTimDocGia.Name = "txtTimDocGia";
            txtTimDocGia.Size = new Size(640, 27);
            txtTimDocGia.TabIndex = 10;
            txtTimDocGia.TextChanged += txtTim_TextChanged;
            txtTimDocGia.KeyPress += txtTimDocGia_KeyPress;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(848, 236);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 38);
            btnClear.TabIndex = 11;
            btnClear.Text = "Xoá nhập liệu";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(12, 643);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(973, 101);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(checkLocDaTra, 2, 0);
            tableLayoutPanel2.Controls.Add(panelLocNgay, 1, 0);
            tableLayoutPanel2.Controls.Add(checkTimDocGia, 0, 1);
            tableLayoutPanel2.Controls.Add(checkLocNgay, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTimDocGia, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(967, 75);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // panelLocNgay
            // 
            panelLocNgay.AutoSize = true;
            panelLocNgay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLocNgay.Controls.Add(cbLocNgay);
            panelLocNgay.Controls.Add(tableLayoutPanel3);
            panelLocNgay.Controls.Add(tableLayoutPanel4);
            panelLocNgay.Dock = DockStyle.Fill;
            panelLocNgay.Enabled = false;
            panelLocNgay.Location = new Point(128, 1);
            panelLocNgay.Margin = new Padding(1);
            panelLocNgay.Name = "panelLocNgay";
            panelLocNgay.Size = new Size(644, 41);
            panelLocNgay.TabIndex = 18;
            // 
            // cbLocNgay
            // 
            cbLocNgay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocNgay.FormattingEnabled = true;
            cbLocNgay.Items.AddRange(new object[] { "Ngày mượn", "Hạn trả", "Một trong các cái trên", "Tất cả trong các cái trên" });
            cbLocNgay.Location = new Point(3, 3);
            cbLocNgay.Name = "cbLocNgay";
            cbLocNgay.Size = new Size(230, 28);
            cbLocNgay.TabIndex = 13;
            cbLocNgay.SelectedIndexChanged += txtTim_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(checkTuNgay, 0, 0);
            tableLayoutPanel3.Controls.Add(dtTuNgay, 1, 0);
            tableLayoutPanel3.Location = new Point(239, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(190, 33);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // checkTuNgay
            // 
            checkTuNgay.AutoSize = true;
            checkTuNgay.Checked = true;
            checkTuNgay.CheckState = CheckState.Checked;
            checkTuNgay.Dock = DockStyle.Fill;
            checkTuNgay.Location = new Point(3, 3);
            checkTuNgay.Name = "checkTuNgay";
            checkTuNgay.Size = new Size(45, 27);
            checkTuNgay.TabIndex = 14;
            checkTuNgay.Text = "từ";
            checkTuNgay.TextAlign = ContentAlignment.MiddleRight;
            checkTuNgay.UseVisualStyleBackColor = true;
            checkTuNgay.CheckedChanged += checkTuNgay_CheckedChanged;
            // 
            // dtTuNgay
            // 
            dtTuNgay.CustomFormat = "dd/MM/yyyy";
            dtTuNgay.Dock = DockStyle.Fill;
            dtTuNgay.Format = DateTimePickerFormat.Custom;
            dtTuNgay.Location = new Point(54, 4);
            dtTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtTuNgay.Name = "dtTuNgay";
            dtTuNgay.Size = new Size(133, 27);
            dtTuNgay.TabIndex = 8;
            dtTuNgay.ValueChanged += txtTim_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(checkDenNgay, 0, 0);
            tableLayoutPanel4.Controls.Add(dtDenNgay, 1, 0);
            tableLayoutPanel4.Location = new Point(435, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(206, 35);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // checkDenNgay
            // 
            checkDenNgay.AutoSize = true;
            checkDenNgay.Checked = true;
            checkDenNgay.CheckState = CheckState.Checked;
            checkDenNgay.Dock = DockStyle.Fill;
            checkDenNgay.Location = new Point(3, 3);
            checkDenNgay.Name = "checkDenNgay";
            checkDenNgay.Size = new Size(56, 29);
            checkDenNgay.TabIndex = 15;
            checkDenNgay.Text = "đến";
            checkDenNgay.TextAlign = ContentAlignment.MiddleRight;
            checkDenNgay.UseVisualStyleBackColor = true;
            checkDenNgay.CheckedChanged += cbDenNgay_CheckedChanged;
            // 
            // dtDenNgay
            // 
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
            dtDenNgay.Dock = DockStyle.Fill;
            dtDenNgay.Format = DateTimePickerFormat.Custom;
            dtDenNgay.Location = new Point(65, 4);
            dtDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtDenNgay.Name = "dtDenNgay";
            dtDenNgay.Size = new Size(138, 27);
            dtDenNgay.TabIndex = 8;
            dtDenNgay.ValueChanged += txtTim_TextChanged;
            // 
            // checkTimDocGia
            // 
            checkTimDocGia.AutoSize = true;
            checkTimDocGia.Dock = DockStyle.Fill;
            checkTimDocGia.Location = new Point(3, 46);
            checkTimDocGia.Name = "checkTimDocGia";
            checkTimDocGia.Size = new Size(121, 29);
            checkTimDocGia.TabIndex = 12;
            checkTimDocGia.Text = "Theo độc giả:";
            checkTimDocGia.UseVisualStyleBackColor = true;
            checkTimDocGia.CheckedChanged += checkTimDocGia_CheckedChanged;
            // 
            // checkLocNgay
            // 
            checkLocNgay.AutoSize = true;
            checkLocNgay.Dock = DockStyle.Fill;
            checkLocNgay.Location = new Point(3, 3);
            checkLocNgay.Name = "checkLocNgay";
            checkLocNgay.Size = new Size(121, 37);
            checkLocNgay.TabIndex = 11;
            checkLocNgay.Text = "Theo ngày:";
            checkLocNgay.UseVisualStyleBackColor = true;
            checkLocNgay.CheckedChanged += checkLocNgay_CheckedChanged;
            // 
            // PhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 756);
            Controls.Add(groupBox2);
            Controls.Add(btnClear);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLap);
            Controls.Add(gbDanhSach);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhieuMuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí phiếu mượn";
            Load += PhieuMuon_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panelLocNgay.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbSach;
        private System.Windows.Forms.ComboBox cbDocGia;
        private System.Windows.Forms.DateTimePicker dtHanTra;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChonSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.CheckBox checkLocDaTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimDocGia;
        private System.Windows.Forms.CheckBox checkDaTra;
        private Button btnClear;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private CheckBox checkTimDocGia;
        private CheckBox checkLocNgay;
        private ComboBox cbLocNgay;
        private CheckBox checkDenNgay;
        private CheckBox checkTuNgay;
        private DateTimePicker dtTuNgay;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel panelLocNgay;
        private DateTimePicker dtDenNgay;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private ComboBox cbThuThu;
    }
}

