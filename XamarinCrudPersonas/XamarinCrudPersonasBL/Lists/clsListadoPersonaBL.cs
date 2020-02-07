using _30_XamarinCrudPersonas_DAL.Lists;
using _30_XamarinCrudPersonas_ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _30_XamarinCrudPersonas_BL.Lists
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
            List<clsPersona> listado = await listBBDD.listadoPersona();
            return listado;
        }
    }
}
