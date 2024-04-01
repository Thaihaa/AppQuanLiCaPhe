namespace QuanLyCaPhe
{
    partial class QLMenu
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
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.txtTenThucDon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewMENU = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhaplaiMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMENU)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaThucDon.Location = new System.Drawing.Point(170, 41);
            this.txtMaThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThucDon.Multiline = true;
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(622, 31);
            this.txtMaThucDon.TabIndex = 0;
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTenThucDon.Location = new System.Drawing.Point(170, 76);
            this.txtTenThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenThucDon.Multiline = true;
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(622, 31);
            this.txtTenThucDon.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtGia.Location = new System.Drawing.Point(170, 116);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(622, 31);
            this.txtGia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã thực đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên thực đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá";
            // 
            // dataGridViewMENU
            // 
            this.dataGridViewMENU.AllowUserToAddRows = false;
            this.dataGridViewMENU.AllowUserToDeleteRows = false;
            this.dataGridViewMENU.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMENU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMENU.Location = new System.Drawing.Point(10, 221);
            this.dataGridViewMENU.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMENU.Name = "dataGridViewMENU";
            this.dataGridViewMENU.ReadOnly = true;
            this.dataGridViewMENU.RowHeadersWidth = 51;
            this.dataGridViewMENU.RowTemplate.Height = 24;
            this.dataGridViewMENU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMENU.Size = new System.Drawing.Size(795, 319);
            this.dataGridViewMENU.TabIndex = 9;
            this.dataGridViewMENU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMENU_CellContentClick);
            this.dataGridViewMENU.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewMENU_RowPrePaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(294, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUẢN LÝ MENU";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnThemMenu
            // 
            this.btnThemMenu.AutoRoundedCorners = true;
            this.btnThemMenu.BorderRadius = 17;
            this.btnThemMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMenu.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThemMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMenu.ForeColor = System.Drawing.Color.Black;
            this.btnThemMenu.Location = new System.Drawing.Point(42, 168);
            this.btnThemMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMenu.Name = "btnThemMenu";
            this.btnThemMenu.Size = new System.Drawing.Size(112, 36);
            this.btnThemMenu.TabIndex = 27;
            this.btnThemMenu.Text = "Thêm";
            this.btnThemMenu.Click += new System.EventHandler(this.btnThemMenu_Click);
            // 
            // btnNhaplaiMenu
            // 
            this.btnNhaplaiMenu.AutoRoundedCorners = true;
            this.btnNhaplaiMenu.BorderRadius = 17;
            this.btnNhaplaiMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaplaiMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhaplaiMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaplaiMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhaplaiMenu.FillColor = System.Drawing.Color.LightSalmon;
            this.btnNhaplaiMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhaplaiMenu.ForeColor = System.Drawing.Color.Black;
            this.btnNhaplaiMenu.Location = new System.Drawing.Point(503, 168);
            this.btnNhaplaiMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaplaiMenu.Name = "btnNhaplaiMenu";
            this.btnNhaplaiMenu.Size = new System.Drawing.Size(112, 36);
            this.btnNhaplaiMenu.TabIndex = 28;
            this.btnNhaplaiMenu.Text = "Nhập lại";
            // 
            // btnThoatMenu
            // 
            this.btnThoatMenu.AutoRoundedCorners = true;
            this.btnThoatMenu.BorderRadius = 17;
            this.btnThoatMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatMenu.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThoatMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatMenu.ForeColor = System.Drawing.Color.Black;
            this.btnThoatMenu.Location = new System.Drawing.Point(661, 168);
            this.btnThoatMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoatMenu.Name = "btnThoatMenu";
            this.btnThoatMenu.Size = new System.Drawing.Size(112, 36);
            this.btnThoatMenu.TabIndex = 29;
            this.btnThoatMenu.Text = "Thoát";
            this.btnThoatMenu.Click += new System.EventHandler(this.btnThoatMenu_Click);
            // 
            // btnXoaMenu
            // 
            this.btnXoaMenu.AutoRoundedCorners = true;
            this.btnXoaMenu.BorderRadius = 17;
            this.btnXoaMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaMenu.FillColor = System.Drawing.Color.LightSalmon;
            this.btnXoaMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaMenu.ForeColor = System.Drawing.Color.Black;
            this.btnXoaMenu.Location = new System.Drawing.Point(343, 168);
            this.btnXoaMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMenu.Name = "btnXoaMenu";
            this.btnXoaMenu.Size = new System.Drawing.Size(112, 36);
            this.btnXoaMenu.TabIndex = 30;
            this.btnXoaMenu.Text = "Xóa";
            this.btnXoaMenu.Click += new System.EventHandler(this.btnXoaMenu_Click);
            // 
            // btnSuaMenu
            // 
            this.btnSuaMenu.AutoRoundedCorners = true;
            this.btnSuaMenu.BorderRadius = 17;
            this.btnSuaMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaMenu.FillColor = System.Drawing.Color.LightSalmon;
            this.btnSuaMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaMenu.ForeColor = System.Drawing.Color.Black;
            this.btnSuaMenu.Location = new System.Drawing.Point(183, 168);
            this.btnSuaMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaMenu.Name = "btnSuaMenu";
            this.btnSuaMenu.Size = new System.Drawing.Size(112, 36);
            this.btnSuaMenu.TabIndex = 31;
            this.btnSuaMenu.Text = "Sửa";
            this.btnSuaMenu.Click += new System.EventHandler(this.btnSuaMenu_Click);
            // 
            // QLMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(818, 551);
            this.Controls.Add(this.btnSuaMenu);
            this.Controls.Add(this.btnXoaMenu);
            this.Controls.Add(this.btnThoatMenu);
            this.Controls.Add(this.btnNhaplaiMenu);
            this.Controls.Add(this.btnThemMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMENU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenThucDon);
            this.Controls.Add(this.txtMaThucDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMENU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaThucDon;
        private System.Windows.Forms.TextBox txtTenThucDon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewMENU;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnThemMenu;
        private Guna.UI2.WinForms.Guna2Button btnNhaplaiMenu;
        private Guna.UI2.WinForms.Guna2Button btnThoatMenu;
        private Guna.UI2.WinForms.Guna2Button btnXoaMenu;
        private Guna.UI2.WinForms.Guna2Button btnSuaMenu;
    }
}

