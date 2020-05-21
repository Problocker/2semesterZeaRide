using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    public enum PersistenceType
    {
        Simple,
        File,
        Database
    };

    static class PersitenceFactory
    {
        public static IPersistence GetPersistency(PersistenceType peristenceType)
        {
            switch (peristenceType)
            {
                case PersistenceType.Simple: return new SimplePersistence();

                // File
                case PersistenceType.File: return new FilePersistence();

                // Database
                case PersistenceType.Database: return new SamkørselPersistence();

                default: return new SimplePersistence();
            }
        }
    }
}
