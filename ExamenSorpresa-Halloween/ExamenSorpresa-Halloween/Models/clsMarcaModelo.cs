using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSorpresa_Halloween.Models
{
    class clsMarcaModelo
    {
        public clsMarcaModelo()
        {
            
        }
        public clsMarcaModelo(clsMarca marca, List<clsModelo> modelos)
        {
            Marca = marca;
            Modelos = modelos;
        }
        
        public clsMarca Marca { get; set; }
        public List<clsModelo> Modelos {get; set;}
    }
}
