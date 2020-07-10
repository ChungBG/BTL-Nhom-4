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
    public partial class FrmNhacungcap : Form
    {
        DataTable NHA_CUNG_CAP;
        public FrmNhacungcap()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            string sql = "select * from NHA_CUNG_CAP";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable NHA_CUNG_CAP = new DataTable();
            adp.Fill(NHA_CUNG_CAP);
            dgvNhacungcap.DataSource = NHA_CUNG_CAP;
        }
        private void FrmNhacungcap_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void dgvNhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaNCC.Text = dgvNhacungcap.CurrentRow.Cells["MANCC"].Value.ToString();
            txtTenNCC.Text = dgvNhacungcap.CurrentRow.Cells["TENNCC"].Value.ToString();
            txtDiachi.Text = dgvNhacungcap.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtMaNCC.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimkiem.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return;
            }

            sql = "SELECT MANCC FROM NHA_CUNG_CAP WHERE MANCC =N'" +
txtMaNCC.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                txtMaNCC.Text = "";
                return;
            }
            sql = "INSERT INTO NHA_CUNG_CAP(MANCC,TENNCC,DIACHI,DIENTHOAI) VALUES(N'" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'"
                + txtDiachi.Text + "',N'" + txtDienThoai.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnTimkiem.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNCC.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHA_CUNG_CAP";
            NHA_CUNG_CAP = DAO.GetDataToTable(sql1);
            string sql;
            if (NHA_CUNG_CAP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNCC.Focus();
                    return;
                }
                if (txtDiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNCC.Focus();
                    return;
                }
                if (txtDienThoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNCC.Focus();
                    return;
                }
            }
            sql = "UPDATE NHA_CUNG_CAP SET TENNCC=N'" + txtTenNCC.Text.ToString() + "',DIACHI=N'" + txtDiachi.Text.ToString()
                + "',DIENTHOAI=N'" + txtDienThoai.Text.ToString() + "' WHERE MANCC=N'" + txtMaNCC.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnTimkiem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHA_CUNG_CAP";
            NHA_CUNG_CAP = DAO.GetDataToTable(sql1);
            string sql;
            if (NHA_CUNG_CAP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NHA_CUNG_CAP WHERE MANCC =N'" + txtMaNCC.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
