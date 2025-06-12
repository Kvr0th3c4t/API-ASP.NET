using BlogSystem.API.DTOs;
using BlogSystem.API.Models.Dtos;

namespace BlogSystem.API.Models.DTOs
{
    public class UserFormulariosDto
    {
        public List<ExcedenteEnergiaNuevoDto> ExcedentesEnergiaNuevo { get; set; } = new();
        public List<ExcedenteEnergiaEnFuncionamientoDto> ExcedentesEnergiaFuncionamiento { get; set; } = new();
        public List<ProduccionHidrogenoDto> ProduccionesHidrogeno { get; set; } = new();
        public List<TransporteHidrogenoDto> TransportesHidrogeno { get; set; } = new();
        public List<VendeAlquilaHidrogenoDto> VendeAlquilaHidrogeno { get; set; } = new();
    }
}