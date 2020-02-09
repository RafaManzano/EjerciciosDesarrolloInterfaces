using System;
using System.Collections.Generic;
using System.Text;

namespace _30_XamarinCrudPersonas_DAL.Connection
{
    public class clsMyConnection
    {
        public static string getUriBase()
        {
            String uriBase = "https://crudtoflamaapi.azurewebsites.net/api";
            return uriBase;
        }
    }
}
