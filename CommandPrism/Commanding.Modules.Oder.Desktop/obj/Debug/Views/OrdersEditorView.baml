   M S B A M L   `   `   `  ����Z  VCommanding.Modules.Oder.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:Commanding.Modules.Oder.Desktop.ViewModels*Commanding.Modules.Oder.Desktop.ViewModels  5      e7clr-namespace:Commanding.Modules.Oder.Desktop.Converter)Commanding.Modules.Oder.Desktop.Converter  5      n jMicrosoft.Practices.Prism.Interactivity, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�fclr-namespace:Microsoft.Practices.Prism.Interactivity;assembly=Microsoft.Practices.Prism.Interactivity'Microsoft.Practices.Prism.Interactivity 5	      <    6Commanding.Modules.Oder.Desktop.Views.OrdersEditorView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Kmodels8clr-namespace:Commanding.Modules.Oder.Desktop.ViewModels     5      M	Converter7clr-namespace:Commanding.Modules.Oder.Desktop.Converter     5      Hi:http://schemas.microsoft.com/expression/2010/interactivity     5      xprismfclr-namespace:Microsoft.Practices.Prism.Interactivity;assembly=Microsoft.Practices.Prism.Interactivity     5	      $
��Auto��5      $
��Auto��6     � 	Resources  5         ErrorTemplate �� Padding �� CornerRadius=   7Commanding.Modules.Oder.Desktop.Converter.DateConverter  DateConverterI   CCommanding.Modules.Oder.Desktop.Converter.StringToNullableConverter  StringToNullableConverter>   8Commanding.Modules.Oder.Desktop.Converter.ErrorConverter  ErrorConverter  TextBoxInError �� 
TargetType-  'System.Windows.Input.KeyboardNavigation �� Property �� Value �� 
TargetType ��Name  WindowsBackgroundBrush  SolidBorderBrush ��Name  SimpleScrollViewer	 �� Triggers
 P� Property P� Value �� RelativeSource �� Path �� 	Converter �� DataType?   9Commanding.Modules.Oder.Desktop.ViewModels.OrderViewModel � RowDefinitions � ColumnDefinitions4  .System.Windows.Automation.AutomationProperties   AutomationId =� ErrorTemplate �� ValidatesOnExceptions �� ValidatesOnDataErrors �� NotifyOnValidationError �� 
IsReadOnly �� Mode��%w
  &	        &	 t     &	 �     &	 �     &	 �     7  (�� z    54      *, +)7   7  7  7   7  7  7   7  7  7  �� 5   
   .R�5      �� 
���  ��$��1q�6(   $ 2q�6<   $ 2��6H   ._�5      �� 5      5        5   
   6"     5   
   6.     5   
   6#   �� 5   
   " ��6'   .�5      ��  �@ TabNavigation$
 None=�6A   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��$ 0,5,0,5q�6'   �� 5       �@J�	AllowDrop . 6*   �� 5        � ��$
 Left=�6;   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      � .+�5%      �� $ Border��6%   #���  65   #���  6k   $��1q�6�   $ 2q�6�   $ 2��6�   ._�5&   "   �� $ PART_ContentHost��6:   $��0q�6/   #���  6T   #��z��6�   5(      5)      	 5*      P� 5+      
 �@=�HasError . . �5,   "   ��  6<   ��  �� *Self+$ (Validation.Errors)�8    �@�ToolTip6�   5-      5/      51      52      �� 54   
   "  6   .R�55      �  56      �� 57      �� 58      �� 59      �� 5:      �� 5;      �� 5<      �� 5=       5?      �� 5@      $	��100 �6'   �� 5A      $��* �6'   .+�5C      �� $ 	NameLabel��6   $��0��6F   $��0��6S   $��0,0,0,0q�6c   .��6t   Name6z   �� 5D      $ 	DateLabel��6   $��1��6F   $��0��6S   .��6c   Delivery Date6r   �� 5E      $ QuantityLabel��6   $��2��6J   $��0��6W   .��6g   
Quantity6q   �� 5F      $ 
PriceLabel��6   $��3��6G   $��0��6T   .��6d   Price6k   �� 5G      $ ShippingLabel��6   $��4��6J   $��0��6W   .��6g   
Shipping6q   �� 5H      $ 
TotalLabel��6   $��5��6G   $��0��6T   .��6d   Total6k   �� 5I      $ OrderNameLabel��6   $��6��6K   $��1��6X   $
��Left=�6�   $
��Bold"�6�   ��6h   �� *	OrderName+6�   �� 5K      $ DeliveryDateTextBox��6   $��1��6R   $��1��6_   8   8�� ��5L      �� *DeliveryDate+ .  .  . 8  5N      �� 5O      $ QuantityTextBox��6   $��2��6N   $��1��6[   8  8�� ��5P      �� *
Quantity+ .  .  . 8  5R      �� 5S      $ PriceTextBox��6   $��3��6K   $��1��6X   8  8�� ��5T      �� *Price+ .  .  . 8  5V      �� 5W      $ ShippingTextBox��6   $��4��6N   $��1��6[   ��5X      �� *
Shipping+8 	 �� 5Z      $ TotalTextbox��6   $��5��6K   $��1��6X    . ��5[      �� *Total+$ TwoWay=��� 5]      $ 
SaveButton��6   $��6��6H   $��1��6U   $
��Save��6e   ��5^      �� *SaveOrderCommand+5d      5e      5j      .��5m      � 5o      5p      