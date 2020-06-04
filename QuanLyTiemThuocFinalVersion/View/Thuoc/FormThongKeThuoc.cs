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

namespace QuanLyTiemThuocFinalVersion.View.Thuoc
{
    public partial class FormThongKeThuoc : Form
    {
        public FormThongKeThuoc()
        {
            InitializeComponent();
        }

        private void FormThongKeThuoc_Load(object sender, EventArgs e)
        {
            LoadDataToCbxThuoc();
            LoadDataToCbxCongDung();
            LoadDataToGridView();
        }

        private void cbxThuoc_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxThuoc.Text));
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxThuoc.Text = "";
            }
            else
            {
                if (cbxThuoc.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Bạn đang chọn tên thuốc mới chưa có trong csdl");
                    cbxThuoc.SelectedIndex = 0;
                }
            }
        }

        private void tbThanhPhan_Leave(object sender, EventArgs e)
        {
            string thanhPhan = TienIch.ToUpperFistCharacter(tbThanhPhan.Text);
            tbThanhPhan.Text = thanhPhan;
        }

        private void cbxCongDung_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxCongDung.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxCongDung.Text = "";
            }
            else
            {
                if (cbxCongDung.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Công Dụng mới chưa có trong csdl\nBạn Có muốn thêm mới Công Dụng này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertCongDung = "Insert into CongDung (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertCongDung);
                        LoadDataToCbxCongDung();
                        cbxCongDung.SelectedIndex = cbxCongDung.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxCongDung.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô Nước Sản Xuất đã bị xóa do bạn không muốn thêm mới Nước Sản Xuất này vào hệ thống.");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tableName = " Thuoc t";
            string whereCongDung = "";
            string whereThuoc = "";
            string whereThanhPhan = "";

            string tenThuoc = TienIch.ToTitleCase(cbxThuoc.Text);

            string thanhPhan = TienIch.XoaKhoangTrang(tbThanhPhan.Text).ToLower();

            //xem có tra theo tên thuốc hay không
            if (!string.IsNullOrEmpty(tenThuoc))
            {
                whereThuoc = " and t.Id = " + DataBaseFunction.GetItemId("Select Id from Thuoc where Ten =N'" + tenThuoc + "'");
            }

            //xem có tra theo công dụng hay không
            List<int> danhSachCongDung = new List<int>();
            foreach (string item in clbCongDung.CheckedItems)
            {
                string sqlSelectId = "Select Id from CongDung where Ten=N'" + item + "'";
                danhSachCongDung.Add(DataBaseFunction.GetItemId(sqlSelectId));
            }
            if (danhSachCongDung.Count > 0)
            {
                whereCongDung = "and t.id in( select IdThuoc from ThuocCongDung tvcd where " + " tvcd.IdCongDung=" + danhSachCongDung.First() + " ";
                string whereCongDungfinal = "";
                foreach (int idCongDung in danhSachCongDung.Skip(1))
                {
                    whereCongDungfinal += (" or tvcd.IdCongDung=" + idCongDung + " ");
                }
                whereCongDung = whereCongDung + whereCongDungfinal + ")";
            }

            //xem có tra theo thành phần hay không
            if (!string.IsNullOrEmpty(thanhPhan))
            {
                char[] delimiterChars = { ',' };
                string[] thanhPhanItems = thanhPhan.Split(delimiterChars);

                whereThanhPhan = " and t.Id in( select Id from Thuoc where " + " ThanhPhan like N'%" + thanhPhanItems[0] + "'%";
                string whereThanhPhanItem = "";
                foreach (string item in thanhPhanItems.Skip(1))
                {
                    whereThanhPhanItem += (" and ThanhPhan like N'%" + item + "%' ");
                }
                whereThanhPhan = whereThanhPhan + whereThanhPhanItem + ")";
            }

            if (string.IsNullOrEmpty(whereCongDung) && string.IsNullOrEmpty(whereThanhPhan) && string.IsNullOrEmpty(whereThuoc))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Hãy nhập dữ liệu bạn muốn tìm kiếm để tìm!");
            }
            else
            {
                string sqlSelect = "select t.Id, t.Ten, " +
                    " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                    " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                    " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                    " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                    " from " + tableName +
                    " where 1=1 " +
                    whereThuoc + " " + whereCongDung + " " + whereThanhPhan;

                DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
                dgvThuoc.DataSource = tbl;
                //Cho người dùng thêm dữ liệu trực tiếp
                dgvThuoc.AllowUserToAddRows = false;
                dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
                dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
                dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
                dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
                dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
                dgvThuoc.Columns[5].HeaderText = "Thành Phần";
                dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
                dgvThuoc.Columns[7].HeaderText = "Giá Bán";
                dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
                dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
                dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
                dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

                foreach (DataGridViewColumn col in dgvThuoc.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.ReadOnly = true;
                }
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            LoadDataToGridView();
        }

        private void btnThemCongDung_Click(object sender, EventArgs e)
        {
            if (!clbCongDung.Items.Contains(cbxCongDung.Text))
            {
                clbCongDung.Items.Insert(clbCongDung.Items.Count, cbxCongDung.Text);
                clbCongDung.SetItemChecked(clbCongDung.Items.Count - 1, true);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvThuoc.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvThuoc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvThuoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //

        private void LoadDataToCbxThuoc()
        {
            cbxThuoc.DataSource = null;
            string sqlSelectThuoc = "Select Id, Ten from Thuoc";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelectThuoc);
            cbxThuoc.DataSource = tbl;
            cbxThuoc.DisplayMember = "Ten";
            cbxThuoc.ValueMember = "Id";
            cbxThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxThuoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxThuoc.Text = "";
        }

        private void LoadDataToCbxCongDung()
        {
            string sqlSelectCongDung = "Select * from CongDung";
            DataTable tblCongDung = DataBaseFunction.GetDataToTable(sqlSelectCongDung);
            cbxCongDung.DataSource = tblCongDung;
            cbxCongDung.DisplayMember = "Ten";
            cbxCongDung.ValueMember = "Id";
            cbxCongDung.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCongDung.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToGridView()
        {
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t ";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //Khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }

        private void btnThuocHetHan_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t " +
                " where 1=1 and t.HanSuDung<GetDate()";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }

        private void btnThongKeThuocConHan_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t " +
                " where 1=1 and t.HanSuDung>=GetDate()";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }
    }
}
