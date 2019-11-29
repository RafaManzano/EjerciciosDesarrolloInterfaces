using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_AjedrezVengadores_ENTITIES
{
    public class clsCasilla
    {
        public clsCasilla()
        {
            Equis = 0;
            YGriega = 0;
            Pieza = new clsPieza();
            Imagen = new Uri("ms-appx:///Assets/cuadrado.png");
        }

        public clsCasilla(int x, int y, clsPieza pieza, Uri s)
        {
            Equis = x;
            YGriega = y;
            Pieza = pieza;
            Imagen = s;
        }

        public int Equis { get; set; }
        public int YGriega { get; set; }
        public clsPieza Pieza { get; set; }
        public Uri Imagen { get; set; }
    }
}
