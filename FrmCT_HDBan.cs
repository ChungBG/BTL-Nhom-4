using System;
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
    public partial class FrmCT_HDBan : Form
    {
        DataTable CHI_TIET_HD_BAN;
        public FrmCT_HDBan()
        {
            InitializeComponent();
        }

        private void FrmCT_HDBan_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();

        }


        private void hienthi()
        {

            string sql = "select * from CHI_TIET_HD_BAN";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable CHI_TIET_HD_BAN = new DataTable();
            adp.Fill(CHI_TIET_HD_BAN);
            dgvCTHDBan.DataSource = CHI_TIET_HD_BAN;

        }

        private void dgvCTHDBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsoHDB.Text = dgvCTHDBan.CurrentRow.Cells["SOHDB"].Value.ToString();
            txtMavach.Text = dgvCTHDBan.CurrentRow.Cells["MAVACH"].Value.ToString();
            txtSoluong.Text = dgvCTHDBan.CurrentRow.Cells["SOLUONGBAN"].Value.ToString();
            txtGiamgia.Text = dgvCTHDBan.CurrentRow.Cells["GIAMGIA"].Value.ToString();
            txtDongia.Text = dgvCTHDBan.CurrentRow.Cells["DONGIA"].Value.ToString();
            txtThanhtien.Text = dgvCTHDBan.CurrentRow.Cells["THANHTIEN"].Value.ToString();
            txtsoHDB.Enabled = false;
            

        }
        private void ResetValues()
        {
            txtsoHDB.Text = "";
            txtMavach.Text = "";
            txtSoluong.Text = "";
            txtGiamgia.Text = "";
            txtDongia.Text = "";
            txtThanhtien.Text = "";

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
            sql1 = "SELECT * FROM CHI_TIET_HD_NHAP";
            CHI_TIET_HD_BAN = DAO.GetDataToTable(sql1);
            string sql;


            if (CHI_TIET_HD_BAN.Rows.Count == 0)
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
                sql = "DELETE FROM CHI_TIET_HD_BAN WHERE SOHDB =N'" + txtsoHDB.Text + "'";
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
            sql1 = "SELECT * FROM CHI_TIET_HD_NHAP";
            CHI_TIET_HD_BAN = DAO.GetDataToTable(sql1);
            string sql;


            if (CHI_TIET_HD_BAN.Rows.Count == 0)
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
                sql = "UPDATE CHI_TIET_HD_BAN SET MAVACH=N'" + txtMavach.Text.ToString() + "',SOLUONGBAN=N'" + txtSoluong.Text.ToString()
+ "',DONGIA=N'" + txtDongia.Text.ToString() + "',GIAMGIA=N'" + txtGiamgia.Text.ToString() + "',THANHTIEN=N'" + txtThanhtien.Text.ToString() + "' WHERE SOHDB=N'" + txtsoHDB.Text + "'";
                DAO.RunSQL(sql);
                hienthi();
                ResetValues();
                btnBoqua.Enabled = false;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string sql;
            if (txtsoHDB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số HDB", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDB.Focus();
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



            sql = "SELECT SOHDB FROM CHI_TIET_HD_BAN WHERE SOHDB =N'" +
            txtsoHDB.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("số HDB này đã có, bạn phải nhập số HDN khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHDB.Focus();
                txtsoHDB.Text = "";
                return;
            }


            sql = "INSERT INTO CHI_TIET_HD_BAN(SOHDB,MAVACH,SOLUONGBAN,DONGIA,GIAMGIA,THANHTIEN) VALUES(N'" + txtsoHDB.Text + "',N'" + txtMavach.Text + "',N'"
+ txtSoluong.Text + "',N'" + txtDongia.Text + "',N'" + txtGiamgia.Text + "',N'" + txtThanhtien.Text + "')";
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
           

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

   
        }


        }
    

