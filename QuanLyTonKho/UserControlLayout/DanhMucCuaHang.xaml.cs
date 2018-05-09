using QuanLyTonKho.Database;
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
    /// Interaction logic for DanhMucCuaHang.xaml
    /// </summary>
    public partial class DanhMucCuaHang : UserControl
    {
        public List<Kho> listKho;

        public DanhMucCuaHang()
        {
            InitializeComponent();

            NapDuLieuCuaHang();
            
        }

        private void NapDuLieuCuaHang()
        {
            listKho = new List<Kho>();
            List<KHO> listKhoDB = Database.QUERY.LayBangKho();
            int SoLuong = listKhoDB.Count;

            for(int i = 0; i < SoLuong; ++i)
            {
                listKho.Add(new Kho()
                {
                    STT = i + 1,
                    MaKho = listKhoDB[i].MAKHO,
                    TenKho = listKhoDB[i].TENKHO,
                    SoLuongSanPham = QUERY.LaySoLuongSanPhamKho(listKhoDB[i].MAKHO)
                });
            }
            lvDanhMucCuaHang.ItemsSource = listKho;
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            // Thêm kho xuống database
            ThemKho them = new ThemKho();
            them.Show();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Xóa kho khỏi database
            Kho kho = lvDanhMucCuaHang.SelectedItem as Kho;
            if (kho != null)
            {
                if (QUERY.LaySoLuongSanPhamKho(kho.MaKho) == 0)
                {
                    if (MessageBox.Show("Xóa khách hàng có mã " + kho.MaKho, "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                    else
                    {
                        Database.DELETE.XoaKho(kho);
                        MessageBox.Show("Đã xóa kho có mã " + kho.MaKho, "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Không thể xóa kho có chứa sản phẩm", "Thông báo");

                
            }
            else
                MessageBox.Show("Hãy chọn kho cần xóa", "Thông báo");
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            Kho kho = lvDanhMucCuaHang.SelectedItem as Kho;
            if (kho != null)
            {
                SuaKho sua = new SuaKho(kho);
                sua.Show();
            }
            else
                MessageBox.Show("Hãy chọn kho cần cập nhật", "Thông báo");
        }
    }

    public class Kho
    {
        public int STT { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int SoLuongSanPham { get; set; }
    }
}
