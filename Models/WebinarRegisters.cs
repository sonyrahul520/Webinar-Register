using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webinar_Register.Models
{
    public class WebinarRegisters
    {
        
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }

        public bool? WillJoin { get; set; }
    }
}
