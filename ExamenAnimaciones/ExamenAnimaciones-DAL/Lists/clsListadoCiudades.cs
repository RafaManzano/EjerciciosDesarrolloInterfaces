using ExamenAnimaciones_DAL.Connection;
using ExamenAnimaciones_ENTITIES;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_DAL.Lists
{
    public class clsListadoCiudades
    {
        /// <summary>
        /// Con este metodo se recoge todas las ciudades de la api
        /// </summary>
        /// <returns>Devuelve una tarea con el listado de ciudades</returns>
        public async Task<List<clsCiudad>> listadoCiudades()
        {
            List<clsCiudad> listado = new List<clsCiudad>();
            HttpClient miCliente = new HttpClient();

            Uri requestUri = new Uri(clsMyConnection.getUriBase() + "ciudades");
            //Uri requestUri = new Uri(clsMyConnection.getUriBase() + "/Persona");

            //Send the GET request asynchronously and retrieve the response as a string.
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            string httpResponseBody = "";

            try
            {

                httpResponse = await miCliente.GetAsync(requestUri);

                if (httpResponse.IsSuccessStatusCode)
                {
                    httpResponseBody = await miCliente.GetStringAsync(requestUri);
                    listado = JsonConvert.DeserializeObject<List<clsCiudad>>(httpResponseBody);
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
