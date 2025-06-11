// Models/DTOs/UserUpdateDto.cs
using BlogSystem.API.Models.Enums;

namespace BlogSystem.API.Models.DTOs
{
    public class UserUpdateDto
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public TipoEntidad? TipoEntidad { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Empresa { get; set; }
        public string? CIF { get; set; }
        public string? DNI { get; set; }
        public string? Representante { get; set; }
        public string? NombreRepresentante { get; set; }
        public string? ApellidosRepresentante { get; set; }
        public string? Telefono { get; set; }
        public string? Municipio { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }
        public bool? Activo { get; set; }
    }
}