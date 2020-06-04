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

namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap
{
    public partial class FormThongKeHoaDonNhap : Form
    {
        public FormThongKeHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormThongKeHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDataToCbxHoaDonNhap();
            LoadDataToCbxNhaCungCap();
            LoadDataToCbxNhanVien();
            cbxThang.SelectedIndex = 1;
        }

        private void cbxNhanVien_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxNhanVien.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxNhanVien.Text = cbxValue;
            }
            else
            {
                if (cbxNhanVien.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang nhập tên Nhân Viên mới chưa có trong csdl\n Bạn Có muốn thêm mới Nhân Viên này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsert = "Insert into NhanVien (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsert);
                        LoadDataToCbxNhaCungCap();
                        cbxNhanVien.SelectedIndex = cbxNhanVien.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxNhanVien.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô nhân viên đã bị xóa do bạn không muốn thêm mới Nhân Viên này vào hệ thống.");
                    }
                }
            }
        }

        private void cbxNhaCungCap_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxNhaCungCap.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxNhaCungCap.Text = cbxValue;
            }
            else
            {
                if (cbxNhaCungCap.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Nhà Cung Cấp mới chưa có trong csdl\n Bạn Có muốn thêm mới Nhà Cung Cấp này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertTrinhDo = "Insert into NhaCungCap (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertTrinhDo);
                        LoadDataToCbxNhaCungCap();
                        cbxNhaCungCap.SelectedIndex = cbxNhaCungCap.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxNhaCungCap.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô nhà cung cấp đã bị xóa do bạn không muốn thêm mới Nhà Cung Cấp này vào hệ thống.");
                    }
                }
            }
        }

        private void cbxHoaDonNhap_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxHoaDonNhap.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo", "Không được để trống thông tin này!");
                cbxHoaDonNhap.SelectedIndex = 0;
            }
            else
            {
                if (cbxHoaDonNhap.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Bạn đang nhập mã hóa đơn bán chưa có trong csdl");
                    cbxHoaDonNhap.SelectedIndex = 0;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDonNhap = TienIch.XoaTatCaKhoangTrang(cbxHoaDonNhap.Text);
            string nhanVien = string.IsNullOrEmpty(TienIch.ToTitleCase(cbxNhanVien.Text)) == true ? "" : cbxNhanVien.SelectedValue.ToString();
            string nhaCungCap = string.IsNullOrEmpty(TienIch.ToTitleCase(cbxNhaCungCap.Text)) == true ? "" : cbxNhaCungCap.SelectedValue.ToString();

            string sqlSearch = "Select hdn.Id, nv.Ten, ncc.Ten, hdn.NgayNhap, hdn.TongTien "
                        + " from HoaDonNhap hdn, NhanVien nv, NhaCungCap ncc " +
                        " where hdn.IdNhanVien=nv.Id and hdn.IdNhaCungCap=ncc.Id " +
                        " and hdn.Id=" + maHoaDonNhap +
                        (nhanVien.Length == 0 ? "" : " and hdn.IdNhanVien=" + nhanVien) + " " +
                        (nhaCungCap.Length == 0 ? "" : " and hdn.IdNhaCungCap=" + nhaCungCap);
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSearch);
            dgvHoaDonNhap.DataSource = null;

            dgvHoaDonNhap.DataSource = tbl;
            dgvHoaDonNhap.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvHoaDonNhap.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvHoaDonNhap.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDonNhap.Columns[1].HeaderText = "Nhân Viên";
            dgvHoaDonNhap.Columns[2].HeaderText = "Nhà Cung Cấp";
            dgvHoaDonNhap.Columns[3].HeaderText = "Ngày Nhập";
            dgvHoaDonNhap.Columns[4].HeaderText = "Tổng Tiền";

            foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
            {
                row.Cells[3].Value = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("dd - MM - yyyy");
            }
        }

        private void cbxThang_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxThang.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxThang.SelectedIndex = 1;
            }
            else
            {
                if (cbxThang.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn tháng từ 1 tới 12");
                }
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string thang = TienIch.XoaTatCaKhoangTrang(cbxThang.Text);
            if (string.IsNullOrEmpty(thang))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Không được để trống tháng");
                cbxThang.SelectedIndex = 1;
            }
            else
            {
                if (thang.All(char.IsDigit))
                {
                    string sqlCommand = "Select hdn.Id, nv.Ten, ncc.Ten, hdn.NgayNhap, hdn.TongTien "
                        + " from HoaDonNhap hdn, NhanVien nv, NhaCungCap ncc " +
                        " where hdn.IdNhanVien=nv.Id and hdn.IdNhaCungCap=ncc.Id " +
                        " and MONTH(hdn.NgayNhap)=" + thang;
                    DataTable tbl = DataBaseFunction.GetDataToTable(sqlCommand);
                    dgvHoaDonNhap.DataSource = null;

                    dgvHoaDonNhap.DataSource = tbl;
                    dgvHoaDonNhap.MultiSelect = false;

                    foreach (DataGridViewColumn col in dgvHoaDonNhap.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.ReadOnly = true;
                    }

                    dgvHoaDonNhap.Columns[0].HeaderText = "Mã Hóa Đơn";
                    dgvHoaDonNhap.Columns[1].HeaderText = "Nhân Viên";
                    dgvHoaDonNhap.Columns[2].HeaderText = "Nhà Cung Cấp";
                    dgvHoaDonNhap.Columns[3].HeaderText = "Ngày Nhập";
                    dgvHoaDonNhap.Columns[4].HeaderText = "Tổng Tiền";

                    foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                    {
                        row.Cells[3].Value = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("dd - MM - yyyy");
                    }
                }
                else
                {
                    cbxThang.SelectedIndex = 1;
                    TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng chọn tháng từ 1 tới 12.");
                }
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = null;
            LoadDataToTable();
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region common function

        private void LoadDataToCbxHoaDonNhap()
        {
            cbxHoaDonNhap.DataSource = null;
            string sqlSelect = "Select Id from HoaDonNhap";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxHoaDonNhap.DataSource = tbl;
            cbxHoaDonNhap.DisplayMember = "Id";
            cbxHoaDonNhap.ValueMember = "Id";
            cbxHoaDonNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxHoaDonNhap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNhanVien()
        {
            string sqlSelect = "Select Id, Ten from NhanVien";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxNhanVien.DataSource = tbl;
            cbxNhanVien.DisplayMember = "Ten";
            cbxNhanVien.ValueMember = "Id";
            cbxNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNhaCungCap()
        {
            string sqlSelect = "Select Id, Ten from NhaCungCap";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxNhaCungCap.DataSource = tbl;
            cbxNhaCungCap.DisplayMember = "Ten";
            cbxNhaCungCap.ValueMember = "Id";
            cbxNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToTable()
        {
            string sqlCommand = "Select hdn.Id, nv.Ten, ncc.Ten, hdn.NgayNhap, hdn.TongTien from HoaDonNhap hdn, NhanVien nv, NhaCungCap ncc where hdn.IdNhanVien=nv.Id and hdn.IdNhaCungCap=ncc.Id";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlCommand);

            dgvHoaDonNhap.DataSource = tbl;
            dgvHoaDonNhap.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvHoaDonNhap.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvHoaDonNhap.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDonNhap.Columns[1].HeaderText = "Nhân Viên";
            dgvHoaDonNhap.Columns[2].HeaderText = "Nhà Cung Cấp";
            dgvHoaDonNhap.Columns[3].HeaderText = "Ngày Nhập";
            dgvHoaDonNhap.Columns[4].HeaderText = "Tổng Tiền";
        }

        private DataTable MakeTableWithAutoIncrement()
        {
            // Make a table with one AutoIncrement column.
            DataTable table = new DataTable("tblHoaDonNhap");

            DataColumn col1 = new DataColumn("Mã Hóa Đơn",
                Type.GetType("System.Int32"));
            table.Columns.Add(col1);

            DataColumn col2 = new DataColumn("Nhân Viên",
                Type.GetType("System.string"));
            table.Columns.Add(col2);

            DataColumn col3 = new DataColumn("Nhà Cung Cấp",
                Type.GetType("System.string"));
            table.Columns.Add(col3);

            DataColumn col4 = new DataColumn("Ngày Nhập",
                Type.GetType("System.DateTime"));
            table.Columns.Add(col4);

            DataColumn col5 = new DataColumn("Tổng Tiền",
                Type.GetType("System.Single"));
            table.Columns.Add(col5);
            return table;
        }

        #endregion

    }
}
