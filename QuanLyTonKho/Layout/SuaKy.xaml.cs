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
    /// Interaction logic for SuaKy.xaml
    /// </summary>
    public partial class SuaKy : Window
    {
        public SuaKy(tonDauKy tonKy)
        {
            InitializeComponent();
            tbMa.Text = tonKy.MaKy;
            tbTen.Text = tonKy.TenKy;
            datePicker1.Text = tonKy.NgayBatDau.ToString();
            datePicker2.Text = tonKy.NgayKetThuc.ToString();
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            if (tbTen.Text != "" && datePicker1.Text != "" && datePicker2.Text != "")
            {
                tonDauKy tonKy = new tonDauKy();
                tonKy.MaKy = tbMa.Text;
                tonKy.TenKy = tbTen.Text;
                tonKy.NgayBatDau = datePicker1.SelectedDate.Value;
                tonKy.NgayKetThuc = datePicker2.SelectedDate.Value;

                Database.UPDATE.CapNhatKy(tonKy);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Không được để thông tin trống", "Thông báo");
            }
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
