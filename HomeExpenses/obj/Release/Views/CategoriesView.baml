   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  G CHomeExpenses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HomeExpenses.ModelsHomeExpenses.Models '   !HomeExpenses.Views.CategoriesView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6sys&clr-namespace:System;assembly=mscorlib     /m!clr-namespace:HomeExpenses.Models     ^ ZCaliburn.Micro.Platform, Version=3.0.3.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  
������   � 	Resources     EnumDataProvider S� 
MethodName S� 
ObjectType   System.Enum S� MethodParameters M� TypeName��%B   &	        S� $ 	GetValues��"   M� $ m:CategoryType��.���  � ColumnDefinitions �� $	��200���� $	��150���� $	��150��$��* � � RowDefinitions �� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ 
Categories��$��0��$��3��   CanUserResizeColumns .  	   CanUserReorderColumns	 .  $��1��$��0,10,0,0q�$��16(�
   ColumnHeaderHeight$
 40Q�$��Times New Roman)�   AutoGenerateColumns .     CanUserAddRows .  
������ 
������    RowBackground �	#00000000 �� SelectedItem �� *SelectedCategory+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��   MinWidth$	 120Q�   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$
 Name�4  .System.Windows.Controls.DataGridComboBoxColumn  $
 Type�� . $ 80Q�   ItemsSource ��  �� Source# [     SelectedItemBinding �� *Type+  $ Description��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *  .  �� $ Description�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� 	  Caliburn.Micro.Message 	  Attach$9 3[Event Click] = [Action EditCategory($dataContext)]��
������ $��40��$��0q�
������ .���� .+��� $%��/Images/icons-edit-property.png��$��40��$��25��   �� $, &[Event Click] = [Action AddCategory()]��
�������$��Right=�$��30��$��0 0 0 0q�$��30��
�������.���� .+��� $��/Images/icons-plus.png��$��60��$��25�� �� .R��� $; 5[Event Click] = [Action DeleteCategory($dataContext)]��$��40��
������ 
������ .���� .+��� $��/Images/icons-delete.png��$��40��$��25��   ColumnHeaderStyle ��  �� 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 .���  �� Property � �� �� Value$
 Bold"���  � ��$ Center=