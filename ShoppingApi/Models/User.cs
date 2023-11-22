using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Role Role { get; set; }
    }
}
