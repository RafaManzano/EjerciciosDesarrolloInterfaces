using _18_EventoCommands.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_EventoCommands.Utilities
{
    public class clsListadosPersonas
    {
        public static ObservableCollection<clsPersona> listadoPersonas()
        {
            ObservableCollection<clsPersona> listado = new ObservableCollection<clsPersona>();
            listado.Add(new clsPersona("Rafael Manuel", "Manzano", "Medina", DateTime.Now));
            listado.Add(new clsPersona("Victor Manuel", "Perez", "Lobato", DateTime.Now));
            listado.Add(new clsPersona("Yeray Manuel", "Campanario", "Fernandez", DateTime.Now));
            listado.Add(new clsPersona("Pablo Manuel", "Prats", "Jimenez", DateTime.Now));
            listado.Add(new clsPersona("Daniel Manuel", "Gordillo", "Rodriguez", DateTime.Now));
            return listado;
        }
    }
}
