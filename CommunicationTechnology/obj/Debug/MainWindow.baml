   M S B A M L   `   `   `  ????R  NCommunicationTechnology, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CommunicationTechnologyCommunicationTechnology  5   	   (    "CommunicationTechnology.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CommunicationTechnology     5   	     ? SizeToContent$  WidthAndHeight=?5   E   $	??600??6d   $	??400??6t   $	??800??6?   $	??400??6?    ? Icon$ Assets/Images/logoms.png??6?    ? Title 6	   ??  ?? ElementName$ 	MainFrame?? ?? Path$ Content.Title?.??5	      ? ???#000000 ? RowDefinitions 5
   
   ?? 5      $??60 ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Assets/Images/logo.png??6   $
??Left=?60   ?? 5   
   $??Center=?6   $??Center=?6-      
TitleLabel#??[  6H   $%??Технологии связи??6l   ?? 5   
   -   5         ??Name$ 
BackButton??5      $??Right=?6>     NavigateButton#??[ 6Z   $??
Назад??6?    ? 5   
   -   5          ?Name$ 	MainFrame??5      $??1??6O     ? NavigationUIVisibility$ Hidden=?6\   5      5      