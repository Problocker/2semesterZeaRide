using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    interface IPersistence
    {
        Task<ICollection<Samkørsel>> LoadSamkørsel();
        void SaveSamkørsels(ICollection<Samkørsel> samkørsels);

        Task<bool> CreateSamkørsel(Samkørsel samkørsel);
    }
}
