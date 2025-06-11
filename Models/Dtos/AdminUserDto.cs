// Models/DTOs/AdminUserDto.cs
using BlogSystem.API.Models.Enums;

namespace BlogSystem.API.Models.DTOs
{
    public class AdminUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public TipoEntidad TipoEntidad { get; set; }
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
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public DateTime CreatedAt { get; set; }

        // Contadores básicos (Angular puede usarlos o recalcular)
        public int TotalFormularios { get; set; }
        public int FormulariosExcedenteNuevo { get; set; }
        public int FormulariosExcedenteFuncionamiento { get; set; }
        public int FormulariosProduccionHidrogeno { get; set; }
        public int FormulariosTransporteHidrogeno { get; set; }
        public int FormulariosVentaAlquilerHidrogeno { get; set; }
    }
}