using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.View.NhanVien
{
    public partial class FormThongKeNhanVien : Form
    {
        public FormThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void cbxMonthFrom_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxMonthFrom.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxMonthFrom.SelectedIndex = 1;
            }
            else
            {
                if (cbxMonthFrom.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn tháng từ 1 tới 12");
                }
            }
        }

        private void cbxMonthTo_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxMonthTo.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxMonthTo.SelectedIndex = 1;
            }
            else
            {
                if (cbxMonthTo.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn tháng từ 1 tới 12");
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int monthFrom = Int32.Parse(cbxMonthFrom.Text);
            int monthTo = Int32.Parse(cbxMonthTo.Text);

            if (monthFrom > monthTo)
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng chọn tháng kết thúc lớn hơn tháng bắt đầu để thống kê");
                cbxMonthTo.Focus();
            }
            else if (monthTo == monthFrom)
            {
                DialogResult result = TienIch.ShowXacThuc("Xác thực", "Bạn chọn tháng bắt đầu và tháng kết thúc giống nhau,\nchương trình sẽ chỉ thống kê họ tên, tổng tiền của 2 nhân viên bán được ít tiền nhất trong tháng " + monthFrom.ToString() + " này.");
                if (result == DialogResult.Yes)
                {
                    ThongKeNhanVien(monthFrom, monthTo);
                }
                else
                {
                    TienIch.ShowThanhCong("", "Hãy chọn lại tháng để bắt đầu thống kê.");
                    cbxMonthFrom.Focus();
                }
            }
            else
            {
                ThongKeNhanVien(monthFrom, monthTo);
            }
        }

        private void ThongKeNhanVien(int monthFrom, int monthTo)
        {
            string sqlSelect = "select distinct top 2 h.IdNhanVien, (select nv.Ten from NhanVien nv where nv.Id=h.IdNhanVien) as 'Họ Và Tên', " +
                " (select sum(h2.TongTien) from HoaDonNhap h2 where h2.IdNhanVien = h.IdNhanVien and MONTH(h2.NgayNhap) >= " + monthFrom + " and MONTH(h2.NgayNhap)<= " + monthTo + " ) as 'Tổng Tiền' " +
                " from HoaDonNhap h " +
                " where MONTH(h.NgayNhap) >= " + monthFrom + " and MONTH(h.NgayNhap)<= " + monthTo + " " +
                " order by[Tổng Tiền]";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThongKeNhanVien.DataSource = tbl;
            dgvThongKeNhanVien.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvThongKeNhanVien.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvThongKeNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvThongKeNhanVien.Columns[1].HeaderText = "Họ Và Tên";
            dgvThongKeNhanVien.Columns[2].HeaderText = "Tổng Tiền";

        }

        private void FormThongKeNhanVien_Load(object sender, EventArgs e)
        {
            cbxMonthFrom.SelectedIndex = 0;
            cbxMonthTo.SelectedIndex = 4;
        }
    }
}
