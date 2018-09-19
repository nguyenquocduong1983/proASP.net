using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invaid Email")]
        [Required(ErrorMessage ="please enter your email")]
       // [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Required(ErrorMessage = "please enter your name")]
        public string Phone { get; set; }
        public bool ? WillAttend { get; set; }

    }
}