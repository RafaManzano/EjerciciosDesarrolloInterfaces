using _25_ExamenAvengers_DAL.Handlers;
using _25_ExamenAvengers_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_BL.Handlers
{
    public class clsManejadorasBL
    {
        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="mision">La mision a actualizar</param>
        public void actualizarMision(clsMisiones mision)
        {
            clsManejadoraDAL bbdd = new clsManejadoraDAL();
            bbdd.actualizarMision(mision);
        }
    }
}
