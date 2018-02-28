
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AGL.CodeChallenge.Data.Entities;
using Newtonsoft.Json;

namespace AGL.CodeChallenge.Utility
{
    /// <summary>
    /// Core logic to get json from provided web service url using HttpClient
    /// and deserializes the Json content to the list of type Person
    /// </summary>
    public static class PersonDataLoader
    {
        public static async Task<List<Person>> GetData(string personWebServiceUrl)
        {           
            using (var client = new HttpClient())
            using (var response = await client.GetAsync(personWebServiceUrl))
            using (var content = response.Content)
            {
                string json = await content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Person>>(json);
             
            }
        }
    }
}

