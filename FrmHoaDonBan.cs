using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTLCK_n1
{
    public partial class FrmHoaDonBan : Form
    {
        DataTable HOA_DON_BAN;
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }

        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();

        }

        private void hienthi()
        {
            string sql = "select * from HOA_DON_BAN";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_BAN = new DataTable();
            adp.Fill(HOA_DON_BAN);
            dgvHDBan.DataSource = HOA_DON_BAN;
        }
        private void ResetValues()
        {
            txtsoHDB.Text = "";
            txtNgayban.Text = "";
            txtMaNV.Text = "";
            txtMakhach.Text = "";
            txtTongtien.Text = "";
        }


        private void dgvHDBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsoHDB.Text = dgvHDBan.CurrentRow.Cells["SOHDB"].Value.ToString();
            txtNgayban.Text = dgvHDBan.CurrentRow.Cells["NGAYBAN"].Value.ToString();
            txtMaNV.Text = dgvHDBan.CurrentRow.Cells["MANV"].Value.ToString();
            txtMakhach.Text = dgvHDBan.CurrentRow.Cells["MAKHACH"].Value.ToString();
            txtTongtien.Text = dgvHDBan.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            txtsoHDB.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtsoHDB.Enabled = true;
            txtsoHDB.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM HOA_DON_BAN";
            DataTable HOA_DON_BAN = DAO.GetDataToTable(sql1);
            string sql;
            if (HOA_DON_BAN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtsoHDB.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HOA_DON_BAN WHERE SOHDB=N'" + txtsoHDB.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM HOA_DON_BAN";
            HOA_DON_BAN = DAO.GetDataToTable(sql1);
            string sql;
            if (HOA_DON_BAN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtsoHDB.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNgayban.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgayban.Focus();
                    return;
                }
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNV.Focus();
                    return;
                }
                if (txtMakhach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMakhach.Focus();
                    return;
                }
                if (txtTongtien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTongtien.Focus();
                    return;
                }

            }
            sql = "UPDATE HOA_DON_BAN SET NGAYBAN=N'" + txtNgayban.Text.ToString() + "',MANV=N'" + txtMaNV.Text.ToString()
                + "',MAKHACH=N'" + txtMakhach.Text.ToString() + "',TONGTIEN=N'" + txtTongtien.Text.ToString() + "' WHERE SOHDB=N'" + txtsoHDB.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtsoHDB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HDN", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDB.Focus();
                return;
            }
            if (txtNgayban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayban.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTongtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongtien.Focus();
                return;
            }


            sql = "SELECT SOHDB FROM HOA_DON_BAN  WHERE SOHDB =N'" +
            txtsoHDB.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("số HDN này đã có, bạn phải nhập số HDB khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDB.Focus();
                txtsoHDB.Text = "";
                return;
            }


            sql = "INSERT INTO HOA_DON_BAN(SOHDB,NGAYBAN,MANV,MAKHACH,TONGTIEN) VALUES(N'" + txtsoHDB.Text + "',N'" + txtNgayban.Text + "',N'"
                + txtMaNV.Text + "',N'" + txtMakhach.Text + "',N'" + txtTongtien.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtsoHDB.Enabled = false;

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtsoHDB.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
           System.Windows.Forms.DialogResult.Yes)
                Application.Exit();

        }

       

    }
}


