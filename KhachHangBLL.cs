using System.Collections.Generic;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();

        // Sửa kiểu trả về thành List<KhachHang>
        public List<KhachHang> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(KhachHang kh)
        {
            return dal.Insert(kh);
        }

        public bool Update(KhachHang kh)
        {
            return dal.Update(kh);
        }

        public bool Delete(int ma)
        {
            return dal.Delete(ma);
        }

        public List<KhachHang> Search(string key)
        {
            return dal.Search(key);
        }
    }
}