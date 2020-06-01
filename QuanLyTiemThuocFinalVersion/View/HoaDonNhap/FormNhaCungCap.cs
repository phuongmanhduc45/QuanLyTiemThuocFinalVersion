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
    public partial class FormNhaCungCap : Form
    {
        private string editTen;
        private string editDiaChi;
        private string editSoDienThoai;

        public FormNhaCungCap()
        {
            InitializeComponent();
            editTen = "";
            editDiaChi = "";
            editSoDienThoai = "";
        }

        private void LoadDataToGridView()
        {
            string sqlCommand = "Select * from NhaCungCap";
            DataTable tblNhaCungCap = DataBaseFunction.GetDataToTable(sqlCommand);
            dgvNhaCungCap.DataSource = tblNhaCungCap;
            //Cho người dùng thêm dữ liệu trực tiếp
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvNhaCungCap.Columns[0].HeaderText = "Mã";
            dgvNhaCungCap.Columns[0].Width = 80;
            dgvNhaCungCap.Columns[0].ReadOnly = true;
            dgvNhaCungCap.Columns[0].Resizable = DataGridViewTriState.False;
            dgvNhaCungCap.Columns[0].ToolTipText = "Mã của nhà cung cấp lưu trong cơ sở dữ liệu";

            dgvNhaCungCap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCungCap.Columns[1].Width = 300;
            dgvNhaCungCap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhaCungCap.Columns[1].Resizable = DataGridViewTriState.False;

            dgvNhaCungCap.Columns[2].HeaderText = "Tên Địa Chỉ";
            dgvNhaCungCap.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhaCungCap.Columns[2].Resizable = DataGridViewTriState.False;

            dgvNhaCungCap.Columns[3].HeaderText = "Số Điện Thoại";
            dgvNhaCungCap.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhaCungCap.Columns[3].Resizable = DataGridViewTriState.False;
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
                tbSoDienThoai.Text = "";
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
                TienIch.ShowLoi("Giá trị không hợp lệ", "Trường tên nhà cung cấp không được để trống!");
            }
            else
            {
                NhaCungCap nhaCungCap = new NhaCungCap
                {
                    Ten = tbTen.Text,
                    DiaChi = tbDiaChi.Text,
                    SoDienThoai = tbSoDienThoai.Text
                };

                string sqlInsert = "Insert into NhaCungCap (Ten, DiaChi, SoDienThoai) Values(N'"
                    + nhaCungCap.Ten + "',N'" + nhaCungCap.DiaChi + "','" + nhaCungCap.SoDienThoai + "')";
                try
                {
                    DataBaseFunction.ExcuteSQL(sqlInsert);
                    TienIch.ShowThanhCong("Thêm Mới Thành Công", "Đã thêm mới nhà cung cấp có tên: " + nhaCungCap.Ten + " vào cơ sở dữ liệu!");
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
                NhaCungCap nhaCungCap = new NhaCungCap
                {
                    Ten = tbTen.Text,
                    DiaChi = tbDiaChi.Text,
                    SoDienThoai = tbSoDienThoai.Text
                };
                string sqlSelect = "Select * from NhaCungCap where ";
                string sqlTen = nhaCungCap.Ten.Length > 0 ? " Ten like N'%" + nhaCungCap.Ten + "%'" : "";
                string sqlDiaChi = nhaCungCap.DiaChi.Length > 0 ? " DiaChi like N'%" + nhaCungCap.DiaChi + "%'" : "";
                string sqlSoDienThoai = nhaCungCap.SoDienThoai.Length > 0 ? " SoDienThoai like '%" + nhaCungCap.SoDienThoai + "%'" : "";

                sqlSelect = sqlSelect
                    + (sqlTen.Length > 0 ?
                                        (sqlDiaChi.Length > 0 ? 
                                                               (sqlTen + " and " + sqlDiaChi + (sqlSoDienThoai.Length > 0 ? (" and " + sqlSoDienThoai) : "")) 
                                                               :
                                                               (sqlSoDienThoai.Length > 0 ? 
                                                                                           (sqlTen+ " and " +  sqlSoDienThoai) 
                                                                                           : 
                                                                                           sqlTen)) 
                                        :
                                        (sqlDiaChi.Length > 0 ?
                                                            (sqlDiaChi + (sqlSoDienThoai.Length > 0 ? ( " and " + sqlSoDienThoai) : "")) 
                                                            :
                                                            (sqlSoDienThoai.Length > 0 ? 
                                                                                        sqlSoDienThoai 
                                                                                        : 
                                                                                        ""))
                    );

                try
                {
                    dgvNhaCungCap.DataSource = null;
                    DataTable tblNhaCungCap = DataBaseFunction.GetDataToTable(sqlSelect);
                    dgvNhaCungCap.DataSource = tblNhaCungCap;

                    if (tblNhaCungCap.Rows.Count == 0)
                    {
                        TienIch.ShowThanhCong("Kết quả tìm kiếm", "Không tìm thấy bản ghi nào cả!");
                    }
                    else
                    {
                        //Cho người dùng thêm dữ liệu trực tiếp
                        dgvNhaCungCap.AllowUserToAddRows = false;
                        dgvNhaCungCap.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                        dgvNhaCungCap.Columns[0].HeaderText = "Mã";
                        dgvNhaCungCap.Columns[0].Width = 80;
                        dgvNhaCungCap.Columns[0].ReadOnly = true;
                        dgvNhaCungCap.Columns[0].Resizable = DataGridViewTriState.False;
                        dgvNhaCungCap.Columns[0].ToolTipText = "Mã của nhà cung cấp lưu trong cơ sở dữ liệu";

                        dgvNhaCungCap.Columns[1].HeaderText = "Tên Khách Hàng";
                        dgvNhaCungCap.Columns[1].Width = 300;
                        dgvNhaCungCap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvNhaCungCap.Columns[1].Resizable = DataGridViewTriState.False;

                        dgvNhaCungCap.Columns[2].HeaderText = "Tên Địa Chỉ";
                        dgvNhaCungCap.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvNhaCungCap.Columns[2].Resizable = DataGridViewTriState.False;

                        dgvNhaCungCap.Columns[3].HeaderText = "Số Điện Thoại";
                        dgvNhaCungCap.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvNhaCungCap.Columns[3].Resizable = DataGridViewTriState.False;

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
            int sizeOfTable = dgvNhaCungCap.Rows.Count;
            // danh sách các bản ghi được người dùng chọn
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            // chạy vòng for duyệt qua hết các bản ghi trong bảng dữ liệu đang được hiển thị
            // nếu có bản ghi nào đang được chọn thì thêm vào danh sách các bản ghi được chọn
            foreach (DataGridViewRow row in dgvNhaCungCap.Rows)
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
                        string sqlDelete = "Delete From NhaCungCap where Id=" + row.Cells[0].Value;
                        DataBaseFunction.Delete(sqlDelete);
                        //thực hiện lưu vị trí bản ghi cần xóa để xóa bản ghi ở phía giao diện người dùng
                        removeIds.Add(Int32.Parse(row.Cells[0].Value.ToString()));
                    }
                    foreach (int giaTriIdCanTimDeXoa in removeIds)
                    {
                        foreach (DataGridViewRow jow in dgvNhaCungCap.Rows)
                        {
                            if (Int32.Parse(jow.Cells[0].Value.ToString()) == giaTriIdCanTimDeXoa)
                            {
                                dgvNhaCungCap.Rows.RemoveAt(jow.Index);
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

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvNhaCungCap.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvNhaCungCap_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                editTen = dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            //Nếu user chỉnh sửa cột địa chỉ
            else if (e.ColumnIndex == 2)
            {
                editDiaChi = dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            //Nếu user chỉnh sửa cột số điện thoại
            else if (e.ColumnIndex == 3)
            {
                editSoDienThoai = dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dgvNhaCungCap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                string ten = dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(ten)))
                {
                    TienIch.ShowCanhBao("Dữ liệu không phù hợp", "Không được để trống tên Nhà Cung Cấp");
                    dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value = editTen;
                }
                else
                {
                    //update lại data trong db
                    updateEditedCellValueToDB("Ten",
                        TienIch.ToTitleCase(dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString()),
                        Int32.Parse(dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    //update lại giá trị cho ô tên ở phía giao diện người dùng
                    dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value = TienIch.ToTitleCase(dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                //set lại biến để dùng cho lần edit sau
                editTen = "";
            }
            //Nếu user chỉnh sửa cột Địa Chỉ
            if (e.ColumnIndex == 2)
            {
                string diaChi = dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(diaChi)))
                {
                    //do nothing
                }
                else
                {
                    //update lại data trong db
                    updateEditedCellValueToDB("DiaChi",
                        TienIch.ToUpperFistCharacter(dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString()),
                        Int32.Parse(dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    //update lại giá trị cho ô tên ở phía giao diện người dùng
                    dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value = TienIch.ToUpperFistCharacter(dgvNhaCungCap.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                //set lại biến để dùng cho lần edit sau
                editDiaChi = "";
            }
            //Nếu user chỉnh sửa cột Số Điện Thoại
            if (e.ColumnIndex == 3)
            {
                string soDienThoai = TienIch.XoaTatCaKhoangTrang(dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (string.IsNullOrEmpty(soDienThoai))
                {
                    //do nothing
                }
                else
                {
                    if (soDienThoai.All(char.IsDigit))
                    {
                        //update lại data trong db
                        updateEditedCellValueToDB("SoDienThoai",
                            TienIch.XoaTatCaKhoangTrang(dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString()),
                            Int32.Parse(dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        //update lại giá trị cho ô tên ở phía giao diện người dùng
                        dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value = TienIch.XoaTatCaKhoangTrang(dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value.ToString());
                    }
                    else
                    {
                        TienIch.ShowLoi("Dữ Liệu không phù hợp", "Chỉ chấp nhận các ký tự là số từ 0~9");
                        dgvNhaCungCap.Rows[e.RowIndex].Cells[3].Value = editSoDienThoai;
                    }

                }
                //set lại biến để dùng cho lần edit sau
                editSoDienThoai = "";
            }
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void updateEditedCellValueToDB(string tenCot, string giaTriMoi, int id)
        {
            string sqlUpdate = "Update NhaCungCap set " + tenCot + "=N'" + giaTriMoi + "' where Id=" + id;
            DataBaseFunction.ExcuteSQL(sqlUpdate);
        }

    }
}
