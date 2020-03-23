using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsp_ure_ula.BACKEND
{
    public class services
    {
        public static void begin()
        {
            begin_graphql();
        }

        private static void begin_graphql()
        {
            var graphql = new GRAPHQL.graphql_service();
        }

    }
}
