   M S B A M L   `   `   `  ????>  :SGI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SGI.Views	SGI.Views  5   	   /clr-namespace:SGI.ViewModelsSGI.ViewModels  5   	       SGI.Views.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SGI.Views     5   	   3
ViewModelsclr-namespace:SGI.ViewModels     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     ? Title$  	Dashboard??5
   	   $	??700??6   $
??1300??6(    ? WindowStartupLocation$ CenterScreen=?65    ? WindowStyle$
 None=?5   	   
??????  ? AllowsTransparency .  ? 	Resources 5       ?? DataType"   SGI.ViewModels.HomeViewModel   SGI.Views.HomeView&    SGI.ViewModels.ContactsViewModel   SGI.Views.ContactsView'   !SGI.ViewModels.InventoryViewModel   SGI.Views.InventoryView'   !SGI.ViewModels.ProvidersViewModel   SGI.Views.ProvidersView'	   !SGI.ViewModels.EquipmentViewModel
   SGI.Views.EquipmentView%   SGI.ViewModels.NetworkViewModel   SGI.Views.NetworkView!   SGI.ViewModels.SMSViewModel   SGI.Views.SMSView$   SGI.ViewModels.ManageViewModel   SGI.Views.ManageView??%X  (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)(?? ?     5      *, +)(?? ?     5       *,	 +)(?? ?     5$      *, +)(?? ,    5(      *, +)(?? ^    5,      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5    
   " 	 6   .R?5!      
  5"      ?? 5$   
   "  6   .R?5%        5&      ?? 5(   
   "  6   .R?5)        5*      ?? 5,   
   "  6   .R?5-        5.      5/       ? DataContext 51      '   !SGI.ViewModels.DashboardViewModel  52   
   .??55      ??  ?? CornerRadius$ 10??6   $??2q?56      ??58   
   ?? 59       ?? 
StartPoint$	 0,0&?6"   	 ?? EndPoint$		 1,1&?63   .??5:      ?    winBorderColor1
 ? Color#
 [  6    ? Offset$ 0Q?6H   ? 5;        winBorderColor2#
 [ 6   $
 0.75Q?6H   ? 5<        winBorderColor3#
 [ 6   $ 1Q?6H   5=      ._?5@   
   ?  ? ColumnDefinitions 5A      ?? 5B      $	??250 ?6#   ?? 5C      $??* ?6#   .+?5G      ?? $ 	10,0,0,10??6   $??0??6.   ??5H      ?? 5I      $	 0,0&?6*   $	 1,0.7&?6;   .??5J      ?   menuBackColor1#
 [ 6'   $ 0Q?6O   ? 5K        menuyBackColor2#
 [ 6'   $ 1Q?6P   5L      ._?5N      ?? .+?5O      ??  ?? Orientation$ 
Horizontal=?6!   $??70??6:   $??
15,25,0,40q?6F   .+?5P      ?? $&?? C:\Proyectos\SGI\Images\Logo.png??6    $	??235??6J   5R      	? 5T        
menuButton#??[ 6"    
 color1
 ? Tag# [ 5U   "    d? 	IsChecked$
 TrueY?5V   "   ??5W   "   ?? *ShowHomeViewCommand+.??5X      ?? $ 
Horizontal=?6%   .+?5Y      "  FontAwesome.WPF.ImageAwesome     Icon$
 Home=?6.     menuButtonIcon#??[ 6:   ?? 5Z      $??Inicio??6(     menuButtonText#??[ 66   5[      5\      	? 5^      #??[ 6"    
	 color2# [	 5_   "   ??5`   "   ?? *ShowContactsViewCommand+.??5a      ?? $ 
Horizontal=?6%   .+?5b        $ AddressBook=?6.   #??[ 6A   ?? 5c      $??	Contactos??6(   #??[ 69   5d      5e      	? 5g      #??[ 6"    

 color3# [
 5h   "   ??5i   "   ?? *ShowInventoryViewCommand+.??5j      ?? $ 
Horizontal=?6%   .+?5k        $ Truck=?6.   #??[ 6;   ?? 5l      $??
Inventario??6(   #??[ 6:   5m      5n      	? 5p      #??[ 6"    
 color4# [ 5q   "   ??5r   "   ?? *ShowProvidersViewCommand+.??5s      ?? $ 
Horizontal=?6%   .+?5t        $ Users=?6.   #??[ 6;   ?? 5u      $??Proveedores??6(   #??[ 6;   5v      5w      	? 5y      #??[ 6"    
 color5# [ 5z   "   ??5{   "   ?? *ShowEquipmentViewCommand+.??5|      ?? $ 
Horizontal=?6%   .+?5}        $ Laptop=?6.   #??[ 6<   ?? 5~      $??Equipos??6(   #??[ 67   5      5?      	? 5?      #??[ 6"    
 color6# [ 5?   "   ??5?   "   ?? *ShowNetworkViewCommand+.??5?      ?? $ 
