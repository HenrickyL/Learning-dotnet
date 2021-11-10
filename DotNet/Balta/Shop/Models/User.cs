using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="[User] campo obrigatório!")]
        [MaxLength(15,ErrorMessage ="[User] out of Range 3-15 characters!")]
        [MinLength(3,ErrorMessage ="[User] out of Range 3-15 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage ="[User] campo obrigatório!")]
        [MaxLength(12,ErrorMessage ="[User] Password out of Range 8-12 characters!")]
        [MinLength(6,ErrorMessage ="[User] Password out of Range 8-12 characters!")]
        public string Password { get; set; }

        public string Role { get; set; }

    }
}