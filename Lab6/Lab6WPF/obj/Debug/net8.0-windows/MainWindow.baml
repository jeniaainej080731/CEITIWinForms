   M S B A M L   `   `   `  ����  Lab6WPF    Lab6WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Fun Graphics��5   	   $	��500��6   $	��800��6+    � WindowStyle$ ThreeDBorderWindow=�5   	   ���#E6F0FA � WindowStartupLocation$ CenterScreen=�5   	    � Icon$ 	/icon.png��6.    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $ Resources/Styles.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $��Center=�6:   .+�5      �� -   5        	 ��Name$	 SnowmanButton��5      $��Snowman��6,      CustomButton#��[  6Z   �� 5      -   5        $	 
BallButton��5      $��Bouncing Ball��6)   $��10,0,0,0q�6Z   #��[  6l   �� 5      -   5        $	 PointsButton��5      $��Points Window��6+   $��10,0,0,0q�6^   #��[  6p   5      �� 5   
   -   5        
 ��Name$
 canvas��5      $��1��6!   
�������$��10q�6A   5      5      