Horizontal=?6%   .+?5?        $
 Wifi=?6.   #??[ 6:   ?? 5?      $	??Red??6(   #??[ 63   5?      5?      	? 5?      #??[ 6"    
 color7# [ 5?   "   ??5?   "   ?? *ShowSMSViewCommand+.??5?      ?? $ 
Horizontal=?6%   .+?5?        $ Telegram=?6.   #??[ 6>   ?? 5?      $	??SMS??6(   #??[ 63   5?      5?      	? 5?      #??[ 6"    
 color8# [ 5?   "   ??5?   "   ?? *ShowManageViewCommand+.??5?      ?? $ 
Horizontal=?6%   .+?5?        $ Tasks=?6.   #??[ 6;   ?? 5?      $??Administrar??6(   #??[ 6;   5?      5?      5?      5?      ?? 5?      $ 	0,10,10,0??6   $??2??6.   ??5?      ?? 5?      $	 1,1&?6*   $		 0,0&?6;   .??5?      ?   secondaryBackColor1#
 [ 6'   $ 0Q?6T   ? 5?        secondaryBackColor2#
 [ 6'   $ 1Q?6T   5?      ._?5?      ?  ? RowDefinitions 5?      ?? 5?      $??25 ?6(   ?? 5?      $??70 ?6(   ?? 5?      $??* ?6(   .+?5?      ?? -   5         ??Name$ pnlControlBar??5?   !   $??0??5?   !   $ 
Horizontal=?5?   !   $??RightToLeft=?5?   !   
?????? $??0,0,5,0q?5?   !   .+?5?      ?? -   5         ??Name$ btnClose??5?   !     controlButton#??[ 5?   !    
 color9# [ 5?   !   .??5?        $ Close=?6.     controlButtonIcon#??[ 6;   5?      ?? 5?      -   5        $ btnMax??5?   !   #??[ 5?   !   # [ 5?   !   .??5?        $ WindowMaximize=?6.   #??[ 6D   5?      ?? 5?      -   5        $ btnMin??5?   !   #??[ 5?   !   # [ 5?   !   .??5?        $ WindowMinimize=?6.   #??[ 6D   5?      5?      ? 5?      $??1??6    5?      ?? 5?      ?? 5?      .+?5?      ?? $??0??6%   $ 
Horizontal=?5?   %   $??Center=?5?   %   .+?5?        $??20??6D     plainTextColor3   
Foreground# [ 6P   $??	35,0,10,0q?6~    6.   ?? *Icon+6~   ?? 5?        textPlainColor1#??[ 6A   $??20(?6o   $??
Montserrat)?6}   $??Medium"?6?   $??Center=?6?   ??6(   ?? *	Caption+6?   5?      ?? 5?      $??1??6%   $ 
Horizontal=?5?   %   $??RightToLeft=?5?   %   $??Center=?5?   %   $??0,0,10,0q?5?   %   .+?5?      ?? -   5          
userButton#??[ 5?   %     panelOverColor# [ 5?   !    ? ToolTip$ Cerrar Sesión??5?   %   .??5?   "     $ 	ArrowLeft=?62     userButtonIcon#??[ 6C   5?      ?? 5?      #??[ 5?   (   $??
Montserrat)?5?   (   $??15(?5?   (   $??Center=?5?   (   $??
0,10,10,10q?5?   (   ??5?   (   ?? * CurrentUserAccount.DisplayName+5?   (   ?? 5?      #??[ 6%   # [ 5?   !   $
 Hora??5?   %   .??5?   "     $ ClockOutline=?62   #??[ 6F   5?      ?? 5?      #??[ 6%   # [ 5?   !   $ Servidor??5?   %   .??5?   "     $ Server=?62   #??[ 6@   5?      ?? 5?      #??[ 6%   # [ 5?   !   $ Información??5?   %   .??5?   "     $
 Info=?62   #??[ 6>   5?      5?      5      ?? 5     $??25, 0, 25 , 25q?5  %   $??2??6=   ??5  %   ?? *CurrentChildView+5  =   5     5     5     5     5	     