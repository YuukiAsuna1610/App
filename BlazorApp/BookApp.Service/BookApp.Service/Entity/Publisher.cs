using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiBookApp.Models
{
    [Table("PublisherTable")]
    public class Verlag
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(200)]
        public string Name { get; set; }

        public Verlag() 
        { 
        }
    }
}
