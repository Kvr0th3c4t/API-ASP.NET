using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSystem.API.Models
{
    public class ProduccionHidrogeno
    {
        [Key]
        public int Id { get; set; }

        // SECCIÓN DE REGISTRO
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

        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

        // FORMULARIO PRODUCCIÓN HIDRÓGENO
        public bool InstalacionConstruida { get; set; }

        [Required]
        public TipoTecnologia TipoTecnologia { get; set; }

        [StringLength(500)]
        public string? OtrasTecnologias { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.

        public int CuantoKiloGramosHora { get; set; }

        public bool Autoconsumo { get; set; }

        [Required]
        public TipoSectorProduccion TipoSectorProduccion { get; set; }

        [StringLength(200)]
        public string? MovilidadSelect { get; set; } //Si el tipo de sector es MOVILIDAD, entonces se muestra este campo para indicar el tipo de movilidad.

        [StringLength(200)]
        public string? ResidencialSelect { get; set; } //Si el tipo de sector es RESIDENCIAL, entonces se muestra este campo para indicar el tipo de residencial.

        [StringLength(200)]
        public string? IndustrialSelect { get; set; } //Si el tipo de sector es INDUSTRIAL, entonces se muestra este campo para indicar el tipo de industrial.

        [StringLength(200)]
        public string? DistribucionSelect { get; set; } //Si el tipo de sector es DISTRIBUCIÓN, entonces se muestra este campo para indicar el tipo de distribución.

        [StringLength(200)]
        public string? OtroSector { get; set; } //Si el tipo de sector es OTRO, entonces se muestra este campo para indicar cuál es el otro sector.

        [StringLength(100)]
        public string? PaisProduccion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100)]
        public string? ProvinciaProduccion { get; set; }

        [StringLength(100)]
        public string? MunicipioProduccion { get; set; }

        [StringLength(100)]
        public string? PaisConsumicion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100)]
        public string? ProvinciaConsumicion { get; set; }

        [StringLength(100)]
        public string? MunicipioConsumicion { get; set; }

        public bool MetanolVerde { get; set; }

        public bool EquiposProducir { get; set; }

        public bool EquiposAlmacenar { get; set; }

        public bool OtraTecnologia { get; set; }

        [StringLength(500)]
        public string? IndicarCual { get; set; } //Indicar si es otra, cuál.

        public bool NecesitaEmpresa { get; set; } //Si es TRUE, país, provincia y municipio

        [StringLength(100)]
        public string? PaisNecesita { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100)]
        public string? ProvinciaNecesita { get; set; }

        [StringLength(100)]
        public string? MunicipioNecesita { get; set; }

        public int BaresHidrogeno { get; set; } //Desde 0 a 2000 con barrita en el HTML!

        public bool AlquilarTerrenoSinInstalaciones { get; set; } //Si es TRUE, seleccionar años de alquiler.

        public int AnosAlquiler { get; set; }

        public bool AlquilarTerrenoConInstalaciones { get; set; } //Si es TRUE, seleccionar años de alquiler.

        public TipoTecnologia? TipoTecnologiaAlquiler { get; set; } 

        [StringLength(500)]
        public string? OtrasTecnologiasAlquiler { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.

        public bool ContratarPPA { get; set; }

        public bool AyudaProveedorPPA { get; set; }

        public bool ProporcionClientes { get; set; }

        public bool RedEmpresas { get; set; }

        public bool RedHidrogeneras { get; set; }

        public bool RedPuntosDispensacion { get; set; }

        public bool TramitacionSolicitudes { get; set; }

        public DateOnly? FechaHidrogenoDisponible { get; set; }

        [StringLength(2000)]
        public string? Observaciones { get; set; }
    }
}