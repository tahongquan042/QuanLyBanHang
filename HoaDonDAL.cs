using System.Collections.Generic;
using System.Linq;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.DAL
{
    public class HoaDonDAL
    {
        public List<HoaDon> GetAll()
        {
            using (var db = new QuanLyBanHangContext())
            {
                return db.HoaDons.ToList();
            }
        }

        // Hàm Insert quan trọng (Transaction)
        public bool Insert(HoaDon hd, List<ChiTietHoaDon> listChiTiet)
        {
            using (var db = new QuanLyBanHangContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Thêm hóa đơn
                        db.HoaDons.Add(hd);
                        db.SaveChanges(); // Để sinh ra MaHD

                        // 2. Thêm chi tiết & Trừ tồn kho
                        foreach (var item in listChiTiet)
                        {
                            item.MaHD = hd.MaHD; // Gán MaHD vừa sinh
                            db.ChiTietHoaDons.Add(item);

                            // Trừ tồn kho
                            var sp = db.SanPhams.Find(item.MaSP);
                            if (sp != null)
                            {
                                sp.SoLuongTon -= item.SoLuong;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}