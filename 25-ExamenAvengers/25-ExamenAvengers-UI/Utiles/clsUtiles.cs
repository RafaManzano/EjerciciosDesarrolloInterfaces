using _25_ExamenAvengers_ENTITIES;
using _25_ExamenAvengers_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_UI.Utiles
{
    public class clsUtiles
    {
        /// <summary>
        /// Con este metodo convertimos el listado de Superheroes en lo que necesita nuestra vista (clsSuperheroeConFoto)
        /// </summary>
        /// <param name="superheroes">La lista de Superheroes de la BBDD</param>
        /// <returns>La lista de Superheroes con Foto</returns>
        public static List<clsSuperheroeConFoto> listadoSuperheroesConFoto(List<clsSuperheroe> superheroes)
        {
            clsSuperheroeConFoto super = new clsSuperheroeConFoto();
            List<clsSuperheroeConFoto> listSuper = new List<clsSuperheroeConFoto>();
            List<Uri> list = listadoRutasFotos();
            for(int i = 0; i < superheroes.Count; i++)
            {
                //TODO Asegurarme que cada foto se almacena correctamente en su superheroe. Al final lo he dejado asi. No me ha dado tiempo
                super = new clsSuperheroeConFoto(superheroes[i].IDSuperheroe, superheroes[i].NombreSuperheroe);
                listSuper.Add(super);
            }

            return listSuper;
        }

        /// <summary>
        /// Con este metodo tenemos la ruta de las fotos de cada superheroe
        /// </summary>
        /// <returns>La lista de las Uri de las fotos de los superheroes</returns>
        public static List<Uri> listadoRutasFotos()
        {
            //Al final no me ha dado tiempo a cambiarlo
            List<Uri> listado = new List<Uri>();
            listado.Add(new Uri("ms-appx:///Assets/1.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/2.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/3.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/4.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/5.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/6.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/7.jpg"));
            listado.Add(new Uri("ms-appx:///Assets/8.jpg"));

            return listado;
        }
    }
}
