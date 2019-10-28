using _15_BindingVM_Ejercicio3_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BindingVM_Ejercicio3_UI.Models.Utiles
{
    public class clsListadosPersonas
    {
        public static List<clsPersona>  listadoPersonas()
        {
            List<clsPersona> listado = new List<clsPersona>();
            listado.Add(new clsPersona("Rafael Manuel", "Manzano", "Medina", DateTime.Now));
            listado.Add(new clsPersona("Victor Manuel", "Perez", "Lobato", DateTime.Now));
            listado.Add(new clsPersona("Yeray Manuel", "Campanario", "Fernandez", DateTime.Now));
            listado.Add(new clsPersona("Pablo Manuel", "Prats", "Jimenez", DateTime.Now));
            listado.Add(new clsPersona("Daniel Manuel", "Gordillo", "Rodriguez", DateTime.Now));
            return listado;
        }
    }
}
