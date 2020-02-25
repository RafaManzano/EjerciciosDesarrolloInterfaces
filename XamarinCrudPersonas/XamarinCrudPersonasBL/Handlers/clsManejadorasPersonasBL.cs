using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Handlers;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasBL.Handlers
{
    public class clsManejadorasPersonasBL
    {
        /// <summary>
        /// Intermediario entre la capa DAL y la UI
        /// </summary>
        /// <param name="persona">la persona a insertar</param>
        /// <returns>Una tarea con un boolean que comprueba si se ha insertado correctamente o no</returns>
        public async Task<int> crearPersona(clsPersona persona)
        {
            clsManejadorasPersona capaDAL = new clsManejadorasPersona();
            return await capaDAL.crearPersona(persona);
        }

        /// <summary>
        /// Intermediario entre la capa DAL y la UI
        /// </summary>
        /// <param name="persona">la persona a actualizar</param>
        /// <returns>Una tarea con un boolean que comprueba si se ha actualizado correctamente o no</returns>
        public async Task<int> actualizarPersona(clsPersona persona)
        {
            clsManejadorasPersona capaDAL = new clsManejadorasPersona();
            return await capaDAL.actualizarPersona(persona);
        }

        /// <summary>
        /// Intermediario entre la capa DAL y la UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Una tarea con un boolean que comprueba si se ha borrado correctamente o no</returns>
        public async Task<int> borrarPersona(int id)
        {
            clsManejadorasPersona capaDAL = new clsManejadorasPersona();
            return await capaDAL.borrarPersona(id);
        }

        /// <summary>
        /// Intermediario entre la capa DAL y la UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Una tarea con la persona a buscar por el id pasado por parametro</returns>
        public async Task<clsPersona> obtenerPersonaPorID(int id)
        {
            clsManejadorasPersona capaDAL = new clsManejadorasPersona();
            return await capaDAL.obtenerPersonaPorID(id);
        }
    }
}
