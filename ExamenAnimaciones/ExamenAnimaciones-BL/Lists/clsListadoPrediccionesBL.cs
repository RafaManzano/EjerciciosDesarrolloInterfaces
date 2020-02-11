using ExamenAnimaciones_DAL.Lists;
using ExamenAnimaciones_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAnimaciones_BL.Lists
{
    public class clsListadoPrediccionesBL
    {
        public async Task<List<clsPrediccion>> listadoPredicciones(int idCiudad)
        {
            clsListadoPrediccionesDAL listBBDD = new clsListadoPrediccionesDAL();
            List<clsPrediccion> listado = await listBBDD.listadoPredicciones(idCiudad);
            return listado;
        }
    }
}
