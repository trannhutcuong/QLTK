using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTonKho.Database
{
    class QUERY
    {
        

        // Lấy danh sách hàng hóa
        public static List<HANGHOA>  LayBangHangHoa()
        {
            List<HANGHOA> listHangHoa = new List<HANGHOA>();
            using (MyDBDataContext db = new MyDBDataContext())
            {
                var query = (from n in db.HANGHOAs
                             select n);
                foreach(var n in query)
                {
                    listHangHoa.Add(new HANGHOA
                    {
                        MAHANG = n.MAHANG,
                        TENHANG = n.TENHANG,
                        GIA = n.GIA,
                        MAKHO = n.MAKHO,
                        NGAYNHAP = n.NGAYNHAP,
                        SOLUONG = n.SOLUONG
                    });
                }
            }
            return listHangHoa;
        }

        // Lấy danh sách kho chứa
        public static List<KHO> LayBangKho()
        {
            List<KHO> listKho = new List<KHO>();
            using (MyDBDataContext db = new MyDBDataContext())
            {
                var query = (from n in db.KHOs
                             select n);
                foreach(var n in query)
                {
                    listKho.Add(new KHO()
                    {
                        MAKHO = n.MAKHO,
                        TENKHO = n.TENKHO
                    });
                }
            }
            return listKho;
        }

        internal static int LaySoLuongSanPhamKho(object maKho)
        {
            throw new NotImplementedException();
        }

        // Lấy danh sách khách hàng
        public static List<KHACHHANG> LayBangKhachHang()
        {
            List<KHACHHANG> listKH = new List<KHACHHANG>();
            using (MyDBDataContext db = new MyDBDataContext())
            {
                var query = (from n in db.KHACHHANGs
                             select n);
                foreach (var n in query)
                {
                    listKH.Add(new KHACHHANG()
                    {
                        MAKHACHHANG = n.MAKHACHHANG,
                        TENKHACHHANG = n.TENKHACHHANG,
                        SODIENTHOAI = n.SODIENTHOAI,
                        DIACHI = n.DIACHI
                    });
                }
            }
            return listKH;
        }

        // Lấy danh sách Phiếu hàng
        public static List<PHIEUHANG> LayBangPhieuHang()
        {
            List<PHIEUHANG> listPhieuHang = new List<PHIEUHANG>();
            using (MyDBDataContext db = new MyDBDataContext())
            {
                var query = (from n in db.PHIEUHANGs
                             select n);
                foreach (var n in query)
                {
                    listPhieuHang.Add(new PHIEUHANG()
                    {
                       SOCHUNGTU = n.SOCHUNGTU,
                       MAHANG = n.MAHANG,
                       MAKHACHHANG = n.MAKHACHHANG,
                       MAKHO = n.MAKHO,
                       NGAY = n.NGAY,
                       SOLUONG = n.SOLUONG,
                       DIENGIAI = n.DIENGIAI,
                       LOAIPHIEU = n.LOAIPHIEU
                    });
                }
            }
            return listPhieuHang;
        }

        // Lấy danh sách phiếu xuất kho
        public static List<PHIEUXUATKHO> LayBangPhieuXuatKho()
        {
            List<PHIEUXUATKHO> listPhieuXuatKho = new List<PHIEUXUATKHO>();
            using (MyDBDataContext db = new MyDBDataContext())
            {
                var query = (from n in db.PHIEUXUATKHOs
                             select n);
                foreach (var n in query)
                {
                    listPhieuXuatKho.Add(new PHIEUXUATKHO()
                    {
                        SOCHUNGTU = n.SOCHUNGTU,
                        MAHANG = n.MAHANG,
                        MAKHOXUAT = n.MAKHOXUAT,
                        MAKHONHAP = n.MAKHONHAP,
                        NGAY = n.NGAY,
                        DIENGIAI = n.DIENGIAI
                    });
                }
            }
            return listPhieuXuatKho;
        }

        // Kiểm tra mã kho đã tồn tại
        public static bool KiemTraMaKho(string maKho)
        {
            List<KHO> listKho = LayBangKho();
            int sokho = listKho.Count;
            for(int i = 0; i < sokho; ++i)
            {
                if (maKho.ToLower() == listKho[i].MAKHO.ToLower())
                    return true;
            }
            return false;
        }

        // Kiểm tra mã hàng hóa có tồn tại
        public static bool KiemTraMaHang(string maHang)
        {
            List<HANGHOA> listHang = LayBangHangHoa();
            int len = listHang.Count;
            for (int i = 0; i < len; ++i)
            {
                if (maHang.ToLower() == listHang[i].MAHANG.ToLower())
                    return true;
            }
            return false;
        }

        // Kiểm tra mã khách hàng có tồn tại
        public static bool KiemTraMaKhachHang(string maKhachHang)
        {
            List<KHACHHANG> listKhachHang = LayBangKhachHang();
            int len = listKhachHang.Count;
            for (int i = 0; i < len; ++i)
            {
                if (maKhachHang.ToLower() == listKhachHang[i].MAKHACHHANG.ToLower())
                    return true;
            }
            return false;
        }

        // Kiểm tra số chứng từ có tồn tại trong phiếu nhập xuất hay chưa
        public static bool KiemTraSoChungTu(string soChungTu)
        {
            List<PHIEUHANG> listPhieuHang = LayBangPhieuHang();
            int len = listPhieuHang.Count;
            for (int i = 0; i < len; ++i)
            {
                if (soChungTu.ToLower() == listPhieuHang[i].SOCHUNGTU.ToLower())
                    return true;
            }
            return false;
        }

        // Kiểm tra số chứng từ có tồn tại trong phiếu xuất kho hay chưa
        public static bool KiemTraSoChungTukho(string soChungTu)
        {
            List<PHIEUXUATKHO> listPhieuXuatKho = LayBangPhieuXuatKho();
            int len = listPhieuXuatKho.Count;
            for (int i = 0; i < len; ++i)
            {
                if (soChungTu.ToLower() == listPhieuXuatKho[i].SOCHUNGTU.ToLower())
                    return true;
            }
            return false;
        }

        // Lấy số lượng sản phẩm của một kho
        public static int LaySoLuongSanPhamKho(string MaKho)
        {
            List<HANGHOA> listHang = LayBangHangHoa();
            int len = listHang.Count;
            int SoLuong = 0;

            for(int i = 0; i < len; ++i)
            {
                if (listHang[i].MAKHO == MaKho)
                    SoLuong = SoLuong + (int)listHang[i].SOLUONG;
            }
            return SoLuong;
        }

        // Lấy mã kho của một mã hàng
        public static string LayMaKhoTuHang(string MaHang)
        {
            string MaKho = "";
            List<HANGHOA> listHang = LayBangHangHoa();
            int len = listHang.Count;

            for(int i = 0; i < len; ++i)
            {
                if (listHang[i].MAHANG == MaHang)
                    MaKho = listHang[i].MAKHO;
            }
            return MaKho;
        }

        // Lấy giá của một mã hàng
        public static int LayGiaTuHang(string MaHang)
        {
            int Gia = 0;
            List<HANGHOA> listHang = LayBangHangHoa();
            int len = listHang.Count;

            for (int i = 0; i < len; ++i)
            {
                if (listHang[i].MAHANG == MaHang)
                    Gia = (int)listHang[i].GIA;
            }
            return Gia;
        }

        // Lấy danh sách các phiếu theo ngày
        public static int LaySoLuongTonTheoNgay(DateTime ngay, string maHang)
        {
            int SoLuong = LaySoLuongTheoMa(maHang);
            List<PHIEUHANG> listPhieuDB = LayBangPhieuHang();
            int len = listPhieuDB.Count;

            for(int i = 0; i < len; ++i)
            {
                if((DateTime)listPhieuDB[i].NGAY >= ngay)
                {
                    SoLuong += (int)listPhieuDB[i].SOLUONG;
                }
            }
            return SoLuong;
        }

        // Lấy số lượng sản phẩm theo mã
        public static int LaySoLuongTheoMa(string maHang)
        {
            List<HANGHOA> listHang = LayBangHangHoa();
            int len = listHang.Count;

            for (int i = 0; i < len; ++i)
            {
                if (listHang[i].MAHANG == maHang)
                {
                    return (int)listHang[i].SOLUONG;
                }
            }
            return 0;
        }
    }
}
