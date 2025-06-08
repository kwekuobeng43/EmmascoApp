using System.ComponentModel.DataAnnotations;

namespace EmmascoTravelsApp1.Models
{
    public class LoginServiceDt
    {

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }


        public string Password { get; set; }

    }
}

