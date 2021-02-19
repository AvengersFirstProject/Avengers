using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFlixlngAvengers.Requests
{
    public class CustomerRequest
    {
        
        
            [Required(ErrorMessage = "Enter FirstName")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Enter LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter MobileNumber")]
        public int MobileNumber { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Password")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Enter ConfirmPassword")]
        public string ConfirmPassword { get; set; }
       
    }
    
}
