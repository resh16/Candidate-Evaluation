using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candidate_Evaluation.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage="UserName Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Conform Password")]
        [Compare("Password")]
        public string Conform_Pwd { get; set; }
    }
}
