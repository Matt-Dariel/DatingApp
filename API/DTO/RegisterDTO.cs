using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class RegisterDTO
    {
        
        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}