   M S B A M L   `   `   `  ����I  EКурасач, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Курасач.ViewКурасач.View  5   	   2    ,Курасач.View.EditInsuranceClaimWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Курасач.View     5   	   -   5        $��EditInsuranceClaimWnd��5   	     � Title$+  %Страховое агентство��5	   	   $	��465��6%   $	��800��62    � 
ResizeMode$ NoResize=�5
   	    � Icon$_ YD:\проекты\Курасач\Курасач\img and icons for main window\3327068.png��6    � 	Resources 5         TextBox.MouseOver.Border �� Color  TextBox.Focus.Border  TextBoxTemplate1 �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value  TextBox.Static.Border  TextBox.MouseOver.Border1  TextBox.Focus.Border1  TextBoxStyle1 �� 
TargetType!  System.Windows.SystemColors   WindowBrushKey   ControlTextBrushKey-  'System.Windows.Input.KeyboardNavigation �� Triggers ]� 
Conditions �� Property �� Value)   "InactiveSelectionHighlightBrushKey  FocusVisual �� StrokeDashArray  Button.Static.Background 	 Button.Static.Border 
 Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1 ��Name   HighlightBrushKey��%N  &	        &	 #     &	 F     7   7  &	 �    &	 �    &	 �    &	     7  7  7  &	 W    &	 
	    &		 -	    &	
 P	    &	 s	    &	 �	    &	 �	    &	 �	    &	 �	    &	 "
    &	 E
    7  7  7 	 7 
 7  7  7  7  7  7  �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��63   .R�5      �� $ border��6   #��z��6%   #��z��6O   #��z��6{   $
 True��6�   $ 5,5,5,5��6�   ._�5      �� $	 PART_ContentHost��6   $|�false��69   $��Hidden=�6K   $��Hidden=�6r   5      
 5      P� 5       � {�$ false��6/   . �5      �� $ border��60    �@J�Opacity$
 0.56Q�6D   5      P� 5       �@J�IsMouseOver$
 true��61   . �5      �� $ border��64   8    � ��6H   5      P� 5       �@J�IsKeyboardFocused$
 true��67   . �5      �� $ border��64   8   � ��6H   5      5      �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6<   �� 5    
   $ 	#FF569DE5��68   �� 5!   
   " ��6&   .�5"      ��  � ��# �  6+   �� 5#       � ��8   6,   �� 5$       � ��# �  6+   �� 5%       � ��$ 1q�60   �� 5&       �@ TabNavigation$
 None=�6A   �� 5'       � ��$
 Left=�6;   �� 5(       �@�FocusVisualStyle 61   Z� �� 5)       �@J�	AllowDrop$
 true��6*   �� 5*       �@��PanningMode$ VerticalFirst=�69   �� 5+       �@��IsFlicksEnabled$ False��67   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 True��6�   $ 5,5,5,5��6�   ._�50      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   51      
 52      P� 53       � {�$ false��6;   . �54   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   55      P� 56       �@J�IsMouseOver$
 true��6=   . �57   "   �� $ border��6@   8   � ��6T   58      P� 59       �@J�IsKeyboardFocused$
 true��6C   . �5:   "   �� $ border��6@   8   � ��6T   5;      5=      5?       5@      ]� 5A       5B      �� 5C      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 5D       �@��IsSelectionActive$ false��6A   ./�5F      ��  �@��SelectionBrush# �  67   5G      5I      �� 5J   
   .�5K      ��  � �� 5L      �� 5M      .R�5N      �� $��2q�6$   $	 1 2R�6/   #���  6E   $
 true��6�   $��1��6�   5O      5Q      5R      �� 5S   
   $ 	#FFDDDDDD��6;   �� 5T   
   $ 	#FF707070��67   �� 5U   
   $ 	#FFBEE6FD��6>   �� 5V   
   $ 	#FF3C7FB1��6:   �� 5W   
   $ 	#FFC4E5F6��6<   �� 5X   
   $ 	#FF2C628B��68   �� 5Y   
   $ 	#FFF4F4F4��6=   �� 5Z   
   $ 	#FFADB2B5��69   �� 5[   
   $ 	#FF838383��6=   �� 5\   
   " ��6%   .�5]      ��  �@�FocusVisualStyle8   61   �� 5^       � ��8  6+   �� 5_       � ��8  6,   �� 5`       � ��# �  6+   �� 5a       � ��$ 1q�60   �� 5b       � ��$ Center=�6;   �� 5c       � ��$ Center=�69   �� 5d       � ��$ 1q�6(   �� 5e       � �� 5f      �� 5g      " ��6&   .R�5h      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   $ 10,10,10,10��6�   ._�5i      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5j      
 5k      P� 5l       �@��IsDefaulted$
 true��6=   . �5m   "   �� $ border��6@   # �  6T    � ��5n      P� 5o       �@J�IsMouseOver$
 true��6=   . �5p   "   �� $ border��6?   8   � ��6S   �� 5q   "   $ border��6@   8   � ��6T   5r      P� 5s       � ��$
 true��6;   . �5t   "   �� $ border��6?   8   � ��6S   �� 5u   "   $ border��6@   8   � ��6T   5v      P� 5w       � {�$ false��6;   . �5x   "   �� $ border��6?   8   � ��6S   �� 5y   "   $ border��6@   8   � ��6T   �� 5z   "   $ contentPresenter��6K   8 	  � ��6i   5{      5}      5      5�      5�      .��5�      � ���	#FFEEEEEE.+�5�   
   �� $
��Left=�6   $	��300��6/   $��116,111,0,0q�6<   $	��Top=�6Q   $	��563��6i   
������� �� RadiusX$ 10��6�    �� RadiusY$ 10��6�   �� 5�   
   $
��Left=�6   $��158,138,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $��Номер полиса��6{   �� 5�   
   $��Дата случая��6   $
��Left=�6&   $��158,207,0,0q�6A   $	��Top=�6V   $��Bahnschrift SemiLight)�6n   �� 5�   
   $
��Left=�6   $��425,138,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $#��Описание случая��6{   �� 5�   
   $
��Left=�6   $��158,273,0,0q�6+   $	��Top=�6@   $��Bahnschrift SemiLight)�6X   $%��Статус погашения��6{   �� 5�   
   $
��Left=�6   $��
138,51,0,0q�6+   $	��Top=�6?   $M��GОкно Редактирования страхового случая��6W   $��Comic Sans MS)�6�   $��22(�6�   �� 5�   
   $
��Left=�6   $��50��6+   $��
583,46,0,0q�67   $	��Top=�6K   $��50��6c   $\��VD:\проекты\Курасач\Курасач\img and icons for main window\icon.png��6n   �� 5�   
   -   5        $%��EditInsuranceClaimPolicyIdBlock��5�      #���  6b   $
��Left=�6�   $��158,159,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   $��2,2,2,2q�6�   $��Center=�6  $��5,0,0,0q�6:  ���	#FF023EFA$��Bahnschrift SemiLight)�6d  ��69   �� *InsuranceClaimPolicyId+6d  �� 5�   
   -   5        $(��"EditInsuranceClaimDescriptionBlock��5�      $
��Left=�6h   $��425,159,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��240��6�   $	��240��6�   $��5,5,5,5q�6�   $��2,2,2,2q�6�   ���	#FF023EFA#���  6!  $��Bahnschrift SemiLight)�6I  ��6<   �� *InsuranceClaimDescription+6I  �� 5�   
   -   5        $(��"EditInsuranceClaimClaimStatusBlock��5�      $
��Left=�6h   $��158,294,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��40��6�   $��5,0,0,0q�6�   $��Center=�6�   $��2,2,2,2q�6  ���	#FF023EFA#���  6B  $��Bahnschrift SemiLight)�6j  ��6<   �� *InsuranceClaimClaimStatus+6j  �� 5�   
   #���  6w   $
��Left=�6�   $��173,354,0,0q�6�   $	��Top=�6�   $��Bahnschrift SemiLight)�6�   $��14(�6	  ���	#FF023EFA
�������$��Изменить��6B  $	��170��6U  $��45��6a  $��2,2,2,2q�6m  ��6   �� *EditInsuranceClaim+��68   ��  �� ElementName$ EditInsuranceClaimWnd��6m  (  "System.Windows.Controls.DatePicker  5�   
   -   5        $��EditAgentHireDateBlock��5�      $
��Left=�6g   $��158,225,0,0q�6�   $	��Top=�6�   $��40��6�   $	��200��6�   ���	#FF023EFA$��2,2,2,2q�6�      SelectedDate 63   �� *InsuranceClaimIncidentDate+6�   5�      5�      