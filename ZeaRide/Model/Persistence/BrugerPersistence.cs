using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZeaRide.Model.Persistence
{
    class BrugerPersistence
    {
        private string URI = "http://localhost:56230/api/Brugers/";

        public async Task<bool> CreateBruger(Bruger bruger)
        {
            bool ok = false;

            using (HttpClient client = new HttpClient())
            {
                String jString = JsonConvert.SerializeObject(bruger);
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


        public async Task<ICollection<Bruger>> LoadBruger()
        {
            List<Bruger> liste;

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(URI);
                liste = JsonConvert.DeserializeObject<List<Bruger>>(json);
            }

            return liste;
        }

    }
}
