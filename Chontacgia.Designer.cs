namespace testgiaodien
{
    partial class Chontacgia
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            datatacgia = new DataGridView();
            Matacgia = new DataGridViewTextBoxColumn();
            Tentacgia = new DataGridViewTextBoxColumn();
            btchon = new Button();
            bthuy = new Button();
            ((System.ComponentModel.ISupportInitialize)datatacgia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 9);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 2;
            label1.Text = "CHỌN TÁC GIẢ";
            // 
            // datatacgia
            // 
            datatacgia.AllowUserToAddRows = false;
            datatacgia.AllowUserToDeleteRows = false;
            datatacgia.AllowUserToResizeColumns = false;
            datatacgia.AllowUserToResizeRows = false;
            datatacgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datatacgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datatacgia.Columns.AddRange(new DataGridViewColumn[] { Matacgia, Tentacgia });
            datatacgia.EditMode = DataGridViewEditMode.EditProgrammatically;
            datatacgia.Location = new Point(29, 65);
            datatacgia.Name = "datatacgia";
            datatacgia.ReadOnly = true;
            datatacgia.RowHeadersVisible = false;
            datatacgia.RowHeadersWidth = 51;
            datatacgia.RowTemplate.Height = 24;
            datatacgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datatacgia.ShowEditingIcon = false;
            datatacgia.Size = new Size(859, 279);
            datatacgia.TabIndex = 3;
            // 
            // Matacgia
            // 
            Matacgia.DataPropertyName = "ID_TG";
            Matacgia.HeaderText = "Mã tác giả";
            Matacgia.MinimumWidth = 6;
            Matacgia.Name = "Matacgia";
            Matacgia.ReadOnly = true;
            Matacgia.Visible = false;
            // 
            // Tentacgia
            // 
            Tentacgia.DataPropertyName = "TenTG";
            Tentacgia.HeaderText = "Tên tác giả";
            Tentacgia.MinimumWidth = 6;
            Tentacgia.Name = "Tentacgia";
            Tentacgia.ReadOnly = true;
            // 
            // btchon
            // 
            btchon.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btchon.Location = new Point(216, 364);
            btchon.Name = "btchon";
            btchon.Size = new Size(109, 54);
            btchon.TabIndex = 4;
            btchon.Text = "Chọn";
            btchon.UseVisualStyleBackColor = true;
            btchon.Click += btchon_Click;
            // 
            // bthuy
            // 
            bthuy.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthuy.Location = new Point(540, 364);
            bthuy.Name = "bthuy";
            bthuy.Size = new Size(109, 54);
            bthuy.TabIndex = 5;
            bthuy.Text = "Hủy";
            bthuy.UseVisualStyleBackColor = true;
            bthuy.Click += bthuy_Click;
            // 
            // Chontacgia
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 498);
            Controls.Add(bthuy);
            Controls.Add(btchon);
            Controls.Add(datatacgia);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chontacgia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChonTacGia";
            Load += Chontacgiac_Load;
            ((System.ComponentModel.ISupportInitialize)datatacgia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView datatacgia;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentacgia;
    }
}