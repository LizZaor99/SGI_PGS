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
        private IHomeRepository homeRepository;
        private string _currentDateTime;
        private int _tipoEq = 105;
        private int _status = 6;
        private HomeModel _countLaptop;


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
        public string CurrentDateTime
        {
            get
            {
                return _currentDateTime;
            }
            set
            {
                if (value != _currentDateTime)
                {
                    _currentDateTime = value;
                    OnPropertyChanged("CurrentDateTime");
                }
            }
        }

        //Status
        public int TipoEq
        {
            get
            {
                return _tipoEq;
            }
            set
            {
                _tipoEq = value;
                OnPropertyChanged(nameof(TipoEq));
            }
        }
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public HomeModel CountLaptop
        {
            get
            {
                return _countLaptop;
            }
            set
            {
                _countLaptop = value; 
                OnPropertyChanged(nameof(CountLaptop));
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

        public ICommand CountLapTopCommand { get; }

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

            //Status
            
           
            //Default View
            ExecuteShowHomeViewCommand(null);

            LoadCurrentUserData();
            

            homeRepository = new HomeRepository();
            CountLaptop = new HomeModel();
            LoadCountLaptopData();

        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Inicio";
            GetCurrentDateTime();
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

        //PARA HOME MODEL,MOSTRAR LA HORA 
        public string GetCurrentDateTime()
        {
            try
            {
                DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();

                return CurrentDateTime;
            }
            catch
            {
                return CurrentDateTime;
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.CurrentDateTime = DateTime.Now.ToString("HH':'mm tt - dddd, dd MMMM yyyy");

           //this.CurrentDateTime = DateTime.Now.ToLongDateString();
            CommandManager.InvalidateRequerySuggested();
        }

        //PARA HOME MODEL, MOSTRAR EL CONTEO DE LAPTOPS

        private void LoadCountLaptopData()
        {

            var count = homeRepository.GetByStatus(TipoEq, Status);
            
            CountLaptop.DisplayLaptop = $"{count} Laptops asignadas";
        }
    }
}
