using _23_CRUDSuperHero_DAL.Lists;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_BL.Lists
{
    public class clsListadoSuperheroBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Superheroes</returns>
        public List<clsSuperhero> listadoSuperheroes()
        {
            clsListadoSuperheroDAL list = new clsListadoSuperheroDAL();
            return list.listadoSuperheroes();
        }

        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Superheroes por ID de Companhia</returns>
        public List<clsSuperhero> listadoSuperheroesporCompanhia(Int16 idCompanhia)
        {
            clsListadoSuperheroDAL list = new clsListadoSuperheroDAL();
            return list.listadoSuperheroesPorIDCompanhia(idCompanhia);
        }
    }
}
