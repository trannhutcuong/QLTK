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
            DanhMucHangHoa danhMuc = new DanhMucHangHoa();
            GridMain.Children.Add(danhMuc);
            TieuDe.Text = "Danh mục hàng hóa";

        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();
            
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name) {
                case "ItemHangHoa":
                    DanhMucHangHoa danhMucHang = new DanhMucHangHoa();
                    GridMain.Children.Add(danhMucHang);
                    TieuDe.Text = "Danh mục hàng hóa";
                    break;
                case "ItemKhachHang":
                    DanhMucKhachHang danhMucKhach = new DanhMucKhachHang();
                    GridMain.Children.Add(danhMucKhach);
                    TieuDe.Text = "Danh mục khách hàng";
                    break;
                case "ItemCuaHang":
                    DanhMucCuaHang danhMucCuaHang = new DanhMucCuaHang();
                    GridMain.Children.Add(danhMucCuaHang);
                    TieuDe.Text = "Danh mục cửa hàng";
                    break;
                case "ItemTonDauKy":
                    TonDauKy tonDauKy = new TonDauKy();
                    GridMain.Children.Add(tonDauKy);
                    TieuDe.Text = "Tồn đầu kỳ";
                    break;
                case "ItemNhapHang":
                    PhieuNhapHang phieuNhap = new PhieuNhapHang();
                    GridMain.Children.Add(phieuNhap);
                    TieuDe.Text = "Phiếu nhập hàng";
                    break;
                case "ItemXuatHang":
                    PhieuXuatHang phieuXuat = new PhieuXuatHang();
                    GridMain.Children.Add(phieuXuat);
                    TieuDe.Text = "Phiếu xuất hàng";
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
