using QuanLyBanHang.DAL;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public TaiKhoan DangNhap(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                return null;

            return dal.DangNhap(user, pass);
        }
    }
}