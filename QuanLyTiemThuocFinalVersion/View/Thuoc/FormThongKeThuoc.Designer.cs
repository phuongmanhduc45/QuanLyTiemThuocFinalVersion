namespace QuanLyTiemThuocFinalVersion.View.Thuoc
{
    partial class FormThongKeThuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbThanhPhan = new System.Windows.Forms.TextBox();
            this.clbCongDung = new System.Windows.Forms.CheckedListBox();
            this.cbxCongDung = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxThuoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThuocHetHan = new System.Windows.Forms.Button();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnThemCongDung = new System.Windows.Forms.Button();
            this.btnThongKeThuocConHan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemCongDung);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.tbThanhPhan);
            this.groupBox1.Controls.Add(this.clbCongDung);
            this.groupBox1.Controls.Add(this.cbxCongDung);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxThuoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(699, 63);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 30);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbThanhPhan
            // 
            this.tbThanhPhan.Location = new System.Drawing.Point(92, 73);
            this.tbThanhPhan.Name = "tbThanhPhan";
            this.tbThanhPhan.Size = new System.Drawing.Size(261, 20);
            this.tbThanhPhan.TabIndex = 6;
            this.tbThanhPhan.Leave += new System.EventHandler(this.tbThanhPhan_Leave);
            // 
            // clbCongDung
            // 
            this.clbCongDung.FormattingEnabled = true;
            this.clbCongDung.Location = new System.Drawing.Point(390, 44);
            this.clbCongDung.Name = "clbCongDung";
            this.clbCongDung.Size = new System.Drawing.Size(293, 49);
            this.clbCongDung.TabIndex = 5;
            // 
            // cbxCongDung
            // 
            this.cbxCongDung.FormattingEnabled = true;
            this.cbxCongDung.Location = new System.Drawing.Point(454, 17);
            this.cbxCongDung.Name = "cbxCongDung";
            this.cbxCongDung.Size = new System.Drawing.Size(229, 21);
            this.cbxCongDung.TabIndex = 4;
            this.cbxCongDung.Leave += new System.EventHandler(this.cbxCongDung_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Công Dụng";
            // 
            // cbxThuoc
            // 
            this.cbxThuoc.FormattingEnabled = true;
            this.cbxThuoc.Location = new System.Drawing.Point(92, 17);
            this.cbxThuoc.Name = "cbxThuoc";
            this.cbxThuoc.Size = new System.Drawing.Size(261, 21);
            this.cbxThuoc.TabIndex = 2;
            this.cbxThuoc.Leave += new System.EventHandler(this.cbxThuoc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thành Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thuốc";
            // 
            // btnThuocHetHan
            // 
            this.btnThuocHetHan.Location = new System.Drawing.Point(661, 144);
            this.btnThuocHetHan.Name = "btnThuocHetHan";
            this.btnThuocHetHan.Size = new System.Drawing.Size(155, 23);
            this.btnThuocHetHan.TabIndex = 2;
            this.btnThuocHetHan.Text = "Thống Kê Thuốc Hết Hạn";
            this.btnThuocHetHan.UseVisualStyleBackColor = true;
            this.btnThuocHetHan.Click += new System.EventHandler(this.btnThuocHetHan_Click);
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(152, 144);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnHienTatCa.TabIndex = 5;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(12, 173);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.Size = new System.Drawing.Size(810, 276);
            this.dgvThuoc.TabIndex = 6;
            this.dgvThuoc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvThuoc_CellBeginEdit);
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            this.dgvThuoc.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellEndEdit);
            // 
            // btnThemCongDung
            // 
            this.btnThemCongDung.Location = new System.Drawing.Point(699, 19);
            this.btnThemCongDung.Name = "btnThemCongDung";
            this.btnThemCongDung.Size = new System.Drawing.Size(105, 23);
            this.btnThemCongDung.TabIndex = 7;
            this.btnThemCongDung.Text = "Thêm Công Dụng";
            this.btnThemCongDung.UseVisualStyleBackColor = true;
            this.btnThemCongDung.Click += new System.EventHandler(this.btnThemCongDung_Click);
            // 
            // btnThongKeThuocConHan
            // 
            this.btnThongKeThuocConHan.Location = new System.Drawing.Point(497, 144);
            this.btnThongKeThuocConHan.Name = "btnThongKeThuocConHan";
            this.btnThongKeThuocConHan.Size = new System.Drawing.Size(158, 23);
            this.btnThongKeThuocConHan.TabIndex = 7;
            this.btnThongKeThuocConHan.Text = "Thống Kê Thuốc Còn Hạn";
            this.btnThongKeThuocConHan.UseVisualStyleBackColor = true;
            this.btnThongKeThuocConHan.Click += new System.EventHandler(this.btnThongKeThuocConHan_Click);
            // 
            // FormThongKeThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnThongKeThuocConHan);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnHienTatCa);
            this.Controls.Add(this.btnThuocHetHan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKeThuoc";
            this.Text = "FormThongKeThuoc";
            this.Load += new System.EventHandler(this.FormThongKeThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbThanhPhan;
        private System.Windows.Forms.CheckedListBox clbCongDung;
        private System.Windows.Forms.ComboBox cbxCongDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThuocHetHan;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnThemCongDung;
        private System.Windows.Forms.Button btnThongKeThuocConHan;
    }
}