using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class ProduccionHidrogenoDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        public bool InstalacionConstruida { get; set; }
        public TipoTecnologia TipoTecnologia { get; set; }
        public string? OtrasTecnologias { get; set; }
        public int CuantoKiloGramosHora { get; set; }
        public bool Autoconsumo { get; set; }
        public TipoSectorProduccion TipoSectorProduccion { get; set; }
        public string? MovilidadSelect { get; set; }
        public string? ResidencialSelect { get; set; }
        public string? IndustrialSelect { get; set; }
        public string? DistribucionSelect { get; set; }
        public string? OtroSector { get; set; }
        public string? PaisProduccion { get; set; }
        public string? ProvinciaProduccion { get; set; }
        public string? MunicipioProduccion { get; set; }
        public string? PaisConsumicion { get; set; }
        public string? ProvinciaConsumicion { get; set; }
        public string? MunicipioConsumicion { get; set; }
        public bool MetanolVerde { get; set; }
        public bool EquiposProducir { get; set; }
        public bool EquiposAlmacenar { get; set; }
        public bool OtraTecnologia { get; set; }
        public string? IndicarCual { get; set; }
        public bool NecesitaEmpresa { get; set; }
        public string? PaisNecesita { get; set; }
        public string? ProvinciaNecesita { get; set; }
        public string? MunicipioNecesita { get; set; }
        public int BaresHidrogeno { get; set; }
        public bool AlquilarTerrenoSinInstalaciones { get; set; }
        public int AnosAlquiler { get; set; }
        public bool AlquilarTerrenoConInstalaciones { get; set; }
        public TipoTecnologia? TipoTecnologiaAlquiler { get; set; }
        public string? OtrasTecnologiasAlquiler { get; set; }
        public bool ContratarPPA { get; set; }
        public bool AyudaProveedorPPA { get; set; }
        public bool ProporcionClientes { get; set; }
        public bool RedEmpresas { get; set; }
        public bool RedHidrogeneras { get; set; }
        public bool RedPuntosDispensacion { get; set; }
        public bool TramitacionSolicitudes { get; set; }
        public DateOnly? FechaHidrogenoDisponible { get; set; }
        public string? Observaciones { get; set; }
    }
}