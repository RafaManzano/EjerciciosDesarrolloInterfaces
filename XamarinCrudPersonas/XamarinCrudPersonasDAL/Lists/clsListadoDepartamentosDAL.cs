using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Connection;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasDAL.Lists
{
    public class clsListadoDepartamentosDAL
    {
        /// <summary>
        /// Con este metodo devolvemos la lista de departamentos de la BBDD
        /// que hay en la BBDD
        /// </summary>
        /// <returns>La lista de departamentos</returns>
        public async Task<List<clsDepartamento>> listadoDepartamentos()
        {
            List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>();
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(clsMyConnection.getUriBase() + "Departamento");
            try
            {
                HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);
                if (responseMessage.IsSuccessStatusCode)
                {
                    string peticion = await httpClient.GetStringAsync(uri);
                    listadoDepartamentos = JsonConvert.DeserializeObject<List<clsDepartamento>>(peticion);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return listadoDepartamentos;
        }
    }
}
