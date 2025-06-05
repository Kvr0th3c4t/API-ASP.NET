using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSystem.API.Models
{
    public class ContactoForm
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Motivo { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "datetime2(0)")] //así se mostrará sin microsegundos en la bbdd
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
