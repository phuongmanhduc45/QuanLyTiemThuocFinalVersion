namespace QuanLyTiemThuocFinalVersion.View.Thuoc.CauHinh
{
    partial class FormCauHinhNuocSanXuat
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
            this.panelBtnContainer = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLaiBang = new System.Windows.Forms.Button();
            this.dgvNuocSanXuat = new System.Windows.Forms.DataGridView();
            this.panelBtnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấu hình nước sản xuất";
            // 
            // panelBtnContainer
            // 
            this.panelBtnContainer.Controls.Add(this.btnLuu);
            this.panelBtnContainer.Controls.Add(this.btnXoa);
            this.panelBtnContainer.Controls.Add(this.btnTaiLaiBang);
            this.panelBtnContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtnContainer.Location = new System.Drawing.Point(0, 24);
            this.panelBtnContainer.Name = "panelBtnContainer";
            this.panelBtnContainer.Size = new System.Drawing.Size(99, 437);
            this.panelBtnContainer.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 336);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLaiBang
            // 
            this.btnTaiLaiBang.Location = new System.Drawing.Point(12, 95);
            this.btnTaiLaiBang.Name = "btnTaiLaiBang";
            this.btnTaiLaiBang.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiBang.TabIndex = 0;
            this.btnTaiLaiBang.Text = "Tải Lại Bảng";
            this.btnTaiLaiBang.UseVisualStyleBackColor = true;
            this.btnTaiLaiBang.Click += new System.EventHandler(this.btnTaiLaiBang_Click);
            // 
            // dgvNuocSanXuat
            // 
            this.dgvNuocSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuocSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNuocSanXuat.Location = new System.Drawing.Point(99, 24);
            this.dgvNuocSanXuat.Name = "dgvNuocSanXuat";
            this.dgvNuocSanXuat.Size = new System.Drawing.Size(735, 437);
            this.dgvNuocSanXuat.TabIndex = 2;
            this.dgvNuocSanXuat.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvNuocSanXuat_CellBeginEdit);
            this.dgvNuocSanXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuocSanXuat_CellClick);
            this.dgvNuocSanXuat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuocSanXuat_CellEndEdit);
            // 
            // FormCauHinhNuocSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dgvNuocSanXuat);
            this.Controls.Add(this.panelBtnContainer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCauHinhNuocSanXuat";
            this.Text = "FormCauHinhNuocSanXuat";
            this.Load += new System.EventHandler(this.FormCauHinhNuocSanXuat_Load);
            this.panelBtnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocSanXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBtnContainer;
        private System.Windows.Forms.Button btnTaiLaiBang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvNuocSanXuat;
    }
}