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

namespace QuanLyTonKho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_DanhMucHangHoa(object sender, RoutedEventArgs e)
        {
            //DanhMucHangHoa danhMucHangHoa = new DanhMucHangHoa();
            //danhMucHangHoa.Show();
        }

        private void Button_DanhMucKhachHang(object sender, RoutedEventArgs e)
        {
            //DanhMucKhachHang danhMucKhachHang = new DanhMucKhachHang();
            //danhMucKhachHang.Show();
        }

        private void Button_DangNhap(object sender, RoutedEventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Close();
            dangNhap.Show();
        }
    }
}
