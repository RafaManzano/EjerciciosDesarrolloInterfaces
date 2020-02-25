using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinCrudPersonasDAL.Lists;
using XamarinCrudPersonasENTITIES;

namespace XamarinCrudPersonasBL.Lists
{
    public class clsListadoPersonaBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de personas List<clsPersona></returns>
        public async Task<List<clsPersona>> listadoPersonas()
        {
            clsListadoPersonaDAL listBBDD = new clsListadoPersonaDAL();
            Task<List<clsPersona>> l = listBBDD.listadoPersona();
            List<clsPersona> listado = await listBBDD.listadoPersona();
            return listado;
        }
    }
}
