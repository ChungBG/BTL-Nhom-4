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
    public partial class FrmCT_HDNhap : Form
    {
        DataTable CHI_TIET_HD_NHAP;
        public FrmCT_HDNhap()
        {
            InitializeComponent();
        }

        private void FrmCT_HDNhap_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void hienthi()
        {

            string sql = "select * from CHI_TIET_HD_NHAP";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable CHI_TIET_HD_NHAP = new DataTable();
            adp.Fill(CHI_TIET_HD_NHAP);
            dgvCTHDNhap.DataSource = CHI_TIET_HD_NHAP;
        }

        private void dgvCTHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsoHDN.Text = dgvCTHDNhap.CurrentRow.Cells["SOHDN"].Value.ToString();
            txtMavach.Text = dgvCTHDNhap.CurrentRow.Cells["MAVACH"].Value.ToString();
            txtSoluong.Text = dgvCTHDNhap.CurrentRow.Cells["SOLUONGNHAP"].Value.ToString();
            txtDongia.Text = dgvCTHDNhap.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtGiamgia.Text = dgvCTHDNhap.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtsoHDN.Enabled = false;
        }
        private void ResetValues()
        {
            txtsoHDN.Text = "";
            txtMavach.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            txtThanhtien.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CHI_TIET_HD_NHAP";
            CHI_TIET_HD_NHAP = DAO.GetDataToTable(sql1);
            string sql;


            if (CHI_TIET_HD_NHAP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (txtsoHDN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM CHI_TIET_HD_NHAP WHERE SOHDN =N'" + txtsoHDN.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.con;
                cmd.ExecuteNonQuery();
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon;
            sql = "SELECT SOHDN FROM HOA_DON_NHAP WHERE SOHDN=N'" + txtsoHDN.Text + "'";
            if (DAO.CheckKey(sql))
            {
                if (txtsoHDN.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số HDN", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoHDN.Focus();
                    return;
                }
                if (txtMavach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã vạch", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMavach.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
                if (txtDongia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDongia.Focus();
                    return;
                }
                if (txtGiamgia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamgia.Focus();
                    return;
                }




                sql = "SELECT SOHDN FROM CHI_TIET_HD_NHAP  WHERE SOHDN =N'" +
                txtsoHDN.Text.Trim() + "'";
                if (DAO.CheckKey(sql))
                {
                    MessageBox.Show("số HDN này đã có, bạn phải nhập số HDN khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsoHDN.Focus();
                    txtsoHDN.Text = "";
                    return;
                }


                sql = "INSERT INTO CHI_TIET_HD_NHAP(SOHDN,MAVACH,SOLUONG,DONGIA,GIAMGIA,THANHTIEN) VALUES(N'" + txtsoHDN.Text + "',N'" + txtMavach.Text + "',N'"
                   + txtSoluong.Text + "',N'" + txtDongia.Text + "',N'" + txtGiamgia.Text + "',N'" + txtThanhtien.Text + "')";
                DAO.RunSQL(sql);
            }
            // Câu 1: Cập nhật lại số lượng của mặt hàng vào bảng DM_HANG_HOA
            sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SOLUONG FROM DM_HANG_HOA WHERE MAVACH = N'" + txtMavach.Text + "'"));
            SLcon = sl + Convert.ToDouble(txtSoluong.Text);
            sql = "UPDATE DM_HANG_HOA SET SOLUONG =" + SLcon + " WHERE MAVACH= N'" + txtMavach.Text + "'";
            DAO.RunSQL(sql);
            ResetValues();
            btnXoa.Enabled = true;

            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtsoHDN.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CHI_TIET_HD_NHAP";
            CHI_TIET_HD_NHAP = DAO.GetDataToTable(sql1);
            string sql;
            if (CHI_TIET_HD_NHAP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtsoHDN.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMavach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã vạch", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMavach.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
                if (txtDongia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDongia.Focus();
                    return;
                }
                if (txtGiamgia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamgia.Focus();
                    return;
                }
                if (txtThanhtien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thành tiền", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtThanhtien.Focus();
                    return;

                }
                sql = "UPDATE CHI_TIET_HD_NHAP SET MAVACH=N'" + txtMavach.Text.ToString() + "',SOLUONGNHAP=N'" + txtSoluong.Text.ToString()
                    + "',DONGIA=N'" + txtDongia.Text.ToString() + "',GIAMGIA=N'" + txtGiamgia.Text.ToString() + "',THANHTIEN=N'" + txtThanhtien.Text.ToString() + "' WHERE SOHDN=N'" + txtsoHDN.Text + "'";
                DAO.RunSQL(sql);
                hienthi();
                ResetValues();
                btnBoqua.Enabled = false;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
         System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtsoHDN.Enabled = false;
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamgia.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {

            double dg = Convert.ToDouble(DAO.Docbang("SELECT DONGIANHAP FROM DM_HANG_HOA WHERE MAVACH = N'" + txtMavach.Text + "'").Rows[0][0].ToString());
            double gnmoi = dg + Convert.ToDouble(txtDongia.Text);
            string sql;
            sql = "UPDATE DM_HANG_HOA SET DONGIANHAP=" + gnmoi + "WHERE MAVACH = N'" + txtMavach.Text + "'";
            DAO.RunSQL(sql);

        }


    }
}
