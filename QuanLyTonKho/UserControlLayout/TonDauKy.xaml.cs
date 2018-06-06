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
    /// Interaction logic for TonDauKy.xaml
    /// </summary>
    public partial class TonDauKy : UserControl
    {
        private List<tonDauKy> listTonDauKy;
        public TonDauKy()
        {
            InitializeComponent();
            LayDanhSachTonKy();
        }

        void LayDanhSachTonKy()
        {
            listTonDauKy = new List<tonDauKy>();
            List<TONKY> listTonDB = Database.QUERY.LayTonDauKy();
            int len = listTonDB.Count;
            for(int i = 0; i < len; ++i)
            {
                listTonDauKy.Add(new tonDauKy()
                {
                    STT = i + 1,
                    MaKy = listTonDB[i].MAKY,
                    TenKy = listTonDB[i].TENKY,
                    NgayBatDau = (DateTime)listTonDB[i].NGAYBATDAU,
                    NgayKetThuc = (DateTime)listTonDB[i].NGAYKETTHUC
                });
            }
            lvTonDauKy.ItemsSource = listTonDauKy;
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            ThemKy themKy = new ThemKy();
            themKy.ShowDialog();
            LayDanhSachTonKy();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            tonDauKy tonKy = lvTonDauKy.SelectedItem as tonDauKy;
            if(tonKy != null)
            {
                if (MessageBox.Show("Xóa kỳ có mã " + tonKy.MaKy, "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    Database.DELETE.XoaKy(tonKy);
                    LayDanhSachTonKy();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn kỳ cần xóa", "Thông báo");
            }
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            tonDauKy tonKy = lvTonDauKy.SelectedItem as tonDauKy;
            if (tonKy != null)
            {
                SuaKy suaKy = new SuaKy(tonKy);
                suaKy.ShowDialog();
                LayDanhSachTonKy();
            }
            else
            {
                MessageBox.Show("Hãy chọn kỳ cần sửa", "Thông báo");
            }
        }

        private void lvTonDauKy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            tonDauKy tonKy = lvTonDauKy.SelectedItem as tonDauKy;
            TonDauKySanPham tonSanPham = new TonDauKySanPham(tonKy);
            tonSanPham.Show();
        }
    }
    public class tonDauKy
    {
        public int STT { get; set; }
        public string MaKy { get; set; }
        public string TenKy { get; set; }
        public DateTime NgayBatDau { get; set; } 
        public DateTime NgayKetThuc { get; set; }
    }
}
