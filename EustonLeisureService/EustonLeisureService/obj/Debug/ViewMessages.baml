   M S B A M L   `   `   `  ����O  KEustonLeisureService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EustonLeisureServiceEustonLeisureService  5   	   '    !EustonLeisureService.ViewMessages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EustonLeisureService     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��624��6   $	��925��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p   ���	#FF019D9D.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��376* �6   �� 5      $
��333* �6   �� 5      $
��216* �6   .+�5   
   �� $��25,125,0,25q�6   $��2��6*   $��0��6>   $	��450��6K   $
��Left=�6W   .+�5      �� 
�������$��10 65q�6(    �� CornerRadius$ 5��67   ._�5      �� $��25q�6   .+�5      �� -   5         ��Name$ 
messageBox��5      $	��250��62   $��	0,0,0.2,0q�6?   6�   �� 5      -   5         ��Name$ backBtn��5      $��40 15q�6.   .��6T   Back6Z   5      5      5      �� 5   
   $��0,126,24.8,25q�6   $��2��6,   $	��425��6@   $��Right=�6L   $��1��6h   .+�5      �� $��Center=�6   $��25(�68   ���#FFF$	��0 0q�6X   .��6e   Message List6s   �� 5      
�������$��10 15q�6(   $ 5��67   ._�5      �� $��25q�6   .+�5      �� .��6   Message Type6*   �� 5      -   5         ��Name$ processedMsgType��5   0   	 �� 
IsReadOnly	 . 6L   �� 5      .��6   Message ID:6)   �� 5       -   5        $ processedMsgHeader��5    X   
���   �
 �� TextWrapping$

 Wrap=�62   	 . 6X   �� 5!      .��6   Body:6#   �� 5"      -   5        $ processedMsgBody��5"   d   
���   �$

 Wrap=�62   $��80��6F   	 . 6d   5#      5%      5&      5'      5)      