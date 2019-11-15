using _19_CRUDPersonasCompletoUWP_BL.Lists;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace _19_CRUDPersonasCompletoUWP_UI.ModelViews
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private clsPersona personaSeleccionada;
        private ObservableCollection<clsPersona> listadoPersonaCompleta;
        private DelegateCommand eliminarComando;
        private DelegateCommand filtrarComando;
        private DelegateCommand recargarComando;
        private ObservableCollection<clsPersona> listadoPersonaFiltrada;
        private String textoBuscado;
        private clsListadoPersonasBL bbdd = new clsListadoPersonasBL();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageVM()
        {
            this.listadoPersonaCompleta = new ObservableCollection<clsPersona>(bbdd.listadoPersonas());
            //this.listadoPersonaFiltrada = bbdd.listadoPersonas();
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
                NotifyPropertyChanged("PersonaSeleccionada");
                //eliminarComando.RaiseCanExecuteChanged();
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


        public async void Eliminar()
        {
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "¿Estas seguro que quiere eliminar?",
                PrimaryButtonText = "Aceptar",
                SecondaryButtonText = "Cancelar",
                DefaultButton = ContentDialogButton.Secondary
            };

            ContentDialogResult result = await subscribeDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                listadoPersonaFiltrada.Remove(personaSeleccionada);
            }
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
