using QuanLyTiemThuocFinalVersion.View.HoaDonBan;
using QuanLyTiemThuocFinalVersion.View.HoaDonNhap;
using QuanLyTiemThuocFinalVersion.View.NhanVien;
using QuanLyTiemThuocFinalVersion.View.NhanVien.CauHinh;
using QuanLyTiemThuocFinalVersion.View.Thuoc;
using QuanLyTiemThuocFinalVersion.View.Thuoc.CauHinh;
using QuanLyTiemThuocFinalVersion.View.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void disposeAllMDIChildrenForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Dispose();
            }
        }

        private void showFormInMDIContainer(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            showFormInMDIContainer(formTrangChu);
        }

        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormTrangChu"))
            {
                disposeAllMDIChildrenForms();
                FormTrangChu formTrangChu = new FormTrangChu();
                showFormInMDIContainer(formTrangChu);
            }
        }

        private void menuBanThuocMain_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormBanThuoc"))
            {
                disposeAllMDIChildrenForms();
                FormBanThuoc formBanThuoc = new FormBanThuoc();
                showFormInMDIContainer(formBanThuoc);
            }
        }

        private void menuThongKeHoaDonBan_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThongKeHoaDonBan"))
            {
                disposeAllMDIChildrenForms();
                FormThongKeHoaDonBan formThongKeHoaDonBan = new FormThongKeHoaDonBan();
                showFormInMDIContainer(formThongKeHoaDonBan);
            }
        }

        private void menuThongKeKhachHang_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThongKeKhachHang"))
            {
                disposeAllMDIChildrenForms();
                FormThongKeKhachHang formThongKeKhachHang = new FormThongKeKhachHang();
                showFormInMDIContainer(formThongKeKhachHang);
            }
        }

        private void menuThemMoiHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThemMoiHoaDonNhap"))
            {
                disposeAllMDIChildrenForms();
                FormThemMoiHoaDonNhap formThemMoiHoaDonNhap = new FormThemMoiHoaDonNhap();
                showFormInMDIContainer(formThemMoiHoaDonNhap);
            }
        }

        private void menuThongKeHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThongKeHoaDonNhap"))
            {
                disposeAllMDIChildrenForms();
                FormThongKeHoaDonNhap formThongKeHoaDonNhap = new FormThongKeHoaDonNhap();
                showFormInMDIContainer(formThongKeHoaDonNhap);
            }
        }

        private void menuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormNhaCungCap"))
            {
                disposeAllMDIChildrenForms();
                FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
                showFormInMDIContainer(formNhaCungCap);
            }

        }

        private void menuThemMoiThuoc_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThemMoiThuoc"))
            {
                disposeAllMDIChildrenForms();
                FormThemMoiThuoc formThemMoiThuoc = new FormThemMoiThuoc();
                showFormInMDIContainer(formThemMoiThuoc);
            }

        }

        private void menuThongKeThuoc_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThongKeThuoc"))
            {
                disposeAllMDIChildrenForms();
                FormThongKeThuoc formThongKeThuoc = new FormThongKeThuoc();
                showFormInMDIContainer(formThongKeThuoc);
            }

        }

        private void menuCauHinhDonViTinh_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhDonViTinh"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhDonViTinh formCauHinhDonViTinh = new FormCauHinhDonViTinh();
                showFormInMDIContainer(formCauHinhDonViTinh);
            }

        }

        private void menuCauHinhDangDieuChe_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhDangDieuChe"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhDangDieuChe formCauHinhDangDieuChe = new FormCauHinhDangDieuChe();
                showFormInMDIContainer(formCauHinhDangDieuChe);
            }
        }

        private void menuCauHinhNuocSanXuat_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhNuocSanXuat"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhNuocSanXuat formCauHinhNuocSanXuat = new FormCauHinhNuocSanXuat();
                showFormInMDIContainer(formCauHinhNuocSanXuat);
            }
        }

        private void menuThemMoiNhanVien_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThemMoiNhanVien"))
            {
                disposeAllMDIChildrenForms();
                FormThemMoiNhanVien formThemMoiNhanVien = new FormThemMoiNhanVien();
                showFormInMDIContainer(formThemMoiNhanVien);
            }
        }

        private void menuThongKeNhanVien_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormThongKeNhanVien"))
            {
                disposeAllMDIChildrenForms();
                FormThongKeNhanVien formThongKeNhanVien = new FormThongKeNhanVien();
                showFormInMDIContainer(formThongKeNhanVien);
            }
        }

        private void menuCauHinhChuyenMon_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhChuyenMon"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhChuyenMon formCauHinhChuyenMon = new FormCauHinhChuyenMon();
                showFormInMDIContainer(formCauHinhChuyenMon);
            }
        }

        private void menuCauHinhTrinhDo_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhTrinhDo"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhTrinhDo formCauHinhTrinhDo = new FormCauHinhTrinhDo();
                showFormInMDIContainer(formCauHinhTrinhDo);
            }
        }

        private void menuCauHinhCongDung_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren[0].Name.Equals("FormCauHinhCongDung"))
            {
                disposeAllMDIChildrenForms();
                FormCauHinhCongDung formCauHinhCongDung = new FormCauHinhCongDung();
                showFormInMDIContainer(formCauHinhCongDung);
            }
        }
    }
}
