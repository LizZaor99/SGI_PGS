using SGI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.Repositories
{
    public interface IContactsRepository
    {
        ObservableCollection<ContactsModel> GetByStore();
        ObservableCollection<ContactsModel> GetByArea();
    }
}
