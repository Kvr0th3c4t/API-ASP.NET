using BlogSystem.API.Models.Dtos;
using BlogSystem.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogSystem.API.Models;
using BlogSystem.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BlogSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Requiere autenticación para todos los métodos
    public class FormularioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FormularioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método helper para extraer UserId del token JWT
        private int GetCurrentUserId()
        {
            var userIdClaim = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userIdClaim))
                throw new UnauthorizedAccessException("No se pudo identificar al usuario");

            return int.Parse(userIdClaim);
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
                var userId = GetCurrentUserId();

                var excedente = new ExcedenteEnergiaNuevo
                {
                    UserId = userId,
                    InstalacionConstruida = dto.InstalacionConstruida,
                    InstalacionContruidaFalse = dto.InstalacionContruidaFalse,
                    InstalacionEnConstruccion = dto.InstalacionEnConstruccion,
                    InstalacionEnConstruccionTrue = dto.InstalacionEnConstruccionTrue,
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

        [HttpPost("produccion-hidrogeno")]
        public async Task<ActionResult<ProduccionHidrogeno>> PostProduccionHidrogeno(ProduccionHidrogenoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userId = GetCurrentUserId();

                var produccionHidrogeno = new ProduccionHidrogeno
                {
                    UserId = userId,
                    InstalacionConstruida = dto.InstalacionConstruida,
                    TipoTecnologia = dto.TipoTecnologia,
                    OtrasTecnologias = dto.OtrasTecnologias,
                    CuantoKiloGramosHora = dto.CuantoKiloGramosHora,
                    Autoconsumo = dto.Autoconsumo,
                    TipoSectorProduccion = dto.TipoSectorProduccion,
                    MovilidadSelect = dto.MovilidadSelect,
                    ResidencialSelect = dto.ResidencialSelect,
                    IndustrialSelect = dto.IndustrialSelect,
                    DistribucionSelect = dto.DistribucionSelect,
                    OtroSector = dto.OtroSector,
                    PaisProduccion = dto.PaisProduccion,
                    ProvinciaProduccion = dto.ProvinciaProduccion,
                    MunicipioProduccion = dto.MunicipioProduccion,
                    PaisConsumicion = dto.PaisConsumicion,
                    ProvinciaConsumicion = dto.ProvinciaConsumicion,
                    MunicipioConsumicion = dto.MunicipioConsumicion,
                    MetanolVerde = dto.MetanolVerde,
                    EquiposProducir = dto.EquiposProducir,
                    EquiposAlmacenar = dto.EquiposAlmacenar,
                    OtraTecnologia = dto.OtraTecnologia,
                    IndicarCual = dto.IndicarCual,
                    NecesitaEmpresa = dto.NecesitaEmpresa,
                    PaisNecesita = dto.PaisNecesita,
                    ProvinciaNecesita = dto.ProvinciaNecesita,
                    MunicipioNecesita = dto.MunicipioNecesita,
                    BaresHidrogeno = dto.BaresHidrogeno,
                    AlquilarTerrenoSinInstalaciones = dto.AlquilarTerrenoSinInstalaciones,
                    AnosAlquiler = dto.AnosAlquiler,
                    AlquilarTerrenoConInstalaciones = dto.AlquilarTerrenoConInstalaciones,
                    TipoTecnologiaAlquiler = dto.TipoTecnologiaAlquiler,
                    OtrasTecnologiasAlquiler = dto.OtrasTecnologiasAlquiler,
                    ContratarPPA = dto.ContratarPPA,
                    AyudaProveedorPPA = dto.AyudaProveedorPPA,
                    ProporcionClientes = dto.ProporcionClientes,
                    RedEmpresas = dto.RedEmpresas,
                    RedHidrogeneras = dto.RedHidrogeneras,
                    RedPuntosDispensacion = dto.RedPuntosDispensacion,
                    TramitacionSolicitudes = dto.TramitacionSolicitudes,
                    FechaHidrogenoDisponible = dto.FechaHidrogenoDisponible,
                    Observaciones = dto.Observaciones
                };

                _context.ProduccionesHidrogeno.Add(produccionHidrogeno);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetProduccionHidrogeno), new { id = produccionHidrogeno.Id }, produccionHidrogeno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        [HttpPost("excedente-energia-funcionamiento")]
        public async Task<ActionResult<ExcedenteEnergiaEnFuncionamiento>> PostExcedenteEnergiaFuncionamiento(ExcedenteEnergiaEnFuncionamientoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userId = GetCurrentUserId();

                var excedenteEnFuncionamiento = new ExcedenteEnergiaEnFuncionamiento
                {
                    UserId = userId,
                    TipoTecnologia = dto.TipoTecnologia,
                    OtrasTecnologias = dto.OtrasTecnologias,
                    CapacidadProduccionEnergia = dto.CapacidadProduccionEnergia,
                    ExcedenteEnergia = dto.ExcedenteEnergia,
                    HorasExcedenteEnergia = dto.HorasExcedenteEnergia,
                    DiasExcedenteEnergia = dto.DiasExcedenteEnergia,
                    CapacidadProduccion = dto.CapacidadProduccion,
                    ProduceEnergia = dto.ProduceEnergia,
                    FechaInicioProduccion = dto.FechaInicioProduccion,
                    VierteEnergiaRed = dto.VierteEnergiaRed,
                    VierteEnergiaTrue = dto.VierteEnergiaTrue,
                    Autoconsumo = dto.Autoconsumo,
                    PaisInstalacion = dto.PaisInstalacion,
                    ProvinciaInstalacion = dto.ProvinciaInstalacion,
                    MunicipioInstalacion = dto.MunicipioInstalacion,
                    Coordenadas = dto.Coordenadas,
                    TieneLicencia = dto.TieneLicencia,
                    CapacidadProduccionLicencia = dto.CapacidadProduccionLicencia,
                    QuiereProducirConExcedente = dto.QuiereProducirConExcedente,
                    AlquilarParteOTotalidad = dto.AlquilarParteOTotalidad,
                    Observaciones = dto.Observaciones
                };

                _context.ExcedentesEnergiaEnFuncionamiento.Add(excedenteEnFuncionamiento);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetExcedenteEnergiaFuncionamiento), new { id = excedenteEnFuncionamiento.Id }, excedenteEnFuncionamiento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        [HttpPost("vende-alquila-hidrogeno")]
        public async Task<ActionResult<VendeAlquilaHidrogeno>> PostVendeAlquilaHidrogeno(VendeAlquilaHidrogenoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userId = GetCurrentUserId();

                var vendeAlquila = new VendeAlquilaHidrogeno
                {
                    UserId = userId,
                    MetrosCuadradosTerreno = dto.MetrosCuadradosTerreno,
                    TipoTerreno = dto.TipoTerreno,
                    TieneLicencia = dto.TieneLicencia,
                    Licencia = dto.Licencia,
                    VenderAlquilar = dto.VenderAlquilar,
                    AnosAlquiler = dto.AnosAlquiler,
                    PrecioAlquiler = dto.PrecioAlquiler,
                    PrecioVenta = dto.PrecioVenta,
                    PaisAlVen = dto.PaisAlVen,
                    ProvinciaAlVen = dto.ProvinciaAlVen,
                    MunicipioAlVen = dto.MunicipioAlVen,
                    Coordenadas = dto.Coordenadas,
                    Observaciones = dto.Observaciones
                };

                _context.VentaAlquilerHidrogeno.Add(vendeAlquila);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetVendeAlquilaHidrogeno), new { id = vendeAlquila.Id }, vendeAlquila);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        [HttpPost("transporte-hidrogeno")]
        public async Task<ActionResult<TransporteHidrogeno>> PostTransporteHidrogeno(TransporteHidrogenoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userId = GetCurrentUserId();

                var transporte = new TransporteHidrogeno
                {
                    UserId = userId,
                    LicenciaMercanciaPeligrosa = dto.LicenciaMercanciaPeligrosa,
                    FalseLicenciaAsesoramiento = dto.FalseLicenciaAsesoramiento,
                    TipoTransporte = dto.TipoTransporte,
                    TieneCaminonesHidrogeno = dto.TieneCaminonesHidrogeno,
                    TieneCamionesMetanol = dto.TieneCamionesMetanol,
                    TieneCamionesAmoniaco = dto.TieneCamionesAmoniaco,
                    RedTransporte = dto.RedTransporte,
                    TipoRed = dto.TipoRed,
                    TipoTransporteHidrogeno = dto.TipoTransporteHidrogeno,
                    PresionHidrogeno = dto.PresionHidrogeno,
                    MunicipioTransporte = dto.MunicipioTransporte,
                    ProvinciaTransporte = dto.ProvinciaTransporte,
                    PaisTransporte = dto.PaisTransporte,
                    NecesitaFormacion = dto.NecesitaFormacion,
                    Observaciones = dto.Observaciones
                };

                _context.TransportesHidrogeno.Add(transporte);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetTransporteHidrogeno), new { id = transporte.Id }, transporte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        // FORMULARIO CONTACTO (SIN AUTENTICACIÓN)
        [HttpPost("contacto-form")]
        [AllowAnonymous]
        public async Task<ActionResult<ContactoForm>> PostContactoForm(ContactoFormDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var contactoReciente = await _context.ContactoForm
                    .Where(c => c.Email == dto.Email &&
                               c.FechaCreacion > DateTime.UtcNow.AddMinutes(-5))
                    .FirstOrDefaultAsync();

                if (contactoReciente != null)
                {
                    return BadRequest(new { message = "Ya has enviado una solicitud recientemente. Por favor espera unos minutos." });
                }

                var contacto = new ContactoForm
                {
                    Motivo = dto.Motivo,
                    Email = dto.Email,
                    FechaCreacion = DateTime.UtcNow
                };

                _context.ContactoForm.Add(contacto);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetContactoForm), new { id = contacto.Id }, contacto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el formulario", error = ex.Message });
            }
        }

        // MÉTODOS GET INDIVIDUALES
        [HttpGet("excedente-energia-nuevo/{id}")]
        public async Task<ActionResult<ExcedenteEnergiaNuevo>> GetExcedenteEnergiaNuevo(int id)
        {
            var userId = GetCurrentUserId();
            var excedente = await _context.ExcedentesEnergiaNuevo
                .FirstOrDefaultAsync(e => e.Id == id && e.UserId == userId);

            if (excedente == null)
            {
                return NotFound("Formulario no encontrado o no tienes permisos para verlo");
            }

            return excedente;
        }

        [HttpGet("produccion-hidrogeno/{id}")]
        public async Task<ActionResult<ProduccionHidrogeno>> GetProduccionHidrogeno(int id)
        {
            var userId = GetCurrentUserId();
            var produccionHidrogeno = await _context.ProduccionesHidrogeno
                .FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);

            if (produccionHidrogeno == null)
            {
                return NotFound("Formulario no encontrado o no tienes permisos para verlo");
            }

            return produccionHidrogeno;
        }

        [HttpGet("excedente-energia-funcionamiento/{id}")]
        public async Task<ActionResult<ExcedenteEnergiaEnFuncionamiento>> GetExcedenteEnergiaFuncionamiento(int id)
        {
            var userId = GetCurrentUserId();
            var excedenteEnFuncionamiento = await _context.ExcedentesEnergiaEnFuncionamiento
                .FirstOrDefaultAsync(e => e.Id == id && e.UserId == userId);

            if (excedenteEnFuncionamiento == null)
            {
                return NotFound("Formulario no encontrado o no tienes permisos para verlo");
            }

            return excedenteEnFuncionamiento;
        }

        [HttpGet("vende-alquila-hidrogeno/{id}")]
        public async Task<ActionResult<VendeAlquilaHidrogeno>> GetVendeAlquilaHidrogeno(int id)
        {
            var userId = GetCurrentUserId();
            var vendeAlquila = await _context.VentaAlquilerHidrogeno
                .FirstOrDefaultAsync(v => v.Id == id && v.UserId == userId);

            if (vendeAlquila == null)
            {
                return NotFound("Formulario no encontrado o no tienes permisos para verlo");
            }

            return vendeAlquila;
        }

        [HttpGet("transporte-hidrogeno/{id}")]
        public async Task<ActionResult<TransporteHidrogeno>> GetTransporteHidrogeno(int id)
        {
            var userId = GetCurrentUserId();
            var transporte = await _context.TransportesHidrogeno
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (transporte == null)
            {
                return NotFound("Formulario no encontrado o no tienes permisos para verlo");
            }

            return transporte;
        }

        [HttpGet("contacto-form/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ContactoForm>> GetContactoForm(int id)
        {
            var contacto = await _context.ContactoForm.FindAsync(id);

            if (contacto == null)
            {
                return NotFound();
            }

            return contacto;
        }

        [HttpGet("contacto-form")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ContactoForm>>> GetContactosForms()
        {
            return await _context.ContactoForm.ToListAsync();
        }        
    }
}