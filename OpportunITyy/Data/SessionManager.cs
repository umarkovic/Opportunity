
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cassandra;

namespace OpportunITyy.Data
{
    public class SessionManager
    {


        public static ISession session;

        public static ISession GetSession()
        {
            if (session == null)
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                session = cluster.Connect("opportunity");
            }

            return session;
        }

    }





}