using _18_EventoCommands.Models;
using _18_EventoCommands.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace _18_EventoCommands.ViewModels
{
    public class clsMainPageVM
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersona;
        private DelegateCommand eliminarComando;

        public clsMainPageVM()
        {
            this.listadoPersona = clsListadosPersonas.listadoPersonas();
            //eliminarComando = new DelegateCommand(Eliminar);
        }

        public clsPersona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                this.personaSeleccionada = value;
            }
        }


        public ObservableCollection<clsPersona> ListadoPersona
        {
            get
            {
                return listadoPersona;
            }
            set
            {
                listadoPersona = value;
            }

        }

        public DelegateCommand EliminarComando
        {
            get
            {
                //return eliminarComando = new DelegateCommand(new Action(Eliminar()));
            }
        }

        public void Eliminar()
        {
            listadoPersona.Remove(personaSeleccionada);
        }

    }
}
