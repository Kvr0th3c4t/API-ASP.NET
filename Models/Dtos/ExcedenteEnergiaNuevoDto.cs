using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ExcedenteEnergiaNuevoDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }

        // Solo los campos del formulario, SIN la navigation property User
        public bool InstalacionConstruida { get; set; }
        public DateOnly? InstalacionContruidaFalse { get; set; }
        public bool InstalacionEnConstruccion { get; set; }
        public DateOnly? InstalacionEnConstruccionTrue { get; set; }
        public int? KwTotalesProduccion { get; set; }
        public TipoTecnologia TipoTecnologia { get; set; }
        public string? OtrasTecnologias { get; set; }
        public bool DestinaInstalacion { get; set; }
        public int? KwDestinados { get; set; }
        public string? NumeroHoras { get; set; }
        public string? PaisInstalacion { get; set; }
        public string? ProvinciaInstalacion { get; set; }
        public string? MunicipioInstalacion { get; set; }
        public string? Coordenadas { get; set; }
        public bool TieneLicencia { get; set; }
        public int? CapacidadProduccionLicencia { get; set; }
        public bool QuierePersonalTramitar { get; set; }
        public bool QuiereProducirConExcedente { get; set; }
        public bool AlquilarInstalaciones { get; set; }
        public int? AnosAlquiler { get; set; }
    }
}