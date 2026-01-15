using System;
using System.Collections.Generic; // Cần thiết để dùng List<>
using System.Data; // Cần thiết để nhận DataTable từ UI
using QuanLyBanHang.DAL;
using QuanLyBanHang.Entities;

namespace QuanLyBanHang.BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();

        // 1. Sửa kiểu trả về thành List<HoaDon> (vì EF trả về List)
        public List<HoaDon> GetAll()
        {
            return dal.GetAll();
        }

        // 2. Hàm này cần thêm bên DAL nếu chưa có. 
        // Tạm thời trả về List<ChiTietHoaDon>
        // Bạn cần đảm bảo bên HoaDonDAL có hàm GetChiTiet(int maHD) trả về List
        /*
        public List<ChiTietHoaDon> GetChiTiet(int maHD)
        {
            return dal.GetChiTiet(maHD);
        }
        */

        // 3. Hàm Thêm Hóa Đơn (Quan trọng nhất)
        // Vẫn nhận DataTable từ UI để bạn đỡ phải sửa Form
        public void ThemHoaDon(HoaDon hd, DataTable dtChiTiet)
        {
            // Kiểm tra dữ liệu đầu vào cơ bản
            if (hd.TongTien <= 0)
                throw new Exception("Tổng tiền hóa đơn phải lớn hơn 0.");

            // --- BƯỚC CHUYỂN ĐỔI: DataTable -> List<ChiTietHoaDon> ---
            List<ChiTietHoaDon> listChiTiet = new List<ChiTietHoaDon>();

            foreach (DataRow row in dtChiTiet.Rows)
            {
                // Lấy dữ liệu từ dòng DataTable
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                decimal donGia = Convert.ToDecimal(row["DonGia"]);
                decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);
                int maSP = Convert.ToInt32(row["MaSP"]);

                // Kiểm tra logic từng dòng
                if (soLuong <= 0)
                    throw new Exception($"Sản phẩm mã {maSP} có số lượng không hợp lệ.");

                // Tạo đối tượng Entity và thêm vào List
                ChiTietHoaDon chiTiet = new ChiTietHoaDon()
                {
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    ThanhTien = thanhTien
                    // MaHD chưa có, DAL sẽ tự điền sau khi insert HoaDon
                };

                listChiTiet.Add(chiTiet);
            }

            // --- GỌI DAL VỚI LIST ĐÃ CHUYỂN ĐỔI ---
            // Lúc này dal.Insert nhận vào (HoaDon, List<ChiTietHoaDon>)
            if (!dal.Insert(hd, listChiTiet))
            {
                throw new Exception("Thêm hóa đơn thất bại (Lỗi Database).");
            }
        }
    }
}