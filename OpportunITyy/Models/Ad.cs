using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Ad
    {
        public string  EmailFirm { get; set; }
        public Guid IdAd { get; set; }
        [Required (ErrorMessage = "This field is required")]
        public List<string> Technologies { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string TypeOfJob { get; set; }
        public string City { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Seniority { get; set; }
        public DateTimeOffset AdSetted { get; set; }
        public string TypeOfWork { get; set; }
        public bool OnlineInterView { get; set; }
        public bool ActiveStatus { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please upload CV")]
        public IFormFile file { get; set; }
        public List<Firm_applied_users> AppliedUsers { get; set; }

    }
}
