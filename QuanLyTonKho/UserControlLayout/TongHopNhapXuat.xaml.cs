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
    /// Interaction logic for TongHopNhapXuat.xaml
    /// </summary>
    public partial class TongHopNhapXuat : UserControl
    {
        public List<TongNhapXuat> listNhapXuat;

        public TongHopNhapXuat()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            Button_Click(sender, e);
        }
    }

    public class TongNhapXuat
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public int TonDau { get; set; }
        public int Nhap { get; set; }
        public int Xuat { get; set; }
        public int TonCuoi { get; set; }
    }

}
