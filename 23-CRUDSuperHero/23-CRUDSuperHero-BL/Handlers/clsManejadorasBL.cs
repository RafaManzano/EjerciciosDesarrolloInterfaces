using _23_CRUDSuperHero_DAL.Handlers;
using _23_CRUDSuperHero_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_BL.Handlers
{
    public class clsManejadorasBL
    {
        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="id">El ID del superheroe a eliminar</param>
        public void borrarPersona(Int16 id)
        {
            clsManejadoas bbdd = new clsManejadoas();
            bbdd.borrarPersona(id);
        }

        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="superhero">El superheroe que se necesita comprobar si ya esta introducido en la bbdd</param>
        public bool estoyenBBDD(clsSuperhero superhero)
        {
            clsManejadoas bbdd = new clsManejadoas();
            return bbdd.estoyEnBBDD(superhero);
        }

        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="superhero">El superheroe a crear</param>
        public void crearSuperhero(clsSuperhero superhero)
        {
            clsManejadoas bbdd = new clsManejadoas();
            bbdd.crearSuperhero(superhero);
        }

        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="id">El superheroe a actualizar</param>
        public void actualizarSuperhero(clsSuperhero superhero)
        {
            clsManejadoas bbdd = new clsManejadoas();
            bbdd.actualizarSuperhero(superhero);
        }
    }
}
