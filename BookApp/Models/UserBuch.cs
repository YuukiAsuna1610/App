using MauiBookApp.Enum;
using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class UserBuch
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Bewertung")]
        public double Bewertung { get; set; }

        [JsonPropertyName("GelesenVon")]
        public DateTime GelesenVon { get; set; }

        [JsonPropertyName("GelesenBis")]
        public DateTime GelesenBis { get; set; }

        [JsonPropertyName("Regale")]
        public List<Regal> Regale { get; set; }

        [JsonPropertyName("Rezension")]
        public string Rezension {  get; set; }

        [JsonPropertyName("PlattformEbook")]
        public PlattformEbook PlattformEbook { get; set; }

        [JsonPropertyName("PlattformHoerbuch")]
        public PlattformHoerbuch PlattformHoerbuch { get; set; }

        [JsonPropertyName("UserBuchStatus")]
        public UserBuchStatus UserBuchStatus { get; set; }

        [JsonPropertyName("Signiert")]
        public bool Signiert {  get; set; }

        public UserBuch() 
        {
        }
    }
}
