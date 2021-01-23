using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class User: Account
    {
        
        public string FName { get; set; }
        public string LName { get; set; }

        //public string Skills { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public List<string> Skills { get; set; }
        [Required (ErrorMessage = "This field is required")]
        public string Education { get; set; }
        
        public IDictionary<Guid,String> AdSaved { get; set; }
        
    }
}
