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
using QuanLyTonKho.Database;

namespace QuanLyTonKho.UserControlLayout
{
    /// <summary>
    /// Interaction logic for DanhMucHangHoa.xaml
    /// </summary>
    public partial class DanhMucHangHoa : UserControl
    {
        public List<HangHoa> listHangHoa;

        public DanhMucHangHoa()
        {
            InitializeComponent();
            NapDuLieuHangHoa();
        }

        private void NapDuLieuHangHoa()
        {
            listHangHoa = new List<HangHoa>();
            List<HANGHOA> listHangHoaDB = Database.QUERY.LayBangHangHoa();
            int SoLuong = listHangHoaDB.Count;
            for(int i = 0; i < SoLuong; ++i)
            {
                listHangHoa.Add(new HangHoa()
                {
                    STT = i + 1,
                    MaHang = listHangHoaDB[i].MAHANG,
                    TenHang = listHangHoaDB[i].TENHANG,
                    Gia = (int)listHangHoaDB[i].GIA,
                    NgayNhap = (DateTime)listHangHoaDB[i].NGAYNHAP,
                    SoLuong = (int)listHangHoaDB[i].SOLUONG
                });
            }
            lvDanhMucHangHoa.ItemsSource = listHangHoa;
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            ThemSanPham them = new ThemSanPham();
            them.ShowDialog();
            NapDuLieuHangHoa();
        }

        private void Button_Xoa_Click(object sender, RoutedEventArgs e)
        {
            // Xóa sản phẩm
            HangHoa hang = lvDanhMucHangHoa.SelectedItem as HangHoa;
            if (hang != null)
            {
                if (MessageBox.Show("Xóa khách hàng có mã " + hang.MaHang, "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    Database.DELETE.XoaHangHoa(hang);
                    NapDuLieuHangHoa();
                }
            }
            else
                MessageBox.Show("Hãy chọn sản phẩm cần xóa", "Thông báo");

            
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            HangHoa hang = lvDanhMucHangHoa.SelectedItem as HangHoa;
            if (hang != null)
            {
                SuaSanPham suaSP = new SuaSanPham(hang);
                suaSP.ShowDialog();
                NapDuLieuHangHoa();
            }
            else
                MessageBox.Show("Hãy chọn sản phẩm cần cập nhật", "Thông báo");
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {
            string ThongTinTim = lbTimKiem.Text;
            int dem = 0;
            for (int i = 0; i < listHangHoa.Count; ++i)
            {
                if (ThongTinTim.ToLower() == listHangHoa[i].MaHang.ToLower())
                {
                    SuaSanPham thongTin = new SuaSanPham(listHangHoa[i]);
                    thongTin.Show();
                }
                else dem++;
            }
            if (dem == listHangHoa.Count)
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Button_Tim_Click(sender, e);
        }
    }

    public class HangHoa
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int Gia { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; } 
    }
}
