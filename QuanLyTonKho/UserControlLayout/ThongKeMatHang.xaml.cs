using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ThongKeMatHang.xaml
    /// </summary>
    public partial class ThongKeMatHang : UserControl
    {
        public ThongKeMatHang()
        {
            InitializeComponent();
            cbThongKe.SelectedIndex = 0;
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
            datePicker2.Text = DateTime.Now.ToString().Substring(0, 10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime NgayDau = datePicker.SelectedDate.Value;
            DateTime NgayCuoi = datePicker2.SelectedDate.Value;

            
            List<HANGHOA> listHangDB = Database.QUERY.LayBangHangHoa();
            List<thongKe> listThongKe = new List<thongKe>();
            int len = listHangDB.Count;

            for(int i = 0; i < len; ++i)
            {
                listThongKe.Add(new thongKe()
                {
                    STT = i + 1,
                    MaHang = listHangDB[i].MAHANG,
                    SoLuongBan = Database.QUERY.LayLuongXuatTheoNgay(NgayDau, NgayCuoi, listHangDB[i].MAHANG),
                    DoanhThu = Database.QUERY.LayLuongXuatTheoNgay(NgayDau, NgayCuoi, listHangDB[i].MAHANG) * Database.QUERY.LayGiaTuHang(listHangDB[i].MAHANG)
                });
            }
            lvThongKe.ItemsSource = listThongKe;
            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvThongKe.ItemsSource);
            if (cbThongKe.Text == "Bán chạy")
            {
                view.SortDescriptions.Add(new SortDescription("SoLuongBan", ListSortDirection.Descending));
            }
            else if(cbThongKe.Text == "Bán chậm")
            {
                view.SortDescriptions.Add(new SortDescription("SoLuongBan", ListSortDirection.Ascending));
            }
            else
            {
                view.SortDescriptions.Add(new SortDescription("DoanhThu", ListSortDirection.Descending));
            }
        }
    }
    public class thongKe
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public int SoLuongBan { get; set; }
        public int DoanhThu { get; set; }
    }
}
