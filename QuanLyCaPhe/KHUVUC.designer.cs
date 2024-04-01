namespace QuanLyCaPhe
{
    partial class KHUVUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHUVUC));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.btnThoatKV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaKV = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_listKV = new System.Windows.Forms.DataGridView();
            this.tb_find_KV = new System.Windows.Forms.TextBox();
            this.tb_tenKV = new System.Windows.Forms.TextBox();
            this.tb_idKV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemKV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatKV = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemKV = new Guna.UI2.WinForms.Guna2Button();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_listKV);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(13, 110);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(2);
            this.gb_listBan.Size = new System.Drawing.Size(730, 360);
            this.gb_listBan.TabIndex = 2;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Khu Vực";
            this.gb_listBan.Enter += new System.EventHandler(this.gb_listBan_Enter);
            // 
            // btnThoatKV
            // 
            this.btnThoatKV.AutoRoundedCorners = true;
            this.btnThoatKV.BorderRadius = 17;
            this.btnThoatKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatKV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThoatKV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatKV.ForeColor = System.Drawing.Color.Black;
            this.btnThoatKV.Location = new System.Drawing.Point(586, 488);
            this.btnThoatKV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoatKV.Name = "btnThoatKV";
            this.btnThoatKV.Size = new System.Drawing.Size(112, 36);
            this.btnThoatKV.TabIndex = 31;
            this.btnThoatKV.Text = "Thoát";
            this.btnThoatKV.Click += new System.EventHandler(this.btnThoatKV_Click);
            // 
            // btnXoaKV
            // 
            this.btnXoaKV.AutoRoundedCorners = true;
            this.btnXoaKV.BorderRadius = 17;
            this.btnXoaKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaKV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnXoaKV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaKV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKV.Location = new System.Drawing.Point(409, 488);
            this.btnXoaKV.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaKV.Name = "btnXoaKV";
            this.btnXoaKV.Size = new System.Drawing.Size(112, 36);
            this.btnXoaKV.TabIndex = 30;
            this.btnXoaKV.Text = "Xóa";
            this.btnXoaKV.Click += new System.EventHandler(this.btnXoaKV_Click);
            // 
            // dgv_listKV
            // 
            this.dgv_listKV.AllowUserToAddRows = false;
            this.dgv_listKV.AllowUserToDeleteRows = false;
            this.dgv_listKV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listKV.Location = new System.Drawing.Point(2, 33);
            this.dgv_listKV.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_listKV.Name = "dgv_listKV";
            this.dgv_listKV.ReadOnly = true;
            this.dgv_listKV.RowHeadersWidth = 51;
            this.dgv_listKV.RowTemplate.Height = 24;
            this.dgv_listKV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listKV.Size = new System.Drawing.Size(719, 313);
            this.dgv_listKV.TabIndex = 0;
            this.dgv_listKV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_listKV_RowPrePaint);
            // 
            // tb_find_KV
            // 
            this.tb_find_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_KV.Location = new System.Drawing.Point(17, 19);
            this.tb_find_KV.Margin = new System.Windows.Forms.Padding(2);
            this.tb_find_KV.Name = "tb_find_KV";
            this.tb_find_KV.Size = new System.Drawing.Size(585, 24);
            this.tb_find_KV.TabIndex = 4;
            this.tb_find_KV.TextChanged += new System.EventHandler(this.tb_find_KV_TextChanged);
            // 
            // tb_tenKV
            // 
            this.tb_tenKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_tenKV.Location = new System.Drawing.Point(519, 67);
            this.tb_tenKV.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenKV.Name = "tb_tenKV";
            this.tb_tenKV.Size = new System.Drawing.Size(223, 24);
            this.tb_tenKV.TabIndex = 12;
            // 
            // tb_idKV
            // 
            this.tb_idKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_idKV.Location = new System.Drawing.Point(144, 67);
            this.tb_idKV.Margin = new System.Windows.Forms.Padding(2);
            this.tb_idKV.Name = "tb_idKV";
            this.tb_idKV.Size = new System.Drawing.Size(215, 24);
            this.tb_idKV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(390, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khu vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khu vực:";
            // 
            // btnThemKV
            // 
            this.btnThemKV.AutoRoundedCorners = true;
            this.btnThemKV.BorderRadius = 17;
            this.btnThemKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemKV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnThemKV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKV.ForeColor = System.Drawing.Color.Black;
            this.btnThemKV.Location = new System.Drawing.Point(51, 488);
            this.btnThemKV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKV.Name = "btnThemKV";
            this.btnThemKV.Size = new System.Drawing.Size(112, 36);
            this.btnThemKV.TabIndex = 28;
            this.btnThemKV.Text = "Thêm";
            this.btnThemKV.Click += new System.EventHandler(this.btnThemKV_Click);
            // 
            // btnCapNhatKV
            // 
            this.btnCapNhatKV.AutoRoundedCorners = true;
            this.btnCapNhatKV.BorderRadius = 17;
            this.btnCapNhatKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatKV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnCapNhatKV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatKV.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatKV.Location = new System.Drawing.Point(230, 488);
            this.btnCapNhatKV.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhatKV.Name = "btnCapNhatKV";
            this.btnCapNhatKV.Size = new System.Drawing.Size(112, 36);
            this.btnCapNhatKV.TabIndex = 29;
            this.btnCapNhatKV.Text = "Cập nhật";
            this.btnCapNhatKV.Click += new System.EventHandler(this.btnCapNhatKV_Click);
            // 
            // btnTimKiemKV
            // 
            this.btnTimKiemKV.AutoRoundedCorners = true;
            this.btnTimKiemKV.BorderRadius = 17;
            this.btnTimKiemKV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemKV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemKV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemKV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemKV.FillColor = System.Drawing.Color.LightSalmon;
            this.btnTimKiemKV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemKV.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemKV.Location = new System.Drawing.Point(606, 11);
            this.btnTimKiemKV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemKV.Name = "btnTimKiemKV";
            this.btnTimKiemKV.Size = new System.Drawing.Size(112, 36);
            this.btnTimKiemKV.TabIndex = 32;
            this.btnTimKiemKV.Text = "Tìm kiếm ";
            this.btnTimKiemKV.Click += new System.EventHandler(this.btnTimKiemKV_Click);
            // 
            // KHUVUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(754, 537);
            this.Controls.Add(this.btnTimKiemKV);
            this.Controls.Add(this.btnThoatKV);
            this.Controls.Add(this.tb_tenKV);
            this.Controls.Add(this.btnXoaKV);
            this.Controls.Add(this.tb_idKV);
            this.Controls.Add(this.btnCapNhatKV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemKV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_find_KV);
            this.Controls.Add(this.gb_listBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KHUVUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHU VỰC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KHUVUC_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listKV;
        private System.Windows.Forms.TextBox tb_find_KV;
        private System.Windows.Forms.TextBox tb_tenKV;
        private System.Windows.Forms.TextBox tb_idKV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThemKV;
        private Guna.UI2.WinForms.Guna2Button btnThoatKV;
        private Guna.UI2.WinForms.Guna2Button btnXoaKV;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatKV;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemKV;
    }
}