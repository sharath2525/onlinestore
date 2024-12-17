using System.ComponentModel.DataAnnotations;

namespace onlinestore.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
