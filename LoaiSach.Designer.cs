namespace testgiaodien
{
    partial class LoaiSach
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            txttim = new TextBox();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            txtten = new TextBox();
            txtma = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataloaisach = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataloaisach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txttim);
            panel1.Controls.Add(btxoa);
            panel1.Controls.Add(btsua);
            panel1.Controls.Add(btthem);
            panel1.Controls.Add(txtten);
            panel1.Controls.Add(txtma);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 54);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 186);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mã loại sách", "Loại sách" });
            comboBox1.Location = new Point(543, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txttim
            // 
            txttim.Location = new Point(569, 77);
            txttim.Margin = new Padding(5);
            txttim.Name = "txttim";
            txttim.Size = new Size(182, 34);
            txttim.TabIndex = 12;
            txttim.TextChanged += txttim_TextChanged;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(273, 131);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(88, 40);
            btxoa.TabIndex = 8;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(159, 131);
            btsua.Name = "btsua";
            btsua.Size = new Size(88, 40);
            btsua.TabIndex = 7;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            btsua.Click += btsua_Click;
            // 
            // btthem
            // 
            btthem.Location = new Point(47, 131);
            btthem.Name = "btthem";
            btthem.Size = new Size(88, 40);
            btthem.TabIndex = 6;
            btthem.Text = "Thêm ";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // txtten
            // 
            txtten.Location = new Point(211, 77);
            txtten.Margin = new Padding(5);
            txtten.Name = "txtten";
            txtten.Size = new Size(284, 34);
            txtten.TabIndex = 4;
            txtten.TextChanged += txtten_TextChanged;
            // 
            // txtma
            // 
            txtma.Location = new Point(211, 27);
            txtma.Margin = new Padding(5);
            txtma.Name = "txtma";
            txtma.ReadOnly = true;
            txtma.Size = new Size(284, 34);
            txtma.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 86);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 3;
            label3.Text = "Loại sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 36);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã loại sách:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ LOẠI SÁCH";
            // 
            // dataloaisach
            // 
            dataloaisach.AllowUserToAddRows = false;
            dataloaisach.AllowUserToDeleteRows = false;
            dataloaisach.AllowUserToResizeColumns = false;
            dataloaisach.AllowUserToResizeRows = false;
            dataloaisach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataloaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataloaisach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataloaisach.Location = new Point(20, 250);
            dataloaisach.Margin = new Padding(5);
            dataloaisach.MultiSelect = false;
            dataloaisach.Name = "dataloaisach";
            dataloaisach.ReadOnly = true;
            dataloaisach.RowHeadersWidth = 51;
            dataloaisach.RowTemplate.Height = 24;
            dataloaisach.Size = new Size(788, 263);
            dataloaisach.TabIndex = 2;
            dataloaisach.CellClick += dataloaisach_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID_LS";
            Column1.HeaderText = "Mã loại sách";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLS";
            Column2.HeaderText = "Loại sách";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // LoaiSach
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 550);
            Controls.Add(dataloaisach);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "LoaiSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyLoaiSach";
            Load += Thể_loại_sách_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataloaisach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataloaisach;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}