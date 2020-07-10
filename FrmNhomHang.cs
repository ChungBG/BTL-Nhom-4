using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BTLCK_n1
{
    public partial class FrmNhomHang : Form
    {
        DataTable NHOM_HANG;
        public FrmNhomHang()
        {
            InitializeComponent();
        }

        private void FrmNhomHang_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void hienthi()
        {

            string sql = "select * from NHOM_HANG";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable NHOM_HANG = new DataTable();
            adp.Fill(NHOM_HANG);
            dgvNhomhang.DataSource = NHOM_HANG;
        }

        private void dgvNhomhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManhom.Text = dgvNhomhang.CurrentRow.Cells["MANHOM"].Value.ToString();
            txtTennhom.Text = dgvNhomhang.CurrentRow.Cells["TENNHOM"].Value.ToString();

            txtManhom.Enabled = false;
        }

        private void ResetValue()
        {
            txtManhom.Text = "";
            txtTennhom.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtManhom.Enabled = true; //cho phép nhập mới
            txtManhom.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhom.Focus();
                return;
            }
            if (txtTennhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhom.Focus();
                return;
            }

            sql = "SELECT MANHOM FROM NHOM_HANG WHERE MANHOM =N'" +
txtManhom.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã nhóm  này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhom.Focus();
                txtManhom.Text = "";
                return;
            }
            sql = "INSERT INTO NHOM_HANG(MANHOM,TENNHOM) VALUES(N'" + txtManhom.Text + "',N'" + txtTennhom.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhom.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHOM_HANG";
            NHOM_HANG = DAO.GetDataToTable(sql1);
            string sql;
            if (NHOM_HANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtManhom.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTennhom.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhóm", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTennhom.Focus();
                    return;
                }

            }
            sql = "UPDATE NHOM_HANG SET TENNHOM=N'" + txtTennhom.Text.ToString() + "' WHERE MANHOM=N'" + txtManhom.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHOM_HANG";
            NHOM_HANG = DAO.GetDataToTable(sql1);
            string sql;
            if (NHOM_HANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtManhom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NHOM_HANG WHERE MANHOM=N'" + txtManhom.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhom.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
