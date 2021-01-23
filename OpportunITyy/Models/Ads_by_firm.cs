using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class Ads_by_firm
    {
        public string email { get; set; }
        public DateTimeOffset time { get; set; }
        public Guid idad { get; set; }
        public string typeofjob { get; set; }
    }
}
