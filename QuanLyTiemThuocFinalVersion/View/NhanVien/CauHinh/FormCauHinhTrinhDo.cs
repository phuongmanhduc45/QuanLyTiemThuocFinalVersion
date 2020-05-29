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

namespace QuanLyTiemThuocFinalVersion.View.NhanVien.CauHinh
{
    public partial class FormCauHinhTrinhDo : Form
    {
        //Bien Dem so luong ban ghi hien co trong bang
        private int SoLuonBanGhi;
        //Biến lưu giá trị của ô tại thời điểm bắt đầu chỉnh sửa
        string editText = "";
        // Danh sách index các bản ghi có thực hiện chỉnh sửa
        private List<TrinhDo> editedRows;
        //Danh sách các bản ghi mới được insert vào bảng(trên giao diện, không phải bảng trong db)
        private List<string> insertRows;

        public FormCauHinhTrinhDo()
        {
            InitializeComponent();
            SoLuonBanGhi = 0;
            editedRows = new List<TrinhDo>();
            insertRows = new List<string>();
        }

        // event diễn ra khi form bắt đầu được load lên
        private void FormCauHinhTrinhDo_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        //load dữ liệu ra bảng
        private void LoadDataToGridView()
        {
            string sqlCommand = "Select * from TrinhDo";
            DataTable tblDonViTinh = DataBaseFunction.GetDataToTable(sqlCommand);
            dgvTrinhDo.DataSource = tblDonViTinh;
            dgvTrinhDo.Columns[0].HeaderText = "Mã";
            dgvTrinhDo.Columns[0].Width = 80;
            dgvTrinhDo.Columns[0].ReadOnly = true;
            dgvTrinhDo.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvTrinhDo.Columns[0].ToolTipText = "Mã của Trình Độ lưu trong cơ sở dữ liệu";

            dgvTrinhDo.Columns[1].HeaderText = "Tên Trình Độ";
            dgvTrinhDo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTrinhDo.Columns[1].Resizable = System.Windows.Forms.DataGridViewTriState.False;

            //Cho người dùng thêm dữ liệu trực tiếp
            dgvTrinhDo.AllowUserToAddRows = true;
            dgvTrinhDo.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            SoLuonBanGhi = tblDonViTinh.Rows.Count;
        }

        //event diễn ra khi người dùng ấn nút Tải lại bảng
        private void btnTaiLaiBang_Click(object sender, EventArgs e)
        {
            // gắn lại dữ liệu bảng bằng rỗng trước khi reload lại
            dgvTrinhDo.DataSource = null;
            LoadDataToGridView();
            TienIch.ShowThanhCong("Tải lại thành công", "Đã load lại dữ liệu trong bảng Trình Độ");

            //xóa 2 list update với insert
            editedRows.Clear();
            insertRows.Clear();
            editText = "";
        }

