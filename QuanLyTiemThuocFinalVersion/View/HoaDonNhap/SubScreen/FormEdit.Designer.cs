namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap.SubScreen
{
    partial class FormEditChuyenMonTrinhDo
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
            this.cbxEdit = new System.Windows.Forms.ComboBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnEditLưu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxEdit
            // 
            this.cbxEdit.FormattingEnabled = true;
            this.cbxEdit.Location = new System.Drawing.Point(53, 99);
            this.cbxEdit.Name = "cbxEdit";
            this.cbxEdit.Size = new System.Drawing.Size(258, 21);
            this.cbxEdit.TabIndex = 0;
            this.cbxEdit.Leave += new System.EventHandler(this.cbxEdit_Leave);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(12, 102);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(35, 13);
            this.lblEdit.TabIndex = 1;
            this.lblEdit.Text = "label1";
            // 
            // btnEditLưu
            // 
            this.btnEditLưu.Location = new System.Drawing.Point(121, 180);
            this.btnEditLưu.Name = "btnEditLưu";
            this.btnEditLưu.Size = new System.Drawing.Size(75, 23);
            this.btnEditLưu.TabIndex = 2;
            this.btnEditLưu.Text = "Lưu";
            this.btnEditLưu.UseVisualStyleBackColor = true;
            this.btnEditLưu.Click += new System.EventHandler(this.btnEditLưu_Click);
            // 
            // FormEditChuyenMonTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 273);
            this.Controls.Add(this.btnEditLưu);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.cbxEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditChuyenMonTrinhDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnEditLưu;
    }
}