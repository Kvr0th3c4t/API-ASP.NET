using BlogSystem.API.Data;
using BlogSystem.API.Models.DTOs;
using BlogSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using BlogSystem.API.Models.Enums;
using BlogSystem.API.DTOs;
using BlogSystem.API.Models.Dtos;

namespace BlogSystem.API.Services
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _context;

        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AdminUserDto>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(u => u.ExcedentesEnergiaNuevo)
                .Include(u => u.ExcedentesEnergiaFuncionamiento)
                .Include(u => u.ProduccionesHidrogeno)
                .Include(u => u.TransportesHidrogeno)
                .Include(u => u.VentaAlquilerHidrogeno)
                .Include(u => u.BlogPosts)
                .OrderByDescending(u => u.CreatedAt)
                .Select(u => new AdminUserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Role = u.Role,
                    TipoEntidad = u.TipoEntidad,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Empresa = u.Empresa,
                    CIF = u.CIF,
                    DNI = u.DNI,
                    Representante = u.Representante,
                    NombreRepresentante = u.NombreRepresentante,
                    ApellidosRepresentante = u.ApellidosRepresentante,
                    Telefono = u.Telefono,
                    Municipio = u.Municipio,
                    Provincia = u.Provincia,
                    Pais = u.Pais,
                    FechaRegistro = u.FechaRegistro,
                    Activo = u.Activo,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }

        public async Task<AdminUserDto?> GetUserByIdAsync(int userId)
        {
            return await _context.Users
                .Include(u => u.ExcedentesEnergiaNuevo)
                .Include(u => u.ExcedentesEnergiaFuncionamiento)
                .Include(u => u.ProduccionesHidrogeno)
                .Include(u => u.TransportesHidrogeno)
                .Include(u => u.VentaAlquilerHidrogeno)
                .Include(u => u.BlogPosts)
                .Where(u => u.Id == userId)
                .Select(u => new AdminUserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Role = u.Role,
                    TipoEntidad = u.TipoEntidad,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Empresa = u.Empresa,
                    CIF = u.CIF,
                    DNI = u.DNI,
                    Representante = u.Representante,
                    NombreRepresentante = u.NombreRepresentante,
                    ApellidosRepresentante = u.ApellidosRepresentante,
                    Telefono = u.Telefono,
                    Municipio = u.Municipio,
                    Provincia = u.Provincia,
                    Pais = u.Pais,
                    FechaRegistro = u.FechaRegistro,
                    Activo = u.Activo,
                    CreatedAt = u.CreatedAt
                  
                })
                .FirstOrDefaultAsync();
        }

        public async Task<AdminUserDto?> UpdateUserAsync(int userId, UserUpdateDto updateDto)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return null;

            // Actualizar solo los campos que no son null
            if (!string.IsNullOrEmpty(updateDto.Username)) user.Username = updateDto.Username;
            if (!string.IsNullOrEmpty(updateDto.Email)) user.Email = updateDto.Email;
            if (!string.IsNullOrEmpty(updateDto.Role)) user.Role = updateDto.Role;
            if (updateDto.TipoEntidad.HasValue) user.TipoEntidad = updateDto.TipoEntidad.Value;
            if (updateDto.Nombre != null) user.Nombre = updateDto.Nombre;
            if (updateDto.Apellidos != null) user.Apellidos = updateDto.Apellidos;
            if (updateDto.Empresa != null) user.Empresa = updateDto.Empresa;
            if (updateDto.CIF != null) user.CIF = updateDto.CIF;
            if (updateDto.DNI != null) user.DNI = updateDto.DNI;
            if (updateDto.Representante != null) user.Representante = updateDto.Representante;
            if (updateDto.NombreRepresentante != null) user.NombreRepresentante = updateDto.NombreRepresentante;
            if (updateDto.ApellidosRepresentante != null) user.ApellidosRepresentante = updateDto.ApellidosRepresentante;
            if (updateDto.Telefono != null) user.Telefono = updateDto.Telefono;
            if (updateDto.Municipio != null) user.Municipio = updateDto.Municipio;
            if (updateDto.Provincia != null) user.Provincia = updateDto.Provincia;
            if (updateDto.Pais != null) user.Pais = updateDto.Pais;
            if (updateDto.Activo.HasValue) user.Activo = updateDto.Activo.Value;

            await _context.SaveChangesAsync();
            return await GetUserByIdAsync(userId);
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            // Las relaciones tienen DeleteBehavior.Cascade
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<UserFormulariosDto?> GetUserFormulariosAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return null;

            return new UserFormulariosDto
            {
                ExcedentesEnergiaNuevo = await _context.ExcedentesEnergiaNuevo
                    .Where(e => e.UserId == userId)
                    .OrderByDescending(e => e.Id)
                    .Select(e => new ExcedenteEnergiaNuevoDto
                    {
                        Id = e.Id,
                        UserId = e.UserId,
                        InstalacionConstruida = e.InstalacionConstruida,
                        InstalacionContruidaFalse = e.InstalacionContruidaFalse,
                        InstalacionEnConstruccion = e.InstalacionEnConstruccion,
                        InstalacionEnConstruccionTrue = e.InstalacionEnConstruccionTrue,
                        KwTotalesProduccion = e.KwTotalesProduccion,
                        TipoTecnologia = e.TipoTecnologia,
                        OtrasTecnologias = e.OtrasTecnologias,
                        DestinaInstalacion = e.DestinaInstalacion,
                        KwDestinados = e.KwDestinados,
                        NumeroHoras = e.NumeroHoras,
                        PaisInstalacion = e.PaisInstalacion,
                        ProvinciaInstalacion = e.ProvinciaInstalacion,
                        MunicipioInstalacion = e.MunicipioInstalacion,
                        Coordenadas = e.Coordenadas,
                        TieneLicencia = e.TieneLicencia,
                        CapacidadProduccionLicencia = e.CapacidadProduccionLicencia,
                        QuierePersonalTramitar = e.QuierePersonalTramitar,
                        QuiereProducirConExcedente = e.QuiereProducirConExcedente,
                        AlquilarInstalaciones = e.AlquilarInstalaciones,
                        AnosAlquiler = e.AnosAlquiler
                    })
                    .ToListAsync(),

                ExcedentesEnergiaFuncionamiento = await _context.ExcedentesEnergiaEnFuncionamiento
                    .Where(e => e.UserId == userId)
                    .OrderByDescending(e => e.Id)
                    .Select(e => new ExcedenteEnergiaEnFuncionamientoDto
                    {
                        Id = e.Id,
                        UserId = e.UserId,
                        TipoTecnologia = e.TipoTecnologia,
                        OtrasTecnologias = e.OtrasTecnologias,
                        CapacidadProduccionEnergia = e.CapacidadProduccionEnergia,
                        ExcedenteEnergia = e.ExcedenteEnergia,
                        HorasExcedenteEnergia = e.HorasExcedenteEnergia,
                        DiasExcedenteEnergia = e.DiasExcedenteEnergia,
                        CapacidadProduccion = e.CapacidadProduccion,
                        ProduceEnergia = e.ProduceEnergia,
                        FechaInicioProduccion = e.FechaInicioProduccion,
                        VierteEnergiaRed = e.VierteEnergiaRed,
                        VierteEnergiaTrue = e.VierteEnergiaTrue,
                        Autoconsumo = e.Autoconsumo,
                        PaisInstalacion = e.PaisInstalacion,
                        ProvinciaInstalacion = e.ProvinciaInstalacion,
                        MunicipioInstalacion = e.MunicipioInstalacion,
                        Coordenadas = e.Coordenadas,
                        TieneLicencia = e.TieneLicencia,
                        CapacidadProduccionLicencia = e.CapacidadProduccionLicencia,
                        QuiereProducirConExcedente = e.QuiereProducirConExcedente,
                        AlquilarParteOTotalidad = e.AlquilarParteOTotalidad,
                        Observaciones = e.Observaciones
                    })
                    .ToListAsync(),

                ProduccionesHidrogeno = await _context.ProduccionesHidrogeno
                    .Where(p => p.UserId == userId)
                    .OrderByDescending(p => p.Id)
                    .Select(p => new ProduccionHidrogenoDto
                    {
                        Id = p.Id,
                        UserId = p.UserId,
                        InstalacionConstruida = p.InstalacionConstruida,
                        TipoTecnologia = p.TipoTecnologia,
                        OtrasTecnologias = p.OtrasTecnologias,
                        CuantoKiloGramosHora = p.CuantoKiloGramosHora,
                        Autoconsumo = p.Autoconsumo,
                        TipoSectorProduccion = p.TipoSectorProduccion,
                        MovilidadSelect = p.MovilidadSelect,
                        ResidencialSelect = p.ResidencialSelect,
                        IndustrialSelect = p.IndustrialSelect,
                        DistribucionSelect = p.DistribucionSelect,
                        OtroSector = p.OtroSector,
                        PaisProduccion = p.PaisProduccion,
                        ProvinciaProduccion = p.ProvinciaProduccion,
                        MunicipioProduccion = p.MunicipioProduccion,
                        PaisConsumicion = p.PaisConsumicion,
                        ProvinciaConsumicion = p.ProvinciaConsumicion,
                        MunicipioConsumicion = p.MunicipioConsumicion,
                        MetanolVerde = p.MetanolVerde,
                        EquiposProducir = p.EquiposProducir,
                        EquiposAlmacenar = p.EquiposAlmacenar,
                        OtraTecnologia = p.OtraTecnologia,
                        IndicarCual = p.IndicarCual,
                        NecesitaEmpresa = p.NecesitaEmpresa,
                        PaisNecesita = p.PaisNecesita,
                        ProvinciaNecesita = p.ProvinciaNecesita,
                        MunicipioNecesita = p.MunicipioNecesita,
                        BaresHidrogeno = p.BaresHidrogeno,
                        AlquilarTerrenoSinInstalaciones = p.AlquilarTerrenoSinInstalaciones,
                        AnosAlquiler = p.AnosAlquiler,
                        AlquilarTerrenoConInstalaciones = p.AlquilarTerrenoConInstalaciones,
                        TipoTecnologiaAlquiler = p.TipoTecnologiaAlquiler,
                        OtrasTecnologiasAlquiler = p.OtrasTecnologiasAlquiler,
                        ContratarPPA = p.ContratarPPA,
                        AyudaProveedorPPA = p.AyudaProveedorPPA,
                        ProporcionClientes = p.ProporcionClientes,
                        RedEmpresas = p.RedEmpresas,
                        RedHidrogeneras = p.RedHidrogeneras,
                        RedPuntosDispensacion = p.RedPuntosDispensacion,
                        TramitacionSolicitudes = p.TramitacionSolicitudes,
                        FechaHidrogenoDisponible = p.FechaHidrogenoDisponible,
                        Observaciones = p.Observaciones
                    })
                    .ToListAsync(),

                TransportesHidrogeno = await _context.TransportesHidrogeno
                    .Where(t => t.UserId == userId)
                    .OrderByDescending(t => t.Id)
                    .Select(t => new TransporteHidrogenoDto
                    {
                        Id = t.Id,
                        UserId = t.UserId,
                        LicenciaMercanciaPeligrosa = t.LicenciaMercanciaPeligrosa,
                        FalseLicenciaAsesoramiento = t.FalseLicenciaAsesoramiento,
                        TipoTransporte = t.TipoTransporte,
                        TieneCaminonesHidrogeno = t.TieneCaminonesHidrogeno,
                        TieneCamionesMetanol = t.TieneCamionesMetanol,
                        TieneCamionesAmoniaco = t.TieneCamionesAmoniaco,
                        RedTransporte = t.RedTransporte,
                        TipoRed = t.TipoRed,
                        TipoTransporteHidrogeno = t.TipoTransporteHidrogeno,
                        PresionHidrogeno = t.PresionHidrogeno,
                        MunicipioTransporte = t.MunicipioTransporte,
                        ProvinciaTransporte = t.ProvinciaTransporte,
                        PaisTransporte = t.PaisTransporte,
                        NecesitaFormacion = t.NecesitaFormacion,
                        Observaciones = t.Observaciones
                    })
                    .ToListAsync(),

                VendeAlquilaHidrogeno = await _context.VentaAlquilerHidrogeno
                    .Where(v => v.UserId == userId)
                    .OrderByDescending(v => v.Id)
                    .Select(v => new VendeAlquilaHidrogenoDto
                    {
                        Id = v.Id,
                        UserId = v.UserId,
                        MetrosCuadradosTerreno = v.MetrosCuadradosTerreno,
                        TipoTerreno = v.TipoTerreno,
                        TieneLicencia = v.TieneLicencia,
                        Licencia = v.Licencia,
                        VenderAlquilar = v.VenderAlquilar,
                        AnosAlquiler = v.AnosAlquiler,
                        PrecioAlquiler = v.PrecioAlquiler,
                        PrecioVenta = v.PrecioVenta,
                        PaisAlVen = v.PaisAlVen,
                        ProvinciaAlVen = v.ProvinciaAlVen,
                        MunicipioAlVen = v.MunicipioAlVen,
                        Coordenadas = v.Coordenadas,
                        Observaciones = v.Observaciones
                    })
                    .ToListAsync()
            };
        }

        public async Task<List<AdminUserDto>> GetEmpresasAsync()
        {
            return await _context.Users
                .Where(u => u.TipoEntidad == TipoEntidad.EMPRESA)
                .Select(u => new AdminUserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Role = u.Role,
                    TipoEntidad = u.TipoEntidad,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Empresa = u.Empresa,
                    CIF = u.CIF,
                    DNI = u.DNI,
                    Representante = u.Representante,
                    NombreRepresentante = u.NombreRepresentante,
                    ApellidosRepresentante = u.ApellidosRepresentante,
                    Telefono = u.Telefono,
                    Municipio = u.Municipio,
                    Provincia = u.Provincia,
                    Pais = u.Pais,
                    FechaRegistro = u.FechaRegistro,
                    Activo = u.Activo,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }

        public async Task<List<AdminUserDto>> GetParticularesAsync()
        {
            return await _context.Users
                .Where(u => u.TipoEntidad == TipoEntidad.PARTICULAR)
                .Select(u => new AdminUserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Role = u.Role,
                    TipoEntidad = u.TipoEntidad,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Empresa = u.Empresa,
                    CIF = u.CIF,
                    DNI = u.DNI,
                    Representante = u.Representante,
                    NombreRepresentante = u.NombreRepresentante,
                    ApellidosRepresentante = u.ApellidosRepresentante,
                    Telefono = u.Telefono,
                    Municipio = u.Municipio,
                    Provincia = u.Provincia,
                    Pais = u.Pais,
                    FechaRegistro = u.FechaRegistro,
                    Activo = u.Activo,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }

        // Método genérico (estilo Spring)
        public async Task<List<AdminUserDto>> GetByTipoEntidadAsync(TipoEntidad tipoEntidad)
        {
            return await _context.Users
                .Where(u => u.TipoEntidad == tipoEntidad)
                .Select(u => new AdminUserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    Role = u.Role,
                    TipoEntidad = u.TipoEntidad,
                    Nombre = u.Nombre,
                    Apellidos = u.Apellidos,
                    Empresa = u.Empresa,
                    CIF = u.CIF,
                    DNI = u.DNI,
                    Representante = u.Representante,
                    NombreRepresentante = u.NombreRepresentante,
                    ApellidosRepresentante = u.ApellidosRepresentante,
                    Telefono = u.Telefono,
                    Municipio = u.Municipio,
                    Provincia = u.Provincia,
                    Pais = u.Pais,
                    FechaRegistro = u.FechaRegistro,
                    Activo = u.Activo,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();
        }
    }

}