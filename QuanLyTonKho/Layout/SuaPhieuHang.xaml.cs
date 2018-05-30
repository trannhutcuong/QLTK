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
    /// Interaction logic for SuaPhieuHang.xaml
    /// </summary>
    public partial class SuaPhieuHang : Window
    {
        private int LoaiPhieu;
        public SuaPhieuHang(PhieuHang phieuHang, int loaiPhieu)
        {
            InitializeComponent();
            datePicker.Text = phieuHang.NgayNhap.ToString();
            tbSoCT.Text = phieuHang.SoCT;
            tbMaHang.Text = phieuHang.MaHang;
            tbMaKhach.Text = phieuHang.MaKH;
            tbDienGiai.Text = phieuHang.DienGiai;
            tbSoLuong.Text = phieuHang.SoLuong.ToString();
            LoaiPhieu = loaiPhieu;
        }

        private void Button_Sua_Click(object sender, RoutedEventArgs e)
        {
            if (tbMaHang.Text != "" && tbMaKhach.Text != "" && tbSoCT.Text != ""
                && tbSoLuong.Text != "" && tbDienGiai.Text != "" && datePicker.Text != "")
            {
                PhieuHang phieuHang = new PhieuHang();
                phieuHang.NgayNhap = datePicker.SelectedDate.Value;
                phieuHang.SoCT = tbSoCT.Text;
                phieuHang.MaHang = tbMaHang.Text;
                phieuHang.MaKH = tbMaKhach.Text;
                phieuHang.DienGiai = tbDienGiai.Text;
                if (LoaiPhieu == 1)
                {
                    phieuHang.SoLuong = Int32.Parse(tbSoLuong.Text);
                    Database.UPDATE.CapNhatPhieuHang(phieuHang, LoaiPhieu);
                }
                else
                {
                    phieuHang.SoLuong = -Int32.Parse(tbSoLuong.Text);
                    Database.UPDATE.CapNhatPhieuHang(phieuHang, LoaiPhieu);
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
        }

        private void Button_Huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
