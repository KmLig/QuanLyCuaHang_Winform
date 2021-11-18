
namespace DoAn_NMLT_2021
{
    partial class frm_Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuanLyMatHang = new System.Windows.Forms.Button();
            this.btnQuanLyLoaiHang = new System.Windows.Forms.Button();
            this.gbThongTinLienHe = new System.Windows.Forms.GroupBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbGmail = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.gbThongTinLienHe.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuanLyMatHang);
            this.groupBox1.Controls.Add(this.btnQuanLyLoaiHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn cửa sổ thao tác quản lý:";
            // 
            // btnQuanLyMatHang
            // 
            this.btnQuanLyMatHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQuanLyMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMatHang.Location = new System.Drawing.Point(30, 48);
            this.btnQuanLyMatHang.Name = "btnQuanLyMatHang";
            this.btnQuanLyMatHang.Size = new System.Drawing.Size(322, 172);
            this.btnQuanLyMatHang.TabIndex = 2;
            this.btnQuanLyMatHang.Text = "Quản lý mặt hàng";
            this.btnQuanLyMatHang.UseVisualStyleBackColor = false;
            this.btnQuanLyMatHang.Click += new System.EventHandler(this.btnQuanLyMatHang_Click);
            // 
            // btnQuanLyLoaiHang
            // 
            this.btnQuanLyLoaiHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQuanLyLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLoaiHang.Location = new System.Drawing.Point(30, 260);
            this.btnQuanLyLoaiHang.Name = "btnQuanLyLoaiHang";
            this.btnQuanLyLoaiHang.Size = new System.Drawing.Size(322, 181);
            this.btnQuanLyLoaiHang.TabIndex = 1;
            this.btnQuanLyLoaiHang.Text = "Quản lý loại hàng";
            this.btnQuanLyLoaiHang.UseVisualStyleBackColor = false;
            this.btnQuanLyLoaiHang.Click += new System.EventHandler(this.btnQuanLyLoaiHang_Click);
            // 
            // gbThongTinLienHe
            // 
            this.gbThongTinLienHe.Controls.Add(this.lbSDT);
            this.gbThongTinLienHe.Controls.Add(this.lbMSSV);
            this.gbThongTinLienHe.Controls.Add(this.lbGmail);
            this.gbThongTinLienHe.Controls.Add(this.lbTen);
            this.gbThongTinLienHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinLienHe.Location = new System.Drawing.Point(521, 28);
            this.gbThongTinLienHe.Name = "gbThongTinLienHe";
            this.gbThongTinLienHe.Size = new System.Drawing.Size(513, 294);
            this.gbThongTinLienHe.TabIndex = 0;
            this.gbThongTinLienHe.TabStop = false;
            this.gbThongTinLienHe.Text = "Thông tin liên hệ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(28, 149);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(157, 20);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "SĐT: 0988351085";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(28, 189);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(152, 20);
            this.lbMSSV.TabIndex = 2;
            this.lbMSSV.Text = "MSSV: 21880067";
            // 
            // lbGmail
            // 
            this.lbGmail.AutoSize = true;
            this.lbGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGmail.Location = new System.Drawing.Point(28, 226);
            this.lbGmail.Name = "lbGmail";
            this.lbGmail.Size = new System.Drawing.Size(344, 20);
            this.lbGmail.TabIndex = 1;
            this.lbGmail.Text = "Email: phamxuankhiem1102@gmail.com";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(28, 104);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(162, 20);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Phạm Xuân Khiêm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(698, 487);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 547);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbThongTinLienHe);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Home";
            this.Text = "Chương trình Quản lý cửa hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Home_FormClosing);            
            this.groupBox1.ResumeLayout(false);
            this.gbThongTinLienHe.ResumeLayout(false);
            this.gbThongTinLienHe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuanLyMatHang;
        private System.Windows.Forms.Button btnQuanLyLoaiHang;
        private System.Windows.Forms.GroupBox gbThongTinLienHe;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbGmail;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbSDT;
    }
}

