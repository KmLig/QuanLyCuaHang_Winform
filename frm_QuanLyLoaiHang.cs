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
    public partial class frm_QuanLyLoaiHang : Form
    {
        #region Khai báo biến và khởi tạo mảng
        string flag;
        string checkBoxChanged;
        int index;
        /*
        LOAIHANG[] LoaiHang = XL_LOAIHANG.KhoiTaoMangLoaiHang("Tao mang Loai hang:");
        MATHANG[] SP0 = XL_MATHANG.KhoiTaoMangMathang("Tao mang:");
        */
        #endregion
        public frm_QuanLyLoaiHang()
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

            txtLoaiHang.ReadOnly = true;
            txtMaSP.ReadOnly = true;

            btnThem.Focus();

        }
        public void UnLockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtLoaiHang.ReadOnly = false;
            txtMaSP.ReadOnly = false;

            txtLoaiHang.Focus();

        }
        public void LockControlTab()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtLoaiHang.ReadOnly = true;
            txtMaSP.ReadOnly = true;

            btnQuayVeDanhMucLoaiHang.Focus();
        }        
        public void LockTimKiem()
        {
            ckbLoaiHang.Enabled = true;
            ckbMaSP.Enabled = true;

            cbbTimKiem.Enabled = false;
            btnTimKiem.Enabled = false;
        }
        public void UnLockTimKiem()
        {
            ckbLoaiHang.Enabled = false;
            ckbMaSP.Enabled = false;

            cbbTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;

            cbbTimKiem.Text = "";
            cbbTimKiem.Focus();
        }
        public bool checkInput()
        {
            if (string.IsNullOrWhiteSpace(txtLoaiHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập Loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void UnLockCheckBox()
        {
            ckbLoaiHang.Checked = false;
            ckbMaSP.Checked = false;

            ckbLoaiHang.Enabled = true;
            ckbMaSP.Enabled = true;
        }
        public void UpdatedataGrid_LoaiHang()
        {
            for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
            {
                dataGrid_LoaiHang.Rows.Add(XL_CUAHANG.LoaiHang[i].LoaiSP, XL_CUAHANG.LoaiHang[i].MaSP);
            }
        }
        public void UpdatedataGrid_MatHangTheoLoaiHang()
        {
            for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
            {
                dataGrid_MatHangTheoLoaiHang.Rows.Add(XL_CUAHANG.SP0[i].maSanPham, XL_CUAHANG.SP0[i].tenSanPham, XL_CUAHANG.SP0[i].hanSudung, XL_CUAHANG.SP0[i].tenCongTy, XL_CUAHANG.SP0[i].namSanXuat, XL_CUAHANG.SP0[i].loaiSanPham);
            }
        }
        public void UpdateComboBoxTimKiem()
        {
            cbbTimKiem.Items.Clear();
            if (checkBoxChanged == "TimLoaiHang")
            {
                for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.LoaiHang[i].LoaiSP);
                    // tạo hàm rồi bỏ vào vòng lặp
                }
            }
            if (checkBoxChanged == "TimMaSP")
            {
                cbbTimKiem.Items.Clear();
                for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
                {
                    cbbTimKiem.Items.Add(XL_CUAHANG.LoaiHang[i].MaSP);
                }
            }            
            
        }           

        private void frm_QuanLyLoaiHang_Load(object sender, EventArgs e)
        {
            LockControl();
            LockTimKiem();

            UpdatedataGrid_LoaiHang();

            dataGrid_MatHangTheoLoaiHang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            UpdatedataGrid_MatHangTheoLoaiHang();            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "add";
            txtLoaiHang.Text = "";
            txtMaSP.Text = "";
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
            index = dataGrid_LoaiHang.CurrentCell.RowIndex;
            if (MessageBox.Show($"Bạn muốn xóa loại hàng {XL_CUAHANG.LoaiHang[index].LoaiSP} có mã sản phẩm là {XL_CUAHANG.LoaiHang[index].MaSP}?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
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
                        string inputLoaiHang = txtLoaiHang.Text;
                        string inputMaSP = txtMaSP.Text;
                        XL_LOAIHANG.ThemLoaiHang(ref XL_CUAHANG.LoaiHang, inputLoaiHang, inputMaSP);                        
                        dataGrid_LoaiHang.Rows.Add(XL_CUAHANG.LoaiHang[XL_CUAHANG.LoaiHang.Length - 1].LoaiSP, XL_CUAHANG.LoaiHang[XL_CUAHANG.LoaiHang.Length - 1].MaSP);
                        dataGrid_LoaiHang.RefreshEdit();                        
                    }
                }
            }
            if (flag == "edit")
            {                
                if (checkInput())
                {
                    if (MessageBox.Show("Bạn có muốn sửa loại hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        index = dataGrid_LoaiHang.CurrentCell.RowIndex;
                        string LoaiSPCanSua = XL_CUAHANG.LoaiHang[index].LoaiSP;
                        string MaSPCanSua = XL_CUAHANG.LoaiHang[index].MaSP;
                        XL_CUAHANG.LoaiHang[index].LoaiSP = txtLoaiHang.Text;
                        XL_CUAHANG.LoaiHang[index].MaSP = txtMaSP.Text;

                        dataGrid_LoaiHang.Rows.RemoveAt(index);
                        dataGrid_LoaiHang.Rows.Insert(index, XL_CUAHANG.LoaiHang[index].LoaiSP, XL_CUAHANG.LoaiHang[index].MaSP);
                        dataGrid_LoaiHang.RefreshEdit();

                        for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].loaiSanPham == LoaiSPCanSua || XL_CUAHANG.SP0[i].maSanPham == MaSPCanSua)
                            {
                                XL_CUAHANG.SP0[i].loaiSanPham = txtLoaiHang.Text;
                                XL_CUAHANG.SP0[i].maSanPham = txtMaSP.Text;
                                dataGrid_MatHangTheoLoaiHang.Rows.RemoveAt(i);
                                dataGrid_MatHangTheoLoaiHang.Rows.Insert(i, XL_CUAHANG.SP0[i].maSanPham, XL_CUAHANG.SP0[i].tenSanPham, XL_CUAHANG.SP0[i].hanSudung, XL_CUAHANG.SP0[i].tenCongTy, XL_CUAHANG.SP0[i].namSanXuat, XL_CUAHANG.SP0[i].loaiSanPham);
                            }
                        }
                        dataGrid_MatHangTheoLoaiHang.RefreshEdit();                        
                    }
                }
            }
            if (flag == "delete")
            {
                if (MessageBox.Show("Bạn có muốn xóa loại hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    index = dataGrid_LoaiHang.CurrentCell.RowIndex;
                    string dlLoaiSP = XL_CUAHANG.LoaiHang[index].LoaiSP;                    

                    if (index >= 0)
                    {
                        XL_LOAIHANG.XoaLoaiHang(ref XL_CUAHANG.LoaiHang, index);
                        dataGrid_LoaiHang.Rows.RemoveAt(index);
                        dataGrid_LoaiHang.RefreshEdit();

                        XL_LOAIHANG.XoaMatHangTheoLoaiHang(ref XL_CUAHANG.SP0, dlLoaiSP);
                        dataGrid_MatHangTheoLoaiHang.Rows.Clear();
                        UpdatedataGrid_MatHangTheoLoaiHang();
                        dataGrid_MatHangTheoLoaiHang.RefreshEdit();
                    }
                }
            }
            MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LockControl();        
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                LockControl();
                txtLoaiHang.Text = "";
                txtMaSP.Text = "";

            }
        }
        private void ckbLoaiHang_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "TimLoaiHang";
            UpdateComboBoxTimKiem();
            
        }
        private void ckbMaSP_CheckedChanged(object sender, EventArgs e)
        {
            UnLockTimKiem();
            checkBoxChanged = "TimMaSP";
            UpdateComboBoxTimKiem();
            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LockControlTab();
            if (checkBoxChanged == "TimLoaiHang")
            {
                if (checkcbbBoxInput())
                {
                    string inputLoaiHang = cbbTimKiem.Text;
                    int countLH = 0;
                    LOAIHANG[] searchedLH = new LOAIHANG[1];
                    for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
                    {
                        if (inputLoaiHang == XL_CUAHANG.LoaiHang[i].LoaiSP)
                        {
                            searchedLH[0] = XL_CUAHANG.LoaiHang[i];
                            
                            countLH++;
                        }
                    }
                    if (countLH == 0)
                    {
                        MessageBox.Show("Không có loại hàng bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGrid_LoaiHang.Rows.Clear();
                        dataGrid_LoaiHang.Rows.Add(searchedLH[0].LoaiSP, searchedLH[0].MaSP);

                        index = dataGrid_LoaiHang.CurrentCell.RowIndex;
                        txtLoaiHang.Text = searchedLH[index].LoaiSP;
                        txtMaSP.Text = searchedLH[index].MaSP;

                        int countMH = 0;
                        for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].loaiSanPham != inputLoaiHang)
                            {
                                countMH++;
                            }
                        }
                        MATHANG[] temp = new MATHANG[XL_CUAHANG.SP0.Length - countMH];
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].loaiSanPham == inputLoaiHang)
                            {
                                temp[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }
                        //MSP = new MATHANG[temp.Length];                        
                        dataGrid_MatHangTheoLoaiHang.Rows.Clear();
                        //dataGrid_MatHangTheoLoaiHang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                        for (int i = 0; i < temp.Length; i++)
                        {
                            dataGrid_MatHangTheoLoaiHang.Rows.Add(temp[i].maSanPham, temp[i].tenSanPham, temp[i].hanSudung, temp[i].tenCongTy, temp[i].namSanXuat, temp[i].loaiSanPham);
                        }

                        dataGrid_MatHangTheoLoaiHang.RefreshEdit();
                    }
                }

            }
            if (checkBoxChanged == "TimMaSP")
            {
                if (checkcbbBoxInput())
                {
                    string inputMaSP = cbbTimKiem.Text;
                    int countMaSP = 0;
                    LOAIHANG[] searchedLH = new LOAIHANG[1];
                    for (int i = 0; i < XL_CUAHANG.LoaiHang.Length; i++)
                    {
                        if (inputMaSP == XL_CUAHANG.LoaiHang[i].MaSP)
                        {
                            searchedLH[0] = XL_CUAHANG.LoaiHang[i];                            
                            countMaSP++;
                        }
                    }
                    if (countMaSP == 0)
                    {
                        MessageBox.Show("Không có mã sản phẩm bạn đang tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGrid_LoaiHang.Rows.Clear();
                        dataGrid_LoaiHang.Rows.Add(searchedLH[0].LoaiSP, searchedLH[0].MaSP);

                        index = dataGrid_LoaiHang.CurrentCell.RowIndex;
                        txtLoaiHang.Text = searchedLH[index].LoaiSP;
                        txtMaSP.Text = searchedLH[index].MaSP;

                        int countMH = 0;
                        for (int i = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].maSanPham != inputMaSP)
                            {
                                countMH++;
                            }
                        }
                        MATHANG[] temp = new MATHANG[XL_CUAHANG.SP0.Length - countMH];
                        for (int i = 0, j = 0; i < XL_CUAHANG.SP0.Length; i++)
                        {
                            if (XL_CUAHANG.SP0[i].maSanPham == inputMaSP)
                            {
                                temp[j] = XL_CUAHANG.SP0[i];
                                j++;
                            }
                        }

                        dataGrid_MatHangTheoLoaiHang.Rows.Clear();

                        for (int i = 0; i < temp.Length; i++)
                        {
                            dataGrid_MatHangTheoLoaiHang.Rows.Add(temp[i].maSanPham, temp[i].tenSanPham, temp[i].hanSudung, temp[i].tenCongTy, temp[i].namSanXuat, temp[i].loaiSanPham);
                        }

                        dataGrid_MatHangTheoLoaiHang.RefreshEdit();
                    }
                }
            }            
        }
        private void btnQuayVeDanhMucLoaiHang_Click(object sender, EventArgs e)
        {            
            LockControl();
            UnLockCheckBox();

            dataGrid_LoaiHang.Rows.Clear();
            UpdatedataGrid_LoaiHang();
            dataGrid_LoaiHang.RefreshEdit();

            dataGrid_MatHangTheoLoaiHang.Rows.Clear();
            UpdatedataGrid_MatHangTheoLoaiHang();
            dataGrid_MatHangTheoLoaiHang.RefreshEdit();
        }
        private void dataGrid_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtLoaiHang.Text = XL_CUAHANG.LoaiHang[index].LoaiSP;
            txtMaSP.Text = XL_CUAHANG.LoaiHang[index].MaSP;            
        }

        private void frm_QuanLyLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dataGrid_LoaiHang.Rows.Clear();
            UpdatedataGrid_LoaiHang();
            dataGrid_LoaiHang.RefreshEdit();

            dataGrid_MatHangTheoLoaiHang.Rows.Clear();
            UpdatedataGrid_MatHangTheoLoaiHang();
            dataGrid_MatHangTheoLoaiHang.RefreshEdit();
        }

        
    }
}
