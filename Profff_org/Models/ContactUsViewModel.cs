using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Profff_org.Models
{
    public class ContactUsViewModel
    {

        [DisplayName("Naam en Voornaam")]
        public string Fullname { get; set; }

        [DisplayName("Emailadres")]
        public string Email { get; set; }

        [DisplayName("Telefoon")]
        public string Phone { get; set; }

        [DisplayName("Onderwerp")]
        public string Subject { get; set; }

        [DisplayName("Bericht")]
        public string Message { get; set; }

        public string TargetPage { get; set; }
    }
}