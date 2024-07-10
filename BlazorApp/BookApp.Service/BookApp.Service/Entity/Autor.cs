using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiBookApp.Models
{
    [Table("AutorDB")]
    public class Autor
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(150)]
        public string Name { get; set; }

        public Autor() 
        {
        }
    }
}
