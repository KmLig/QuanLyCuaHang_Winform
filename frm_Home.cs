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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btnQuanLyMatHang_Click(object sender, EventArgs e)
        {
            frm_QuanLyMatHang fMH = new frm_QuanLyMatHang();          
            fMH.Show();            
        }

        private void btnQuanLyLoaiHang_Click(object sender, EventArgs e)
        {
            frm_QuanLyLoaiHang fLH = new frm_QuanLyLoaiHang();            
            fLH.Show();
        }        

        private void frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        
    }
}
