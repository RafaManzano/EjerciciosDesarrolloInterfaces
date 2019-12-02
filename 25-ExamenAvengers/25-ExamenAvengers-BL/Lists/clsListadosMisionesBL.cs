using _25_ExamenAvengers_DAL.Lists;
using _25_ExamenAvengers_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_BL.Lists
{
    public class clsListadosMisionesBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Misiones disponibles</returns>
        public List<clsMisiones> listadoMisionesDisponibles()
        {
            clsListadosMisionesDAL list = new clsListadosMisionesDAL();
            return list.listadoMisionesDisponibles();
        }
    }
}
