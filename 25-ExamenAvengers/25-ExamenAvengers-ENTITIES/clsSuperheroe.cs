using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExamenAvengers_ENTITIES
{
    public class clsSuperheroe
    {
        public clsSuperheroe()
        {
            IDSuperheroe = 0;
            NombreSuperheroe = "Nadie";
        }

        public clsSuperheroe(int id, string nombre)
        {
            IDSuperheroe = id;
            NombreSuperheroe = nombre;
        }

        public int IDSuperheroe { get; set; }
        public string NombreSuperheroe { get; set; }
        
    }
}
