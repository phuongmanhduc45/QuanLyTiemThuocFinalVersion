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

namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    public partial class FormThongKeKhachHang : Form
    {
        private string editTen;
        private string editDiaChi;
        private string editSoDienThoai;

        public FormThongKeKhachHang()
        {
            InitializeComponent();
            editTen = "";
            editDiaChi = "";
            editSoDienThoai = "";
        }

        private void LoadDataToGridView()
        {
            string sqlCommand = "Select * from KhachHang";
            DataTable tblNhaCungCap = DataBaseFunction.GetDataToTable(sqlCommand);
            dgvKhachHang.DataSource = tblNhaCungCap;
            //Cho người dùng thêm dữ liệu trực tiếp
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvKhachHang.Columns[0].HeaderText = "Mã";
            dgvKhachHang.Columns[0].Width = 80;
            dgvKhachHang.Columns[0].ReadOnly = true;
            dgvKhachHang.Columns[0].Resizable = DataGridViewTriState.False;
            dgvKhachHang.Columns[0].ToolTipText = "Mã của khách hàng lưu trong cơ sở dữ liệu";

            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[1].Width = 300;
            dgvKhachHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvKhachHang.Columns[1].Resizable = DataGridViewTriState.False;

            dgvKhachHang.Columns[2].HeaderText = "Tên Địa Chỉ";
            dgvKhachHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKhachHang.Columns[2].Resizable = DataGridViewTriState.False;

            dgvKhachHang.Columns[3].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKhachHang.Columns[3].Resizable = DataGridViewTriState.False;
        }

        private void tbTen_Leave(object sender, EventArgs e)
        {
            tbTen.Text = TienIch.ToTitleCase(tbTen.Text);
        }

        private void tbSoDienThoai_Leave(object sender, EventArgs e)
        {
            tbSoDienThoai.Text = TienIch.XoaTatCaKhoangTrang(tbSoDienThoai.Text);

            if (!tbSoDienThoai.Text.All(char.IsDigit))
            {
                TienIch.ShowCanhBao("Không hợp lệ", "Số điện thoại bạn nhập vào không hợp lệ!\n Số điện thoại chỉ được chứa chữ số(0-9)");
            }
        }

        private void tbDiaChi_Leave(object sender, EventArgs e)
        {
            tbDiaChi.Text = TienIch.ToUpperFistCharacter(tbDiaChi.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TienIch.XoaTatCaKhoangTrang(tbTen.Text).Length == 0)
            {
                TienIch.ShowLoi("Giá trị không hợp lệ", "Trường tên khách hàng không được để trống!");
            }
            else
            {
                KhachHang khachHang = new KhachHang
                {
                    Ten = tbTen.Text,
                    DiaChi = tbDiaChi.Text,
                    DienThoai = tbSoDienThoai.Text
                };

                string sqlInsert = "Insert into KhachHang (Ten, DiaChi, DienThoai) Values(N'"
                    + khachHang.Ten + "',N'" + khachHang.DiaChi + "','" + khachHang.DienThoai + "')";
                try
                {
                    DataBaseFunction.ExcuteSQL(sqlInsert);
                    TienIch.ShowThanhCong("Thêm Mới Thành Công", "Đã thêm mới khách hàng có tên: " + khachHang.Ten + " vào cơ sở dữ liệu!");
                    LoadDataToGridView();
                }
                catch (Exception err)
                {
                    TienIch.ShowLoi("Lỗi", err.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text) && string.IsNullOrEmpty(tbDiaChi.Text) && string.IsNullOrEmpty(tbSoDienThoai.Text))
            {
                TienIch.ShowCanhBao("Chú ý!", "Vui lòng nhập thông tin bạn muốn tìm kiếm vào các ô nhập ở bên.");
            }
            else
            {
                KhachHang khachHang = new KhachHang
                {
                    Ten = tbTen.Text,
                    DiaChi = tbDiaChi.Text,
                    DienThoai = tbSoDienThoai.Text
                };
                string sqlSelect = "Select * from KhachHang where ";
                string sqlTen = khachHang.Ten.Length > 0 ? " Ten like N'%" + khachHang.Ten + "%'" : "";
                string sqlDiaChi = khachHang.DiaChi.Length > 0 ? " DiaChi like N'%" + khachHang.DiaChi + "%'" : "";
                string sqlSoDienThoai = khachHang.DienThoai.Length > 0 ? " DienThoai like '%" + khachHang.DienThoai + "%'" : "";

                sqlSelect = sqlSelect
                    + (sqlTen.Length > 0 ?
                                        (sqlDiaChi.Length > 0 ?
                                                               (sqlTen + " and " + sqlDiaChi + (sqlSoDienThoai.Length > 0 ? (" and " + sqlSoDienThoai) : ""))
                                                               :
                                                               (sqlSoDienThoai.Length > 0 ?
                                                                                           (sqlTen + " and " + sqlSoDienThoai)
                                                                                           :
                                                                                           sqlTen))
                                        :
                                        (sqlDiaChi.Length > 0 ?
                                                            (sqlDiaChi + (sqlSoDienThoai.Length > 0 ? (" and " + sqlSoDienThoai) : ""))
                                                            :
                                                            (sqlSoDienThoai.Length > 0 ?
                                                                                        sqlSoDienThoai
                                                                                        :
                                                                                        ""))
                    );

                try
                {
                    dgvKhachHang.DataSource = null;
                    DataTable tblNhaCungCap = DataBaseFunction.GetDataToTable(sqlSelect);
                    dgvKhachHang.DataSource = tblNhaCungCap;

                    if (tblNhaCungCap.Rows.Count == 0)
                    {
                        TienIch.ShowThanhCong("Kết quả tìm kiếm", "Không tìm thấy bản ghi nào cả!");
                    }
                    else
                    {
                        //Cho người dùng thêm dữ liệu trực tiếp
                        dgvKhachHang.AllowUserToAddRows = false;
                        dgvKhachHang.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                        dgvKhachHang.Columns[0].HeaderText = "Mã";
                        dgvKhachHang.Columns[0].Width = 80;
                        dgvKhachHang.Columns[0].ReadOnly = true;
                        dgvKhachHang.Columns[0].Resizable = DataGridViewTriState.False;
                        dgvKhachHang.Columns[0].ToolTipText = "Mã của khách hàng lưu trong cơ sở dữ liệu";

                        dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
                        dgvKhachHang.Columns[1].Width = 300;
                        dgvKhachHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvKhachHang.Columns[1].Resizable = DataGridViewTriState.False;

                        dgvKhachHang.Columns[2].HeaderText = "Tên Địa Chỉ";
                        dgvKhachHang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvKhachHang.Columns[2].Resizable = DataGridViewTriState.False;

                        dgvKhachHang.Columns[3].HeaderText = "Số Điện Thoại";
                        dgvKhachHang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvKhachHang.Columns[3].Resizable = DataGridViewTriState.False;

                        TienIch.ShowThanhCong("Kết quả tìm kiếm", "Đã tìm thấy: " + tblNhaCungCap.Rows.Count + " bản ghi phù hợp với kết quả tìm kiếm!");
                    }

                }
                catch (Exception err)
                {
                    TienIch.ShowLoi("Lỗi", err.Message);
                }
            }
        }

        private void btnTaiLaiBang_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //biến chứa số lượng phần tử trong bảng hiện bên phía giao diện người dùng
            int sizeOfTable = dgvKhachHang.Rows.Count;
            // danh sách các bản ghi được người dùng chọn
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            // chạy vòng for duyệt qua hết các bản ghi trong bảng dữ liệu đang được hiển thị
            // nếu có bản ghi nào đang được chọn thì thêm vào danh sách các bản ghi được chọn
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Selected)
                {
                    selectedRows.Add(row);
                }
            }

            // Danh sách các bản ghi được chọn có số lượng lớn hơn không
            if (selectedRows.Count > 0)
            {
                //Hiển thị thông báo yêu cầu người dùng xác thực lựa chọn có xóa hay không?
                DialogResult result = TienIch.ShowXacThuc("Xác Thực", "Bạn có chắc chắn muốn xóa vĩnh viễn các bản ghi đã chọn?");
                //Người dùng chọn có
                if (result == DialogResult.Yes)
                {
                    List<int> removeIds = new List<int>();
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string sqlDelete = "Delete From KhachHang where Id=" + row.Cells[0].Value;
                        DataBaseFunction.Delete(sqlDelete);
                        //thực hiện lưu vị trí bản ghi cần xóa để xóa bản ghi ở phía giao diện người dùng
                        removeIds.Add(Int32.Parse(row.Cells[0].Value.ToString()));
                    }
                    foreach (int giaTriIdCanTimDeXoa in removeIds)
                    {
                        foreach (DataGridViewRow jow in dgvKhachHang.Rows)
                        {
                            if (Int32.Parse(jow.Cells[0].Value.ToString()) == giaTriIdCanTimDeXoa)
                            {
                                dgvKhachHang.Rows.RemoveAt(jow.Index);
                                break;
                            }
                        }
                    }
                    TienIch.ShowThanhCong("Thành Công", "Đã thực hiện xóa thành công!");
                }
                //Người dùng chọn không
                else if (result == DialogResult.No)
                {
                    TienIch.ShowThanhCong("Thông Báo", "Không có bản ghi nào bị xóa khỏi cơ sở dữ liệu cả!");
                }
            }
            // Chưa có bản ghi nào được chọn
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng chọn bản ghi muốn xóa");
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvKhachHang.Rows[e.RowIndex].Selected = true;
            }
        }


        private void dgvKhachHang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                editTen = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            //Nếu user chỉnh sửa cột địa chỉ
            else if (e.ColumnIndex == 2)
            {
                editDiaChi = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            //Nếu user chỉnh sửa cột số điện thoại
            else if (e.ColumnIndex == 3)
            {
                editSoDienThoai = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dgvKhachHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                string ten = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(ten)))
                {
                    TienIch.ShowCanhBao("Dữ liệu không phù hợp", "Không được để trống tên Khách Hàng");
                    dgvKhachHang.Rows[e.RowIndex].Cells[1].Value = editTen;
                }
                else
                {
                    //update lại data trong db
                    updateEditedCellValueToDB("Ten",
                        TienIch.ToTitleCase(dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString()),
                        Int32.Parse(dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    //update lại giá trị cho ô tên ở phía giao diện người dùng
                    dgvKhachHang.Rows[e.RowIndex].Cells[1].Value = TienIch.ToTitleCase(dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                //set lại biến để dùng cho lần edit sau
                editTen = "";
            }
            //Nếu user chỉnh sửa cột Địa Chỉ
            if (e.ColumnIndex == 2)
            {
                string diaChi = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(diaChi)))
                {
                    //do nothing
                }
                else
                {
                    //update lại data trong db
                    updateEditedCellValueToDB("DiaChi",
                        TienIch.ToUpperFistCharacter(dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString()),
                        Int32.Parse(dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    //update lại giá trị cho ô tên ở phía giao diện người dùng
                    dgvKhachHang.Rows[e.RowIndex].Cells[2].Value = TienIch.ToUpperFistCharacter(dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                //set lại biến để dùng cho lần edit sau
                editDiaChi = "";
            }
            //Nếu user chỉnh sửa cột Số Điện Thoại
            if (e.ColumnIndex == 3)
            {
                string soDienThoai = TienIch.XoaTatCaKhoangTrang(dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (string.IsNullOrEmpty(soDienThoai))
                {
                    //do nothing
                }
                else
                {
                    if (soDienThoai.All(char.IsDigit))
                    {
                        //update lại data trong db
                        updateEditedCellValueToDB("DienThoai",
                            TienIch.XoaTatCaKhoangTrang(dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString()),
                            Int32.Parse(dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        //update lại giá trị cho ô tên ở phía giao diện người dùng
                        dgvKhachHang.Rows[e.RowIndex].Cells[3].Value = TienIch.XoaTatCaKhoangTrang(dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString());
                    }
                    else
                    {
                        TienIch.ShowLoi("Dữ Liệu không phù hợp", "Chỉ chấp nhận các ký tự là số từ 0~9");
                        dgvKhachHang.Rows[e.RowIndex].Cells[3].Value = editSoDienThoai;
                    }
                    
                }
                //set lại biến để dùng cho lần edit sau
                editSoDienThoai = "";
            }
        }

        private void FormThongKeKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void updateEditedCellValueToDB(string tenCot, string giaTriMoi, int id)
        {
            string sqlUpdate = "Update KhachHang set " + tenCot + "=N'" + giaTriMoi + "' where Id=" + id;
            DataBaseFunction.ExcuteSQL(sqlUpdate);
        }
    
    }
}
