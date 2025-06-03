using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class ExcedenteEnergiaEnFuncionamiento
    {
        [Key]
        public int Id { get; set; }

        //SECCIÓN DE REGISTRO
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

        //FORMULARIO ENERGIA EN FUNCIONAMIENTO
        [Required]
        public TipoTecnologia TipoTecnologia { get; set; }
        public string? OtrasTecnologias { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.
        [Required]
        public int? CapacidadProduccionEnergia { get; set; }
        [Required]
        public int? ExcedenteEnergia { get; set; }
        [StringLength(20)]
        public string? HorasExcedenteEnergia { get; set; }
        [StringLength(20)]
        public string? DiasExcedenteEnergia { get; set; }
        [Required]
        public int? CapacidadProduccion { get; set; }
        public bool ProduceEnergia { get; set; }
        public DateOnly? FechaInicioProduccion { get; set; }
        public bool VierteEnergiaRed { get; set; } //Si es TRUE aparece nueva opción en el form (esto lo añadimos en el HTML @if)
        public int? VierteEnergiaTrue { get; set; } //Si VierteEnergiaRed es TRUE, entonces se muestra este campo para indicar cuánto vierte.
        public bool Autoconsumo { get; set; }
        public string? PaisInstalacion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).
        public string? ProvinciaInstalacion { get; set; }
        public string? MunicipioInstalacion { get; set; }
        public string? Coordenadas { get; set; } //Coordenadas GPS de la instalación. Hay que saber si lo introduce con las coordenadas o a través de una dirección.
        public bool TieneLicencia { get; set; } //Si es TRUE indicar capacidad.
        public int? CapacidadProduccionLicencia { get; set; } //Si TieneLicencia es TRUE, entonces indica la capacidad de producción según la licencia.
        public bool QuiereProducirConExcedente { get; set; }
        public string? AlquilarParteOTotalidad { get; set; }
        public string? Observaciones { get; set; }
    }
}