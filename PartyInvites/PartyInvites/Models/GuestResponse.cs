using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse : Controller
    {
        [Required(ErrorMessage = "Proszę podać imię i nzawisko")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać adres email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Proszę podać prawidłowy email.")]
        public string Email { get; set; }
        
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę określić czy przyjdziesz.")]
        public bool? WillAttend { get; set; }
    }
}