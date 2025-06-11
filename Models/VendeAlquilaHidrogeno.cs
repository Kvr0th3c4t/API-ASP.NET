using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSystem.API.Models
{
    public class VendeAlquilaHidrogeno
    {
        [Key]
        public int Id { get; set; }

        // AGREGAR: Foreign key hacia User
        [Required]
        public int UserId { get; set; }

        // AGREGAR: Navigation property hacia User
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        // FORMULARIO VENTA/ALQUILER HIDRÓGENO (tu código existente sin cambios)
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