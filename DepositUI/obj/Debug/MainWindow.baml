   M S B A M L   `   `   `  ����D  @DepositUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DepositUI	DepositUI  5   	       DepositUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DepositUI     5   	     � Title$  Deposit Calculator��5   	   $��633.841��6$   $��570.884��65    � 
ResizeMode$ CanMinimize=�6E   .��5	      � .+�5
   
   �� $��1q�6    �� CornerRadius$ 9��6%   $
��Left=�66   $��55��6R   $��0,10,0,0q�6^   $	��Top=�6p   $	��555��6�   ���	#FFEA3F3F._�5      �� $!��Advanced Deposit Calculator��6    �� TextAlignment$ Center=�6;   $��Center=�6R   $��24(�6m   $��DemiBold"�6{   
�������$��	0,12,-1,9q�6�   5      �� 5   
   $,��&Find a Summary Future Deposit Payments��6   $ Center=�6B   $��Center=�6Y   $��20(�6t   $��DemiBold"�6�   $��
0,87,0,491q�6�   � 5   
   $��10,155,10,414q�6   .+�5      �� $��First payments date :��6   $
 Left=�65   $��16(�6J   $��DemiBold"�6X   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 	FirstDate��5      $��20,0,0,0q�6,   $��14(�6>   $��DemiBold"�6L   $	��200��6b   5      � 5   
   $��10,191,10,374q�6   .+�5      �� $��Latest payments date :��6   $
 Left=�66   $��16(�6L   $��DemiBold"�6Z     5      -   5        $ 
LatestDate��5      $��8,0,0,0q�6-   $��14(�6>   $��DemiBold"�6L   $	��200��6b   5      � 5   
   $��10,236,-10,338q�6   .+�5      �� $��Deposit Sum :��6   $
 Left=�6-   $��16(�6C   $��DemiBold"�6Q   $	��150��6g   �� 5      -   5         ��Name$ 
DepositSum��5      $��20,0,0,0q�6*   $��14(�6<   $��DemiBold"�6J   $	��200��6`   6l   �� 5      $�� $��6   $
 Left=�6"   $��16(�67   $��DemiBold"�6E   5      � 5   
   $��10,272,-10,302q�6   .+�5      �� $��Deposit Percentage :��6   $
 Left=�64   $��16(�6J   $��DemiBold"�6X   $	��150��6n   �� 5      -   5        $ 
PercentSum��5      $��20,0,0,0q�6*   $��14(�6<   $��DemiBold"�6J   $	��200��6`   6l   5       � 5!   
   $��10,353,10,189q�6   .+�5"      �� -   5         ��Name$" ReplenishmentDepositCheckBox��5"      $��Is Repayment Deposit��6=   $��16(�6\   $��DemiBold"�6j   $	��193��6�   $��28��6�   � 5#      -   5         �Name$ ReplenishmentDeposit��5#      $��32��6�   $	��545��6�   y�66   ��  �� ElementName$" ReplenishmentDepositCheckBox��	 �� Path$	 	IsChecked�
 �� TargetNullValue$
 false�� �� 	Converter ,   &DepositUI.BooleanToVisibilityConverter  .+�5$      �� $��Repayment Deposit Sum :��6   $
 Left=�6;   $��16(�6Q   $��DemiBold"�6_   $	��193��6u   �� 5%      -   5        $! ReplenishmentDepositTextBox��5%      $��20,0,0,0q�6?   $��14(�6Q   $��DemiBold"�6_   $	��156��6u   6�   �� 5&      $�� $��6   $
 Left=�6&   $��16(�6;   $��DemiBold"�6I   5'      5(      � 5)   
   $��10,308,10,257q�6   .+�5*      �� $��Compounding :��6   $
 Left=�6-   $��16(�6C   $��DemiBold"�6Q   $	��170��6g   �� 5+      -   5        $��TypeCapital��5+      $	��Top=�6*   $	��199��6B   .@�5,      ��  �� 
IsSelected . .��61   	Monthly6:   �� 5-      .��6    	Quarterly6+   �� 5.      .��6    Daily6'   5/      50      �� 51   
   -	   5        $��Calculating��51      $��221,416,220,0q�6'   $	��Top=�6>   $��22��6V   6b   � 52   
   $��10,459,-10,115q�6   .+�53      �� $'��!Summary Future Deposit Percents :��6   $
 Left=�6A   $��16(�6W   $��DemiBold"�6e   $	��280��6{   �� 54      -
   5        $ Ansver��54   (    �� 
IsReadOnly . $��20,0,0,0q�68   $��14(�6J   $��DemiBold"�6X   $	��202��6n   6z   55      � 56   
   $��10,495,-10,79q�6   .+�57      �� $��Summary Deposit Days :��6   $
 Left=�66   $��16(�6L   $��DemiBold"�6Z   $	��280��6p   �� 58      -   5        $ Ansver1��58   (    . $��20,0,0,0q�69   $��14(�6K   $��DemiBold"�6Y   $	��202��6o   6{   59      � 5:   
   $��10,531,-10,43q�6   y�6+   �� $" ReplenishmentDepositCheckBox��$	 	IsChecked�$
 false��   .+�5;      �� $��Summary Deposit:��6   $
 Left=�60   $��16(�6F   $��DemiBold"�6T   $	��280��6j   �� 5<      -   5        $ Ansver2��5<   (    . $��20,0,0,0q�6:   $��14(�6L   $��DemiBold"�6Z   $	��202��6p   6|   5=      5>      5?      