namespace testgiaodien
{
    partial class Chontheloai
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
            bthuy = new Button();
            btchon = new Button();
            dataloaisach = new DataGridView();
            Maloaisach = new DataGridViewTextBoxColumn();
            Loaisach = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataloaisach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 6);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 37);
            label1.TabIndex = 9;
            label1.Text = "CHỌN LOẠI SÁCH";
            // 
            // bthuy
            // 
            bthuy.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthuy.Location = new Point(581, 368);
            bthuy.Name = "bthuy";
            bthuy.Size = new Size(109, 54);
            bthuy.TabIndex = 13;
            bthuy.Text = "Hủy";
            bthuy.UseVisualStyleBackColor = true;
            bthuy.Click += bthuy_Click;
            // 
            // btchon
            // 
            btchon.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btchon.Location = new Point(207, 368);
            btchon.Name = "btchon";
            btchon.Size = new Size(109, 54);
            btchon.TabIndex = 12;
            btchon.Text = "Chọn";
            btchon.UseVisualStyleBackColor = true;
            btchon.Click += btchon_Click;
            // 
            // dataloaisach
            // 
            dataloaisach.AllowUserToAddRows = false;
            dataloaisach.AllowUserToDeleteRows = false;
            dataloaisach.AllowUserToResizeColumns = false;
            dataloaisach.AllowUserToResizeRows = false;
            dataloaisach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataloaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataloaisach.Columns.AddRange(new DataGridViewColumn[] { Maloaisach, Loaisach });
            dataloaisach.Location = new Point(37, 62);
            dataloaisach.Name = "dataloaisach";
            dataloaisach.ReadOnly = true;
            dataloaisach.RowHeadersWidth = 51;
            dataloaisach.RowTemplate.Height = 24;
            dataloaisach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataloaisach.Size = new Size(859, 279);
            dataloaisach.TabIndex = 11;
            // 
            // Maloaisach
            // 
            Maloaisach.DataPropertyName = "ID_LS";
            Maloaisach.HeaderText = "Mã loại sách";
            Maloaisach.MinimumWidth = 6;
            Maloaisach.Name = "Maloaisach";
            Maloaisach.ReadOnly = true;
            Maloaisach.Visible = false;
            // 
            // Loaisach
            // 
            Loaisach.DataPropertyName = "TenLS";
            Loaisach.HeaderText = "Loại sách";
            Loaisach.MinimumWidth = 6;
            Loaisach.Name = "Loaisach";
            Loaisach.ReadOnly = true;
            // 
            // Chontheloai
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 469);
            Controls.Add(bthuy);
            Controls.Add(btchon);
            Controls.Add(dataloaisach);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Chontheloai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChonTheLoai";
            Load += Chontheloai_Load;
            ((System.ComponentModel.ISupportInitialize)dataloaisach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.DataGridView dataloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaisach;
    }
}