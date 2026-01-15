using quanlybanhang;
using QuanLyBanHang.BLL;
using QuanLyBanHang.Entities;
using System;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace coffee_management
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Validate
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Bạn phải nhập mật khẩu");
                txtPass.Focus();
                return;
            }

            // 2. Gọi BLL (Entity Framework)
            TaiKhoan tk = tkBLL.DangNhap(txtUser.Text.Trim(), txtPass.Text.Trim());

            if (tk == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            if (tk != null)
            {
                Session.MaNhanVien = tk.MaTK;
                Session.TenDangNhap = tk.TenDangNhap;
                Session.VaiTro = tk.VaiTro;

                FrmMain f = new FrmMain();
                f.Show();
                this.Hide();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = chkShowPass.Checked ? '\0' : '*';
        }
    }
}
