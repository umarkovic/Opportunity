using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Firm_applied_users
    {
        public Guid IdAd { get; set; }
        public string Email { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string TypeOfJob { get; set; }
        public DateTimeOffset Time { get; set; }
        public string CvPath { get; set; }
    }
}
