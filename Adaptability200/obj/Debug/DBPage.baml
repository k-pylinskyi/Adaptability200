   M S B A M L   `   `   `  ����J  FAdaptability200, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Adaptability200Adaptability200  5          Adaptability200.DBPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Adaptability200     5        N� Title$  DBPage��5	      .��5      � ���#CCE5FF � RowDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   �� 5      $��4* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��2* �6   .+�5   
   �� $��Пароль��6   $��0��6!   $��Center=�6.   $��Center=�6K   ���#004085$
��Bold"�6{   $��25(�6�   G� 5   
   -   5         G�Name$ PassBox��5      $��0��6'   $��1��64   ���	#FFE7F3FF$
��Bold"�6[   $��10q�6m   $��Center=�6y   $��Center=�6�   �� 5   
   -   5         ��Name$ PasswordButton��5      $��Підтвердити��6)   $��2��6?   $��0��6O   ���#28A745$��Center=�6r   $��Center=�6�   $��25(�6�   $
��Bold"�6�   
�������$��5q�6�   6�   �� 5   
   $��Прізвище��6   $��1��6#   $��Center=�60   $��Center=�6M   ���#004085$
��Bold"�6}   $��25(�6�   �� 5   
   -   5         ��Name$ FindByNameBox��5      $��1��6)   $��1��69   $��Center=�6F   $��Center=�6j   ���#004085���	#FFE7F3FF$��10q�5   $   $
��Bold"�60   �� 5   
   -   5        $ FindByNameButton��5      $��Знайти��6+   $��2��6<   $��1��6L   ���#28A745$��Center=�6o   $��Center=�6�   $��25(�6�   $
��Bold"�6�   
�������$��5q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BaseGrid��5         AutoGenerateColumns . 
�������   RowBackground
 �����	   AlternatingRowBackground
	 ��ح�
�������$��5q�6�   $��1��6�   $��2��6�   $��3��6�   �� 5!   
   -   5        $ UpdateButton��5!      $%��Оновити сторінку��6'   $��0��6B   $��4��6R   $��3��6_   $��Center=�6s   $��Center=�6�   $��25(�6�   
����������#28A745$
��Bold"�6�   6  5"      5#      