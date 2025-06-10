using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ExcedenteEnergiaNuevoDto
    {

            // FORMULARIO ENERGIA
            public bool InstalacionConstruida { get; set; }

            // Convertir string de fecha a DateOnly
            public string? InstalacionContruidaFalse { get; set; }

            public bool InstalacionEnConstruccion { get; set; }

            // Convertir string de fecha a DateOnly
            public string? InstalacionEnConstruccionTrue { get; set; }

            public int? KwTotalesProduccion { get; set; }

            [Required]
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