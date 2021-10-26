using System.Text.Json.Serialization;
using DNP_Assignment1.Persistence;

namespace Models {
public class Adult : Person {
    
    [JsonPropertyName("jobTitle")]
    public Job JobTitle { get; set; }
}
}