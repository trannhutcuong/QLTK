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
    /// Interaction logic for ThemKy.xaml
    /// </summary>
    public partial class ThemKy : Window
    {
        public ThemKy()
        {
            InitializeComponent();
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            if(tbMa.Text != "" && tbTen.Text != "" && datePicker1.Text != "" && datePicker2.Text != "")
            {
                if (Database.QUERY.KiemTraMaKy(tbMa.Text))
                {
                    MessageBox.Show("Mã kỳ đã tồn tại", "Thông báo");
                }
                else
                {
                    TONKY tonKy = new TONKY();
                    tonKy.MAKY = tbMa.Text;
                    tonKy.TENKY = tbTen.Text;
                    tonKy.NGAYBATDAU = datePicker1.SelectedDate.Value;
                    tonKy.NGAYKETTHUC = datePicker2.SelectedDate.Value;
                    Database.INSERT.ThemTonDauKy(tonKy);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo");
            }
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
