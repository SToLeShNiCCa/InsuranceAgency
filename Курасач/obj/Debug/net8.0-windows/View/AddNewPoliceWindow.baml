   M S B A M L   `   `   `  ����I  EКурасач, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Курасач.ViewКурасач.View  5   	   ,    &Курасач.View.AddNewPoliceWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Курасач.View     5   	   -   5        $��AddNewPoliceWnd��5   	     � Title$+  %Страховое агентство��5	   	   $	��465��6%   $	��800��62    � 
ResizeMode$ NoResize=�5
   	    � Icon$_ YD:\проекты\Курасач\Курасач\img and icons for main window\3327068.png��6    � 	Resources 5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property!  System.Windows.SystemColors   WindowBrushKey �� Value	   ControlTextBrushKey-  'System.Windows.Input.KeyboardNavigation
 �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value)   "InactiveSelectionHighlightBrushKey  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1 ��Name   HighlightBrushKey��%�  &	        &	 #     &	 F     &	 i     7   7  7  &	 �    &	 h    &	 �    &	 �    &	 �    &		 �    &	
     &	 :    &	 ]    &	 �    &	 �    7  7  7  7  7  7 	 7 
 7  7  7  �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6&   .�5      ��  � ��# �  6+   �� 5       � ��8   6,   �� 5       � ��# � 	 6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 True��6�   $ 5,5,5,5��6�   ._�5      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5       5       P� 5!       � {�$ false��6;   . �5"   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5#      P� 5$       �@J�IsMouseOver$
 true��6=   . �5%   "   �� $ border��6@   8   � ��6T   5&      P� 5'       �@J�IsKeyboardFocused$
 true��6C   . �5(   "   �� $ border��6@   8   � ��6T   5)      5+      5-       5.      ]� 5/       50      �� 51      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 52       �@��IsSelectionActive$ false��6A   ./�54      ��  �@��SelectionBrush# �  67   55      57      �� 58   
   .�59      ��  � �� 5:      �� 5;      .R�5<      �� $��2q�6$   $	 1 2R�6/   #��� 	 6E   $
 true��6�   $��1��6�   5=      5?      5@      �� 5A   
   $ 	#FFDDDDDD��6;   �� 5B   
   $ 	#FF707070��67   �� 5C   
   $ 	#FFBEE6FD��6>   �� 5D   
   $ 	#FF3C7FB1��6:   �� 5E   
   $ 	#FFC4E5F6��6<   �� 5F   
   $ 	#FF2C628B��68   �� 5G   
   $ 	#FFF4F4F4��6=   �� 5H   
   $ 	#FFADB2B5��69   �� 5I   
   $ 	#FF838383��6=   �� 5J   
   " ��6%   .�5K      ��  �@�FocusVisualStyle8   61   �� 5L       � ��8  6+   �� 5M       � ��8  6,   �� 5N       � ��# � 	 6+   �� 5O       � ��$ 1q�60   �� 5P       � ��$ Center=�6;   �� 5Q       � ��$ Center=�69   �� 5R       � ��$ 1q�6(   �� 5S       � �� 5T      �� 5U      "
 ��6&   .R�5V      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   $ 10,10,10,10��6�   ._�5W      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5X       5Y      P� 5Z       �@��IsDefaulted$
 true��6=   . �5[   "   �� $ border��6@   # �  6T    � ��5\      P� 5]       �@J�IsMouseOver$
 true��6=   . �5^   "   �� $ border��6?   8   � ��6S   �� 5_   "   $ border��6@   8   � ��6T   5`      P� 5a       � ��$
 true��6;   . �5b   "   �� $ border��6?   8   � ��6S   �� 5c   "   $ border��6@   8   � ��6T   5d      P� 5e       � {�$ false��6;   . �5f   "   �� $ border��6?   8   � ��6S   �� 5g   "   $ border��6@   8   � ��6T   �� 5h   "   $ contentPresenter��6K   8 	  � ��6i   5i      5k      5m      5n      5o      .��5p      � ���	#FFEEEEEE.+�5q   
   �� $
��Left=�6   $	��308��6/   $��	50,90,0,0q�6<   
�������$	��Top=�6^   $	��690��6v    �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   
�������6�   �� 5r   
   $
��Left=�6   $��
187,28,0,0q�6,   $	��Top=�6@   $?��9Окно регистрации нового полиса��6X   $��Comic Sans MS)�6�   $��22(�6�   �� 5s   
   $
��Left=�6   $��50��6+   $��
562,23,0,0q�67   $	��Top=�6K   $��50��6c   $\��VD:\проекты\Курасач\Курасач\img and icons for main window\icon.png��6n   �� 5t   
   $��Номер клиента��6   $
��Left=�6(   $��
62,101,0,0q�6C   $	��Top=�6W   $��Bahnschrift SemiLight)�6o   �� 5u   
   $��Тип полиса��6   $
��Left=�6%   $��
62,171,0,0q�6@   $	��Top=�6T   $��Bahnschrift SemiLight)�6l   �� 5v   
   $
