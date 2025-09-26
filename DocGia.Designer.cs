namespace QuanLyTacGia
{
    partial class DocGia
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocGia));
            data2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel1 = new Panel();
            btnEnabled = new Button();
            tbCCCD = new TextBox();
            tbSDT = new TextBox();
            tbMa = new TextBox();
            tbTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTim = new TextBox();
            cbFilter = new ComboBox();
            label6 = new Label();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            ((System.ComponentModel.ISupportInitialize)data2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // data2
            // 
            data2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            data2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            data2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            data2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            data2.DefaultCellStyle = dataGridViewCellStyle3;
            data2.EditMode = DataGridViewEditMode.EditProgrammatically;
            data2.EnableHeadersVisualStyles = false;
            data2.Location = new Point(13, 440);
            data2.Margin = new Padding(3, 4, 3, 4);
            data2.MultiSelect = false;
            data2.Name = "data2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            data2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            data2.RowHeadersWidth = 51;
            data2.RowTemplate.Height = 24;
            data2.ScrollBars = ScrollBars.Vertical;
            data2.Size = new Size(776, 344);
            data2.TabIndex = 11;
            data2.CellClick += data2_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID_DG";
            Column1.HeaderText = "Mã độc giả";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenDG";
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SDT";
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "CCCD";
            Column4.HeaderText = "Căn cước công dân";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(19, 32);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên độc giả";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnEnabled);
            panel1.Controls.Add(tbCCCD);
            panel1.Controls.Add(tbSDT);
            panel1.Controls.Add(tbMa);
            panel1.Controls.Add(tbTen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(13, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 196);
            panel1.TabIndex = 9;
            // 
            // btnEnabled
            // 
            btnEnabled.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnabled.BackColor = Color.Transparent;
            btnEnabled.FlatStyle = FlatStyle.Flat;
            btnEnabled.ForeColor = Color.PaleTurquoise;
            btnEnabled.Location = new Point(742, 28);
            btnEnabled.Name = "btnEnabled";
            btnEnabled.Size = new Size(37, 33);
            btnEnabled.TabIndex = 15;
            btnEnabled.UseVisualStyleBackColor = false;
            btnEnabled.Click += btnEnabled_Click;
            // 
            // tbCCCD
            // 
            tbCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCCCD.BackColor = Color.Aquamarine;
            tbCCCD.BorderStyle = BorderStyle.FixedSingle;
            tbCCCD.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCCCD.ForeColor = Color.Black;
            tbCCCD.Location = new Point(536, 118);
            tbCCCD.Margin = new Padding(3, 4, 3, 4);
            tbCCCD.Multiline = true;
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(219, 33);
            tbCCCD.TabIndex = 14;
            tbCCCD.TextAlign = HorizontalAlignment.Center;
            tbCCCD.TextChanged += tbCCCD_TextChanged;
            // 
            // tbSDT
            // 
            tbSDT.BackColor = Color.Aquamarine;
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSDT.ForeColor = Color.Black;
            tbSDT.Location = new Point(137, 118);
            tbSDT.Margin = new Padding(3, 4, 3, 4);
            tbSDT.Multiline = true;
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(162, 33);
            tbSDT.TabIndex = 13;
            tbSDT.TextAlign = HorizontalAlignment.Center;
            tbSDT.TextChanged += tbSDT_TextChanged;
            // 
            // tbMa
            // 
            tbMa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbMa.BackColor = Color.Aquamarine;
            tbMa.BorderStyle = BorderStyle.FixedSingle;
            tbMa.Enabled = false;
            tbMa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMa.ForeColor = Color.Black;
            tbMa.Location = new Point(616, 28);
            tbMa.Margin = new Padding(3, 4, 3, 4);
            tbMa.Multiline = true;
            tbMa.Name = "tbMa";
            tbMa.Size = new Size(123, 33);
            tbMa.TabIndex = 12;
            tbMa.TextAlign = HorizontalAlignment.Center;
            tbMa.TextChanged += tbMa_TextChanged;
            // 
            // tbTen
            // 
            tbTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTen.BackColor = Color.Aquamarine;
            tbTen.BorderStyle = BorderStyle.FixedSingle;
            tbTen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTen.ForeColor = Color.Black;
            tbTen.Location = new Point(137, 28);
            tbTen.Margin = new Padding(3, 4, 3, 4);
            tbTen.Multiline = true;
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(306, 33);
            tbTen.TabIndex = 11;
            tbTen.TextAlign = HorizontalAlignment.Center;
            tbTen.TextChanged += tbTen_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(338, 126);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 10;
            label5.Text = "Căn cước công dân";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(19, 126);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(490, 32);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã độc giả";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(267, 11);
            label1.Name = "label1";
            label1.Size = new Size(276, 40);
            label1.TabIndex = 8;
            label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbTim
            // 
            tbTim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTim.BackColor = Color.Aquamarine;
            tbTim.BorderStyle = BorderStyle.FixedSingle;
            tbTim.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTim.ForeColor = Color.Black;
            tbTim.Location = new Point(331, 381);
            tbTim.Margin = new Padding(3, 4, 3, 4);
            tbTim.Multiline = true;
            tbTim.Name = "tbTim";
            tbTim.Size = new Size(458, 33);
            tbTim.TabIndex = 16;
            tbTim.TextAlign = HorizontalAlignment.Center;
            tbTim.TextChanged += tbTim_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Gainsboro;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Mã", "Họ tên", "CCCD" });
            cbFilter.Location = new Point(179, 381);
            cbFilter.Margin = new Padding(3, 4, 3, 4);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 33);
            cbFilter.TabIndex = 18;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(13, 384);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 17;
            label6.Text = "Tìm kiếm theo: ";
            // 
            // btXoa
            // 
            btXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btXoa.BackColor = Color.LightCoral;
            btXoa.FlatStyle = FlatStyle.Popup;
            btXoa.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Image = (Image)resources.GetObject("btXoa.Image");
            btXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btXoa.Location = new Point(670, 278);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(119, 70);
            btXoa.TabIndex = 14;
            btXoa.Text = "XÓA";
            btXoa.TextAlign = ContentAlignment.MiddleRight;
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Anchor = AnchorStyles.Top;
            btSua.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btSua.BackColor = Color.DeepSkyBlue;
            btSua.FlatStyle = FlatStyle.Popup;
            btSua.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.ForeColor = Color.Black;
            btSua.Image = (Image)resources.GetObject("btSua.Image");
            btSua.ImageAlign = ContentAlignment.MiddleLeft;
            btSua.Location = new Point(359, 278);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(119, 70);
            btSua.TabIndex = 13;
            btSua.Text = "SỬA";
            btSua.TextAlign = ContentAlignment.MiddleRight;
            btSua.UseVisualStyleBackColor = false;
            btSua.Click += btSua_Click;
            // 
            // btThem
            // 
            btThem.BackColor = Color.PaleGreen;
            btThem.FlatStyle = FlatStyle.Popup;
            btThem.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.ForeColor = Color.Black;
            btThem.Image = (Image)resources.GetObject("btThem.Image");
            btThem.ImageAlign = ContentAlignment.MiddleLeft;
            btThem.Location = new Point(13, 278);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(118, 70);
            btThem.TabIndex = 12;
            btThem.Text = "THÊM";
            btThem.TextAlign = ContentAlignment.MiddleRight;
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // DocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(807, 819);
            Controls.Add(cbFilter);
            Controls.Add(label6);
            Controls.Add(tbTim);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(data2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DocGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ ĐỘC GIẢ";
            Load += DocGia_Load;
            ((System.ComponentModel.ISupportInitialize)data2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTim;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbCCCD;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label6;
        private Button btnEnabled;
    }
}