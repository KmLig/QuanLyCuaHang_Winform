using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NMLT_2021
{
    public struct MATHANG
    {
        public string maSanPham;
        public string tenSanPham;
        public DateTime hanSudung;
        public string tenCongTy;
        public int namSanXuat;
        public string loaiSanPham;
        public MATHANG(string maSanPham, string tenSanPham, DateTime hanSudung, string tenCongTy, int namSanXuat, string loaiSanPham)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.hanSudung = hanSudung;
            this.tenCongTy = tenCongTy;
            this.namSanXuat = namSanXuat;
            this.loaiSanPham = loaiSanPham;
        }
    }
    class XL_MATHANG
    {
        public static MATHANG[] KhoiTaoMangMathang(string ghichu)
        {
            MATHANG[] SP0 = new MATHANG[12];
            #region Tạo trước các struct sản phẩm
            MATHANG A = new MATHANG("KH-SP2021", "Sony XZ Premium", new DateTime(2025, 10, 20), "Sony", 2021, "Smartphone");
            MATHANG A1 = new MATHANG("KH-SP2021", "Samsung Note 10", new DateTime(2026, 10, 20), "Samsung", 2019, "Smartphone");
            MATHANG A2 = new MATHANG("KH-SP2021", "Nokia 6800", new DateTime(2022, 12, 20), "Nokia", 2018, "Smartphone");
            MATHANG A3 = new MATHANG("KH-SP2021", "iPhone 10 Plus", new DateTime(2024, 10, 20), "Apple", 2021, "Smartphone");
            MATHANG B = new MATHANG("KH-LT2021", "Dell XPS", new DateTime(2028, 10, 20), "Dell", 2020, "Laptop");
            MATHANG B1 = new MATHANG("KH-LT2021", "HP Probook 430", new DateTime(2030, 10, 20), "PH", 2021, "Laptop");
            MATHANG C = new MATHANG("KH-SK2021", "Nike Airmax", new DateTime(2023, 10, 20), "Nike", 2021, "Sneaker");
            MATHANG C1 = new MATHANG("KH-SK2021", "Addidas Fluidstreet", new DateTime(2023, 10, 20), "Addidas", 2020, "Sneaker");
            MATHANG C2 = new MATHANG("KH-SK2021", "Addidas Ultraboost 21", new DateTime(2023, 10, 20), "Addidas", 2018, "Sneaker");
            MATHANG D = new MATHANG("KH-V2021", "Ví da handmade", new DateTime(2027, 10, 20), "PUS-LEATHER", 2019, "Ví");
            MATHANG D1 = new MATHANG("KH-V2021", "Ví thổ cẩm", new DateTime(2025, 10, 20), "PUS-LEATHER", 2020, "Ví");
            MATHANG D2 = new MATHANG("KH-V2021", "Ví đựng thẻ ATM", new DateTime(2025, 10, 20), "PUS-LEATHER", 2021, "Ví");

            #endregion
            #region Tạo mảng struct sản phẩm            
            SP0[0] = A;
            SP0[1] = A1;
            SP0[2] = A2;
            SP0[3] = A3;
            SP0[4] = B;
            SP0[5] = B1;
            SP0[6] = C;
            SP0[7] = C1;
            SP0[8] = C2;
            SP0[9] = D;
            SP0[10] = D1;
            SP0[11] = D2;
            #endregion
            return SP0;
        }
        public static bool ThemMatHang(ref MATHANG[] SP0, string inputMaSP, string inputTenMH, string inputHanSD, string inputCongtySX, string inputNamSX, string inputLoaiHang)
        {
            MATHANG[] temp = new MATHANG[SP0.Length + 1];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = SP0[i];
            }
            temp[temp.Length - 1].maSanPham = inputMaSP;
            temp[temp.Length - 1].tenSanPham = inputTenMH;
            temp[temp.Length - 1].hanSudung = DateTime.Parse(inputHanSD);
            temp[temp.Length - 1].tenCongTy = inputCongtySX;
            temp[temp.Length - 1].namSanXuat = int.Parse(inputNamSX);
            temp[temp.Length - 1].loaiSanPham = inputLoaiHang;
            
            SP0 = new MATHANG[temp.Length];
            SP0 = temp;
            return true;
        }
        public static bool XoaMatHang(ref MATHANG[] SP0, int index)
        {
            MATHANG[] temp = new MATHANG[SP0.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = SP0[i];
            }
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = SP0[i + 1];
            }
            //Đã cập nhật sau khi xóa
            SP0 = new MATHANG[temp.Length];
            SP0 = temp;
            return true;
        }
    }
}
