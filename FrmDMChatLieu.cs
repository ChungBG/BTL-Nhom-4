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
    public partial class FrmDMChatLieu : Form
    {
        DataTable CHAT_LIEU;
        public FrmDMChatLieu()
        {
            InitializeComponent();
        }
        private void hienthi()
        {

            string sql = "select * from CHAT_LIEU";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable CHAT_LIEU = new DataTable();
            adp.Fill(CHAT_LIEU);
            dgvDMChatlieu.DataSource = CHAT_LIEU;
        }
        private void FrmDMChatLieu_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }

        private void dgvDMChatlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMachatlieu.Text = dgvDMChatlieu.CurrentRow.Cells["MACHATLIEU"].Value.ToString();
            txtTenchatlieu.Text = dgvDMChatlieu.CurrentRow.Cells["TENCHATLIEU"].Value.ToString();
           
            txtMachatlieu.Enabled = false;
        }

        private void ResetValue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMachatlieu.Enabled = true; //cho phép nhập mới
            txtMachatlieu.Focus();
        }
       
       

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchatlieu.Focus();
                return;
            }

            sql = "SELECT MACHATLIEU FROM CHAT_LIEU WHERE MACHATLIEU =N'" +
txtMachatlieu.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtMachatlieu.Focus();
                txtMachatlieu.Text = "";
                return;
            }
            sql = "INSERT INTO CHAT_LIEU(MACHATLIEU,TENCHATLIEU) VALUES(N'" + txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CHAT_LIEU";
            CHAT_LIEU = DAO.GetDataToTable(sql1);
            string sql;
            if (CHAT_LIEU.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtMachatlieu.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenchatlieu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenchatlieu.Focus();
                    return;
                }
                
            }
            sql = "UPDATE CHAT_LIEU SET TENCHATLIEU=N'" + txtTenchatlieu.Text.ToString() + "' WHERE MACHATLIEU=N'" + txtMachatlieu.Text + "'";
            DAO.RunSQL(sql);
            hienthi();
            ResetValue();
            btnBoqua.Enabled = false;
            
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM CHAT_LIEU";
            CHAT_LIEU = DAO.GetDataToTable(sql1);
            string sql;
            if (CHAT_LIEU.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE CHAT_LIEU WHERE MACHATLIEU=N'" + txtMachatlieu.Text + "'";
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
            txtMachatlieu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
        