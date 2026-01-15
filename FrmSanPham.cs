using System;
using QuanLyBanHang.BLL;
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
    public partial class FrmSanPham : Form
    {
        SanPhamBLL spBLL = new SanPhamBLL();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text))
            {
                MessageBox.Show("Nhập tên sản phẩm");
                txtTenSP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDonGia.Text) || !decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Nhập đúng giá sản phẩm");
                txtDonGia.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Nhập đúng số lượng tồn");
                txtSoLuong.Focus();
                return;
            }
            SanPham sp = new SanPham
            {
                TenSP = txtTenSP.Text,
                DonGia = decimal.Parse(txtDonGia.Text),
                SoLuongTon = int.Parse(txtSoLuong.Text)
            };

            if (spBLL.Add(sp))
            {
                MessageBox.Show("Thêm thành công");
                dgvSanPham.DataSource = spBLL.GetAll();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = dgvSanPham.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSP = (int)dgvSanPham.CurrentRow.Cells["MaSP"].Value;

            SanPham sp = new SanPham
            {
                MaSP = maSP,
                TenSP = txtTenSP.Text,
                DonGia = decimal.Parse(txtDonGia.Text),
                SoLuongTon = int.Parse(txtSoLuong.Text)
            };

            if (spBLL.Update(sp))
            {
                MessageBox.Show("Sửa thành công");
                dgvSanPham.DataSource = spBLL.GetAll();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSP = (int)dgvSanPham.CurrentRow.Cells["MaSP"].Value;

            if (spBLL.Delete(maSP))
            {
                MessageBox.Show("Xóa thành công");
                dgvSanPham.DataSource = spBLL.GetAll();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.Search(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
