using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class frmChonThucDon : Form
    {
        SqlConnection conn;
 
        bool _chon = false;
        public frmChonThucDon()
        {
            InitializeComponent();
            LoadGrid("");
        }

        public void LoadGrid(string tukhoa)
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();

            gridThucDon.Rows.Clear();
            string sql = "SELECT MaThucDon, TenThucDon, Gia FROM dbo.THUCDON WHERE MaThucDon LIKE N'%" + tukhoa + "%' OR TenThucDon LIKE N'%" + tukhoa + "%' OR Gia LIKE N'%" + tukhoa + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int i = gridThucDon.Rows.Add();
                DataGridViewRow drr = gridThucDon.Rows[i];
                drr.Cells["MaThucDon"].Value = dr["MaThucDon"];
                drr.Cells["TenThucDon"].Value = dr["TenThucDon"];
                drr.Cells["Gia"].Value = dr["Gia"];
            }
            dr.Close();

        }

        public DataGridView grid
        {
            get { return gridThucDon; }
            set { gridThucDon = value; }

        }
        public bool chon
        {
            get { return _chon; }
            set { _chon = value; }
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            chon = true;
            Close();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
