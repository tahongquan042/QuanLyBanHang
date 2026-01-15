using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace QuanLyBanHang.DAL
{
    // Class chứa kết quả báo cáo ngày
    public class BaoCaoNgayDTO
    {
        public DateTime Ngay { get; set; }
        public decimal DoanhThu { get; set; }
    }

    // Class chứa kết quả báo cáo tháng
    public class BaoCaoThangDTO
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal DoanhThu { get; set; }
    }

    public class BaoCaoDAL
    {
        // 1. Doanh thu theo ngày
        public List<BaoCaoNgayDTO> DoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            using (var db = new QuanLyBanHangContext())
            {
                // Tương đương câu lệnh: 
                // SELECT CAST(NgayLap as Date), SUM(TongTien) 
                // WHERE ... GROUP BY ...
                var query = db.HoaDons
                    .Where(hd => hd.NgayLap >= tuNgay && hd.NgayLap <= denNgay)
                    .GroupBy(hd => DbFunctions.TruncateTime(hd.NgayLap)) // Chỉ lấy phần NGÀY, bỏ giờ phút
                    .Select(g => new BaoCaoNgayDTO
                    {
                        Ngay = g.Key.Value, // Key chính là ngày đã group
                        DoanhThu = g.Sum(hd => hd.TongTien) // Tính tổng tiền
                    });

                return query.ToList();
            }
        }

        // 2. Doanh thu theo tháng
        public List<BaoCaoThangDTO> DoanhThuTheoThang(int nam)
        {
            using (var db = new QuanLyBanHangContext())
            {
                var query = db.HoaDons
                    .Where(hd => hd.NgayLap.Year == nam)
                    .GroupBy(hd => new { hd.NgayLap.Month, hd.NgayLap.Year }) // Group theo Tháng + Năm
                    .Select(g => new BaoCaoThangDTO
                    {
                        Thang = g.Key.Month,
                        Nam = g.Key.Year,
                        DoanhThu = g.Sum(hd => hd.TongTien)
                    })
                    .OrderBy(x => x.Thang); // Sắp xếp từ tháng 1 đến 12

                return query.ToList();
            }
        }
    }
}