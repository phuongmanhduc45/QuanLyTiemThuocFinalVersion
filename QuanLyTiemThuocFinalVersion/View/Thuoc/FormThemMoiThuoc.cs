using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Model.Entity;
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
    public partial class FormThemMoiThuoc : Form
    {
        public FormThemMoiThuoc()
        {
            InitializeComponent();
            LoadDataToCbxCongDung();
            LoadDataToCbxDonViTinh();
            LoadDataToCbxNuocSanXuat();
            LoadDataToCbxDangDieuChe();
            tbSoLuonHienCo.Text = "0";
            lblGiaBan.Text = "0 đ";
        }

        private void tbTen_Leave(object sender, EventArgs e)
        {
            tbTen.Text = TienIch.ToTitleCase(tbTen.Text);
            string sqlSelect = "Select Ten from Thuoc where Ten=N'" + tbTen.Text + "'";
            if (DataBaseFunction.IsExisted(sqlSelect))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Thuốc này đã tồn tại trong csdl");
                tbTen.SelectionLength = tbTen.Text.Length;
            }
        }

        private void cbxDonViTinh_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxDonViTinh.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo",
                    "Không được để trống thông tin này!\nCó thể gõ mới Đơn Vị Tính nếu Đơn Vị Tính bạn cần không có ở đây");
                if (cbxDonViTinh.Items.Count > 0)
                {
                    cbxDonViTinh.SelectedIndex = 0;
                }
            }
            else
            {
                if (cbxDonViTinh.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Đơn Vị Tính mới chưa có trong csdl\n Bạn Có muốn thêm mới Đơn Vị Tính này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertDonViTinh = "Insert into DonViTinh (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertDonViTinh);
                        LoadDataToCbxDonViTinh();
                        cbxDonViTinh.SelectedIndex = cbxDonViTinh.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxDonViTinh.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô Đơn Vị Tính đã bị xóa do bạn không muốn thêm mới Đơn Vị Tính này vào hệ thống.");
                    }
                }
            }
        }

        private void cbxNuocSanXuat_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxNuocSanXuat.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo",
                    "Không được để trống thông tin này!\nCó thể gõ mới Nước Sản Xuất nếu Nước Sản Xuất bạn cần không có ở đây");
                if (cbxNuocSanXuat.Items.Count > 0)
                {
                    cbxNuocSanXuat.SelectedIndex = 0;
                }
            }
            else
            {
                if (cbxNuocSanXuat.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Nước Sản Xuất mới chưa có trong csdl\nBạn Có muốn thêm mới Nước Sản Xuất này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertNuocSanXuat = "Insert into NuocSanXuat (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertNuocSanXuat);
                        LoadDataToCbxNuocSanXuat();
                        cbxNuocSanXuat.SelectedIndex = cbxNuocSanXuat.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxNuocSanXuat.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô Nước Sản Xuất đã bị xóa do bạn không muốn thêm mới Nước Sản Xuất này vào hệ thống.");
                    }
                }
            }
        }

        private void cbxDangDieuChe_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxDangDieuChe.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo",
                    "Không được để trống thông tin này!\nCó thể gõ mới Dạng Điều Chế nếu Dạng Điều Chế bạn cần không có ở đây");
                if (cbxDangDieuChe.Items.Count > 0)
                {
                    cbxDangDieuChe.SelectedIndex = 0;
                }
            }
            else
            {
                if (cbxDangDieuChe.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Dạng Điều Chế mới chưa có trong csdl\nBạn Có muốn thêm mới Dạng Điều Chế này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertDangDieuChe = "Insert into DangDieuChe (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertDangDieuChe);
                        LoadDataToCbxDangDieuChe();
                        cbxDangDieuChe.SelectedIndex = cbxDangDieuChe.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxDangDieuChe.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô Nước Sản Xuất đã bị xóa do bạn không muốn thêm mới Nước Sản Xuất này vào hệ thống.");
                    }
                }
            }
        }

        private void cbxCongDung_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxCongDung.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo",
                    "Không được để trống thông tin này!\nCó thể gõ mới Công Dụng nếu Công Dụng bạn cần không có ở đây");
                if (cbxCongDung.Items.Count > 0)
                {
                    cbxCongDung.SelectedIndex = 0;
                }
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

        private void btnThemCongDung_Click(object sender, EventArgs e)
        {
            if (!clbCongDung.Items.Contains(cbxCongDung.Text))
            {
                clbCongDung.Items.Insert(clbCongDung.Items.Count, cbxCongDung.Text);
                clbCongDung.SetItemChecked(clbCongDung.Items.Count - 1, true);
            }
        }

        private void tbThanhPhan_Leave(object sender, EventArgs e)
        {
            tbThanhPhan.Text = TienIch.XoaKhoangTrang(tbThanhPhan.Text);
        }

        private void tbChongChiDinh_Leave(object sender, EventArgs e)
        {
            tbChongChiDinh.Text = TienIch.XoaKhoangTrang(tbChongChiDinh.Text);
        }

        private void tbSoLuonHienCo_Leave(object sender, EventArgs e)
        {
            //validate luôn >=0
            string soLuonHienCoValue = TienIch.XoaTatCaKhoangTrang(tbSoLuonHienCo.Text);
            if (soLuonHienCoValue.All(char.IsDigit))
            {
                int soLuong;
                if (Int32.TryParse(soLuonHienCoValue, out soLuong))
                {
                    if (soLuong < 0)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Hiện Có phải là số tự nhiên lớn hơn hoặc bằng 0");
                        tbSoLuonHienCo.Focus();
                        tbSoLuonHienCo.SelectionLength = tbSoLuonHienCo.Text.Length;
                    }
                    else
                    {
                        tbSoLuonHienCo.Text = soLuong.ToString();
                    }
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Hiện Có phải là số tự nhiên lớn hơn hoặc bằng 0");
                tbSoLuonHienCo.Focus();
                tbSoLuonHienCo.SelectionLength = tbSoLuonHienCo.Text.Length;
            }
        }

        private void tbGiaNhap_Leave(object sender, EventArgs e)
        {
            string giaNhapValue = TienIch.XoaTatCaKhoangTrang(tbGiaNhap.Text);
            if (giaNhapValue.All(char.IsDigit))
            {
                int soLuong;
                if (Int32.TryParse(giaNhapValue, out soLuong))
                {
                    if (soLuong < 0)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Giá Nhập phải là số tự nhiên lớn hơn hoặc bằng 0");
                        tbGiaNhap.Focus();
                        tbGiaNhap.SelectionLength = tbGiaNhap.Text.Length;
                    }
                    else
                    {
                        tbGiaNhap.Text = soLuong.ToString();
                        lblGiaBan.Text = (soLuong * 1.1).ToString() + " đ";
                    }
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Giá Nhập phải là số tự nhiên lớn hơn hoặc bằng 0");
                tbGiaNhap.Focus();
                tbGiaNhap.SelectionLength = tbGiaNhap.Text.Length;
            }
        }

        private void btnThemMoiThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Không được để trống tên thuốc!");
                tbTen.Focus();
            }
            else
            {
                QuanLyTiemThuocFinalVersion.Model.Entity.Thuoc thuoc = new Model.Entity.Thuoc
                {
                    Ten = tbTen.Text,
                    IdDonVi = Int32.Parse(cbxDonViTinh.SelectedValue.ToString()),
                    IdNuocSanXuat = Int32.Parse(cbxNuocSanXuat.SelectedValue.ToString()),
                    IdDangDieuChe = Int32.Parse(cbxDangDieuChe.SelectedValue.ToString()),
                    ThanhPhan = tbThanhPhan.Text,
                    SoLuongHienCo = Int32.Parse(tbSoLuonHienCo.Text),
                    GiaBan = float.Parse(lblGiaBan.Text.Replace(" đ", "")),
                    DonGiaNhap = float.Parse(tbGiaNhap.Text),
                    ChongChiDinh = tbChongChiDinh.Text,
                };

                DialogResult result = TienIch.ShowXacThuc("Xác Nhận", "Bạn có chắc chắn muốn thêm thuốc này vào trong tiệm chứ?");
                if (result == DialogResult.Yes)
                {
                    //Them Thuoc Vao Co So Du Lieu
                    AddNewDrugToStore(thuoc);

                    //Them Cong Dung Vao Bang Cong Dung
                    AddCongDungChoThuoc(thuoc.Ten);
                }
                else
                {

                }
            }
        }

        private void AddNewDrugToStore(Model.Entity.Thuoc thuoc)
        {
            string sqlInsert = " Insert into Thuoc (Ten,IdDonViTinh,IdDangDieuChe,IdNuocSanXuat,ThanhPhan,DonGiaNhap,GiaBan,SoLuongHienCo,ChongChiDinh) \n"
                + " values(N'" + thuoc.Ten + "'," + thuoc.IdDonVi + " , "
                + thuoc.IdDangDieuChe + ", " + thuoc.IdNuocSanXuat
                + ", N'" + thuoc.ThanhPhan + "', " + thuoc.DonGiaNhap + ", "
                + thuoc.GiaBan + ", " + thuoc.SoLuongHienCo
                + ", N'" + thuoc.ChongChiDinh + "')";
            DataBaseFunction.ExcuteSQL(sqlInsert);

            TienIch.ShowThanhCong("Thêm Mới Thành Công", "Thuốc " + thuoc.Ten + " đã được thêm mới vào csdl.");
        }

        private void AddCongDungChoThuoc(string tenThuoc)
        {
            string sqlSelect = "Select Id from Thuoc where Ten=N'" + tenThuoc + "'";
            int thuocId = DataBaseFunction.GetItemId(sqlSelect);

            List<int> danhSachCongDung = new List<int>();

            foreach (string item in clbCongDung.CheckedItems)
            {
                string sqlSelectId = "Select Id from CongDung where Ten=N'" + item + "'";
                danhSachCongDung.Add(DataBaseFunction.GetItemId(sqlSelectId));
            }

            foreach (int id in danhSachCongDung)
            {
                string sqlInsert = "Insert into ThuocCongDung(IdThuoc,IdCongDung) values(" + thuocId + "," + id + ")";
                DataBaseFunction.ExcuteSQL(sqlInsert);
            }

        }

        private void LoadDataToCbxDonViTinh()
        {
            cbxDonViTinh.DataSource = null;
            string sqlSelectDonViTinh = "Select * from DonViTinh";
            DataTable tblDonViTinh = DataBaseFunction.GetDataToTable(sqlSelectDonViTinh);
            cbxDonViTinh.DataSource = tblDonViTinh;
            cbxDonViTinh.DisplayMember = "Ten";
            cbxDonViTinh.ValueMember = "Id";
            cbxDonViTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxDonViTinh.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNuocSanXuat()
        {
            string sqlSelectNuocSanXuat = "Select * from NuocSanXuat";
            DataTable tblNuocSanXuat = DataBaseFunction.GetDataToTable(sqlSelectNuocSanXuat);
            cbxNuocSanXuat.DataSource = tblNuocSanXuat;
            cbxNuocSanXuat.DisplayMember = "Ten";
            cbxNuocSanXuat.ValueMember = "Id";
            cbxNuocSanXuat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNuocSanXuat.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxDangDieuChe()
        {
            string sqlSelectDangDieuChe = "Select * from DangDieuChe";
            DataTable tblDangDieuChe = DataBaseFunction.GetDataToTable(sqlSelectDangDieuChe);
            cbxDangDieuChe.DataSource = tblDangDieuChe;
            cbxDangDieuChe.DisplayMember = "Ten";
            cbxDangDieuChe.ValueMember = "Id";
            cbxDangDieuChe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxDangDieuChe.AutoCompleteSource = AutoCompleteSource.ListItems;
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

    }
}
