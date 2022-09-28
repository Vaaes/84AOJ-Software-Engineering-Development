using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace _84AOJ.Application.Request
{
    public class LogInRequest
    {
    

        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
