using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_BuscaminasSoso.Models
{
    class clsCasilla
    {
        public clsCasilla()
        {
            ID = 1;
            Imagen = new Uri("ms-appx:///Assets/cda.png");
            IsBomba = false;
        }

        public clsCasilla(int id, Uri imagen, Boolean isBomba)
        {
            ID = id;
            Imagen = imagen;
            IsBomba = isBomba;
        }
        public int ID { get; set; }
        public Uri Imagen { get; set; }
        public Boolean IsBomba { get; set; }
    }
}
