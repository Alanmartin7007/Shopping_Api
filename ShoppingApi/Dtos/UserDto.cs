using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Dtos
{
    public class UserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
