using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace BTLCK_n1
{
    public partial class FrmBCKHtheoQuy : Form
    {
        public FrmBCKHtheoQuy()
        {
            InitializeComponent();
        }

        private void FrmBCKHtheoQuy_Load(object sender, EventArgs e)
        {

            DAO.connect();
            hienthi();
            
        }
        private void hienthi()
        {
            string sql = "select CHI_TIET_HD_BAN.SOHDB, CHI_TIET_HD_BAN.MAVACH, SOLUONGBAN, TENHANGHOA, NGAYBAN from ((CHI_TIET_HD_BAN full outer join DM_HANG_HOA on CHI_TIET_HD_BAN.MAVACH = DM_HANG_HOA.MAVACH) full outer join HOA_DON_BAN on CHI_TIET_HD_BAN.SOHDB = HOA_DON_BAN.SOHDB)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable CHI_TIET_HD_BAN = new DataTable();
            adp.Fill(CHI_TIET_HD_BAN);
            dgvBCKH.DataSource = CHI_TIET_HD_BAN;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

            if ((txtQuy.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ quý!!!", "Yeu cau ...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int dau, cuoi;
            dau = 0;
            cuoi = 0;
            int quy = Convert.ToInt32(txtQuy.Text);
            if (quy == 1)
            {
                dau = 1;
                cuoi = 3;
            }
            else if (quy == 2)
            {
                dau = 4;
                cuoi = 6;
            }
            else if (quy == 3)
            {
                dau = 7;
                cuoi = 9;
            }
            else if (quy == 4)
            {
                dau = 10;
                cuoi = 12;
            }
     string sql;
     sql = "select CHI_TIET_HD_BAN.SOHDB, CHI_TIET_HD_BAN.MAVACH, SOLUONGBAN, TENHANGHOA, NGAYBAN from ((CHI_TIET_HD_BAN full outer join DM_HANG_HOA on CHI_TIET_HD_BAN.MAVACH = DM_HANG_HOA.MAVACH) full outer join HOA_DON_BAN on CHI_TIET_HD_BAN.SOHDB = HOA_DON_BAN.SOHDB)";
            DataTable tblQuy;
            tblQuy = ThucthiSQL.DocBang(sql);
            if (tblQuy.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Có " + tblQuy.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvBCKH.DataSource = tblQuy;
            hienthi();
        }

        }

    }
