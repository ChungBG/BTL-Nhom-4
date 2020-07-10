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
    public partial class FrmDMNhanVien : Form
    {
        DataTable NHAN_VIEN;
        public FrmDMNhanVien()
        {
            InitializeComponent();
        }
        private void hienthi()
            {
           string sql = "select * from NHAN_VIEN";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable NHAN_VIEN = new DataTable();
            adp.Fill(NHAN_VIEN);
            dgvNhanvien.DataSource = NHAN_VIEN;
        }
        private void FrmDMNhanVien_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
         private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         txtManhanvien.Text = dgvNhanvien.CurrentRow.Cells["MANV"].Value.ToString();
            txtTennhanvien.Text = dgvNhanvien.CurrentRow.Cells["TENNHANVIEN"].Value.ToString();
            txtGioitinh.Text = dgvNhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            mskNgaysinh.Text = dgvNhanvien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            mtbDienthoai.Text = dgvNhanvien.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
           txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["DIACHI"].Value.ToString();
           txtManhom.Text = dgvNhanvien.CurrentRow.Cells["MANHOM"].Value.ToString();
             txtManhanvien.Enabled = false;
        }

       
        
private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtGioitinh.Text = "";
            mskNgaysinh.Text = "";
            mtbDienthoai.Text = "";
            txtDiachi.Text = "";
            txtManhom.Text = "";
           
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (mtbDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (mskNgaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }

            sql = "SELECT MANV FROM NHAN_VIEN  WHERE MANV =N'" +
txtManhanvien.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên  này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO NHAN_VIEN(MANV,TENNHANVIEN,GIOITINH,NGAYSINH,DIENTHOAI,DIACHI,MANHOM) VALUES(N'" + txtManhanvien.Text + "',N'" + txtTennhanvien.Text + "',N'" + txtGioitinh.Text + "',N'" + mskNgaysinh.Text + "',N'" + mtbDienthoai.Text + "',N'"
                + txtDiachi.Text + "',N'" + txtManhom.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;     
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHAN_VIEN";
            NHAN_VIEN = DAO.GetDataToTable(sql1);
            string sql;
            if (NHAN_VIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtManhanvien.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTennhanvien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTennhanvien.Focus();
                    return;
                }
                if (txtDiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTennhanvien.Focus();
                    return;
                }
                if (mtbDienthoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTennhanvien.Focus();
                    return;
                }
            }
            sql = "UPDATE NHANVIEN SET TENNHANVIEN=N'" + txtTennhanvien.Text.ToString() + "',DIACHI=N'" + txtDiachi.Text.ToString()
                + "',DIENTHOAI=N'" + mtbDienthoai.Text.ToString()+"',MANHOM=N'"+txtManhom.Text.ToString() + "' WHERE MANV=N'" + txtManhanvien.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM NHAN_VIEN";
            NHAN_VIEN = DAO.GetDataToTable(sql1);
            string sql;
            if (NHAN_VIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NHAN_VIEN WHERE MANV =N'" + txtManhanvien.Text + "'";
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
            txtManhanvien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanvien_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}