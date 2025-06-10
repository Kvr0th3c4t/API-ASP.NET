using BlogSystem.API.Data;
using BlogSystem.API.Models;
using BlogSystem.API.Models.DTOs;
using BlogSystem.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace BlogSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public AuthController(ApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            try
            {
                Console.WriteLine("=== INICIO REGISTER ===");
                Console.WriteLine($"Username: '{registerDto.Username}'");
                Console.WriteLine($"Email: '{registerDto.Email}'");
                Console.WriteLine($"Password length: {registerDto.Password?.Length}");
                Console.WriteLine($"TipoEntidad: '{registerDto.TipoEntidad}'");
                Console.WriteLine($"Nombre: '{registerDto.Nombre}'");
                Console.WriteLine($"DNI: '{registerDto.DNI}'");

                // Verificar si el email ya existe
                Console.WriteLine("=== VERIFICANDO EMAIL ===");
                var emailExists = await _context.Users.AnyAsync(u => u.Email == registerDto.Email);
                Console.WriteLine($"Email ya existe: {emailExists}");

                if (emailExists)
                {
                    Console.WriteLine("=== EMAIL YA REGISTRADO ===");
                    return BadRequest("El email ya está registrado");
                }

                Console.WriteLine("=== CREANDO USUARIO ===");

                // Crear nuevo usuario con TODOS los campos
                var user = new User
                {
                    Username = registerDto.Username,
                    Email = registerDto.Email,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password),
                    Role = "user",
                    TipoEntidad = registerDto.TipoEntidad,
                    Nombre = registerDto.Nombre,
                    Apellidos = registerDto.Apellidos,
                    Empresa = registerDto.Empresa,
                    CIF = registerDto.CIF,
                    DNI = registerDto.DNI,
                    Representante = registerDto.Representante,
                    NombreRepresentante = registerDto.NombreRepresentante,
                    ApellidosRepresentante = registerDto.ApellidosRepresentante,
                    Telefono = registerDto.Telefono,
                    Municipio = registerDto.Municipio,
                    Provincia = registerDto.Provincia,
                    Pais = registerDto.Pais,
                    FechaRegistro = DateTime.UtcNow,
                    Activo = true,
                    CreatedAt = DateTime.UtcNow
                };

                Console.WriteLine("=== USUARIO CREADO EN MEMORIA ===");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Nombre: {user.Nombre}");
                Console.WriteLine($"DNI: {user.DNI}");

                _context.Users.Add(user);
                Console.WriteLine("=== USUARIO AÑADIDO AL CONTEXTO ===");

                await _context.SaveChangesAsync();
                Console.WriteLine("=== CAMBIOS GUARDADOS EN BD ===");
                Console.WriteLine($"ID generado: {user.Id}");

                // Generar token
                var token = _jwtService.GenerateToken(user);
                Console.WriteLine("=== TOKEN GENERADO ===");

                var response = new
                {
                    Token = token,
                    User = new
                    {
                        user.Id,
                        user.Username,
                        user.Email,
                        user.Role,
                        user.TipoEntidad,
                        user.Nombre,
                        user.Apellidos,
                        user.Empresa,
                        user.CIF,
                        user.DNI,
                        user.Representante,
                        user.NombreRepresentante,
                        user.ApellidosRepresentante,
                        user.Telefono,
                        user.Municipio,
                        user.Provincia,
                        user.Pais,
                        user.FechaRegistro,
                        user.Activo
                    }
                };

                Console.WriteLine("=== RESPUESTA CREADA ===");
                Console.WriteLine($"Response: {System.Text.Json.JsonSerializer.Serialize(response)}");

                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"=== ERROR EN REGISTER ===");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
            {
                return BadRequest("Credenciales inválidas");
            }

            var token = _jwtService.GenerateToken(user);

            return Ok(new
            {
                Token = token,
                User = new
                {
                    user.Id,
                    user.Email,
                    user.Role
                }
            });
        }
    }
}