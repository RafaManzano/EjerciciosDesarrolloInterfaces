using _17_EventoSinCommands.Models;
using _17_EventoSinCommands.Utiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace _17_EventoSinCommands.ViewModels
{
    public class clsMainPageVM
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersona;

        public clsMainPageVM()
        {
            this.listadoPersona = clsListadosPersonas.listadoPersonas();
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

        public void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            listadoPersona.Remove(personaSeleccionada);
        }


    }
}

