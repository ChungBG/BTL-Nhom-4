using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BTLCK_n1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmDMChatLieu());
            Application.Run(new FrmMain());
           //Application.Run(new FrmDMNhanVien());
            //Application.Run(new FrmHoaDonBan());
           //Application.Run(new FrmDMHang());
           // Application.Run(new FrmDMKhachHang());
          // Application.Run(new FrmNhacungcap());
          // Application.Run(new FrmCT_HDNhap());
            //Application.Run(new FrmBaoCaoSanPham()); 
        }
    }
}
