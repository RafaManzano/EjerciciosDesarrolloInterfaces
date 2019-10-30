using ExamenSorpresa_Halloween.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSorpresa_Halloween.Utiles
{
    class clsListados
    {
        public static List<clsMarca> listadoMarcas()
        {
            List<clsMarca> list = new List<clsMarca>();
            list.Add(new clsMarca(1, "Ford"));
            list.Add(new clsMarca(2, "Renault"));
            list.Add(new clsMarca(3, "Seat"));
            return list;
        }

        public static List<clsModelo> listadoModelos()
        {
            List<clsModelo> list = new List<clsModelo>();
            list.Add(new clsModelo(1, "Fiesta",1));
            list.Add(new clsModelo(2, "Focus",1));
            list.Add(new clsModelo(3, "Kuga",1));
            list.Add(new clsModelo(1, "Clio",2));
            list.Add(new clsModelo(2, "Megane",2));
            list.Add(new clsModelo(3, "Scenic",2));
            list.Add(new clsModelo(1, "Ibiza",3));
            list.Add(new clsModelo(2, "Leon",3));
            list.Add(new clsModelo(3, "Tarraco",3));
            return list;
        }

        //public static List<clsMarca>
        
        public static List<clsModelo> listadodeModeloPorMarca(List<clsModelo> modelos, int id)
        {
            List<clsModelo> modeloID = modelos.FindAll(a => a.IDMarca == id);
            return modeloID;
        }
        
    }
}
