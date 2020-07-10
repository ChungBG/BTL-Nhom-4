
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Windows;


namespace BTLCK_n1
{
    public partial class FrmBaoCaoHDB : Form
    {
        public FrmBaoCaoHDB()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoHDB_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = " select * from HOA_DON_BAN";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_BAN = new DataTable();
            adp.Fill(HOA_DON_BAN);
            dgvBCHDN.DataSource = HOA_DON_BAN;
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql = "select * from HOA_DON_BAN where MANV = '" + txtMaNV.Text + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_BAN = new DataTable();
            adp.Fill(HOA_DON_BAN);
            dgvBCHDN.DataSource = HOA_DON_BAN;
        }

        private void dgvBCHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvBCHDN.CurrentRow.Cells["MANV"].Value.ToString();
        }
    }
}
