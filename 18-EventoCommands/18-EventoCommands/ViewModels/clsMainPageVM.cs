using _18_EventoCommands.Models;
using _18_EventoCommands.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace _18_EventoCommands.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersonaCompleta;
        private DelegateCommand eliminarComando;
        private DelegateCommand filtrarComando;
        private DelegateCommand recargarComando;
        private ObservableCollection<clsPersona> listadoPersonaFiltrada;
        private String textoBuscado;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public clsMainPageVM()
        {
            this.listadoPersonaCompleta = clsListadosPersonas.listadoPersonas();
            this.listadoPersonaFiltrada = clsListadosPersonas.listadoPersonas();
            eliminarComando = new DelegateCommand(Eliminar, () => personaSeleccionada != null);
            filtrarComando = new DelegateCommand(Filtrar, () => !String.IsNullOrEmpty(textoBuscado));
        }

        public clsPersona PersonaSeleccionada
        {
            get
            {
                //eliminarComando.CanExecute(personaSeleccionada != null);
                return personaSeleccionada;
            }
            set
            {
                this.personaSeleccionada = value;
                eliminarComando.RaiseCanExecuteChanged();
                //eliminarComando.CanExecute(personaSeleccionada);
            }
        }


        public ObservableCollection<clsPersona> ListadoPersonaCompleta
        {
            get
            {
                return listadoPersonaCompleta;
            }
            set
            {
                listadoPersonaCompleta = value;
            }

        }


        public DelegateCommand EliminarComando
        {
            get
            {
                return eliminarComando;
            }
        }

        public DelegateCommand FiltrarComando
        {
            get
            {
                return filtrarComando;
            }
        }


        public void Eliminar()
        {
            listadoPersonaCompleta.Remove(personaSeleccionada);
        }

        public void Filtrar()
        {
            ObservableCollection<clsPersona> list = new ObservableCollection<clsPersona>(ListadoPersonaFiltrada.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado)).ToList<clsPersona>());
            //ListadoPersonaFiltrada = ListadoPersonaFiltrada.ToList().FindAll(a => a.Nombre.Contains(TextoBuscado));
            ListadoPersonaFiltrada = list;
            
        }

        public String TextoBuscado
        {
            get
            {
                return textoBuscado;
            }

            set
            {
                this.textoBuscado = value;
                filtrarComando.Execute(null);
                filtrarComando.RaiseCanExecuteChanged();
                NotifyPropertyChanged("ListadoPersonaFiltrada");
            }
        }

        public ObservableCollection<clsPersona> ListadoPersonaFiltrada
        {
            get
            {
                return listadoPersonaFiltrada;
            }
            set
            {
                listadoPersonaFiltrada = value;
            }

        }

    }
}
