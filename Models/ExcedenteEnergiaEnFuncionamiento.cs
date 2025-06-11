using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSystem.API.Models
{
    public class ExcedenteEnergiaEnFuncionamiento
    {
        [Key]
        public int Id { get; set; }

        // AGREGAR: Foreign key hacia User
        [Required]
        public int UserId { get; set; }

        // AGREGAR: Navigation property hacia User
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        //FORMULARIO ENERGIA EN FUNCIONAMIENTO (tu código existente sin cambios)
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