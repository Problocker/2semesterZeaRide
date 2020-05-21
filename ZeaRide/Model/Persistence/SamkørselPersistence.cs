using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ZeaRide.Model.Persistence
{
    class SamkørselPersistence:IPersistence
    {
        private string URI = "http://localhost:56230/api/Samkorsels";
        //public async Task<ICollection<Samkørsel>> LoadSamkørsels()
        //{
        //    List<Samkørsel> liste = new List<Samkørsel>();

        //    using (HttpClient client = new HttpClient())
        //    {
        //        string json = await client.GetStringAsync(URI);
        //        liste = JsonConvert.DeserializeObject<List<Samkørsel>>(json); 
        //    }

        //    return liste;
        //}

        public void SaveSamkørsels(ICollection<Samkørsel> samkørsels)
        {

        }

        public async Task<bool> CreateSamkørsel(Samkørsel samkørsel)
        {
            bool ok = false;

            using (HttpClient client = new HttpClient())
            {
                String jString = JsonConvert.SerializeObject(samkørsel);
                StringContent content = new StringContent(jString, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await client.PostAsync(URI, content);

                if (result.IsSuccessStatusCode)
                {
                    string okRes = await result.Content.ReadAsStringAsync();
                    ok = JsonConvert.DeserializeObject<bool>(okRes);
                }
            }
            return ok;
        }

        public async Task<ICollection<Samkørsel>> LoadSamkørsel()
        {
            List<Samkørsel> liste = new List<Samkørsel>();

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(URI);
                liste = JsonConvert.DeserializeObject<List<Samkørsel>>(json);
            }

            return liste;
        }

        //public async Task<Samkørsel> DeleteSamkørsel(Samkørsel samkørsel)
        //{
        //    Samkørsel hersamkørsel = null;

        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage result = await client.DeleteAsync(URI + "/" + samkørsel.samkørselId);

        //        if (result.IsSuccessStatusCode)
        //        {
        //            string json = await result.Content.ReadAsStringAsync();
        //            hersamkørsel = JsonConvert.DeserializeObject<Samkørsel>(json);
        //        }
        //    }
        //    return hersamkørsel;
        //}

    }
}
