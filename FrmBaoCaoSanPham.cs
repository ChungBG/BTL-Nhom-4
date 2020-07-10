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
    public partial class FrmBaoCaoSanPham : Form
    {
        public FrmBaoCaoSanPham()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoSanPham_Load(object sender, EventArgs e)
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
            dgvBCSP.DataSource = CHI_TIET_HD_BAN;
        }

        

        private void ResetValues()
        {
            mskThang.Text = "";
        }
        private void hienthitimkiem()
        {
            string sql = "SELECT * FROM HOA_DON_BAN where HOA_DON_BAN.NGAYBAN like '%" + mskThang.Text + "%' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable HOA_DON_BAN = new DataTable();
            adp.Fill(HOA_DON_BAN);
            dgvBCSP.DataSource = HOA_DON_BAN;
        }


        private void dgvBCSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mskThang.Text = dgvBCSP.CurrentRow.Cells["NGAYBAN"].Value.ToString();
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            hienthitimkiem();
        }

        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            xuatexcel excel = new xuatexcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = (DataTable)dgvBCSP.DataSource;
            excel.Export(dt, "Danh sach", "Danh sách các sản phẩm bán chạy nhất trong tháng");
        }

       
    }
}
