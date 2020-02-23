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
    public class clsListadoPrediccionesDAL
    {
        
        /// <summary>
        /// Con este metodo recogemos las predicciones de una ciudad pasada como parametro
        /// </summary>
        /// <param name="idCiudad">El id de la ciudad a buscar</param>
        /// <returns>El listado de predicciones de esa ciudad</returns>
        public async Task<List<clsPrediccion>> listadoPredicciones(int idCiudad)
        {
            List<clsPrediccion> listado = new List<clsPrediccion>();
            HttpClient miCliente = new HttpClient();

            Uri requestUri = new Uri(clsMyConnection.getUriBase() + "prediccion/" + idCiudad);
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
                    listado = JsonConvert.DeserializeObject<List<clsPrediccion>>(httpResponseBody);
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
