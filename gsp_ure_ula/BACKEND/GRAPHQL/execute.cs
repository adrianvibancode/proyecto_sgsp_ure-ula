using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace gsp_ure_ula.BACKEND.GRAPHQL
{
    static class execute
    {
        public static void schema(ISchema typeDefinition,object root)
        {
            var schema = typeDefinition;

            var json = schema.Execute(_ =>
            {

                _.Query = "{ test, greet}";
                _.Root = root;

            });

            Console.WriteLine(json);
        }
    }
}
