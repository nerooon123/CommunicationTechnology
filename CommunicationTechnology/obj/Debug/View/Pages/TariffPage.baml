   M S B A M L   `   `   `  ????R  NCommunicationTechnology, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CommunicationTechnology.View.Pages"CommunicationTechnology.View.Pages  5      3    -CommunicationTechnology.View.Pages.TariffPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:CommunicationTechnology.View.Pages     5        N? Title$%  Настройка тарифа??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??60 ?6   ?? 5      .+?5   
   ?? $??Center=?6      
TitleLabel#??[  6-   $%??Настройка тарифа??6Q   A? 5   
    A? Columns$ 2??6   $??1??6"   .+?5      ?? $??Center=?6   $??Center=?66   .+?5      A? .+?5      ?? $??
Тариф??6   ?? 5      -   5         ??Name$ TariffCombobox??5      67   5      A? 5      .+?5      ?? $??Интернет??6   ?? 5      -   5         ??Name$ InternetSlider??5       ? Maximum$ 50Q?65   ?? 5      
?????????63   ??  ?? ElementName$ InternetSlider?? ?? Path$ Value?5      A? 5      .+?5      ?? $??Звонки??6   ?? 5      -   5        $ CountBellSlider??5      $
 1000Q?66   ?? 5      
?????????63   ?? $ CountBellSlider??$ Value?5       A? 5!      .+?5"      ?? $	??SMS??6   ?? 5#      -   5        $ 	SmsSlider??5#      $
 1000Q?60   ?? 5$      
?????????63   ?? $ 	SmsSlider??$ Value?5%      ?? 5&      -   5         ??Name$ TariffButton??5&      $!??Изменить тариф??6/   5'      ?? 5(      .+?5)      ?? #??[  6   $??Center=?6<   $%??Стоимость тарифа??6Y   ?? 5*      -   5        	 ??Name$	 
PriceLabel??5*        
PriceLabel#??[ 6,   $??Center=?6P   .??6m   
365руб.6v   5+      5,      5-      5.      