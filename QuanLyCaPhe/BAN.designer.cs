namespace QuanLyCaPhe
{
    partial class BAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAN));
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.tb_maKhuVuc = new System.Windows.Forms.TextBox();
            this.tb_tenBan = new System.Windows.Forms.TextBox();
            this.tb_maBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.btnTimKiemBan = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_listBan = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.gb_Ban.SuspendLayout();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.tb_maKhuVuc);
            this.gb_Ban.Controls.Add(this.tb_tenBan);
            this.gb_Ban.Controls.Add(this.tb_maBan);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Ban.Location = new System.Drawing.Point(11, 35);
            this.gb_Ban.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Ban.Size = new System.Drawing.Size(559, 246);
            this.gb_Ban.TabIndex = 0;
            this.gb_Ban.TabStop = false;
            this.gb_Ban.Text = "Số Bàn";
            // 
            // tb_maKhuVuc
            // 
            this.tb_maKhuVuc.Location = new System.Drawing.Point(217, 154);
            this.tb_maKhuVuc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_maKhuVuc.Name = "tb_maKhuVuc";
            this.tb_maKhuVuc.Size = new System.Drawing.Size(282, 24);
            this.tb_maKhuVuc.TabIndex = 3;
            // 
            // tb_tenBan
            // 
            this.tb_tenBan.Location = new System.Drawing.Point(217, 106);
            this.tb_tenBan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenBan.Name = "tb_tenBan";
            this.tb_tenBan.Size = new System.Drawing.Size(282, 24);
            this.tb_tenBan.TabIndex = 2;
            // 
            // tb_maBan
            // 
            this.tb_maBan.Location = new System.Drawing.Point(217, 60);
            this.tb_maBan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_maBan.Name = "tb_maBan";
            this.tb_maBan.Size = new System.Drawing.Size(282, 24);
            this.tb_maBan.TabIndex = 1;
            this.tb_maBan.TextChanged += new System.EventHandler(this.tb_maBan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Khu Vực: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Bàn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bàn:";
            // 
            // btnCapNhatBan
            // 
            this.btnCapNhatBan.AutoRoundedCorners = true;
            this.btnCapNhatBan.BorderRadius = 17;
            this.btnCapNhatBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatBan.FillColor = System.Drawing.Color.LightSalmon;
            this.btnCapNhatBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatBan.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatBan.Location = new System.Drawing.Point(228, 315);
            this.btnCapNhatBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatBan.Name = "btnCapNhatBan";
            this.btnCapNhatBan.Size = new System.Drawing.Size(112, 36);
            this.btnCapNhatBan.TabIndex = 28;
            this.btnCapNhatBan.Text = "Cập nhật";
            // 
            // btnThemBan
            // 
            this.btnThemBan.AutoRoundedCorners = true;
            this.btnThemBan.BorderRadius = 17;
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemBan.ForeColor = System.Drawing.Color.Black;
            this.btnThemBan.Location = new System.Drawing.Point(53, 315);
            this.btnThemBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(112, 36);
            this.btnThemBan.TabIndex = 27;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_listBan);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(606, 54);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Size = new System.Drawing.Size(671, 400);
            this.gb_listBan.TabIndex = 0;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Bàn";
            // 
            // btnTimKiemBan
            // 
            this.btnTimKiemBan.AutoRoundedCorners = true;
            this.btnTimKiemBan.BorderRadius = 17;
            this.btnTimKiemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemBan.FillColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemBan.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemBan.Location = new System.Drawing.Point(1090, 11);
            this.btnTimKiemBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemBan.Name = "btnTimKiemBan";
            this.btnTimKiemBan.Size = new System.Drawing.Size(130, 36);
            this.btnTimKiemBan.TabIndex = 30;
            this.btnTimKiemBan.Text = "Tìm Kiếm";
            this.btnTimKiemBan.Click += new System.EventHandler(this.btnTimKiemBan_Click);
            // 
            // dgv_listBan
            // 
            this.dgv_listBan.AllowUserToAddRows = false;
            this.dgv_listBan.AllowUserToDeleteRows = false;
            this.dgv_listBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listBan.Location = new System.Drawing.Point(4, 32);
            this.dgv_listBan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listBan.Name = "dgv_listBan";
            this.dgv_listBan.ReadOnly = true;
            this.dgv_listBan.RowHeadersWidth = 51;
            this.dgv_listBan.RowTemplate.Height = 24;
            this.dgv_listBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listBan.Size = new System.Drawing.Size(663, 365);
            this.dgv_listBan.TabIndex = 0;
            this.dgv_listBan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_listBan_RowPrePaint);
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_find.Location = new System.Drawing.Point(610, 19);
            this.tb_find.Margin = new System.Windows.Forms.Padding(2);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(456, 23);
            this.tb_find.TabIndex = 8;
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.AutoRoundedCorners = true;
            this.btnXoaBan.BorderRadius = 17;
            this.btnXoaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaBan.FillColor = System.Drawing.Color.LightSalmon;
            this.btnXoaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaBan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaBan.Location = new System.Drawing.Point(398, 315);
            this.btnXoaBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(112, 36);
            this.btnXoaBan.TabIndex = 29;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // BAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1302, 474);
            this.Controls.Add(this.btnTimKiemBan);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnCapNhatBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.gb_listBan);
            this.Controls.Add(this.gb_Ban);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÀN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.TextBox tb_maKhuVuc;
        private System.Windows.Forms.TextBox tb_tenBan;
        private System.Windows.Forms.TextBox tb_maBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listBan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.TextBox tb_find;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatBan;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemBan;
    }
}

