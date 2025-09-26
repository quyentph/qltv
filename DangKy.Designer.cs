namespace Giao_dien_dang_nhap
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            txtmktk = new TextBox();
            txttentk = new TextBox();
            txtxacthuc = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btndangky = new Button();
            SuspendLayout();
            // 
            // txtmktk
            // 
            txtmktk.BackColor = Color.LightCyan;
            txtmktk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtmktk.Location = new Point(333, 159);
            txtmktk.Margin = new Padding(3, 4, 3, 4);
            txtmktk.Multiline = true;
            txtmktk.Name = "txtmktk";
            txtmktk.Size = new Size(374, 52);
            txtmktk.TabIndex = 8;
            txtmktk.TextAlign = HorizontalAlignment.Center;
            // 
            // txttentk
            // 
            txttentk.BackColor = Color.LightCyan;
            txttentk.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txttentk.Location = new Point(333, 39);
            txttentk.Margin = new Padding(3, 4, 3, 4);
            txttentk.Multiline = true;
            txttentk.Name = "txttentk";
            txttentk.Size = new Size(374, 52);
            txttentk.TabIndex = 6;
            txttentk.TextAlign = HorizontalAlignment.Center;
            // 
            // txtxacthuc
            // 
            txtxacthuc.BackColor = Color.LightCyan;
            txtxacthuc.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            txtxacthuc.Location = new Point(333, 277);
            txtxacthuc.Margin = new Padding(3, 4, 3, 4);
            txtxacthuc.Multiline = true;
            txtxacthuc.Name = "txtxacthuc";
            txtxacthuc.Size = new Size(374, 52);
            txtxacthuc.TabIndex = 10;
            txtxacthuc.TextAlign = HorizontalAlignment.Center;
            txtxacthuc.TextChanged += txtxacthuc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(60, 52);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 13;
            label1.Text = "TÊN TÀI KHOẢN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(39, 293);
            label3.Name = "label3";
            label3.Size = new Size(270, 25);
            label3.TabIndex = 15;
            label3.Text = "XÁC THỰC MẬT KHẨU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(81, 173);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 16;
            label4.Text = "MẬT KHẨU";
            label4.Click += label4_Click;
            // 
            // btndangky
            // 
            btndangky.BackColor = Color.PowderBlue;
            btndangky.FlatStyle = FlatStyle.Flat;
            btndangky.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndangky.ForeColor = Color.SteelBlue;
            btndangky.Location = new Point(433, 358);
            btndangky.Margin = new Padding(3, 4, 3, 4);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(186, 56);
            btndangky.TabIndex = 17;
            btndangky.Text = "ĐĂNG KÝ";
            btndangky.UseVisualStyleBackColor = false;
            btndangky.Click += btndangky_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 427);
            Controls.Add(btndangky);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtxacthuc);
            Controls.Add(txtmktk);
            Controls.Add(txttentk);
            ForeColor = Color.DarkSlateGray;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            Load += DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtmktk;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.TextBox txtxacthuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndangky;
    }
}