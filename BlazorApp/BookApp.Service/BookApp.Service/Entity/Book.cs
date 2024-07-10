using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiBookApp.Models
{
    [Table("BookDB")]
    public class Buch
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Titel")]
        [MaxLength(264)]
        public string Titel { get; set; }

        [Column("Subtitle")]
        [MaxLength(264)]
        public string? Subtitle { get; set; }

        [Required]
        [Column("Format")]
        public int Format { get; set; }

        [Required]
        [Column("Language")]
        public int Language { get; set; }

        [Column("Page")]
        public int? Page { get; set; }

        [Column("Hours")]
        public decimal? Hours { get; set; }

        [Column("DateOfRelease")]
        public DateTime? DateOfRelease { get; set; }

        [Required]
        [Column("ISBN")]
        public string ISBN { get; set; }

        [Column("BandNr")]
        public int? BandNr { get; set; }

        [Required]    
        [Column("PublisherId")]
        public Guid PublisherId { get; set; }

        [Required]
        [Column("AuthorId")]
        public Guid AuthorId { get; set; }

        //[JsonPropertyName("Bewertung")]
        //public double Bewertung { get; set; }
 
        //// Schuber
        //[JsonPropertyName("SchuberBuecher")]
        //public List<Buch> SchuberBuecher { get; set; }

        //[JsonPropertyName("SchuberBuecherAnzahl")]
        //public int SchuberBuecherAnzahl { get; set; }

        //// Reihen
        //[JsonPropertyName("BuecherReihe")]
        //public List<Buch> BuecherReihe { get; set; }


        public Buch() 
        {
        }
    }
}
