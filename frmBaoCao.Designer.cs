namespace quanlybanhang
{
    partial class frmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboTheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn xem theo";
            // 
            // cboTheo
            // 
            this.cboTheo.FormattingEnabled = true;
            this.cboTheo.Location = new System.Drawing.Point(538, 44);
            this.cboTheo.Name = "cboTheo";
            this.cboTheo.Size = new System.Drawing.Size(121, 33);
            this.cboTheo.TabIndex = 1;
            this.cboTheo.SelectedIndexChanged += new System.EventHandler(this.cboTheo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(580, 124);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 31);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(580, 213);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 31);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1075, 91);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(109, 49);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(201, 401);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 82;
            this.dgvBaoCao.RowTemplate.Height = 33;
            this.dgvBaoCao.Size = new System.Drawing.Size(946, 292);
            this.dgvBaoCao.TabIndex = 7;
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoCao_CellContentClick);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(556, 338);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(173, 25);
            this.lblTongDoanhThu.TabIndex = 8;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 778);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTheo);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTheo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}