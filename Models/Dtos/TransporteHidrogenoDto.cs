using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class TransporteHidrogenoDto
    {

        // FORMULARIO TRANSPORTE HIDRÓGENO
        public bool LicenciaMercanciaPeligrosa { get; set; } //Si es FALSE aparece opcion de asesoramiento.

        public bool FalseLicenciaAsesoramiento { get; set; }

        [Required(ErrorMessage = "El tipo de transporte es obligatorio")]
        public TipoTransporte TipoTransporte { get; set; }

        public bool TieneCaminonesHidrogeno { get; set; }

        public bool TieneCamionesMetanol { get; set; }

        public bool TieneCamionesAmoniaco { get; set; }

        public bool RedTransporte { get; set; } //Si es TRUE seleccionar qué red nacional, local, provincial, internacional, regional.

        public string? TipoRed { get; set; } //Seleccion en HTML.

        public string? TipoTransporteHidrogeno { get; set; } //Seleccion liquido o gas en el HTML.

        public string? PresionHidrogeno { get; set; } //Select para baja presion, 200 bar, 350 bar, 700 bar, 1000 bar.

        [StringLength(100, ErrorMessage = "El municipio de transporte no puede exceder 100 caracteres")]
        public string? MunicipioTransporte { get; set; }

        [StringLength(100, ErrorMessage = "La provincia de transporte no puede exceder 100 caracteres")]
        public string? ProvinciaTransporte { get; set; }

        [StringLength(100, ErrorMessage = "El país de transporte no puede exceder 100 caracteres")]
        public string? PaisTransporte { get; set; }

        public bool NecesitaFormacion { get; set; }

        public string? Observaciones { get; set; }
    }
}