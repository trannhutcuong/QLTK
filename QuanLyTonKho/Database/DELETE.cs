using QuanLyTonKho.UserControlLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTonKho.Database
{
    class DELETE
    {
        // Xóa một hàng hóa khỏi database
        public static void XoaHangHoa(HangHoa hangHoa)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                HANGHOA hangHoaDB = (from n in db.HANGHOAs
                                     where n.MAHANG == hangHoa.MaHang
                                     select n).FirstOrDefault();
                XoaMaHangKhoiPHIEUHANG(hangHoa.MaHang);
                XoaMaHangKhoiPHIEUXUATKHO(hangHoa.MaHang);
                db.HANGHOAs.DeleteOnSubmit(hangHoaDB);
                db.SubmitChanges();
            }
        }

        // Xóa một khách hàng khỏi database
        public static void XoaKhachHang(KhachHang khachHang)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                KHACHHANG khachHangDB = (from n in db.KHACHHANGs
                                       where n.MAKHACHHANG == khachHang.MaKhachHang
                                     select n).FirstOrDefault();
                XoaKhachHangKhoiPHIEUHANG(khachHang.MaKhachHang);

                db.KHACHHANGs.DeleteOnSubmit(khachHangDB);
                db.SubmitChanges();
            }
        }

        // Xóa một kho khỏi database
        public static void XoaKho(Kho kho)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                KHO khoDB = (from n in db.KHOs
                             where n.MAKHO == kho.MaKho
                             select n).FirstOrDefault();
                db.KHOs.DeleteOnSubmit(khoDB);
                db.SubmitChanges();
            }
        }

        // Xóa 1 Mã hàng khỏi danh sách PHIEUHANG
        public static void XoaMaHangKhoiPHIEUHANG(string MaHang)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                var PhieuHang = (from n in db.PHIEUHANGs
                                 where n.MAHANG == MaHang
                                 select n);
                foreach(var n in PhieuHang)
                {
                    db.PHIEUHANGs.DeleteOnSubmit(n);
                    db.SubmitChanges();
                }
            }
        }

        // Xóa 1 Mã hàng khỏi danh sách PHIEUXUATKHO
        public static void XoaMaHangKhoiPHIEUXUATKHO(string MaHang)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                var PhieuXuatKho = (from n in db.PHIEUXUATKHOs
                                    where n.MAHANG == MaHang
                                    select n);
                foreach(var n in PhieuXuatKho)
                {
                    db.PHIEUXUATKHOs.DeleteOnSubmit(n);
                    db.SubmitChanges();
                }
            }
        }

        // Xóa một mã khách hàng khỏi danh sách PHIEUHANG
        public static void XoaKhachHangKhoiPHIEUHANG(string MaKhachHang)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                var PhieuHang = (from n in db.PHIEUHANGs
                                 where n.MAKHACHHANG == MaKhachHang
                                 select n);
                foreach (var n in PhieuHang)
                {
                    db.PHIEUHANGs.DeleteOnSubmit(n);
                    db.SubmitChanges();
                }
            }
        }

        // Xóa một phiếu nhập hoặc xuất hàng khỏi PHIEUHANG
        public static void XoaPhieuHang(string SoCT)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                var PhieuHang = (from n in db.PHIEUHANGs
                                 where n.SOCHUNGTU == SoCT
                                 select n);
                foreach (var n in PhieuHang)
                {
                    db.PHIEUHANGs.DeleteOnSubmit(n);
                    db.SubmitChanges();
                }
            }
        }

        // Xóa một tồn kỳ khỏi database
        public static void XoaKy(tonDauKy tonKy)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                TONKY tonKyDB = (from n in db.TONKies
                                     where n.MAKY == tonKy.MaKy
                                     select n).FirstOrDefault();
                db.TONKies.DeleteOnSubmit(tonKyDB);
                db.SubmitChanges();
            }
        }
    }
}
