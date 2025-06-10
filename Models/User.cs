using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;

        public TipoEntidad TipoEntidad { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(100)]
        public string? Apellidos { get; set; }

        [StringLength(200)]
        public string? Empresa { get; set; }

        [StringLength(20)]
        public string? CIF { get; set; }

        [StringLength(20)]
        public string? DNI { get; set; }

        [StringLength(200)]
        public string? Representante { get; set; }

        [StringLength(200)]
        public string? NombreRepresentante { get; set; }

        [StringLength(200)]
        public string? ApellidosRepresentante { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Municipio { get; set; }

        [StringLength(100)]
        public string? Provincia { get; set; }

        [StringLength(100)]
        public string? Pais { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Role { get; set; } = "user"; // "admin" o "user"

        //Datos para el blog
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navegación
        public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    }
}
