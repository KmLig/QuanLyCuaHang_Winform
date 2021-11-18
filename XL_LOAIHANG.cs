using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NMLT_2021
{
    public struct LOAIHANG
    {
        public string LoaiSP;
        public string MaSP;

        public LOAIHANG(string LoaiSP, string MaSP)
        {
            this.LoaiSP = LoaiSP;
            this.MaSP = MaSP;
        }
    }

    class XL_LOAIHANG
    {
        
        public static LOAIHANG[] KhoiTaoMangLoaiHang(string ghiChu)
        {
            LOAIHANG[] LH = new LOAIHANG[4];
            LH[0] = new LOAIHANG("Smartphone", "KH-SP2021");
            LH[1] = new LOAIHANG("Laptop", "KH-LT2021");
            LH[2] = new LOAIHANG("Sneaker", "KH-SK2021");
            LH[3] = new LOAIHANG("Ví", "KH-V2021");
            return LH;
        }
        public static bool TimKiemLoaiHang(LOAIHANG[] LH, string input)
        {
            int count = 0;
            LOAIHANG[] searchedLH = new LOAIHANG[1];
            for (int i = 0; i < LH.Length; i++)
            {
                if (input == LH[i].LoaiSP)
                {
                    searchedLH[0] = LH[i];
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Không có loại hàng bạn đang tìm kiếm");
                return false;
            }
            return true;


        }
        public static bool ThemLoaiHang(ref LOAIHANG[] LoaiHang, string inputLoaiHang, string inputMaSP)
        {
            LOAIHANG[] temp = new LOAIHANG[LoaiHang.Length + 1];
            for (int i = 0; i < temp.Length - 1; i++)
            {
                temp[i] = LoaiHang[i];
            }
            temp[temp.Length - 1].LoaiSP = inputLoaiHang;
            temp[temp.Length - 1].MaSP = inputMaSP;
            LoaiHang = new LOAIHANG[temp.Length];
            LoaiHang = temp;
            return true;
        }
        public static bool XoaLoaiHang(ref LOAIHANG[] LoaiHang, int index)
        {
            LOAIHANG[] temp = new LOAIHANG[LoaiHang.Length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = LoaiHang[i];
            }
            for (int i = index; i < temp.Length; i++)
            {
                temp[i] = LoaiHang[i + 1];
            }
            //Đã cập nhật sau khi xóa
            LoaiHang = new LOAIHANG[temp.Length];
            LoaiHang = temp;
            return true;
        }
        public static bool XoaMatHangTheoLoaiHang(ref MATHANG[] SP0, string dlLoaiSP)
        {
            int count = 0;
            for (int i = 0; i < SP0.Length; i++)
            {
                if (SP0[i].loaiSanPham == dlLoaiSP)
                {
                    count++;
                }
            }
            MATHANG[] tempMH = new MATHANG[SP0.Length - count];
            for (int i = 0, j = 0; i < SP0.Length; i++)
            {
                if (SP0[i].loaiSanPham != dlLoaiSP)
                {
                    tempMH[j] = SP0[i];
                    j++;
                }
            }
            SP0 = new MATHANG[tempMH.Length];
            SP0 = tempMH;
            return true;
        }
        
    }
}
