namespace QuanLiThuVien_PhieuMuon
{
    partial class SachTrongPhieuMuon
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            cbTimTheo = new ComboBox();
            txtTim = new TextBox();
            label4 = new Label();
            gridViewTim = new DataGridView();
            gbChon = new GroupBox();
            gridView = new DataGridView();
            btnChon = new Button();
            btnClear = new Button();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewTim).BeginInit();
            gbChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(gridViewTim);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(811, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sách";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cbTimTheo, 3, 0);
            tableLayoutPanel1.Controls.Add(txtTim, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Location = new Point(10, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(795, 35);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbTimTheo
            // 
            cbTimTheo.Dock = DockStyle.Fill;
            cbTimTheo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimTheo.FormattingEnabled = true;
            cbTimTheo.Items.AddRange(new object[] { "Tên sách", "Thể loại", "Tác giả", "Số lượng" });
            cbTimTheo.Location = new Point(570, 3);
            cbTimTheo.Name = "cbTimTheo";
            cbTimTheo.Size = new Size(222, 28);
            cbTimTheo.TabIndex = 4;
            cbTimTheo.SelectedIndexChanged += cbTimTheo_SelectedIndexChanged;
            // 
            // txtTim
            // 
            txtTim.Dock = DockStyle.Fill;
            txtTim.Location = new Point(82, 4);
            txtTim.Margin = new Padding(3, 4, 3, 4);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(405, 27);
            txtTim.TabIndex = 0;
            txtTim.TextChanged += txtTim_TextChanged;
            txtTim.KeyPress += txtTim_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(493, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 35);
            label4.TabIndex = 3;
            label4.Text = "Tìm theo:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gridViewTim
            // 
            gridViewTim.AllowUserToAddRows = false;
            gridViewTim.AllowUserToDeleteRows = false;
            gridViewTim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewTim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewTim.Location = new Point(7, 69);
            gridViewTim.Margin = new Padding(3, 4, 3, 4);
            gridViewTim.Name = "gridViewTim";
            gridViewTim.ReadOnly = true;
            gridViewTim.RowHeadersWidth = 51;
            gridViewTim.RowTemplate.Height = 24;
            gridViewTim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewTim.Size = new Size(798, 237);
            gridViewTim.TabIndex = 2;
            // 
            // gbChon
            // 
            gbChon.Controls.Add(gridView);
            gbChon.Dock = DockStyle.Fill;
            gbChon.Location = new Point(3, 371);
            gbChon.Margin = new Padding(3, 4, 3, 4);
            gbChon.Name = "gbChon";
            gbChon.Padding = new Padding(3, 4, 3, 4);
            gbChon.Size = new Size(811, 317);
            gbChon.TabIndex = 1;
            gbChon.TabStop = false;
            gbChon.Text = "Sách được chọn (0)";
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(3, 24);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 24;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(805, 289);
            gridView.TabIndex = 0;
            gridView.SelectionChanged += gridView_SelectionChanged;
            // 
            // btnChon
            // 
            btnChon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChon.DialogResult = DialogResult.OK;
            btnChon.Location = new Point(761, 796);
            btnChon.Margin = new Padding(3, 4, 3, 4);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(75, 34);
            btnChon.TabIndex = 2;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Location = new Point(100, 796);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Bỏ hết";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 254);
            label2.Location = new Point(340, 26);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 4;
            label2.Text = "Chọn sách";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(326, 59);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 5;
            label3.Text = "Chọn sách cho phiếu mượn";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Left;
            btnThem.Location = new Point(3, 329);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 34);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoa.Location = new Point(19, 796);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Loại bỏ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 0, 1);
            tableLayoutPanel2.Controls.Add(gbChon, 0, 2);
            tableLayoutPanel2.Location = new Point(19, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(817, 692);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // SachTrongPhieuMuon
            // 
            AcceptButton = btnChon;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 841);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnXoa);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnChon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SachTrongPhieuMuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn sách";
            Load += SachTrongPhieuMuon_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewTim).EndInit();
            gbChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridViewTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox gbChon;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private Label label4;
        private ComboBox cbTimTheo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}