using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Firm : Account
    {
        [Required (ErrorMessage = "This field is required")]
        public string NameOfFirm { get; set; }
        

    }
}
