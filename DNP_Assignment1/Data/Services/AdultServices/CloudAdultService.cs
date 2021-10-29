using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace DNP_Assignment1.Data.Services.AdultServices
{
    public class CloudAdultService : IAdultService
    {
        private string uri = "http://localhost:1234";
        private readonly HttpClient client;
        
        public CloudAdultService()
        {
            client = new HttpClient();
        }
        
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage reponse = await client.GetAsync(uri + "/Adult");
            if (!reponse.IsSuccessStatusCode)
            {
                throw new Exception("Error or whatever");
            }

            string message = await reponse.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri + "/Adult", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/Delete/{adultId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAdultAsync(int id,Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            Console.Out.WriteLine(adultAsJson);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PatchAsync($"{uri}/Update/{id}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
        

        public async Task<Adult> GetAdultAsync(int id)
        {
            HttpResponseMessage reponse = await client.GetAsync(uri + "/Adult/"+id);
            if (!reponse.IsSuccessStatusCode)
            {
                throw new Exception("Error or whatever");
            }

            string message = await reponse.Content.ReadAsStringAsync();
            Adult result = JsonSerializer.Deserialize<Adult>(message);
            return result;
        }
    }
}