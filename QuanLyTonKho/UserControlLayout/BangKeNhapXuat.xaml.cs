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
    /// Interaction logic for BangKeNhapXuat.xaml
    /// </summary>
    public partial class BangKeNhapXuat : UserControl
    {
        public BangKeNhapXuat()
        {
            InitializeComponent();
            cbLoaiBangKe.SelectedIndex = 0;
            datePicker.Text = DateTime.Now.ToString().Substring(0, 10);
            datePicker2.Text = DateTime.Now.ToString().Substring(0, 10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            if (datePicker.Text != "" && datePicker2.Text != "")
            {
                if(cbLoaiBangKe.Text == "Tất cả")
                {
                    LayTatCaPhieuHang();
                }
                else if(cbLoaiBangKe.Text == "Bảng kê nhập")
                {
                    LayPhieuNhap();
                }
                else
                {
                    LayPhieuXuat();
                }

            }
            else
                MessageBox.Show("Hãy nhập đủ thông tin ngày", "Thông báo");
        }

        private void LayTatCaPhieuHang()
        {
            List<PHIEUHANG> listPhieuHang = Database.QUERY.LayBangPhieuHang();
            List<bangKeNhapXuat> listKeNhapXuat = new List<bangKeNhapXuat>();
            DateTime NgayDau = datePicker.SelectedDate.Value;
            DateTime NgayCuoi = datePicker2.SelectedDate.Value;
            int len = listPhieuHang.Count;

            for (int i = 0; i < len; ++i)
            {
                if (listPhieuHang[i].NGAY >= NgayDau && listPhieuHang[i].NGAY < NgayCuoi)
                {
                    listKeNhapXuat.Add(new bangKeNhapXuat()
                    {
                        SoChungTu = listPhieuHang[i].SOCHUNGTU,
                        Ngay = (DateTime)listPhieuHang[i].NGAY,
                        MaHang = listPhieuHang[i].MAHANG,
                        MaKhachHang = listPhieuHang[i].MAKHACHHANG,
                        SoLuong = Math.Abs((int)listPhieuHang[i].SOLUONG),
                        Tien = Math.Abs(Database.QUERY.LayGiaTuHang(listPhieuHang[i].MAHANG) * (int)listPhieuHang[i].SOLUONG),
                        DienGiai = listPhieuHang[i].DIENGIAI
                    });

                }
            }
            lvBangKeNhapXuat.ItemsSource = listKeNhapXuat;
        }

        private void LayPhieuNhap()
        {
            List<PHIEUHANG> listPhieuHang = Database.QUERY.LayBangPhieuHang();
            List<bangKeNhapXuat> listKeNhapXuat = new List<bangKeNhapXuat>();
            DateTime NgayDau = datePicker.SelectedDate.Value;
            DateTime NgayCuoi = datePicker2.SelectedDate.Value;
            int len = listPhieuHang.Count;

            for (int i = 0; i < len; ++i)
            {
                if (listPhieuHang[i].LOAIPHIEU == 1)
                {
                    if (listPhieuHang[i].NGAY >= NgayDau && listPhieuHang[i].NGAY < NgayCuoi)
                    {
                        listKeNhapXuat.Add(new bangKeNhapXuat() {
                            SoChungTu = listPhieuHang[i].SOCHUNGTU,
                            Ngay = (DateTime)listPhieuHang[i].NGAY,
                            MaHang = listPhieuHang[i].MAHANG,
                            MaKhachHang = listPhieuHang[i].MAKHACHHANG,
                            SoLuong = Math.Abs((int)listPhieuHang[i].SOLUONG),
                            Tien = Math.Abs(Database.QUERY.LayGiaTuHang(listPhieuHang[i].MAHANG) * (int)listPhieuHang[i].SOLUONG),
                            DienGiai = listPhieuHang[i].DIENGIAI
                        });
                    }
                }
            }
            lvBangKeNhapXuat.ItemsSource = listKeNhapXuat;
        }
            
        

        private void LayPhieuXuat()
        {
            List<PHIEUHANG> listPhieuHang = Database.QUERY.LayBangPhieuHang();
            List<bangKeNhapXuat> listKeNhapXuat = new List<bangKeNhapXuat>();
            DateTime NgayDau = datePicker.SelectedDate.Value;
            DateTime NgayCuoi = datePicker2.SelectedDate.Value;
            int len = listPhieuHang.Count;

            for (int i = 0; i < len; ++i)
            {
                if (listPhieuHang[i].LOAIPHIEU == 2)
                {
                    if (listPhieuHang[i].NGAY >= NgayDau && listPhieuHang[i].NGAY < NgayCuoi)
                    {
                        listKeNhapXuat.Add(new bangKeNhapXuat()
                        {
                            SoChungTu = listPhieuHang[i].SOCHUNGTU,
                            Ngay = (DateTime)listPhieuHang[i].NGAY,
                            MaHang = listPhieuHang[i].MAHANG,
                            MaKhachHang = listPhieuHang[i].MAKHACHHANG,
                            SoLuong = Math.Abs((int)listPhieuHang[i].SOLUONG),
                            Tien = Math.Abs(Database.QUERY.LayGiaTuHang(listPhieuHang[i].MAHANG) * (int)listPhieuHang[i].SOLUONG),
                            DienGiai = listPhieuHang[i].DIENGIAI
                        });
                    }
                }
            }
            lvBangKeNhapXuat.ItemsSource = listKeNhapXuat;
        }

        private void cbLoaiBangKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
                
        }
    }

    public class bangKeNhapXuat
    {
        public string SoChungTu { get; set; }
        public DateTime Ngay { get; set; }
        public string MaHang { get; set; }
        public string MaKhachHang { get; set; }
        public int SoLuong { get; set; }
        public int Tien { get; set; }
        public string DienGiai { get; set; }
    }
}
