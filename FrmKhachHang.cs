using QuanLyBanHang.BLL;
using System;
using QuanLyBanHang.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class frmKhachHang : Form
    {
        private KhachHangBLL khBLL = new KhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvKhachHang.DataSource = khBLL.GetAll();
            dgvKhachHang.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang()
                {
                    TenKH = txtTenKH.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                khBLL.Insert(kh);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHang kh = new KhachHang()
                {
                    MaKH = int.Parse(txtMaKH.Text),
                    TenKH = txtTenKH.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                khBLL.Update(kh);
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int MaKH = int.Parse(txtMaKH.Text);
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    khBLL.Delete(MaKH);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvKhachHang.DataSource = khBLL.Search(keyword);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
