using _25_ExamenAvengers_DAL.Lists;
using _25_ExamenAvengers_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_BL.Lists
{
    public class clsListadosSuperheroeBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Superheroes</returns>
        public List<clsSuperheroe> listadoSuperheroes()
        {
            clsListadosSuperheroesDAL list = new clsListadosSuperheroesDAL();
            return list.listadoSuperheroes();
        }
    }
}
