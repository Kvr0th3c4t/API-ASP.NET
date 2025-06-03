using BlogSystem.API.Models.Dtos;
using BlogSystem.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogSystem.API.Models;

namespace BlogSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormularioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FormularioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("excedente-energia-nuevo")]
        public async Task<ActionResult<ExcedenteEnergiaNuevo>> PostExcedenteEnergiaNuevo(ExcedenteEnergiaNuevoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var excedente = new ExcedenteEnergiaNuevo
                {
                    // SECCIÓN DE REGISTRO
                    TipoEntidad = dto.TipoEntidad,
                    Nombre = dto.Nombre,
                    Apellidos = dto.Apellidos,
                    Empresa = dto.Empresa,
                    CIF = dto.CIF,
                    DNI = dto.DNI,
                    Representante = dto.Representante,
                    NombreRepresentante = dto.NombreRepresentante,
                    ApellidosRepresentante = dto.ApellidosRepresentante,
                    Telefono = dto.Telefono,
                    Email = dto.Email,
                    Municipio = dto.Municipio,
                    Provincia = dto.Provincia,
                    Pais = dto.Pais,
                    FechaRegistro = DateTime.UtcNow,
                    Activo = true,

                    // FORMULARIO ENERGIA
                    InstalacionConstruida = dto.InstalacionConstruida,
                    InstalacionContruidaFalse = ConvertToDateOnly(dto.InstalacionContruidaFalse),
                    InstalacionEnConstruccion = dto.InstalacionEnConstruccion,
                    InstalacionEnConstruccionTrue = ConvertToDateOnly(dto.InstalacionEnConstruccionTrue),
                    KwTotalesProduccion = dto.KwTotalesProduccion,
                    TipoTecnologia = dto.TipoTecnologia,
                    OtrasTecnologias = dto.OtrasTecnologias,
                    DestinaInstalacion = dto.DestinaInstalacion,
                    KwDestinados = dto.KwDestinados,
                    NumeroHoras = dto.NumeroHoras,
                    PaisInstalacion = dto.PaisInstalacion,
                    ProvinciaInstalacion = dto.ProvinciaInstalacion,
                    MunicipioInstalacion = dto.MunicipioInstalacion,
                    Coordenadas = dto.Coordenadas,
                    TieneLicencia = dto.TieneLicencia,
                    CapacidadProduccionLicencia = dto.CapacidadProduccionLicencia,
                    QuierePersonalTramitar = dto.QuierePersonalTramitar,
                    QuiereProducirConExcedente = dto.QuiereProducirConExcedente,
                    AlquilarInstalaciones = dto.AlquilarInstalaciones,
                    AnosAlquiler = dto.AnosAlquiler
                };

                _context.ExcedentesEnergiaNuevo.Add(excedente);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetExcedenteEnergiaNuevo), new { id = excedente.Id }, excedente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        private DateOnly? ConvertToDateOnly(string? dateString)
        {
            if (string.IsNullOrEmpty(dateString))
                return null;

            if (DateTime.TryParse(dateString, out DateTime dateTime))
            {
                return DateOnly.FromDateTime(dateTime);
            }

            return null;
        }


        [HttpGet("excedente-energia-nuevo/{id}")]
        public async Task<ActionResult<ExcedenteEnergiaNuevo>> GetExcedenteEnergiaNuevo(int id)
        {
            var excedente = await _context.ExcedentesEnergiaNuevo.FindAsync(id);

            if (excedente == null)
            {
                return NotFound();
            }

            return excedente;
        }

        [HttpGet("excedente-energia-nuevo")]
        public async Task<ActionResult<IEnumerable<ExcedenteEnergiaNuevo>>> GetExcedentesEnergiaNuevo()
        {
            return await _context.ExcedentesEnergiaNuevo.Where(x => x.Activo).ToListAsync();
        }
    }
}