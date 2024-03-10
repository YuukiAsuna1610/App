using MauiBookApp.Enum;
using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class Buch
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Titel")]
        public string Titel { get; set; }

        [JsonPropertyName("Untertitel")]
        public string Untertitel { get; set; }

        [JsonPropertyName("Seiten")]
        public int Seiten { get; set; }

        [JsonPropertyName("Stunden")]
        public int Stunden { get; set; }

        [JsonPropertyName("Minuten")]
        public int Minuten { get; set; }

        [JsonPropertyName("Format")]
        public BuchFormat Format { get; set; }

        [JsonPropertyName("Sprache")]
        public BuchSprachen Sprache { get; set; }

        [JsonPropertyName("Verlag")]
        public Verlag Verlag { get; set; }

        [JsonPropertyName("Autor")]
        public Autor Autor { get; set; }

        [JsonPropertyName("Bewertung")]
        public double Bewertung { get; set; }

        [JsonPropertyName("ISBN")]
        public string ISBN { get; set; }

        [JsonPropertyName("Veroeffentlichung")]
        public DateTime Veroeffentlichung { get; set; }

        // Schuber
        [JsonPropertyName("SchuberBuecher")]
        public List<Buch> SchuberBuecher { get; set; }

        [JsonPropertyName("SchuberBuecherAnzahl")]
        public int SchuberBuecherAnzahl { get; set; }

        // Reihen
        [JsonPropertyName("BuecherReihe")]
        public List<Buch> BuecherReihe { get; set; }

        [JsonPropertyName("BuecherReiheNr")]
        public int BuecherReiheNr { get; set; }

        public Buch() { }
    }
}
