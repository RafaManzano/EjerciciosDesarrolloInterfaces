using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Connection;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasDAL.Handlers
{
    public class clsManejadorasDepartamento
    {
        /// <summary>
        /// Con este metodo se obtiene el departamento por la id pasada como parametro
        /// </summary>
        /// <param name="id">La id del departamento a buscar</param>
        /// <returns>Devuelve una tarea con el departamento</returns>
        public async Task<clsDepartamento> obtenerDepartamentoPorID(int id)
        {
            clsDepartamento departamento = new clsDepartamento();
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = new HttpResponseMessage();

            try
            {
                responseMessage = await client.GetAsync(clsMyConnection.getUriBase() + "Departamento");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (responseMessage.IsSuccessStatusCode)
            {
                string d = await responseMessage.Content.ReadAsStringAsync();
                departamento = JsonConvert.DeserializeObject<clsDepartamento>(d);
            }

            return departamento;
        }
    }
}
