using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SGI.Models;
using SGI.Repositories;

namespace SGI.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    
    {
        private UserAccountModel _currentUserAccount;
        private IUserRepository userRepository;
        public UserAccountModel CurrentUserAccount { get { return _currentUserAccount; } set { _currentUserAccount = value; OnPropertyChanged(nameof(CurrentUserAccount)); } }
        
        public DashboardViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = user.usuario;
                CurrentUserAccount.DisplayName = $"{user.nombre} {user.primer_apellido}";
                CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                CurrentUserAccount.DisplayName = "Usuario invalido";
                //Hide child views.
            }
        }

    }
}
