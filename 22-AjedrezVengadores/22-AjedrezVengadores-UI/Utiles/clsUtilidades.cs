using _22_AjedrezVengadores_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_AjedrezVengadores_UI.Utiles
{
    public class clsUtilidades
    {
        /// <summary>
        /// Funcion que devuelve el listado con el tablero completo
        /// </summary>
        /// <returns>Devuelve un listado con la composicion del tablero</returns>
        public static List<clsCasilla> crearTablero()
        {
            List<clsCasilla> tablero = new List<clsCasilla>();
            tablero.Add(new clsCasilla(0, 0, new clsPieza('H', true), new Uri("ms-appx:///Assets/hulk.jpg")));
            tablero.Add(new clsCasilla(1, 0, new clsPieza('S', true), new Uri("ms-appx:///Assets/spiderman.jpg")));
            tablero.Add(new clsCasilla(2, 0, new clsPieza('I', true), new Uri("ms-appx:///Assets/ironman.jpg")));
            tablero.Add(new clsCasilla(3, 0, new clsPieza('D', true), new Uri("ms-appx:///Assets/doctorstrange.jpg")));
            tablero.Add(new clsCasilla(4, 0, new clsPieza('G', true), new Uri("ms-appx:///Assets/groot.jpg")));
            tablero.Add(new clsCasilla(5, 0, new clsPieza('C', true), new Uri("ms-appx:///Assets/capitanamerica.jpg")));

            tablero.Add(new clsCasilla(0, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(1, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(2, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(3, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(4, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(5, 1, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));

            tablero.Add(new clsCasilla(0, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(1, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(2, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(3, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(4, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(5, 2, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));

            tablero.Add(new clsCasilla(0, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(1, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(2, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(3, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(4, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(5, 3, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));

            tablero.Add(new clsCasilla(0, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(1, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(2, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(3, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(4, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));
            tablero.Add(new clsCasilla(5, 4, new clsPieza(), new Uri("ms-appx:///Assets/cuadrado.png")));


            tablero.Add(new clsCasilla(0, 5, new clsPieza('H', true), new Uri("ms-appx:///Assets/hulk.jpg")));
            tablero.Add(new clsCasilla(1, 5, new clsPieza('S', true), new Uri("ms-appx:///Assets/spiderman.jpg")));
            tablero.Add(new clsCasilla(2, 5, new clsPieza('I', true), new Uri("ms-appx:///Assets/ironman.jpg")));
            tablero.Add(new clsCasilla(3, 5, new clsPieza('D', true), new Uri("ms-appx:///Assets/doctorstrange.jpg")));
            tablero.Add(new clsCasilla(4, 5, new clsPieza('G', true), new Uri("ms-appx:///Assets/groot.jpg")));
            tablero.Add(new clsCasilla(5, 5, new clsPieza('C', true), new Uri("ms-appx:///Assets/capitanamerica.jpg")));

            return tablero;
        }
    }
}
