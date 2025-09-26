namespace testgiaodien
{
    partial class Sach
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
            panel1 = new Panel();
            txtloaisach = new TextBox();
            txttentacgia = new TextBox();
            comboBox1 = new ComboBox();
            txtmaloaisach = new TextBox();
            label8 = new Label();
            txtmatacgia = new TextBox();
            label7 = new Label();
            btchonloaisach = new Button();
            btchontacgia = new Button();
            btxoa = new Button();
            btsua = new Button();
            num = new NumericUpDown();
            txtmasach = new TextBox();
            txttensach = new TextBox();
            txttim = new TextBox();
            btthem = new Button();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            datasach = new DataGridView();
            Masach = new DataGridViewTextBoxColumn();
            Tensach = new DataGridViewTextBoxColumn();
            Matacgia = new DataGridViewTextBoxColumn();
            Tentacgia = new DataGridViewTextBoxColumn();
            Maloaisach = new DataGridViewTextBoxColumn();
            Loaisach = new DataGridViewTextBoxColumn();
            Soluongsach = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datasach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SÁCH";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtloaisach);
            panel1.Controls.Add(txttentacgia);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtmaloaisach);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtmatacgia);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btchonloaisach);
            panel1.Controls.Add(btchontacgia);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(num);
            panel1.Controls.Add(txtmasach);
            panel1.Controls.Add(txttensach);
            panel1.Controls.Add(txttim);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(23, 46);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 328);
            panel1.TabIndex = 1;
            // 
            // txtloaisach
            // 
            txtloaisach.Location = new Point(161, 278);
            txtloaisach.Margin = new Padding(5);
            txtloaisach.Name = "txtloaisach";
            txtloaisach.ReadOnly = true;
            txtloaisach.Size = new Size(421, 34);
            txtloaisach.TabIndex = 32;
            // 
            // txttentacgia
            // 
            txttentacgia.Location = new Point(161, 180);
            txttentacgia.Margin = new Padding(5);
            txttentacgia.Name = "txttentacgia";
            txttentacgia.ReadOnly = true;
            txttentacgia.Size = new Size(421, 34);
            txttentacgia.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(785, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 33);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtmaloaisach
            // 
            txtmaloaisach.Location = new Point(185, 229);
            txtmaloaisach.Margin = new Padding(5);
            txtmaloaisach.Name = "txtmaloaisach";
            txtmaloaisach.ReadOnly = true;
            txtmaloaisach.Size = new Size(397, 34);
            txtmaloaisach.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 287);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 28;
            label8.Text = "Loại sách: ";
            // 
            // txtmatacgia
            // 
            txtmatacgia.Location = new Point(161, 119);
            txtmatacgia.Margin = new Padding(5);
            txtmatacgia.Name = "txtmatacgia";
            txtmatacgia.ReadOnly = true;
            txtmatacgia.Size = new Size(421, 34);
            txtmatacgia.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 183);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 26;
            label7.Text = "Tên tác giả : ";
            // 
            // btchonloaisach
            // 
            btchonloaisach.Location = new Point(596, 278);
            btchonloaisach.Margin = new Padding(5);
            btchonloaisach.Name = "btchonloaisach";
            btchonloaisach.Size = new Size(116, 34);
            btchonloaisach.TabIndex = 25;
            btchonloaisach.Text = "Chọn...";
            btchonloaisach.UseVisualStyleBackColor = true;
            btchonloaisach.Click += btchonloaisach_Click;
            // 
            // btchontacgia
            // 
            btchontacgia.Location = new Point(596, 183);
            btchontacgia.Margin = new Padding(5);
            btchontacgia.Name = "btchontacgia";
            btchontacgia.Size = new Size(126, 34);
            btchontacgia.TabIndex = 24;
            btchontacgia.Text = "Chọn...";
            btchontacgia.UseVisualStyleBackColor = true;
            btchontacgia.Click += btchontacgia_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(940, 25);
            btxoa.Margin = new Padding(5);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(128, 60);
            btxoa.TabIndex = 22;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(773, 25);
            btsua.Margin = new Padding(5);
            btsua.Name = "btsua";
            btsua.Size = new Size(131, 60);
            btsua.TabIndex = 21;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // num
            // 
            num.Location = new Point(797, 110);
            num.Margin = new Padding(5);
            num.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            num.Name = "num";
            num.ReadOnly = true;
            num.Size = new Size(95, 34);
            num.TabIndex = 20;
            num.TextAlign = HorizontalAlignment.Center;
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(161, 16);
            txtmasach.Margin = new Padding(5);
            txtmasach.Name = "txtmasach";
            txtmasach.ReadOnly = true;
            txtmasach.Size = new Size(421, 34);
            txtmasach.TabIndex = 18;
            // 
            // txttensach
            // 
            txttensach.Location = new Point(161, 66);
            txttensach.Margin = new Padding(5);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(421, 34);
            txttensach.TabIndex = 16;
            // 
            // txttim
            // 
            txttim.Location = new Point(690, 234);
            txttim.Margin = new Padding(5);
            txttim.Name = "txttim";
            txttim.Size = new Size(368, 34);
            txttim.TabIndex = 14;
            txttim.TextChanged += txttim_TextChanged;
            // 
            // btthem
            // 
            btthem.Location = new Point(606, 25);
            btthem.Margin = new Padding(5);
            btthem.Name = "btthem";
            btthem.Size = new Size(132, 60);
            btthem.TabIndex = 10;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 25);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 5;
            label3.Text = "Mã sách :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(618, 112);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 4;
            label6.Text = "Số lượng : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 237);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 3;
            label5.Text = "Mã loại sách: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 128);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã tác giả : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 75);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 0;
            label2.Text = "Tên sách : ";
            // 
            // datasach
            // 
            datasach.AllowUserToAddRows = false;
            datasach.AllowUserToDeleteRows = false;
            datasach.AllowUserToResizeColumns = false;
            datasach.AllowUserToResizeRows = false;
            datasach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasach.Columns.AddRange(new DataGridViewColumn[] { Masach, Tensach, Matacgia, Tentacgia, Maloaisach, Loaisach, Soluongsach });
            datasach.Location = new Point(23, 384);
            datasach.Margin = new Padding(5);
            datasach.MultiSelect = false;
            datasach.Name = "datasach";
            datasach.ReadOnly = true;
            datasach.RowHeadersWidth = 51;
            datasach.RowTemplate.Height = 24;
            datasach.Size = new Size(1079, 305);
            datasach.TabIndex = 12;
            datasach.CellClick += datasach_CellClick;
            // 
            // Masach
            // 
            Masach.DataPropertyName = "Mã sách";
            Masach.HeaderText = "Mã sách";
            Masach.MinimumWidth = 6;
            Masach.Name = "Masach";
            Masach.ReadOnly = true;
            Masach.Visible = false;
            // 
            // Tensach
            // 
            Tensach.DataPropertyName = "Tên sách";
            Tensach.HeaderText = "Tên sách";
            Tensach.MinimumWidth = 6;
            Tensach.Name = "Tensach";
            Tensach.ReadOnly = true;
            // 
            // Matacgia
            // 
            Matacgia.DataPropertyName = "Mã tác giả";
            Matacgia.HeaderText = "Mã tác giả";
            Matacgia.MinimumWidth = 6;
            Matacgia.Name = "Matacgia";
            Matacgia.ReadOnly = true;
            Matacgia.Visible = false;
            // 
            // Tentacgia
            // 
            Tentacgia.DataPropertyName = "Tên tác giả";
            Tentacgia.HeaderText = "Tên tác giả";
            Tentacgia.MinimumWidth = 12;
            Tentacgia.Name = "Tentacgia";
            Tentacgia.ReadOnly = true;
            // 
            // Maloaisach
            // 
            Maloaisach.DataPropertyName = "Mã loại sách";
            Maloaisach.HeaderText = "Mã loại sách";
            Maloaisach.MinimumWidth = 12;
            Maloaisach.Name = "Maloaisach";
            Maloaisach.ReadOnly = true;
            Maloaisach.Visible = false;
            // 
            // Loaisach
            // 
            Loaisach.DataPropertyName = "Loại sách";
            Loaisach.HeaderText = "Loại sách";
            Loaisach.MinimumWidth = 6;
            Loaisach.Name = "Loaisach";
            Loaisach.ReadOnly = true;
            // 
            // Soluongsach
            // 
            Soluongsach.DataPropertyName = "Số lượng sách";
            Soluongsach.HeaderText = "Số lượng sách";
            Soluongsach.MinimumWidth = 6;
            Soluongsach.Name = "Soluongsach";
            Soluongsach.ReadOnly = true;
            // 
            // Sach
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 699);
            Controls.Add(datasach);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLySach";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            ((System.ComponentModel.ISupportInitialize)datasach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DataGridView datasach;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Button btchonloaisach;
        private System.Windows.Forms.Button btchontacgia;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txtmaloaisach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongsach;
        private System.Windows.Forms.TextBox txtloaisach;
        private System.Windows.Forms.TextBox txttentacgia;
    }
}

