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
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Button_DangNhap(object sender, RoutedEventArgs e)
        {
            ManHinhChinh main = new ManHinhChinh();
            this.Close();
            main.Show();
        }

        private void Button_Thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Enter_down(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                ManHinhChinh main = new ManHinhChinh();
                this.Close();
                main.Show();
            }
        }
    }
}
