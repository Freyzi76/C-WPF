   M S B A M L   `   `   `  ����F  BPlusMoinWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PlusMoinWPFPlusMoinWPF  5   	       PlusMoinWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PlusMoinWPF     5   	     � Title$  PlusMoins C# WPF��5   	   $	��173��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�6.   .��5      � .+�5   
   �� -   5         ��Name$ title��5      $+��%Bienvenue dans le de jeu de PlusMoins��6   $
��Left=�6O   $��	10,10,0,0q�6j   $	��Top=�6}   $��36��6�   $	��323��6�   $ ��Source Sans Pro ExtraLight)�6�   $��18(�6�   �� 5   
   -   5         ��Name$ 	UserInput��5      $
��Left=�6%   $��28��6@   $��	15,51,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��177��6�   $��14(�6�   �� 5   
   -   5         ��Name$ buttonUserInput��5      $��Valider mon choix��6*   $
��Left=�6F   $��
197,51,0,0q�6a   $	��Top=�6u   $	��136��6�   $��28��6�    J� RenderTransformOrigin$ 1.613,0.643&�6�   6�   �� 5   
   -   5        $ resultLabel��5      $k��eTu dois trouver un chiffre random créé par le programme,
compris entre 0 et 10.
A toi de jouer :)��6%   $
��Left=�6�   $��
357,10,0,0q�6�   $	��Top=�6�   $��81��6�   $	��427��6�   $��14(�6  �� 5   
   -   5        $ 	lifeLabel��5      $��Vie restante : ��6#   $
��Left=�6=   $��
15,104,0,0q�6X   $	��Top=�6l   $��28��6�   $	��102��6�   �� 5   
   -   5        $ resultLifeLabel��5      $��
��6)   $
��Left=�69   $��
93,104,0,0q�6T   $	��Top=�6h   $ 0.184,-1.048&�6�   $��28��6�   $��38��6�   �� 5   
   -   5        $ 
scoreLabel��5      $��Score :��6$   $
��Left=�66   $��158,104,0,0q�6Q   $	��Top=�6f   $��46��6~   $��28��6�   �� 5   
   -   5        $ scoreResult��5      $�� ��6%   $
��Left=�60   $��209,104,0,0q�6K   $	��Top=�6`   $��28��6x   $��85��6�   �� 5   
   -	   5        $ buttonChangeValMax��5      $"��Changer la valeur Max de jeu��6-   $
��Left=�6T   $��618,104,0,0q�6o   $	��Top=�6�   $	��166��6�   $��28��6�   6�   5      5      