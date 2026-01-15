using quanlybanhang;
using QuanLyBanHang.BLL;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Entities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang.UI
{
    public partial class frmHoaDonBan : Form
    {
        DataTable dtHangHoa;
        DataTable dtGioHang;
        private HoaDon HoaDonVuaLuu;

        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            CreateGioHang();
            LoadKhachHang();

            // Render mã NV từ đăng nhập
            txtMaNV.Text = Session.MaNhanVien.ToString();
            txtMaNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtMaSP.ReadOnly = true;
            txtMaSP.TabStop = false;
        }

        // ================= LOAD HÀNG HÓA =================

        private void LoadHangHoa()
        {
            using (var db = new QuanLyBanHangContext())
            {
                var data = db.SanPhams
                    .Select(sp => new
                    {
                        sp.MaSP,
                        sp.TenSP,
                        sp.DonGia,
                        sp.SoLuongTon
                    })
                    .ToList();

                dtHangHoa = new DataTable();
                dtHangHoa.Columns.Add("MaSP", typeof(int));
                dtHangHoa.Columns.Add("TenSP", typeof(string));
                dtHangHoa.Columns.Add("DonGia", typeof(decimal));
                dtHangHoa.Columns.Add("SoLuongTon", typeof(int));

                foreach (var sp in data)
                {
                    dtHangHoa.Rows.Add(sp.MaSP, sp.TenSP, sp.DonGia, sp.SoLuongTon);
                }

                dgvHanghoa.DataSource = dtHangHoa;
            }

            dgvHanghoa.Columns["MaSP"].HeaderText = "Mã SP";
            dgvHanghoa.Columns["TenSP"].HeaderText = "Tên hàng hóa";
            dgvHanghoa.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvHanghoa.Columns["SoLuongTon"].HeaderText = "Tồn kho";
        }

        // ================= GIỎ HÀNG =================

        private void CreateGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaSP", typeof(int));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "DonGia * SoLuong");

            dgvGioHang.DataSource = dtGioHang;
        }
        private void LoadKhachHang()
        {
            using (var db = new QuanLyBanHangContext())
            {
                var data = db.KhachHangs
                    .Select(kh => new
                    {
                        kh.MaKH,
                        kh.TenKH,
                        kh.DienThoai
                    })
                    .ToList();

                cboKhachHang.DataSource = data;
                cboKhachHang.DisplayMember = "TenKH";
                cboKhachHang.ValueMember = "MaKH";
            }
        }
        private void ExportHoaDonToExcel(HoaDon hd, DataTable gioHang)
        {
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = true;

                wb = excelApp.Workbooks.Add();
                ws = (Excel.Worksheet)wb.ActiveSheet;
                ws.Name = "HoaDon";

                int row = 1;

                // ====== TIÊU ĐỀ ======
                ws.Cells[row, 1] = "HÓA ĐƠN BÁN HÀNG";
                ws.Range["A1", "E1"].Merge();
                ws.Range["A1"].Font.Size = 16;
                ws.Range["A1"].Font.Bold = true;
                ws.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                row += 2;
                ws.Cells[row, 1] = "Ngày lập:";
                ws.Cells[row, 2] = hd.NgayLap.ToString("dd/MM/yyyy HH:mm");

                row++;
                ws.Cells[row, 1] = "Nhân viên:";
                ws.Cells[row, 2] = hd.MaNV;

                row += 2;

                // ====== HEADER ======
                ws.Cells[row, 1] = "STT";
                ws.Cells[row, 2] = "Tên SP";
                ws.Cells[row, 3] = "Số lượng";
                ws.Cells[row, 4] = "Đơn giá";
                ws.Cells[row, 5] = "Thành tiền";

                ws.Range["A" + row, "E" + row].Font.Bold = true;
                ws.Range["A" + row, "E" + row].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                row++;

                // ====== DỮ LIỆU ======
                int stt = 1;
                foreach (DataRow r in gioHang.Rows)
                {
                    ws.Cells[row, 1] = stt++;
                    ws.Cells[row, 2] = r["TenSP"].ToString();
                    ws.Cells[row, 3] = Convert.ToInt32(r["SoLuong"]);
                    ws.Cells[row, 4] = Convert.ToDecimal(r["DonGia"]);
                    ws.Cells[row, 5] = Convert.ToDecimal(r["ThanhTien"]);

                    ws.Range["A" + row, "E" + row].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    row++;
                }

                row += 1;

                // ====== TỔNG TIỀN ======
                ws.Cells[row, 4] = "Tổng tiền:";
                ws.Cells[row, 5] = hd.TongTien;
                ws.Range["D" + row, "E" + row].Font.Bold = true;

                ws.Columns.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message);
            }
            finally
            {
                // Giải phóng COM (tránh treo Excel)
                if (ws != null) Marshal.ReleaseComObject(ws);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvHanghoa.CurrentRow == null) return;

            int maSP = Convert.ToInt32(dgvHanghoa.CurrentRow.Cells["MaSP"].Value);
            string tenSP = dgvHanghoa.CurrentRow.Cells["TenSP"].Value.ToString();
            decimal donGia = Convert.ToDecimal(dgvHanghoa.CurrentRow.Cells["DonGia"].Value);
            int tonKho = Convert.ToInt32(dgvHanghoa.CurrentRow.Cells["SoLuongTon"].Value);
            int soLuong = (int)numSoLuong.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải > 0");
                return;
            }

            if (soLuong > tonKho)
            {
                MessageBox.Show("Số lượng vượt tồn kho!");
                return;
            }

            foreach (DataRow r in dtGioHang.Rows)
            {
                if ((int)r["MaSP"] == maSP)
                {
                    r["SoLuong"] = (int)r["SoLuong"] + soLuong;
                    TinhTongTien();
                    return;
                }
            }

            DataRow row = dtGioHang.NewRow();
            row["MaSP"] = maSP;
            row["TenSP"] = tenSP;
            row["DonGia"] = donGia;
            row["SoLuong"] = soLuong;
            dtGioHang.Rows.Add(row);

            TinhTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null) return;
            dgvGioHang.Rows.RemoveAt(dgvGioHang.CurrentRow.Index);
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow r in dtGioHang.Rows)
                tong += (decimal)r["ThanhTien"];

            txtTongTien.Text = tong.ToString("N0");
        }

        // ================= THANH TOÁN (EF + TRANSACTION) =================

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }
            if (cboKhachHang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }

            using (var db = new QuanLyBanHangContext())
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    decimal tongTien = decimal.Parse(txtTongTien.Text.Replace(",", ""));

                    var hd = new HoaDon
                    {
                        NgayLap = DateTime.Now,
                        MaNV = Session.MaNhanVien,
                        MaKH = (int)cboKhachHang.SelectedValue,
                        TongTien = tongTien
                    };

                    db.HoaDons.Add(hd);
                    db.SaveChanges(); // sinh MaHD

                    foreach (DataRow r in dtGioHang.Rows)
                    {
                        int maSP = (int)r["MaSP"];
                        int soLuong = (int)r["SoLuong"];
                        decimal donGia = (decimal)r["DonGia"];

                        var ct = new ChiTietHoaDon
                        {
                            MaHD = hd.MaHD,
                            MaSP = maSP,
                            SoLuong = soLuong,
                            DonGia = donGia
                        };
                        db.ChiTietHoaDons.Add(ct);

                        // Trừ tồn kho
                        var sp = db.SanPhams.Find(maSP);
                        sp.SoLuongTon -= soLuong;
                    }

                    db.SaveChanges();
                    tran.Commit();
                    HoaDonVuaLuu = hd;

                    MessageBox.Show("Thanh toán thành công!\nBạn có thể in hóa đơn.");
                    txtTongTien.Clear();
                    LoadHangHoa();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi thanh toán!\n" + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng!");
                return;
            }

            int soLuongMoi = (int)numSoLuong.Value;
            if (soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return;
            }

            int maSP = Convert.ToInt32(dgvGioHang.CurrentRow.Cells["MaSP"].Value);

            // 🔹 Lấy tồn kho hiện tại từ bảng hàng hóa
            int tonKho = dtHangHoa.AsEnumerable()
                .Where(r => r.Field<int>("MaSP") == maSP)
                .Select(r => r.Field<int>("SoLuongTon"))
                .FirstOrDefault();

            if (soLuongMoi > tonKho)
            {
                MessageBox.Show("Số lượng vượt quá tồn kho!");
                return;
            }

            // 🔹 Cập nhật số lượng trong giỏ
            dgvGioHang.CurrentRow.Cells["SoLuong"].Value = soLuongMoi;

            dgvGioHang.Refresh();
            TinhTongTien();

            MessageBox.Show("Cập nhật số lượng thành công!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            using (var db = new QuanLyBanHangContext())
            {
                var query = db.SanPhams.AsQueryable();

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(sp =>
                        sp.TenSP.Contains(tuKhoa) ||
                        sp.MaSP.ToString().Contains(tuKhoa));
                }

                var data = query.Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.DonGia,
                    sp.SoLuongTon
                }).ToList();

                dtHangHoa.Clear();

                foreach (var sp in data)
                {
                    dtHangHoa.Rows.Add(
                        sp.MaSP,
                        sp.TenSP,
                        sp.DonGia,
                        sp.SoLuongTon
                    );
                }
            }

            if (dtHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hàng hóa phù hợp!");
            }
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedItem == null) return;

            // Lấy object hiện tại
            dynamic kh = cboKhachHang.SelectedItem;
            txtSDT.Text = kh.DienThoai;
        }
        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                txtMaSP.Clear();
                return;
            }

            using (var db = new QuanLyBanHangContext())
            {
                var sp = db.SanPhams
                    .FirstOrDefault(x => x.TenSP == txtTenSP.Text);

                if (sp != null)
                {
                    txtMaSP.Text = sp.MaSP.ToString();
                }
                else
                {
                    txtMaSP.Clear();
                }
            }
        }

        private void dgvHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaSP.Text = dgvHanghoa.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
            txtTenSP.Text = dgvHanghoa.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (HoaDonVuaLuu == null)
            {
                MessageBox.Show("Chưa có hóa đơn để xuất!");
                return;
            }

            ExportHoaDonToExcel(HoaDonVuaLuu, dtGioHang);
            dtGioHang.Clear();
        }
    }
}
