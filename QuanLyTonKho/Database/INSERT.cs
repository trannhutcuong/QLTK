﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTonKho.UserControlLayout;

namespace QuanLyTonKho.Database
{
    class INSERT
    {
        // Thêm hàng hóa
        public static void ThemHangHoa(HangHoa hangHoa)
        {
            HANGHOA hangHoaDB = new HANGHOA();
            hangHoaDB.MAHANG = hangHoa.MaHang;
            hangHoaDB.TENHANG = hangHoa.TenHang;
            hangHoaDB.GIA = hangHoa.Gia;            hangHoaDB.NGAYNHAP = hangHoa.NgayNhap;
            hangHoaDB.SOLUONG = hangHoa.SoLuong;

            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.HANGHOAs.InsertOnSubmit(hangHoaDB);
                db.SubmitChanges();
            }
        }

        // Thêm khách hàng
        public static void ThemKhachHang(KhachHang khachHang)
        {
            KHACHHANG khachHangDB = new KHACHHANG();
            khachHangDB.MAKHACHHANG = khachHang.MaKhachHang;
            khachHangDB.TENKHACHHANG = khachHang.TenKhachHang;
            khachHangDB.SODIENTHOAI = khachHang.SDT;
            khachHangDB.DIACHI = khachHang.DiaChi;

            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.KHACHHANGs.InsertOnSubmit(khachHangDB);
                db.SubmitChanges();
            }
        }

        // Thêm kho
        public static void ThemKho(Kho kho)
        {
            KHO KhoDB = new KHO();
            KhoDB.MAKHO = kho.MaKho;
            KhoDB.TENKHO = kho.TenKho;

            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.KHOs.InsertOnSubmit(KhoDB);
                db.SubmitChanges();
            }
        }

        // Thêm phiếu hàng
        public static void ThemPhieuHang(PHIEUHANG phieu)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.PHIEUHANGs.InsertOnSubmit(phieu);
                db.SubmitChanges();
            }
        }

        // Thêm phiếu xuất kho
        public static void ThemPhieuXuatKho(PHIEUXUATKHO phieu)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.PHIEUXUATKHOs.InsertOnSubmit(phieu);
                db.SubmitChanges();
            }
        }
        // Thêm tồn đầu kỳ
        public static void ThemTonDauKy(TONKY tonKy)
        {
            using (MyDatabaseDataContext db = new MyDatabaseDataContext())
            {
                db.TONKies.InsertOnSubmit(tonKy);
                db.SubmitChanges();
            }
        }
    }
}
