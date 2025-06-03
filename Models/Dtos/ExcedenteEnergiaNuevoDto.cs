using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ExcedenteEnergiaNuevoDto
    {
            [Required]
            public TipoEntidad TipoEntidad { get; set; }

            [StringLength(100)]
            public string? Nombre { get; set; }

            [StringLength(100)]
            public string? Apellidos { get; set; }

            [StringLength(200)]
            public string? Empresa { get; set; }

            [StringLength(20)]
            public string? CIF { get; set; }

            [StringLength(20)]
            public string? DNI { get; set; }

            [StringLength(200)]
            public string? Representante { get; set; }

            [StringLength(200)]
            public string? NombreRepresentante { get; set; }

            [StringLength(200)]
            public string? ApellidosRepresentante { get; set; }

            [StringLength(20)]
            public string? Telefono { get; set; }

            [StringLength(100)]
            public string? Email { get; set; }

            [StringLength(100)]
            public string? Municipio { get; set; }

            [StringLength(100)]
            public string? Provincia { get; set; }

            [StringLength(100)]
            public string? Pais { get; set; }

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