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
    /// Interaction logic for ThemSanPham.xaml
    /// </summary>
    public partial class ThemSanPham : Window
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            // Thêm sảm phẩm xuống database
            if (tbMa.Text != "" && tbTen.Text != "" && tbGia.Text != "" &&
                tbKho.Text != "" && tbNgay.Text != "" && tbSoLuong.Text != "")
            {
                if (Database.QUERY.KiemTraMaHang(tbMa.Text) == false)
                {
                    if (Database.QUERY.KiemTraMaKho(tbKho.Text))
                    {
                        HangHoa hang = new HangHoa();
                        hang.MaHang = tbMa.Text;
                        hang.TenHang = tbTen.Text;
                        hang.Gia = Int32.Parse(tbGia.Text);
                        hang.KhoChua = tbKho.Text;
                        hang.NgayNhap = tbNgay.SelectedDate.Value;
                        hang.SoLuong = Int32.Parse(tbSoLuong.Text);

                        Database.INSERT.ThemHangHoa(hang);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Mã kho không tồn tại", "Thông báo");
                }
                else MessageBox.Show("Đã tồn tại mã hàng này", "Thông báo");
            }
            else
                MessageBox.Show("Hãy nhập đủ thông tin sản phẩm", "Thôn báo");
            
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Thêm sảm phẩm xuống database
           if(e.Key == Key.Enter)
                MessageBox.Show("Thêm thành công", "Thông báo");
        }
    }
}
