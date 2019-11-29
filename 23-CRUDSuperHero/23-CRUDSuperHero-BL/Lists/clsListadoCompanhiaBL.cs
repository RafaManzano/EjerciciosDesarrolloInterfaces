using _23_CRUDSuperHero_DAL.Lists;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_BL.Lists
{
    public class clsListadoCompanhiaBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>Eli listado de Companhias</returns>
        public List<clsCompanhia> listadoCompanhias()
        {
            clsListadoCompanhiaDAL list = new clsListadoCompanhiaDAL();
            return list.listadoCompanhia();
        }
    }
}
