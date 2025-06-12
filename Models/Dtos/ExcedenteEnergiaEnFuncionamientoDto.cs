using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ExcedenteEnergiaEnFuncionamientoDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public TipoTecnologia TipoTecnologia { get; set; }
        public string? OtrasTecnologias { get; set; }
        public int? CapacidadProduccionEnergia { get; set; }
        public int? ExcedenteEnergia { get; set; }
        public string? HorasExcedenteEnergia { get; set; }
        public string? DiasExcedenteEnergia { get; set; }
        public int? CapacidadProduccion { get; set; }
        public bool ProduceEnergia { get; set; }
        public DateOnly? FechaInicioProduccion { get; set; }
        public bool VierteEnergiaRed { get; set; }
        public int? VierteEnergiaTrue { get; set; }
        public bool Autoconsumo { get; set; }
        public string? PaisInstalacion { get; set; }
        public string? ProvinciaInstalacion { get; set; }
        public string? MunicipioInstalacion { get; set; }
        public string? Coordenadas { get; set; }
        public bool TieneLicencia { get; set; }
        public int? CapacidadProduccionLicencia { get; set; }
        public bool QuiereProducirConExcedente { get; set; }
        public string? AlquilarParteOTotalidad { get; set; }
        public string? Observaciones { get; set; }
    }
}