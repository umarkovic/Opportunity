using Cassandra.Mapping;
using OpportunITyy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpportunITyy.Data
{
    public class MyMappings : Mappings
    {
        public MyMappings()
        {
            // Define mappings in the constructor of your class
            // that inherits from Mappings
            For<User>()
               .TableName("user")
               .PartitionKey(u => u.Email);
            For<Firm>()
                .TableName("firm")
                .PartitionKey(f => f.Email);
            For<Ad>()
                .TableName("ad")
                .PartitionKey(m => m.EmailFirm);
            For<User_ads_history>()
                .TableName("user_ads_history")
                .PartitionKey(m => m.email);
            For<Ads_by_firm>()
                .TableName("ads_by_firm")
                .PartitionKey(m => m.email);
            For<Firm_applied_users>()
                .TableName("firm_applied_users")
                .PartitionKey(m => m.IdAd);
            For<Ads_user_applied>()
                .TableName("ads_user_appllyed")
                .PartitionKey(m => m.Email);
            

            
        }
    }
}
