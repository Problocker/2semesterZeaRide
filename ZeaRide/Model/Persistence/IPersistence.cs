using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    interface IPersistence
    {
        // Denne del er til Samkørsel
        Task<ICollection<Samkørsel>> LoadSamkørsel();
        void SaveSamkørsels(ICollection<Samkørsel> samkørsels);

        Task<bool> CreateSamkørsel(Samkørsel samkørsel);

        // Denne del er til Bruger
        //Task<ICollection<Bruger>> LoadBruger();

        //Task<bool> CreateBruger(Bruger bruger);
    }
}
