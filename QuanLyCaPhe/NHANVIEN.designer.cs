namespace QuanLyCaPhe
{
    partial class NHANVIEN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NHANVIEN));
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.dgv_listNV = new System.Windows.Forms.DataGridView();
            this.tb_find_NV = new System.Windows.Forms.TextBox();
            this.bt_find_NV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_matNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sdtNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_mail_NV = new System.Windows.Forms.TextBox();
            this.tb_MQNV = new System.Windows.Forms.TextBox();
            this.tb_dcNV = new System.Windows.Forms.TextBox();
            this.tb_passNV = new System.Windows.Forms.TextBox();
            this.tb_loginNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatNV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_listNV);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(637, 84);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(1054, 662);
            this.gb_listBan.TabIndex = 2;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Nhân Viên";
            // 
            // dgv_listNV
            // 
            this.dgv_listNV.AllowUserToAddRows = false;
            this.dgv_listNV.AllowUserToDeleteRows = false;
            this.dgv_listNV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listNV.Location = new System.Drawing.Point(5, 41);
            this.dgv_listNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listNV.Name = "dgv_listNV";
            this.dgv_listNV.ReadOnly = true;
            this.dgv_listNV.RowHeadersWidth = 51;
            this.dgv_listNV.RowTemplate.Height = 24;
            this.dgv_listNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listNV.Size = new System.Drawing.Size(1043, 608);
            this.dgv_listNV.TabIndex = 0;
            this.dgv_listNV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_listNV_RowPrePaint);
            // 
            // tb_find_NV
            // 
            this.tb_find_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_NV.Location = new System.Drawing.Point(637, 45);
            this.tb_find_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find_NV.Name = "tb_find_NV";
            this.tb_find_NV.Size = new System.Drawing.Size(663, 24);
            this.tb_find_NV.TabIndex = 4;
            // 
            // bt_find_NV
            // 
            this.bt_find_NV.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_find_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_find_NV.ForeColor = System.Drawing.Color.White;
            this.bt_find_NV.Location = new System.Drawing.Point(1323, 33);
            this.bt_find_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find_NV.Name = "bt_find_NV";
            this.bt_find_NV.Size = new System.Drawing.Size(185, 47);
            this.bt_find_NV.TabIndex = 6;
            this.bt_find_NV.Text = "Tìm Kiếm";
            this.bt_find_NV.UseVisualStyleBackColor = false;
            this.bt_find_NV.Click += new System.EventHandler(this.bt_find_NV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "SDT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // tb_matNV
            // 
            this.tb_matNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_matNV.Location = new System.Drawing.Point(200, 86);
            this.tb_matNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matNV.Name = "tb_matNV";
            this.tb_matNV.Size = new System.Drawing.Size(418, 24);
            this.tb_matNV.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã quyền:";
            // 
            // tb_tenNV
            // 
            this.tb_tenNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_tenNV.Location = new System.Drawing.Point(200, 144);
            this.tb_tenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenNV.Name = "tb_tenNV";
            this.tb_tenNV.Size = new System.Drawing.Size(418, 24);
            this.tb_tenNV.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mật khẩu:";
            // 
            // tb_sdtNV
            // 
            this.tb_sdtNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_sdtNV.Location = new System.Drawing.Point(200, 275);
            this.tb_sdtNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sdtNV.Name = "tb_sdtNV";
            this.tb_sdtNV.Size = new System.Drawing.Size(418, 24);
            this.tb_sdtNV.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(31, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đăng nhập:";
            // 
            // tb_mail_NV
            // 
            this.tb_mail_NV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_mail_NV.Location = new System.Drawing.Point(200, 342);
            this.tb_mail_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mail_NV.Name = "tb_mail_NV";
            this.tb_mail_NV.Size = new System.Drawing.Size(418, 24);
            this.tb_mail_NV.TabIndex = 2;
            // 
            // tb_MQNV
            // 
            this.tb_MQNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_MQNV.Location = new System.Drawing.Point(200, 538);
            this.tb_MQNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MQNV.Name = "tb_MQNV";
            this.tb_MQNV.Size = new System.Drawing.Size(418, 24);
            this.tb_MQNV.TabIndex = 2;
            // 
            // tb_dcNV
            // 
            this.tb_dcNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_dcNV.Location = new System.Drawing.Point(200, 210);
            this.tb_dcNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_dcNV.Name = "tb_dcNV";
            this.tb_dcNV.Size = new System.Drawing.Size(418, 24);
            this.tb_dcNV.TabIndex = 2;
            // 
            // tb_passNV
            // 
            this.tb_passNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_passNV.Location = new System.Drawing.Point(200, 469);
            this.tb_passNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_passNV.Name = "tb_passNV";
            this.tb_passNV.Size = new System.Drawing.Size(418, 24);
            this.tb_passNV.TabIndex = 2;
            // 
            // tb_loginNV
            // 
            this.tb_loginNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_loginNV.Location = new System.Drawing.Point(200, 403);
            this.tb_loginNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_loginNV.Name = "tb_loginNV";
            this.tb_loginNV.Size = new System.Drawing.Size(418, 24);
            this.tb_loginNV.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 36);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nhân Viên";
            // 
            // btnThemNV
            // 
            this.btnThemNV.AutoRoundedCorners = true;
            this.btnThemNV.BorderRadius = 21;
            this.btnThemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemNV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNV.ForeColor = System.Drawing.Color.Black;
            this.btnThemNV.Location = new System.Drawing.Point(167, 599);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(150, 44);
            this.btnThemNV.TabIndex = 26;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.AutoRoundedCorners = true;
            this.btnCapNhatNV.BorderRadius = 21;
            this.btnCapNhatNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatNV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnCapNhatNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatNV.Location = new System.Drawing.Point(399, 599);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(150, 44);
            this.btnCapNhatNV.TabIndex = 37;
            this.btnCapNhatNV.Text = "Cập Nhật";
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.AutoRoundedCorners = true;
            this.btnXoaNV.BorderRadius = 21;
            this.btnXoaNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaNV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaNV.Location = new System.Drawing.Point(167, 669);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(150, 44);
            this.btnXoaNV.TabIndex = 38;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.AutoRoundedCorners = true;
            this.btnThoatNV.BorderRadius = 21;
            this.btnThoatNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatNV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThoatNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatNV.ForeColor = System.Drawing.Color.Black;
            this.btnThoatNV.Location = new System.Drawing.Point(399, 669);
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.Size = new System.Drawing.Size(150, 44);
            this.btnThoatNV.TabIndex = 39;
            this.btnThoatNV.Text = "Thoát";
            this.btnThoatNV.Click += new System.EventHandler(this.btnThoatNV_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // NHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1703, 757);
            this.Controls.Add(this.btnThoatNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnCapNhatNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_loginNV);
            this.Controls.Add(this.tb_find_NV);
            this.Controls.Add(this.tb_passNV);
            this.Controls.Add(this.tb_dcNV);
            this.Controls.Add(this.bt_find_NV);
            this.Controls.Add(this.tb_MQNV);
            this.Controls.Add(this.tb_mail_NV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_sdtNV);
            this.Controls.Add(this.gb_listBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_tenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_matNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NHANVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NHANVIEN_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listNV;
        private System.Windows.Forms.TextBox tb_find_NV;
        private System.Windows.Forms.Button bt_find_NV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_matNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sdtNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_mail_NV;
        private System.Windows.Forms.TextBox tb_MQNV;
        private System.Windows.Forms.TextBox tb_dcNV;
        private System.Windows.Forms.TextBox tb_passNV;
        private System.Windows.Forms.TextBox tb_loginNV;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnThemNV;
        private Guna.UI2.WinForms.Guna2Button btnXoaNV;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatNV;
        private Guna.UI2.WinForms.Guna2Button btnThoatNV;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}