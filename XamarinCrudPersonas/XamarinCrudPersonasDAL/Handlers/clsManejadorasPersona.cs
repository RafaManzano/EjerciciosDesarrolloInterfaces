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
    public class clsManejadorasPersona
    {
        /// <summary>
        /// Metodo que borra una persona por su ID de la BBDD
        /// </summary>
        /// <param name="id">El ID de la persona a eliminar</param>
        /// <returns>Devuelve la tarea con un entero si la eliminacion ha sido correcta o no</returns>
        public async Task<int> borrarPersona(int id)
        {
            int eliminado = 0;
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(clsMyConnection.getUriBase() + "Persona/" + id );

            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    eliminado = 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return eliminado;
        }


        /// <summary>
        /// Creamos la persona y la introducimos en la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que introducir en la BBDD</param>
        /// <returns>Devuelve la tarea con un entero si la insercion ha sido correcta o no</returns>
        public async Task<int> crearPersona(clsPersona persona)
        {
            HttpClient client = new HttpClient();
            String json = "";
            HttpContent body;
            Uri uri = new Uri(clsMyConnection.getUriBase() + "Persona");
            int insertado = 0;

            HttpResponseMessage responseMessage = new HttpResponseMessage();

            try
            {
                json = JsonConvert.SerializeObject(persona);
                body = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                responseMessage = await client.PostAsync(uri, body);
            }
            catch (Exception e)
            {
                throw e;
            }

            if (responseMessage.IsSuccessStatusCode)
            {
                insertado = 1;
            }

            return insertado;

        }

        /// <summary>
        /// Actualizamos la persona de la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que actualizar en la BBDD</param>
        /// <returns>Devuelve la tarea con el booleano si la actualizacion ha sido correcta o no</returns>
        public async Task<int> actualizarPersona(clsPersona persona)
        {
            HttpClient client = new HttpClient();
            String json;
            HttpContent body;
            Uri uri = new Uri(clsMyConnection.getUriBase() + "Persona/" + persona.IDPersona);
            int actualizado = 0;

            HttpResponseMessage responseMessage = new HttpResponseMessage();

            try
            {
                json = JsonConvert.SerializeObject(persona);
                body = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                responseMessage = await client.PutAsync(uri, body);
                if (responseMessage.IsSuccessStatusCode)
                {
                    actualizado = 1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            

            return actualizado;

        }

        /// <summary>
        /// Con este metodo seleccionamos a una persona de la BBDD con la id pasada por parametro
        /// </summary>
        /// <param name="id">Id de la persona</param>
        /// <returns>La persona seleccionada</returns>
        public async Task<clsPersona> obtenerPersonaPorID(int id)
        {
            clsPersona persona = new clsPersona();
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = new HttpResponseMessage();

            try
            {
                responseMessage = await client.GetAsync(clsMyConnection.getUriBase() + "Persona/" + id);
            }
            catch (Exception e)
            {
                throw e;
            }

            if (responseMessage.IsSuccessStatusCode)
            {
                string p = await responseMessage.Content.ReadAsStringAsync();
                persona = JsonConvert.DeserializeObject<clsPersona>(p);
            }

            return persona;
        }
    }
}
