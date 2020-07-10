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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTLCK_n1
{
    public partial class FrmHoaDonNhap : Form
    {
        DataTable HOA_DON_NHAP; //Bảng  hoá đơn nhập 
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void hienthi()
        {

            string sql = "select * from HOA_DON_NHAP";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_NHAP = new DataTable();
            adp.Fill(HOA_DON_NHAP);
            dgvHDNhap.DataSource = HOA_DON_NHAP;
        }
   
       
       
        //nạp các giá trị control về mặc định 
        private void ResetValues()
        {
            txtsoHDN.Text = "";
            txtNgaynhap.Text = "";
            txtMaNV.Text = "";
            txtMaNCC.Text = "";
            txtTongtien.Text = "";
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
           System.Windows.Forms.DialogResult.Yes)
                Application.Exit();

        }
      

        private void dgvHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsoHDN.Text = dgvHDNhap.CurrentRow.Cells["SOHDN"].Value.ToString();
            txtNgaynhap.Text = dgvHDNhap.CurrentRow.Cells["NGAYNHAP"].Value.ToString();
            txtMaNV.Text = dgvHDNhap.CurrentRow.Cells["MANV"].Value.ToString();
            txtMaNCC.Text = dgvHDNhap.CurrentRow.Cells["MANCC"].Value.ToString();
            txtTongtien.Text = dgvHDNhap.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            txtsoHDN.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            ResetValues();
            txtsoHDN.Enabled = true;
            txtsoHDN.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql1;
            sql1 = "SELECT * FROM HOA_DON_NHAP";
            HOA_DON_NHAP = DAO.GetDataToTable(sql1);
            string sql;


            if (HOA_DON_NHAP.Rows.Count == 0)
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
                sql = "DELETE FROM HOA_DON_NHAP WHERE SOHDN =N'" + txtsoHDN.Text + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.con;
                cmd.ExecuteNonQuery();
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM HOA_DON_NHAP";
            HOA_DON_NHAP = DAO.GetDataToTable(sql1);
            string sql;
            if (HOA_DON_NHAP.Rows.Count == 0)
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
                if (txtNgaynhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNgaynhap.Focus();
                    return;
                }
                if (txtMaNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNV.Focus();
                    return;
                }
                if (txtMaNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNCC.Focus();
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
            sql = "UPDATE HOA_DON_NHAP SET NGAYNHAP=N'" + txtNgaynhap.Text.ToString() + "',MANV=N'" + txtMaNV.Text.ToString()
                + "',MANCC=N'" + txtMaNCC.Text.ToString() + "',TONGTIEN=N'" + txtTongtien.Text.ToString() + "' WHERE SOHDN=N'" + txtsoHDN.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtsoHDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HDN", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDN.Focus();
                return;
            }
            if (txtNgaynhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaynhap.Focus();
                return;
            }
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã NCC", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (txtTongtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongtien.Focus();
                return;
            }


            sql = "SELECT SOHDN FROM HOA_DON_NHAP  WHERE SOHDN =N'" +
            txtsoHDN.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("số HDN này đã có, bạn phải nhập số HDN khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDN.Focus();
                txtsoHDN.Text = "";
                return;
            }


            sql = "INSERT INTO HOA_DON_NHAP(SOHDN,NGAYNHAP,MANV,MANCC,TONGTIEN) VALUES(N'" + txtsoHDN.Text + "',N'" + txtNgaynhap.Text + "',N'"
                + txtMaNV.Text + "',N'" + txtMaNCC.Text + "',N'" + txtTongtien.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtsoHDN.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtsoHDN.Enabled = false;
        }    
    }
    
}

