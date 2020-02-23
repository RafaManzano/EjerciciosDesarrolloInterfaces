using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_DAL.Connection
{
    public class clsMyConnection
    {
        public static string getUriBase()
        {
            String uriBase = "http://webapiaemet.azurewebsites.net/api/";
            return uriBase;
        }
    }
}
