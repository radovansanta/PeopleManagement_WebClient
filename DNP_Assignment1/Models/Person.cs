using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
public class Person {
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public string LastName { get; set; }
    [JsonPropertyName("hairColor")]
    public string HairColor { get; set; }
    [JsonPropertyName("eyeColor")]
    public string EyeColor { get; set; }
    [JsonPropertyName("age")]
    public int Age { get; set; }
    [JsonPropertyName("weight")]
    public float Weight { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("sex")]
    public string Sex { get; set; }
    [JsonPropertyName("profileUrl")]
    public string ProfileUrl { get; set; }
}


}