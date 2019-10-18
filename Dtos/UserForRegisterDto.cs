using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FosstechInvoice.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }


        [Required]
        [StringLength(8, ErrorMessage = "You must specify password between 4 and 8")]
        public string Password { get; set; }
    }
}
