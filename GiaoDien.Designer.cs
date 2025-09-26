namespace Giao_dien_dang_nhap
{
    partial class GiaoDien
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
            btndoimk = new Button();
            label1 = new Label();
            txtten = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            btnthoat = new Button();
            txtID_TT = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btndoimk
            // 
            btndoimk.Location = new Point(36, 288);
            btndoimk.Margin = new Padding(3, 4, 3, 4);
            btndoimk.Name = "btndoimk";
            btndoimk.Size = new Size(102, 64);
            btndoimk.TabIndex = 0;
            btndoimk.Text = "Đổi mật khẩu ";
            btndoimk.UseVisualStyleBackColor = true;
            btndoimk.Click += btndoimk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 115);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ tên thủ thư:";
            // 
            // txtten
            // 
            txtten.Location = new Point(164, 115);
            txtten.Margin = new Padding(3, 4, 3, 4);
            txtten.Name = "txtten";
            txtten.Size = new Size(204, 27);
            txtten.TabIndex = 2;
            txtten.TextChanged += txtten_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(299, 25);
            label3.Name = "label3";
            label3.Size = new Size(155, 38);
            label3.TabIndex = 5;
            label3.Text = "Thủ Thư ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3 });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(36, 372);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(725, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID_TT";
            Column1.HeaderText = "ID_TT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TenThuThu";
            Column3.HeaderText = "Họ tên thủ thư";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(519, 288);
            btnxoa.Margin = new Padding(3, 4, 3, 4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(102, 64);
            btnxoa.TabIndex = 10;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(349, 288);
            btnsua.Margin = new Padding(3, 4, 3, 4);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(102, 64);
            btnsua.TabIndex = 11;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(185, 288);
            btnthem.Margin = new Padding(3, 4, 3, 4);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(102, 64);
            btnthem.TabIndex = 12;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(659, 288);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(102, 64);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txtID_TT
            // 
            txtID_TT.Location = new Point(519, 112);
            txtID_TT.Margin = new Padding(3, 4, 3, 4);
            txtID_TT.Name = "txtID_TT";
            txtID_TT.ReadOnly = true;
            txtID_TT.Size = new Size(204, 27);
            txtID_TT.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 115);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 16;
            label2.Text = "ID_TT:";
            // 
            // GiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 577);
            Controls.Add(txtID_TT);
            Controls.Add(label2);
            Controls.Add(btnthoat);
            Controls.Add(btnthem);
            Controls.Add(btnsua);
            Controls.Add(btnxoa);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtten);
            Controls.Add(label1);
            Controls.Add(btndoimk);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GiaoDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GiaoDien";
            Load += GiaoDien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtID_TT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}