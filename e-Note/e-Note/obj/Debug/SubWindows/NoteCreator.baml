   M S B A M L   `   `   `  ����A  =e-Note, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:e_Note.SubWindowse_Note.SubWindows  5   	   #    e_Note.SubWindows.NoteCreator   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:e_Note.SubWindows     5   	     � Title$  NoteCreator��5   	   $	��460��6   $	��800��6*   $	��698��5	   	   $	��460��6   .��5      � ��5   
   �� 5       �� ImageSource$. (/e-Note;component/SubWindows/bgphoto.png��6   .+�5   
   �� -   5         ��Name$ L_Cím��5      $��Cím:��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $��20(�6t   �� 5   
   -   5        $ 
L_Tartalom��5      $��Jegyzet:��6$   $
��Left=�67   $��10,72,0,311q�6R   $	��Top=�6g   $��20(�6   $��37��6�   �� 5   
   -   5        $ 
L_Címkék��5      $?��9Jegyzethez tartozó címkék:
 (vesszővel elválasztva)��6"   $
��Left=�6i   $��20,361,0,10q�6�   $��Bottom=�6�   $��49��6�   $	��155��6�   �� 5   
   -   5         ��Name$	 Cim��5      $
��Left=�6   $��37��6:   $��	63,10,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��195��6�   $��24(�6�   
���   �.��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5   
   -   5        $ Címkék��5      $
��Left=�6"   $��26��6=   $��
219,0,0,33q�6I   $
 Wrap=�6]   $��Bottom=�6r   $	��297��6�   
���   �$��18(�6�   .��6�    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 3��65   5      5      .��6!   5      �� 5    
   -   5        $ Tartalom��5       $��Stretch=�6$   $��95,72,20,110q�6C   $
 Wrap=�6Y   $��Stretch=�6n   
���   �$��18(�6�   .��6�    5!      ��%^   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$ 3��65   5$      5%      .��6!   5&      �� 5'   
   -   5        	 ��Name$	 Kész��5'      $��Kész��6   $��Right=�6.   $��	0,0,46,10q�6J   $��Bottom=�6]   $	��110��6x   $��30(�6�   $��66��6�   
���   �$��2q�6�    5(      ��%^   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$ 5��65   5+      5,      5-      5/      50      