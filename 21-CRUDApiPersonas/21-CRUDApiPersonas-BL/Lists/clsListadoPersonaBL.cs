using _21_CRUDApiPersonas_DAL.Lists;
using _21_CRUDApiPersonas_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_CRUDApiPersonas_BL.Lists
{
    public class clsListadoPersonaBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de personas List<clsPersona></returns>
        public async Task<List<clsPersona>> listadoPersonas()
        {
            clsListadoPersonasDAL listBBDD = new clsListadoPersonasDAL();
            Task<List<clsPersona>> l = listBBDD.listadoPersona();
            List<clsPersona> listado =  await listBBDD.listadoPersona();
            return listado;
        }
    }
}
