namespace BlogSystem.API.Models.Dtos
{
    using System.ComponentModel.DataAnnotations;

    namespace BlogSystem.API.Models.DTOs
    {
        public class CreateBlogPostDto
        {
            [Required]
            [StringLength(200)]
            public string Title { get; set; } = string.Empty;

            [Required]
            public string Content { get; set; } = string.Empty;
        }
    }
}
