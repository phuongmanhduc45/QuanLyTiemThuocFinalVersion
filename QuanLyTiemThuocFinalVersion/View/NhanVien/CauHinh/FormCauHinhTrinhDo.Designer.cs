namespace QuanLyTiemThuocFinalVersion.View.NhanVien.CauHinh
{
    partial class FormCauHinhTrinhDo
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLaiBang = new System.Windows.Forms.Button();
            this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấu hình trình độ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTaiLaiBang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 476);
            this.panel1.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 366);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLaiBang
            // 
            this.btnTaiLaiBang.Location = new System.Drawing.Point(12, 82);
            this.btnTaiLaiBang.Name = "btnTaiLaiBang";
            this.btnTaiLaiBang.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiBang.TabIndex = 0;
            this.btnTaiLaiBang.Text = "Tải Lại Bảng";
            this.btnTaiLaiBang.UseVisualStyleBackColor = true;
            this.btnTaiLaiBang.Click += new System.EventHandler(this.btnTaiLaiBang_Click);
            // 
            // dgvTrinhDo
            // 
            this.dgvTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrinhDo.Location = new System.Drawing.Point(108, 24);
            this.dgvTrinhDo.Name = "dgvTrinhDo";
            this.dgvTrinhDo.Size = new System.Drawing.Size(742, 476);
            this.dgvTrinhDo.TabIndex = 2;
            this.dgvTrinhDo.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTrinhDo_CellBeginEdit);
            this.dgvTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellClick);
            this.dgvTrinhDo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellEndEdit);
            // 
            // FormCauHinhTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.dgvTrinhDo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCauHinhTrinhDo";
            this.Text = "FormCauHinhTrinhDo";
            this.Load += new System.EventHandler(this.FormCauHinhTrinhDo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLaiBang;
        private System.Windows.Forms.DataGridView dgvTrinhDo;
    }
}