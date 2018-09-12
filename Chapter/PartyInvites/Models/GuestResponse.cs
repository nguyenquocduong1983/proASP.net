using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invaid Email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool ? WillAttend { get; set; }

    }
}