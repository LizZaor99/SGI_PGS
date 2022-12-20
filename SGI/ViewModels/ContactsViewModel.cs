using SGI.Models;
using SGI.Repositories;
using SGI.Views;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;

namespace SGI.ViewModels
{
    public class ContactsViewModel : ViewModelBase
    {
        private IContactsRepository contactsRepository;
        
        //Properties
        private ObservableCollection<ContactsModel> _storeType;
        public ObservableCollection<ContactsModel> StoreType
        {
            get
            {
                return _storeType;
            }
            set
            {
                _storeType = value;
                OnPropertyChanged(nameof(StoreType));
            }
        }

        private ObservableCollection<ContactsModel> _area;
        public ObservableCollection<ContactsModel> Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
                OnPropertyChanged(nameof(Area));
            }
        }

        private ContactoModel _contact;
        public ContactoModel Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        ObservableCollection<ContactoModel> _contacts;
        public ObservableCollection<ContactoModel> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }

        private int _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        
        private string _names;
        public string Names
        {
            get
            {
                return _names;
            }
            set
            {
                _names = value;
                OnPropertyChanged("Names");
            }
        }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _secondName;
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set
            {
                _secondName = value;
                OnPropertyChanged("SecondName");
            }
        }

        private string _cel;
        public string Cel
        {
            get
            {
                return _cel;
            }
            set
            {
                _cel = value;
                OnPropertyChanged("Cel");
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        private string _position;
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
                OnPropertyChanged("Position");
            }
        }

        private string _branch;
        public string Branch
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
                OnPropertyChanged("Branch");
            }
        }

        private string _store;
        public string Store
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
                OnPropertyChanged("Store");
            }
        }

        private ObservableCollection<ContactoModel> _result;
        public ObservableCollection<ContactoModel> Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        private ContactsModel _selectedStore;
        public ContactsModel SelectedStore
        {
            get
            {
                return _selectedStore;
            }
            set
            {
                _selectedStore = value;
                OnPropertyChanged("SelectedStore");
            }
        }

        private ContactsModel _selectedArea;
        public ContactsModel SelectedArea
        {
            get
            {
                return _selectedArea;
            }
            set
            {
                _selectedArea = value;
                OnPropertyChanged("SelectedArea");
            }
        }

        private ContactoModel _selectedData;
        public ContactoModel SelectedData
        {
            get
            {
                return _selectedData;
            }
            set
            {
                _selectedData = value;
                if (_selectedData != value)
                {
                    OnPropertyChanged("SelectedData");
                }

            }
        }

        //Commands
        public ICommand DeletedCommand { get; }
        public ICommand AddCommand { get; }
        public ContactsViewModel()
        {
            contactsRepository = new ContactsRepository();
            LoadStoreData();
            LoadAreaData();
            LoadDataGrid();

            DeletedCommand = new ViewModelCommand(ExecuteDeletedCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
        }
        //Methods
        public void LoadStoreData()
        {
            _storeType = contactsRepository.GetByStore();

        }

        public void LoadAreaData()
        {
            Area = contactsRepository.GetByArea();
        }

        public void LoadDataGrid()
        {
            Contacts = contactsRepository.GetByAll();
            
        }

        private void ExecuteDeletedCommand(object obj)
        {

            contactsRepository.Delete(ID);
            LoadDataGrid();

        }

        public void ExecuteAddCommand(object obj)
        {

            contactsRepository.Add(Names,  FirstName,  SecondName,  Cel,  Email,  Position, Convert.ToString(SelectedArea.Id), Convert.ToString(SelectedStore.Id));
            LoadDataGrid();
        }

        public void Update()
        {
            var Aux = this.SelectedData.GetType().GetProperty("Nombres");

        }
    }
}
