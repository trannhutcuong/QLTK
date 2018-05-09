using QuanLyTonKho.UserControlLayout;
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
using System.Windows.Shapes;

namespace QuanLyTonKho.Layout
{
    /// <summary>
    /// Interaction logic for ThemKhachHang.xaml
    /// </summary>
    public partial class ThemKhachHang : Window
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            // Thêm khách hàng xuống database
            if (tbMa.Text != "" && tbTen.Text != "" && tbSDT.Text != "" && tbDiaChi.Text != "")
            {
                if (Database.QUERY.KiemTraMaKhachHang(tbMa.Text) == false)
                {
                    KhachHang khachHang = new KhachHang();
                    khachHang.MaKhachHang = tbMa.Text;
                    khachHang.TenKhachHang = tbTen.Text;
                    khachHang.SDT = tbSDT.Text;
                    khachHang.DiaChi = tbDiaChi.Text;
                    Database.INSERT.ThemKhachHang(khachHang);

                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã tồn tại mã khách hàng này", "Thông báo");
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
            
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Thêm khách hàng xuống database
            MessageBox.Show("Thêm thành công", "Thông báo");
        }
    }
}
