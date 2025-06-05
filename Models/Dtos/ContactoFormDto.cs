using System.ComponentModel.DataAnnotations;

namespace BlogSystem.API.Models.Dtos
{
    public class ContactoFormDto
    {
        [Required(ErrorMessage = "El motivo es requerido")]
        public string Motivo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        [StringLength(255, ErrorMessage = "El email no puede exceder 255 caracteres")]
        public string Email { get; set; } = string.Empty;
    }
}
