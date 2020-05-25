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
    class SamkørselVM:INotifyPropertyChanged
    {
        // Nikolaj - indtil videre arbejdes der kun på at oprette en samkørsel
        // da det kun er den userstory der fokuseres på i denne omgang.

        private ObservableCollection<Samkørsel> _samkørsels;
        private Samkørsel _selectedSamkørsel;
        private Samkørsel _skabesSamkørsel;
        private ICommand _load;
        private ICommand _opret;

        private IPersistence _persistence;

        public SamkørselVM()
        {
            _samkørsels = new ObservableCollection<Samkørsel>();
            _selectedSamkørsel = new Samkørsel(); 
            _skabesSamkørsel = new Samkørsel();
            _skabesSamkørsel.dato = DateTime.Now;
            //_skabesSamkørsel.tid = TimeSpan

            _load = new RelayCommand(LoadSamkørsel);
            _opret = new RelayCommand(CreateSamkørsel);

            _persistence = PersitenceFactory.GetPersistency(PersistenceType.Database);
        }

        public Samkørsel SelectedSamkørsel
        {
            get => _selectedSamkørsel;
            set
            {
                if (Equals(value, _selectedSamkørsel)) return;
                _selectedSamkørsel = value;
                OnPropertyChanged();
            }
        }

        public Samkørsel SkabSamkørelse
        {
            get => _skabesSamkørsel;
            set
            {
                if (Equals(value, _skabesSamkørsel)) return;
                _skabesSamkørsel = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Samkørsel> Samkørsels => _samkørsels;

        public ICommand Load => _load;
        
        public ICommand SkabSamkørsel => _opret;

        private async void LoadSamkørsel()
        {
            _samkørsels.Clear();
            var liste = await _persistence.LoadSamkørsel();
            foreach (Samkørsel s in liste)
            {
                _samkørsels.Add(s);
            }
        }
        
        private async void CreateSamkørsel()
        {
            if (_skabesSamkørsel != null && _skabesSamkørsel.samkorselId != -1)
            {
                await _persistence.CreateSamkørsel(_skabesSamkørsel);
                //_samkørsels.Add(_skabesSamkørsel);
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
