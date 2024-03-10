using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class Leseliste
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Anzahl")]
        public int Anzahl { get; set; }

        [JsonPropertyName("User")]
        public User User { get; set; }

        public Leseliste() 
        { 
        }
    }
}
