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
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
            datePicker2.Text = DateTime.Now.ToString().Substring(0, 10); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<HANGHOA> listHangDB = Database.QUERY.LayBangHangHoa();
            List<TongNhapXuat> listTongNhapXuat = new List<TongNhapXuat>();
            int len = listHangDB.Count;

            for(int i = 0; i < len; ++i)
            {
                listTongNhapXuat.Add(new TongNhapXuat() {
                    STT = i+ 1,
                    MaHang = listHangDB[i].MAHANG,
                    TonDau = Database.QUERY.LaySoLuongTonTheoNgay(datePicker.SelectedDate.Value, DateTime.Now, listHangDB[i].MAHANG),
                    Nhap = Database.QUERY.LayLuongNhapTheoNgay(datePicker.SelectedDate.Value, datePicker2.SelectedDate.Value, listHangDB[i].MAHANG),
                    Xuat = Database.QUERY.LayLuongXuatTheoNgay(datePicker.SelectedDate.Value, datePicker2.SelectedDate.Value, listHangDB[i].MAHANG),
                    TonCuoi = Database.QUERY.LaySoLuongTonTheoNgay(datePicker2.SelectedDate.Value, DateTime.Now, listHangDB[i].MAHANG)
                });
            }
            lvTongHopNhapXuat.ItemsSource = listTongNhapXuat;
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            //Button_Click(sender, e);
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
