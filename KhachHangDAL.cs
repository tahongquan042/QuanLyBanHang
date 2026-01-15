using System.Collections.Generic;
using System.Linq;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.DAL
{
    public class KhachHangDAL
    {
        // Trả về List thay vì DataTable
        public List<KhachHang> GetAll()
        {
            using (var db = new QuanLyBanHangContext())
            {
                return db.KhachHangs.ToList();
            }
        }

        public bool Insert(KhachHang kh)
        {
            using (var db = new QuanLyBanHangContext())
            {
                db.KhachHangs.Add(kh);
                return db.SaveChanges() > 0;
            }
        }

        public bool Update(KhachHang kh)
        {
            using (var db = new QuanLyBanHangContext())
            {
                var item = db.KhachHangs.Find(kh.MaKH);
                if (item == null) return false;

                item.TenKH = kh.TenKH;
                item.DienThoai = kh.DienThoai;
                item.DiaChi = kh.DiaChi;

                return db.SaveChanges() > 0;
            }
        }

        public bool Delete(int maKH)
        {
            using (var db = new QuanLyBanHangContext())
            {
                var item = db.KhachHangs.Find(maKH);
                if (item == null) return false;

                db.KhachHangs.Remove(item);
                return db.SaveChanges() > 0;
            }
        }

        public List<KhachHang> Search(string keyword)
        {
            using (var db = new QuanLyBanHangContext())
            {
                return db.KhachHangs.Where(x => x.TenKH.Contains(keyword)).ToList();
            }
        }
    }
}