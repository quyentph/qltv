namespace PhieuTraMuon
{
    partial class QLTRAMUON
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateNgayTra = new DateTimePicker();
            label11 = new Label();
            btnChonSach = new Button();
            txtSoSachMuon = new TextBox();
            label9 = new Label();
            cbSachDaMuon = new ComboBox();
            cbMaPM = new ComboBox();
            cbTenDG = new ComboBox();
            cbTenTT = new ComboBox();
            txtSoNgayMuon = new TextBox();
            txtTienPhat = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtFind = new TextBox();
            label10 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            dataLatePaid = new DataGridView();
            ColumnTenThuThu = new DataGridViewTextBoxColumn();
            ColumnTenDG = new DataGridViewTextBoxColumn();
            ColumnSDT = new DataGridViewTextBoxColumn();
            ColumnHanTra = new DataGridViewTextBoxColumn();
            ColumnNgayTra = new DataGridViewTextBoxColumn();
            ColumnSoSachDaMuon = new DataGridViewTextBoxColumn();
            ColumnSoNgayTraMuon = new DataGridViewTextBoxColumn();
            ColumnTienPhat = new DataGridViewTextBoxColumn();
            ColumnID_PTM = new DataGridViewTextBoxColumn();
            ColumnID_TT = new DataGridViewTextBoxColumn();
            ColumnID_PM = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            btnThoat = new Button();
            cbTim = new ComboBox();
            btnSua = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLatePaid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lí phiếu trả muộn";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dateNgayTra);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(btnChonSach);
            groupBox1.Controls.Add(txtSoSachMuon);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbSachDaMuon);
            groupBox1.Controls.Add(cbMaPM);
            groupBox1.Controls.Add(cbTenDG);
            groupBox1.Controls.Add(cbTenTT);
            groupBox1.Controls.Add(txtSoNgayMuon);
            groupBox1.Controls.Add(txtTienPhat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(22, 65);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1070, 202);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu trả muộn";
            // 
            // dateNgayTra
            // 
            dateNgayTra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateNgayTra.Location = new Point(505, 99);
            dateNgayTra.Margin = new Padding(2);
            dateNgayTra.Name = "dateNgayTra";
            dateNgayTra.Size = new Size(160, 27);
            dateNgayTra.TabIndex = 16;
            dateNgayTra.ValueChanged += dateNgayTra_ValueChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(398, 101);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 15;
            label11.Text = "Ngày trả:";
            // 
            // btnChonSach
            // 
            btnChonSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChonSach.Location = new Point(473, 154);
            btnChonSach.Margin = new Padding(2);
            btnChonSach.Name = "btnChonSach";
            btnChonSach.Size = new Size(141, 26);
            btnChonSach.TabIndex = 14;
            btnChonSach.Text = "Xem chi tiết";
            btnChonSach.UseVisualStyleBackColor = true;
            btnChonSach.Click += btnChonSach_Click;
            // 
            // txtSoSachMuon
            // 
            txtSoSachMuon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSoSachMuon.Enabled = false;
            txtSoSachMuon.Location = new Point(849, 101);
            txtSoSachMuon.Margin = new Padding(2);
            txtSoSachMuon.Name = "txtSoSachMuon";
            txtSoSachMuon.Size = new Size(194, 27);
            txtSoSachMuon.TabIndex = 13;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(707, 103);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 12;
            label9.Text = "Số sách đã mượn:";
            // 
            // cbSachDaMuon
            // 
            cbSachDaMuon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbSachDaMuon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSachDaMuon.FormattingEnabled = true;
            cbSachDaMuon.Location = new Point(177, 154);
            cbSachDaMuon.Margin = new Padding(2);
            cbSachDaMuon.Name = "cbSachDaMuon";
            cbSachDaMuon.Size = new Size(257, 28);
            cbSachDaMuon.TabIndex = 11;
            cbSachDaMuon.SelectedIndexChanged += cbSachDaMuon_SelectedIndexChanged;
            // 
            // cbMaPM
            // 
            cbMaPM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaPM.FormattingEnabled = true;
            cbMaPM.Location = new Point(177, 44);
            cbMaPM.Margin = new Padding(2);
            cbMaPM.Name = "cbMaPM";
            cbMaPM.Size = new Size(194, 28);
            cbMaPM.TabIndex = 10;
            cbMaPM.SelectedIndexChanged += cbMaPM_SelectedIndexChanged;
            cbMaPM.TextChanged += cbMaPM_TextChanged;
            // 
            // cbTenDG
            // 
            cbTenDG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTenDG.Enabled = false;
            cbTenDG.FormattingEnabled = true;
            cbTenDG.Location = new Point(177, 99);
            cbTenDG.Margin = new Padding(2);
            cbTenDG.Name = "cbTenDG";
            cbTenDG.Size = new Size(194, 28);
            cbTenDG.TabIndex = 9;
            // 
            // cbTenTT
            // 
            cbTenTT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbTenTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenTT.FormattingEnabled = true;
            cbTenTT.Location = new Point(505, 46);
            cbTenTT.Margin = new Padding(2);
            cbTenTT.Name = "cbTenTT";
            cbTenTT.Size = new Size(160, 28);
            cbTenTT.TabIndex = 2;
            cbTenTT.SelectedIndexChanged += cbTenTT_SelectedIndexChanged;
            cbTenTT.TextChanged += cbTenTT_TextChanged;
            // 
            // txtSoNgayMuon
            // 
            txtSoNgayMuon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSoNgayMuon.Enabled = false;
            txtSoNgayMuon.Location = new Point(849, 42);
            txtSoNgayMuon.Margin = new Padding(2);
            txtSoNgayMuon.Name = "txtSoNgayMuon";
            txtSoNgayMuon.Size = new Size(194, 27);
            txtSoNgayMuon.TabIndex = 8;
            // 
            // txtTienPhat
            // 
            txtTienPhat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTienPhat.Enabled = false;
            txtTienPhat.Location = new Point(849, 155);
            txtTienPhat.Margin = new Padding(2);
            txtTienPhat.Name = "txtTienPhat";
            txtTienPhat.Size = new Size(194, 27);
            txtTienPhat.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(707, 158);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 6;
            label8.Text = "Tiền phạt:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(707, 44);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 5;
            label7.Text = "Số ngày trả muộn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 160);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 4;
            label6.Text = "Sách đã mượn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 101);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 3;
            label5.Text = "Tên độc giả:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(398, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Tên thủ thư:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 46);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã phiếu mượn:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // txtFind
            // 
            txtFind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFind.Location = new Point(125, 289);
            txtFind.Margin = new Padding(2);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(202, 27);
            txtFind.TabIndex = 15;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 291);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 15;
            label10.Text = "Tìm kiếm:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(581, 284);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 34);
            btnThem.TabIndex = 15;
            btnThem.Text = "Lập phiếu";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(838, 284);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 34);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataLatePaid);
            groupBox2.Location = new Point(22, 341);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(914, 228);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách (0)";
            // 
            // dataLatePaid
            // 
            dataLatePaid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataLatePaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataLatePaid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataLatePaid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataLatePaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataLatePaid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLatePaid.Columns.AddRange(new DataGridViewColumn[] { ColumnTenThuThu, ColumnTenDG, ColumnSDT, ColumnHanTra, ColumnNgayTra, ColumnSoSachDaMuon, ColumnSoNgayTraMuon, ColumnTienPhat, ColumnID_PTM, ColumnID_TT, ColumnID_PM });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataLatePaid.DefaultCellStyle = dataGridViewCellStyle3;
            dataLatePaid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataLatePaid.Location = new Point(5, 21);
            dataLatePaid.Margin = new Padding(2);
            dataLatePaid.MultiSelect = false;
            dataLatePaid.Name = "dataLatePaid";
            dataLatePaid.RowHeadersWidth = 51;
            dataLatePaid.Size = new Size(905, 202);
            dataLatePaid.TabIndex = 0;
            dataLatePaid.CellClick += dataLatePaid_CellClick;
            dataLatePaid.CellContentClick += dataLatePaid_CellContentClick;
            dataLatePaid.CellFormatting += dataLatePaid_CellFormatting;
            dataLatePaid.RowsAdded += dataLatePaid_RowsAdded;
            // 
            // ColumnTenThuThu
            // 
            ColumnTenThuThu.DataPropertyName = "TenThuThu";
            ColumnTenThuThu.HeaderText = "Tên thủ thư";
            ColumnTenThuThu.MinimumWidth = 6;
            ColumnTenThuThu.Name = "ColumnTenThuThu";
            // 
            // ColumnTenDG
            // 
            ColumnTenDG.DataPropertyName = "TenDG";
            ColumnTenDG.HeaderText = "Tên độc giả";
            ColumnTenDG.MinimumWidth = 6;
            ColumnTenDG.Name = "ColumnTenDG";
            // 
            // ColumnSDT
            // 
            ColumnSDT.DataPropertyName = "SDT";
            ColumnSDT.HeaderText = "Số điện thoại";
            ColumnSDT.MinimumWidth = 6;
            ColumnSDT.Name = "ColumnSDT";
            // 
            // ColumnHanTra
            // 
            ColumnHanTra.DataPropertyName = "HanTra";
            ColumnHanTra.HeaderText = "Hạn trả";
            ColumnHanTra.MinimumWidth = 6;
            ColumnHanTra.Name = "ColumnHanTra";
            // 
            // ColumnNgayTra
            // 
            ColumnNgayTra.DataPropertyName = "NgayTra";
            ColumnNgayTra.HeaderText = "Ngày trả";
            ColumnNgayTra.MinimumWidth = 6;
            ColumnNgayTra.Name = "ColumnNgayTra";
            // 
            // ColumnSoSachDaMuon
            // 
            ColumnSoSachDaMuon.DataPropertyName = "SoSachDaMuon";
            ColumnSoSachDaMuon.HeaderText = "Số sách đã mượn";
            ColumnSoSachDaMuon.MinimumWidth = 6;
            ColumnSoSachDaMuon.Name = "ColumnSoSachDaMuon";
            // 
            // ColumnSoNgayTraMuon
            // 
            ColumnSoNgayTraMuon.DataPropertyName = "SoNgayTraMuon";
            ColumnSoNgayTraMuon.HeaderText = "Số ngày trả muộn";
            ColumnSoNgayTraMuon.MinimumWidth = 6;
            ColumnSoNgayTraMuon.Name = "ColumnSoNgayTraMuon";
            // 
            // ColumnTienPhat
            // 
            ColumnTienPhat.DataPropertyName = "TienPhat";
            ColumnTienPhat.HeaderText = "Tiền phạt";
            ColumnTienPhat.MinimumWidth = 6;
            ColumnTienPhat.Name = "ColumnTienPhat";
            // 
            // ColumnID_PTM
            // 
            ColumnID_PTM.DataPropertyName = "ID_PTM";
            ColumnID_PTM.HeaderText = "Mã phiếu trả muộn";
            ColumnID_PTM.MinimumWidth = 6;
            ColumnID_PTM.Name = "ColumnID_PTM";
            ColumnID_PTM.Visible = false;
            // 
            // ColumnID_TT
            // 
            ColumnID_TT.DataPropertyName = "ID_TT";
            ColumnID_TT.HeaderText = "Mã thủ thư";
            ColumnID_TT.MinimumWidth = 6;
            ColumnID_TT.Name = "ColumnID_TT";
            ColumnID_TT.Visible = false;
            // 
            // ColumnID_PM
            // 
            ColumnID_PM.DataPropertyName = "ID_PM";
            ColumnID_PM.HeaderText = "Mã phiếu mượn";
            ColumnID_PM.MinimumWidth = 6;
            ColumnID_PM.Name = "ColumnID_PM";
            ColumnID_PM.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(974, 348);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 34);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.Location = new Point(974, 416);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 34);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // cbTim
            // 
            cbTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTim.FormattingEnabled = true;
            cbTim.Items.AddRange(new object[] { "Tên thủ thư", "Tên độc giả", "Số điện thoại" });
            cbTim.Location = new Point(352, 289);
            cbTim.Margin = new Padding(2);
            cbTim.Name = "cbTim";
            cbTim.Size = new Size(182, 28);
            cbTim.TabIndex = 23;
            cbTim.SelectedIndexChanged += cbTim_SelectedIndexChanged;
            cbTim.TextChanged += cbTim_TextChanged;
            cbTim.Validating += cbTim_Validating;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(705, 284);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 34);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // QLTRAMUON
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 578);
            Controls.Add(btnSua);
            Controls.Add(cbTim);
            Controls.Add(btnThoat);
            Controls.Add(btnRefresh);
            Controls.Add(groupBox2);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label10);
            Controls.Add(txtFind);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "QLTRAMUON";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí phiếu trả muộn";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataLatePaid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private ComboBox cbMaPM;
        private ComboBox cbTenTT;
        private TextBox txtSoNgayMuon;
        private TextBox txtTienPhat;
        private TextBox txtSoSachMuon;
        private Label label9;
        private ComboBox cbSachDaMuon;
        private Button btnChonSach;
        private TextBox txtFind;
        private Label label10;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox2;
        private Button btnRefresh;
        private Button btnThoat;
        private DateTimePicker dateNgayTra;
        private Label label11;
        private ComboBox cbTim;
        private DataGridView dataLatePaid;
        private Button btnSua;
        private ComboBox cbTenDG;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn ColumnTenThuThu;
        private DataGridViewTextBoxColumn ColumnTenDG;
        private DataGridViewTextBoxColumn ColumnSDT;
        private DataGridViewTextBoxColumn ColumnHanTra;
        private DataGridViewTextBoxColumn ColumnNgayTra;
        private DataGridViewTextBoxColumn ColumnSoSachDaMuon;
        private DataGridViewTextBoxColumn ColumnSoNgayTraMuon;
        private DataGridViewTextBoxColumn ColumnTienPhat;
        private DataGridViewTextBoxColumn ColumnID_PTM;
        private DataGridViewTextBoxColumn ColumnID_TT;
        private DataGridViewTextBoxColumn ColumnID_PM;
    }
}
