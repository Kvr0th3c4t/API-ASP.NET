using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.DTOs
{
    public class TransporteHidrogenoDto
    {
        // SECCIÓN DE REGISTRO
        [Required(ErrorMessage = "El tipo de entidad es obligatorio")]
        public TipoEntidad TipoEntidad { get; set; }

        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(100, ErrorMessage = "Los apellidos no pueden exceder 100 caracteres")]
        public string? Apellidos { get; set; }

        [StringLength(200, ErrorMessage = "La empresa no puede exceder 200 caracteres")]
        public string? Empresa { get; set; }

        [StringLength(20, ErrorMessage = "El CIF no puede exceder 20 caracteres")]
        public string? CIF { get; set; }

        [StringLength(20, ErrorMessage = "El DNI no puede exceder 20 caracteres")]
        public string? DNI { get; set; }

        [StringLength(200, ErrorMessage = "El representante no puede exceder 200 caracteres")]
        public string? Representante { get; set; }

        [StringLength(200, ErrorMessage = "El nombre del representante no puede exceder 200 caracteres")]
        public string? NombreRepresentante { get; set; }

        [StringLength(200, ErrorMessage = "Los apellidos del representante no pueden exceder 200 caracteres")]
        public string? ApellidosRepresentante { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono no puede exceder 20 caracteres")]
        public string? Telefono { get; set; }

        [StringLength(100, ErrorMessage = "El email no puede exceder 100 caracteres")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "El municipio no puede exceder 100 caracteres")]
        public string? Municipio { get; set; }

        [StringLength(100, ErrorMessage = "La provincia no puede exceder 100 caracteres")]
        public string? Provincia { get; set; }

        [StringLength(100, ErrorMessage = "El país no puede exceder 100 caracteres")]
        public string? Pais { get; set; }

        // FORMULARIO TRANSPORTE HIDRÓGENO
        public bool LicenciaMercanciaPeligrosa { get; set; } //Si es FALSE aparece opcion de asesoramiento.

        public bool FalseLicenciaAsesoramiento { get; set; }

        [Required(ErrorMessage = "El tipo de transporte es obligatorio")]
        public TipoTransporte TipoTransporte { get; set; }

        public bool TieneCaminonesHidrogeno { get; set; }

        public bool TieneCamionesMetanol { get; set; }

        public bool TieneCamionesAmoniaco { get; set; }

        public bool RedTransporte { get; set; } //Si es TRUE seleccionar qué red nacional, local, provincial, internacional, regional.

        public string? TipoRed { get; set; } //Seleccion en HTML.

        public string? TipoTransporteHidrogeno { get; set; } //Seleccion liquido o gas en el HTML.

        public string? PresionHidrogeno { get; set; } //Select para baja presion, 200 bar, 350 bar, 700 bar, 1000 bar.

        [StringLength(100, ErrorMessage = "El municipio de transporte no puede exceder 100 caracteres")]
        public string? MunicipioTransporte { get; set; }

        [StringLength(100, ErrorMessage = "La provincia de transporte no puede exceder 100 caracteres")]
        public string? ProvinciaTransporte { get; set; }

        [StringLength(100, ErrorMessage = "El país de transporte no puede exceder 100 caracteres")]
        public string? PaisTransporte { get; set; }

        public bool NecesitaFormacion { get; set; }

        public string? Observaciones { get; set; }
    }
}