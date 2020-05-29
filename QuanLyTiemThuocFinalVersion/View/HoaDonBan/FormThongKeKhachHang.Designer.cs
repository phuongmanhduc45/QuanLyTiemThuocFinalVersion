namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    partial class FormThongKeKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelThongKeKhachHang = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnTaiLaiBang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelThongKeKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màn hình thống kê khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelThongKeKhachHang);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 437);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelThongKeKhachHang
            // 
            this.panelThongKeKhachHang.Controls.Add(this.dgvKhachHang);
            this.panelThongKeKhachHang.Controls.Add(this.btnTaiLaiBang);
            this.panelThongKeKhachHang.Controls.Add(this.btnXoa);
            this.panelThongKeKhachHang.Controls.Add(this.btnTimKiem);
            this.panelThongKeKhachHang.Controls.Add(this.btnThem);
            this.panelThongKeKhachHang.Controls.Add(this.tbDiaChi);
            this.panelThongKeKhachHang.Controls.Add(this.tbSoDienThoai);
            this.panelThongKeKhachHang.Controls.Add(this.tbTen);
            this.panelThongKeKhachHang.Controls.Add(this.lblSoDienThoai);
            this.panelThongKeKhachHang.Controls.Add(this.lblTen);
            this.panelThongKeKhachHang.Controls.Add(this.lblDiaChi);
            this.panelThongKeKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongKeKhachHang.Location = new System.Drawing.Point(0, 0);
            this.panelThongKeKhachHang.Name = "panelThongKeKhachHang";
            this.panelThongKeKhachHang.Size = new System.Drawing.Size(834, 437);
            this.panelThongKeKhachHang.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(713, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(713, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(175, 59);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(511, 20);
            this.tbDiaChi.TabIndex = 4;
            this.tbDiaChi.Leave += new System.EventHandler(this.tbDiaChi_Leave);
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(484, 21);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(202, 20);
            this.tbSoDienThoai.TabIndex = 3;
            this.tbSoDienThoai.Leave += new System.EventHandler(this.tbSoDienThoai_Leave);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(175, 18);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(202, 20);
            this.tbTen.TabIndex = 2;
            this.tbTen.Leave += new System.EventHandler(this.tbTen_Leave);
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(403, 21);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(75, 13);
            this.lblSoDienThoai.TabIndex = 1;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(132, 21);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(128, 62);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // btnTaiLaiBang
            // 
            this.btnTaiLaiBang.Location = new System.Drawing.Point(12, 11);
            this.btnTaiLaiBang.Name = "btnTaiLaiBang";
            this.btnTaiLaiBang.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiBang.TabIndex = 9;
            this.btnTaiLaiBang.Text = "Tải Lại Bảng";
            this.btnTaiLaiBang.UseVisualStyleBackColor = true;
            this.btnTaiLaiBang.Click += new System.EventHandler(this.btnTaiLaiBang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 97);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(834, 340);
            this.dgvKhachHang.TabIndex = 10;
            this.dgvKhachHang.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvKhachHang_CellBeginEdit);
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellEndEdit);
            // 
            // FormThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKeKhachHang";
            this.Text = "FormThongKeKhachHang";
            this.Load += new System.EventHandler(this.FormThongKeKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panelThongKeKhachHang.ResumeLayout(false);
            this.panelThongKeKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelThongKeKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button btnTaiLaiBang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvKhachHang;
    }
}