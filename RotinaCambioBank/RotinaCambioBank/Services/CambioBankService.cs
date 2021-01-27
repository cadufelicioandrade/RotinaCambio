using Newtonsoft.Json;
using RotinaCambioBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Services
{
    public class CambioBankService
    {
        const string URI = "http://localhost:5000/api/";
        

        public CambioBankService()
        {

        }

        public async Task<Fila> GetItemFila()
        {
            Fila itemFila = new Fila();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(String.Concat(URI, "Fila/")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var itemJsonString = await response.Content.ReadAsStringAsync();
                        itemFila = JsonConvert.DeserializeObject<Fila>(itemJsonString);
                    }
                }
            }

            return itemFila;
        }
    }
}
