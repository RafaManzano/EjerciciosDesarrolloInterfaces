using ExamenAnimaciones_DAL.Lists;
using ExamenAnimaciones_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_BL.Lists
{
    public class clsListadoCiudadesBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de ciudades List<clsCiudad></returns>
        public async Task<List<clsCiudad>> listadoCiudades()
        {
            clsListadoCiudades listBBDD = new clsListadoCiudades();
            List<clsCiudad> listado = await listBBDD.listadoCiudades();
            return listado;
        }
    }
}
