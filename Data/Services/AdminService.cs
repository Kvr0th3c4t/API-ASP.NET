using BlogSystem.API.Data;
using BlogSystem.API.Models.DTOs;
using BlogSystem.API.Models;
using Microsoft.EntityFrameworkCore;

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
                    CreatedAt = u.CreatedAt,

                    // Angular calculará estos valores
                    FormulariosExcedenteNuevo = u.ExcedentesEnergiaNuevo.Count,
                    FormulariosExcedenteFuncionamiento = u.ExcedentesEnergiaFuncionamiento.Count,
                    FormulariosProduccionHidrogeno = u.ProduccionesHidrogeno.Count,
                    FormulariosTransporteHidrogeno = u.TransportesHidrogeno.Count,
                    FormulariosVentaAlquilerHidrogeno = u.VentaAlquilerHidrogeno.Count,
                    TotalFormularios = u.ExcedentesEnergiaNuevo.Count +
                                     u.ExcedentesEnergiaFuncionamiento.Count +
                                     u.ProduccionesHidrogeno.Count +
                                     u.TransportesHidrogeno.Count +
                                     u.VentaAlquilerHidrogeno.Count
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
                    CreatedAt = u.CreatedAt,
                    FormulariosExcedenteNuevo = u.ExcedentesEnergiaNuevo.Count,
                    FormulariosExcedenteFuncionamiento = u.ExcedentesEnergiaFuncionamiento.Count,
                    FormulariosProduccionHidrogeno = u.ProduccionesHidrogeno.Count,
                    FormulariosTransporteHidrogeno = u.TransportesHidrogeno.Count,
                    FormulariosVentaAlquilerHidrogeno = u.VentaAlquilerHidrogeno.Count,
                    TotalFormularios = u.ExcedentesEnergiaNuevo.Count +
                                     u.ExcedentesEnergiaFuncionamiento.Count +
                                     u.ProduccionesHidrogeno.Count +
                                     u.TransportesHidrogeno.Count +
                                     u.VentaAlquilerHidrogeno.Count
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
            var user = await GetUserByIdAsync(userId);
            if (user == null) return null;

            var userWithFormularios = await _context.Users
                .Include(u => u.ExcedentesEnergiaNuevo)
                .Include(u => u.ExcedentesEnergiaFuncionamiento)
                .Include(u => u.ProduccionesHidrogeno)
                .Include(u => u.TransportesHidrogeno)
                .Include(u => u.VentaAlquilerHidrogeno)
                .Include(u => u.BlogPosts)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (userWithFormularios == null) return null;

            return new UserFormulariosDto
            {
                Usuario = user,
                ExcedentesEnergiaNuevo = userWithFormularios.ExcedentesEnergiaNuevo.OrderByDescending(e => e.Id).ToList(),
                ExcedentesEnergiaFuncionamiento = userWithFormularios.ExcedentesEnergiaFuncionamiento.OrderByDescending(e => e.Id).ToList(),
                ProduccionesHidrogeno = userWithFormularios.ProduccionesHidrogeno.OrderByDescending(p => p.Id).ToList(),
                TransportesHidrogeno = userWithFormularios.TransportesHidrogeno.OrderByDescending(t => t.Id).ToList(),
                VentaAlquilerHidrogeno = userWithFormularios.VentaAlquilerHidrogeno.OrderByDescending(v => v.Id).ToList(),
                BlogPosts = userWithFormularios.BlogPosts.OrderByDescending(b => b.Id).ToList()
            };
        }
    }
}