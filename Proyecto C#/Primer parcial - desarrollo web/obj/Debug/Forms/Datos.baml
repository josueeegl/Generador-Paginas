   M S B A M L   `   `   `  ����Z  VPrimer parcial - desarrollo web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Primer_parcial___desarrollo_web.Forms%Primer_parcial___desarrollo_web.Forms  5   	   1    +Primer_parcial___desarrollo_web.Forms.Datos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:Primer_parcial___desarrollo_web.Forms     5   	     � Title$  Datos��5   	   $��861.197��6   $��1495.694��6(    � WindowState$ 	Maximized=�69    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � .+�5
   
   �� -   5         ��Name$ 
btnGenerar��5
   *   $��Generar��6>   $��89��6P   $��280,0,290,26q�6\   $��Bottom=�6r   $	��424��6�   ���	#FF1D8B1D���	#FFECECEC$��24(�6�   $��Center=�6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��35��6@   $��
207,50,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��350��6�   $��16(�6�   �� 5   
   $��Nombre completo:��6   $
��Left=�6+   $��	30,54,0,0q�6F   $	��Top=�6Y   $	��155��6q   $��16(�6}   $
��Bold"�6�   �� 5   
   -   5        $ txtCarne��5      $
��Left=�6$   $��35��6?   $��207,112,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��350��6�   $��16(�6�   �� 5   
   $��Carné:��6   $
��Left=�6!   $��
30,116,0,0q�6<   $	��Top=�6P   $	��155��6h   $��16(�6t   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 	imgcargar��5      $
��Left=�6#   $	��183��6>   $��
739,24,0,0q�6K   $	��Top=�6_   $	��232��6w   $7��1pack://siteoforigin:,,,/Resources/darth-vader.png��6�   �� 5   
   -   5        $��	btnImagen��5   )   $��Cargar imagen��6   $
��Left=�6:   $��
574,73,0,0q�6U   $	��Top=�6i   $	��150��6�   ���	#FF4260C9$��16(�6�   $
��Bold"�6�   $��47��6�   �� 5   
   -   5        $ txtFecha��5      $
��Left=�6$   $��35��6?   $��207,181,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��350��6�   $��16(�6�   �� 5   
   $��Fecha de nacimiento:��6   $
��Left=�6/   $��
30,185,0,0q�6J   $	��Top=�6^   $	��172��6v   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $ 	txtCiudad��5      $
��Left=�6%   $��35��6@   $��207,248,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��350��6�   $��16(�6�   �� 5   
   $��Ciudad:��6   $
��Left=�6"   $��
30,252,0,0q�6=   $	��Top=�6Q   $	��172��6i   $��16(�6u   $
��Bold"�6�   �� 5   
   $��Habilidades:��6   $
��Left=�6'   $��
30,312,0,0q�6B   $	��Top=�6V   $	��172��6n   $��16(�6z   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridHabilidades��5      $
��Left=�6,   $	��162��6G   $��
30,369,0,0q�6T   $	��Top=�6h   $	��290��6�   ���	#FF678B88   CanUserAddRows . 	   AutoGenerateColumns	 .  
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -	   5        habi��   FontSize$ 16Q�5   W   ,  &System.Windows.Controls.DataGridColumn   Header$ 	Habilidad��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$ 	Habilidad�6e   5      �� 5   
   $��Hobbies:��6   $
��Left=�6#   $��376,312,0,0q�6>   $	��Top=�6S   $	��172��6k   $��16(�6w   $
��Bold"�6�     5   
   -
   5        $ gridHobbies��5      $
��Left=�6(   $	��162��6C   $��376,369,0,0q�6P   $	��Top=�6e   $	��264��6}   ���	#FF5F8784 . 	 .  
 5        5      -   5        Hob��$ 16Q�5   T   $ Hobbies��6b    62   �� $ Hobbies�6b   5       �� 5!   
   -   5        $ imgFondo��5!      $
��Left=�6"   $	��183��6=   $��1030,348,0,0q�6J   $	��Top=�6`   $	��232��6x   $7��1pack://siteoforigin:,,,/Resources/darth-vader.png��6�   �� 5"   
   -   5        $ btnImgFondo��5"   (   $��Cargar Fondo��6   $
��Left=�6=   $��865,397,0,0q�6X   $	��Top=�6m   $	��150��6�   ���	#FF4260C9$��16(�6�   $
��Bold"�6�   $��47��6�   5$      5%      