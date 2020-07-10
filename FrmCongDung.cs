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
    public partial class FrmCongDung : Form
    {
        DataTable CONG_DUNG;
        public FrmCongDung()
        {
            InitializeComponent();
        }

        private void FrmCongDung_Load(object sender, EventArgs e)
        {

            DAO.connect();
            hienthi();
        }

        private void hienthi()
        {

            string sql = "select * from CONG_DUNG";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable CONG_DUNG = new DataTable();
            adp.Fill(CONG_DUNG);
            dgvCongdung.DataSource = CONG_DUNG;
        }

        private void dgvCongdung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMacongdung.Text = dgvCongdung.CurrentRow.Cells["MACONGDUNG"].Value.ToString();
            txtTencongdung.Text = dgvCongdung.CurrentRow.Cells["TENCONGDUNG"].Value.ToString();

            txtMacongdung.Enabled = false;
        }

        private void ResetValue()
        {
            txtMacongdung.Text = "";
            txtTencongdung.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMacongdung.Enabled = true; //cho phép nhập mới
            txtMacongdung.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công dụng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacongdung.Focus();
                return;
            }
            if (txtTencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTencongdung.Focus();
                return;
            }

            sql = "SELECT MACONGDUNG FROM CONG_DUNG WHERE MACONGDUNG =N'" +
 txtMacongdung.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMacongdung.Focus();
                txtMacongdung.Text = "";
                return;
            }
            sql = "INSERT INTO CONG_DUNG(MACONGDUNG,TENCONGDUNG) VALUES(N'" + txtMacongdung.Text + "',N'" + txtTencongdung.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMacongdung.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CONG_DUNG";
            CONG_DUNG = DAO.GetDataToTable(sql1);
            string sql;
            if (CONG_DUNG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtMacongdung.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTencongdung.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTencongdung.Focus();
                    return;
                }

            }
            sql = "UPDATE CONG_DUNG SET TENCONGDUNG=N'" + txtTencongdung.Text.ToString() + "' WHERE MACONGDUNG=N'" + txtMacongdung.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CONG_DUNG";
            CONG_DUNG = DAO.GetDataToTable(sql1);
            string sql;
            if (CONG_DUNG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE CONG_DUNG WHERE MACONGDUNG=N'" + txtMacongdung.Text + "'";
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
            txtMacongdung.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
