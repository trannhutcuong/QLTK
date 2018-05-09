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
    /// Interaction logic for PhieuXuatKho.xaml
    /// </summary>
    public partial class PhieuXuatKho : UserControl
    {
        public PhieuXuatKho()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PHIEUXUATKHO xuatKhoDB = new PHIEUXUATKHO();
            if (datePicker.Text != "" && tbSoCT.Text != "" && tbMaHang.Text != ""
                && tbDienGiai.Text != "" && tbMaKhoNhan.Text != "")
            {
                xuatKhoDB.NGAY = datePicker.SelectedDate.Value;
                xuatKhoDB.SOCHUNGTU = tbSoCT.Text;
                xuatKhoDB.MAHANG = tbMaHang.Text;
                xuatKhoDB.DIENGIAI = tbDienGiai.Text;
                tbMaKhoXuat.Text = QUERY.LayMaKhoTuHang(tbMaHang.Text);
                xuatKhoDB.MAKHOXUAT = tbMaKhoXuat.Text;
                xuatKhoDB.MAKHONHAP = tbMaKhoNhan.Text;

                if (QUERY.KiemTraSoChungTukho(tbSoCT.Text))
                    MessageBox.Show("Số chứng từ đã tồn tại", "Thông báo");
                else if (QUERY.KiemTraMaHang(tbMaHang.Text) == false)
                    MessageBox.Show("Không tồn tại mã khách hàng", "Thông báo");
                else if(QUERY.KiemTraMaKho(tbMaKhoXuat.Text) == false)
                    MessageBox.Show("Không tồn tại mã kho xuất", "Thông báo");
                else if (QUERY.KiemTraMaKho(tbMaKhoNhan.Text) == false)
                    MessageBox.Show("Không tồn tại mã kho nhận", "Thông báo");
                else
                {
                    INSERT.ThemPhieuXuatKho(xuatKhoDB);
                    UPDATE.SuaKhoSanPham(xuatKhoDB.MAHANG, xuatKhoDB.MAKHONHAP);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
            }
            else
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo");
        }

        private void tbMaHang_MouseLeave(object sender, MouseEventArgs e)
        {
            tbMaKhoXuat.Text = QUERY.LayMaKhoTuHang(tbMaHang.Text);
        }
    }
}
