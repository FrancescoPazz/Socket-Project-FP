   M S B A M L   `   `   `  ����M  IProgetto_Socket_FP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Progetto_Socket_FPProgetto_Socket_FP  5   	   #    Progetto_Socket_FP.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Progetto_Socket_FP     5   	     � Title$  Progetto SOCKET��5   	   $	��600��6!   $	��800��6.    � 
ResizeMode$ 	CanResize=�6:   $��20(�6Q   .��5	      � ���	#FF50F5B2$��0,0,0,-2q�6"    � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ txtIP��5      $��0��6!   $��0��6.   $��40��6>   $	��150��6J   6z   �� 5   
   -   5        $ txtPort��5      $��0��6#   $��1��60   $��40��6@   $	��150��6M   6}   �� 5   
   $��IP��6   $��0��6   $��0��6*   $	��Top=�6:   $��Center=�6R   6q   �� 5   
   $
��PORT��6   $��0��6   $��1��6,   $	��Top=�6<   $��Center=�6T   6s   �� 5   
   -   5         ��Name$ btnCreateSocket��5      $��40��6*   $	��150��67   $��0��6C   $��2��6P   $��Create Socket��6`   {�.  6�   �� 5   
   $��Txt Message��6   $��1��6'   $��0��64   $	��Top=�6D   $��Center=�6\   6{   �� 5   
   -   5        $ 
txtMessage��5      $��1��6&   $��2��63   $��0��6D   $	��190��6T   $��Center=�6a   $��5q�6|   6�   �� 5   
   -   5        $ btnSend��5      $��40��6"   $	��150��6/   $��2��6;   $��0��6H   $��Send Message��6X   $��center=�6o   {�.  $��57,116,57,34q�6�   6�   �� 5   
   $��Label receive��6   $��1��6(   $��1��65   $��2��6E   $��Center=�6Y   $	��Top=�6v   6�   �� 5   
   -   5         ��Name$ 
tbkReceive��5      $��1��6(   $��1��65   $��2��6E   $��2��6Y    �� TextAlignment$ Justify=�6j   $��15,35,15,15q�6�   $��15(�6�   6�   5      5      