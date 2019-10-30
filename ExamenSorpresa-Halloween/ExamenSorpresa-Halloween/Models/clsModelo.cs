using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSorpresa_Halloween.Models
{
    class clsModelo
    {
        public clsModelo()
        {
            ID = 0;
            Modelo = "Vacio";
            IDMarca = 0;
        }

        public clsModelo(int id, string modelo, int idMarca)
        {
            ID = id;
            Modelo = modelo;
            IDMarca = idMarca;
        }
        public int ID { get; set; }
        public String Modelo { get; set; }
        public int IDMarca { get; set; }
    }
}
