using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class VendeAlquilaHidrogenoDto
    {

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