using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTonKho.Layout;
using QuanLyTonKho.UserControlLayout;

namespace QuanLyTonKho.Database
{
    class UPDATE
    {
        // Sửa thông tin hàng hóa
        public static void CapNhatHangHoa(HangHoa hang)
        {
            using (MyDBDataContext db = new MyDBDataContext())
            {
                HANGHOA hangHoaDB = (from n in db.HANGHOAs
                                     where n.MAHANG == hang.MaHang
                                     select n).FirstOrDefault();
                hangHoaDB.TENHANG = hang.TenHang;
                hangHoaDB.GIA = hang.Gia;
                hangHoaDB.MAKHO = hang.KhoChua;
                hangHoaDB.NGAYNHAP = hang.NgayNhap;
                hangHoaDB.SOLUONG = hang.SoLuong;
                db.SubmitChanges();
            }
        }

        // Sửa thông tin khách hàng
        public static void CapNhatKhachHang(KhachHang khachHang)
        {
            using (MyDBDataContext db = new MyDBDataContext())
            {
                KHACHHANG khachHangDB = (from n in db.KHACHHANGs
                                       where n.MAKHACHHANG == khachHang.MaKhachHang
                                       select n).FirstOrDefault();
                khachHangDB.MAKHACHHANG = khachHang.MaKhachHang;
                khachHangDB.TENKHACHHANG = khachHang.TenKhachHang;
                khachHangDB.SODIENTHOAI = khachHang.SDT;
                khachHangDB.DIACHI = khachHang.DiaChi;

                db.SubmitChanges();
            }
        }

        // Sửa thông tin kho
        public static void CapNhatKho(Kho kho)
        {
            using (MyDBDataContext db = new MyDBDataContext())
            {
                KHO khoDB = (from n in db.KHOs
                                         where n.MAKHO == kho.MaKho
                                         select n).FirstOrDefault();
                khoDB.MAKHO = kho.MaKho;
                khoDB.TENKHO = kho.TenKho;

                db.SubmitChanges();
            }
        }

        // Sửa thông tin số lượng sản phẩm
        public static void SuaSoLuongSanPham(string MaHang, int soLuong)
        {
            using (MyDBDataContext db = new MyDBDataContext())
            {
                HANGHOA hangDB = (from n in db.HANGHOAs
                                  where n.MAHANG == MaHang
                                  select n).FirstOrDefault();
                hangDB.SOLUONG = hangDB.SOLUONG + soLuong;
                db.SubmitChanges();
            }
        }

        // Sửa thông tin kho hàng hóa
        public static void SuaKhoSanPham(string MaHang, string maKho)
        {
            using (MyDBDataContext db = new MyDBDataContext())
            {
                HANGHOA hangDB = (from n in db.HANGHOAs
                                  where n.MAHANG == MaHang
                                  select n).FirstOrDefault();
                hangDB.MAKHO = maKho;
                db.SubmitChanges();
            }
        }
    }
}
