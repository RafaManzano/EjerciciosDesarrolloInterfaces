using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCrudPersonasDAL.Connection
{
    public class clsMyConnection
    {
        public static string getUriBase()
        {
            String uriBase = "https://crudtoflamaapi.azurewebsites.net/api/";
            return uriBase;
        }
    }
}
