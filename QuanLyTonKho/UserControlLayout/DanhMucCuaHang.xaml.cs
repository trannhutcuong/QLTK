using QuanLyTonKho.Database;
using QuanLyTonKho.Layout;
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
    /// Interaction logic for DanhMucCuaHang.xaml
    /// </summary>
    public partial class DanhMucCuaHang : UserControl
    {
        public List<Kho> listKho;

        public DanhMucCuaHang()
        {
            InitializeComponent();

            NapDuLieuCuaHang();
            
        }

        private void NapDuLieuCuaHang()
        {
            listKho = new List<Kho>();
            List<KHO> listKhoDB = Database.QUERY.LayBangKho();
            int SoLuong = listKhoDB.Count;

            for(int i = 0; i < SoLuong; ++i)
            {
                listKho.Add(new Kho()
                {
                    STT = i + 1,
                    MaKho = listKhoDB[i].MAKHO,
                    TenKho = listKhoDB[i].TENKHO
                });
            }
            lvDanhMucCuaHang.ItemsSource = listKho;
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            // Thêm kho xuống database
            ThemKho them = new ThemKho();
            them.Show();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Xóa kho khỏi database
            
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            Kho kho = lvDanhMucCuaHang.SelectedItem as Kho;
            if (kho != null)
            {
                SuaKho sua = new SuaKho(kho);
                sua.Show();
            }
            else
                MessageBox.Show("Hãy chọn kho cần cập nhật", "Thông báo");
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {
            string ThongTinTim = lbTimKiem.Text;
            int dem = 0;
            for (int i = 0; i < listKho.Count; ++i)
            {
                if (ThongTinTim.ToLower() == listKho[i].MaKho.ToLower())
                {
                    SuaKho thongTin = new SuaKho(listKho[i]);
                    thongTin.Show();
                }
                else dem++;
            }
            if (dem == listKho.Count)
                MessageBox.Show("Không tìm thấy kho", "Thông báo");
        }

        private void lbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Button_Tim_Click(sender, e);
        }
    }

    public class Kho
    {
        public int STT { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int SoLuongSanPham { get; set; }
    }
}
