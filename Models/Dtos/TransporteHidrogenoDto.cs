using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class TransporteHidrogenoDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public bool LicenciaMercanciaPeligrosa { get; set; }
        public bool FalseLicenciaAsesoramiento { get; set; }
        public TipoTransporte TipoTransporte { get; set; }
        public bool TieneCaminonesHidrogeno { get; set; }
        public bool TieneCamionesMetanol { get; set; }
        public bool TieneCamionesAmoniaco { get; set; }
        public bool RedTransporte { get; set; }
        public string? TipoRed { get; set; }
        public string? TipoTransporteHidrogeno { get; set; }
        public string? PresionHidrogeno { get; set; }
        public string? MunicipioTransporte { get; set; }
        public string? ProvinciaTransporte { get; set; }
        public string? PaisTransporte { get; set; }
        public bool NecesitaFormacion { get; set; }
        public string? Observaciones { get; set; }
    }
}