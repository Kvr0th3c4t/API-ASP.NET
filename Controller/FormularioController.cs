using BlogSystem.API.Models.Dtos;
using BlogSystem.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogSystem.API.Models;
using BlogSystem.API.DTOs;

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

        [HttpPost("produccion-hidrogeno")]
        public async Task<ActionResult<ProduccionHidrogeno>> PostProduccionHidrogeno(ProduccionHidrogenoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var produccionHidrogeno = new ProduccionHidrogeno
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

                    // FORMULARIO PRODUCCIÓN HIDRÓGENO
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

        [HttpGet("{id}")]
        public async Task<ActionResult<ProduccionHidrogeno>> GetProduccionHidrogeno(int id)
        {
            var produccionHidrogeno = await _context.ProduccionesHidrogeno.FindAsync(id);

            if (produccionHidrogeno == null)
            {
                return NotFound();
            }

            return produccionHidrogeno;
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


        [HttpPost("excedente-energia-funcionamiento")]
        public async Task<ActionResult<ExcedenteEnergiaEnFuncionamiento>> PostExcedenteEnergiaFuncionamiento(ExcedenteEnergiaEnFuncionamientoDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var excedenteEnFuncionamiento = new ExcedenteEnergiaEnFuncionamiento
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

                    // FORMULARIO ENERGIA EN FUNCIONAMIENTO
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

        // Métodos GET complementarios siguiendo el mismo estilo

        [HttpGet("excedente-energia-funcionamiento/{id}")]
        public async Task<ActionResult<ExcedenteEnergiaEnFuncionamiento>> GetExcedenteEnergiaFuncionamiento(int id)
        {
            var excedenteEnFuncionamiento = await _context.ExcedentesEnergiaEnFuncionamiento.FindAsync(id);

            if (excedenteEnFuncionamiento == null)
            {
                return NotFound();
            }

            return excedenteEnFuncionamiento;
        }

        [HttpGet("excedente-energia-funcionamiento")]
        public async Task<ActionResult<IEnumerable<ExcedenteEnergiaEnFuncionamiento>>> GetExcedentesEnergiaFuncionamiento()
        {
            return await _context.ExcedentesEnergiaEnFuncionamiento.Where(x => x.Activo).ToListAsync();
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
                var vendeAlquila = new VendeAlquilaHidrogeno
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

                    // FORMULARIO VENTA/ALQUILER HIDRÓGENO
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

        [HttpGet("vende-alquila-hidrogeno/{id}")]
        public async Task<ActionResult<VendeAlquilaHidrogeno>> GetVendeAlquilaHidrogeno(int id)
        {
            var vendeAlquila = await _context.VentaAlquilerHidrogeno.FindAsync(id);

            if (vendeAlquila == null)
            {
                return NotFound();
            }

            return vendeAlquila;
        }

        [HttpGet("vende-alquila-hidrogeno")]
        public async Task<ActionResult<IEnumerable<VendeAlquilaHidrogeno>>> GetVentaAlquilerHidrogeno()
        {
            return await _context.VentaAlquilerHidrogeno.Where(x => x.Activo).ToListAsync();
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
                var transporte = new TransporteHidrogeno
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

                    // FORMULARIO TRANSPORTE HIDRÓGENO
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

        [HttpGet("transporte-hidrogeno/{id}")]
        public async Task<ActionResult<TransporteHidrogeno>> GetTransporteHidrogeno(int id)
        {
            var transporte = await _context.TransportesHidrogeno.FindAsync(id);

            if (transporte == null)
            {
                return NotFound();
            }

            return transporte;
        }

        [HttpGet("transporte-hidrogeno")]
        public async Task<ActionResult<IEnumerable<TransporteHidrogeno>>> GetTransportesHidrogeno()
        {
            return await _context.TransportesHidrogeno.Where(x => x.Activo).ToListAsync();
        }
    }
}
    