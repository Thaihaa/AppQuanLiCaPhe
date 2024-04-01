namespace QuanLyCaPhe
{
    partial class frmChinhSuaThucDon
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
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenThucDon = new System.Windows.Forms.Label();
            this.btnLuuTD = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatTD = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(127, 73);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(152, 20);
            this.txtSoLuong.TabIndex = 0;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(127, 103);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(318, 78);
            this.txtGhiChu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chỉnh sửa thực đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên thực đơn:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTenThucDon
            // 
            this.lbTenThucDon.AutoSize = true;
            this.lbTenThucDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThucDon.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTenThucDon.Location = new System.Drawing.Point(124, 45);
            this.lbTenThucDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenThucDon.Name = "lbTenThucDon";
            this.lbTenThucDon.Size = new System.Drawing.Size(0, 17);
            this.lbTenThucDon.TabIndex = 8;
            // 
            // btnLuuTD
            // 
            this.btnLuuTD.AutoRoundedCorners = true;
            this.btnLuuTD.BorderRadius = 18;
            this.btnLuuTD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTD.FillColor = System.Drawing.Color.DarkOrange;
            this.btnLuuTD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuTD.ForeColor = System.Drawing.Color.Black;
            this.btnLuuTD.Location = new System.Drawing.Point(63, 212);
            this.btnLuuTD.Name = "btnLuuTD";
            this.btnLuuTD.Size = new System.Drawing.Size(120, 38);
            this.btnLuuTD.TabIndex = 26;
            this.btnLuuTD.Text = "Lưu và đóng";
            this.btnLuuTD.Click += new System.EventHandler(this.btnLuuTD_Click);
            // 
            // btnThoatTD
            // 
            this.btnThoatTD.AutoRoundedCorners = true;
            this.btnThoatTD.BorderRadius = 18;
            this.btnThoatTD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatTD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatTD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatTD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatTD.FillColor = System.Drawing.Color.DarkOrange;
            this.btnThoatTD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatTD.ForeColor = System.Drawing.Color.Black;
            this.btnThoatTD.Location = new System.Drawing.Point(281, 212);
            this.btnThoatTD.Name = "btnThoatTD";
            this.btnThoatTD.Size = new System.Drawing.Size(120, 38);
            this.btnThoatTD.TabIndex = 27;
            this.btnThoatTD.Text = "Thoát";
            this.btnThoatTD.Click += new System.EventHandler(this.btnThoatTD_Click);
            // 
            // frmChinhSuaThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.btnThoatTD);
            this.Controls.Add(this.btnLuuTD);
            this.Controls.Add(this.lbTenThucDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtSoLuong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChinhSuaThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thực đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTenThucDon;
        private Guna.UI2.WinForms.Guna2Button btnLuuTD;
        private Guna.UI2.WinForms.Guna2Button btnThoatTD;
    }
}