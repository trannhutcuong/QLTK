using QuanLyTonKho.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyTonKho.UserControlLayout
{
    /// <summary>
    /// Interaction logic for PhieuXuatHang.xaml
    /// </summary>
    public partial class PhieuXuatHang : UserControl
    {
        public PhieuXuatHang()
        {
            InitializeComponent();
            NapDanhSachPhieuXuat();


        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            ThemPhieuHang themPhieuXuat = new ThemPhieuHang(2);
            themPhieuXuat.ShowDialog();
            NapDanhSachPhieuXuat();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            PhieuHang phieuXuat = lvPhieuXuatHang.SelectedItem as PhieuHang;
            if (phieuXuat != null)
            {
                if (MessageBox.Show("Xóa phiếu xuất hàng đã chọn", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    Database.DELETE.XoaPhieuHang(phieuXuat.SoCT);
                    NapDanhSachPhieuXuat();
                }
            }
            else
                MessageBox.Show("Hãy chọn phiếu cần xóa", "Thông báo");
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            PhieuHang phieuNhap = lvPhieuXuatHang.SelectedItem as PhieuHang;
            if (phieuNhap != null)
            {
                SuaPhieuHang suaPhieuNhap = new SuaPhieuHang(phieuNhap, 2);
                suaPhieuNhap.ShowDialog();
                NapDanhSachPhieuXuat();
            }
            else
                MessageBox.Show("Hãy chọn phiếu cần chỉnh sửa", "Thông báo");
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NapDanhSachPhieuXuat()
        {
            List<PhieuHang> listNhap = new List<PhieuHang>();
            List<PHIEUHANG> listHangDB = Database.QUERY.LayBangPhieuHang();
            int len = listHangDB.Count;
            int stt = 1;
            for (int i = 0; i < len; ++i)
            {
                if (listHangDB[i].LOAIPHIEU == 2)
                {
                    listNhap.Add(new PhieuHang()
                    {
                        STT = stt,
                        SoCT = listHangDB[i].SOCHUNGTU,
                        MaHang = listHangDB[i].MAHANG,
                        MaKH = listHangDB[i].MAKHACHHANG,
                        NgayNhap = (DateTime)listHangDB[i].NGAY,
                        SoLuong = -(int)listHangDB[i].SOLUONG,
                        DienGiai = listHangDB[i].DIENGIAI
                    });
                    stt++;
                }
            }
            lvPhieuXuatHang.ItemsSource = listNhap;
        }

        private void lbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
