
namespace DoAn_NMLT_2021
{
    partial class frm_QuanLyMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.libLoaiHang = new System.Windows.Forms.ListBox();
            this.libMaSP = new System.Windows.Forms.ListBox();
            this.dateTimePickerHanSD = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbLoaiHang = new System.Windows.Forms.Label();
            this.lbTenMH = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lbHanSD = new System.Windows.Forms.Label();
            this.lbCongtySX = new System.Windows.Forms.Label();
            this.txtCongtySX = new System.Windows.Forms.TextBox();
            this.lbNamSX = new System.Windows.Forms.Label();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.gbMatHang = new System.Windows.Forms.GroupBox();
            this.dataGrid_MatHang = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCongtySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.ckbHanSD = new System.Windows.Forms.CheckBox();
            this.ckbCongtySX = new System.Windows.Forms.CheckBox();
            this.lbHuongDanChonTimKiem = new System.Windows.Forms.Label();
            this.btnQuayVeDanhMucLoaiHang = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.ckbTenMH = new System.Windows.Forms.CheckBox();
            this.ckbLoaiHang = new System.Windows.Forms.CheckBox();
            this.gbThaoTac.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.gbMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.Controls.Add(this.libLoaiHang);
            this.gbThaoTac.Controls.Add(this.libMaSP);
            this.gbThaoTac.Controls.Add(this.dateTimePickerHanSD);
            this.gbThaoTac.Controls.Add(this.monthCalendar1);
            this.gbThaoTac.Controls.Add(this.btnHuy);
            this.gbThaoTac.Controls.Add(this.btnLuu);
            this.gbThaoTac.Controls.Add(this.lbLoaiHang);
            this.gbThaoTac.Controls.Add(this.lbTenMH);
            this.gbThaoTac.Controls.Add(this.txtTenMH);
            this.gbThaoTac.Controls.Add(this.lbHanSD);
            this.gbThaoTac.Controls.Add(this.lbCongtySX);
            this.gbThaoTac.Controls.Add(this.txtCongtySX);
            this.gbThaoTac.Controls.Add(this.lbNamSX);
            this.gbThaoTac.Controls.Add(this.txtNamSX);
            this.gbThaoTac.Controls.Add(this.btnThem);
            this.gbThaoTac.Controls.Add(this.btnSua);
            this.gbThaoTac.Controls.Add(this.btnXoa);
            this.gbThaoTac.Controls.Add(this.lbMaMH);
            this.gbThaoTac.Location = new System.Drawing.Point(12, 3);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(399, 775);
            this.gbThaoTac.TabIndex = 22;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Mục thao tác: Thêm, sửa, xóa các mặt hàng";
            // 
            // libLoaiHang
            // 
            this.libLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libLoaiHang.FormattingEnabled = true;
            this.libLoaiHang.ItemHeight = 25;
            this.libLoaiHang.Location = new System.Drawing.Point(145, 371);
            this.libLoaiHang.Name = "libLoaiHang";
            this.libLoaiHang.Size = new System.Drawing.Size(178, 29);
            this.libLoaiHang.TabIndex = 29;
            // 
            // libMaSP
            // 
            this.libMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libMaSP.FormattingEnabled = true;
            this.libMaSP.ItemHeight = 25;
            this.libMaSP.Location = new System.Drawing.Point(145, 106);
            this.libMaSP.Name = "libMaSP";
            this.libMaSP.Size = new System.Drawing.Size(169, 29);
            this.libMaSP.TabIndex = 28;
            // 
            // dateTimePickerHanSD
            // 
            this.dateTimePickerHanSD.Location = new System.Drawing.Point(146, 212);
            this.dateTimePickerHanSD.Name = "dateTimePickerHanSD";
            this.dateTimePickerHanSD.Size = new System.Drawing.Size(241, 22);
            this.dateTimePickerHanSD.TabIndex = 27;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monthCalendar1.Location = new System.Drawing.Point(32, 526);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(226, 439);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 54);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(15, 439);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 54);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbLoaiHang
            // 
            this.lbLoaiHang.AutoSize = true;
            this.lbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLoaiHang.Location = new System.Drawing.Point(-4, 375);
            this.lbLoaiHang.Name = "lbLoaiHang";
            this.lbLoaiHang.Size = new System.Drawing.Size(98, 25);
            this.lbLoaiHang.TabIndex = 22;
            this.lbLoaiHang.Text = "Loại hàng";
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenMH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTenMH.Location = new System.Drawing.Point(-5, 156);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(133, 25);
            this.lbTenMH.TabIndex = 20;
            this.lbTenMH.Text = "Tên mặt hàng";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenMH.Location = new System.Drawing.Point(145, 156);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(242, 30);
            this.txtTenMH.TabIndex = 18;
            // 
            // lbHanSD
            // 
            this.lbHanSD.AutoSize = true;
            this.lbHanSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHanSD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbHanSD.Location = new System.Drawing.Point(-5, 209);
            this.lbHanSD.Name = "lbHanSD";
            this.lbHanSD.Size = new System.Drawing.Size(123, 25);
            this.lbHanSD.TabIndex = 21;
            this.lbHanSD.Text = "Hạn sử dụng";
            // 
            // lbCongtySX
            // 
            this.lbCongtySX.AutoSize = true;
            this.lbCongtySX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCongtySX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCongtySX.Location = new System.Drawing.Point(-7, 263);
            this.lbCongtySX.Name = "lbCongtySX";
            this.lbCongtySX.Size = new System.Drawing.Size(113, 25);
            this.lbCongtySX.TabIndex = 16;
            this.lbCongtySX.Text = "Công ty SX";
            // 
            // txtCongtySX
            // 
            this.txtCongtySX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongtySX.Location = new System.Drawing.Point(145, 260);
            this.txtCongtySX.Name = "txtCongtySX";
            this.txtCongtySX.Size = new System.Drawing.Size(178, 30);
            this.txtCongtySX.TabIndex = 14;
            // 
            // lbNamSX
            // 
            this.lbNamSX.AutoSize = true;
            this.lbNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNamSX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNamSX.Location = new System.Drawing.Point(-7, 322);
            this.lbNamSX.Name = "lbNamSX";
            this.lbNamSX.Size = new System.Drawing.Size(132, 25);
            this.lbNamSX.TabIndex = 17;
            this.lbNamSX.Text = "Năm sản xuất";
            // 
            // txtNamSX
            // 
            this.txtNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNamSX.Location = new System.Drawing.Point(145, 317);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(178, 30);
            this.txtNamSX.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(32, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 37);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(145, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(263, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMaMH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMaMH.Location = new System.Drawing.Point(-5, 106);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(131, 25);
            this.lbMaMH.TabIndex = 13;
            this.lbMaMH.Text = "Mã sản phẩm";
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.gbMatHang);
            this.gbTimKiem.Controls.Add(this.btnCapNhat);
            this.gbTimKiem.Controls.Add(this.ckbHanSD);
            this.gbTimKiem.Controls.Add(this.ckbCongtySX);
            this.gbTimKiem.Controls.Add(this.lbHuongDanChonTimKiem);
            this.gbTimKiem.Controls.Add(this.btnQuayVeDanhMucLoaiHang);
            this.gbTimKiem.Controls.Add(this.cbbTimKiem);
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.lbTimKiem);
            this.gbTimKiem.Controls.Add(this.ckbTenMH);
            this.gbTimKiem.Controls.Add(this.ckbLoaiHang);
            this.gbTimKiem.Location = new System.Drawing.Point(426, 3);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(984, 775);
            this.gbTimKiem.TabIndex = 23;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Mục tìm kiếm mặt hàng";
            // 
            // gbMatHang
            // 
            this.gbMatHang.Controls.Add(this.dataGrid_MatHang);
            this.gbMatHang.Location = new System.Drawing.Point(6, 204);
            this.gbMatHang.Name = "gbMatHang";
            this.gbMatHang.Size = new System.Drawing.Size(967, 566);
            this.gbMatHang.TabIndex = 27;
            this.gbMatHang.TabStop = false;
            this.gbMatHang.Text = "Các mặt hàng trong cửa hàng:";
            // 
            // dataGrid_MatHang
            // 
            this.dataGrid_MatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_MatHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colHanSD,
            this.colCongtySX,
            this.colNamSX,
            this.colLoaiHang});
            this.dataGrid_MatHang.Location = new System.Drawing.Point(6, 21);
            this.dataGrid_MatHang.Name = "dataGrid_MatHang";
            this.dataGrid_MatHang.ReadOnly = true;
            this.dataGrid_MatHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrid_MatHang.RowHeadersWidth = 51;
            this.dataGrid_MatHang.RowTemplate.Height = 24;
            this.dataGrid_MatHang.Size = new System.Drawing.Size(955, 539);
            this.dataGrid_MatHang.TabIndex = 1;
            this.dataGrid_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_MatHang_CellClick);
            // 
            // colMaMH
            // 
            this.colMaMH.HeaderText = "Mã mặt hàng";
            this.colMaMH.MinimumWidth = 6;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            // 
            // colTenMH
            // 
            this.colTenMH.HeaderText = "Tên mặt hàng";
            this.colTenMH.MinimumWidth = 6;
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.ReadOnly = true;
            // 
            // colHanSD
            // 
            this.colHanSD.HeaderText = "Hạn sử dụng";
            this.colHanSD.MinimumWidth = 6;
            this.colHanSD.Name = "colHanSD";
            this.colHanSD.ReadOnly = true;
            // 
            // colCongtySX
            // 
            this.colCongtySX.HeaderText = "Công ty sản xuất";
            this.colCongtySX.MinimumWidth = 6;
            this.colCongtySX.Name = "colCongtySX";
            this.colCongtySX.ReadOnly = true;
            // 
            // colNamSX
            // 
            this.colNamSX.HeaderText = "Năm sản xuất";
            this.colNamSX.MinimumWidth = 6;
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.ReadOnly = true;
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.HeaderText = "Loại hàng";
            this.colLoaiHang.MinimumWidth = 6;
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.ReadOnly = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCapNhat.Location = new System.Drawing.Point(620, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(325, 67);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập nhật để đồng bộ cửa hàng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ckbHanSD
            // 
            this.ckbHanSD.AutoSize = true;
            this.ckbHanSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHanSD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbHanSD.Location = new System.Drawing.Point(49, 111);
            this.ckbHanSD.Name = "ckbHanSD";
            this.ckbHanSD.Size = new System.Drawing.Size(116, 21);
            this.ckbHanSD.TabIndex = 23;
            this.ckbHanSD.Text = "Năm sản xuất";
            this.ckbHanSD.UseVisualStyleBackColor = true;
            this.ckbHanSD.CheckedChanged += new System.EventHandler(this.ckbHanSD_CheckedChanged);
            // 
            // ckbCongtySX
            // 
            this.ckbCongtySX.AutoSize = true;
            this.ckbCongtySX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCongtySX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbCongtySX.Location = new System.Drawing.Point(320, 75);
            this.ckbCongtySX.Name = "ckbCongtySX";
            this.ckbCongtySX.Size = new System.Drawing.Size(135, 21);
            this.ckbCongtySX.TabIndex = 22;
            this.ckbCongtySX.Text = "Công ty sản xuất";
            this.ckbCongtySX.UseVisualStyleBackColor = true;
            this.ckbCongtySX.CheckedChanged += new System.EventHandler(this.ckbCongtySX_CheckedChanged);
            // 
            // lbHuongDanChonTimKiem
            // 
            this.lbHuongDanChonTimKiem.AutoSize = true;
            this.lbHuongDanChonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHuongDanChonTimKiem.Location = new System.Drawing.Point(46, 156);
            this.lbHuongDanChonTimKiem.Name = "lbHuongDanChonTimKiem";
            this.lbHuongDanChonTimKiem.Size = new System.Drawing.Size(269, 17);
            this.lbHuongDanChonTimKiem.TabIndex = 21;
            this.lbHuongDanChonTimKiem.Text = "Chọn một trong các mục trên để tìm kiếm ";
            // 
            // btnQuayVeDanhMucLoaiHang
            // 
            this.btnQuayVeDanhMucLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnQuayVeDanhMucLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayVeDanhMucLoaiHang.Location = new System.Drawing.Point(620, 29);
            this.btnQuayVeDanhMucLoaiHang.Name = "btnQuayVeDanhMucLoaiHang";
            this.btnQuayVeDanhMucLoaiHang.Size = new System.Drawing.Size(325, 67);
            this.btnQuayVeDanhMucLoaiHang.TabIndex = 20;
            this.btnQuayVeDanhMucLoaiHang.Text = "Quay về Danh mục Mặt Hàng";
            this.btnQuayVeDanhMucLoaiHang.UseVisualStyleBackColor = true;
            this.btnQuayVeDanhMucLoaiHang.Click += new System.EventHandler(this.btnQuayVeDanhMucLoaiHang_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Smartphone",
            "Laptop",
            "Sneaker",
            "Ví"});
            this.cbbTimKiem.Location = new System.Drawing.Point(98, 31);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(315, 24);
            this.cbbTimKiem.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTimKiem.Location = new System.Drawing.Point(451, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 50);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTimKiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTimKiem.Location = new System.Drawing.Point(1, 33);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(91, 25);
            this.lbTimKiem.TabIndex = 14;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // ckbTenMH
            // 
            this.ckbTenMH.AutoSize = true;
            this.ckbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTenMH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbTenMH.Location = new System.Drawing.Point(173, 75);
            this.ckbTenMH.Name = "ckbTenMH";
            this.ckbTenMH.Size = new System.Drawing.Size(118, 21);
            this.ckbTenMH.TabIndex = 17;
            this.ckbTenMH.Text = "Tên mặt hàng";
            this.ckbTenMH.UseVisualStyleBackColor = true;
            this.ckbTenMH.CheckedChanged += new System.EventHandler(this.ckbTenMH_CheckedChanged);
            // 
            // ckbLoaiHang
            // 
            this.ckbLoaiHang.AutoSize = true;
            this.ckbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbLoaiHang.Location = new System.Drawing.Point(49, 75);
            this.ckbLoaiHang.Name = "ckbLoaiHang";
            this.ckbLoaiHang.Size = new System.Drawing.Size(93, 21);
            this.ckbLoaiHang.TabIndex = 16;
            this.ckbLoaiHang.Text = "Loại hàng";
            this.ckbLoaiHang.UseVisualStyleBackColor = true;
            this.ckbLoaiHang.CheckedChanged += new System.EventHandler(this.ckbLoaiHang_CheckedChanged);
            // 
            // frm_QuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 790);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThaoTac);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "frm_QuanLyMatHang";
            this.Text = "Quản lý Mặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QuanLyMatHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_QuanLyMatHang_Load);
            this.gbThaoTac.ResumeLayout(false);
            this.gbThaoTac.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbMatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lbHuongDanChonTimKiem;
        private System.Windows.Forms.Button btnQuayVeDanhMucLoaiHang;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.CheckBox ckbTenMH;
        private System.Windows.Forms.CheckBox ckbLoaiHang;
        private System.Windows.Forms.GroupBox gbMatHang;
        private System.Windows.Forms.DataGridView dataGrid_MatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCongtySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.Label lbTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lbHanSD;
        private System.Windows.Forms.Label lbCongtySX;
        private System.Windows.Forms.TextBox txtCongtySX;
        private System.Windows.Forms.Label lbNamSX;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.Label lbLoaiHang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox ckbCongtySX;
        private System.Windows.Forms.CheckBox ckbHanSD;
        private System.Windows.Forms.DateTimePicker dateTimePickerHanSD;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListBox libMaSP;
        private System.Windows.Forms.ListBox libLoaiHang;
    }
}