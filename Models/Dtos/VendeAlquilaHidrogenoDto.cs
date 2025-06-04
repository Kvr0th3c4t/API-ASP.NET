using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class VendeAlquilaHidrogenoDto
    {
        // SECCIÓN DE REGISTRO
        [Required(ErrorMessage = "El tipo de entidad es obligatorio")]
        public TipoEntidad TipoEntidad { get; set; }

        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(100, ErrorMessage = "Los apellidos no pueden exceder 100 caracteres")]
        public string? Apellidos { get; set; }

        [StringLength(200, ErrorMessage = "La empresa no puede exceder 200 caracteres")]
        public string? Empresa { get; set; }

        [StringLength(20, ErrorMessage = "El CIF no puede exceder 20 caracteres")]
        public string? CIF { get; set; }

        [StringLength(20, ErrorMessage = "El DNI no puede exceder 20 caracteres")]
        public string? DNI { get; set; }

        [StringLength(200, ErrorMessage = "El representante no puede exceder 200 caracteres")]
        public string? Representante { get; set; }

        [StringLength(200, ErrorMessage = "El nombre del representante no puede exceder 200 caracteres")]
        public string? NombreRepresentante { get; set; }

        [StringLength(200, ErrorMessage = "Los apellidos del representante no pueden exceder 200 caracteres")]
        public string? ApellidosRepresentante { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono no puede exceder 20 caracteres")]
        public string? Telefono { get; set; }

        [StringLength(100, ErrorMessage = "El email no puede exceder 100 caracteres")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "El municipio no puede exceder 100 caracteres")]
        public string? Municipio { get; set; }

        [StringLength(100, ErrorMessage = "La provincia no puede exceder 100 caracteres")]
        public string? Provincia { get; set; }

        [StringLength(100, ErrorMessage = "El país no puede exceder 100 caracteres")]
        public string? Pais { get; set; }

        // FORMULARIO VENTA/ALQUILER HIDRÓGENO
        [Range(1, int.MaxValue, ErrorMessage = "Los metros cuadrados deben ser mayor a 0")]
        public int? MetrosCuadradosTerreno { get; set; }

        [Required(ErrorMessage = "El tipo de terreno es obligatorio")]
        public TipoTerreno TipoTerreno { get; set; }

        public bool? TieneLicencia { get; set; } //Si es TRUE indicar cuál

        public string? Licencia { get; set; } //opciones múltiples: energía solar, energía eólica, biomasa, hidroeléctrica, hidrógeno verde, metanol verde, amoniaco verde.

        public string? VenderAlquilar { get; set; } //Si es alquilar indicar años de alquiler.

        [Range(1, 99, ErrorMessage = "Los años de alquiler deben estar entre 1 y 99")]
        public int? AnosAlquiler { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El precio de alquiler debe ser mayor o igual a 0")]
        public int PrecioAlquiler { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El precio de venta debe ser mayor o igual a 0")]
        public int PrecioVenta { get; set; }

        public string? PaisAlVen { get; set; }

        [StringLength(100, ErrorMessage = "La provincia no puede exceder 100 caracteres")]
        public string? ProvinciaAlVen { get; set; }

        [StringLength(100, ErrorMessage = "El municipio no puede exceder 100 caracteres")]
        public string? MunicipioAlVen { get; set; }

        public string? Coordenadas { get; set; }

        public string? Observaciones { get; set; }
    }
}