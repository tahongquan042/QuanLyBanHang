using QuanLyBanHang.Entities;
using System.Collections.Generic;
using System.Linq; // Cần thiết để dùng .ToList(), .Where()

namespace QuanLyBanHang.DAL
{
    public class SanPhamDAL
    {
        // 1. Lấy tất cả
        public List<SanPham> GetAll()
        {
            using (var db = new QuanLyBanHangContext())
            {
                return db.SanPhams.ToList();
            }
        }

        // 2. Thêm mới
        public bool Insert(SanPham sp)
        {
            using (var db = new QuanLyBanHangContext())
            {
                db.SanPhams.Add(sp);
                return db.SaveChanges() > 0;
            }
        }

        // 3. Sửa (Update) - Đã chuyển sang Code First
        public bool Update(SanPham sp)
        {
            using (var db = new QuanLyBanHangContext())
            {
                // Bước 1: Tìm sản phẩm cũ trong database theo ID
                var sanPhamCu = db.SanPhams.Find(sp.MaSP);

                if (sanPhamCu != null)
                {
                    // Bước 2: Gán dữ liệu mới đè lên dữ liệu cũ
                    sanPhamCu.TenSP = sp.TenSP;
                    sanPhamCu.DonGia = sp.DonGia;
                    sanPhamCu.SoLuongTon = sp.SoLuongTon;

                    // Bước 3: Lưu thay đổi (EF tự sinh lệnh UPDATE SQL)
                    return db.SaveChanges() > 0;
                }

                return false; // Không tìm thấy ID để sửa
            }
        }

        // 4. Xóa
        public bool Delete(int maSP)
        {
            using (var db = new QuanLyBanHangContext())
            {
                var sp = db.SanPhams.Find(maSP);
                if (sp == null) return false;

                db.SanPhams.Remove(sp);
                return db.SaveChanges() > 0;
            }
        }

        // 5. Tìm kiếm (Search) - Đã chuyển sang Code First (LINQ)
        public List<SanPham> Search(string keyword)
        {
            using (var db = new QuanLyBanHangContext())
            {
                // Dùng LINQ: Where + Contains (tương đương LIKE %keyword%)
                return db.SanPhams
                         .Where(s => s.TenSP.Contains(keyword))
                         .ToList();
            }
        }
    }
}