using System.Linq;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.DAL
{
    public class TaiKhoanDAL
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();

        public TaiKhoan DangNhap(string user, string pass)
        {
            return db.TaiKhoans
                     .FirstOrDefault(t => t.TenDangNhap == user
                                       && t.MatKhau == pass);
        }
    }
}