using BlogSystem.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models
{
    public class TransporteHidrogeno
    {
        [Key]
        public int Id { get; set; }

        // SECCIÓN DE REGISTRO
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

        // FORMULARIO TRANSPORTE HIDRÓGENO
        public bool LicenciaMercanciaPeligrosa { get; set; } //Si es FALSE aparece opcion de asesoramiento.
        public bool FalseLicenciaAsesoramiento { get; set; }
        public TipoTransporte TipoTransporte { get; set; }
        public bool TieneCaminonesHidrogeno { get; set; }
        public bool TieneCamionesMetanol { get; set; }
        public bool TieneCamionesAmoniaco { get; set; }
        public bool RedTransporte { get; set; } //Si es TRUE seleccionar qué red nacional, local, provincial, internacional, regional.
        public string? TipoRed { get; set; } //Seleccion en HTML.
        public string? TipoTransporteHidrogeno { get; set; } //Seleccion liquido o gas en el HTML.
        public string? PresionHidrogeno { get; set; } //Select para baja presion, 200 bar, 350 bar, 700 bar, 1000 bar.
        [StringLength(100)]
        public string? MunicipioTransporte { get; set; }
        [StringLength(100)]
        public string? ProvinciaTransporte { get; set; }
        [StringLength(100)]
        public string? PaisTransporte { get; set; }
        public bool NecesitaFormacion { get; set; }
        public string? Observaciones { get; set; }

    }
}
