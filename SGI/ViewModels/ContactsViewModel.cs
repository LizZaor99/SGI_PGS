using SGI.Models;
using SGI.Repositories;
using System.Collections.ObjectModel;
using System.Data;

namespace SGI.ViewModels
{
    public class ContactsViewModel : ViewModelBase
    {
        private IContactsRepository contactsRepository;
        private ObservableCollection<ContactsModel> _store;
        private ObservableCollection<ContactsModel> _area;

        //Properties
        public ObservableCollection<ContactsModel> TipoTienda
        {
            get
            {
                return _store;
            }
            set
            {
                _store = value;
                OnPropertyChanged(nameof(TipoTienda));
            }
        }

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

        //Constructor
        public ContactsViewModel()
        {
            contactsRepository = new ContactsRepository();
            LoadStoreData();
            LoadAreaData();
        }

        //Functions
        public void LoadStoreData()
        {
            TipoTienda = contactsRepository.GetByStore();
           
        }

        public void LoadAreaData()
        {
            Area = contactsRepository.GetByArea();
        }
    }
}
