namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    partial class FormBanThuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTenThuoc = new System.Windows.Forms.ComboBox();
            this.cbxKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.dgvBanThuoc = new System.Windows.Forms.DataGridView();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khách";
            // 
            // cbxTenThuoc
            // 
            this.cbxTenThuoc.FormattingEnabled = true;
            this.cbxTenThuoc.Location = new System.Drawing.Point(78, 36);
            this.cbxTenThuoc.Name = "cbxTenThuoc";
            this.cbxTenThuoc.Size = new System.Drawing.Size(282, 21);
            this.cbxTenThuoc.TabIndex = 3;
            this.cbxTenThuoc.Leave += new System.EventHandler(this.cbxTenThuoc_Leave);
            // 
            // cbxKhachHang
            // 
            this.cbxKhachHang.FormattingEnabled = true;
            this.cbxKhachHang.Location = new System.Drawing.Point(78, 72);
            this.cbxKhachHang.Name = "cbxKhachHang";
            this.cbxKhachHang.Size = new System.Drawing.Size(282, 21);
            this.cbxKhachHang.TabIndex = 4;
            this.cbxKhachHang.Leave += new System.EventHandler(this.cbxKhachHang_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng Tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTongTien.Location = new System.Drawing.Point(724, 400);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(19, 20);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "0";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(425, 36);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(88, 20);
            this.tbSoLuong.TabIndex = 7;
            this.tbSoLuong.Text = "1";
            this.tbSoLuong.Leave += new System.EventHandler(this.tbSoLuong_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giảm Giá";
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(597, 37);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(88, 20);
            this.tbGiamGia.TabIndex = 9;
            this.tbGiamGia.Text = "0";
            this.tbGiamGia.Leave += new System.EventHandler(this.tbGiamGia_Leave);
            // 
            // dgvBanThuoc
            // 
            this.dgvBanThuoc.AllowUserToAddRows = false;
            this.dgvBanThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanThuoc.Location = new System.Drawing.Point(78, 111);
            this.dgvBanThuoc.Name = "dgvBanThuoc";
            this.dgvBanThuoc.Size = new System.Drawing.Size(744, 286);
            this.dgvBanThuoc.TabIndex = 11;
            this.dgvBanThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanThuoc_CellClick);
            this.dgvBanThuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanThuoc_CellDoubleClick);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHoaDon.Location = new System.Drawing.Point(618, 437);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(204, 41);
            this.btnLuuHoaDon.TabIndex = 12;
            this.btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(12, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 48);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemVaoDon
            // 
            this.btnThemVaoDon.Location = new System.Drawing.Point(541, 75);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(144, 23);
            this.btnThemVaoDon.TabIndex = 14;
            this.btnThemVaoDon.Text = "Thêm Vào Đơn";
            this.btnThemVaoDon.UseVisualStyleBackColor = true;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);
            // 
            // FormBanThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnThemVaoDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.dgvBanThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGiamGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxKhachHang);
            this.Controls.Add(this.cbxTenThuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanThuoc";
            this.Text = "FormBanThuoc";
            this.Load += new System.EventHandler(this.FormBanThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTenThuoc;
        private System.Windows.Forms.ComboBox cbxKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.DataGridView dgvBanThuoc;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemVaoDon;
    }
}