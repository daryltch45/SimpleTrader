   M S B A M L   `   `   `  ����K  GSimpleTrader.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SimpleTrader.WPF.ControlsSimpleTrader.WPF.Controls  5      S.clr-namespace:SimpleTrader.WPF.State.Navigator SimpleTrader.WPF.State.Navigator  5	      -    'SimpleTrader.WPF.Controls.NavigationBar   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SimpleTrader.WPF.Controls     5      >nav.clr-namespace:SimpleTrader.WPF.State.Navigator     5	      .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Padding$ 10q�6!   $��28(�6.   
�������$��Simple Trader��6O      BrushPrimary1#��[  6d   � 5   
   $��1��6     BrushPrimary2#��[ 6    �� EdgeMode$ Aliased=�6H    � 	Resources 5       �� 
TargetType  	NavButton �� BasedOn��%0   '	�       7  �� 5      " 	�6   8   61   5       � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      	� $��0��6   $
��Home��6*   /   )SimpleTrader.WPF.State.Navigator.ViewType   Home#��Z 5      ��5      �� *UpdateCurrentViewModelCommand+5      	� 5!      $��1��6   $��	Portfolio��6*      	Portfolio#��Z 5#      ��5"      �� *UpdateCurrentViewModelCommand+5#      	� 5%      $��2��6   $	��Buy��6*   	� 5'      $��3��6   $
��Sell��6*   5(      5)      5*      