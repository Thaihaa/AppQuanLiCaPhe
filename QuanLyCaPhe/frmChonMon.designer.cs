namespace QuanLyCaPhe
{
    partial class frmChonThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonThucDon));
            this.btnHuyChon = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonMon = new Guna.UI2.WinForms.Guna2Button();
            this.gridThucDon = new System.Windows.Forms.DataGridView();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.AutoRoundedCorners = true;
            this.btnHuyChon.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyChon.BorderRadius = 22;
            this.btnHuyChon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyChon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyChon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyChon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyChon.FillColor = System.Drawing.Color.LightSalmon;
            this.btnHuyChon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyChon.ForeColor = System.Drawing.Color.Black;
            this.btnHuyChon.Location = new System.Drawing.Point(499, 528);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(210, 47);
            this.btnHuyChon.TabIndex = 27;
            this.btnHuyChon.Text = "Hủy chọn";
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // btnChonMon
            // 
            this.btnChonMon.AutoRoundedCorners = true;
            this.btnChonMon.BackColor = System.Drawing.Color.Transparent;
            this.btnChonMon.BorderRadius = 22;
            this.btnChonMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonMon.FillColor = System.Drawing.Color.LightSalmon;
            this.btnChonMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonMon.ForeColor = System.Drawing.Color.Black;
            this.btnChonMon.Location = new System.Drawing.Point(154, 528);
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.Size = new System.Drawing.Size(210, 47);
            this.btnChonMon.TabIndex = 26;
            this.btnChonMon.Text = "Chọn món và đóng";
            this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
            // 
            // gridThucDon
            // 
            this.gridThucDon.AllowUserToAddRows = false;
            this.gridThucDon.AllowUserToDeleteRows = false;
            this.gridThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThucDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucDon,
            this.TenThucDon,
            this.Gia});
            this.gridThucDon.Location = new System.Drawing.Point(22, 71);
            this.gridThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridThucDon.Name = "gridThucDon";
            this.gridThucDon.ReadOnly = true;
            this.gridThucDon.RowHeadersWidth = 51;
            this.gridThucDon.RowTemplate.Height = 24;
            this.gridThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridThucDon.Size = new System.Drawing.Size(828, 431);
            this.gridThucDon.TabIndex = 1;
            // 
            // MaThucDon
            // 
            this.MaThucDon.HeaderText = "Mã thực đơn";
            this.MaThucDon.MinimumWidth = 6;
            this.MaThucDon.Name = "MaThucDon";
            this.MaThucDon.ReadOnly = true;
            this.MaThucDon.Width = 150;
            // 
            // TenThucDon
            // 
            this.TenThucDon.HeaderText = "Tên thực đơn";
            this.TenThucDon.MinimumWidth = 6;
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.ReadOnly = true;
            this.TenThucDon.Width = 250;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá ";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 150;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(746, -1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 31;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(786, -1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 32;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(826, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 33;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thực đơn";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmChonThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnChonMon);
            this.Controls.Add(this.gridThucDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChonThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn thực đơn";
            ((System.ComponentModel.ISupportInitialize)(this.gridThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private Guna.UI2.WinForms.Guna2Button btnChonMon;
        private Guna.UI2.WinForms.Guna2Button btnHuyChon;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}