using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    interface IPersistence
    {
        Task<ICollection<Bruger>> LoadBruger();
        void SaveBruger(ICollection<Bruger> brugers);

        Task<bool> UpdateBruger(Bruger bruger);

        Task<bool> CreateBruger(Bruger bruger);

        Task<bool> DeleteBruger(Bruger bruger);

        Task<ICollection<Samkørsel>> LoadSamkørsel();
        void SaveSamkørsel(ICollection<Samkørsel> samkørsels);

        Task<bool> UpdateSamkørsel(Bruger bruger);

        Task<>
    }
}
