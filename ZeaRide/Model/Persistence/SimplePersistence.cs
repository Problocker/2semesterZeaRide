using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    class SimplePersistence:IPersistence
    {
        // simple list in memory  disappear when shutting down the app
        private static List<Samkørsel> _samkørsels;

        //public SimplePersistence()
        //{
        //    _samkørsels = populateSamkørsels();
        //}


        public async Task<ICollection<Samkørsel>> LoadSamkørsel()
        {
            return new List<Samkørsel>(_samkørsels);
        }

        public void SaveSamkørsels(ICollection<Samkørsel> samkørsels)
        {
            _samkørsels.Clear();
            foreach (Samkørsel samkørsel in samkørsels)
            {
                _samkørsels.Add(samkørsel);
            }
        }

        public async Task<bool> CreateSamkørsel(Samkørsel samkørsel)
        {
            _samkørsels.Add(samkørsel);
            return true;
        }


    }
}
