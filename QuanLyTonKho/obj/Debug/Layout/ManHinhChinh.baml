   M S B A M L   `   `   `  ����G  CQuanLyTonKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:QuanLyTonKho.LayoutQuanLyTonKho.Layout  5   	   O,clr-namespace:QuanLyTonKho.UserControlLayoutQuanLyTonKho.UserControlLayout  5   	   &     QuanLyTonKho.Layout.ManHinhChinh   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:QuanLyTonKho.Layout     5   	   ;uc,clr-namespace:QuanLyTonKho.UserControlLayout     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��18(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   #��� ��5   	     MaterialDesignFont#���  5   	    � Title$ Quản lý tồn kho��5   	   $	��700��6!   $
��1300��6.    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ 	CanResize=�5   	   .��5      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��250��6   ���	#FF6A98E8.+�5      �� $	��150��6   ���	#FF8909E2$��1q�6>   ._�5      � $��5q�6   .+�5      �� $��/Image/store.jpg��6    6<   5      5      �� 5      ���	#FF8909E2$��1q�61   ._�5      �� -   5         ��Name$ ListViewMenu��5      $��5q�65   $��Arial)�6@   $��15(�6S   .@�5!      �� -   5         ��Name$ ItemHangHoa��5!   '   $��60��6<   .��5"      �� $ 
Horizontal=�6)   .+�5#   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ ViewList=�6:   $��Center=�6J   �� 5$   "   $��Danh mục hàng hóa��6,   $
��Bold"�6E   $��Center=�6W   $
��20 5q�6r   5%      5&      �� 5(      -   5        $ ItemKhachHang��5(   '   $��60��6>   .��5)      �� $ 
Horizontal=�6)   .+�5*   "     $ AccountCardDetails=�6:   $��Center=�6T   �� 5+   "   $��Danh mục khách hàng��6,   $
��Bold"�6G   $��Center=�6Y   $
��20 5q�6t   5,      5-      �� 5/      -   5        $ ItemTonDauKy��5/   '   $��60��6=   .��50      �� $ 
Horizontal=�6)   .+�51   "     $ Restore=�6:   $��Center=�6I   �� 52   "   $��Tồn đầu kỳ��6,   $
��Bold"�6>   $��Center=�6P   $
��20 5q�6k   53      54      �� 57      -   5        $ ItemNhapHang��57   '   $��60��6=   .��58      �� $ 
Horizontal=�6)   .+�59   "     $ ArrowRightBoldBox=�6:   $��Center=�6S   �� 5:   "   $��Phiếu nhập hàng��6,   $
��Bold"�6C   $��Center=�6U   $
��20 5q�6p   5;      5<      �� 5>      -   5        $ ItemXuatHang��5>   '   $��60��6=   .��5?      �� $ 
Horizontal=�6)   .+�5@   "     $ ArrowLeftBoldBox=�6:   $��Center=�6R   �� 5A   "   $��Phiếu xuất hàng��6,   $
��Bold"�6C   $��Center=�6U   $
��20 5q�6p   5B      5D      �� 5F      -   5        $ ItemTongNhapXuat��5F   '   $��60��6A   .��5G      �� $ 
Horizontal=�6)   .+�5H   "     $ Elevator=�6:   $��Center=�6J   �� 5I   "   $ ��Tổng hợp nhập xuất��6,   $
��Bold"�6F   $��Center=�6X   $
��20 5q�6s   5J      5K      �� 5M      -   5        $ ItemBangKeNhapXuat��5M   '   $��60��6C   .��5N      �� $ 
Horizontal=�6)   .+�5O   "     $ 
TableLarge=�6:   $��Center=�6L   �� 5P   "   $%��Bảng kê nhập, xuất hàng��6,   $
��Bold"�6K   $��Center=�6]   $
��20 5q�6x   5Q      5R      �� 5T      -	   5        $ ItemThongKe��5T   '   $��60��6<   .��5U      �� $ 
Horizontal=�6)   .+�5V   "     $ Creation=�6:   $��Center=�6J   �� 5W   "   $��Thống kê mặt hàng��6,   $
��Bold"�6E   $��Center=�6W   $
��20 5q�6r   5X      5Y      5Z      5[      5\      �� 5^      $
��1050��6   .+�5`      �� $��70��6   ���	#FF1735B9.+�5a      �� $ 
Horizontal=�6!   .+�5b      � $	��950��6   .+�5c      �� -
   5        	 ��Name$	 TieuDe��5c   (   
 �� Padding$
 12q�68   
������� �� TextAlignment$ Center=�6X   $��30(�6o   $
��Bold"�6}   Danh mục hàng hóa6�   5d      � 5f      .+�5g      '  !MaterialDesignThemes.Wpf.PopupBox  
�������$��Right=�6I   $��0,0,10,0q�6e      PlacementMode$ BottomAndAlignRightEdges=�5h   *      PopupContent. 5i   "   �� .+�5j   &   �� .��6-   Đăng xuất68   �� 5k   &   .��6-   Thoát64   5l   #   5m      5n      5s      5t      � 5w      $	��600��6   
�������.+�5x      �� .+�5z      � $��60��6   .+�5{      �� -   5        $	 textNgay��5{   (   $��Center=�6:   $
��Left=�6U   $��
100,10,0,0q�5|   $   6;   �� 5}      $��Center=�6(   $��Right=�6C   $��Arial)�5~   $   $��20(�67   $��0,0,50,0q�6E   Tài khoản6b   5      � 5�      -   5         �Name$ GridMain��5�      $	��540��61   5�      5�      5�      5�      5�      5�      5�      