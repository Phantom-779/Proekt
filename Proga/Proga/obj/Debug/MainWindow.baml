   M S B A M L   `   `   `  ����@  <Proga, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ProgaProga  5   	       Proga.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.51.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Proga     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   $	��450��65   $	��800��6E   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $	��30* �6   .+�5   
     ScottPlot.WpfPlot  -   5        $��Chart��5      $��1��6   $��3��6/   {�.  6@   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	DateStart��5      $��Center=�6&   $��39,12,100,0q�6C   $��1��6X   $	��Top=�6e      SelectedDateFormat$ Short=�6}     5   
   -   5        $��DateEnd��5      $��Center=�6$   $��39,52,100,0q�6A   $��1��6V   $	��Top=�6c   $ Short=�6{   �� 5   
   $
��От��6   $
��Left=�6   $��	10,10,0,0q�68   $��1��6K   $	��Top=�6X    J� RenderTransformOrigin$ 	-1.042,-1&�6p   �� 5   
   $
��До��6   $
��Left=�6   $��9,51,0,0q�68   $��1��6J   $	��Top=�6W   �� 5   
   $)��#Построение графика��6   $��Center=�6-   $��Center=�6J   $��14(�6e   $
��Bold"�6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DataGrid1��5      $��1��6&   $��0,82,0,0q�63   6G   5      5      