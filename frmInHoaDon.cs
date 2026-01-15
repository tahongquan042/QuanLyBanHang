using QuanLyBanHang.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class frmInHoaDon : Form
    {
        public HoaDon HoaDon { get; set; }
        public DataTable GioHang { get; set; }

        PrintDocument printDoc = new PrintDocument();
        public frmInHoaDon()
        {
            InitializeComponent();
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            printDoc.Print();
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            int y = 20;

            g.DrawString("HÓA ĐƠN BÁN HÀNG",
                new Font("Arial", 16, FontStyle.Bold),
                Brushes.Black, 200, y);

            y += 40;
            g.DrawString($"Ngày: {HoaDon.NgayLap}", font, Brushes.Black, 20, y);
            y += 20;
            g.DrawString($"Nhân viên: {HoaDon.MaNV}", font, Brushes.Black, 20, y);

            y += 30;
            foreach (DataRow r in GioHang.Rows)
            {
                g.DrawString(r["TenSP"].ToString(), font, Brushes.Black, 20, y);
                g.DrawString(r["SoLuong"].ToString(), font, Brushes.Black, 200, y);
                g.DrawString(
                    ((decimal)r["ThanhTien"]).ToString("N0"),
                    font, Brushes.Black, 300, y);
                y += 20;
            }

            y += 20;
            g.DrawString($"Tổng tiền: {HoaDon.TongTien:N0} đ",
                new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black, 200, y);
        }
    }
}

