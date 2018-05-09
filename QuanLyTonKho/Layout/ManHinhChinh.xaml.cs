using QuanLyTonKho.UserControlLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyTonKho.Layout
{
    /// <summary>
    /// Interaction logic for ManHinhChinh.xaml
    /// </summary>
    public partial class ManHinhChinh : Window
    {
        

        public ManHinhChinh()
        {
            InitializeComponent();
            textNgay.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString().Substring(0, 10);
            SearchItem search = new SearchItem(1);
            DanhMucHangHoa danhMuc = new DanhMucHangHoa();
            TuyChonTimKiem.Children.Add(search);
            MainView.Children.Add(danhMuc);
            TieuDe.Text = "Danh mục hàng hóa";

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ListViewMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ListViewMenu.Visibility = Visibility.Hidden;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();
            TuyChonTimKiem.Children.Clear();
            MainView.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name) {
                case "ItemHangHoa":
                    SearchItem search1 = new SearchItem(1);
                    DanhMucHangHoa danhMucHang = new DanhMucHangHoa();
                    TuyChonTimKiem.Children.Add(search1);
                    MainView.Children.Add(danhMucHang);
                    GridMain.Children.Add(TuyChonTimKiem);
                    GridMain.Children.Add(MainView);
                    TieuDe.Text = "Danh mục hàng hóa";
                    break;
                case "ItemKhachHang":
                    SearchItem search2 = new SearchItem(2);
                    DanhMucKhachHang danhMucKhach = new DanhMucKhachHang();
                    TuyChonTimKiem.Children.Add(search2);
                    MainView.Children.Add(danhMucKhach);
                    GridMain.Children.Add(TuyChonTimKiem);
                    GridMain.Children.Add(MainView);
                    TieuDe.Text = "Danh mục khách hàng";
                    break;
                case "ItemCuaHang":
                    SearchItem search3 = new SearchItem(3);
                    DanhMucCuaHang danhMucCuaHang = new DanhMucCuaHang();
                    TuyChonTimKiem.Children.Add(search3);
                    MainView.Children.Add(danhMucCuaHang);
                    GridMain.Children.Add(TuyChonTimKiem);
                    GridMain.Children.Add(MainView);
                    TieuDe.Text = "Danh mục cửa hàng";
                    break;
                case "ItemTonDauKy":
                    TonDauKy tonDauKy = new TonDauKy();
                    GridMain.Children.Add(tonDauKy);
                    TieuDe.Text = "Tồn đầu kỳ";
                    break;
                case "ItemNhapXuatHang":
                    PhieuNhapXuatHang phieuNhapXuat = new PhieuNhapXuatHang();
                    GridMain.Children.Add(phieuNhapXuat);
                    TieuDe.Text = "Phiếu nhập, xuất hàng";
                    break;
                case "ItemXuatKho":
                    PhieuXuatKho phieuXuatKho = new PhieuXuatKho();
                    GridMain.Children.Add(phieuXuatKho);
                    TieuDe.Text = "Phiếu xuất kho";
                    break;
                case "ItemTongNhapXuat":
                    TongHopNhapXuat tongHop = new TongHopNhapXuat();
                    GridMain.Children.Add(tongHop);
                    TieuDe.Text = "Tổng hợp nhập xuất";
                    break;
                case "ItemBangKeNhapXuat":
                    BangKeNhapXuat bangKeNhapXuat = new BangKeNhapXuat();
                    GridMain.Children.Add(bangKeNhapXuat);
                    TieuDe.Text = "Bảng kê nhập, xuất hàng";
                    break;
                case "ItemThongKe":
                    ThongKeMatHang thongKe = new ThongKeMatHang();
                    GridMain.Children.Add(thongKe);
                    TieuDe.Text = "Thống kê mặt hàng";
                    break;
                default:
                    break;
            }
        }
    }
}
