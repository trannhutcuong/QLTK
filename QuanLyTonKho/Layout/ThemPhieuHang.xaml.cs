using QuanLyTonKho.Database;
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
    /// Interaction logic for ThemPhieuHang.xaml
    /// </summary>
    public partial class ThemPhieuHang : Window
    {
        private int LoaiPhieu;
        public ThemPhieuHang(int loaiPhieu)
        {
            InitializeComponent();
            LoaiPhieu = loaiPhieu;
            if (loaiPhieu == 1)
                tbphieuHang.Text = "THÊM PHIẾU NHẬP HÀNG";
            else
                tbphieuHang.Text = "THÊM PHIẾU XUẤT HÀNG";
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
        }

        private void Button_Them_Click(object sender, RoutedEventArgs e)
        {
            PHIEUHANG phieuHang = new PHIEUHANG();
            if (tbMaHang.Text != "" && tbMaKhach.Text != "" && tbSoCT.Text != ""
                && tbSoLuong.Text != "" && tbDienGiai.Text != "" && datePicker.Text != "")
            {
                phieuHang.NGAY = datePicker.SelectedDate.Value;
                phieuHang.SOCHUNGTU = tbSoCT.Text;
                phieuHang.MAKHACHHANG = tbMaKhach.Text;
                phieuHang.DIENGIAI = tbDienGiai.Text;
                phieuHang.MAHANG = tbMaHang.Text;
                if (LoaiPhieu == 1)
                    phieuHang.SOLUONG = Int32.Parse(tbSoLuong.Text);
                else
                    phieuHang.SOLUONG = -Int32.Parse(tbSoLuong.Text);
                phieuHang.LOAIPHIEU = (byte)LoaiPhieu;

                // Kiểm tra dữ liệu nhập
                if (QUERY.KiemTraSoChungTu(phieuHang.SOCHUNGTU))
                    MessageBox.Show("Số chứng từ đã tồn tại", "Thông báo");
                else if (QUERY.KiemTraMaKhachHang(phieuHang.MAKHACHHANG) == false)
                    MessageBox.Show("Không tồn tại mã khách hàng", "Thông báo");
                else if (QUERY.KiemTraMaHang(phieuHang.MAHANG) == false)
                    MessageBox.Show("Không tồn tại mã hàng", "Thông báo");
                else   // Thêm phiếu hàng
                {
                    INSERT.ThemPhieuHang(phieuHang);
                    UPDATE.SuaSoLuongSanPham(phieuHang.MAHANG, (int)phieuHang.SOLUONG);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
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
