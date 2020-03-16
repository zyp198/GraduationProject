using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElectricSys.Models.UserViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public bool IsRemembered { get; set; }
    }
}