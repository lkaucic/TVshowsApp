   M S B A M L   `   `   `  ����D  @TvShowGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TvShowGUI	TvShowGUI  5   	       TvShowGUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TvShowGUI     5   	     � Title$  TV Shows Manager��5   	   $	��450��6"   $	��900��6/   $��15(�6<   $��SemiBold"�6J   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��0.5* �6   �� 5      $��10 �6   �� 5      $
��0.5* �6   �� 5      $��10 �6   �� 5      $
��0.5* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6   �� 5#      $
��auto �6   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $
��auto �6   �� 5'      $
��auto �6   �� 5(      $��* �6   �� 5)      $��10 �6   .+�5,   
   �� -   5        $��
SearchShow��5,      $��1��6&   $��1��66   $��Search by title:��6C   $��0,0,0,5q�6[   �� 5-   
   -   5        $��SearchInput��5-      $��1��6%   $��2��65   $�� ��6B   $��0,0,0,10q�6J   �� 5.   
   -   5        $��ConfirmSearch��5.      $��1��6&   $��3��66   $��Search��6C   $��0,0,0,10q�6T   6f   �� 5/   
   -   5        $��SeasonsTitle��5/      $��3��6(   $��1��68   $��Seasons:��6E   $��0,0,0,5q�6U   �� 50   
   -   5        $��SeasonsList��50      $��3��6%   $��2��65   $��15��6B   6T   �� 51   
   -   5        $��EPisodesTitle��51      $��5��6)   $��1��69   $��	Episodes:��6F   $��0,0,0,5q�6W   �� 52   
   -   5        $��EpisodesList��52      $��5��6&   $��2��66   $��16��6C   6U   �� 53   
   -   5        $��ShowsListBox��53      $��1��6&   $��4��66   $��8��6C   $��0,0,0,10q�6T   6f   �� 55   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��13��6>   $��	0,15,0,10q�6L   .+�56      �� -	   5        $��ShowName��56      $��Name:��6(   $��0,0,5,5q�65   �� 57      -
   5         ��Name$ ShowNameBox��57      $�� ��6,   $	��150��64   $��0,0,0,5q�6@   {�.  
������ 6c   58      �� 59   
   $ 
Horizontal=�6   $��1��6.   $��14��6>   $��0,0,0,10q�6L   .+�5:      �� -   5        $��ShowLanguage��5:      $��	Language:��6,   $��0,0,5,5q�6=   �� 5;      -   5        $ ShowLanguageBox��5;      $�� ��60   $	��150��68   $��0,0,0,5q�6D   {�.  
������ 6g   5<      �� 5=   
   $ 
Horizontal=�6   $��1��6.   $��15��6>   $��0,0,0,10q�6L   .+�5>      �� -   5        $��
ShowRating��5>      $��Rating:��6*   $��0,0,5,5q�69   �� 5?      -   5        $ ShowRatingBox��5?      $�� ��6.   $	��150��66   $��0,0,0,5q�6B   {�.  
������ 6e   5@      �� 5A   
   $ 
Horizontal=�6   $��1��6.   $��16��6>   $��0,0,0,10q�6L   .+�5B      �� -   5        $��
ShowGenres��5B      $��Genres:��6*   $��0,0,5,5q�69   �� 5C      -   5        $ ShowGenresBox��5C      $�� ��6.   $	��229��66   $��	0,0,0,5.4q�6B   {�.  
������ 6g   5D      �� 5E   
   $ 
Horizontal=�6   $��1��6.   $��17��6>   $��0,0,0,0q�6L   .+�5F      �� -   5        $��
ShowStatus��5F      $��Status:��6*   $��0,0,5,5q�69   �� 5G      -   5        $ ShowStatusBox��5G      $�� ��6.   $	��150��66   $��0,0,0,5q�6B   {�.  
������ 6e   5H      �� 5J   
   -   5        $
��XKCD��5J      $��3��6   $��17��6-   $��10,10,10,10q�6;   $��DO NOT PRESS THIS BUTTON!��6P   
���  ��$
��Bold"�6�   $��3q�6�   
���   �6�   5K      5L      