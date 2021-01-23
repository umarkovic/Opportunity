using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Ads_user_applied
    {
        public string Email { get; set; }
        public DateTimeOffset Time { get; set; }
        public Guid IdAd { get; set; }
        public string TypeOfJob { get; set; }
    }
}
