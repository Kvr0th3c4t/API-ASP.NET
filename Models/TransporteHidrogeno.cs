using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class TransporteHidrogeno
    {
        [Key]
        public int Id { get; set; }

        // FORMULARIO TRANSPORTE HIDRÓGENO
        public bool LicenciaMercanciaPeligrosa { get; set; } //Si es FALSE aparece opcion de asesoramiento.
        public bool FalseLicenciaAsesoramiento { get; set; }
        public TipoTransporte TipoTransporte { get; set; }
        public bool TieneCaminonesHidrogeno { get; set; }
        public bool TieneCamionesMetanol { get; set; }
        public bool TieneCamionesAmoniaco { get; set; }
        public bool RedTransporte { get; set; } //Si es TRUE seleccionar qué red nacional, local, provincial, internacional, regional.
        public string? TipoRed { get; set; } //Seleccion en HTML.
        public string? TipoTransporteHidrogeno { get; set; } //Seleccion liquido o gas en el HTML.
        public string? PresionHidrogeno { get; set; } //Select para baja presion, 200 bar, 350 bar, 700 bar, 1000 bar.
        [StringLength(100)]
        public string? MunicipioTransporte { get; set; }
        [StringLength(100)]
        public string? ProvinciaTransporte { get; set; }
        [StringLength(100)]
        public string? PaisTransporte { get; set; }
        public bool NecesitaFormacion { get; set; }
        public string? Observaciones { get; set; }

    }
}
