using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CRUDSuperHero_ENTITIES
{
    public class clsCompanhia
    {
        public clsCompanhia()
        {
            ID = 0;
            Nombre = "";
        }

        public clsCompanhia(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public int ID { get; set; }
        public String Nombre { get; set; }
    }
}
