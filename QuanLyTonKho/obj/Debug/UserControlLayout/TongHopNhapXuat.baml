   M S B A M L   `   `   `  ����G  CQuanLyTonKho, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:QuanLyTonKho.UserControlLayoutQuanLyTonKho.UserControlLayout  5      4    .QuanLyTonKho.UserControlLayout.TongHopNhapXuat   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:QuanLyTonKho.UserControlLayout     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      #��� ��5        MaterialDesignFont#���  5      .��5      �� .+�5   
   �� $��80��6   .+�5      �� $��2��6   ���	#FF24F19D69   � 5      $��80��6    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��70��6$   $��Center=�6/   $��	100,0,0,0q�6J   Từ ngày:6g   �� 5      
����+��$��40��6:   $	��220��6F    �� CornerRadius$ 5��6R   $��1q�6c   $��10,0,0,0q�6w   ._�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datePicker��5   )   $��30��6=   $	��180��6I   $��10,2,0,5q�6U   $��Arial)�6g   $��18(�6z   $��0q�6�   6�   5      5       5!      � 5#      $��1��6   .+�5$      �� $ 
Horizontal=�6!   .+�5%      �� $��Center=�6$   $��20,0,0,0q�6?   Đến ngày:6\   �� 5&      
����+��$��40��6:   $	��220��6F   $ 5��6R   $��1q�6c   $��10,0,0,0q�6w   ._�5'        -   5        $ datePicker2��5'   )   $��30��6>   $	��180��6J   $��10,2,0,5q�6V   $��Arial)�6h   $��18(�6{   $��0q�6�   6�   5(      �� 5*      -   5         & "MaterialDesignToolForegroundButton#���  5*   !   $��20,0,0,0q�5+   !   .��5,      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Send=�66   5-      5.      5/      50      51      �� 53   
   $ 
Horizontal=�6   $	��450��6.   .+�54      �� 
����+��$	��800��6.   $��1q�55      $��80,10,10,10q�6%   ._�56      �� -   5         ��Name$ lvTongHopNhapXuat��56       �� View 57      �� 58      .P�59      �� $	��STT��6-   	 �� Width$		 100��6_   
 �� DisplayMemberBinding
 6:   �� *STT+6m   �� 5:      $��	Mã hàng��6-   $		 150��6f   
 6>   �� *MaHang+6t   �� 5;      $��Tồn đầu��6-   $		 150��6f   
 6>   �� *TonDau+6t   �� 5<      $��Nhập��6-   $		 130��6a   
 6;   �� *Nhap+6o   �� 5=      $��Xuất��6-   $		 130��6a   
 6;   �� *Xuat+6o   �� 5>      $��Tồn cuối��6-   $		 150��6h   
 6?   �� *	TonCuoi+6v   5?      5A      5B      5C      5D      5E      