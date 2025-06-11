using BlogSystem.API.Models.DTOs;

namespace BlogSystem.API.Services
{
    public interface IAdminService
    {
        Task<List<AdminUserDto>> GetAllUsersAsync();
        Task<AdminUserDto?> GetUserByIdAsync(int userId);
        Task<AdminUserDto?> UpdateUserAsync(int userId, UserUpdateDto updateDto);
        Task<bool> DeleteUserAsync(int userId);
        Task<UserFormulariosDto?> GetUserFormulariosAsync(int userId);
    }
}
