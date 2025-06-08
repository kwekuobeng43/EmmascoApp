
using System.ComponentModel.DataAnnotations;

namespace EmmascoTravelsApp1.Models
{
    public class CustomerServiceDt
    {


        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
