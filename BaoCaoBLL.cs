using System;
using System.Collections.Generic;
using QuanLyBanHang.DAL;

namespace QuanLyBanHang.BLL
{
    public class BaoCaoBLL
    {
        BaoCaoDAL dal = new BaoCaoDAL();

        public List<BaoCaoNgayDTO> DoanhThuTheoNgay(DateTime tu, DateTime den)
        {
            return dal.DoanhThuTheoNgay(tu, den);
        }

        public List<BaoCaoThangDTO> DoanhThuTheoThang(int nam)
        {
            return dal.DoanhThuTheoThang(nam);
        }
    }
}