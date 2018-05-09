using QuanLyTonKho.Database;
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
    /// Interaction logic for ThemKho.xaml
    /// </summary>
    public partial class ThemKho : Window
    {
        public ThemKho()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            // Thêm kho vào database
            if(tbMa.Text != "" && tbTen.Text != null)
            {
                if (QUERY.KiemTraMaKho(tbMa.Text) == false)
                {
                    Kho kho = new Kho();
                    kho.MaKho = tbMa.Text;
                    kho.TenKho = tbTen.Text;

                    Database.INSERT.ThemKho(kho);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Đã tồn tại mã kho", "Thông báo");
            }
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
