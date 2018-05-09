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
    /// Interaction logic for SuaKho.xaml
    /// </summary>
    public partial class SuaKho : Window
    {
        private Kho kho;

        public SuaKho(Kho kho2)
        {
            InitializeComponent();

            kho = kho2;
            tbMa.Text = kho.MaKho;
            tbTen.Text = kho.TenKho;
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            if(tbTen.Text != kho.TenKho)
            {
                Kho khoSua = new Kho();
                khoSua.MaKho = kho.MaKho;
                khoSua.TenKho = tbTen.Text;

                Database.UPDATE.CapNhatKho(khoSua);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                MessageBox.Show("Cập nhật thành công", "Thông báo");
        }
    }
}
