using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_AjedrezVengadores_ENTITIES
{
    public class clsPieza
    {
        public clsPieza()
        {
            Personaje = 'O';
            Blanco = true;
        }

        public clsPieza(Char p, bool b)
        {
            Personaje = p;
            Blanco = b;
        }

        public Char Personaje { get; set; }
        public bool Blanco { get; set; }
        
    }
}
