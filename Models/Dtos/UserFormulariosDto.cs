
// Models/DTOs/UserFormulariosDto.cs
namespace BlogSystem.API.Models.DTOs
{
    public class UserFormulariosDto
    {
        public AdminUserDto Usuario { get; set; } = new();
        public List<ExcedenteEnergiaNuevo> ExcedentesEnergiaNuevo { get; set; } = new();
        public List<ExcedenteEnergiaEnFuncionamiento> ExcedentesEnergiaFuncionamiento { get; set; } = new();
        public List<ProduccionHidrogeno> ProduccionesHidrogeno { get; set; } = new();
        public List<TransporteHidrogeno> TransportesHidrogeno { get; set; } = new();
        public List<VendeAlquilaHidrogeno> VentaAlquilerHidrogeno { get; set; } = new();
        public List<BlogPost> BlogPosts { get; set; } = new();
    }
}