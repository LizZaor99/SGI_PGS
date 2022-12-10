using SGI.Models;
using SGI.Repositories;
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
        private IHomeRepository homeRepository;
        private string _currentDateTime;
        private int _tipoEq;
        private int _status;
        private HomeModel _counterlaptop;
        private HomeModel _counterequipment;
        private HomeModel _counterminiprint;
        private HomeModel _counterswitch;
        private HomeModel _counterstore;

        //Properties
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

        public HomeModel CounterLaptop
        {
            get
            {
                return _counterlaptop;
            }
            set
            {
                _counterlaptop = value;
                OnPropertyChanged(nameof(CounterLaptop));
            }
        }

        public HomeModel CounterEquipment
        {
            get
            {
                return _counterequipment;
            }
            set
            {
                _counterequipment = value;
                OnPropertyChanged(nameof(CounterEquipment));
            }
        }

        public HomeModel CounterMiniprint
        {
            get
            {
                return _counterminiprint;
            }
            set
            {
                _counterminiprint = value;
                OnPropertyChanged(nameof(CounterMiniprint));
            }
        }

        public HomeModel CounterSwitch
        {
            get
            {
                return _counterswitch;
            }
            set
            {
                _counterswitch = value;
                OnPropertyChanged(nameof(CounterSwitch));
            }
        }

        public HomeModel CounterStore
        {
            get
            {
                return _counterstore;
            }
            set
            {
                _counterstore = value;
                OnPropertyChanged(nameof(CounterStore));
            }
        }

        //Constructor
        public HomeViewModel()
        {
            homeRepository = new HomeRepository();
            CounterLaptop = new HomeModel();
            CounterEquipment = new HomeModel();
            CounterMiniprint = new HomeModel();
            CounterSwitch = new HomeModel();
            CounterStore = new HomeModel();
            LoadCountEquipmentData();
            LoadCountLaptopData();
            LoadCountMiniprintsData();
            LoadCountSwitchData();
            LoadCountOpenStorepData();
            GetCurrentDateTime();
        }

        //Functions
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
            this.CurrentDateTime = DateTime.Now.ToString("HH':'mm tt\ndddd, dd MMMM yyyy");
            CommandManager.InvalidateRequerySuggested();
        }

        private void LoadCountEquipmentData()
        {
            TipoEq = 107;
            Status = 6;

            var count = homeRepository.GetByStatus(TipoEq, Status);

            CounterEquipment.Display = $"\n {count} Equipos asignados";
        }
        private void LoadCountLaptopData()
        {
            TipoEq = 105;
            Status = 6;

            var count = homeRepository.GetByStatus(TipoEq, Status);

            CounterLaptop.Display = $"\n {count} Laptops asignadas";
        }
        private void LoadCountMiniprintsData()
        {
            TipoEq = 35;
            Status = 6;

            var count = homeRepository.GetByStatus(TipoEq, Status);

            CounterMiniprint.Display = $"\n {count} MiniPrints asignadas";
        }

        private void LoadCountSwitchData()
        {
            TipoEq = 41;
            Status = 6;

            var count = homeRepository.GetByStatus(TipoEq, Status);

            CounterSwitch.Display = $"\n {count} Switchs asignados";
        }

        private void LoadCountOpenStorepData()
        {
            var count = homeRepository.GetByStore();

            CounterStore.Display = $" \n {count} Caja Progressa abiertas";
        }
    }
}

