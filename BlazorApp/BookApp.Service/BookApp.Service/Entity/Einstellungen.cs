using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class Einstellungen
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Wunschliste")]
        public bool Wunschliste { get; set; }

        // Sprache

        public Einstellungen() 
        { 
        }
    }
}
