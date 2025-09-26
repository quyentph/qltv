namespace QuanLyTacGia
{
    partial class TacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TacGia));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            pTG = new Panel();
            btnEnabled = new Button();
            tbMa = new TextBox();
            label6 = new Label();
            tbTG = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pSach = new Panel();
            tbTL = new TextBox();
            label9 = new Label();
            tbS = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btSua = new Button();
            btXoa = new Button();
            data1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            cbFilter = new ComboBox();
            tbTim = new TextBox();
            btThem = new Button();
            pTG.SuspendLayout();
            pSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(526, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 40);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÁC GIẢ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pTG
            // 
            pTG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pTG.Controls.Add(btnEnabled);
            pTG.Controls.Add(tbMa);
            pTG.Controls.Add(label6);
            pTG.Controls.Add(tbTG);
            pTG.Controls.Add(label2);
            pTG.Controls.Add(label3);
            pTG.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pTG.Location = new Point(27, 72);
            pTG.Margin = new Padding(3, 4, 3, 4);
            pTG.Name = "pTG";
            pTG.Size = new Size(519, 267);
            pTG.TabIndex = 1;
            // 
            // btnEnabled
            // 
            btnEnabled.BackColor = Color.Transparent;
            btnEnabled.FlatStyle = FlatStyle.Flat;
            btnEnabled.ForeColor = Color.LightSkyBlue;
            btnEnabled.Location = new Point(382, 171);
            btnEnabled.Name = "btnEnabled";
            btnEnabled.Size = new Size(37, 36);
            btnEnabled.TabIndex = 9;
            btnEnabled.UseVisualStyleBackColor = false;
            btnEnabled.Click += btnEnabled_Click;
            // 
            // tbMa
            // 
            tbMa.BackColor = Color.Turquoise;
            tbMa.BorderStyle = BorderStyle.FixedSingle;
            tbMa.Enabled = false;
            tbMa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMa.Location = new Point(186, 171);
            tbMa.Margin = new Padding(3, 4, 3, 4);
            tbMa.Multiline = true;
            tbMa.Name = "tbMa";
            tbMa.Size = new Size(169, 33);
            tbMa.TabIndex = 8;
            tbMa.TextAlign = HorizontalAlignment.Center;
            tbMa.TextChanged += tbMa_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(18, 175);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 7;
            label6.Text = "Mã tác giả";
            // 
            // tbTG
            // 
            tbTG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTG.BackColor = Color.Turquoise;
            tbTG.BorderStyle = BorderStyle.FixedSingle;
            tbTG.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTG.Location = new Point(186, 89);
            tbTG.Margin = new Padding(3, 4, 3, 4);
            tbTG.Multiline = true;
            tbTG.Name = "tbTG";
            tbTG.Size = new Size(316, 34);
            tbTG.TabIndex = 5;
            tbTG.TextAlign = HorizontalAlignment.Center;
            tbTG.TextChanged += tbTG_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(154, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 2;
            label2.Text = "Thông tin tác giả";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 0;
            label3.Text = "Họ tên tác giả";
            // 
            // pSach
            // 
            pSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pSach.BackColor = Color.LightSkyBlue;
            pSach.Controls.Add(tbTL);
            pSach.Controls.Add(label9);
            pSach.Controls.Add(tbS);
            pSach.Controls.Add(label8);
            pSach.Controls.Add(label7);
            pSach.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pSach.ForeColor = Color.Black;
            pSach.Location = new Point(793, 72);
            pSach.Margin = new Padding(3, 4, 3, 4);
            pSach.Name = "pSach";
            pSach.Size = new Size(496, 358);
            pSach.TabIndex = 2;
            // 
            // tbTL
            // 
            tbTL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTL.BackColor = Color.Turquoise;
            tbTL.BorderStyle = BorderStyle.FixedSingle;
            tbTL.Enabled = false;
            tbTL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTL.Location = new Point(159, 89);
            tbTL.Margin = new Padding(3, 4, 3, 4);
            tbTL.Multiline = true;
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(307, 34);
            tbTL.TabIndex = 10;
            tbTL.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Indigo;
            label9.Location = new Point(176, 0);
            label9.Name = "label9";
            label9.Size = new Size(155, 31);
            label9.TabIndex = 9;
            label9.Text = "Thông tin sách";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbS
            // 
            tbS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbS.BackColor = Color.Turquoise;
            tbS.BorderStyle = BorderStyle.FixedSingle;
            tbS.Enabled = false;
            tbS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbS.Location = new Point(159, 178);
            tbS.Margin = new Padding(3, 4, 3, 4);
            tbS.Multiline = true;
            tbS.Name = "tbS";
            tbS.Size = new Size(307, 163);
            tbS.TabIndex = 8;
            tbS.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Indigo;
            label8.Location = new Point(19, 181);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 3;
            label8.Text = "Tên sách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Indigo;
            label7.Location = new Point(19, 92);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 2;
            label7.Text = "Thể loại";
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.Top;
            btSua.BackColor = Color.DeepSkyBlue;
            btSua.FlatStyle = FlatStyle.Flat;
            btSua.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.Image = (Image)resources.GetObject("btSua.Image");
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.Location = new Point(617, 156);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(114, 76);
            btSua.TabIndex = 5;
            btSua.Text = "SỬA";
            btSua.TextAlign = ContentAlignment.MiddleRight;
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.Top;
            btXoa.BackColor = Color.LightCoral;
            btXoa.FlatStyle = FlatStyle.Flat;
            btXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Image = (Image)resources.GetObject("btXoa.Image");
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.Location = new Point(617, 244);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(114, 76);
            btXoa.TabIndex = 6;
            btXoa.Text = "XÓA";
            btXoa.TextAlign = ContentAlignment.MiddleRight;
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // data1
            // 
            data1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            data1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            data1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data1.BackgroundColor = Color.PowderBlue;
            data1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MediumTurquoise;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            data1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            data1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            data1.DefaultCellStyle = dataGridViewCellStyle3;
            data1.EditMode = DataGridViewEditMode.EditProgrammatically;
            data1.EnableHeadersVisualStyles = false;
            data1.Location = new Point(12, 438);
            data1.Margin = new Padding(3, 4, 3, 4);
            data1.MultiSelect = false;
            data1.Name = "data1";
            data1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            data1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            data1.RowHeadersWidth = 51;
            data1.RowTemplate.Height = 24;
            data1.ScrollBars = ScrollBars.Vertical;
            data1.Size = new Size(1295, 512);
            data1.TabIndex = 3;
            data1.CellClick += data1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "Mã tác giả";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TENTG";
            Column2.FillWeight = 43.71357F;
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TENSACH";
            Column3.FillWeight = 207.9034F;
            Column3.HeaderText = "Sách";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "THELOAI";
            Column4.HeaderText = "Thể loại";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(27, 387);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm theo: ";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Mã", "Họ tên" });
            cbFilter.Location = new Point(194, 380);
            cbFilter.Margin = new Padding(3, 4, 3, 4);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 33);
            cbFilter.TabIndex = 8;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // tbTim
            // 
            tbTim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTim.BackColor = Color.Turquoise;
            tbTim.BorderStyle = BorderStyle.FixedSingle;
            tbTim.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTim.Location = new Point(356, 380);
            tbTim.Margin = new Padding(3, 4, 3, 4);
            tbTim.Multiline = true;
            tbTim.Name = "tbTim";
            tbTim.Size = new Size(375, 33);
            tbTim.TabIndex = 9;
            tbTim.TextAlign = HorizontalAlignment.Center;
            tbTim.TextChanged += tbTim_TextChanged;
            // 
            // btThem
            // 
            btThem.Anchor = AnchorStyles.Top;
            btThem.BackColor = Color.PaleGreen;
            btThem.FlatStyle = FlatStyle.Flat;
            btThem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.Image = (Image)resources.GetObject("btThem.Image");
            btThem.ImageAlign = ContentAlignment.MiddleLeft;
            btThem.Location = new Point(617, 72);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(114, 76);
            btThem.TabIndex = 4;
            btThem.Text = "THÊM";
            btThem.TextAlign = ContentAlignment.MiddleRight;
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // TacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1318, 963);
            Controls.Add(tbTim);
            Controls.Add(cbFilter);
            Controls.Add(label4);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(data1);
            Controls.Add(pSach);
            Controls.Add(pTG);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TÁC GIẢ";
            Load += Form1_Load;
            pTG.ResumeLayout(false);
            pTG.PerformLayout();
            pSach.ResumeLayout(false);
            pSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTG;
        private System.Windows.Forms.Panel pSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.TextBox tbTL;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Button btnEnabled;
    }
}

