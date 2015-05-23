using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AwarenessGrows.Web.Models
{
    public class ContactInfoViewModel
    {
        [Display (Name="Two Letter State Code")]
        [StringLength(2,MinimumLength=2)]
        public string State { get; set;  }

        [Display(Name="5 Digit ZipCode")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }
    }
}