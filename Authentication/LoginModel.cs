using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candidate_Evaluation.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "UserName Required")]
        public string UserName { get; set; }

       

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
    }
}
