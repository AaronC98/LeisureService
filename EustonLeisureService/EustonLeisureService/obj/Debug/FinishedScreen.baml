   M S B A M L   `   `   `  ����O  KEustonLeisureService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EustonLeisureServiceEustonLeisureService  5   	   )    #EustonLeisureService.FinishedScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EustonLeisureService     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��624��6   $	��925��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p   ���	#FF019D9D.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��23* �6   �� 5      $��7* �6   .+�5   
   �� $��25,125,25,25q�6   $��2��6+   $��0��6?   $	��300��6L   $
��Left=�6X   .+�5      �� $��Center=�6   $��25(�68   ���#FFF$��10q�6X   .��6d   
Mentions6n   �� 5      
�������$��
10,0,9.6,0q�6(    �� CornerRadius$ 5��6<   $	��457��6M   ._�5      �� $��25q�6   .+�5      �� -   5         ��Name$ 
mentionBox��5      $	��310��62   $��	0,0,0.2,0q�6?   6T   �� 5      -   5         ��Name$ backBtn��5      $��40 35q�6.   .��6S   Back6Y   5      5      5      �� 5   
   $��25,125,25,25q�6   $��2��6+   $��0��6?   $	��300��6L   $��Center=�6X   .+�5      �� $��Center=�6   $��25(�68   ���#FFF$��10q�6X   .��6d   
Trending6n   �� 5      
�������$��
10,0,9.6,0q�6(   $ 5��6<   $	��457��6M   ._�5      �� $��25q�6   .+�5      �� -   5        $ 
hashtagBox��5      $	��310��62   $��	0,0,0.2,0q�6?   6T   �� 5      -   5        $ closeBtn��5      $��40 35q�6/   .��6V   Close6]   5      5!      5"      �� 5#   
   $��25,125,25,25q�6   $��2��6+   $��0��6?   $	��300��6L   $��Right=�6X   .+�5$      �� $��Center=�6   $��25(�68   ���#FFF$��10q�6X   .��6d   Serious Incidents6w   �� 5%      
�������$��
10,0,9.6,0q�6(   $ 5��6<   $	��457��6M   ._�5&      �� $��25q�6   .+�5'      �� -   5        $ 
seriousBox��5'      $	��310��63   $��	0,0,0.2,0q�6@   6U   5)      5+      5,      5-      50      