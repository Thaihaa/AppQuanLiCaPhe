namespace QuanLyCaPhe
{
    partial class KHACHHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHACHHANG));
            this.tb_find_KH = new System.Windows.Forms.TextBox();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.dgv_list_KH = new System.Windows.Forms.DataGridView();
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.tb_loai_KH = new System.Windows.Forms.TextBox();
            this.tb_email_KH = new System.Windows.Forms.TextBox();
            this.tb_sdt_KH = new System.Windows.Forms.TextBox();
            this.tb_dc_KH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_maKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_MQKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_loginKH = new System.Windows.Forms.TextBox();
            this.tb_passKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemKH = new Guna.UI2.WinForms.Guna2Button();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).BeginInit();
            this.gb_Ban.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_find_KH
            // 
            this.tb_find_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_KH.Location = new System.Drawing.Point(427, 24);
            this.tb_find_KH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_find_KH.Name = "tb_find_KH";
            this.tb_find_KH.Size = new System.Drawing.Size(653, 24);
            this.tb_find_KH.TabIndex = 6;
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_list_KH);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(423, 78);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Size = new System.Drawing.Size(817, 444);
            this.gb_listBan.TabIndex = 4;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Khách Hàng";
            // 
            // dgv_list_KH
            // 
            this.dgv_list_KH.AllowUserToAddRows = false;
            this.dgv_list_KH.AllowUserToDeleteRows = false;
            this.dgv_list_KH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_KH.Location = new System.Drawing.Point(4, 36);
            this.dgv_list_KH.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_list_KH.Name = "dgv_list_KH";
            this.dgv_list_KH.ReadOnly = true;
            this.dgv_list_KH.RowHeadersWidth = 51;
            this.dgv_list_KH.RowTemplate.Height = 24;
            this.dgv_list_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_KH.Size = new System.Drawing.Size(809, 402);
            this.dgv_list_KH.TabIndex = 0;
            this.dgv_list_KH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_list_KH_RowPrePaint);
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.tb_loai_KH);
            this.gb_Ban.Controls.Add(this.tb_email_KH);
            this.gb_Ban.Controls.Add(this.tb_sdt_KH);
            this.gb_Ban.Controls.Add(this.tb_dc_KH);
            this.gb_Ban.Controls.Add(this.label6);
            this.gb_Ban.Controls.Add(this.tb_tenKH);
            this.gb_Ban.Controls.Add(this.label5);
            this.gb_Ban.Controls.Add(this.tb_maKH);
            this.gb_Ban.Controls.Add(this.label4);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Ban.Location = new System.Drawing.Point(10, 12);
            this.gb_Ban.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Ban.Size = new System.Drawing.Size(388, 396);
            this.gb_Ban.TabIndex = 5;
            this.gb_Ban.TabStop = false;
            this.gb_Ban.Text = "Khách Hàng";
            // 
            // tb_loai_KH
            // 
            this.tb_loai_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_loai_KH.Location = new System.Drawing.Point(144, 322);
            this.tb_loai_KH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_loai_KH.Name = "tb_loai_KH";
            this.tb_loai_KH.Size = new System.Drawing.Size(233, 24);
            this.tb_loai_KH.TabIndex = 2;
            // 
            // tb_email_KH
            // 
            this.tb_email_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_email_KH.Location = new System.Drawing.Point(144, 264);
            this.tb_email_KH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email_KH.Name = "tb_email_KH";
            this.tb_email_KH.Size = new System.Drawing.Size(233, 24);
            this.tb_email_KH.TabIndex = 2;
            // 
            // tb_sdt_KH
            // 
            this.tb_sdt_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_sdt_KH.Location = new System.Drawing.Point(144, 212);
            this.tb_sdt_KH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_sdt_KH.Name = "tb_sdt_KH";
            this.tb_sdt_KH.Size = new System.Drawing.Size(233, 24);
            this.tb_sdt_KH.TabIndex = 2;
            // 
            // tb_dc_KH
            // 
            this.tb_dc_KH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_dc_KH.Location = new System.Drawing.Point(144, 153);
            this.tb_dc_KH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dc_KH.Name = "tb_dc_KH";
            this.tb_dc_KH.Size = new System.Drawing.Size(233, 24);
            this.tb_dc_KH.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại:";
            // 
            // tb_tenKH
            // 
            this.tb_tenKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_tenKH.Location = new System.Drawing.Point(144, 104);
            this.tb_tenKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenKH.Name = "tb_tenKH";
            this.tb_tenKH.Size = new System.Drawing.Size(233, 24);
            this.tb_tenKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // tb_maKH
            // 
            this.tb_maKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_maKH.Location = new System.Drawing.Point(144, 52);
            this.tb_maKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_maKH.Name = "tb_maKH";
            this.tb_maKH.Size = new System.Drawing.Size(233, 24);
            this.tb_maKH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã quyền:";
            // 
            // tb_MQKH
            // 
            this.tb_MQKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_MQKH.Location = new System.Drawing.Point(144, 130);
            this.tb_MQKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_MQKH.Name = "tb_MQKH";
            this.tb_MQKH.Size = new System.Drawing.Size(233, 24);
            this.tb_MQKH.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_loginKH);
            this.groupBox1.Controls.Add(this.tb_passKH);
            this.groupBox1.Controls.Add(this.tb_MQKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 412);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(388, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tb_loginKH
            // 
            this.tb_loginKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_loginKH.Location = new System.Drawing.Point(144, 22);
            this.tb_loginKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_loginKH.Name = "tb_loginKH";
            this.tb_loginKH.Size = new System.Drawing.Size(233, 24);
            this.tb_loginKH.TabIndex = 2;
            // 
            // tb_passKH
            // 
            this.tb_passKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_passKH.Location = new System.Drawing.Point(144, 73);
            this.tb_passKH.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passKH.Name = "tb_passKH";
            this.tb_passKH.Size = new System.Drawing.Size(233, 24);
            this.tb_passKH.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Đăng nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mật khẩu:";
            // 
            // btnThemKH
            // 
            this.btnThemKH.AutoRoundedCorners = true;
            this.btnThemKH.BorderRadius = 17;
            this.btnThemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemKH.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKH.ForeColor = System.Drawing.Color.Black;
            this.btnThemKH.Location = new System.Drawing.Point(469, 554);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(112, 36);
            this.btnThemKH.TabIndex = 29;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.AutoRoundedCorners = true;
            this.btnCapNhatKH.BorderRadius = 17;
            this.btnCapNhatKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatKH.FillColor = System.Drawing.Color.LightSalmon;
            this.btnCapNhatKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatKH.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatKH.Location = new System.Drawing.Point(663, 554);
            this.btnCapNhatKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.Size = new System.Drawing.Size(112, 36);
            this.btnCapNhatKH.TabIndex = 30;
            this.btnCapNhatKH.Text = "Cập nhật";
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.AutoRoundedCorners = true;
            this.btnXoaKH.BorderRadius = 17;
            this.btnXoaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaKH.FillColor = System.Drawing.Color.LightSalmon;
            this.btnXoaKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKH.Location = new System.Drawing.Point(882, 554);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(112, 36);
            this.btnXoaKH.TabIndex = 31;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.AutoRoundedCorners = true;
            this.btnThoatKH.BorderRadius = 17;
            this.btnThoatKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatKH.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThoatKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatKH.ForeColor = System.Drawing.Color.Black;
            this.btnThoatKH.Location = new System.Drawing.Point(1079, 554);
            this.btnThoatKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.Size = new System.Drawing.Size(112, 36);
            this.btnThoatKH.TabIndex = 32;
            this.btnThoatKH.Text = "Thoát";
            this.btnThoatKH.Click += new System.EventHandler(this.btnThoatKH_Click);
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.AutoRoundedCorners = true;
            this.btnTimKiemKH.BorderRadius = 21;
            this.btnTimKiemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemKH.FillColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemKH.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemKH.Location = new System.Drawing.Point(1097, 12);
            this.btnTimKiemKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(125, 44);
            this.btnTimKiemKH.TabIndex = 33;
            this.btnTimKiemKH.Text = "Tìm Kiếm ";
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1264, 622);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoatKH);
            this.Controls.Add(this.tb_find_KH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnCapNhatKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.gb_listBan);
            this.Controls.Add(this.gb_Ban);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KHACHHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KHACHHANG_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).EndInit();
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_find_KH;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.TextBox tb_tenKH;
        private System.Windows.Forms.TextBox tb_maKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_loai_KH;
        private System.Windows.Forms.TextBox tb_email_KH;
        private System.Windows.Forms.TextBox tb_sdt_KH;
        private System.Windows.Forms.TextBox tb_dc_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_list_KH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_MQKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_loginKH;
        private System.Windows.Forms.TextBox tb_passKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemKH;
        private Guna.UI2.WinForms.Guna2Button btnThoatKH;
        private Guna.UI2.WinForms.Guna2Button btnXoaKH;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatKH;
    }
}