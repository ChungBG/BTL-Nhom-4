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
    public partial class FrmBaoCaoHDNhap : Form
    {
        public FrmBaoCaoHDNhap()
        {
            InitializeComponent();
        }

       private void FrmBaoCaoHDNhap_Load(object sender, EventArgs e)
        {
            DAO.connect();
            }

      

       private void btnHienthitheonam_Click(object sender, EventArgs e)
       {

           string sql = "select top 3 * from HOA_DON_NHAP order by TONGTIEN DESC;";
           SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
           DataTable tblchitiettrasach = new DataTable();
           adp.Fill(tblchitiettrasach);
           dgvBCHDNhap.DataSource = tblchitiettrasach;

       }

       private void btnXuat_Click(object sender, EventArgs e)
       {
           excelnam ex = new excelnam();
           DataTable dt = (DataTable)dgvBCHDNhap.DataSource;
           ex.Export(dt, "Danh sach", "Báo cáo tổng tiền thu");

       }

       

       }

    }

