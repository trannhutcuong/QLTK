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
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                HANGHOA hangHoaDB = (from n in db.HANGHOAs
                                     where n.MAHANG == hang.MaHang
                                     select n).FirstOrDefault();
                hangHoaDB.TENHANG = hang.TenHang;
                hangHoaDB.GIA = hang.Gia;
                hangHoaDB.NGAYNHAP = hang.NgayNhap;
                hangHoaDB.SOLUONG = hang.SoLuong;
                db.SubmitChanges();
            }
        }

        // Sửa thông tin khách hàng
        public static void CapNhatKhachHang(KhachHang khachHang)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
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
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
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
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                HANGHOA hangDB = (from n in db.HANGHOAs
                                  where n.MAHANG == MaHang
                                  select n).FirstOrDefault();
                hangDB.SOLUONG = hangDB.SOLUONG + soLuong;
                db.SubmitChanges();
            }
        }

        // Sửa thông tin phiếu hàng
        public static void CapNhatPhieuHang(PhieuHang phieuHang, int loaiPhieu)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                PHIEUHANG phieuHangDB = (from n in db.PHIEUHANGs
                                     where n.SOCHUNGTU == phieuHang.SoCT
                                     select n).FirstOrDefault();
                phieuHangDB.SOCHUNGTU = phieuHang.SoCT;
                phieuHangDB.NGAY = phieuHang.NgayNhap;
                phieuHangDB.MAHANG = phieuHang.MaHang;
                phieuHangDB.MAKHACHHANG = phieuHang.MaKH;
                phieuHangDB.DIENGIAI = phieuHang.DienGiai;
                phieuHangDB.LOAIPHIEU = (byte)loaiPhieu;
                phieuHangDB.SOLUONG = phieuHang.SoLuong;
                db.SubmitChanges();
            }
        }
        // Sửa thông tin kỳ
        public static void CapNhatKy(tonDauKy tonKy)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                TONKY tonKyDB = (from n in db.TONKies
                                     where n.MAKY == tonKy.MaKy
                                     select n).FirstOrDefault();
                tonKyDB.TENKY = tonKy.TenKy;
                tonKyDB.NGAYBATDAU = tonKy.NgayBatDau;
                tonKyDB.NGAYKETTHUC = tonKy.NgayKetThuc;
                db.SubmitChanges();
            }
        }
    }
}
