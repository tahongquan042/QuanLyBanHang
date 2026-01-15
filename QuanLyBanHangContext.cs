using System.Data.Entity;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.DAL
{
    public class QuanLyBanHangContext : DbContext
    {
        public QuanLyBanHangContext() : base("Data Source=.\\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True")
        {
        }

        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}