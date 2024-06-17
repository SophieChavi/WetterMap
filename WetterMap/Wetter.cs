using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterMap
{
    public class Wetter
    {
        HttpClient _client;

        public Wetter()
        {
            _client = new HttpClient();
        }
        public async Task<WerteWetter> GetWerteWetter (string query)  
        {
            WerteWetter werteWetter = null;
            try
            {
                var wert = await _client.GetAsync(query);
                if (wert.IsSuccessStatusCode)
                {
                    var content = await wert.Content.ReadAsStringAsync();
                    werteWetter = JsonConvert.DeserializeObject<WerteWetter>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return werteWetter;
        }
    }
}
