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
    /// Interaction logic for PhieuNhapHang.xaml
    /// </summary>
    public partial class PhieuNhapHang : UserControl
    {
        public PhieuNhapHang()
        {
            InitializeComponent();
            NapDanhSachPhieuNhap();
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            ThemPhieuHang themPhieuNhap = new ThemPhieuHang(1);
            themPhieuNhap.ShowDialog();
            NapDanhSachPhieuNhap();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            PhieuHang phieuNhap = lvPhieuNhapHang.SelectedItem as PhieuHang;
            if (phieuNhap != null)
            {
                if (MessageBox.Show("Xóa phiếu nhập hàng đã chọn", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    Database.DELETE.XoaPhieuHang(phieuNhap.SoCT);
                    NapDanhSachPhieuNhap();
                }
            }
            else
                MessageBox.Show("Hãy chọn phiếu cần xóa", "Thông báo");
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            PhieuHang phieuNhap = lvPhieuNhapHang.SelectedItem as PhieuHang;
            if (phieuNhap != null)
            {
                SuaPhieuHang suaPhieuNhap = new SuaPhieuHang(phieuNhap, 1);
                suaPhieuNhap.ShowDialog();
                NapDanhSachPhieuNhap();
            }
            else
                MessageBox.Show("Hãy chọn phiếu cần chỉnh sửa", "Thông báo");
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NapDanhSachPhieuNhap()
        {
            List<PhieuHang> listNhap = new List<PhieuHang>();
            List<PHIEUHANG> listHangDB = Database.QUERY.LayBangPhieuHang();
            int len = listHangDB.Count;
            int stt = 1;
            for (int i = 0; i < len; ++i)
            {
                if(listHangDB[i].LOAIPHIEU == 1)
                {
                    listNhap.Add(new PhieuHang()
                    {
                        STT = stt,
                        SoCT = listHangDB[i].SOCHUNGTU,
                        MaHang = listHangDB[i].MAHANG,
                        MaKH = listHangDB[i].MAKHACHHANG,
                        NgayNhap = (DateTime)listHangDB[i].NGAY,
                        SoLuong = (int)listHangDB[i].SOLUONG,
                        DienGiai = listHangDB[i].DIENGIAI
                    });
                    stt++;
                }
            }
            lvPhieuNhapHang.ItemsSource = listNhap;
        }

        private void lbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
    public class PhieuHang
    {
        public int STT { get; set; }
        public string SoCT { get; set; }
        public string MaHang { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public string DienGiai { get; set; }
    }
}

