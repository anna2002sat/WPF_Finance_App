   M S B A M L   `   `   `  ����G  CHomeExpenses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HomeExpenses.ViewsHomeExpenses.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      '    !HomeExpenses.Views.StatisticsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:HomeExpenses.Views     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      .��5      �   � ColumnDefinitions  5   
   �� 5      �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��0��6   $��Choose year:��6-   $��
10 10 5 10q�6D   $��Times New Roman)�6X   $��18(�6u   $��DemiBold"�6�   $��Right=�6�   $��Center=�6�   �� 5   
   $��1��6\   $
��Left=�6l   $��Stretch=�6�   $��
0 10 20 10q�6�   $	��150��5      $��Times New Roman)�6   $��DemiBold"�6<   $��17(�6S   
���������5      �� *
YearBalans+ �� SelectedItem 66   �� *SelectedYear+5   a   �� 5   
   $��0��6   $��2��6   $��Choose month:��6-   $��
10 10 5 10q�6E   $��Times New Roman)�6Y   $��18(�6v   $��DemiBold"�6�   $��Right=�6�   $��Center=�6�   �� 5   
   $��3��6�   $
��Left=�6�   $��Stretch=�6�   $��
0 10 20 10q�6�   $	��150��5      $��Times New Roman)�6   $��DemiBold"�6<   $��17(�6S   
���������5      �� *DatesAxexXOrderByDescending+ �� SelectedIndex 6G   �� *SelectedMonthIndex+ �� Mode$ TwoWay=�5   a   #  LiveCharts.Wpf.CartesianChart  5   
   $��1��6   $��0��6*   $��2��6:   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6N      Series 5!        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series   Title$ Debit��6!      Values 6/   �� *DebitMonthlyValues+  5"      $ Credit��6!    60   �� *CreditMonthlyValues+	   AxisX	 5%        LiveCharts.Wpf.Axis  
   Title$
 Months��6      Labels 6*   �� *
DatesAxexX+   	Separator 5&        LiveCharts.Wpf.Separator  5'         Step$ 1Q�6(   5)         AxisY 5,        $

 Cost��6      MinValue$ 0Q�6(   5.        LiveCharts.Wpf.PieChart  50   
   -   5        $��Chart��50      $ Right=�51      $��1��6.   $��2��6;   $��2��6K    50   %   �� *SeriesCollection+   ChartLegend 52      "  LiveCharts.Wpf.DefaultLegend  53         
BulletSize$ 20Q�6$   66      DataTooltip 55      #	  LiveCharts.Wpf.DefaultTooltip	  56       	  
BulletSize$ 20Q�6%   67   58      5:      5;      