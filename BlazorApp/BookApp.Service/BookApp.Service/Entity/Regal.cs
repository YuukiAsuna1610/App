using MauiBookApp.Enum;
using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class Regal
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("RegalArt")]
        public RegalArt RegalArt { get; set; }
        
        public Regal() 
        { 
        }
    }
}
