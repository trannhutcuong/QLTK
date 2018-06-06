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
    /// Interaction logic for TonDauKySanPham.xaml
    /// </summary>
    public partial class TonDauKySanPham : Window
    {
        private tonDauKy TonKy;
        private List<TonSanPham> listTonSanPham;
        public TonDauKySanPham(tonDauKy tonKy)
        {
            InitializeComponent();
            tbTenTon.Text = tonKy.TenKy;
            TonKy = tonKy;
            NapDanhSachSanPhamTheoKy();
        }

        private void NapDanhSachSanPhamTheoKy()
        {
            listTonSanPham = new List<TonSanPham>();
            List<HANGHOA> listHangDB = Database.QUERY.LayBangHangHoa();
            int len = listHangDB.Count;

            for (int i = 0; i < len; ++i)
            {
                int soLuongTon = Database.QUERY.LaySoLuongTonTheoNgay(TonKy.NgayBatDau, DateTime.Now, listHangDB[i].MAHANG);
                int tien = soLuongTon * (int)listHangDB[i].GIA;
                listTonSanPham.Add(new TonSanPham()
                {
                    STT = i + 1,
                    MaHang = listHangDB[i].MAHANG,
                    TenHang = listHangDB[i].TENHANG,
                    SoLuongTon = soLuongTon,
                    Tien = tien
                });
            }
            lvSanPhamTheoKy.ItemsSource = listTonSanPham;
        }

    }

    public class TonSanPham
    {
        public int STT { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuongTon { get; set; }
        public int Tien { get; set; }
    }
}

