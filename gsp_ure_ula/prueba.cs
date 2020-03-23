using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gsp_ure_ula
{
    class conexion : BACKEND.GRAPHQL.resolver
    {
        public static void conectar()
        {
            gsp_ure_ula.BACKEND.services.begin();
            
        }


        


    }
}
