using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace DNP_Assignment1.Data.Services.UserServices
{
    public class CloudUserService : IUserService
    {
        
        private readonly HttpClient client;
        private string uri = "http://localhost:1234/user/";
        
        public CloudUserService()
        {
            client = new HttpClient();
        }
        
        public async Task<User> ValidateUserAsync(string email, string password)
        {
            HttpResponseMessage response = await client.GetAsync(uri+email+","+password);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson);
                return resultUser;
            } 
            throw new Exception("User not found");
        }

        public async Task AddUserAsync(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}