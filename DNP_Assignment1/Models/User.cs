using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
        
        [JsonPropertyName("firstName")]
        public string FisrtName { get; set; }
        
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}