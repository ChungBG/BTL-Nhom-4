using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BTLCK_n1
{
    public partial class FrmTimHDNhap : Form
    {
        DataTable HOA_DON_NHAP;
        public FrmTimHDNhap()
        {
            InitializeComponent();
        }
        private void hienthi()
        {

            string sql = "select * from HOA_DON_NHAP";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_NHAP = new DataTable();
            adp.Fill(HOA_DON_NHAP);
            dgvTKHoaDonNhap.DataSource = HOA_DON_NHAP;
        }

        private void FrmTimHDNhap_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();

        }

        private void dgvTKHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtsoHDN.Text = dgvTKHoaDonNhap.CurrentRow.Cells["SOHDN"].Value.ToString();
            cboMaNV.Text = dgvTKHoaDonNhap.CurrentRow.Cells["MANV"].Value.ToString();
            txtNgaynhap.Text = dgvTKHoaDonNhap.CurrentRow.Cells["NGAYNHAP"].Value.ToString();
            cboMaNCC.Text = dgvTKHoaDonNhap.CurrentRow.Cells["MANCC"].Value.ToString();

            txtsoHDN.Enabled = false;

        }

        private void ResetValues()
        {
            txtsoHDN.Text = "";
            cboMaNV.Text = "";
            txtNgaynhap.Text = "";
            cboMaNCC.Text = "";

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
System.Windows.Forms.DialogResult.Yes)
                Application.Exit();

        }
        private void hienthitimkiem()
        {
            string sql = "select * from HOA_DON_NHAP where SOHDN like '%" + txtTukhoa.Text +
                "%' or MANV like '%" + txtTukhoa.Text + "%' or NGAYNHAP like '%" + txtTukhoa.Text +
                "%' or MANCC like '%" + txtTukhoa.Text + "%' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_NHAP = new DataTable();
            adp.Fill(HOA_DON_NHAP);
            dgvTKHoaDonNhap.DataSource = HOA_DON_NHAP;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKHoaDonNhap.DataSource = null;

        }

    }
}
