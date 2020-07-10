﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace BTLCK_n1
{
    public partial class FrmTimKiemHang : Form
    {
        public FrmTimKiemHang()
        {
            InitializeComponent();
        }

        private void FrmTimKiemHang_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {

            string sql = "select * from DM_HANG_HOA";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable DM_HANG_HOA = new DataTable();
            adp.Fill(DM_HANG_HOA);
            dgvTKhang.DataSource = DM_HANG_HOA;

        }

        private void dgvTKhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManhom.Text = dgvTKhang.CurrentRow.Cells["MANHOM"].Value.ToString();
            txtMachatlieu.Text = dgvTKhang.CurrentRow.Cells["MACHATLIEU"].Value.ToString();

            txtMacongdung.Text = dgvTKhang.CurrentRow.Cells["MACONGDUNG"].Value.ToString();

            txtManhom.Enabled = false;
        }

        private void ResetValues()
        {
            txtManhom.Text = "";
            txtMachatlieu.Text = "";
            txtMacongdung.Text = "";

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }
        private void hienthitimkiem()
        {
            string sql = "select * from DM_HANG_HOA where MANHOM like '%" + txtTukhoa.Text +
                "%' or MACHATLIEU like '%" + txtTukhoa.Text +
                "%' or MACONGDUNG like '%" + txtTukhoa.Text + "%' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable DM_HANG_HOA = new DataTable();
            adp.Fill(DM_HANG_HOA);
            dgvTKhang.DataSource = DM_HANG_HOA;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKhang.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
