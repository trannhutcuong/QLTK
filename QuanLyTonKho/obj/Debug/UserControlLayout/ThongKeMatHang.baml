   M S B A M L   `   `   `  ����G  CQuanLyTonKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:QuanLyTonKho.UserControlLayoutQuanLyTonKho.UserControlLayout  5      3    -QuanLyTonKho.UserControlLayout.ThongKeMatHang   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:QuanLyTonKho.UserControlLayout     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      #��� ��5        MaterialDesignFont#���  5      .��5      �� .+�5   
   �� $��80��6   .+�5      �� $��2��6   ���	#FF24F19D69   � 5      $��80��6    � ColumnDefinitions 5      �� 5      $	��400 �6'   65   �� 5      6)   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��70��6$   $��Center=�6/   $��	100,0,0,0q�6J   Từ ngày:6g   �� 5      
����+��$��40��6:   $	��200��6F    �� CornerRadius$ 5��6R   $��1q�6c   $��10,0,0,0q�6w   ._�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datePicker��5   )   $��30��6=   $	��180��6I   $��10,2,0,5q�6U   $��Arial)�6g   $��18(�6z   $��0q�6�   6�   5      5       5!      � 5#      $��1��6   .+�5$      �� $ 
Horizontal=�6!   .+�5%      �� $��Center=�6$   $��10,0,0,0q�6?   Đến ngày:6\   �� 5&      
����+��$��40��6:   $	��200��6F   $ 5��6R   $��1q�6c   $��10,0,0,0q�6w   ._�5'        -   5        $ datePicker2��5'   )   $��30��6>   $	��180��6J   $��10,2,0,5q�6V   $��Arial)�6h   $��18(�6{   $��0q�6�   6�   5(      �� 5*      
����+��$��40��6:   $	��150��6F   $ 5��6R   $��1q�6c   $��30,0,0,0q�6w   ._�5+      �� -   5         ��Name$ 	cbThongKe��5+   '   $��0q�6:   $��10,2,5,5q�6N   #��["�5,   '   .@�5-   "   �� .��6/   Bán chạy69   �� 5.   "   .��6/   Doanh thu cao6>   �� 5/   "   .��6/   Bán chậm69   50      51      �� 53      -   5         & "MaterialDesignToolForegroundButton#���  53   !   $��15,0,0,0q�54   !   .��55      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Send=�66   56      57      58      59      5:      �� 5<   
   $ 
Horizontal=�6   $	��450��6.   .+�5=      �� 
����+��$	��880��6.   $��1q�5>      $��80,10,10,10q�6%   ._�5?      �� -   5         ��Name$ 	lvThongKe��5?      	 �� View	 5@      �� 5A      .P�5B      �� $	��STT��6-   
 �� Width$	
 150��6_    �� DisplayMemberBinding 6:   �� *STT+6m   �� 5C      $��	Mã hàng��6-   $	
 200��6f    6>   �� *MaHang+6t   �� 5D      $��Số lượng bán��6-   $	
 200��6o    6C   �� *
SoLuongBan+6}   �� 5E      $��	Doanh thu��6-   $	
 200��6j    6@   �� *
DoanhThu+6x   5F      5H      5I      5J      5K      5L      