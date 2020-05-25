using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZeaRide.Common;
using ZeaRide.Model;
using ZeaRide.Model.Persistence;

namespace ZeaRide.ViewModel
{
    class BrugerVM:INotifyPropertyChanged
    {
        private ObservableCollection<Bruger> _brugers;
        private Bruger _skabBruger;
        private ICommand _opret;

        private BrugerPersistence _persistence;
        //private IPersistence _persistence;

        public BrugerVM()
        {
            _brugers = new ObservableCollection<Bruger>();
            _skabBruger = new Bruger();

            _opret = new RelayCommand(CreateBruger);

            _persistence = new BrugerPersistence();
        }

        public Bruger SkabBruger
        {
            get => _skabBruger;
            set
            {
                if (Equals(value, _skabBruger)) return;
                _skabBruger = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Bruger> Brugers => _brugers;

        public ICommand SkabesBruger => _opret;

        private async void CreateBruger()
        {
            if (_skabBruger != null && _skabBruger.brugerId != -1)
            {
                await _persistence.CreateBruger(_skabBruger);
                _brugers.Add(_skabBruger);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
