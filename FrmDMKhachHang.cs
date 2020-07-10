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
    public partial class FrmDMKhachHang : Form
    {
        DataTable KHACH_HANG;

        public FrmDMKhachHang()
        {
            InitializeComponent();
        }
        private void hienthi()
        {

            string sql = "select * from KHACH_HANG";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable KHACH_HANG = new DataTable();
            adp.Fill(KHACH_HANG);
            dgvKhachhang.DataSource = KHACH_HANG;
        }
        private void FrmDMKhachHang_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakhach.Text = dgvKhachhang.CurrentRow.Cells["MAKHACH"].Value.ToString();
            txtTenkhach.Text = dgvKhachhang.CurrentRow.Cells["TENKHACH"].Value.ToString();
            txtDiachi.Text = dgvKhachhang.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtMakhach.Enabled = false;
        }


        private void ResetValues()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            mtbDienthoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhach.Enabled = true;
            txtMakhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (mtbDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }

            sql = "SELECT MAKHACH FROM KHACH_HANG  WHERE MAKHACH =N'" +
txtMakhach.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                txtMakhach.Text = "";
                return;
            }
            sql = "INSERT INTO KHACH_HANG(MAKHACH,TENKHACH,DIACHI,DIENTHOAI) VALUES(N'" + txtMakhach.Text + "',N'" + txtTenkhach.Text + "',N'"
                + txtDiachi.Text + "',N'"+mtbDienthoai.Text+"')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM KHACH_HANG";
            KHACH_HANG= DAO.GetDataToTable(sql1);
            string sql;
            if (KHACH_HANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtMakhach.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenkhach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenkhach.Focus();
                    return;
                }
                if (txtDiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenkhach.Focus();
                    return;
                }
                if (mtbDienthoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenkhach.Focus();
                    return;
                }
            }
            sql = "UPDATE khachhang SET TENKHACH=N'" + txtTenkhach.Text.ToString() + "',DIACHI=N'" + txtDiachi.Text.ToString() 
                +"',DIENTHOAI=N'"+mtbDienthoai.Text.ToString()+ "' WHERE MAKHACH=N'" + txtMakhach.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM KHACH_HANG";
            KHACH_HANG = DAO.GetDataToTable(sql1);
            string sql;
            if (KHACH_HANG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE KHACH_HANG WHERE MAKHACH =N'" + txtMakhach.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
        ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
   