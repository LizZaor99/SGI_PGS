   M S B A M L   `   `   `  ????>  :SGI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SGI.Views	SGI.Views  5      /clr-namespace:SGI.ViewModelsSGI.ViewModels  64       SGI.Views.HomeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SGI.Views     5      3
ViewModelsclr-namespace:SGI.ViewModels     64     ? DataContext  5
      "   SGI.ViewModels.HomeViewModel  5   
   .??5      ??  ?? CornerRadius$ 10??6   $??2q?5      ??5   
   ?? 5       ?? 
StartPoint$	 0,0&?6"    ?? EndPoint$	 1,1&?63   .??5      ?    winBorderColor1 ? Color# [  6    ? Offset$ 0Q?6H   ? 5        winBorderColor2# [ 6   $
 0.75Q?6H   ? 5        winBorderColor3# [ 6   $ 1Q?6H   5      ._?5   
   ?  ? RowDefinitions 5      ?? 5      $	??150 ?6    ?? 5      $??* ?6    .+?5      ?? $??0??6   $??
30,20,30,0q?6&    ?? Orientation$ 
Horizontal=?6:   $??Center=?6S   $	??120??6n   .+?5      ??  
 color9#??[ 5!      $??20(?5"      $??
Montserrat)?5#      $??Medium"?5$      $	??100??5%      $	??125??6)   $
??Wrap=?5&       ?? TextAlignment$ Center=?5'      ??5       ?? *CounterEquipment.Display+5'      ?? 5(      #??[ 5*      $??20(?5+      $??
Montserrat)?5,      $??Medium"?5-      $	??100??5.      $	??125??6)   $
??Wrap=?5/      $ Center=?50      $??75,0,0,0q?51      ??5)      ?? *CounterLaptop.Display+51      ?? 52      #??[ 54      $??20(?55      $??
Montserrat)?56      $??Medium"?57      $	??100??58      $	??125??6)   $
??Wrap=?59      $ Center=?5:      $??75,0,0,0q?5;      ??53      ?? *CounterMiniprint.Display+5;      ?? 5<      #??[ 5>      $??20(?5?      $??
Montserrat)?5@      $??Medium"?5A      $	??100??5B      $	??125??6)   $
??Wrap=?5C      $ Center=?5D      $??75,0,0,0q?5E      ??5=      ?? *CounterSwitch.Display+5E      ?? 5F      #??[ 5H      $??20(?5I      $??
Montserrat)?5J      $??Medium"?5K      $	??100??5L      $	??125??6)   $??WrapWithOverflow=?5M      $ Center=?5N      $??75,0,0,0q?5O      ??5G      ?? *CounterStore.Display+5O      5P      ? 5R      $??1??6   	 ? ColumnDefinitions	 5S      ?? 5T      $??* ?6'   ?? 5U      $	??400 ?6'   .+?5Y      ?? $??1??6   $??Center=?6-   $??0,125,0,150q?6J   .+?5Z      ?? $??30(?5[       $??Bell MT)?5\       $??Medium"?5]       $??WrapWithOverflow=?5^       $ Center=?5_       $	??250??67   ??5Z       ?? *CurrentDateTime+5_   7   5`      ?? 5c      $??0??6   $??Center=?6-   $??
0,75,0,100q?6J   .+?5d      ?? $??Proximas Aperturas:??6    $??30(?5e       $??Bell MT)?5f       $??Medium"?5g       $??WrapWithOverflow=?5h       $ Center=?5i       $	??370??67   $??10q?6C   ?? 5j      $*??$C:\Proyectos\SGI\Images\Apertura.PNG??6   $	??140??6J   $	??525??6W   5k      5l      5m      5n      5o      