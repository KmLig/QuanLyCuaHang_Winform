using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_NMLT_2021
{
    public partial class frm_QuanLyMatHang : Form
    {
        #region Khởi tạo mảng và biến global
        string flag;
        string checkBoxChanged;
        int index;
        //MATHANG[] SP0 = XL_MATHANG.KhoiTaoMangMathang("Tao mang:");
        #endregion

        public frm_QuanLyMatHang()
        {
            InitializeComponent();
        }
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            
            libMaSP.Enabled = false;
            txtTenMH.ReadOnly = true;            
            dateTimePickerHanSD.Enabled = false;
            txtCongtySX.ReadOnly = true;
            txtNamSX.ReadOnly = true;
            libLoaiHang.Enabled = false;

            btnThem.Focus();

        }
        public void UnLockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;


            libMaSP.Enabled = true;
            txtTenMH.ReadOnly = false;            
            dateTimePickerHanSD.Enabled = false;
            txtCongtySX.ReadOnly = false;
            txtNamSX.ReadOnly = false;
            libLoaiHang.Enabled = true;

            btnLuu.Focus();

        }
        public void LockControlTab()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            libMaSP.Enabled = false;
            txtTenMH.ReadOnly = true;            
            dateTimePickerHanSD.Enabled = false;
            txtCongtySX.ReadOnly = true;
            txtNamSX.ReadOnly = true;
            libLoaiHang.Enabled = false;

            btnQuayVeDanhMucLoaiHang.Focus();
        }
        public void LockTimKiem()
        {
            ckbLoaiHang.Checked = false;
            ckbTenMH.Checked = false;
            ckbCongtySX.Checked = false;
            ckbHanSD.Checked = false;

            ckbLoaiHang.Enabled = true;
            ckbTenMH.Enabled = true;
            ckbCongtySX.Enabled = true;
            ckbHanSD.Enabled = true;


            cbbTimKiem.Enabled = false;
            btnTimKiem.Enabled = false;
        }
        public void UnLockTimKiem()
        {
            ckbLoaiHang.Enabled = false;
            ckbTenMH.Enabled = false;
            ckbCongtySX.Enabled = false;
            ckbHanSD.Enabled = false;

            cbbTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;

            cbbTimKiem.Text = "";
            cbbTimKiem.Focus();
        }
        public bool checkInput()
        {
            if (string.IsNullOrWhiteSpace(libMaSP.Text))
            {
                MessageBox.Show("Bạn chưa chọn Mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(string.IsNullOrWhiteSpace(dateTimePickerHanSD.Text))
            {
                MessageBox.Show("Bạn chưa nhập Hạn sử dụng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCongtySX.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNamSX.Text))
            {
                MessageBox.Show("Bạn chưa nhập Năm sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(libLoaiHang.Text))
            {
                MessageBox.Show("Bạn chưa chọn Loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        public bool checkcbbBoxInput()
        {
            if (string.IsNullOrWhiteSpace(cbbTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }        
        public void UpdatedataGrid_MatHang()
        {
            for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
            {
                dataGrid_MatHang.Rows.Add(XL_CUAHANG.SP0[i].maSanPham, XL_CUAHANG.SP0[i].tenSanPham, XL_CUAHANG.SP0[i].hanSudung, XL_CUAHANG.SP0[i].tenCongTy, XL_CUAHANG.SP0[i].namSanXuat, XL_CUAHANG.SP0[i].loaiSanPham);
            }
        }                                            
        public void UpdateLiB_MaSP_LoaiHang()
        {
            libLoaiHang.Items.Clear();
            libMaSP.Items.Clear();
            for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
            {
                libMaSP.Items.Add(XL_CUAHANG.LoaiHang[i].MaSP);
                libLoaiHang.Items.Add(XL_CUAHANG.LoaiHang[i].LoaiSP);
            }
        }
        public void UpdateCBB_TimKiem()
        {
            cbbTimKiem.Items.Clear();
            if (checkBoxChanged == "Loaihang")
            {
                for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.LoaiHang[i].LoaiSP);
                }
            }
            if (checkBoxChanged == "TenMH")
            {
                for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.SP0[i].tenSanPham);
                }
            }
            if (checkBoxChanged == "CongtySX")
            {                
                for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.SP0[i].tenCongTy);
                }
            }
            if (checkBoxChanged == "NamSX")
            {
                for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.SP0[i].namSanXuat);
                }
            }
        }

        private void frm_QuanLyMatHang_Load(object sender, EventArgs e)
        {
            LockControl();
            LockTimKiem();
            dataGrid_MatHang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            UpdatedataGrid_MatHang();
            UpdateLiB_MaSP_LoaiHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "add";

            libMaSP.Text = "";
            txtTenMH.Text = "";            
            dateTimePickerHanSD.Enabled = true;
            txtCongtySX.Text = "";
            txtNamSX.Text = "";
            libLoaiHang.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "edit";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "delete";
            index = dataGrid_MatHang.CurrentCell.RowIndex;
            if (MessageBox.Show($"Bạn muốn xóa loại hàng {XL_CUAHANG.SP0[index].tenSanPham} có mã sản phẩm là {XL_CUAHANG.SP0[index].maSanPham}?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Chọn nút Lưu để xác nhận xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuu.Focus();
            }
            else
            {
                LockControl();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (MessageBox.Show("Bạn có muốn lưu loại hàng thêm mới này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (checkInput())
                    {
                        string inputMaMH = libMaSP.Text;
                        string inputTenMH = txtTenMH.Text;
                        string inputHanSD = dateTimePickerHanSD.Text;                        
                        string inputCongtySX = txtCongtySX.Text;
                        string inputNamSX = txtNamSX.Text;
                        string inputLoaiHang = libLoaiHang.Text;

                        
                        XL_MATHANG.ThemMatHang(ref XL_CUAHANG.SP0, inputMaMH, inputTenMH, inputHanSD, inputCongtySX, inputNamSX, inputLoaiHang);
                        dataGrid_MatHang.Rows.Add(XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].maSanPham, XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].tenSanPham, XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].hanSudung, XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].tenCongTy, XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].namSanXuat, XL_CUAHANG.SP0[XL_CUAHANG.SP0.Length - 1].loaiSanPham);
                        dataGrid_MatHang.RefreshEdit();
                        MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (flag == "edit")
            {
                if (checkInput())
                {
                    index = dataGrid_MatHang.CurrentCell.RowIndex;

                    
                    string MaMHCanSua = XL_CUAHANG.SP0[index].maSanPham;
                    string TenMHCanSua = XL_CUAHANG.SP0[index].tenSanPham;
                    string HanSDCanSua = XL_CUAHANG.SP0[index].hanSudung.ToString();
                    string CongtySXCanSua = XL_CUAHANG.SP0[index].tenCongTy;
                    string NamSPCanSua = XL_CUAHANG.SP0[index].namSanXuat.ToString();
                    string LoaiHangCanSua = XL_CUAHANG.SP0[index].loaiSanPham;

                    XL_CUAHANG.SP0[index].maSanPham = libMaSP.Text;
                    XL_CUAHANG.SP0[index].tenSanPham = txtTenMH.Text;
                    XL_CUAHANG.SP0[index].hanSudung = DateTime.Parse(dateTimePickerHanSD.Text);
                    XL_CUAHANG.SP0[index].tenCongTy = txtCongtySX.Text;
                    XL_CUAHANG.SP0[index].namSanXuat = int.Parse(txtNamSX.Text);
                    XL_CUAHANG.SP0[index].loaiSanPham = libLoaiHang.Text;

                    dataGrid_MatHang.Rows.RemoveAt(index);
                    dataGrid_MatHang.Rows.Insert(index, XL_CUAHANG.SP0[index].maSanPham, XL_CUAHANG.SP0[index].tenSanPham, XL_CUAHANG.SP0[index].hanSudung, XL_CUAHANG.SP0[index].tenCongTy, XL_CUAHANG.SP0[index].namSanXuat, XL_CUAHANG.SP0[index].loaiSanPham);
                    dataGrid_MatHang.RefreshEdit();
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (flag == "delete")
            {
                if (MessageBox.Show("Bạn có muốn xóa loại hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    index = dataGrid_MatHang.CurrentCell.RowIndex;
                    if (index>=0)
                    {
                        XL_MATHANG.XoaMatHang(ref XL_CUAHANG.SP0, index);
                        dataGrid_MatHang.Rows.Clear();
                        UpdatedataGrid_MatHang();
                        dataGrid_MatHang.RefreshEdit();
                        MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                    
                                                      
                }
            }
            else
            {
                MessageBox.Show("Chưa lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                     
            LockControl();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                LockControl();
                libMaSP.Text = "";
                txtTenMH.Text = "";
                dateTimePickerHanSD.Enabled = true;
                txtCongtySX.Text = "";
                txtNamSX.Text = "";
                libLoaiHang.Text = "";
            }
        }

        private void dataGrid_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            libMaSP.Text = XL_CUAHANG.SP0[index].maSanPham;
            txtTenMH.Text = XL_CUAHANG.SP0[index].tenSanPham;
            dateTimePickerHanSD.Text = XL_CUAHANG.SP0[index].hanSudung.ToString();
            txtCongtySX.Text = XL_CUAHANG.SP0[index].tenCongTy;
            txtNamSX.Text = XL_CUAHANG.SP0[index].namSanXuat.ToString();
            libLoaiHang.Text = XL_CUAHANG.SP0[index].loaiSanPham;
        }

        private void ckbLoaiHang_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "Loaihang";
            UpdateCBB_TimKiem();
        }
        private void ckbTenMH_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "TenMH";
            UpdateCBB_TimKiem();
        }
        private void ckbCongtySX_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "CongtySX";
            UpdateCBB_TimKiem();
        }
        private void ckbHanSD_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "NamSX";
            UpdateCBB_TimKiem();
        }        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LockControlTab();
            if (checkBoxChanged == "Loaihang")
            {
                if (checkcbbBoxInput())
                {
                    string inputLoaiHang = cbbTimKiem.Text;
                    int countMH = 0;
                    
                    for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                    {
                        if (inputLoaiHang == XL_CUAHANG.SP0[i].loaiSanPham)
                        {                            
                            countMH++;
                        }
                    }
                    MATHANG[] searchedMH = new MATHANG[countMH];
                    if (countMH == 0)
                    {
                        MessageBox.Show("Không có loại hàng bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].loaiSanPham == inputLoaiHang)
                            {
                                searchedMH[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }
                        dataGrid_MatHang.Rows.Clear();
                        for (int i = 0; i < searchedMH.Length; i++)
                        {
                            dataGrid_MatHang.Rows.Add(searchedMH[i].maSanPham, searchedMH[i].tenSanPham, searchedMH[i].hanSudung, searchedMH[i].tenCongTy, searchedMH[i].namSanXuat, searchedMH[i].loaiSanPham);
                        }
                        dataGrid_MatHang.RefreshEdit();
                    }
                }

            }
            if (checkBoxChanged == "TenMH")
            {
                if (checkcbbBoxInput())
                {
                    string inputTenMH = cbbTimKiem.Text;
                    int countMH = 0;

                    for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                    {
                        if (inputTenMH == XL_CUAHANG.SP0[i].tenSanPham)
                        {
                            countMH++;
                        }
                    }
                    MATHANG[] searchedMH = new MATHANG[countMH];
                    if (countMH == 0)
                    {
                        MessageBox.Show("Không có loại hàng bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].tenSanPham == inputTenMH)
                            {
                                searchedMH[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }
                        dataGrid_MatHang.Rows.Clear();
                        for (int i = 0; i < searchedMH.Length; i++)
                        {
                            dataGrid_MatHang.Rows.Add(searchedMH[i].maSanPham, searchedMH[i].tenSanPham, searchedMH[i].hanSudung, searchedMH[i].tenCongTy, searchedMH[i].namSanXuat, searchedMH[i].loaiSanPham);
                        }
                        dataGrid_MatHang.RefreshEdit();
                    }
                }
            }
            if (checkBoxChanged == "CongtySX")
            {
                if (checkcbbBoxInput())
                {
                    string inputCongtySX = cbbTimKiem.Text;
                    int countMH = 0;

                    for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                    {
                        if (inputCongtySX == XL_CUAHANG.SP0[i].tenCongTy)
                        {
                            countMH++;
                        }
                    }
                    MATHANG[] searchedMH = new MATHANG[countMH];
                    if (countMH == 0)
                    {
                        MessageBox.Show("Không có loại hàng bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].tenCongTy == inputCongtySX)
                            {
                                searchedMH[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }
                        dataGrid_MatHang.Rows.Clear();
                        for (int i = 0; i < searchedMH.Length; i++)
                        {
                            dataGrid_MatHang.Rows.Add(searchedMH[i].maSanPham, searchedMH[i].tenSanPham, searchedMH[i].hanSudung, searchedMH[i].tenCongTy, searchedMH[i].namSanXuat, searchedMH[i].loaiSanPham);
                        }
                        dataGrid_MatHang.RefreshEdit();
                    }
                }
            }
            if (checkBoxChanged == "NamSX")
            {
                if (checkcbbBoxInput())
                {
                    int inputNamSX = int.Parse(cbbTimKiem.Text);
                    int countMH = 0;

                    for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                    {
                        if (inputNamSX == XL_CUAHANG.SP0[i].namSanXuat)
                        {
                            countMH++;
                        }
                    }
                    MATHANG[] searchedMH = new MATHANG[countMH];
                    if (countMH == 0)
                    {
                        MessageBox.Show("Không có loại hàng bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].namSanXuat == inputNamSX)
                            {
                                searchedMH[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }
                        dataGrid_MatHang.Rows.Clear();
                        for (int i = 0; i < searchedMH.Length; i++)
                        {
                            dataGrid_MatHang.Rows.Add(searchedMH[i].maSanPham, searchedMH[i].tenSanPham, searchedMH[i].hanSudung, searchedMH[i].tenCongTy, searchedMH[i].namSanXuat, searchedMH[i].loaiSanPham);
                        }
                        dataGrid_MatHang.RefreshEdit();
                    }
                }
            }
        }
        private void btnQuayVeDanhMucLoaiHang_Click(object sender, EventArgs e)
        {
            LockTimKiem();
            LockControl();            
            

            dataGrid_MatHang.Rows.Clear();
            UpdatedataGrid_MatHang();
            dataGrid_MatHang.RefreshEdit();
        }
        private void frm_QuanLyMatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) !=DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dataGrid_MatHang.Rows.Clear();
            UpdatedataGrid_MatHang();
            dataGrid_MatHang.RefreshEdit();
            UpdateLiB_MaSP_LoaiHang();
        }
    }
}
