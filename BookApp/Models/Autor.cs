using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class Autor
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        public Autor() {}
    }
}
