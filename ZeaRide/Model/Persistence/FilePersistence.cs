using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ZeaRide.Model.Persistence
{
    class FilePersistence:IPersistence
    {
        private static StorageFolder folder = ApplicationData.Current.LocalFolder;
        private const String FileName = "SamkørslerFil.json";
        private List<Samkørsel> _cacheSamkørsels;

        public async Task<ICollection<Samkørsel>> LoadSamkørsel()
        {
            if (await DoesExists(FileName))
            {
                StorageFile dataFile = await folder.GetFileAsync(FileName);
                string dataJSON = await FileIO.ReadTextAsync(dataFile);

                _cacheSamkørsels = JsonConvert.DeserializeObject<List<Samkørsel>>(dataJSON);
            }
            _cacheSamkørsels = (_cacheSamkørsels == null) ? new List<Samkørsel>() : new List<Samkørsel>(_cacheSamkørsels);
            return _cacheSamkørsels;
        }

        public async void SaveSamkørsels(ICollection<Samkørsel> samkørsels)
        {
            _cacheSamkørsels = new List<Samkørsel>(samkørsels);

            StorageFile file;
            if (await DoesExists(FileName))
            {
                file = await folder.CreateFileAsync(FileName, CreationCollisionOption.ReplaceExisting);
            }
            else
            {
                file = await folder.CreateFileAsync(FileName);
            }

            await FileIO.WriteTextAsync(file, JsonConvert.SerializeObject(samkørsels));
        }

        public async Task<bool> CreateSamkørsel(Samkørsel samkørsel)
        {
            _cacheSamkørsels.Add(samkørsel);
            SaveSamkørsels(_cacheSamkørsels);
            return true;
        }

        private async Task<bool> DoesExists(String filename)
        {
            bool exists = false;
            IReadOnlyList<StorageFile> files = await folder.GetFilesAsync();
            foreach (StorageFile file in files)
            {
                if (file.Name == filename)
                {
                    return true; // exists 
                }
            }
            return exists;
        }
    }
}
