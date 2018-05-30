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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyTonKho.UserControlLayout
{
    /// <summary>
    /// Interaction logic for PhieuNhapXuatHang.xaml
    /// </summary>
    public partial class PhieuNhapXuatHang : UserControl
    {
        public PhieuNhapXuatHang()
        {
            InitializeComponent();
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PHIEUHANG phieuHang = new PHIEUHANG();

            if (datePicker.Text != "" && tbSoCT.Text != "" && tbMaKhach.Text != "" && tbDienGiai.Text != ""
                && tbMaHang.Text != "" && tbSoLuong.Text != "")
            {
                phieuHang.NGAY = datePicker.SelectedDate.Value;
                phieuHang.SOCHUNGTU = tbSoCT.Text;
                phieuHang.MAKHACHHANG = tbMaKhach.Text;
                phieuHang.DIENGIAI = tbDienGiai.Text;
                phieuHang.MAHANG = tbMaHang.Text;
                if (cbbTuyChon.Text != "")
                {
                    if (cbbTuyChon.Text == "Phiếu nhập hàng")
                    {
                        phieuHang.LOAIPHIEU = 1;   // Nhập
                        phieuHang.SOLUONG = Int32.Parse(tbSoLuong.Text);
                    }
                    else if (cbbTuyChon.Text == "Phiếu xuất hàng")
                    {
                        phieuHang.LOAIPHIEU = 2;   // Xuất
                        phieuHang.SOLUONG = -Int32.Parse(tbSoLuong.Text);
                    }
                        

                    // Kiểm tra dữ liệu nhập
                    if (QUERY.KiemTraSoChungTu(phieuHang.SOCHUNGTU))
                        MessageBox.Show("Số chứng từ đã tồn tại", "Thông báo");
                    else if (QUERY.KiemTraMaKhachHang(phieuHang.MAKHACHHANG) == false)
                        MessageBox.Show("Không tồn tại mã khách hàng", "Thông báo");
                    else if (QUERY.KiemTraMaHang(phieuHang.MAHANG) == false)
                        MessageBox.Show("Không tồn tại mã hàng", "Thông báo");
                    else if (QUERY.KiemTraMaKho(phieuHang.MAKHO) == false)
                        MessageBox.Show("Không tồn tại mã kho", "Thông báo");
                    else   // Thêm phiếu hàng
                    {
                        INSERT.ThemPhieuHang(phieuHang);
                        UPDATE.SuaSoLuongSanPham(phieuHang.MAHANG, (int)phieuHang.SOLUONG);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Chưa chọn loại phiếu", "Thông báo");
            }
            else
                MessageBox.Show("Hãy nhập đủ thông tin phiếu", "Thông báo");
            


        }
    }
}
