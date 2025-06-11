// Controllers/AdminController.cs
using BlogSystem.API.Models.DTOs;
using BlogSystem.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")] // Solo usuarios con rol admin
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        // Método helper para verificar que realmente es admin
        private bool IsCurrentUserAdmin()
        {
            var userRole = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
            return userRole == "admin";
        }

        /// <summary>
        /// Obtener todos los usuarios (Angular se encarga de paginación y filtros)
        /// </summary>
        [HttpGet("users")]
        public async Task<ActionResult<List<AdminUserDto>>> GetAllUsers()
        {
            try
            {
                if (!IsCurrentUserAdmin())
                    return Forbid("Se requiere rol de administrador");

                var users = await _adminService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al obtener usuarios", error = ex.Message });
            }
        }

        /// <summary>
        /// Obtener un usuario específico por ID
        /// </summary>
        [HttpGet("users/{id}")]
        public async Task<ActionResult<AdminUserDto>> GetUser(int id)
        {
            try
            {
                if (!IsCurrentUserAdmin())
                    return Forbid("Se requiere rol de administrador");

                var user = await _adminService.GetUserByIdAsync(id);

                if (user == null)
                    return NotFound(new { message = "Usuario no encontrado" });

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al obtener el usuario", error = ex.Message });
            }
        }

        /// <summary>
        /// Actualizar un usuario
        /// </summary>
        [HttpPut("users/{id}")]
        public async Task<ActionResult<AdminUserDto>> UpdateUser(int id, UserUpdateDto updateDto)
        {
            try
            {
                if (!IsCurrentUserAdmin())
                    return Forbid("Se requiere rol de administrador");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var updatedUser = await _adminService.UpdateUserAsync(id, updateDto);

                if (updatedUser == null)
                    return NotFound(new { message = "Usuario no encontrado" });

                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al actualizar el usuario", error = ex.Message });
            }
        }

        /// <summary>
        /// Eliminar un usuario y todos sus formularios
        /// </summary>
        [HttpDelete("users/{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                if (!IsCurrentUserAdmin())
                    return Forbid("Se requiere rol de administrador");

                var result = await _adminService.DeleteUserAsync(id);

                if (!result)
                    return NotFound(new { message = "Usuario no encontrado" });

                return Ok(new { message = "Usuario eliminado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al eliminar el usuario", error = ex.Message });
            }
        }

        /// <summary>
        /// Obtener todos los formularios de un usuario específico
        /// </summary>
        [HttpGet("users/{id}/formularios")]
        public async Task<ActionResult<UserFormulariosDto>> GetUserFormularios(int id)
        {
            try
            {
                if (!IsCurrentUserAdmin())
                    return Forbid("Se requiere rol de administrador");

                var userFormularios = await _adminService.GetUserFormulariosAsync(id);

                if (userFormularios == null)
                    return NotFound(new { message = "Usuario no encontrado" });

                return Ok(userFormularios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al obtener los formularios del usuario", error = ex.Message });
            }
        }
    }
}