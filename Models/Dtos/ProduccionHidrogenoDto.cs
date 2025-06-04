using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class ProduccionHidrogenoDto
    {
        // SECCIÓN DE REGISTRO
        [Required(ErrorMessage = "El tipo de entidad es obligatorio")]
        public TipoEntidad TipoEntidad { get; set; }

        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(100, ErrorMessage = "Los apellidos no pueden exceder los 100 caracteres")]
        public string? Apellidos { get; set; }

        [StringLength(200, ErrorMessage = "El nombre de la empresa no puede exceder los 200 caracteres")]
        public string? Empresa { get; set; }

        [StringLength(20, ErrorMessage = "El CIF no puede exceder los 20 caracteres")]
        public string? CIF { get; set; }

        [StringLength(20, ErrorMessage = "El DNI no puede exceder los 20 caracteres")]
        public string? DNI { get; set; }

        [StringLength(200, ErrorMessage = "El representante no puede exceder los 200 caracteres")]
        public string? Representante { get; set; }

        [StringLength(200, ErrorMessage = "El nombre del representante no puede exceder los 200 caracteres")]
        public string? NombreRepresentante { get; set; }

        [StringLength(200, ErrorMessage = "Los apellidos del representante no pueden exceder los 200 caracteres")]
        public string? ApellidosRepresentante { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono no puede exceder los 20 caracteres")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        public string? Telefono { get; set; }

        [StringLength(100, ErrorMessage = "El email no puede exceder los 100 caracteres")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "El municipio no puede exceder los 100 caracteres")]
        public string? Municipio { get; set; }

        [StringLength(100, ErrorMessage = "La provincia no puede exceder los 100 caracteres")]
        public string? Provincia { get; set; }

        [StringLength(100, ErrorMessage = "El país no puede exceder los 100 caracteres")]
        public string? Pais { get; set; }

        // FORMULARIO PRODUCCIÓN HIDRÓGENO
        public bool InstalacionConstruida { get; set; }

        [Required(ErrorMessage = "El tipo de tecnología es obligatorio")]
        public TipoTecnologia TipoTecnologia { get; set; }

        [StringLength(500, ErrorMessage = "La descripción de otras tecnologías no puede exceder los 500 caracteres")]
        public string? OtrasTecnologias { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad de kilogramos por hora debe ser mayor o igual a 0")]
        public int CuantoKiloGramosHora { get; set; }

        public bool Autoconsumo { get; set; }

        [Required(ErrorMessage = "El tipo de sector de producción es obligatorio")]
        public TipoSectorProduccion TipoSectorProduccion { get; set; }

        [StringLength(200, ErrorMessage = "La selección de movilidad no puede exceder los 200 caracteres")]
        public string? MovilidadSelect { get; set; } //Si el tipo de sector es MOVILIDAD, entonces se muestra este campo para indicar el tipo de movilidad.

        [StringLength(200, ErrorMessage = "La selección residencial no puede exceder los 200 caracteres")]
        public string? ResidencialSelect { get; set; } //Si el tipo de sector es RESIDENCIAL, entonces se muestra este campo para indicar el tipo de residencial.

        [StringLength(200, ErrorMessage = "La selección industrial no puede exceder los 200 caracteres")]
        public string? IndustrialSelect { get; set; } //Si el tipo de sector es INDUSTRIAL, entonces se muestra este campo para indicar el tipo de industrial.

        [StringLength(200, ErrorMessage = "La selección de distribución no puede exceder los 200 caracteres")]
        public string? DistribucionSelect { get; set; } //Si el tipo de sector es DISTRIBUCIÓN, entonces se muestra este campo para indicar el tipo de distribución.

        [StringLength(200, ErrorMessage = "La descripción del otro sector no puede exceder los 200 caracteres")]
        public string? OtroSector { get; set; } //Si el tipo de sector es OTRO, entonces se muestra este campo para indicar cuál es el otro sector.

        [StringLength(100, ErrorMessage = "El país de producción no puede exceder los 100 caracteres")]
        public string? PaisProduccion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100, ErrorMessage = "La provincia de producción no puede exceder los 100 caracteres")]
        public string? ProvinciaProduccion { get; set; }

        [StringLength(100, ErrorMessage = "El municipio de producción no puede exceder los 100 caracteres")]
        public string? MunicipioProduccion { get; set; }

        [StringLength(100, ErrorMessage = "El país de consumición no puede exceder los 100 caracteres")]
        public string? PaisConsumicion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100, ErrorMessage = "La provincia de consumición no puede exceder los 100 caracteres")]
        public string? ProvinciaConsumicion { get; set; }

        [StringLength(100, ErrorMessage = "El municipio de consumición no puede exceder los 100 caracteres")]
        public string? MunicipioConsumicion { get; set; }

        public bool MetanolVerde { get; set; }

        public bool EquiposProducir { get; set; }

        public bool EquiposAlmacenar { get; set; }

        public bool OtraTecnologia { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string? IndicarCual { get; set; } //Indicar si es otra, cuál.

        public bool NecesitaEmpresa { get; set; } //Si es TRUE, país, provincia y municipio

        [StringLength(100, ErrorMessage = "El país necesario no puede exceder los 100 caracteres")]
        public string? PaisNecesita { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        [StringLength(100, ErrorMessage = "La provincia necesaria no puede exceder los 100 caracteres")]
        public string? ProvinciaNecesita { get; set; }

        [StringLength(100, ErrorMessage = "El municipio necesario no puede exceder los 100 caracteres")]
        public string? MunicipioNecesita { get; set; }

        [Range(0, 2000, ErrorMessage = "Los bares de hidrógeno deben estar entre 0 y 2000")]
        public int BaresHidrogeno { get; set; } //Desde 0 a 2000 con barrita en el HTML!

        public bool AlquilarTerrenoSinInstalaciones { get; set; } //Si es TRUE, seleccionar años de alquiler.

        [Range(0, 100, ErrorMessage = "Los años de alquiler deben estar entre 0 y 100")]
        public int AnosAlquiler { get; set; }

        public bool AlquilarTerrenoConInstalaciones { get; set; } //Si es TRUE, seleccionar años de alquiler.

        public TipoTecnologia? TipoTecnologiaAlquiler { get; set; }

        [StringLength(500, ErrorMessage = "La descripción de otras tecnologías de alquiler no puede exceder los 500 caracteres")]
        public string? OtrasTecnologiasAlquiler { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.

        public bool ContratarPPA { get; set; }

        public bool AyudaProveedorPPA { get; set; }

        public bool ProporcionClientes { get; set; }

        public bool RedEmpresas { get; set; }

        public bool RedHidrogeneras { get; set; }

        public bool RedPuntosDispensacion { get; set; }

        public bool TramitacionSolicitudes { get; set; }

        [DataType(DataType.Date, ErrorMessage = "La fecha debe tener un formato válido")]
        public DateOnly? FechaHidrogenoDisponible { get; set; }

        [StringLength(2000, ErrorMessage = "Las observaciones no pueden exceder los 2000 caracteres")]
        public string? Observaciones { get; set; }
    }
}