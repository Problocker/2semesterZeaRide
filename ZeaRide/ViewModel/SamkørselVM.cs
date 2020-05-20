using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZeaRide.Model;
using ZeaRide.Model.Persistence;

namespace ZeaRide.ViewModel
{
    public class SamkørselVM
    {
        // Nikolaj - indtil videre arbejdes der kun på at oprette en samkørsel
        // da det kun er den userstory der fokuseres på i denne omgang.

        private ObservableCollection<Samkørsel> _samkørsel;
        private ICommand _opret;

        private IPersistence _persistence;





    }
}
