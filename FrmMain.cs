
using QuanLyBanHang.BLL;
using QuanLyBanHang.UI;
using System;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"👋Xin chào, {Session.TenDangNhap}";
            if (Session.VaiTro == "NhanVien")
            {
                mnuSanPham.Visible = false;
                mnuBaoCao.Visible = false;
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmSanPham)
                {
                    f.BringToFront();
                    return;
                }
            }
            FrmSanPham frm = new FrmSanPham();
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmKhachHang)
                {
                    f.BringToFront();
                    return;
                }
            }
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmHoaDonBan)
                {
                    f.BringToFront();
                    return;
                }
            }
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmBaoCao)
                {
                    f.BringToFront();
                    return;
                }
            }
            frmBaoCao frm = new frmBaoCao();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mnuSanPham.Visible = false;
            mnuKhachHang.Visible = false;
            mnuHoaDon.Visible = true;
            mnuBaoCao.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mnuSanPham.Visible = true;
            mnuKhachHang.Visible = true;
            mnuHoaDon.Visible = true;
            mnuBaoCao.Visible = true;
        }

    }
}