��Left=�6   $��
62,242,0,0q�6+   $	��Top=�6?   $6��0Сумма страхового покрытия��6W   $��Bahnschrift SemiLight)�6{   �� 5w   
   $
��Left=�6   $��295,101,0,0q�6+   $	��Top=�6@   $��Премиум��6X   $��Bahnschrift SemiLight)�6j   �� 5x   
   $
��Left=�6   $��295,171,0,0q�6+   $	��Top=�6@   $��Дата начала��6X   $��Bahnschrift SemiLight)�6n   �� 5y   
   $
��Left=�6   $��526,101,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $��Статус��6{   �� 5z   
   $
��Left=�6   $��295,242,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $��Дата конца��6{   �� 5{   
   -   5        $��PolicyClientIdBlock��5{      #���  6N   $
��Left=�6v   $��
65,121,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   ���	#FF023EFA$��Bahnschrift SemiLight)�6  $��Center=�6$  $��5,0,0,0q�6F  $��2,2,2,2q�6X  ��6-   �� *PolicyClientId+6X  �� 5|   
   -   5        $��PolicyPolicyTypeBlock��5|   5   $��Bahnschrift SemiLight)�6   $
��Left=�6u   $��
65,192,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   ���	#FF023EFA$��5,0,0,0q�6   $��Center=�6  #���  64  $��2,2,2,2q�6\  ��6R   �� *PolicyPolicyType+6\  �� 5}   
   -   5        $��PolicyCoverageAmountBlock��5}      $
��Left=�6Z   $��
65,262,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   ���	#FF023EFA$��Bahnschrift SemiLight)�6�   $��5,0,0,0q�6  $��Center=�6  #���  6<  $��2,2,2,2q�6d  ��63   �� *PolicyCoverageAmount+6d  �� 5~   
   -   5        $��PolicyPremiumBlock��5~      $
��Left=�6L   $��295,121,0,0q�6g   $
 Wrap=�6|   $	��Top=�6�   $	��200��6�   $��40��6�   ���	#FF023EFA$��5,0,0,0q�6�   $��Center=�6�   #���  6  $��2,2,2,2q�64  ��6,   �� *PolicyPremium+64  �� 5   
   -   5        $��PolicyStatBlock��5      $
��Left=�6F   $��526,121,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��200��6�   $��40��6�   ���	#FF023EFA$��Bahnschrift SemiLight)�6�   $��5,0,0,0q�6�   $��Center=�6  #���  6)  $��2,2,2,2q�6Q  ��6)   �� *
PolicyStat+6Q  �� 5�   
   #���  6k   $��Center=�6�   $��	0,339,0,0q�6�   $	��Top=�6�   ���	#FF023EFA
�������$	��170��6  $��40��6  $��Bahnschrift SemiLight)�6  $��14(�6@  $��2,2,2,2q�6N  $��Добавить��6h  ��6   �� *AddNewPolicy+��62   ��  �� ElementName$ AddNewPoliceWnd��6h  (  "System.Windows.Controls.DatePicker  5�   
   -   5        $��StartDateBlock��5�      $
��Left=�6T   $��295,192,0,0q�6o   $	��Top=�6�   $��40��6�   $	��200��6�   ���	#FF023EFA$��2,2,2,2q�6�      SelectedDate 6+   �� *PolicyStartDate+6�     5�   
   -   5        $��EndDateBlock��5�      $
��Left=�6P   $��295,262,0,0q�6k   $	��Top=�6�   $��40��6�   $	��200��6�   ���	#FF023EFA$��2,2,2,2q�6�    6)   �� *PolicyEndDate+6�   5�      5�      