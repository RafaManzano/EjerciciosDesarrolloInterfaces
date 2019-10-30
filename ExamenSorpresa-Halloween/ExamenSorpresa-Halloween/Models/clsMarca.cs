using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSorpresa_Halloween.Models
{
    class clsMarca
    {
        public clsMarca()
        {
            ID = 0;
            Marca = "Vacio";
        }

        public clsMarca(int id, string marca)
        {
            ID = id;
            Marca = marca;
        }
        public int ID { get; set; }
        public String Marca { get; set; }
    }
}
