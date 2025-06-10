using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(50)]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;

        [Required]
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

    }
}