using QuanLyBanHang.BLL;
using QuanLyBanHang.DAL; // Cần cái này để hiểu DTO
using System;
using System.Collections.Generic;
using System.Linq; // Cần cái này để dùng hàm .Sum()
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class frmBaoCao : Form
    {
        // Khai báo BLL
        private BaoCaoBLL bcBLL = new BaoCaoBLL();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // Thêm item cho ComboBox
            cboTheo.Items.Clear();
            cboTheo.Items.Add("Ngày");
            cboTheo.Items.Add("Tháng");
            cboTheo.SelectedIndex = 0; // Mặc định chọn cái đầu

            // Format hiển thị ngày tháng trên DateTimePicker cho đẹp
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Format = DateTimePickerFormat.Short;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            decimal tongDoanhThu = 0;

            // Xóa dữ liệu cũ trên lưới
            dgvBaoCao.DataSource = null;

            if (cboTheo.Text == "Ngày")
            {
                // 1. Lấy dữ liệu dạng List
                var listData = bcBLL.DoanhThuTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);

                // 2. Đổ lên lưới
                dgvBaoCao.DataSource = listData;

                // 3. Tính tổng (Dùng hàm Sum của LINQ cực nhanh)
                if (listData.Count > 0)
                    tongDoanhThu = listData.Sum(x => x.DoanhThu);

                // 4. Đặt tên cột tiếng Việt
                if (dgvBaoCao.Columns["Ngay"] != null)
                    dgvBaoCao.Columns["Ngay"].HeaderText = "Ngày";
            }
            else if (cboTheo.Text == "Tháng")
            {
                // 1. Lấy dữ liệu
                // Lưu ý: DateTimePicker có thể tên là dtpTu hoặc dtpTuNgay tùy form bạn vẽ
                int nam = dtpTuNgay.Value.Year;
                var listData = bcBLL.DoanhThuTheoThang(nam);

                // 2. Đổ lên lưới
                dgvBaoCao.DataSource = listData;

                // 3. Tính tổng
                if (listData.Count > 0)
                    tongDoanhThu = listData.Sum(x => x.DoanhThu);

                // 4. Đặt tên cột
                if (dgvBaoCao.Columns["Thang"] != null)
                    dgvBaoCao.Columns["Thang"].HeaderText = "Tháng";
                if (dgvBaoCao.Columns["Nam"] != null)
                    dgvBaoCao.Columns["Nam"].HeaderText = "Năm";
            }

            // --- PHẦN CHUNG CHO CẢ 2 ---

            // Định dạng cột tiền (Dấu phẩy ngăn cách hàng nghìn)
            if (dgvBaoCao.Columns["DoanhThu"] != null)
            {
                dgvBaoCao.Columns["DoanhThu"].HeaderText = "Doanh Thu (VNĐ)";
                dgvBaoCao.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
                dgvBaoCao.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvBaoCao.Columns["DoanhThu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Hiển thị tổng tiền lên Label
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + " VNĐ";
        }

        // Không cần xử lý định dạng ở sự kiện này nữa, đã xử lý ngay nút Xem rồi
        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e) { }
        private void cboTheo_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}