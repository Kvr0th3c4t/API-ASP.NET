using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class VendeAlquilaHidrogenoDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public int? MetrosCuadradosTerreno { get; set; }
        public TipoTerreno TipoTerreno { get; set; }
        public bool? TieneLicencia { get; set; }
        public string? Licencia { get; set; }
        public string? VenderAlquilar { get; set; }
        public int? AnosAlquiler { get; set; }
        public int? PrecioAlquiler { get; set; }
        public int? PrecioVenta { get; set; }
        public string? PaisAlVen { get; set; }
        public string? ProvinciaAlVen { get; set; }
        public string? MunicipioAlVen { get; set; }
        public string? Coordenadas { get; set; }
        public string? Observaciones { get; set; }
    }
}