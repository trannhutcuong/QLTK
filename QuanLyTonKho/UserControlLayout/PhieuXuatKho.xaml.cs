using QuanLyTonKho.Database;
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
    /// Interaction logic for PhieuXuatKho.xaml
    /// </summary>
    public partial class PhieuXuatKho : UserControl
    {
        public PhieuXuatKho()
        {
            InitializeComponent();
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tbMaHang_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }
    }
}
