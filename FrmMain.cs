using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace BTLCK_n1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuChatlieu_Click_1(object sender, EventArgs e)
        {
            FrmDMChatLieu frmChatLieu = new FrmDMChatLieu(); //Khởi tạo đối tượng
            frmChatLieu.ShowDialog(); //Hiển thị
        }

        private void mnuDanhmuc_Click_1(object sender, EventArgs e)
        {
            
        }

        private void mnuNhanvien_Click_1(object sender, EventArgs e)
        {
            FrmDMNhanVien f1 = new FrmDMNhanVien();
            f1.Show();
        }

        private void mnuKhachhang_Click_1(object sender, EventArgs e)
        {
            FrmDMKhachHang f1 = new FrmDMKhachHang();
            f1.Show();
        }

        private void mnuHoadonnhap_Click_1(object sender, EventArgs e)
        {

            FrmHoaDonNhap f1 = new FrmHoaDonNhap();
            f1.Show();
        }

        private void mnuHoadonban_Click_1(object sender, EventArgs e)
        {
            FrmHoaDonBan f1 = new FrmHoaDonBan();
            f1.Show();
        }

        private void mnuHanghoa_Click_1(object sender, EventArgs e)
        {
            FrmDMHang f1 = new FrmDMHang();
            f1.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuNhacungcap_Click(object sender, EventArgs e)
        {
            FrmNhacungcap f1 = new FrmNhacungcap();
            f1.Show();
        }

        private void mnuNhomhang_Click(object sender, EventArgs e)
        {
            FrmNhomHang f1 = new FrmNhomHang();
            f1.Show();
        }

        private void mnuCongdung_Click(object sender, EventArgs e)
        {
            FrmCongDung f1 = new FrmCongDung();
            f1.Show();
        }

        private void mnuHDNhap_Click(object sender, EventArgs e)
        {
            FrmBaoCaoHDNhap f1 = new FrmBaoCaoHDNhap();
            f1.Show();
        }

        private void mnuBCSanpham_Click(object sender, EventArgs e)
        {
            FrmBaoCaoSanPham f1 = new FrmBaoCaoSanPham();
            f1.Show();
        }

        private void mnuBCKHtheoQuy_Click(object sender, EventArgs e)
        {
            FrmBCKHtheoQuy f1 = new FrmBCKHtheoQuy();
            f1.Show();
        }

        private void mnuCT_HDNhap_Click(object sender, EventArgs e)
        {
            FrmCT_HDNhap f1 = new FrmCT_HDNhap();
            f1.Show();

        }

        private void mnuCT_HDBan_Click(object sender, EventArgs e)
        {
            FrmCT_HDBan f1 = new FrmCT_HDBan();
            f1.Show();
        }

        private void mnuFindHang_Click(object sender, EventArgs e)
        {
            FrmTimKiemHang f1 = new FrmTimKiemHang();
            f1.Show();
        }

        private void mnuFindHoadonnhap_Click(object sender, EventArgs e)
        {
            FrmTimHDNhap f1 = new FrmTimHDNhap();
            f1.Show();

        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoHDB f1 = new FrmBaoCaoHDB();
            f1.Show();
        }

        
    }
}
