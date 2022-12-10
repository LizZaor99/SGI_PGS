using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using FontAwesome.WPF;
using SGI.Models;
using SGI.Repositories;

namespace SGI.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    
    {
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;
        private FontAwesomeIcon _icon;
        private IUserRepository userRepository;

        //Properties
        public UserAccountModel CurrentUserAccount 
        { 
            get 
            { 
                return _currentUserAccount; 
            } 
            set 
            { 
                _currentUserAccount = value; OnPropertyChanged(nameof(CurrentUserAccount)); 
            } 
        }
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value; OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value; OnPropertyChanged(nameof(Caption));
            }
        }
        public FontAwesomeIcon Icon 
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value; OnPropertyChanged(nameof(Icon)); 
            }
        }

        // Commands of the views
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowContactsViewCommand { get; }
        public ICommand ShowInventoryViewCommand { get; }
        public ICommand ShowProvidersViewCommand { get; }
        public ICommand ShowEquipmentViewCommand { get; }
        public ICommand ShowNetworkViewCommand { get; }
        public ICommand ShowSMSViewCommand { get; }
        public ICommand ShowManageViewCommand { get; } 

        //Constructor
        public DashboardViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            

            //Initialize commands of the views
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowContactsViewCommand = new ViewModelCommand(ExecuteShowContactsViewCommand);
            ShowInventoryViewCommand = new ViewModelCommand(ExecuteShowInventoryViewCommand);
            ShowProvidersViewCommand = new ViewModelCommand(ExecuteShowProvidersViewCommand);
            ShowEquipmentViewCommand = new ViewModelCommand(ExecuteShowEquipmentViewCommand);
            ShowNetworkViewCommand = new ViewModelCommand(ExecuteShowNetworkViewCommand);
            ShowSMSViewCommand = new ViewModelCommand(ExecuteShowSMSViewCommand);
            ShowManageViewCommand = new ViewModelCommand(ExecuteShowManageViewCommand);

            //Default View
            ExecuteShowHomeViewCommand(null);
            LoadCurrentUserData();

        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Inicio";
            Icon = FontAwesomeIcon.Home;
        }
        private void ExecuteShowContactsViewCommand(object obj)
        {
            CurrentChildView = new ContactsViewModel();
            Caption = "Contactos";
            Icon = FontAwesomeIcon.AddressBook;
        }
        private void ExecuteShowInventoryViewCommand(object obj)
        {
            CurrentChildView = new InventoryViewModel();
            Caption = "Inventario";
            Icon = FontAwesomeIcon.Truck;
        }
        private void ExecuteShowProvidersViewCommand(object obj)
        {
            CurrentChildView = new ProvidersViewModel();
            Caption = "Proveedores";
            Icon = FontAwesomeIcon.Users;
        }
        private void ExecuteShowEquipmentViewCommand(object obj)
        {
            CurrentChildView = new EquipmentViewModel();
            Caption = "Equipos";
            Icon = FontAwesomeIcon.Laptop;
        }
        private void ExecuteShowNetworkViewCommand(object obj)
        {
            CurrentChildView = new NetworkViewModel();
            Caption = "Red";
            Icon = FontAwesomeIcon.Wifi;
        }
        private void ExecuteShowSMSViewCommand(object obj)
        {
            CurrentChildView = new SMSViewModel();
            Caption = "SMS";
            Icon = FontAwesomeIcon.Telegram;
        }
        private void ExecuteShowManageViewCommand(object obj)
        {
            CurrentChildView = new ManageViewModel();
            Caption = "Administrar";
            Icon = FontAwesomeIcon.Tasks;
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = user.Usuario;
                CurrentUserAccount.DisplayName = $"{user.Nombre} {user.PrimerApellido}";
            }
            else
            {
                CurrentUserAccount.DisplayName = "Usuario invalido";
                //Hide child views.
            }
        }
    }
}
