using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assessment.Models
{
    public class Carrier
    {
        public int CarrierID { get; set; }

        [Required]
        public string CarrierName { get; set; }

        [Required]
        public string Address { get; set; }

        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Fax { get; set; }

        [Required]
        public string Email { get; set; }
    }
}