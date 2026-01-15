using System.Collections.Generic;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public List<SanPham> GetAll()
        {
            return dal.GetAll();
        }

        public bool Add(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                return false;

            if (sp.DonGia <= 0 || sp.SoLuongTon < 0)
                return false;

            return dal.Insert(sp);
        }

        public bool Update(SanPham sp)
        {
            if (sp.MaSP <= 0)
                return false;

            return dal.Update(sp);
        }

        public bool Delete(int maSP)
        {
            return dal.Delete(maSP);
        }

        public List<SanPham> Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}