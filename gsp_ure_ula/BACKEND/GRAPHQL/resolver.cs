using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;



namespace gsp_ure_ula.BACKEND.GRAPHQL
{
    public abstract class resolver
    {
        public resolver()
        {

        }

        protected static void Resolver()
        {
            //Execution  
            var root = new { test = "test ok" , greet="fast"};        
            
        }

    }

}
