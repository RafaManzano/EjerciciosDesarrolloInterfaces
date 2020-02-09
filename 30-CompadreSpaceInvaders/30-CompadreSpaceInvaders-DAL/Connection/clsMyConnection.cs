using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_CompadreSpaceInvaders_DAL.Connection
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
