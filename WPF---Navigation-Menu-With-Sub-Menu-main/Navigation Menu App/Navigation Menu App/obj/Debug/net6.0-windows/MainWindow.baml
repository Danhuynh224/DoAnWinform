   M S B A M L   `   `   `  ����N  JNavigation Menu App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Navigation_Menu_AppNavigation_Menu_App  5   	   $    Navigation_Menu_App.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Navigation_Menu_App     5   	     � Title$  
MainWindow��5   	   $	��700��5   	   $	��900��5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#23262B.+�5   
   �� $-��'D E S I G N   T H E   I N T E R F A C E��6   ���#525965$��Fonts/#Orbitron Medium)�5      $��10(�5      $��Bottom=�5      $��Right=�5      $��	0,0,15,10q�5      �� 5!   
   ���#D61734$��15��5"       �� CornerRadius$ 3,0,0,3��5#      $��5��5$      $��Bottom=�5%      $��Right=�5&      $��0,0,0,8q�5'      �� 5+   
   ���#2E333A$	��230��5,       �� Orientation$ Vertical=�5-      $
��Left=�5.      .+�52      � $��50��6   $	��Top=�53      $��0,30,0,0q�54       � ColumnDefinitions 55      �� 56      $
��116* �6'   �� 57      $
��115* �6'   .+�5:      �� ���#D61734$��26��5;      $ 3,0,0,3��5<      $��6��5=      $��Center=�5>      $
��Left=�5?      $��1��64   $��	108,0,0,0q�6D   �� 5A      $��C #   D E S I G N   P R O��6   ���#FFFFFF$��Fonts/#Orbitron Medium)�5C      $��15(�5D      $��Center=�5E      $
��Left=�5F      $��2��67   $��22,0,0,0q�6K   5H      o� 5L      $	��450��6   
������ $��0,40,0,0q�5N      ��5P      �� 5R      .R�5T      $�  $� Orientation$ Vertical=�61   5V      .@�5\      m� $
��Home��6      Menu_Template#��[  5]       m� Icon 5_      �� 5a      $��Assets/img_home.png��6    $
��None=�5b       5f      m� 5j      $��Music��6     Menu_SubMenu_Template#��[ 5k       5m      �� 5o      $��Assets/img_music.png��6    $
��None=�5p       .@�5v      m� $��	All Songs��6     Item_Template#��[ 5w       5y      �� 5{      $��Assets/img_songs.png��6$   $
��None=�5|   $   5�      m� 5�      $��Albums��6   #��[ 5�       5�      �� 5�      $��Assets/img_album.png��6$   $
��None=�5�   $   5�      m� 5�      $��Genres��6   #��[ 5�       5�      �� 5�      $��Assets/img_genre.png��6$   $
��None=�5�   $   .@�5�      m� $	��Pop��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_pop.png��6(   $
��None=�5�   (   5�      m� 5�      $
��Rock��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_rock.png��6(   $
��None=�5�   (   5�      m� 5�      $��Metal��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_metal.png��6(   $
��None=�5�   (   5�      m� 5�      $��Acoustic��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_acoustic.png��6(   $
��None=�5�   (   5�      m� 5�      $��Hip Hop��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_hiphop.png��6(   $
��None=�5�   (   5�      m� 5�      $��
Electronic��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_electronic.png��6(   $
��None=�5�   (   5�      m� 5�      $
��Jazz��6#   #��[ 5�   #    5�      �� 5�   "   $��Assets/img_jazz.png��6(   $
��None=�5�   (   5�      5�      m� 5     $��Artists��6   #��[ 5      5     �� 5     $��Assets/img_artist.png��6$   $
��None=�5  $   5     m� 5     $��	Playlists��6   #��[ 5      5     �� 5     $��Assets/img_playlist.png��6$   $
��None=�5  $   5     5     m� 5      $��Movies��6   #��[  5!      5#     �� 5%     $��Assets/img_movies.png��6    $
��None=�5&      5*     m� 5.     $��Search��6   #��[  5/      51     �� 53     $��Assets/img_search.png��6    $
��None=�54      58     m� 5<     $��Folders��6   #��[  5=      5?     �� 5A     $��Assets/img_folder.png��6    $
��None=�5B      5F     m� 5J     $��History��6   #��[  5K      5M     �� 5O     $��Assets/img_history.png��6    $
��None=�5P      5T     m� 5X     $��Settings��6   #��[ 5Y      5[     �� 5]     $��Assets/img_setting.png��6    $
��None=�5^      .@�5d     m� $��Input / Codecs��6   #��[ 5e      5g     �� 5i     $��Assets/img_input.png��6$   $
��None=�5j  $   5n     m� 5r     $��Hotkeys��6   #��[ 5s      5u     �� 5w     $��Assets/img_hotkey.png��6$   $
��None=�5x  $   5|     5~     m� 5�     $��About��6   #��[  5�      5�     �� 5�     $��Assets/img_about.png��6    $
��None=�5�      5�     m� 5�     $
��Exit��6   #��[  5�      5�     �� 5�     $��Assets/img_exit.png��6    $
��None=�5�      5�     5�     5�     �� 5�  
   -   5        	 ��Name$	 MaxBtn��5�       MaxBtnStyle#��[ 5�     5�     �� 5�  
   -   5        $	 CloseBtn��5�       CloseBtnStyle#��[ 5�     5�     5�     5�     