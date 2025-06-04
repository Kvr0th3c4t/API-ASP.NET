using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class VendeAlquilaHidrogeno
    {
        [Key]
        public int Id { get; set; }

        // SECCIÓN DE REGISTRO
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
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Municipio { get; set; }
        [StringLength(100)]
        public string? Provincia { get; set; }
        [StringLength(100)]
        public string? Pais { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public bool Activo { get; set; } = true;

        // FORMULARIO VENTA/ALQUILER HIDRÓGENO
        public int? MetrosCuadradosTerreno { get; set; }
        public TipoTerreno TipoTerreno { get; set; }
        public bool? TieneLicencia { get; set; } //Si es TRUE indicar cuál
        public string? Licencia { get; set; } //opciones múltiples: energía solar, energía eólica, biomasa, hidroeléctrica, hidrógeno verde, metanol verde, amoniaco verde.
        public string? VenderAlquilar { get; set; } //Si es alquilar indicar años de alquiler.
        public int? AnosAlquiler { get; set; }
        public int PrecioAlquiler { get; set; }
        public int PrecioVenta { get; set; }
        public string? PaisAlVen { get; set; }
        [StringLength(100)]
        public string? ProvinciaAlVen { get; set; }
        [StringLength(100)]
        public string? MunicipioAlVen { get; set; }
        public string? Coordenadas { get; set; }
        public string? Observaciones { get; set; }
    }
}