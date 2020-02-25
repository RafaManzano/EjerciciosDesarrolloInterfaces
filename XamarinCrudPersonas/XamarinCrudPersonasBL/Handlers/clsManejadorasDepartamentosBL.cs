using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Handlers;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasBL.Handlers
{
    public class clsManejadorasDepartamentosBL
    {
        /// <summary>
        /// Intermediario entre la capa DAL y la UI
        /// </summary>
        /// <param name="id">El id del departamento a buscar</param>
        /// <returns>El departamento</returns>
        public async Task<clsDepartamento> obtenerDepartamentoPorID(int id)
        {
            clsManejadorasDepartamento capaDAL = new clsManejadorasDepartamento();
            return await capaDAL.obtenerDepartamentoPorID(id);
        }
    }
}
