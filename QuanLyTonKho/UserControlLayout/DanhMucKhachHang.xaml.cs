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
    /// Interaction logic for DanhMucKhachHang.xaml
    /// </summary>
    public partial class DanhMucKhachHang : UserControl
    {
        public List<KhachHang> listKhachHang;

        public DanhMucKhachHang()
        {
            InitializeComponent();
            NapDuLieuKhachHang();
        }

        private void NapDuLieuKhachHang()
        {
            listKhachHang = new List<KhachHang>();
            List<KHACHHANG> listKhachHangDB = Database.QUERY.LayBangKhachHang();
            int SoLuong = listKhachHangDB.Count;

            for(int i = 0; i < SoLuong; ++i)
            {
                listKhachHang.Add(new KhachHang()
                {
                    STT = i + 1,
                    MaKhachHang = listKhachHangDB[i].MAKHACHHANG,
                    TenKhachHang = listKhachHangDB[i].TENKHACHHANG,
                    SDT = listKhachHangDB[i].SODIENTHOAI,
                    DiaChi = listKhachHangDB[i].DIACHI
                });
            }
            lvDanhMucKhachHang.ItemsSource = listKhachHang;
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            ThemKhachHang them = new ThemKhachHang();
            them.ShowDialog();
            NapDuLieuKhachHang();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Xóa khách hàng
            KhachHang khachHang = lvDanhMucKhachHang.SelectedItem as KhachHang;
            if (khachHang != null)
            {
                if (MessageBox.Show("Xóa khách hàng có mã " + khachHang.MaKhachHang, "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    Database.DELETE.XoaKhachHang(khachHang);
                    NapDuLieuKhachHang();
                }
            }
            else
                MessageBox.Show("Hãy chọn khách hàng cần xóa", "Thông báo");

            
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            KhachHang khachHang = lvDanhMucKhachHang.SelectedItem as KhachHang;
            if(khachHang != null)
            {
                SuaKhachHang suaKH = new SuaKhachHang(khachHang);
                suaKH.ShowDialog();
                NapDuLieuKhachHang();
            }
            else
                MessageBox.Show("Hãy chọn khách hàng cần cập nhật", "Thông báo");
        }

        private void lbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Button_Tim_Click(sender, e);
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {
            string ThongTinTim = lbTimKiem.Text;
            int dem = 0;
            for (int i = 0; i < listKhachHang.Count; ++i)
            {
                if (ThongTinTim.ToLower() == listKhachHang[i].MaKhachHang.ToLower())
                {
                    SuaKhachHang thongTin = new SuaKhachHang(listKhachHang[i]);
                    thongTin.Show();
                }
                else dem++;
            }
            if (dem == listKhachHang.Count)
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo");
        }
    }

    public class KhachHang
    {
        public int STT { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    }
}
