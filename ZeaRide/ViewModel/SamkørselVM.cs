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
        private Samkørsel _skabesSamkørsel;
        private ICommand _opret;

        private IPersistence _persistence;
        //private SamkørselPersistence _samkørselPersistence; 

        public SamkørselVM()
        {
            _samkørsels = new ObservableCollection<Samkørsel>();
            _skabesSamkørsel = new Samkørsel();

            _opret = new RelayCommand(CreateSamkørsel);

            _persistence = PersitenceFactory.GetPersistency(PersistenceType.Database);
        }

        private Samkørsel SkabSamkørelse
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

        public ICommand SkabSamkørsel => _opret;

        
        private async void CreateSamkørsel()
        {
            if (_skabesSamkørsel != null && _skabesSamkørsel.samkørselId != -1)
            {
                await _persistence.CreateSamkørsel(_skabesSamkørsel);
                _samkørsels.Add(_skabesSamkørsel);
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
