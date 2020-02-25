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
    public class clsListadoPersonaDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de las personas
        /// </summary>
        /// <returns>Listado de personas List<clsPersona></returns>
        public async Task<List<clsPersona>> listadoPersona()
        {
            List<clsPersona> listado = new List<clsPersona>();
            HttpClient miCliente = new HttpClient();

            Uri requestUri = new Uri(clsMyConnection.getUriBase() + "/Persona");

            //Send the GET request asynchronously and retrieve the response as a string.
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            string httpResponseBody = "";

            try
            {

                httpResponse = await miCliente.GetAsync(requestUri);

                if (httpResponse.IsSuccessStatusCode)
                {
                    httpResponseBody = await miCliente.GetStringAsync(requestUri);
                    listado = JsonConvert.DeserializeObject<List<clsPersona>>(httpResponseBody);
                }


            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }

            return listado;

        }

       
    }
}
