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
    /// Interaction logic for SuaKhachHang.xaml
    /// </summary>
    public partial class SuaKhachHang : Window
    {
        private KhachHang khachHang;

        public SuaKhachHang(KhachHang khachhang)
        {
            InitializeComponent();
            khachHang = khachhang;

            tbMa.Text = khachHang.MaKhachHang;
            tbTen.Text = khachHang.TenKhachHang;
            tbSDT.Text = khachHang.SDT;
            tbDiaChi.Text = khachHang.DiaChi;
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            // Sửa khách hàng vào database
            if(tbTen.Text != khachHang.TenKhachHang || tbSDT.Text != khachHang.SDT || tbDiaChi.Text != khachHang.DiaChi)
            {
                KhachHang KHMoi = new KhachHang();
                KHMoi.MaKhachHang = tbMa.Text;
                KHMoi.TenKhachHang = tbTen.Text;
                KHMoi.SDT = tbSDT.Text;
                KHMoi.DiaChi = tbDiaChi.Text;

                Database.UPDATE.CapNhatKhachHang(KHMoi);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Sửa khách hàng vào database
        }
    }
}
