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
    public partial class FrmDMHang : Form
    {
        DataTable DM_HANG_HOA;
        public FrmDMHang()
        {
            InitializeComponent();
        }


        private void hienthi()
        {

            string sql = "select * from DM_HANG_HOA";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable DM_HANG_HOA = new DataTable();
            adp.Fill(DM_HANG_HOA);
            dgvHang.DataSource = DM_HANG_HOA;
        }
        private void ResetValues()
        {
            txtMavach.Text = "";
            txtTenhang.Text = "";
            txtMachatlieu.Text = "";
            txtManhom.Text = "";
            txtMacongdung.Text = "";
            txtSoluong.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
            picAnh.Image = null;
            txtAnh.Text = "";
            txtGhichu.Text = "";
        }

        private void FrmDMHang_Load(object sender, EventArgs e)
        {

            DAO.connect();
            hienthi();
        }


        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMavach.Text = dgvHang.CurrentRow.Cells["MAVACH"].Value.ToString();
            txtTenhang.Text = dgvHang.CurrentRow.Cells["TENHANGHOA"].Value.ToString();
            txtManhom.Text = dgvHang.CurrentRow.Cells["MANHOM"].Value.ToString();
            txtMachatlieu.Text = dgvHang.CurrentRow.Cells["MACHATLIEU"].Value.ToString();
            txtMacongdung.Text = dgvHang.CurrentRow.Cells["MACONGDUNG"].Value.ToString();
            txtSoluong.Text = dgvHang.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtDongianhap.Text = dgvHang.CurrentRow.Cells["DONGIANHAP"].Value.ToString();
            txtDongiaban.Text = dgvHang.CurrentRow.Cells["DONGIABAN"].Value.ToString();
            txtAnh.Text = dgvHang.CurrentRow.Cells["ANH"].Value.ToString();
            txtGhichu.Text = dgvHang.CurrentRow.Cells["GHICHU"].Value.ToString();
            txtMavach.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMavach.Enabled = true;
            txtMavach.Focus();
            txtMachatlieu.Enabled = true;
            txtMacongdung.Enabled = true;
            txtManhom.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMavach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã vạch", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMavach.Focus();
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng hóa", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenhang.Focus();
                return;
            }

            if (txtMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                return;
            }

            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }

            if (txtDongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongianhap.Focus();
                return;
            }
            if (txtDongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongiaban.Focus();
                return;
            }

            sql = "SELECT MAVACH FROM DM_HANG_HOA WHERE MAVACH =N'" +
txtMavach.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng hóa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMavach.Focus();
                txtMavach.Text = "";
                return;
            }
            sql = "INSERT INTO DM_HANG_HOA(MAVACH,TENHANGHOA,MANHOM,MACHATLIEU,MACONGDUNG,SOLUONG,DONGIANHAP,DONGIABAN,ANH,GHICHU) VALUES(N'" + txtMavach.Text + "',N'"
                + txtTenhang.Text + "',N'" + txtManhom.Text + "',N'" + txtMachatlieu.Text + "',N'" + txtMacongdung.Text + "',N'" + txtSoluong.Text + "',N'" + txtDongianhap.Text + "',N'" + txtDongiaban.Text + "',N'" + txtAnh.Text + "',N'" + txtGhichu.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMavach.Enabled = false;
            txtMachatlieu.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM DM_HANG_HOA";
            DM_HANG_HOA = DAO.GetDataToTable(sql1);
            string sql;
            if (DM_HANG_HOA.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtMavach.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenhang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên hàng hóa", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenhang.Focus();
                    return;
                }
                if (txtMachatlieu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMachatlieu.Focus();
                    return;
                }
                if (txtSoluong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoluong.Focus();
                    return;
                }
                if (txtDongianhap.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDongianhap.Focus();
                    return;
                }
                if (txtDongiaban.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDongiaban.Focus();
                    return;
                }
            }
            sql = "UPDATE DM_HANG_HOA SET TENHANG=N'" + txtTenhang.Text.ToString() + "' WHERE MAVACH=N'" + txtMavach.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM DM_HANG_HOA";
            DM_HANG_HOA = DAO.GetDataToTable(sql1);
            string sql;
            if (DM_HANG_HOA.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMavach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE DM_HANG_HOA WHERE MAVACH=N'" + txtMavach.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMavach.Enabled = false;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho hàng hóa";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }




        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            double gn, gb, sl;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtDongianhap.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtDongianhap.Text);
            gb = gn * 10 / 100 + gn;
            txtDongiaban.Text = gb.ToString();

        }
    }
}
      
   