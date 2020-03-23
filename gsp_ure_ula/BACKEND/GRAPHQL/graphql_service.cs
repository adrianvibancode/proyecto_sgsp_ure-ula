using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


using GraphQL.Types;

namespace gsp_ure_ula.BACKEND.GRAPHQL
{
    class graphql_service : GRAPHQL.resolver
    {
        public graphql_service()
        {
            _run();
        }

        private void _run()
        {
            //Data definition
            SchemaDefinition("test: String, greet:String");
        }

        private static void SchemaDefinition(String datatypesinput)
        {
            var typeDefinition = Schema.For(
                               @"type Query {" + datatypesinput + "}");
            Resolver();
            execute.schema(typeDefinition,root);
        }

        
    }


    //class queryGraphql
    //{
    //    public class Query
    //    {
    //        [GraphQLMetadata("hello")]
    //        public string GetHello()
    //        {
    //            Console.WriteLine("oK");
    //            return db.getHello();
    //        }
    //    }
    //}

    //static class db
    //{
    //    internal static string getHello()
    //    {
    //        return "helloDB";
    //    }
    //}

}
