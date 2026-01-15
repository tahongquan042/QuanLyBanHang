namespace QuanLyBanHang.UI
{
    partial class frmHoaDonBan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblGioHang = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Location = new System.Drawing.Point(18, 50);
            this.dgvHanghoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.RowHeadersWidth = 51;
            this.dgvHanghoa.RowTemplate.Height = 29;
            this.dgvHanghoa.Size = new System.Drawing.Size(900, 312);
            this.dgvHanghoa.TabIndex = 0;
            this.dgvHanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanghoa_CellClick);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(945, 50);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 29;
            this.dgvGioHang.Size = new System.Drawing.Size(950, 312);
            this.dgvGioHang.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenu.Location = new System.Drawing.Point(15, 1);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(166, 45);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Hàng hóa";
            // 
            // lblGioHang
            // 
            this.lblGioHang.AutoSize = true;
            this.lblGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGioHang.Location = new System.Drawing.Point(945, 1);
            this.lblGioHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioHang.Name = "lblGioHang";
            this.lblGioHang.Size = new System.Drawing.Size(313, 45);
            this.lblGioHang.TabIndex = 3;
            this.lblGioHang.Text = "Giỏ hàng của khách";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(940, 488);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(133, 25);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Khách hàng:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(21, 438);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(148, 25);
            this.lblMaSP.TabIndex = 5;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(21, 488);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(155, 25);
            this.lblTenSP.TabIndex = 6;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(21, 538);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(103, 25);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Location = new System.Drawing.Point(1089, 488);
            this.cboKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(214, 33);
            this.cboKhachHang.TabIndex = 9;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(225, 488);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(298, 31);
            this.txtTenSP.TabIndex = 11;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(225, 538);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(150, 31);
            this.numSoLuong.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(603, 417);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 50);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(603, 479);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(603, 541);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 50);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(1274, 391);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(140, 25);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền (₫):";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1015, 626);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(225, 56);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(1364, 626);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(225, 56);
            this.btnXuatExcel.TabIndex = 24;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1469, 385);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(151, 31);
            this.txtTongTien.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(940, 541);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(154, 25);
            this.lblSDT.TabIndex = 29;
            this.lblSDT.Text = "Số Điện Thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1089, 538);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 31);
            this.txtSDT.TabIndex = 31;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(603, 607);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 50);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 600);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tìm kiếm:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(225, 597);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(298, 31);
            this.txtTimKiem.TabIndex = 34;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtMaNV.Location = new System.Drawing.Point(1089, 382);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(169, 31);
            this.txtMaNV.TabIndex = 39;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(225, 432);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(298, 31);
            this.txtMaSP.TabIndex = 40;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1429);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dgvHanghoa);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblGioHang);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXuatExcel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý hóa đơn bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblGioHang;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaSP;
    }
}
