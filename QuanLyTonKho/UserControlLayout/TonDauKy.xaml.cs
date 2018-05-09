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
    /// Interaction logic for TonDauKy.xaml
    /// </summary>
    public partial class TonDauKy : UserControl
    {
        public TonDauKy()
        {
            InitializeComponent();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.Text != "")
            {
                List<tonDauKy> listTonDauKy = new List<tonDauKy>();
                DateTime ngay = datePicker.SelectedDate.Value;
                List<HANGHOA> listHang = Database.QUERY.LayBangHangHoa();
                int lenHang = listHang.Count;

                for(int i = 0; i < lenHang; ++i)
                {
                    listTonDauKy.Add(new tonDauKy()
                    {
                        STT = i + 1,
                        MaHang = listHang[i].MAHANG,
                        SoLuong = Database.QUERY.LaySoLuongTonTheoNgay(ngay, listHang[i].MAHANG),
                        Tien = Database.QUERY.LaySoLuongTonTheoNgay(ngay, listHang[i].MAHANG)* Database.QUERY.LayGiaTuHang(listHang[i].MAHANG)
                    });
                }
                lvDanhMucCuaHang.ItemsSource = listTonDauKy;
            }
            else
                MessageBox.Show("Hãy nhập ngày cần xem", "Thông báo");
        }
    }
    public class tonDauKy
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; } 
        public int Tien { get; set; }
    }
}
