
namespace DoAn_NMLT_2021
{
    partial class frm_QuanLyLoaiHang
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
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbHuongDanChonTimKiem = new System.Windows.Forms.Label();
            this.btnQuayVeDanhMucLoaiHang = new System.Windows.Forms.Button();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.ckbMaSP = new System.Windows.Forms.CheckBox();
            this.ckbLoaiHang = new System.Windows.Forms.CheckBox();
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbLoaiHang = new System.Windows.Forms.Label();
            this.dataGrid_LoaiHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbMatHangTheoLoaiHang = new System.Windows.Forms.GroupBox();
            this.dataGrid_MatHangTheoLoaiHang = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCongtySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTimKiem.SuspendLayout();
            this.gbThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LoaiHang)).BeginInit();
            this.gbMatHangTheoLoaiHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MatHangTheoLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnCapNhat);
            this.gbTimKiem.Controls.Add(this.lbHuongDanChonTimKiem);
            this.gbTimKiem.Controls.Add(this.btnQuayVeDanhMucLoaiHang);
            this.gbTimKiem.Controls.Add(this.cbbTimKiem);
            this.gbTimKiem.Controls.Add(this.btnTimKiem);
            this.gbTimKiem.Controls.Add(this.lbTimKiem);
            this.gbTimKiem.Controls.Add(this.ckbMaSP);
            this.gbTimKiem.Controls.Add(this.ckbLoaiHang);
            this.gbTimKiem.Location = new System.Drawing.Point(12, 8);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(421, 286);
            this.gbTimKiem.TabIndex = 20;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Mục tìm kiếm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCapNhat.Location = new System.Drawing.Point(6, 220);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(409, 50);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật để đồng bộ cửa hàng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbHuongDanChonTimKiem
            // 
            this.lbHuongDanChonTimKiem.AutoSize = true;
            this.lbHuongDanChonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHuongDanChonTimKiem.Location = new System.Drawing.Point(20, 127);
            this.lbHuongDanChonTimKiem.Name = "lbHuongDanChonTimKiem";
            this.lbHuongDanChonTimKiem.Size = new System.Drawing.Size(331, 17);
            this.lbHuongDanChonTimKiem.TabIndex = 21;
            this.lbHuongDanChonTimKiem.Text = "Chọn \"Loại hàng\" hoặc \"Mã sản phẩm\" để tìm kiếm ";
            // 
            // btnQuayVeDanhMucLoaiHang
            // 
            this.btnQuayVeDanhMucLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnQuayVeDanhMucLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayVeDanhMucLoaiHang.Location = new System.Drawing.Point(6, 152);
            this.btnQuayVeDanhMucLoaiHang.Name = "btnQuayVeDanhMucLoaiHang";
            this.btnQuayVeDanhMucLoaiHang.Size = new System.Drawing.Size(409, 50);
            this.btnQuayVeDanhMucLoaiHang.TabIndex = 20;
            this.btnQuayVeDanhMucLoaiHang.Text = "Quay về Danh mục Loại Hàng";
            this.btnQuayVeDanhMucLoaiHang.UseVisualStyleBackColor = true;
            this.btnQuayVeDanhMucLoaiHang.Click += new System.EventHandler(this.btnQuayVeDanhMucLoaiHang_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Location = new System.Drawing.Point(98, 31);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(190, 24);
            this.cbbTimKiem.TabIndex = 19;
            
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTimKiem.Location = new System.Drawing.Point(313, 21);
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
            // ckbMaSP
            // 
            this.ckbMaSP.AutoSize = true;
            this.ckbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMaSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbMaSP.Location = new System.Drawing.Point(173, 85);
            this.ckbMaSP.Name = "ckbMaSP";
            this.ckbMaSP.Size = new System.Drawing.Size(115, 21);
            this.ckbMaSP.TabIndex = 17;
            this.ckbMaSP.Text = "Mã sản phẩm";
            this.ckbMaSP.UseVisualStyleBackColor = true;
            this.ckbMaSP.CheckedChanged += new System.EventHandler(this.ckbMaSP_CheckedChanged);
            // 
            // ckbLoaiHang
            // 
            this.ckbLoaiHang.AutoSize = true;
            this.ckbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbLoaiHang.Location = new System.Drawing.Point(36, 85);
            this.ckbLoaiHang.Name = "ckbLoaiHang";
            this.ckbLoaiHang.Size = new System.Drawing.Size(93, 21);
            this.ckbLoaiHang.TabIndex = 16;
            this.ckbLoaiHang.Text = "Loại hàng";
            this.ckbLoaiHang.UseVisualStyleBackColor = true;
            this.ckbLoaiHang.CheckedChanged += new System.EventHandler(this.ckbLoaiHang_CheckedChanged);
            // 
            // gbThaoTac
            // 
            this.gbThaoTac.Controls.Add(this.btnThem);
            this.gbThaoTac.Controls.Add(this.btnSua);
            this.gbThaoTac.Controls.Add(this.btnXoa);
            this.gbThaoTac.Controls.Add(this.label2);
            this.gbThaoTac.Controls.Add(this.txtLoaiHang);
            this.gbThaoTac.Controls.Add(this.btnHuy);
            this.gbThaoTac.Controls.Add(this.label3);
            this.gbThaoTac.Controls.Add(this.btnLuu);
            this.gbThaoTac.Controls.Add(this.txtMaSP);
            this.gbThaoTac.Location = new System.Drawing.Point(453, 8);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(629, 252);
            this.gbThaoTac.TabIndex = 21;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Mục thao tác: Thêm, sửa, xóa các loại hàng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(36, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 37);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(195, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnXoa.Location = new System.Drawing.Point(356, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loại hàng";
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoaiHang.Location = new System.Drawing.Point(173, 91);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(200, 30);
            this.txtLoaiHang.TabIndex = 8;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(512, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 72);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã sản phẩm";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(512, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 72);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSP.Location = new System.Drawing.Point(173, 152);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 30);
            this.txtMaSP.TabIndex = 11;
            // 
            // lbLoaiHang
            // 
            this.lbLoaiHang.AutoSize = true;
            this.lbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLoaiHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLoaiHang.Location = new System.Drawing.Point(7, 315);
            this.lbLoaiHang.Name = "lbLoaiHang";
            this.lbLoaiHang.Size = new System.Drawing.Size(265, 25);
            this.lbLoaiHang.TabIndex = 24;
            this.lbLoaiHang.Text = "Loại hàng có trong cửa hàng:";
            // 
            // dataGrid_LoaiHang
            // 
            this.dataGrid_LoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_LoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colMaSP});
            this.dataGrid_LoaiHang.Location = new System.Drawing.Point(12, 367);
            this.dataGrid_LoaiHang.Name = "dataGrid_LoaiHang";
            this.dataGrid_LoaiHang.RowHeadersWidth = 51;
            this.dataGrid_LoaiHang.RowTemplate.Height = 24;
            this.dataGrid_LoaiHang.Size = new System.Drawing.Size(421, 394);
            this.dataGrid_LoaiHang.TabIndex = 23;
            this.dataGrid_LoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_LoaiHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loại hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monthCalendar1.Location = new System.Drawing.Point(1130, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            // 
            // gbMatHangTheoLoaiHang
            // 
            this.gbMatHangTheoLoaiHang.Controls.Add(this.dataGrid_MatHangTheoLoaiHang);
            this.gbMatHangTheoLoaiHang.Location = new System.Drawing.Point(453, 266);
            this.gbMatHangTheoLoaiHang.Name = "gbMatHangTheoLoaiHang";
            this.gbMatHangTheoLoaiHang.Size = new System.Drawing.Size(967, 505);
            this.gbMatHangTheoLoaiHang.TabIndex = 26;
            this.gbMatHangTheoLoaiHang.TabStop = false;
            this.gbMatHangTheoLoaiHang.Text = "Các mặt hàng theo loại hàng:";
            // 
            // dataGrid_MatHangTheoLoaiHang
            // 
            this.dataGrid_MatHangTheoLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_MatHangTheoLoaiHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGrid_MatHangTheoLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MatHangTheoLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colHanSD,
            this.colCongtySX,
            this.colNamSX,
            this.colLoaiHang});
            this.dataGrid_MatHangTheoLoaiHang.Location = new System.Drawing.Point(6, 38);
            this.dataGrid_MatHangTheoLoaiHang.Name = "dataGrid_MatHangTheoLoaiHang";
            this.dataGrid_MatHangTheoLoaiHang.ReadOnly = true;
            this.dataGrid_MatHangTheoLoaiHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGrid_MatHangTheoLoaiHang.RowHeadersWidth = 51;
            this.dataGrid_MatHangTheoLoaiHang.RowTemplate.Height = 24;
            this.dataGrid_MatHangTheoLoaiHang.Size = new System.Drawing.Size(955, 457);
            this.dataGrid_MatHangTheoLoaiHang.TabIndex = 1;
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
            // frm_QuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 783);
            this.Controls.Add(this.gbMatHangTheoLoaiHang);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbLoaiHang);
            this.Controls.Add(this.dataGrid_LoaiHang);
            this.Controls.Add(this.gbThaoTac);
            this.Controls.Add(this.gbTimKiem);
            this.Name = "frm_QuanLyLoaiHang";
            this.Text = "Quản lý Loại Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QuanLyLoaiHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_QuanLyLoaiHang_Load);
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbThaoTac.ResumeLayout(false);
            this.gbThaoTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_LoaiHang)).EndInit();
            this.gbMatHangTheoLoaiHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MatHangTheoLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lbHuongDanChonTimKiem;
        private System.Windows.Forms.Button btnQuayVeDanhMucLoaiHang;
        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.CheckBox ckbMaSP;
        private System.Windows.Forms.CheckBox ckbLoaiHang;
        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbLoaiHang;
        private System.Windows.Forms.DataGridView dataGrid_LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox gbMatHangTheoLoaiHang;
        private System.Windows.Forms.DataGridView dataGrid_MatHangTheoLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCongtySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.Button btnCapNhat;
    }
}