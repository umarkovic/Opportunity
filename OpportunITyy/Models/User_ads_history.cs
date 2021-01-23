using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Models
{
    public class User_ads_history
    {
        public string email { get; set; }
        public DateTimeOffset time { get; set; }
        public Guid idad { get; set; }
        public string typeofjob { get; set; }
    }
}
