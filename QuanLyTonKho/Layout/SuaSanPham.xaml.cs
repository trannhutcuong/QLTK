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
    /// Interaction logic for SuaSanPham.xaml
    /// </summary>
    public partial class SuaSanPham : Window
    {
        private HangHoa hangHoa;
        public SuaSanPham(HangHoa hang)
        {
            InitializeComponent();
            hangHoa = hang;
            tbMa.Text = hangHoa.MaHang;
            tbTen.Text = hangHoa.TenHang;
            tbGia.Text = hangHoa.Gia.ToString();
            datePicker.Text = hangHoa.NgayNhap.ToString();
            tbSoLuong.Text = hangHoa.SoLuong.ToString();
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            // Cập nhật sảm phẩm xuống database
            if(tbTen.Text != hangHoa.TenHang || tbGia.Text != hangHoa.Gia.ToString() ||
               datePicker.ToString() != hangHoa.NgayNhap.ToString() || tbSoLuong.Text != hangHoa.SoLuong.ToString())
            {
                HangHoa hangSua = new HangHoa();
                hangSua.MaHang = hangHoa.MaHang;
                hangSua.TenHang = tbTen.Text;
                hangSua.Gia = Int32.Parse(tbGia.Text);
                hangSua.NgayNhap = datePicker.SelectedDate.Value;
                hangSua.SoLuong = Int32.Parse(tbSoLuong.Text);

                Database.UPDATE.CapNhatHangHoa(hangSua);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
      
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
