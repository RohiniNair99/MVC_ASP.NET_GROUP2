using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AskMeBL;
using AskMeDTO;

namespace AskMeAPI.Models
{
    public class Profile
    {
        [Display(Name = "Your Name")]
        public string UserName { get; set; }
        [Display(Name = "EmailId")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string UEmail { get; set; }
        [Display(Name = "Your Age")]
        public string UAge { get; set; }
        public int UserId { get; set; }
    }
}