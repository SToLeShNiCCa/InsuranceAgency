   M S B A M L   `   `   `  ����I  EКурасач, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Курасач.ViewКурасач.View  5   	   .    (Курасач.View.EditPolicyTypeWondow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Курасач.View     5   	   -   5        $��EditPolicyTypeWnd��5   	     � Title$+  %Страховое агентство��5	   	   $	��465��6%   $	��800��62    � 
ResizeMode$ NoResize=�5
   	    � Icon$_ YD:\проекты\Курасач\Курасач\img and icons for main window\3327068.png��6    � 	Resources 5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property!  System.Windows.SystemColors   WindowBrushKey �� Value	   ControlTextBrushKey-  'System.Windows.Input.KeyboardNavigation
 �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value)   "InactiveSelectionHighlightBrushKey  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonTemplate1 ��Name   HighlightBrushKey��%�
  &	        &	 #     &	 F     &	 i     7   7  7  &	 �    &	 �    &	 �    &	     &	 A    &		 d    &	
 �    &	 �    7  7  7  7  7  7 	 7 
 �� 5   
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
   $ 	#FFBEE6FD��6>   �� 59   
   $ 	#FF3C7FB1��6:   �� 5:   
   $ 	#FFC4E5F6��6<   �� 5;   
   $ 	#FF2C628B��68   �� 5<   
   $ 	#FFF4F4F4��6=   �� 5=   
   $ 	#FFADB2B5��69   �� 5>   
   $ 	#FF838383��6=   �� 5?   
   "
 ��62   .R�5@      �� $ border��6   #��z��6%   #��z��6O   #��z��6{   $
 true��6�   $ 10,10,10,10��6�   ._�5A      �� $ contentPresenter��6#   $|�False��6=   #��z��6O   #��z��6�   $
��True��6�   # z 6�   #��z��6  5B       5C      P� 5D       �@��IsDefaulted$
 true��68   . �5E      �� $ border��64   # �  6H    � ��5F      P� 5G       �@J�IsMouseOver$
 true��61   . �5H      �� $ border��63   8    � ��6G   �� 5I      $ border��64   8   � ��6H   5J      P� 5K       � ��$
 true��6/   . �5L      �� $ border��63   8   � ��6G   �� 5M      $ border��64   8   � ��6H   5N      P� 5O       � {�$ false��6/   . �5P      �� $ border��63   8   � ��6G   �� 5Q      $ border��64   8   � ��6H   �� 5R      $ contentPresenter��6?   8   � ��6]   5S      5U      5V      .��5W      � ���	#FFEEEEEE.+�5X   
   �� $
��Left=�6   $	��270��6/   $��116,118,0,0q�6<   $	��Top=�6Q   $	��563��6i   
������� �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   �� 5Y   
   #���  6o     ButtonStyle1#���  6�   $
��Left=�6�   $��464,328,0,0q�6�   $	��Top=�6�   $��Bahnschrift SemiLight)�6  ���	#FF023EFA$��2,2,2,2q�6F  $	��170��6`  $��45��6l  
�������$��Изменить��6�  $��14(�6�  ��6   �� *EditPolicyType+��64   ��  �� ElementName$ EditPolicyTypeWnd��6�  �� 5Z   
   $
��Left=�6   $��449,135,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $��Название��6{   �� 5[   
   $��Описание��6   $
��Left=�6#   $��134,130,0,0q�6>   $	��Top=�6S   $��Bahnschrift SemiLight)�6k   �� 5\   
   $
��Left=�6   $��449,197,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $��Базовая цена��6{   �� 5]   
   $
��Left=�6   $��
151,39,0,0q�6+   $	��Top=�6?   $A��;Окно редактирования типа полиса��6W   $��Comic Sans MS)�6�   $��22(�6�   �� 5^   
   $
��Left=�6   $��50��6+   $��
530,39,0,0q�67   $	��Top=�6K   $��50��6c   $\��VD:\проекты\Курасач\Курасач\img and icons for main window\icon.png��6n   �� 5_   
   -   5        $��EditPolicyTypeNameBlock��5_      #���  6R   $
��Left=�6z   $��449,155,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   $��5,0,0,0q�6�   $��Center=�6   $��2,2,2,2q�6"  ���	#FF023EFA$��Bahnschrift SemiLight)�6T  ��61   �� *PolicyTypeName+6T  �� 5`   
   -   5        $$��EditPolicyTypeDescriptionBlock��5`      $
��Left=�6`   $��134,151,0,0q�6{   $
 Wrap=�6�   $	��Top=�6�   $	��300��6�   $	��222��6�   $��5,0,0,0q�6�   $��2,2,2,2q�6�   $��Bahnschrift SemiLight)�6  ���	#FF023EFA#���  6<  ��68   �� *PolicyTypeDescription+6<  �� 5a   
   -   5        $"��EditPolicyTypeBasePriceBlock��5a      $
��Left=�6\   $��449,217,0,0q�6w   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   $��5,0,0,0q�6�   $��Center=�6�   $��2,2,2,2q�6  $��Bahnschrift SemiLight)�6  ���	#FF023EFA#���  6Y  ��66   �� *PolicyTypeBasePrice+6Y  5b      5c      