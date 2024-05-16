using MAUIBuscaCep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MAUIBuscaCep.Services
{
    internal class DataService
    {
        public static async Task<Endereco> GetEnderecoCep(string cep)
        {
            Endereco endereco;
            using(HttpClient httpClient = new HttpClient())
            {
                string url = "https://cep.metoda.com.br/endereco/by-cep?cep=" + cep;

                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    endereco = JsonConvert.DeserializeObject<Endereco>(json);
                }
                else throw new Exception(response.RequestMessage.Content.ToString());
            }

            return endereco;
        }
    }
}
