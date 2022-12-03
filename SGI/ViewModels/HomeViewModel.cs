using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace SGI.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private string _currentDateTime;
       // private ViewModelBase _currentView;

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
            this.CurrentDateTime = DateTime.Now.ToString(" HH:mm tt");

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        /*public ViewModelBase CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value; OnPropertyChanged(nameof(CurrentView));
            }
        }
        public ICommand ShowTimeViewCommand { get; }
        public HomeViewModel()
        {
            ShowTimeViewCommand = new ViewModelCommand(ExecuteShowTimeViewCommand);
        }

        private void ExecuteShowTimeViewCommand(object obj)
        {
          //  CurrentView = new HomeViewModel();
            Systemtime = "Inicio";
        }*/

    }
}

