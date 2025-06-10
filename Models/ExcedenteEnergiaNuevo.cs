using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class ExcedenteEnergiaNuevo
    {
        [Key]
        public int Id { get; set; }

        //FORMULARIO ENERGIA
        public bool InstalacionConstruida { get; set; } //Si es NO, hay que pedir la fecha de cuando se construirá la instalación.
        public DateOnly? InstalacionContruidaFalse { get; set; } //Si es no se completa esta opción.
        public bool InstalacionEnConstruccion { get; set; } //Si es SI, se indica fecha
        public DateOnly? InstalacionEnConstruccionTrue { get; set; } //Si es SI se completa esta opción.
        public int? KwTotalesProduccion { get; set; }
        public TipoTecnologia TipoTecnologia { get; set; }
        public string? OtrasTecnologias { get; set; } //Si el tipo de tecnología es Otras, entonces se muestra este campo para indicar cuál es la otra tecnología.
        public bool DestinaInstalacion { get; set; } //Si es NO, cuántos KW destinará e intervalos de hora
        public int? KwDestinados { get; set; } //Si DestinaInstalacion es NO, entonces se muestra este campo para indicar cuántos KW destinará.
        public string? NumeroHoras { get; set; } //Si DestinaInstalacion es NO, entonces se muestra este campo para indicar en qué horas destinará los KW.
        public string? PaisInstalacion { get; set; } //Formulario reactivo, según la opción que se elija mostrará unos datos u otros después (provincia, municipio).
        public string? ProvinciaInstalacion { get; set; }
        public string? MunicipioInstalacion { get; set; }
        public string? Coordenadas { get; set; } //Coordenadas GPS de la instalación. Hay que saber si lo introduce con las coordenadas o a través de una dirección.
        public bool TieneLicencia { get; set; } //Si es TRUE indicar capacidad.
        public int? CapacidadProduccionLicencia { get; set; } //Si TieneLicencia es TRUE, entonces indica la capacidad de producción según la licencia.
        public bool QuierePersonalTramitar { get; set; }
        public bool QuiereProducirConExcedente { get; set; }
        public bool AlquilarInstalaciones { get; set; } //Si es TRUE, poner años de alquiler.
        public int? AnosAlquiler { get; set; } //Si AlquilarInstalaciones es TRUE, entonces se muestra este campo para indicar cuántos años alquilará.
    }
}