        //Khi người dùng ấn vào nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //biến chứa số lượng phần tử trong bảng hiện bên phía giao diện người dùng
            int sizeOfTable = dgvTrinhDo.Rows.Count;
            // danh sách các bản ghi được người dùng chọn
            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
            // chạy vòng for duyệt qua hết các bản ghi trong bảng dữ liệu đang được hiển thị
            // nếu có bản ghi nào đang được chọn thì thêm vào danh sách các bản ghi được chọn
            foreach (DataGridViewRow row in dgvTrinhDo.Rows)
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
                        // bản ghi hiện tại phải khác bản ghi cuối cùng trong bảng
                        //(vì nó luôn luôn là null nên cần tránh)
                        if (row.Index != dgvTrinhDo.Rows[sizeOfTable - 1].Index)
                        {
                            //Xác thực xem bản ghi này đã có trong database chưa?
                            //Neu ban ghi nay chua duoc cap nhat vao trong db thi cot Id se không có giá trị
                            //Nếu cột Id có giá trị và khác rỗng thì thực hiện xóa khỏi db
                            if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                            {
                                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                                {
                                    string sqlDelete = "Delete From TrinhDo where Id=" + row.Cells[0].Value;
                                    DataBaseFunction.Delete(sqlDelete);
                                }
                                //thực hiện lưu vị trí bản ghi cần xóa để xóa bản ghi ở phía giao diện người dùng
                                removeIds.Add(Int32.Parse(row.Cells[0].Value.ToString()));

                                // biến flag được dùng để lưu vị trí của phần tử trong mảng
                                // danh sách các bản ghi có thực hiện chỉnh sửa có giá trị = editedText,
                                int flag = editedRows.FindIndex(x => x.Ten.Equals(row.Cells[1]));
                                //  nếu flag > 0 tức mảng chứa phần tử này
                                // thực hiện xóa Đối tượng đó khỏi danh sách
                                if (flag > 0)
                                {
                                    editedRows.RemoveAt(flag);
                                }
                            }
                            //Nếu cột Id khộng có giá trị thì tìm trong list insert xem đã có phần tử này chưa
                            else
                            {
                                //Nếu list insert mới có chứa thì xóa
                                if (insertRows.Contains(row.Cells[1].Value.ToString()))
                                {
                                    insertRows.Remove(row.Cells[1].Value.ToString());
                                }
                                dgvTrinhDo.Rows.RemoveAt(row.Index);
                            }
                        }
                    }
                    foreach (int giaTriIdCanTimDeXoa in removeIds)
                    {
                        foreach (DataGridViewRow jow in dgvTrinhDo.Rows)
                        {
                            if (Int32.Parse(jow.Cells[0].Value.ToString()) == giaTriIdCanTimDeXoa)
                            {
                                dgvTrinhDo.Rows.RemoveAt(jow.Index);
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

        //sự kiện xảy ra khi người dùng click vào nút lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //duyệt danh sách chứa các bản ghi cần thêm mới vào db
            if (insertRows.Count > 0)
            {
                foreach (string donViTinhMoi in insertRows)
                {
                    string sqlInsert = "Insert into TrinhDo (Ten) Values (N'" +
                        TienIch.XoaKhoangTrang(donViTinhMoi) + "')";
                    DataBaseFunction.ExcuteSQL(sqlInsert);
                }
                // Xóa danh sách chứa các bản ghi cần insert mới 
                // để bảo đảm lần ấn nút lưu tiếp theo không lưu những bản ghi đã xử lý rồi
                insertRows.Clear();
            }

            //duyệt danh sách chứa index các bản ghi chỉnh sửa
            if (editedRows.Count > 0)
            {
                foreach (TrinhDo donViTinhMoi in editedRows)
                {
                    string sqlUpdate = "Update TrinhDo Set Ten=N'" + donViTinhMoi.Ten + "' where Id=" + donViTinhMoi.Id;
                    DataBaseFunction.ExcuteSQL(sqlUpdate);
                }
                //Xóa danh sách chứa index các bản ghi đã được chỉnh sửa 
                // để thực hiện lưu cho lần ấn nút lưu tiếp theo
                editedRows.Clear();
            }

            //load lại data từ db lên bảng
            LoadDataToGridView();
        }

        //sự kiện xảy ra khi người dùng click vào 1 ô trong bảng(chưa chỉnh sửa)
        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nếu ô đang chọn thuộc hàng chứa bản ghi có dữ liệu hợp lý
                if (e.RowIndex > -1 && (e.RowIndex < SoLuonBanGhi ||
                   // (trường 'tên đơn vị' không bị bỏ trống)
                   // thì select cả hàng đó luôn
                   !string.IsNullOrEmpty(TienIch.XoaKhoangTrang(dgvTrinhDo.Rows[e.RowIndex].Cells[1].Value.ToString()))))
                {
                    dgvTrinhDo.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception err)
            {
                TienIch.ShowLoi("Lỗi", err.Message);
            }
        }

        //event xảy ra khi bắt đầu chỉnh sửa 1 ô trong bảng
        //lưu giá trị của ô tên tại thời điểm đó
        private void dgvTrinhDo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //bản ghi đang xét tới phải khác bản ghi cuối cùng trong bảng
            if (e.RowIndex != (dgvTrinhDo.Rows.Count - 1))
            {

                editText = TienIch.XoaKhoangTrang(dgvTrinhDo.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        //event xảy ra khi kết thúc chỉnh sửa 1 ô trong bảng
        private void dgvTrinhDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //bản ghi đang xét tới phải khác bản ghi cuối cùng trong bảng
            if (e.RowIndex != (dgvTrinhDo.Rows.Count - 1))
            {
                //nếu ô tên vừa sửa đổi có giá trị là rỗng hoặc bị xóa hoàn toàn giá trị
                // hiện ô cảnh báo hỏi người dùng muốn xóa hoàn toàn bản ghi này hay ntn?
                if (string.IsNullOrEmpty(TienIch.XoaTatCaKhoangTrang(dgvTrinhDo.Rows[e.RowIndex].Cells[1].Value.ToString())))
                {
                    //kiểm tra Id
                    // id khác rỗng
                    if (!string.IsNullOrEmpty(dgvTrinhDo.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        DialogResult result =
                                                TienIch.ShowXacThuc("Cảnh Báo", "Bạn có muốn xóa hoàn toàn Đơn vị tính:'" + editText + "' khỏi database?");
                        if (result == DialogResult.Yes)
                        {
                            // thực hiện xóa khỏi database
                            string sqlDelete = "Delete From TrinhDo where Id=" + dgvTrinhDo.Rows[e.RowIndex].Cells[0].Value;
                            DataBaseFunction.Delete(sqlDelete);
                            dgvTrinhDo.Rows.RemoveAt(e.RowIndex);
                            TienIch.ShowThanhCong("Đã xóa!", "Bản ghi '" + editText + "' đã bị xóa khỏi database!");
                        }
                        else if (result == DialogResult.No)
                        {
                            //Khôi phục dữ liệu về như cũ
                            dgvTrinhDo.Rows[e.RowIndex].Cells[1].Value = editText;
                            TienIch.ShowThanhCong("Đã khôi phục!", "Bản ghi '" + editText + "' chưa bị xóa khỏi database!");
                        }
                    }
                    //id bị rỗng
                    else
                    {
                        dgvTrinhDo.Rows.RemoveAt(e.RowIndex);

                    }
                }
                // nếu ô vừa sửa đổi khác rỗng và null
                else
                {
                    //lấy giá trị của ô tên khi kết thúc edit text
                    string editedText = TienIch.XoaKhoangTrang(dgvTrinhDo.Rows[e.RowIndex].Cells[1].Value.ToString());

                    //kiểm tra id
                    //id khác rỗng 
                    if (!string.IsNullOrEmpty(TienIch.XoaTatCaKhoangTrang(dgvTrinhDo.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {

                        // nếu giá trị của ô vừa chỉnh sửa khác với giá trị trước đó đã lưu 
                        // thì thực hiện lưu vị trí của bản ghi vừa chỉnh sửa để sau này thực hiện update cho nhanh
                        if (!editText.Equals(editedText))
                        {
                            // biến flag được dùng để lưu vị trí của phần tử trong mảng
                            // danh sách các bản ghi có thực hiện chỉnh sửa có giá trị = editedText,
                            int flag = editedRows.FindIndex(x => x.Ten.Equals(editedText));
                            //  nếu flag = -1 tức mảng chưa chứa phần tử này
                            // thực hiện lưu Đối tượng đó vào danh sách
                            if (flag < 0)
                            {
                                editedRows.Add(new TrinhDo
                                {
                                    Id = Int32.Parse(dgvTrinhDo.Rows[e.RowIndex].Cells[0].Value.ToString()),
                                    Ten = editedText
                                });
                            }
                        }
                        //giống thì không làm gì cả
                    }
                    //id rỗng
                    else
                    {
                        //kiểm tra xem giá trị cũ có nằm trong list insert mới không?
                        // editText là biến chứa giá trị cũ trước khi sửa đổi
                        // editedText là biến chứa giá trị mới đã sửa đổi
                        //Có chứa giá trị này trong list insert, thực hiện xóa khỏi list insert
                        if (insertRows.Contains(editText))
                        {
                            insertRows.Remove(editText);
                        }
                        // thêm vào danh sách insert
                        if (!insertRows.Contains(editedText))
                        {
                            insertRows.Add(editedText);
                        }
                    }
                }
            }
            //gắn lại giá trị cho editText về rỗng để thực hiện so sánh lần sau
            editText = "";
        }

    }
}
