using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ExcedenteEnergiaEnFuncionamientoDto
    {
        //SECCIÓN DE REGISTRO
        [Required(ErrorMessage = "El tipo de entidad es obligatorio")]
        public TipoEntidad TipoEntidad { get; set; }

        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(100, ErrorMessage = "Los apellidos no pueden superar los 100 caracteres")]
        public string? Apellidos { get; set; }

        [StringLength(200, ErrorMessage = "El nombre de la empresa no puede superar los 200 caracteres")]
        public string? Empresa { get; set; }

        [StringLength(20, ErrorMessage = "El CIF no puede superar los 20 caracteres")]
        public string? CIF { get; set; }

        [StringLength(20, ErrorMessage = "El DNI no puede superar los 20 caracteres")]
        public string? DNI { get; set; }

        [StringLength(200, ErrorMessage = "El representante no puede superar los 200 caracteres")]
        public string? Representante { get; set; }

        [StringLength(200, ErrorMessage = "El nombre del representante no puede superar los 200 caracteres")]
        public string? NombreRepresentante { get; set; }

        [StringLength(200, ErrorMessage = "Los apellidos del representante no pueden superar los 200 caracteres")]
        public string? ApellidosRepresentante { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono no puede superar los 20 caracteres")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        public string? Telefono { get; set; }

        [StringLength(100, ErrorMessage = "El email no puede superar los 100 caracteres")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "El municipio no puede superar los 100 caracteres")]
        public string? Municipio { get; set; }

        [StringLength(100, ErrorMessage = "La provincia no puede superar los 100 caracteres")]
        public string? Provincia { get; set; }

        [StringLength(100, ErrorMessage = "El país no puede superar los 100 caracteres")]
        public string? Pais { get; set; }

        //FORMULARIO ENERGIA EN FUNCIONAMIENTO
        [Required(ErrorMessage = "El tipo de tecnología es obligatorio")]
        public TipoTecnologia TipoTecnologia { get; set; }

        public string? OtrasTecnologias { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.

        [Required(ErrorMessage = "La capacidad de producción de energía es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "La capacidad de producción debe ser mayor a 0")]
        public int? CapacidadProduccionEnergia { get; set; }

        [Required(ErrorMessage = "El excedente de energía es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El excedente de energía debe ser mayor a 0")]
        public int? ExcedenteEnergia { get; set; }

        [StringLength(20, ErrorMessage = "Las horas de excedente no pueden superar los 20 caracteres")]
        public string? HorasExcedenteEnergia { get; set; }

        [StringLength(20, ErrorMessage = "Los días de excedente no pueden superar los 20 caracteres")]
        public string? DiasExcedenteEnergia { get; set; }

        [Required(ErrorMessage = "La capacidad de producción es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "La capacidad de producción debe ser mayor a 0")]
        public int? CapacidadProduccion { get; set; }

        public bool ProduceEnergia { get; set; }

        public DateOnly? FechaInicioProduccion { get; set; }

        public bool VierteEnergiaRed { get; set; } //Si es TRUE aparece nueva opción en el form (esto lo añadimos en el HTML @if)

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad que vierte debe ser mayor a 0")]
        public int? VierteEnergiaTrue { get; set; } //Si VierteEnergiaRed es TRUE, entonces se muestra este campo para indicar cuánto vierte.

        public bool Autoconsumo { get; set; }

        public string? PaisInstalacion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).

        public string? ProvinciaInstalacion { get; set; }

        public string? MunicipioInstalacion { get; set; }

        public string? Coordenadas { get; set; } //Coordenadas GPS de la instalación. Hay que saber si lo introduce con las coordenadas o a través de una dirección.

        public bool TieneLicencia { get; set; } //Si es TRUE indicar capacidad.

        [Range(1, int.MaxValue, ErrorMessage = "La capacidad de producción según licencia debe ser mayor a 0")]
        public int? CapacidadProduccionLicencia { get; set; } //Si TieneLicencia es TRUE, entonces indica la capacidad de producción según la licencia.

        public bool QuiereProducirConExcedente { get; set; }

        public string? AlquilarParteOTotalidad { get; set; }

        [StringLength(1000, ErrorMessage = "Las observaciones no pueden superar los 1000 caracteres")]
        public string? Observaciones { get; set; }
    }
}