   M S B A M L   `   `   `  ����F  BLoginSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LoginSystemLoginSystem  5   	       LoginSystem.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LoginSystem     5   	   -   5          � Title$  
MainWindow��5   	   $	��277��6   $	��525��6)    � 
ResizeMode$ CanMinimize=�65    � WindowStyle$
 None=�6N   
���   � � WindowStartupLocation$ CenterScreen=�6�   .��5	      � -   5        
���   �$��0,43,0,0q�5	   9    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ button��5      $��Login��6!   $��Center=�61   $��39��6N   $��223,191,220,0q�6Z   $	��Top=�6q   $��82��6�   
���   ����	#FF2EFF00$��Century Gothic)�6�   $��18.667(�6�   $
��Bold"�6�   
���   � � Cursor$
 Hand��6'  �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��26��6>   $��
185,39,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��158��6�   	 �� SelectionBrush
	 � � �6�   �� 5   
   -   5        
 ��Name$
 label��5      $��Username��6   $
��Left=�62   $��26��6M   $��	185,8,0,0q�6Y   $	��Top=�6l   $	��158��6�   ���	#FF17FF00$��Center=�6�   �� 5   
   -   5        $
 
label_Copy��5      $��Password��6$   $
��Left=�67   $��26��6R   $��
185,73,0,0q�6^   $	��Top=�6r   $	��158��6�   ���	#FF17FF00$��Center=�6�   �� 5   
   -   5        $ button1��5      $��X��6"   $
��Left=�6.   $��33��6I   $��492,-41,0,0q�6U   $	��Top=�6j   $��31��6�   
���   �
���   ����	#FF46FF00$��Aharoni)�6�   $��26.667(�6�   $
 Hand��6  G� 5   
   -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��
185,99,0,0q�6F   $	��Top=�6Z   $	��158��6r    G� SelectionBrush �	#FF51FF006~   �� 5   
   -	   5        $ button_Copy��5      $��Create account��6&   $��Center=�6?   $��17��6\   $��436,209,2,0q�6h   $	��Top=�6}   $��87��6�   
���   ����	#FF2EFF00$��Century Gothic)�6�   $��8(�6�   $
��Bold"�6�   
���   �$
 Hand��6/  5      5      