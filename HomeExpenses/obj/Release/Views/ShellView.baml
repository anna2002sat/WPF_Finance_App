   M S B A M L   `   `   `  ���� G  CHomeExpenses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HomeExpenses.ViewsHomeExpenses.Views  "    HomeExpenses.Views.ShellView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:HomeExpenses.Views     -     �Name$  	AppWindow��$��18(�$	��500��$
��1000�� � WindowStartupLocation$ CenterScreen=�$	��430��$	��800�� � Title$ Home ��.��� -    �Name$ MainGrid������  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF00FFD6�� � Offset$ 1Q�� $ 	#FF12C3FF��$ 0.139Q�� $ 	#FF128BFF��	 � ColumnDefinitions	 �� $��10 ��� $��* ��� $
��auto ��� $	��220���� $	��220���� $	��220���� $	��220���� $
��auto ��� $��* ��� $��10 �
 � RowDefinitions
 �� $��50 �$��70���� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��10 �.+��� -    ��Name$ StatisticsPage��$��0��$��3��$��
Statistics��
�������
���   �$��Cooper Black)�$��26(��� -   $ TransactionPage��$��0��$��4��$��Transactions��
�������$��Cooper Black)�$��26(�
���   ��� -   $ CategoriesPage��$��0��$��5��$��
Categories��$��Cooper Black)�$��26(�
�������
���   �
���   ��� -   $ 	AboutPage��$��0��$��6��$��About��$��Cooper Black)�$��26(�
�������
���   �
���   ��� -    ��Name$ 
ActiveItem��$��3��$��1��$��8��$��6��
���   