namespace BTL_QuanLyThuVien_Nhom2
{
    partial class ThuThu
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btndoimk = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            txtten = new TextBox();
            txtchucvu = new TextBox();
            txtid = new TextBox();
            txtgt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 48);
            label1.Name = "label1";
            label1.Size = new Size(122, 38);
            label1.TabIndex = 0;
            label1.Text = "Thủ thư";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(126, 128);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ tên thủ thư";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(126, 189);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 1;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 189);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 2;
            label4.Text = "Chức vụ đảm nhận";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 128);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 2;
            label5.Text = "ID_TT";
            // 
            // btndoimk
            // 
            btndoimk.Location = new Point(78, 343);
            btndoimk.Name = "btndoimk";
            btndoimk.Size = new Size(127, 67);
            btndoimk.TabIndex = 3;
            btndoimk.Text = "Đổi mật khẩu";
            btndoimk.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(256, 343);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(91, 67);
            btnsua.TabIndex = 3;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(430, 343);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(91, 67);
            btnxoa.TabIndex = 3;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(588, 343);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(91, 67);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // txtten
            // 
            txtten.Location = new Point(243, 121);
            txtten.Name = "txtten";
            txtten.Size = new Size(167, 27);
            txtten.TabIndex = 4;
            // 
            // txtchucvu
            // 
            txtchucvu.Location = new Point(587, 184);
            txtchucvu.Name = "txtchucvu";
            txtchucvu.Size = new Size(167, 27);
            txtchucvu.TabIndex = 4;
            // 
            // txtid
            // 
            txtid.Location = new Point(598, 118);
            txtid.Name = "txtid";
            txtid.Size = new Size(167, 27);
            txtid.TabIndex = 4;
            // 
            // txtgt
            // 
            txtgt.Location = new Point(243, 189);
            txtgt.Name = "txtgt";
            txtgt.Size = new Size(167, 27);
            txtgt.TabIndex = 4;
            // 
            // ThuThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 502);
            Controls.Add(txtid);
            Controls.Add(txtchucvu);
            Controls.Add(txtgt);
            Controls.Add(txtten);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btndoimk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThuThu";
            Text = "ThuThu";
            Load += ThuThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btndoimk;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthoat;
        private TextBox txtten;
        private TextBox txtchucvu;
        private TextBox txtid;
        private TextBox txtgt;
    }
}