   M S B A M L   `   `   `  ����G  CHomeExpenses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HomeExpenses.ViewsHomeExpenses.Views  5   	   "    HomeExpenses.Views.ShellView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:HomeExpenses.Views     5   	     � Title$  Home Expenses��5   	   $	��600��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�69   $	��500��6^   $
��1000��6n    � Icon$ /Images/Main_Icon.png��5	   	   .��5
      � -   5         �Name$ MainGrid��5
      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF00FFD6��6    � Offset$ 1Q�61   � 5      $ 	#FF12C3FF��6   $ 0.139Q�61   � 5      $ 	#FF128BFF��6   5      	 � ColumnDefinitions	 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $	��240��6   �� 5      $	��240��6   �� 5      $	��240��6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6   
 � RowDefinitions
 5   
   �� 5      $��40 �6   $��70��6(   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $��* �6   �� 5'      $��10 �6   .+�5+   
   �� -   5         ��Name$ StatisticsPage��5+      $��0��6)   $��3��66   $��
Statistics��6F   
�������
���   �$��Cooper Black)�6�   $��26(�6�   �� 5,   
   -   5        $ TransactionPage��5,      $��0��6*   $��4��67   $��Transactions��6G   
�������$��Cooper Black)�6q   $��26(�6�   
���   �6�   �� 5-   
   -   5        $ CategoriesPage��5-      $��0��6)   $��5��66   $��
Categories��6F   $��Cooper Black)�6[   $��26(�6u   
�������
���   �
���   �6�   �� 50   
   -   5         ��Name$ 
ActiveItem��50   [   $��3��6   $��1��6&   $��7��66   $��6��6J   
���   �6o   52      53      