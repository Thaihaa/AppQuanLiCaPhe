﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class QLBH : Form
    {
        Guid _MaHD = Guid.Empty;
        string MaBan = "", MaKhuVuc = "";
        SqlConnection conn;
        List<Button> DSBan = new List<Button>();

        List<Button> DSKhuVuc = new List<Button>();
        public QLBH()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();
            dateNgayVao.Format = DateTimePickerFormat.Custom;
            dateNgayVao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            LoadKhuVuc();
            //Chọn khu vực đầu tiên
            DSKhuVuc[0].PerformClick();

            XoaTrong();
        }
        void LoadKhuVuc()
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LayTatCaKhuVuc";
            cmd.Connection = conn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //tạo khu vực theo csdl
                Button button = new Button();
                button.Text = dr["TenKhuVuc"].ToString();
                button.Name = dr["MaKhuVuc"].ToString();
                button.BackColor = Color.FromArgb(226, 171, 60);
                button.Margin = new Padding(0);
                button.Height = 50;
                button.Width = 175;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Black;
                button.Font = new Font("Bahnschrift", 18, FontStyle.Regular);
                //sự kiện cho button
                button.Click += KhuVuc_Click;

                DSKhuVuc.Add(button);// thêm vô list để In đậm nút khi nhấn vô
                panelKhuVuc.Controls.Add(button);// thêm vô panel để hiển thị

            }

            dr.Close();
            conn.Close();

        }
        void KhuVuc_Click(object sender, EventArgs e)
        {
            Button khuvuc = (Button)sender;
            foreach (Button btn in DSKhuVuc)
            {
                // nút nào giống nút vừa click -> đổi màu
                if (btn == khuvuc)
                {
                    btn.BackColor = Color.FromArgb(246, 218, 142);
                    btn.Font = new Font("Bahnschrift", 18, FontStyle.Bold);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(246, 218, 142);
                    btn.Font = new Font("Bahnschrift", 15, FontStyle.Regular);

                }

            }
            MaKhuVuc = khuvuc.Name;
            LoadBan(khuvuc.Name);
            DSBan[0].PerformClick();// click vô bàn đầu tiên
        }
        public void LoadBan(string MaKhuVuc)
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LayDanhSachBan";
            cmd.Parameters.AddWithValue("@MaKhuVuc", MaKhuVuc);

            SqlDataReader dr = cmd.ExecuteReader();
            panelBan.Controls.Clear();
            while (dr.Read())
            {
                Button ban = new Button();
                ban.Text = dr["TenBan"].ToString();
                ban.TextAlign = ContentAlignment.BottomCenter;
                ban.Height = 100;
                ban.Width = 175;
                ban.Margin = Padding.Empty;
                ban.Font = new Font("Tahoma", 12, FontStyle.Regular);
                ban.ImageAlign = ContentAlignment.TopCenter;
                ban.Name = dr["MaBan"].ToString();
                ban.Click += Ban_Click;
                if(dr["DaThanhToan"].ToString() == "False")
                {
                    ban.Image = Properties.Resources.BanCoKhach;
                }
                else
                {
                    ban.Image = Properties.Resources.BanTrong;
                }
                panelBan.Controls.Add(ban);
                DSBan.Add(ban);

            }
            dr.Close();

            conn.Close();

        }


        void Ban_Click(object sender, EventArgs e)
        {
            XoaTrong();
            Button ban = (Button)sender;
            lblBan.Text = "Bàn số "+ban.Text;
            MaBan = ban.Name;
            string sql = "SELECT TOP 1 MaHD FROM dbo.HOADON WHERE MaBan = '" + MaBan + "' ORDER BY NgayVao DESC";
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object _ban = cmd.ExecuteScalar();
            try
            {
                if(_ban != null)
                {
                    _MaHD = Guid.Parse(_ban.ToString());
                    string sql2 = "SELECT * FROM dbo.HOADON WHERE MaHD = '" + _MaHD + "'";
                    SqlConnection conn2 = new SqlConnection(DB.ConnectString);
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                    SqlDataReader _dr = cmd2.ExecuteReader();
                    _dr.Read();
                    for (int i = 0; i < cbNV.Items.Count; i++)
                    {
                        if (_dr["MaNV"].ToString() == cbNV.GetItemText(cbNV.Items[i]))
                        {
                            cbNV.SelectedIndex = i;
                            break;
                        }
                    }
                    for (int i = 0; i < cbKH.Items.Count; i++)
                    {
                        if (_dr["MaKH"].ToString() == cbKH.GetItemText(cbKH.Items[i]))
                        {
                            cbKH.SelectedIndex = i;
                            break;
                        }
                    }
                    //dateNgayVao.Value = DateTime.ParseExact(_dr["NgayVao"].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.CurrentCulture);
                    _dr.Close();
                    conn.Close();
                }
                else
                    _MaHD = Guid.Empty;

            }
            catch (Exception)
            {
                _MaHD = Guid.Empty;
            }




            LoadGrid();
        }

        public void LoadKhachHang()
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            string sql = "SELECT MaKH, TenKH, DiaChi, SDT, Email, MaLKH FROM dbo.KHACHHANG";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds, "KHACHHANG");
            cbKH.DataSource = ds.Tables["KHACHHANG"];
            cbKH.DisplayMember = "TenKH";
            cbKH.ValueMember = "MaKH";
            conn.Close();
        }
        public void LoadNhanVien()
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            string sql = "SELECT MaNV, TenNV, DiaChi, SDT, Email FROM dbo.NHANVIEN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dap.Fill(ds, "NV");
            cbNV.DataSource = ds.Tables["NV"];
            cbNV.DisplayMember = "TenNV";
            cbNV.ValueMember = "MaNV";

            conn.Close();
        }
        private void LoadGrid()// load thực đơn đã chọn
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllHoaDonChiTiet";
            cmd.Parameters.AddWithValue("@MaHD", _MaHD);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvThucDon.DataSource = table;

            conn.Close();

        }

        public bool LuuHoaDon()
        {
            try
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemHoaDon";
                decimal phuthu;
                decimal giamgia;
                decimal.TryParse(txtGiamGia.Text, out giamgia);
                decimal.TryParse(txtPhuThu.Text, out phuthu);
                cmd.Parameters.AddWithValue("@NgayVao", dateNgayVao.Value);
                cmd.Parameters.AddWithValue("@MaKH", cbKH.SelectedValue);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.SelectedValue);
                cmd.Parameters.AddWithValue("@PhuThu", phuthu);
                cmd.Parameters.AddWithValue("@PhuThuTheoPhanTram", cbPhuThu.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@GiamGia", giamgia);
                cmd.Parameters.AddWithValue("@GiamGiaTheoPhanTram", cbGiamGia.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@MaBan", MaBan);

                _MaHD = Guid.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            frmChonThucDon frmChonMon = new frmChonThucDon();
            frmChonMon.ShowDialog();

            if (frmChonMon.chon)
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayHoaDonMoiNhat";
                cmd.Parameters.AddWithValue("@MaBan", MaBan);
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    LuuHoaDon();
                    LoadBan(MaKhuVuc);
                }
                else
                {
                    dr.Read();
                    if (dr["DaThanhToan"].ToString() == "True")
                    {
                        LuuHoaDon();
                        LoadBan(MaKhuVuc);
                    }
                }
                dr.Close();
                conn.Close();

                for (int i = 0; i < frmChonMon.grid.SelectedRows.Count; i++)
                {
                    var cl = frmChonMon.grid.SelectedRows[i].Cells;

                    conn = new SqlConnection(DB.ConnectString);
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "LuuHoaDonChiTiet";
                    cmd1.Parameters.AddWithValue("@Loai", "them");
                    cmd1.Parameters.AddWithValue("@MaHDCT", Guid.Empty.ToString());
                    cmd1.Parameters.AddWithValue("@MaHD", _MaHD.ToString());
                    cmd1.Parameters.AddWithValue("@MaThucDon", cl["MaThucDon"].Value.ToString());
                    cmd1.Parameters.AddWithValue("@SoLuong", 1);
                    cmd1.Parameters.AddWithValue("@GhiChu", "");
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                }
                txtThanhTien.Text = TinhThanhTien().ToString();
                LoadGrid();

                conn.Close();
            }
        }


            


        private void dgvThucDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThucDon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        public int TinhThanhTien()
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dgvThucDon.Rows.Count; i++)
                {   
                    if (dgvThucDon.Rows[i].Cells["SoLuong"].Value != null && dgvThucDon.Rows[i].Cells["DonGia"].Value != null)
                    {
                        int DonGia, SoLuong;

                        int.TryParse(dgvThucDon.Rows[i].Cells["DonGia"].Value.ToString(), out DonGia);
                        int.TryParse(dgvThucDon.Rows[i].Cells["SoLuong"].Value.ToString(), out SoLuong);

                        sum += DonGia * SoLuong;
                    }

                }
                if (txtGiamGia.Text != "")
                {
                    int giamgia = Int32.Parse(txtGiamGia.Text);
                    if (cbGiamGia.Text == "Phần trăm (%)")
                    {
                        sum = sum - (sum * giamgia / 100);
                    }
                    else
                    {
                        sum = sum - giamgia;
                    }
                }
                if (txtPhuThu.Text != ""){
                    int phuthu = Int32.Parse(txtPhuThu.Text);
                    if (cbPhuThu.Text == "Phần trăm (%)")
                    {
                        sum = sum + (sum * phuthu / 100);
                    }
                    else
                    {
                        sum = sum + phuthu;
                    }
                }


                return sum;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }
        
        private void dgvThucDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtThanhTien.Text = TinhThanhTien().ToString();

        }
        

        private void nhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TinhTien(object sender, EventArgs e)
        {
            txtThanhTien.Text = TinhThanhTien().ToString();

        }

        private void ChinhSuaMon()
        {
            try
            {
                frmChinhSuaThucDon frmChinhSuaThucDon = new frmChinhSuaThucDon();
                frmChinhSuaThucDon.SetSoLuong(dgvThucDon.SelectedRows[0].Cells["SoLuong"].Value);
                frmChinhSuaThucDon.SetGhiChu(dgvThucDon.SelectedRows[0].Cells["GhiChu"].Value);
                frmChinhSuaThucDon.SetTenThucDon(dgvThucDon.SelectedRows[0].Cells["TenThucDon"].Value);
                frmChinhSuaThucDon.ShowDialog();
                if (frmChinhSuaThucDon.luu)
                {
                    conn = new SqlConnection(DB.ConnectString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SuaHoaDonChiTiet";
                    cmd.Parameters.AddWithValue("@MaHDCT", Guid.Parse(dgvThucDon.SelectedRows[0].Cells["MaHDCT"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@SoLuong", frmChinhSuaThucDon.SoLuong());
                    cmd.Parameters.AddWithValue("@GhiChu", frmChinhSuaThucDon.GhiChu());
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    txtThanhTien.Text = TinhThanhTien().ToString();
                }
                LoadGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công.");
            }

        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ChinhSuaMon();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaHoaDon";
                cmd.Parameters.AddWithValue("@MaHD", _MaHD);
                cmd.Parameters.AddWithValue("@NgayVao", dateNgayVao.Value);
                cmd.Parameters.AddWithValue("@MaKH", cbKH.SelectedValue);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.SelectedValue);
                cmd.Parameters.AddWithValue("@PhuThu", txtPhuThu.Text);
                cmd.Parameters.AddWithValue("@PhuThuTheoPhanTram", cbPhuThu.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@GiamGia", txtGiamGia.Text);
                cmd.Parameters.AddWithValue("@GiamGiaTheoPhanTram", cbGiamGia.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@NgayThanhToan", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
                cmd.Parameters.AddWithValue("@DaThanhToan", 1);
                cmd.Parameters.AddWithValue("@MaBan", MaBan);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();


                LoadBan(MaKhuVuc);
                LoadGrid();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaHoaDon";
                cmd.Parameters.AddWithValue("@MaHD", _MaHD);
                cmd.Parameters.AddWithValue("@NgayVao", dateNgayVao.Value);
                cmd.Parameters.AddWithValue("@MaKH", cbKH.SelectedValue);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.SelectedValue);
                cmd.Parameters.AddWithValue("@PhuThu", txtPhuThu.Text);
                cmd.Parameters.AddWithValue("@PhuThuTheoPhanTram", cbPhuThu.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@GiamGia", txtGiamGia.Text);
                cmd.Parameters.AddWithValue("@GiamGiaTheoPhanTram", cbGiamGia.Text == "Phần trăm (%)");
                cmd.Parameters.AddWithValue("@NgayThanhToan", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
                cmd.Parameters.AddWithValue("@DaThanhToan", 1);
                cmd.Parameters.AddWithValue("@MaBan", MaBan);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();


                LoadBan(MaKhuVuc);
                LoadGrid();                

            }
        }

        private void XoaTrong()
        {
            dateNgayVao.Value = DateTime.Now;
            txtGiamGia.Text = "0";
            txtPhuThu.Text = "0";
            cbGiamGia.SelectedIndex = 0;
            cbPhuThu.SelectedIndex = 0;
            cbKH.SelectedIndex = 0;
            cbNV.SelectedIndex = 0;
            txtThanhTien.Text = "0";
            for(int i = 0; i < cbNV.Items.Count; i++)
            {
                if(User.TenNV == cbNV.GetItemText(cbNV.Items[i]))
                {
                    cbNV.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < cbKH.Items.Count; i++)
            {
                if (User.TenKH == cbKH.GetItemText(cbKH.Items[i]))
                {
                    cbKH.SelectedIndex = i;
                    break;
                }
            }
        }
        private void báoBáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void dgvThucDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChinhSuaMon();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMenu qLMenu = new QLMenu();
            qLMenu.Show();
        }

        private void lịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_LichLam form_LichLam = new Form_LichLam();
            form_LichLam.Show();
        }

        private void caLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ca form_Ca = new Form_Ca();
            form_Ca.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BAN bAN = new BAN();
            bAN.Show();
        }

        private void khuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KHUVUC khuvuc = new KHUVUC();
            khuvuc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHANVIEN nHANVIEN = new NHANVIEN();
            nHANVIEN.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void lươngThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TinhLuong form_TinhLuong = new Form_TinhLuong();
            form_TinhLuong.Show();
        }

        private void btnChinhSua_Click_1(object sender, EventArgs e)
        {
            ChinhSuaMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int count = dgvThucDon.SelectedRows.Count;
                for (int i = 0; i < count; i++)
                {
                    conn = new SqlConnection(DB.ConnectString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "XoaHoaDonChiTiet";
                    cmd.Parameters.AddWithValue("@MaHDCT", Guid.Parse(dgvThucDon.SelectedRows[0].Cells["MaHDCT"].Value.ToString()));
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadGrid();
                txtThanhTien.Text = TinhThanhTien().ToString();
            }
        }

        private void panelKhuVuc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHoaDon";
                cmd.Parameters.AddWithValue("@MaHD", _MaHD);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadBan(MaKhuVuc);
                LoadGrid();

            }
        }


    }
}
