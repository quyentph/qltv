namespace QuanLyThuVien
{
    partial class QuanLyThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuVien));
            btnQLLS = new Button();
            btnQLS = new Button();
            panel1 = new Panel();
            btnQLTG = new Button();
            btnQLPTM = new Button();
            btnQLDG = new Button();
            btnQLPM = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnQLTT = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnQLLS
            // 
            btnQLLS.BackColor = Color.Transparent;
            btnQLLS.FlatStyle = FlatStyle.Flat;
            btnQLLS.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLLS.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLLS.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLS.Location = new Point(0, 257);
            btnQLLS.Name = "btnQLLS";
            btnQLLS.Size = new Size(363, 119);
            btnQLLS.TabIndex = 5;
            btnQLLS.Text = "QUẢN LÝ LOẠI SÁCH";
            btnQLLS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLLS.UseVisualStyleBackColor = false;
            btnQLLS.Click += button5_Click;
            btnQLLS.MouseEnter += btnQLLS_MouseEnter;
            btnQLLS.MouseLeave += btnQLLS_MouseLeave;
            // 
            // btnQLS
            // 
            btnQLS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQLS.BackColor = Color.Transparent;
            btnQLS.FlatStyle = FlatStyle.Flat;
            btnQLS.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLS.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLS.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLS.Location = new Point(0, 314);
            btnQLS.Name = "btnQLS";
            btnQLS.Size = new Size(363, 172);
            btnQLS.TabIndex = 5;
            btnQLS.Text = "QUẢN LÝ SÁCH";
            btnQLS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLS.UseVisualStyleBackColor = false;
            btnQLS.Click += btnQLS_Click;
            btnQLS.MouseEnter += btnQLS_MouseEnter;
            btnQLS.MouseLeave += btnQLS_MouseLeave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnQLS);
            panel1.Controls.Add(btnQLLS);
            panel1.Controls.Add(btnQLTG);
            panel1.Controls.Add(btnQLPTM);
            panel1.Controls.Add(btnQLDG);
            panel1.Controls.Add(btnQLPM);
            panel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 882);
            panel1.TabIndex = 4;
            // 
            // btnQLTG
            // 
            btnQLTG.BackColor = Color.Transparent;
            btnQLTG.Dock = DockStyle.Top;
            btnQLTG.FlatStyle = FlatStyle.Flat;
            btnQLTG.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLTG.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLTG.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLTG.Location = new Point(0, 0);
            btnQLTG.Name = "btnQLTG";
            btnQLTG.Size = new Size(363, 117);
            btnQLTG.TabIndex = 0;
            btnQLTG.Text = "QUẢN LÝ TÁC GIẢ";
            btnQLTG.UseVisualStyleBackColor = false;
            btnQLTG.Click += btnQLTG_Click;
            btnQLTG.MouseEnter += btnQLTG_MouseEnter;
            btnQLTG.MouseLeave += btnQLTG_MouseLeave;
            // 
            // btnQLPTM
            // 
            btnQLPTM.BackColor = Color.Transparent;
            btnQLPTM.Dock = DockStyle.Bottom;
            btnQLPTM.FlatStyle = FlatStyle.Flat;
            btnQLPTM.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLPTM.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLPTM.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLPTM.Location = new Point(0, 667);
            btnQLPTM.Name = "btnQLPTM";
            btnQLPTM.Size = new Size(363, 215);
            btnQLPTM.TabIndex = 3;
            btnQLPTM.Text = "QUẢN LÝ PHIẾU TRẢ MUỘN";
            btnQLPTM.UseVisualStyleBackColor = false;
            btnQLPTM.Click += btnQLPTM_Click;
            btnQLPTM.MouseEnter += btnQLPTM_MouseEnter;
            btnQLPTM.MouseLeave += btnQLPTM_MouseLeave;
            // 
            // btnQLDG
            // 
            btnQLDG.BackColor = Color.Transparent;
            btnQLDG.FlatStyle = FlatStyle.Flat;
            btnQLDG.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLDG.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLDG.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDG.Location = new Point(0, 132);
            btnQLDG.Name = "btnQLDG";
            btnQLDG.Size = new Size(363, 119);
            btnQLDG.TabIndex = 1;
            btnQLDG.Text = "QUẢN LÝ ĐỘC GIẢ";
            btnQLDG.UseVisualStyleBackColor = false;
            btnQLDG.Click += button2_Click;
            btnQLDG.MouseEnter += btnQLDG_MouseEnter;
            btnQLDG.MouseLeave += btnQLDG_MouseLeave;
            // 
            // btnQLPM
            // 
            btnQLPM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQLPM.BackColor = Color.Transparent;
            btnQLPM.FlatStyle = FlatStyle.Flat;
            btnQLPM.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnQLPM.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLPM.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLPM.Location = new Point(-3, 492);
            btnQLPM.Name = "btnQLPM";
            btnQLPM.Size = new Size(366, 169);
            btnQLPM.TabIndex = 2;
            btnQLPM.Text = "QUẢN LÝ PHIẾU MƯỢN";
            btnQLPM.UseVisualStyleBackColor = false;
            btnQLPM.Click += btnQLPM_Click;
            btnQLPM.MouseEnter += btnQLPM_MouseEnter;
            btnQLPM.MouseLeave += btnQLPM_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(613, 442);
            label1.Name = "label1";
            label1.Size = new Size(804, 90);
            label1.TabIndex = 5;
            label1.Text = "QUẢN  LÝ  THƯ  VIỆN";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnQLTT);
            panel2.Location = new Point(623, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 63);
            panel2.TabIndex = 6;
            // 
            // btnQLTT
            // 
            btnQLTT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQLTT.FlatStyle = FlatStyle.Flat;
            btnQLTT.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLTT.ForeColor = Color.FromArgb(255, 192, 128);
            btnQLTT.Image = (Image)resources.GetObject("btnQLTT.Image");
            btnQLTT.Location = new Point(8, 0);
            btnQLTT.Name = "btnQLTT";
            btnQLTT.Size = new Size(436, 56);
            btnQLTT.TabIndex = 0;
            btnQLTT.Text = "QUẢN LÝ                    THỦ THƯ";
            btnQLTT.UseVisualStyleBackColor = true;
            btnQLTT.Click += btnQLTT_Click;
            btnQLTT.MouseEnter += button7_MouseEnter;
            btnQLTT.MouseLeave += btQLTK_MouseLeave;
            // 
            // QuanLyThuVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1626, 920);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyThuVien";
            Text = "Quản Lý Thư Viện";
            WindowState = FormWindowState.Maximized;
            FormClosing += QuanLyThuVien_FormClosing;
            Load += QuanLyThuVien_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQLLS;
        private Button btnQLS;
        private Panel panel1;
        private Button btnQLTG;
        private Button btnQLPTM;
        private Button btnQLDG;
        private Button btnQLPM;
        private Label label1;
        private Panel panel2;
        private Button btnQLTT;
    }
}

