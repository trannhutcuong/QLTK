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
    /// Interaction logic for SearchItem.xaml
    /// </summary>
    public partial class SearchItem : UserControl
    {
        private int LoaiManHinh;

        public SearchItem(int loaiManHinh)
        {
            InitializeComponent();
            LoaiManHinh = loaiManHinh;
        }

        private void Button_Tim_Click(object sender, RoutedEventArgs e)
        {
            string ThongTinTim = lbTimKiem.Text;
            if (LoaiManHinh == 1)
            {
                DanhMucHangHoa danhMuc = new DanhMucHangHoa();

                int dem = 0;
                for (int i = 0; i < danhMuc.listHangHoa.Count; ++i)
                {
                    if (ThongTinTim.ToLower() == danhMuc.listHangHoa[i].MaHang.ToLower())
                    {
                        SuaSanPham thongTin = new SuaSanPham(danhMuc.listHangHoa[i]);
                        thongTin.Show();
                    }
                    else dem++;
                }
                if (dem == danhMuc.listHangHoa.Count)
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
            }
            else if(LoaiManHinh == 2)
            {
                DanhMucKhachHang danhMuc = new DanhMucKhachHang();

                int dem = 0;
                for (int i = 0; i < danhMuc.listKhachHang.Count; ++i)
                {
                    if (ThongTinTim.ToLower() == danhMuc.listKhachHang[i].MaKhachHang.ToLower())
                    {
                        SuaKhachHang thongTin = new SuaKhachHang(danhMuc.listKhachHang[i]);
                        thongTin.Show();
                    }
                    else dem++;
                }
                if (dem == danhMuc.listKhachHang.Count)
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
            }
            else if(LoaiManHinh == 3)
            {
                DanhMucCuaHang danhMuc = new DanhMucCuaHang();

                int dem = 0;
                for (int i = 0; i < danhMuc.listKho.Count; ++i)
                {
                    if (ThongTinTim.ToLower() == danhMuc.listKho[i].MaKho.ToLower())
                    {
                        SuaKho thongTin = new SuaKho(danhMuc.listKho[i]);
                        thongTin.Show();
                    }
                    else dem++;
                }
                if (dem == danhMuc.listKho.Count)
                    MessageBox.Show("Không tìm thấy kho", "Thông báo");
            }
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                Button_Tim_Click(sender, e);
        }
    }
}
