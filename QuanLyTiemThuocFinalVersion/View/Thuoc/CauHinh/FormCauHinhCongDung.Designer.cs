﻿namespace QuanLyTiemThuocFinalVersion.View.Thuoc.CauHinh
{
    partial class FormCauHinhCongDung
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
            this.dgvCongDung = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấu hình công dụng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTaiLaiBang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 437);
            this.panel1.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(15, 341);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(15, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLaiBang
            // 
            this.btnTaiLaiBang.Location = new System.Drawing.Point(12, 91);
            this.btnTaiLaiBang.Name = "btnTaiLaiBang";
            this.btnTaiLaiBang.Size = new System.Drawing.Size(75, 23);
            this.btnTaiLaiBang.TabIndex = 0;
            this.btnTaiLaiBang.Text = "Tải Lại Bảng";
            this.btnTaiLaiBang.UseVisualStyleBackColor = true;
            this.btnTaiLaiBang.Click += new System.EventHandler(this.btnTaiLaiBang_Click);
            // 
            // dgvCongDung
            // 
            this.dgvCongDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongDung.Location = new System.Drawing.Point(105, 24);
            this.dgvCongDung.Name = "dgvCongDung";
            this.dgvCongDung.Size = new System.Drawing.Size(729, 437);
            this.dgvCongDung.TabIndex = 2;
            this.dgvCongDung.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCongDung_CellBeginEdit);
            this.dgvCongDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongDung_CellClick);
            this.dgvCongDung.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongDung_CellEndEdit);
            // 
            // FormCauHinhCongDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dgvCongDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCauHinhCongDung";
            this.Text = "FormCauHinhCongDung";
            this.Load += new System.EventHandler(this.FormCauHinhCongDung_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLaiBang;
        private System.Windows.Forms.DataGridView dgvCongDung;
    }
}