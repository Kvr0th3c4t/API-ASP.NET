using BlogSystem.API.Data;
using BlogSystem.API.Models;
using BlogSystem.API.Models.Dtos.BlogSystem.API.Models.DTOs;
using BlogSystem.API.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BlogSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _context.BlogPosts
                .Include(bp => bp.User)
                .OrderByDescending(bp => bp.CreatedAt)
                .Select(bp => new
                {
                    bp.Id,
                    bp.Title,
                    bp.Content,
                    bp.CreatedAt,
                    Author = bp.User.Username
                })
                .ToListAsync();

            return Ok(posts);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreatePost(CreateBlogPostDto createPostDto)
        {
            // Debug: Verificar claims del usuario
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            var roleClaim = User.FindFirst(ClaimTypes.Role);

            if (userIdClaim == null)
            {
                return Unauthorized("No se encontró el ID del usuario en el token");
            }

            if (roleClaim == null || roleClaim.Value != "admin")
            {
                return Unauthorized($"Rol actual: {roleClaim?.Value ?? "null"}, se requiere: admin");
            }

            var userId = int.Parse(userIdClaim.Value);

            var blogPost = new BlogPost
            {
                Title = createPostDto.Title,
                Content = createPostDto.Content,
                UserId = userId
            };

            _context.BlogPosts.Add(blogPost);
            await _context.SaveChangesAsync();

            var createdPost = await _context.BlogPosts
                .Include(bp => bp.User)
                .Where(bp => bp.Id == blogPost.Id)
                .Select(bp => new
                {
                    bp.Id,
                    bp.Title,
                    bp.Content,
                    bp.CreatedAt,
                    Author = bp.User.Username
                })
                .FirstOrDefaultAsync();

            return Ok(createdPost);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _context.BlogPosts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.BlogPosts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}