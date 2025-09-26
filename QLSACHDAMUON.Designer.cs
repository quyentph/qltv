namespace PhieuTraMuon
{
    partial class QLSACHDAMUON
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDG = new TextBox();
            txtSDT = new TextBox();
            label4 = new Label();
            txtMaPM = new TextBox();
            groupBox1 = new GroupBox();
            dataBook = new DataGridView();
            ID_Sach = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtTimSach = new TextBox();
            cbTimSach = new ComboBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(426, 41);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết những sách đã mượn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên độc giả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 220);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // txtTenDG
            // 
            txtTenDG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenDG.Enabled = false;
            txtTenDG.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenDG.Location = new Point(221, 151);
            txtTenDG.Margin = new Padding(2);
            txtTenDG.Name = "txtTenDG";
            txtTenDG.Size = new Size(309, 31);
            txtTenDG.TabIndex = 3;
            txtTenDG.TextAlign = HorizontalAlignment.Center;
            txtTenDG.TextChanged += textBox1_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.Enabled = false;
            txtSDT.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.Location = new Point(221, 218);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(309, 31);
            txtSDT.TabIndex = 4;
            txtSDT.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 98);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 5;
            label4.Text = "Mã phiếu mượn:";
            // 
            // txtMaPM
            // 
            txtMaPM.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaPM.Enabled = false;
            txtMaPM.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaPM.Location = new Point(221, 94);
            txtMaPM.Margin = new Padding(2);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.Size = new Size(309, 31);
            txtMaPM.TabIndex = 6;
            txtMaPM.TextAlign = HorizontalAlignment.Center;
            txtMaPM.TextChanged += txtMaPM_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataBook);
            groupBox1.Location = new Point(48, 302);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1089, 292);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách (0)";
            // 
            // dataBook
            // 
            dataBook.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBook.Columns.AddRange(new DataGridViewColumn[] { ID_Sach, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataBook.DefaultCellStyle = dataGridViewCellStyle3;
            dataBook.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataBook.GridColor = Color.Black;
            dataBook.Location = new Point(0, 24);
            dataBook.Margin = new Padding(2);
            dataBook.Name = "dataBook";
            dataBook.RowHeadersWidth = 51;
            dataBook.Size = new Size(1078, 262);
            dataBook.TabIndex = 0;
            // 
            // ID_Sach
            // 
            ID_Sach.DataPropertyName = "ID_Sach";
            ID_Sach.HeaderText = "Mã sách";
            ID_Sach.MinimumWidth = 6;
            ID_Sach.Name = "ID_Sach";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenSach";
            Column2.HeaderText = "Tên sách";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TheLoai";
            Column3.HeaderText = "Thể loại sách";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TacGia";
            Column4.HeaderText = "Tác giả";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // txtTimSach
            // 
            txtTimSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimSach.Location = new Point(570, 265);
            txtTimSach.Margin = new Padding(2);
            txtTimSach.Name = "txtTimSach";
            txtTimSach.Size = new Size(302, 31);
            txtTimSach.TabIndex = 8;
            txtTimSach.TextChanged += txtTimSach_TextChanged;
            // 
            // cbTimSach
            // 
            cbTimSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTimSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimSach.FormattingEnabled = true;
            cbTimSach.Items.AddRange(new object[] { "Mã sách", "Tên sách", "Thể loại sách", "Tác giả" });
            cbTimSach.Location = new Point(916, 265);
            cbTimSach.Margin = new Padding(2);
            cbTimSach.Name = "cbTimSach";
            cbTimSach.Size = new Size(214, 33);
            cbTimSach.TabIndex = 9;
            cbTimSach.SelectedIndexChanged += cbTimSach_SelectedIndexChanged;
            cbTimSach.TextChanged += cbTimSach_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(916, 235);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 10;
            label5.Text = "Tìm kiếm theo:";
            // 
            // QLSACHDAMUON
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 630);
            Controls.Add(label5);
            Controls.Add(cbTimSach);
            Controls.Add(txtTimSach);
            Controls.Add(groupBox1);
            Controls.Add(txtMaPM);
            Controls.Add(label4);
            Controls.Add(txtSDT);
            Controls.Add(txtTenDG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "QLSACHDAMUON";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDG;
        private TextBox txtSDT;
        private Label label4;
        private TextBox txtMaPM;
        private GroupBox groupBox1;
        private DataGridView dataBook;
        private DataGridViewTextBoxColumn ID_Sach;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtTimSach;
        private ComboBox cbTimSach;
        private Label label5;
    }
}