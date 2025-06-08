using System.ComponentModel.DataAnnotations;

namespace EmmascoTravelsApp1.Models
{
    public class LoginService
    {

        public int Id { get; set; }

        [Required]

        [MaxLength(50)]

        public string UserName { get; set; }

        [Required]

        [MaxLength(30)]
        public string Password { get; set; }

        
    }
}
