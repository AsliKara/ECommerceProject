using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceProject.UI.Web.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
