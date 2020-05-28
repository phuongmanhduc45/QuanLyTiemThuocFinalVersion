namespace QuanLyTiemThuocFinalVersion
{
    partial class formMain
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
            this.menuContainer = new System.Windows.Forms.MenuStrip();
            this.menuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanThuocMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCauHinhThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.côngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinhDonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinhDangDieuChe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinhNuocSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVienContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCauHinhNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinhChuyenMon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinhTrinhDo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrangChu,
            this.menuBanThuocContainer,
            this.menuNhapThuocContainer,
            this.menuThuocContainer,
            this.menuNhanVienContainer});
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(884, 24);
            this.menuContainer.TabIndex = 0;
            // 
            // menuTrangChu
            // 
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Size = new System.Drawing.Size(73, 20);
            this.menuTrangChu.Text = "Trang Chủ";
            this.menuTrangChu.Click += new System.EventHandler(this.menuTrangChu_Click);
            // 
            // menuBanThuocContainer
            // 
            this.menuBanThuocContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanThuocMain,
            this.menuThongKeHoaDonBan,
            this.menuThongKeKhachHang});
            this.menuBanThuocContainer.Name = "menuBanThuocContainer";
            this.menuBanThuocContainer.Size = new System.Drawing.Size(75, 20);
            this.menuBanThuocContainer.Text = "Bán Thuốc";
            // 
            // menuBanThuocMain
            // 
            this.menuBanThuocMain.Name = "menuBanThuocMain";
            this.menuBanThuocMain.Size = new System.Drawing.Size(197, 22);
            this.menuBanThuocMain.Text = "Bán";
            this.menuBanThuocMain.Click += new System.EventHandler(this.menuBanThuocMain_Click);
            // 
            // menuThongKeHoaDonBan
            // 
            this.menuThongKeHoaDonBan.Name = "menuThongKeHoaDonBan";
            this.menuThongKeHoaDonBan.Size = new System.Drawing.Size(197, 22);
            this.menuThongKeHoaDonBan.Text = "Thống Kê Hóa Đơn Bán";
            this.menuThongKeHoaDonBan.Click += new System.EventHandler(this.menuThongKeHoaDonBan_Click);
            // 
            // menuThongKeKhachHang
            // 
            this.menuThongKeKhachHang.Name = "menuThongKeKhachHang";
            this.menuThongKeKhachHang.Size = new System.Drawing.Size(197, 22);
            this.menuThongKeKhachHang.Text = "Thống Kê Khách Hàng";
            this.menuThongKeKhachHang.Click += new System.EventHandler(this.menuThongKeKhachHang_Click);
            // 
            // menuNhapThuocContainer
            // 
            this.menuNhapThuocContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiHoaDonNhap,
            this.menuThongKeHoaDonNhap,
            this.toolStripSeparator1,
            this.menuNhaCungCap});
            this.menuNhapThuocContainer.Name = "menuNhapThuocContainer";
            this.menuNhapThuocContainer.Size = new System.Drawing.Size(84, 20);
            this.menuNhapThuocContainer.Text = "Nhập Thuốc";
            // 
            // menuThemMoiHoaDonNhap
            // 
            this.menuThemMoiHoaDonNhap.Name = "menuThemMoiHoaDonNhap";
            this.menuThemMoiHoaDonNhap.Size = new System.Drawing.Size(210, 22);
            this.menuThemMoiHoaDonNhap.Text = "Thêm Mới Hóa Đơn Nhập";
            this.menuThemMoiHoaDonNhap.Click += new System.EventHandler(this.menuThemMoiHoaDonNhap_Click);
            // 
            // menuThongKeHoaDonNhap
            // 
            this.menuThongKeHoaDonNhap.Name = "menuThongKeHoaDonNhap";
            this.menuThongKeHoaDonNhap.Size = new System.Drawing.Size(210, 22);
            this.menuThongKeHoaDonNhap.Text = "Thống Kê Hóa Đơn Nhập";
            this.menuThongKeHoaDonNhap.Click += new System.EventHandler(this.menuThongKeHoaDonNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // menuNhaCungCap
            // 
            this.menuNhaCungCap.Name = "menuNhaCungCap";
            this.menuNhaCungCap.Size = new System.Drawing.Size(210, 22);
            this.menuNhaCungCap.Text = "Nhà Cung Cấp";
            this.menuNhaCungCap.Click += new System.EventHandler(this.menuNhaCungCap_Click);
            // 
            // menuThuocContainer
            // 
            this.menuThuocContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiThuoc,
            this.menuThongKeThuoc,
            this.toolStripSeparator2,
            this.menuCauHinhThuoc});
            this.menuThuocContainer.Name = "menuThuocContainer";
            this.menuThuocContainer.Size = new System.Drawing.Size(52, 20);
            this.menuThuocContainer.Text = "Thuốc";
            // 
            // menuThemMoiThuoc
            // 
            this.menuThemMoiThuoc.Name = "menuThemMoiThuoc";
            this.menuThemMoiThuoc.Size = new System.Drawing.Size(180, 22);
            this.menuThemMoiThuoc.Text = "Thêm Mới";
            this.menuThemMoiThuoc.Click += new System.EventHandler(this.menuThemMoiThuoc_Click);
            // 
            // menuThongKeThuoc
            // 
            this.menuThongKeThuoc.Name = "menuThongKeThuoc";
            this.menuThongKeThuoc.Size = new System.Drawing.Size(180, 22);
            this.menuThongKeThuoc.Text = "Thống Kê Thuốc";
            this.menuThongKeThuoc.Click += new System.EventHandler(this.menuThongKeThuoc_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuCauHinhThuoc
            // 
            this.menuCauHinhThuoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngDụngToolStripMenuItem,
            this.menuCauHinhDonViTinh,
            this.menuCauHinhDangDieuChe,
            this.menuCauHinhNuocSanXuat});
            this.menuCauHinhThuoc.Name = "menuCauHinhThuoc";
            this.menuCauHinhThuoc.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhThuoc.Text = "Cấu Hình";
            // 
            // côngDụngToolStripMenuItem
            // 
            this.côngDụngToolStripMenuItem.Name = "côngDụngToolStripMenuItem";
            this.côngDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.côngDụngToolStripMenuItem.Text = "Công Dụng";
            // 
            // menuCauHinhDonViTinh
            // 
            this.menuCauHinhDonViTinh.Name = "menuCauHinhDonViTinh";
            this.menuCauHinhDonViTinh.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhDonViTinh.Text = "Đơn Vị Tính";
            this.menuCauHinhDonViTinh.Click += new System.EventHandler(this.menuCauHinhDonViTinh_Click);
            // 
            // menuCauHinhDangDieuChe
            // 
            this.menuCauHinhDangDieuChe.Name = "menuCauHinhDangDieuChe";
            this.menuCauHinhDangDieuChe.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhDangDieuChe.Text = "Dạng Điều Chế";
            this.menuCauHinhDangDieuChe.Click += new System.EventHandler(this.menuCauHinhDangDieuChe_Click);
            // 
            // menuCauHinhNuocSanXuat
            // 
            this.menuCauHinhNuocSanXuat.Name = "menuCauHinhNuocSanXuat";
            this.menuCauHinhNuocSanXuat.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhNuocSanXuat.Text = "Nước Sản Xuất";
            this.menuCauHinhNuocSanXuat.Click += new System.EventHandler(this.menuCauHinhNuocSanXuat_Click);
            // 
            // menuNhanVienContainer
            // 
            this.menuNhanVienContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiNhanVien,
            this.menuThongKeNhanVien,
            this.toolStripSeparator3,
            this.menuCauHinhNhanVien});
            this.menuNhanVienContainer.Name = "menuNhanVienContainer";
            this.menuNhanVienContainer.Size = new System.Drawing.Size(74, 20);
            this.menuNhanVienContainer.Text = "Nhân Viên";
            // 
            // menuThemMoiNhanVien
            // 
            this.menuThemMoiNhanVien.Name = "menuThemMoiNhanVien";
            this.menuThemMoiNhanVien.Size = new System.Drawing.Size(182, 22);
            this.menuThemMoiNhanVien.Text = "Thêm Mới";
            this.menuThemMoiNhanVien.Click += new System.EventHandler(this.menuThemMoiNhanVien_Click);
            // 
            // menuThongKeNhanVien
            // 
            this.menuThongKeNhanVien.Name = "menuThongKeNhanVien";
            this.menuThongKeNhanVien.Size = new System.Drawing.Size(182, 22);
            this.menuThongKeNhanVien.Text = "Thống Kê Nhân Viên";
            this.menuThongKeNhanVien.Click += new System.EventHandler(this.menuThongKeNhanVien_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // menuCauHinhNhanVien
            // 
            this.menuCauHinhNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCauHinhChuyenMon,
            this.menuCauHinhTrinhDo});
            this.menuCauHinhNhanVien.Name = "menuCauHinhNhanVien";
            this.menuCauHinhNhanVien.Size = new System.Drawing.Size(182, 22);
            this.menuCauHinhNhanVien.Text = "Cấu Hình";
            // 
            // menuCauHinhChuyenMon
            // 
            this.menuCauHinhChuyenMon.Name = "menuCauHinhChuyenMon";
            this.menuCauHinhChuyenMon.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhChuyenMon.Text = "Chuyên Môn";
            this.menuCauHinhChuyenMon.Click += new System.EventHandler(this.menuCauHinhChuyenMon_Click);
            // 
            // menuCauHinhTrinhDo
            // 
            this.menuCauHinhTrinhDo.Name = "menuCauHinhTrinhDo";
            this.menuCauHinhTrinhDo.Size = new System.Drawing.Size(180, 22);
            this.menuCauHinhTrinhDo.Text = "Trình Độ";
            this.menuCauHinhTrinhDo.Click += new System.EventHandler(this.menuCauHinhTrinhDo_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.menuContainer);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuContainer;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tiệm Thuốc";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuContainer;
        public System.Windows.Forms.ToolStripMenuItem menuTrangChu;
        public System.Windows.Forms.ToolStripMenuItem menuBanThuocContainer;
        public System.Windows.Forms.ToolStripMenuItem menuBanThuocMain;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeHoaDonBan;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeKhachHang;
        public System.Windows.Forms.ToolStripMenuItem menuNhapThuocContainer;
        public System.Windows.Forms.ToolStripMenuItem menuThemMoiHoaDonNhap;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeHoaDonNhap;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem menuNhaCungCap;
        public System.Windows.Forms.ToolStripMenuItem menuThuocContainer;
        public System.Windows.Forms.ToolStripMenuItem menuThemMoiThuoc;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeThuoc;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhThuoc;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhDonViTinh;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhDangDieuChe;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhNuocSanXuat;
        public System.Windows.Forms.ToolStripMenuItem menuNhanVienContainer;
        public System.Windows.Forms.ToolStripMenuItem menuThemMoiNhanVien;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeNhanVien;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhNhanVien;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhChuyenMon;
        public System.Windows.Forms.ToolStripMenuItem menuCauHinhTrinhDo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem côngDụngToolStripMenuItem;
    }
}

